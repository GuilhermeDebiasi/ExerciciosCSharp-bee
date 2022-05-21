using System;

namespace _1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double porcentual1 = 15;
            /* Salário 0 - 400.00 */
            const double porcentual2 = 12;
            /* Salário 400.01 - 800.00 */
            const double porcentual3 = 10;
            /* Salário 800.01 - 1200.00 */
            const double porcentual4 = 7;
            /* Salário 1200.01 - 2000.00 */
            const double porcentual5 = 4;
            /* Salário Acima de 2000.0 */

            double salario, novoSalario = 0;

            Double.TryParse(Console.ReadLine(), out salario);

            if (salario >= 0.00 && salario <= 400.00)
            {
                Console.WriteLine("Novo salario: " + (novoSalario = salario + ((salario * porcentual1) / 100)).ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + (novoSalario - salario).ToString("F2"));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                Console.WriteLine("Novo salario: " + (novoSalario = salario + ((salario * porcentual2) / 100)).ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + (novoSalario - salario).ToString("F2"));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                Console.WriteLine("Novo salario: " + (novoSalario = salario + ((salario * porcentual3) / 100)).ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + (novoSalario - salario).ToString("F2"));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario >= 1200.1 && salario <= 2000.00)
            {
                Console.WriteLine("Novo salario: " + (novoSalario = salario + ((salario * porcentual4) / 100)).ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + (novoSalario - salario).ToString("F2"));
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (salario >= 2000.01)
            {
                Console.WriteLine("Novo salario: " + (novoSalario = salario + ((salario * porcentual5) / 100)).ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + (novoSalario - salario).ToString("F2"));
                Console.WriteLine("Em percentual: 4 %");
            }
        }
    }
}