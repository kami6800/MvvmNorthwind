using MvvmNorthwind.Models;
using MvvmNorthwind.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MvvmNorthwind.ViewModel
{
    class ProductsVM : ObservableObject
    {
        private Repository repository = new Repository();
        public GridCommand ProductCommand { get; private set; }
        public UpdateProductCommand UpdateEntityCommand { get; private set; }
        public ObservableCollection<Products> AllProducts { get; set; }
        public ObservableCollection<Suppliers> AllSuppliers { get; set; }
        public ObservableCollection<Categories> AllCategories { get; set; }
        public Products SelectedProduct
        {
            get { return _selectedProduct;  }
            set
            {
                _selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }
        private Products _selectedProduct;

        public ProductsVM()
        {
            ProductCommand = new GridCommand(AddBlankProduct);
            UpdateEntityCommand = new UpdateProductCommand(UpdateEntity);
            PopulateAllProducts();
        }

        public void PopulateAllProducts()
        {
            AllProducts = new ObservableCollection<Products>(repository.GetAllProducts());
            AllSuppliers = new ObservableCollection<Suppliers>(repository.GetAllSuppliers());
            AllCategories = new ObservableCollection<Categories>(repository.GetAllCategories());
            SelectedProduct = AllProducts[0];
        }

        public void AddBlankProduct(string name)
        {
            Products product = new Products()
            {
                ProductName = name
            };

            AllProducts.Add(product);
        }

        public void UpdateEntity(Products product)
        {
            repository.UpdateEntity(product);
        }
    }
}
