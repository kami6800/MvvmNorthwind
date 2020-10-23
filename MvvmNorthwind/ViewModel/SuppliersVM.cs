using MvvmNorthwind.Models;
using MvvmNorthwind.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MvvmNorthwind.ViewModel
{
    class SuppliersVM
    {
        private Repository repository = new Repository();
        public GridCommand SupplierCommand { get; private set; }
        public UpdateCommand UpdateSupplierCommand { get; private set; }
        public ObservableCollection<Suppliers> AllSuppliers { get; set; }

        public SuppliersVM()
        {
            SupplierCommand = new GridCommand(AddBlankSupplier);
            UpdateSupplierCommand = new UpdateCommand(UpdateSupplier);
            PopulateAllSuppliers();
        }

        public void PopulateAllSuppliers()
        {
            AllSuppliers = new ObservableCollection<Suppliers>(repository.GetAllSuppliers());
        }

        public void AddBlankSupplier(string name)
        {
            Suppliers supplier = new Suppliers()
            {
                CompanyName = name
            };

            AllSuppliers.Add(supplier);
        }

        public void UpdateSupplier(Object supplier)
        {
            repository.UpdateEntity(supplier);
        }
    }
}
