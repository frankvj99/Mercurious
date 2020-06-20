using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Mercurius.Entities;

namespace Mercurius.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            Vendors = new List<SelectListItem>();
        }

        public int Id { get; set; }

        [Required]
        public string ProductNum { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsActive { get; set; }
        public DateTime DateActivated { get; set; }

        //public bool OnlyProductWithVendor { get; set; }

        [Required]
        [Display(Name = "Vendors")]
        public int? SourceVendorId { get; set; }
        public Vendor Vendor { get; set; }
        public IEnumerable<SelectListItem> Vendors { get; set; } // For SelectList

    }
}
