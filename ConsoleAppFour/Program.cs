using Newtonsoft.Json;
using System;

namespace ConsoleAppFour
{
   class Program
   {
      static void Main(string[] args)
      {
         try
         {
            string inputJson = Console.In.ReadToEnd();
            var request = JsonConvert.DeserializeObject<CalculationRequest>(inputJson);
            var response = Calculate(request);
            Console.WriteLine(JsonConvert.SerializeObject(response));
         }
         catch (Exception ex)
         {
            var errorResponse = new CalculationResponse { Error = ex.Message };
            Console.WriteLine(JsonConvert.SerializeObject(errorResponse));
         }
      }

      static CalculationResponse Calculate(CalculationRequest request)
      {
         if (request == null || request.Numbers == null || request.Numbers.Length == 0)
            return new CalculationResponse { Error = "Некорректные входные данные" };

         double result = 0;
         switch (request.Operation?.ToLower())
         {
            case "sum":
               foreach (var n in request.Numbers) result += n;
               break;
            case "multiply":
               result = 1;
               foreach (var n in request.Numbers) result *= n;
               break;
            case "average":
               foreach (var n in request.Numbers) result += n;
               result /= request.Numbers.Length;
               break;
            default:
               return new CalculationResponse { Error = $"Неизвестная операция: {request.Operation}" };
         }
         return new CalculationResponse { Result = result };
      }
   }
}