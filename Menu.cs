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
            Test();
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
    }
}
