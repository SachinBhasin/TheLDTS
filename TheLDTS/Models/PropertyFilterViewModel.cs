using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TheLDTS.Models
{
    public class PropertyFilterViewModel
    {
        public List<Property>? Properties { get; set; }
        public SelectList? Countries { get; set; }
        public string? propertyCountry { get; set; }
        public string? propertyCity { get; set; }
    }
}
