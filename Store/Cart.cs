using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioSemana1.Store
{
    internal class Cart
    {
        private List<ClayProduct> clayProducts;
        private List<ClothProduct> clothProducts;

        public Cart()
        {
            clayProducts = new List<ClayProduct>();
            clothProducts = new List<ClothProduct>();
        }

        public float GetTotalPrice()
        {
            float price = 0;
            foreach(ClayProduct clayProduct in clayProducts)
            {
                price += clayProduct.GetPrice();
            }
            foreach (ClothProduct clothProduct in clothProducts)
            {
                price += clothProduct.GetPrice();
            }
            return price;
        }

        public void AddClothProduct(ClothProduct clothProduct)
        {
            clothProducts.Add(clothProduct);
        }

        public void AddClayProduct(ClayProduct clayProduct) 
        {
            clayProducts.Add(clayProduct);
        }

        public string GetAllProductsData()
        {
            string data = "";
            foreach(ClayProduct clayProduct in clayProducts)
            {
                data += $"{clayProduct.GetData()}\n";
            }
            foreach(ClothProduct clothProduct in clothProducts)
            {
                data += $"{clothProduct.GetData()}\n";
            }
            return data;
        }
    
    }
}
