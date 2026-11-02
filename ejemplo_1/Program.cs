using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_1
{
    internal class Program
    {
        public static void Factorial_sinrecursividad()
        {
            Console.WriteLine("Ingrese un numero para hallar su factorial: ");
            int N = int.Parse(Console.ReadLine());
            long F=1;
            for (int i = 1; i <= N ; i++)
            {
                F = F * i;
            }
            Console.WriteLine("Factorial: " + F);
        }

        public static long Factorial_conrecursividad(int N)
        {
            if(N == 0 || N == 1)
            {
                return 1;
            }
            return N * Factorial_conrecursividad(N - 1);
        }

        public static void Potencia_sinrecursividad()
        {
            int B, exp;
            Console.WriteLine("Ingresar base: ");
             B = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar exponente: ");
            exp = int.Parse(Console.ReadLine());
            long P= 1;
            for(int i = 1; i <= exp ; i++)
            {
                P = P * B;
            }
            Console.WriteLine("Potencia: "+P);
        }

        static public double Potencia_conrecursividad(int B, int exp)
        {
             if(exp == 0)
            {
                return 1;
            }
            return B * Potencia_conrecursividad(B, exp - 1);
        }

        //Sumatoria de N primeros numeros naturales
        static public int sumatoria(int N)
        {
            if(N == 1)
            {
                return 1;
            }
            return N + sumatoria(N - 1);
        }
        //Conteo regresivo de N a 1
        static public int Conteo_regresivo(int N)
        {
            if (N == 0)
            {
                return 0;
            }
            Console.WriteLine(N);
            return Conteo_regresivo(N - 1);
        }

        static public int suma_arreglo(int[]numeros, int indice)
        {
            if(indice <= numeros.Length)
            {
                return 0; 
            }
            return numeros[indice] + suma_arreglo(numeros, indice + 1);
        }
        static void Main(string[] args)
        {
            int opc;
            bool S = true;
            while (S)
            {
                Console.Clear();
                Console.WriteLine("*****************************");
                Console.WriteLine("\tMenu de opciones");
                Console.WriteLine("*****************************");
                Console.WriteLine("[1]Factorial sin recursividad");
                Console.WriteLine("[2]Factorial con recursividad");
                Console.WriteLine("[3]Potencia sin recursividad");
                Console.WriteLine("[4]Potencia con recursividad");
                Console.WriteLine("[5]Sumatoria de N primeros numeros naturales");
                Console.WriteLine("[6]Conteo regresivo de N a 1");
                Console.WriteLine("[7]Arreglos");
                Console.WriteLine("[8]Salir");
                Console.WriteLine("*****************************");
                Console.Write("Ingrese una opcion: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Factorial_sinrecursividad();
                        break;   
                    case 2:
                        Console.WriteLine("Ingresar numero: ");
                        int N = int.Parse(Console.ReadLine());
                        Console.WriteLine(N+"!="+ Factorial_conrecursividad(N));
                        break;
                    case 3:
                        Potencia_sinrecursividad();
                        break;
                    case 4:
                        Console.WriteLine("Ingresa base: ");
                        int B = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa exponente: ");
                        int exp = int.Parse(Console.ReadLine());
                        Console.WriteLine(B+"^"+exp+"="+Potencia_conrecursividad(B, exp));
                        break;
                    case 5:
                        Console.WriteLine("Ingresar el numero de N: ");
                        int N1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La sumatoria de numeros naturales es: " + sumatoria(N1));
                        break;
                    case 6:
                        Console.WriteLine("Ingresar el valor de N: ");
                        int N2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Conteo regresivo de N a 1: "+Conteo_regresivo(N2));
                        break;
                    case 7:
                        Console.WriteLine("Suma de arreglo");
                        int[] numeros = { 10, 20, 30, 40, 50 };
                        break;
                    case 8:
                        S = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                Console.ReadKey();
            }    
        }
    }
}
