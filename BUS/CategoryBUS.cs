using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;


namespace BUS
{
    public class CategoryBUS
    {
        CategoryDAO category = new CategoryDAO();
        
        public List<Category> GetData()
        {
            return category.GetData();
        }
    }
}
