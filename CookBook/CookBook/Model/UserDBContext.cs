using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CookBook.services;
using SQLite;
using System.IO;

namespace CookBook.Model
{
    public class UserDBContext : IUserInfo
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
            try
            {
                var user = await database.Table<UserDB>().FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
                return user != null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        //add user to the database
        public async Task AddUser(UserDB user)
        {
            try
            {
                await database.InsertAsync(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //method to get user's first name to display if logged in
        public async Task<string> GetFirstName(string email, string password)
        {
            try
            {
                var user = await database.Table<UserDB>().FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
                return user.FirstName;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }


        }
    }
}
