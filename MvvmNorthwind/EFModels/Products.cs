using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MvvmNorthwind.Models
{
    public partial class Products : ObservableObject, IEquatable<Products>
    {
        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int ProductId { get; set; }
        public string ProductName {
            get { return _productName; }
            set
            {
                _productName = value;
                OnPropertyChanged("ProductName");
            }
        }
        private string _productName;
        public int? SupplierId
        {
            get { return _supplierId; }
            set
            {
                _supplierId = value;
                OnPropertyChanged("SupplierId");
            }
        }
        private int? _supplierId;
        public int? CategoryId
        {
            get { return _categoryId; }
            set
            {
                _categoryId = value;
                OnPropertyChanged("CategoryId");
            }
        }
        private int? _categoryId;
        public string QuantityPerUnit
        {
            get { return _quantityPerUnit; }
            set
            {
                _quantityPerUnit = value;
                OnPropertyChanged("QuantityPerUnit");
            }
        }
        private string _quantityPerUnit;
        public decimal? UnitPrice
        {
            get { return _unitPrice; }
            set
            {
                _unitPrice = value;
                OnPropertyChanged("UnitPrice");
            }
        }
        private decimal? _unitPrice;
        public short? UnitsInStock
        {
            get { return _unitsInStock; }
            set
            {
                _unitsInStock = value;
                OnPropertyChanged("UnitsInStock");
            }
        }
        private short? _unitsInStock;
        public short? UnitsOnOrder
        {
            get { return _unitsOnOrder; }
            set
            {
                _unitsOnOrder = value;
                OnPropertyChanged("UnitsOnOrder");
            }
        }
        private short? _unitsOnOrder;
        public short? ReorderLevel
        {
            get { return _reorderLevel; }
            set
            {
                _reorderLevel = value;
                OnPropertyChanged("ReorderLevel");
            }
        }
        private short? _reorderLevel;
        public bool Discontinued
        {
            get { return _discontinued; }
            set
            {
                _discontinued = value;
                OnPropertyChanged("Discontinued");
            }
        }
        private bool _discontinued;

        public virtual Categories Category
        {
            get { return _category; }
            set
            {
                _category = value;
                OnPropertyChanged("Category");
            }
        }
        private Categories _category;

        public virtual Suppliers Supplier
        {
            get { return _supplier; }
            set
            {
                _supplier = value;
                OnPropertyChanged("Supplier");
            }
        }
        private Suppliers _supplier;
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        public bool Equals([AllowNull] Products other)
        {
            if (other == null) return false;
            return ProductId == other.ProductId;
        }
    }
}
