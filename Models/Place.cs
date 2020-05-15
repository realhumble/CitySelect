using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CitySelect.Models
{
    public class MysqlUtil
    {


        //数据库连接
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;pwd=1234;database=city;charset=utf8");

        public class Cityselect
        {
            public int Nation { get; set; }
            public string City { get; set; }

         } 


            ////从数据库中读取
            //var nationname = new List<Cityselect>()
            //{

            //    };
            //var selectItemList = new List<SelectListItem>() {
            //        new SelectListItem(){Value="0",Text="全部",Selected=true}
            //    };
            //var selectList = new SelectList(categoryList, "CategoryId", "CategoryName");
            //selectItemList.AddRange(selectList);
            //    ViewBag.database = selectItemList;
        
    }
}
   


