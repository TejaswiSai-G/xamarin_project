using System;
using SQLite;
using TestApp.iOS;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDB))]
namespace TestApp.iOS
{
    public class SQLiteDB: ISQLiteDb
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
