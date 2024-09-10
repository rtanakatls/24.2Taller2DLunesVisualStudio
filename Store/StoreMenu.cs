using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioSemana1.Store
{
    internal class StoreMenu
    {
        private Cart cart;
        private List<ClothProduct> clothProducts;
        private List<ClayProduct> clayProducts;
    
        public StoreMenu()
        {
            clothProducts = new List<ClothProduct>();
            clayProducts = new List<ClayProduct>();
            clothProducts.Add(new ClothProduct("Alfombra",10,"Lana","Rojo",10));
            clothProducts.Add(new ClothProduct("Mantel",5,"Algodón","Blanco",20));
            clayProducts.Add(new ClayProduct("Jarrón", 10, 10, "Marrón", 50));
            clayProducts.Add(new ClayProduct("Vaso", 5, 2, "Rojo", 10));
        }

        public void Execute()
        {
            ShowMenu();
        }

        private void ShowMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce una opción");
                Console.WriteLine("1. Crear un nuevo carrito de compras");
                Console.WriteLine("2. Salir");
                string option= Console.ReadLine();
                switch(option)
                {
                    case "1":
                        ShowCartMenu();
                        break;
                    case "2":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }

        private void ShowCartMenu()
        {
            bool continueFlag=true;
            cart = new Cart();
            while (continueFlag)
            {
                Console.WriteLine("Introduce una opción");
                Console.WriteLine("1. Añadir un producto al carrito");
                Console.WriteLine("2. Mostrar el contenido del carrito");
                Console.WriteLine("3. Finalizar compra");
                string option= Console.ReadLine();
                switch (option)
                {
                    case "1":
                        ShowAddProductMenu();
                        break;
                    case "2":
                        ShowCartContent();
                        break;
                    case "3":
                        ShowCartContent();
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }

        private void ShowCartContent()
        {
            Console.WriteLine("El carrito tiene: ");
            Console.WriteLine(cart.GetAllProductsData());
            Console.WriteLine($"El precio final es: {cart.GetTotalPrice()}");
        }

        private void ShowAddProductMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce la opción");
                Console.WriteLine("1. Agregar un producto de tela");
                Console.WriteLine("2. Agregar un producto de arcilla");
                Console.WriteLine("3. Cancelar");
                string option=Console.ReadLine();
                switch (option)
                {
                    case "1":
                        ShowAllClothProductsMenu();
                        continueFlag = false;
                        break;
                    case "2":
                        ShowAllClayProductsMenu();
                        continueFlag = false;
                        break;
                    case "3":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("La opción no es válida");
                        break;
                }
            }
        }

        private void ShowAllClothProductsMenu()
        {
            bool continueFlag = true;
            while(continueFlag)
            {
                Console.WriteLine("Introduce el producto a comprar");
                for (int i = 0; i < clothProducts.Count; i++) 
                {
                    Console.WriteLine($"{i}. {clothProducts[i].GetData()}");
                }

                int option = int.Parse(Console.ReadLine());
                if (option < 0 || option >= clothProducts.Count)
                {
                    Console.WriteLine("Opción inválida");
                }
                else
                {
                    bool continueFlag2 = true;
                    while (continueFlag2)
                    {
                        ClothProduct clothProduct = clothProducts[option];
                        Console.WriteLine($"Has seleccionado: {clothProduct.GetData()}");
                        Console.WriteLine("Estás seguro querer comprarlo? s/n");
                        string option2= Console.ReadLine();
                        if (option2 == "s")
                        {
                            continueFlag2 = false;
                            cart.AddClothProduct(clothProduct);
                        }
                        else if(option2=="n")
                        {
                            continueFlag2 = false;
                        }
                        else
                        {
                            Console.WriteLine("Opción no válida");
                        }
                    }
                    continueFlag = false;
                }
            }
        }
        private void ShowAllClayProductsMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce el producto a comprar");
                for (int i = 0; i < clayProducts.Count; i++)
                {
                    Console.WriteLine($"{i}. {clayProducts[i].GetData()}");
                }

                int option = int.Parse(Console.ReadLine());
                if (option < 0 || option >= clayProducts.Count)
                {
                    Console.WriteLine("Opción inválida");
                }
                else
                {
                    bool continueFlag2 = true;
                    while (continueFlag2)
                    {
                        ClayProduct clayProduct = clayProducts[option];
                        Console.WriteLine($"Has seleccionado: {clayProduct.GetData()}");
                        Console.WriteLine("Estás seguro querer comprarlo? s/n");
                        string option2 = Console.ReadLine();
                        if (option2 == "s")
                        {
                            continueFlag2 = false;
                            cart.AddClayProduct(clayProduct);
                        }
                        else if (option2 == "n")
                        {
                            continueFlag2 = false;
                        }
                        else
                        {
                            Console.WriteLine("Opción no válida");
                        }
                    }
                    continueFlag = false;
                }
            }
        }
    }
}
