using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioSemana1.Store
{
    internal class ClayProduct
    {
        private string name;
        private int size;
        private float weight;
        private string color;
        private float price;
        
        public ClayProduct(string name, int size, float weight, string color, float price)
        {
            this.name = name;
            this.size = size;
            this.weight = weight;
            this.color = color;
            this.price = price;
        }

        public string GetData()
        {
            return $"Nombre: {name}, Tamaño {size}, Peso: {weight}, Color: {color}, Precio: {price}";
        }

        public float GetPrice()
        {
            return price;
        }
    }
}
