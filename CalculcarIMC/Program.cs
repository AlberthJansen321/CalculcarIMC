using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculcarIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Calcular IMC\n");

            Console.WriteLine($"Digite sua altura\n");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine($"Altura {altura}\n");

            Console.WriteLine($"Digite seu peso\n");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine($"Peso {peso}\n");

            var resultado = peso / (altura * altura);

            if(resultado < 18.5){
                Console.WriteLine($"\n Resultado: {resultado}, você está desnutrido");
            }
            else if(resultado >= 18.5  && resultado < 24.9)
            {
                Console.WriteLine($"\n Resultado: {resultado}, você está com o peso normal");
            }
            else if(resultado >= 24.9 && resultado < 29.9)
            {
                Console.WriteLine($"\n Resultado: {resultado}, você está com um peso um pouco acima do normal");
            }
            else if (resultado >= 29.9 && resultado < 34.9)
            {
                Console.WriteLine($"\n Resultado: {resultado}, você está um pouco obeso");
            }
            else if (resultado >= 34.9 && resultado < 39.9)
            {
                Console.WriteLine($"\n Resultado: {resultado}, você está muito obeso");
            }
            else if (resultado >= 40)
            {
                Console.WriteLine($"\n Resultado: {resultado}, você está hipermega obeso");
            }



            Console.ReadKey();

        }
    }
}
