using System.ComponentModel.DataAnnotations;

namespace AmdarisInternship.API.Dtos
{
    public class UpdateModuleDto
    {
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Name length between 1 - 100")]
        public string Name { get; set; }
    }
}
