using System;

namespace ConsoleApp {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o primeiro número: ");
            string num1texto = Console.ReadLine();
            Console.WriteLine("Digite o segundo número: ");
            string num2texto = Console.ReadLine();
            Console.WriteLine("Digite o operador: ");
            string operador = Console.ReadLine();
            
            int num1 = int.Parse(num1texto);
            int num2 = int.Parse(num2texto);
            int resultado = 0;


            switch (operador) {

                case "+":
                    resultado = num1 + num2;
                    break;

                case "-":
                    resultado = num1 - num2;
                    break;

                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
               
            }
            




            Console.WriteLine($"A soma dos números é: {resultado}");



        }
    }
}
