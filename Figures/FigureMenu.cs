using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioSemana1.Figures
{
    internal class FigureMenu
    {
        public void Execute()
        {
            ShowMenu();
        }

        private void ShowMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce la figura a operar");
                Console.WriteLine("1. Rectángulo");
                Console.WriteLine("2. Círculo");
                Console.WriteLine("3. Triángulo");
                Console.WriteLine("0. Salir");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        CalculateRectangle();
                        break;
                    case "2":
                        CalculateCircle();
                        break;
                    case "3":
                        CalculateTriangle();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }

        private void CalculateRectangle()
        {
            Console.WriteLine("Introduce la base");
            float b= float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura");
            float h= float.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(h,b);
            Console.WriteLine($"El área del rectángulo es: {rectangle.GetArea()}");
        }

        private void CalculateCircle()
        {
            Console.WriteLine("Introduce el radio");
            float radius = float.Parse(Console.ReadLine());
            Circle circle= new Circle(radius);
            Console.WriteLine($"El área del círculo es: {circle.GetArea()}");


        }

        private void CalculateTriangle()
        {

            Console.WriteLine("Introduce la base");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura");
            float h = float.Parse(Console.ReadLine());
            Triangle triangle= new Triangle(b, h);
            Console.WriteLine($"El área del triángulo es: {triangle.GetArea()}");
        }
    }
}
