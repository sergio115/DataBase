using DataBase.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public Task<List<ProductModel>> GetItemsAsync()
        {
            return database.Table<ProductModel>().ToListAsync();
        }

        public Task<List<ProductModel>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<ProductModel>("SELECT * FROM [ProductModel] WHERE [Done] = 0");
        }

        public Task<ProductModel> GetItemAsync(int id)
        {
            return database.Table<ProductModel>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(ProductModel item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(ProductModel item)
        {
            return database.DeleteAsync(item);
        }

    }
}
