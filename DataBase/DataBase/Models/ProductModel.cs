using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataBase.Models
{    
    public class ProductModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public bool Done { get; set; }

        public ProductModel()
        {

        }
    }
}
