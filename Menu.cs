using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioSemana1
{
    internal class Menu
    {
        public void Execute()
        {
            E3();
        }

        private void Test()
        {
            Console.WriteLine("Introduce tu nombre");
            string name = Console.ReadLine();
            Console.WriteLine($"Hola {name}");
            int age;
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("Introduce tu edad");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tu edad es {age}");
                if (age < 0)
                {
                    Console.WriteLine("No puedes tener edad negativa");
                }
                else if (age <= 18)
                {
                    continueFlag = false;
                    Console.WriteLine("Eres menor de edad, no tomes alcohol");
                }
                else
                {
                    continueFlag = false;
                    Console.WriteLine("Toma todo lo que quieras");
                }
            }
        }

        private void E1()
        {
            int a;
            int b;
            Console.WriteLine("Introduce el primer número");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine($"Suma: {a + b}");
            Console.WriteLine($"Resta: {a - b}");
            Console.WriteLine($"Multiplicación: {a * b}");
        }

        private void E2()
        {
            float a;
            float b;
            Console.WriteLine("Introduce el primer número");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine($"División: {a / b}");
            Console.WriteLine($"Módulo: {a % b}");
        }

        private void E3()
        {
            float days;
            Console.WriteLine("Introduce la cantidad de días:");
            days = int.Parse(Console.ReadLine());

            Console.WriteLine($"{days} días son {days / 365} años");
            Console.WriteLine($"{days} días son {days / 7} semanas");

        }
    }
}
