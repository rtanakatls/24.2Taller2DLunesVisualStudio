using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioSemana1.Store
{
    internal class ClothProduct
    {
        private string name;
        private int size;
        private string material;
        private string color;
        private float price;

        public ClothProduct(string name, int size, string material, string color, float price)
        {
            this.name = name;
            this.size = size;
            this.material = material;
            this.color = color;
            this.price = price;
        }

        public string GetData()
        {
            return $"Nombre: {name}, Tamaño {size}, Material: {material}, Color: {color}, Precio: {price}";
        }

        public float GetPrice()
        {
            return price;
        }
    }
}
