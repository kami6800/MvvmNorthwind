using Microsoft.EntityFrameworkCore;
using MvvmNorthwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvvmNorthwind
{
    class Repository
    {
        NorthwindContext context = new NorthwindContext();

        public List<Products> GetAllProducts()
        {
            return context.Products.Include(p=>p.Supplier)/*.Include(p=>p.Category)*/.ToList();
        }

        public Products GetProductById(int id)
        {
            return context.Products.Where(p => p.ProductId == id).FirstOrDefault();
        }

        public List<Suppliers> GetAllSuppliers()
        {
            return context.Suppliers.ToList();
        }

        public List<Categories> GetAllCategories()
        {
            return context.Categories.ToList();
        }

        public void UpdateEntity(object toUpdate)
        {
            using(var context = new NorthwindContext())
            {
                context.Entry(toUpdate).State = EntityState.Modified;
                context.Update<object>(toUpdate);
                context.SaveChanges();
            }
        }

        public void UpdateProduct(Products product)
        {
            product.CategoryId = product.Category.CategoryId;
            product.SupplierId = product.Supplier.SupplierId;

            using (var context = new NorthwindContext())
            {
                Products oldProduct = context.Products.Where(p => p.ProductId == product.ProductId).FirstOrDefault();
                oldProduct.SupplierId = product.SupplierId;
                oldProduct.CategoryId = product.CategoryId;
                context.Update<Products>(oldProduct);
                //context.Entry(product).State = EntityState.Modified;
                //context.Entry(product.Supplier).State = EntityState.Modified;
                //context.Entry(product.Category).State = EntityState.Modified;
                //context.Entry(product.SupplierId).State = EntityState.Modified;
                //context.Entry(product.CategoryId).State = EntityState.Modified;
                //context.Update<Products>(product);
                context.SaveChanges();
            }
        }
    }
}
