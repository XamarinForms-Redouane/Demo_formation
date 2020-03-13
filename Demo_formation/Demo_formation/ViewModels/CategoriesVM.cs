using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demo_formation.ViewModels
{
    class CategoriesVM
    {
        public ObservableCollection<string> List_Categories
        {
            get;
            set;
        }
        public CategoriesVM()
        {
            List_Categories = new ObservableCollection<string>();
            GetListCategories();
        }
        private void GetListCategories()
        {
            List_Categories.Clear();
            List_Categories.Add("Housting");
            List_Categories.Add("Debt");
        }
    }
}
