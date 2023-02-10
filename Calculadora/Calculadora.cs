using System;

namespace Calculadora
{
    public class Calculadora
    {

        public static void Main()
        {
            //char refazOp = 's';
            //while (refazOp != 'n')
            {
                Console.Clear();
                Console.WriteLine("Selecione o tipo de Operacao");
                Console.WriteLine("1 - Adicao");
                Console.WriteLine("2 - Subtracao");
                Console.WriteLine("3 - Multiplicacao");
                Console.WriteLine("4 - Divisao \n");

                int operacao = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o primeiro numero: ");
                double num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Segundo numero: ");
                double num2 = int.Parse(Console.ReadLine());

                double resultado = 0;

                Calc calc = new Calc();
                switch (operacao)
                {
                    case 1:
                        {
                            resultado = calc.Adicao(num1, num2);
                            break;
                        }
                    case 2:
                        {
                            resultado = calc.Subtracao(num1, num2);
                            break;
                        }
                    case 3:
                        {
                            resultado = calc.Multiplicacao(num1, num2);
                            break;
                        }
                    case 4:
                        {
                            resultado = calc.Divisao(num1, num2);
                            break;
                        }
                    default:
                        Console.WriteLine("numero invalido, digite outro numero. ");
                        break;
                }
                Console.WriteLine("o resultado da operacao dos numeros {0} e {1} e: {2}", num1, num2, resultado);
                Console.ReadKey();

                Console.WriteLine("Deseje fazer mais uma operacao [s] ou  [n]: ");
                //refazOp = Convert.ToChar(Console.ReadLine().ToLower());

            }

        }

        class Calc
        {

            public double Adicao(double num1, double num2)
            {
                double resultado = num1 + num2;
                return resultado;
            }
            public double Subtracao(double num1, double num2)
            {
                double resultado = num1 - num2;
                return resultado;
            }
            public double Multiplicacao(double num1, double num2)
            {
                double resultado = num1 * num2;
                return resultado;
            }
            public double Divisao(double num1, double num2)
            {
                double resultado = num1 / num2;
                return resultado;
            }
        }


    }
}




