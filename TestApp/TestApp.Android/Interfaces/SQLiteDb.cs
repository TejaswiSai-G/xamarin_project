using TestApp.Droid;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]
namespace TestApp.Droid
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            //var path = Path.Combine(documentsPath, "MySQLite.db3");
            var path = Path.Combine(documentsPath, "UserInfo.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}