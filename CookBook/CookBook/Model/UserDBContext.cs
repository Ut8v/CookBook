using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CookBook.services;
using SQLite;
using System.IO;

namespace CookBook.Model
{
    internal class UserDBContext : IUserInfo
    {
        SQLiteAsyncConnection database;

        public UserDBContext()  
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UserDB.db");
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<UserDB>().Wait();
        }
        //to find if user exists
        public async Task<bool> UserExists(string email, string password)
        {
            var user = await database.Table<UserDB>().FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
            return user != null;
        }
        //add user to the database
        public async Task AddUser(UserDB user)
        {
            await database.InsertAsync(user);
        }
    }
}
