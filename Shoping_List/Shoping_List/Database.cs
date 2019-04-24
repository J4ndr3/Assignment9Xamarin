using Android.Util;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using SQLitePCL;

namespace Shoping_List
{
    class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool createDatabase()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "ShopList.db")))
                {
                    connection.CreateTable<ShopinList>();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        //Add or Insert Operation  

        public bool insertIntoTable(ShopinList list)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "ShopList.db")))
                {
                    connection.Insert(list);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public List<ShopinList> selectTable()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "ShopList.db")))
                {
                    return connection.Table<ShopinList>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return null;
            }
        }
        //Edit Operation  

        public bool updateTable(ShopinList list)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "ShopList.db")))
                {
                    connection.Query<ShopinList>("UPDATE ShopinList set Name=?", list.Name, list.Id);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        //Delete Data Operation  

        public bool removeTable(ShopinList list)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "ShopList.db")))
                {
                    connection.Delete(list);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        //Select Operation  

        public bool selectTable(int Id)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "ShopList.db")))
                {
                    connection.Query<ShopinList>("SELECT * FROM ShopinList Where Id=?", Id);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
    }
}
