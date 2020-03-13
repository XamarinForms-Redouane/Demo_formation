using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Demo_formation.Models;

namespace Demo_formation.ViewModels
{
    class NewExpenseVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null )
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private string _expenseName;
        public string ExpenseName
        {
            get
            {
                return _expenseName;
            }
            set
            {
                _expenseName = value;
                OnPropertyChanged("ExpenseName");
            }
        }

        private string _expenseDescription;
        public string ExpenseDescription
        {
            get { return _expenseDescription; }
            set
            {
                _expenseDescription = value;
                OnPropertyChanged("ExpenseDescription");
            }
        }

        private float _expenseAmmount;
        public float ExpenseAmmount
        {
            get { return _expenseAmmount; }
            set
            {
                _expenseAmmount = value;
                OnPropertyChanged("ExpenseAmmmount");
            }
        }
        private DateTime expenseDate;
        public DateTime ExpenseDate
        {
            get { return expenseDate; }
            set
            {
                expenseDate = value;
                OnPropertyChanged("ExpenseDate");
            }
        }
        private string expenseCategory;
        public string ExpenseCategory
        {
            get { return expenseCategory; }
            set
            {
                expenseCategory = value;
                OnPropertyChanged("ExpenseCategory");
            }
        }
        //Need some searching
        public Command SaveExpenseCommand
        {
            get;
            set;
        }

        public ObservableCollection<string> Categories
        {
            get;
            set;
        }

        //public ObservableCollection<ExpenseStatus> ExpenseStatuses
        //{
        //    get;
        //    set;
        //}

        public NewExpenseVM()
        {
            Categories = new ObservableCollection<string>();
            //ExpenseStatuses = new ObservableCollection<ExpenseStatus>();
            ExpenseDate = DateTime.Today;
            // LOOK HERE
            SaveExpenseCommand = new Command(InsertExpense);
           GetListCategories();
        }


        // TO INSERT 
        public void InsertExpense()
        {
            var vm = this;
            Expense Md_expense = new Expense()
            {
                Name = ExpenseName,
                Ammount = ExpenseAmmount,
                Category = ExpenseCategory,
                Date = ExpenseDate,
                Description = ExpenseDescription
            };

            // CALL METHODE INSERT TO CHECK
            int response = Expense.InsertExpense(Md_expense);

            if(response > 0)
            {// NEED SEARCHING ALSO
                Application.Current.MainPage.Navigation.PopAsync();
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "No items were inserter", "Ok");
            }
        }


        // LIST CATEGORIES
        private void GetListCategories()
        {
            Categories.Clear();
            Categories.Add("Housting");
            Categories.Add("Debt");
        }


    }
}
