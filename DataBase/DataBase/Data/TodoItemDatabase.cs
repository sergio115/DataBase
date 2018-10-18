using DataBase.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Data
{
    public class TodoItemDatabase
    {
        readonly SQLiteAsyncConnection database;
        public TodoItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<ProductModel>().Wait();
        }
        
    }
}
