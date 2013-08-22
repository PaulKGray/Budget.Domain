using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Budget.Domain;

namespace Budget.Models
{
    public class StandardItem
    {
        public int id { get; set; }

        [DisplayName("Item Name")]
        [StringLength(160)]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        
        [DisplayName("Item Type")]
        public Budget.Domain.ItemType Type { get; set; }

        public string Description { get; set; }

        public StandardItem()
        {
        
        }

      
    }
}