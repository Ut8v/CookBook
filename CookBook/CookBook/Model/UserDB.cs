using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CookBook.Model
{
    internal class UserDB
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
