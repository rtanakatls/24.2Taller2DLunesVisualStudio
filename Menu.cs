using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioSemana1
{
    internal class Menu
    {
        PersonController personController;
        public Menu()
        {
            personController = new PersonController();
        }
        public void Execute()
        {
            ShowPeopleMenu();
        }

        private void ShowPeopleMenu()
        {
            bool continueFlag=true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce la opción a realizar");
                Console.WriteLine("1. Añadir persona");
                Console.WriteLine("2. Remover persona");
                Console.WriteLine("3. Mostrar todas las personas");
                Console.WriteLine("0. Salir");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddPersonMenu();
                        break;
                    case "2":
                        RemovePersonMenu();
                        break;
                    case "3":
                        ShowAllPeopleMenu();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                }
            }
        }

        private void AddPersonMenu()
        {
            Console.WriteLine("Introduce el nombre:");
            string name=Console.ReadLine();
            Console.WriteLine("Introduce la edad:");
            int age = int.Parse(Console.ReadLine());
            personController.AddNewPerson(name, age);

        }
        private void RemovePersonMenu()
        {
            Console.WriteLine("Introduce el nombre:");
            string name = Console.ReadLine();
            personController.RemovePerson(name);

        }

        private void ShowAllPeopleMenu()
        {
            Console.WriteLine($"{personController.ShowAllPeople()}");
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
