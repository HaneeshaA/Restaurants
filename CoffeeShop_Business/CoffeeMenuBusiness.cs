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
            var data = CoffeeMenuData.GetMenuFromDB();
            return data;
        }
    }
}
