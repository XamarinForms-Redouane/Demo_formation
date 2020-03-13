using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Demo_formation.Models
{
    class Expense
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public float Ammount
        {
            get;
            set;
        }
        [MaxLength(25)]
        public string Description
        {
            get;
            set;
        }
        public DateTime Date
        {
            get;
            set;
        }
        public string Category
        {
            get;
            set;
        }
        public Expense()
        {
            //Constructor
        }
        public static int InsertExpense(Expense obj_expense)
        {
            using(SQLite.SQLiteConnection conn = new SQLiteConnection(App.DatabasePath))
            {
                conn.CreateTable<Expense>();
                return conn.Insert(obj_expense);
            }
        }
        public static List<Expense> GetListExpenses()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabasePath))
            {
                conn.CreateTable<Expense>();
                return conn.Table<Expense>().ToList();
            }
        }

    }
}
