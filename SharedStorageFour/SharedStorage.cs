using Newtonsoft.Json;
using System;
using System.Diagnostics;

namespace SharedStorageFour
{
   public class StreamSharedStorage : IDisposable
   {
      private readonly Process _process;

      public StreamSharedStorage(string executablePath = "Calculator.exe")
      {
         _process = new Process();
         _process.StartInfo.FileName = executablePath;
         _process.StartInfo.UseShellExecute = false;
         _process.StartInfo.RedirectStandardInput = true;
         _process.StartInfo.RedirectStandardOutput = true;
         _process.StartInfo.CreateNoWindow = true;
         _process.Start();
      }

      public CalculationResponse SendRequest(CalculationRequest request)
      {
         if (_process == null || _process.HasExited)
            throw new InvalidOperationException("Процесс не запущен или уже завершён");

         // Сериализация запроса через Newtonsoft.Json
         string requestJson = JsonConvert.SerializeObject(request);

         // Передаём в stdin и закрываем
         _process.StandardInput.Write(requestJson);
         _process.StandardInput.Close();

         // Читаем весь ответ
         string responseJson = _process.StandardOutput.ReadToEnd();
         _process.WaitForExit();

         // Десериализация ответа
         return JsonConvert.DeserializeObject<CalculationResponse>(responseJson);
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
