using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintService
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService.Services.PrintServic printService = new Services.PrintServic();

            Console.WriteLine("Quantos valores irá digitar?");

            int n ;//caso o try parse consiga converter o valor digitado, o "n" é a saida para o valor, 
            int.TryParse(Console.ReadLine(), out n); //se nao, iguala "n" a 0

            if (n > 0)
            {
                try
                {
                    for (int i = 0; i < n; i++)
                    {
                        int x = int.Parse(Console.ReadLine());
                        printService.AddValue(x);
                    }

                    printService.Print();
                    Console.Write("First: " + printService.First());
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("OPS!!! \n\r\n\r\n\rOcorreu um problema: " + ex.Message);
                }
            }
            
        }
    }
}
