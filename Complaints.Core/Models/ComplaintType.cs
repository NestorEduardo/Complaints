using System.ComponentModel.DataAnnotations;

namespace Complaints.Core.Models
{
    public class ComplaintType : BaseEntity
    {
        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El campo {0} debe estar entre {2} y {1} caracteres.")]
        public string Description { get; set; }
    }
}
