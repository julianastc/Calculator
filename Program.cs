using System; 

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           Menu();
        }

        static void Menu()
        {
            Console.Clear(); 
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Quociente da Divisão");
            Console.WriteLine("4 - Resto da Divisão");
            Console.WriteLine("5 - Multiplicação");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("-----------------");

            string input = Console.ReadLine();
            short res; 
            bool isValidShort = short.TryParse(input, out res);

            if (!isValidShort) 
            {
                res = 0;
            }

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: DivisaoQuociente(); break;
                case 4: DivisaoResto(); break; 
                case 5: Multiplicacao(); break;
                case 6: System.Environment.Exit(0); break;
                default: MostreErro(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            
            Console.WriteLine("Digite um número: ");
            string inputValueOne = Console.ReadLine();
            float v1;
            bool isValidFloatOne = float.TryParse(inputValueOne, out v1);
            
            if (!isValidFloatOne)
            {
                MostreErro();
            }

            Console.WriteLine("Digite outro número: ");
            string inputValueTwo= Console.ReadLine();
            float v2;
            bool isValidFloatTwo = float.TryParse(inputValueTwo, out v2);
            
            if (!isValidFloatTwo)
            {
                MostreErro();
            }


            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é " + resultado); 
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
           
            Console.WriteLine("Digite um número: ");
            string inputValueOne = Console.ReadLine();
            float v1;
            bool isValidFloatOne = float.TryParse(inputValueOne, out v1);
            
            if (!isValidFloatOne)
            {
                MostreErro();
            }

            Console.WriteLine("Digite outro número: ");
            string inputValueTwo= Console.ReadLine();
            float v2;
            bool isValidFloatTwo = float.TryParse(inputValueTwo, out v2);
            
            if (!isValidFloatTwo)
            {
                MostreErro();
            }
            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void DivisaoQuociente()
        {
            Console.Clear();
            
            Console.WriteLine("Digite um número: ");
            string inputValueOne = Console.ReadLine();
            float v1;
            bool isValidFloatOne = float.TryParse(inputValueOne, out v1);
            
            if (!isValidFloatOne)
            {
                MostreErro();
            }

            Console.WriteLine("Digite outro número: ");
            string inputValueTwo= Console.ReadLine();
            float v2;
            bool isValidFloatTwo = float.TryParse(inputValueTwo, out v2);
            
            if (!isValidFloatTwo)
            {
                MostreErro();
            }
            Console.WriteLine("");
            
            float resultado = v1/v2;
            Console.WriteLine($"O quociente da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void DivisaoResto()
        {
            Console.Clear();
            
            Console.WriteLine("Digite um número: ");
            string inputValueOne = Console.ReadLine();
            float v1;
            bool isValidFloatOne = float.TryParse(inputValueOne, out v1);
            
            if (!isValidFloatOne)
            {
                MostreErro();
            }

            Console.WriteLine("Digite outro número: ");
            string inputValueTwo= Console.ReadLine();
            float v2;
            bool isValidFloatTwo = float.TryParse(inputValueTwo, out v2);
            
            if (!isValidFloatTwo)
            {
                MostreErro();
            }
            Console.WriteLine("");

            float resultado = v1 % v2;
            Console.WriteLine($"O resto da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
           
            Console.WriteLine("Digite um número: ");
            string inputValueOne = Console.ReadLine();
            float v1;
            bool isValidFloatOne = float.TryParse(inputValueOne, out v1);
            
            if (!isValidFloatOne)
            {
                MostreErro();
            }

            Console.WriteLine("Digite outro número: ");
            string inputValueTwo= Console.ReadLine();
            float v2;
            bool isValidFloatTwo = float.TryParse(inputValueTwo, out v2);
            
            if (!isValidFloatTwo)
            {
                MostreErro();
            }
            Console.WriteLine(""); 

            float resultado = v1*v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();

        }

        static void MostreErro()
        {
            Console.WriteLine("Caractere Inválido! Aperte enter para continuar.");
            Console.ReadLine();
            Menu();
        }
    }
}
