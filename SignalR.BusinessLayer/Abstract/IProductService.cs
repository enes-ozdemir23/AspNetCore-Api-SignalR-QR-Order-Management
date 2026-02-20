using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();

        public int TProductCount();
        public int TProductCountByCategoryNameHamburger();
        public int TProductCountByCategoryNameDrink();

        public decimal TProductPriceAvg();

        string TProductNameByMaxPrice();
        string TProductNameByMinPrice();

        decimal TProductAvgPriceByHamburger();

        public decimal TProductPriceBySteakBurger();

        public decimal TTotalPriceByDrinkCategory();

        public decimal TTotalPriceBySaladCategory();

        List<Product> TGetLast9Products();



    }
}
