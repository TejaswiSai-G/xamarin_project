using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    public  interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
        SQLiteAsyncConnection GetConnectionSearch();
    }
}
