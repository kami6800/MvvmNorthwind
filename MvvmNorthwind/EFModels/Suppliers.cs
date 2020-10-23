using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MvvmNorthwind.Models
{
    public partial class Suppliers : ObservableObject, IEquatable<Suppliers>
    {
        public Suppliers()
        {
            Products = new HashSet<Products>();
        }

        public int SupplierId { get; set; }
        public string CompanyName
        {
            get { return _companyName; }
            set
            {
                _companyName = value;
                OnPropertyChanged("CompanyName");
            }
        }
        private string _companyName;
        public string ContactName
        {
            get { return _contactName; }
            set
            {
                _contactName = value;
                OnPropertyChanged("ContactName");
            }
        }
        private string _contactName;
        public string ContactTitle
        {
            get { return _contactTitle; }
            set
            {
                _contactTitle = value;
                OnPropertyChanged("ContactTitle");
            }
        }
        private string _contactTitle;
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged("Address");
            }
        }
        private string _address;
        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                OnPropertyChanged("City");
            }
        }
        private string _city;
        public string Region
        {
            get { return _region; }
            set
            {
                _region = value;
                OnPropertyChanged("Region");
            }
        }
        private string _region;
        public string PostalCode
        {
            get { return _postalCode; }
            set
            {
                _postalCode = value;
                OnPropertyChanged("PostalCode");
            }
        }
        private string _postalCode;
        public string Country
        {
            get { return _country; }
            set
            {
                _country = value;
                OnPropertyChanged("Country");
            }
        }
        private string _country;
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged("Phone");
            }
        }
        private string _phone;
        public string Fax
        {
            get { return _fax; }
            set
            {
                _fax = value;
                OnPropertyChanged("Fax");
            }
        }
        private string _fax;
        public string HomePage
        {
            get { return _homePage; }
            set
            {
                _homePage = value;
                OnPropertyChanged("HomePage");
            }
        }
        private string _homePage;

        public virtual ICollection<Products> Products { get; set; }

        public bool Equals([AllowNull] Suppliers other)
        {
            if (other == null) return false;
            return SupplierId == other.SupplierId;
        }
    }
}
