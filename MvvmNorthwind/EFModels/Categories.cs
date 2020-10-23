using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MvvmNorthwind.Models
{
    public partial class Categories : IEquatable<Categories>
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public virtual ICollection<Products> Products { get; set; }

        public bool Equals([AllowNull] Categories other)
        {
            if (other == null) return false;
            return CategoryId == other.CategoryId;
        }
    }
}
