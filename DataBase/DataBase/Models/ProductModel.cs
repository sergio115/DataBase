using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataBase.Models
{
    
    public class ProductModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int id;
        private string name;
        private string description;
        private string price;

        public ProductModel() {

        }

        [PrimaryKey, AutoIncrement]
        public int Id {
            get => id;
            set => id = value;
        }
        
        public string Name {
            get => name;
            set => name = value;
        }
        public string Description {
            get => description;
            set => description = value;
        }
        public string Price {
            get => price;
            set => price = value;
        }

    }
}
