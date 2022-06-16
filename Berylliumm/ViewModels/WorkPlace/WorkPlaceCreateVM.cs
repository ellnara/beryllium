using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Berylliumm.ViewModels.Category
{
    public class WorkPlaceCreateVM
    {
        [Required]
        public string Image { get; set; }
        public string Name { get; set; }
    }
}
