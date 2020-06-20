using System;
using System.Collections.Generic;
using Mercurius.Entities;
using Mercurius.DataAccess;
using Mercurius.ViewModels;
using System.Web.Mvc;
using System.Linq;

namespace Mercurius.Application.Services
{
    public class ProductService
    {
        private readonly MercuriusContext _context;

        public ProductService(MercuriusContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductViewModel> GetAllProductsViewModel()
        {
            return _context.Products.OrderBy(x => x.Name)
                .Select(x => new ProductViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Vendor = x.Vendor
                })
                .ToList();                
        }

        public ProductViewModel GetNewProductViewModel()
        {
            var productViewModel = new ProductViewModel()
            {
                Vendors = GetVendorsSelectList()
            };

            return productViewModel;
        }

        public IEnumerable<SelectListItem> GetVendorsSelectList()
        {
            return _context.Vendors.ToList()
                .OrderBy(x => x.Name)
                .Select(x => new SelectListItem()
                {
                    Value = x.Id.ToString(),
                    Text = x.Name
                })
                .ToList();
        }

        public void Create(ProductViewModel product)
        {
            var newProduct = new Product()
            {
                ProductNum = product.ProductNum,
                Name = product.Name,
                Description = product.Description,
                SourceVendorId = product.SourceVendorId ?? product.SourceVendorId.Value,
                DateActivated = product.DateActivated,
                IsActive = product.IsActive
            };

            _context.Add(newProduct);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = _context.Products
                .SingleOrDefault(x => x.Id == id);

            if (product != null)
            {
                _context.Remove(product);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Product not found");
            }
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
