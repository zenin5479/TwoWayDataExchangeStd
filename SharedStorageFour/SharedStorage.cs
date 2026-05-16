using Newtonsoft.Json;
using System;
using System.Diagnostics;

namespace SharedStorageFour
{
   public class StreamSharedStorage : IDisposable
   {
      private readonly Process _process;

      public StreamSharedStorage(string executablePath = "ConsoleAppFour")
      {
         _process = new Process();
         _process.StartInfo.FileName = executablePath;
         _process.StartInfo.UseShellExecute = false;
         _process.StartInfo.RedirectStandardInput = true;
         _process.StartInfo.RedirectStandardOutput = true;
         _process.StartInfo.RedirectStandardError = true;   // <-- добавить!
         _process.StartInfo.CreateNoWindow = false;
         _process.Start();
      }

      public CalculationResponse SendRequest(CalculationRequest request)
      {
         if (_process == null || _process.HasExited)
            throw new InvalidOperationException("Процесс не запущен или уже завершён");

         string requestJson = JsonConvert.SerializeObject(request);

         // Передаём запрос
         _process.StandardInput.Write(requestJson);
         _process.StandardInput.Close();

         // Читаем ответ и ошибки
         string responseJson = _process.StandardOutput.ReadToEnd();
         string errorText = _process.StandardError.ReadToEnd();
         _process.WaitForExit();

         // Если что-то попало в stderr – это скорее всего ошибка
         if (!string.IsNullOrEmpty(errorText))
            throw new Exception("Ошибка в консольном приложении: " + errorText);

         if (_process.ExitCode != 0)
            throw new Exception($"Процесс завершился с кодом {_process.ExitCode}");

         // Парсим ответ
         var response = JsonConvert.DeserializeObject<CalculationResponse>(responseJson);
         if (response == null)
            throw new Exception("Получен пустой или некорректный ответ от консольного приложения");

         return response;
      }

      public void Dispose()
      {
         if (_process != null && !_process.HasExited)
         {
            _process.Kill();
            _process.WaitForExit();
         }
         _process?.Dispose();
      }
   }
}
