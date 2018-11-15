using CoffeeShop_Data;
using CoffeeShop_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeShop_Business
{
    public class CoffeeMenuBusiness
    {
        public List<CoffeeMenuModel> GetMenu()
        {
            List<CoffeeMenuModel> menuResult = new List<CoffeeMenuModel>();
            
            //2nd Assignment
             //menuResult = CoffeeMenuData.GetMenuFromDB();

            //3rd Assignment
            var coffeeService = new CoffeeShopService.CoffeeShopServiceClient();
            menuResult = coffeeService.GetData().ToList();


            return menuResult;
        }
    }
}
