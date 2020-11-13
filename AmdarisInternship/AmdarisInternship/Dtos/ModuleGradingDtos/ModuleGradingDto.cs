using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmdarisInternship.API.Dtos
{
    public class ModuleGradingDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Name length between 1 - 100")]
        public string Name { get; set; }

        public float Weight { get; set; }

        public int ModuleId { get; set; }
    }
}
