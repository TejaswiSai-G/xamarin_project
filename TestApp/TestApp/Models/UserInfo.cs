using System;
using SQLite;

namespace TestApp
{
    public class UserInfo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
