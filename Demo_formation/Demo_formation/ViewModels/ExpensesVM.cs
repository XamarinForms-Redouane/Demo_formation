using Demo_formation.Models;
using Demo_formation.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Demo_formation.ViewModels
{
    class ExpensesVM
    {
        public static ObservableCollection<Expense> List_Expenses
        {
            get;
            set;
        }
        public Command AddExpenseCommand
        {
            get;
            set;
        }
        public ExpensesVM()
        {
            List_Expenses = new ObservableCollection<Expense>();
            AddExpenseCommand = new Command(AddExpense);
            GetExpenses();
        }
        private void GetExpenses()
        {
            var expenses = Expense.GetListExpenses();
            List_Expenses.Clear();
            foreach(var obj_expense in List_Expenses)
            {
                List_Expenses.Add(obj_expense);
            }
        }

        public void AddExpense()
        {
            Application.Current.MainPage.Navigation.PushAsync(new NewExpensesPage());
        }
    }
}
