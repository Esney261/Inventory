using System.ComponentModel.DataAnnotations;

namespace Inventory.Data.Entities
{
    public class Location
    {
        public int Id { get; set; }
        [MaxLength(6, ErrorMessage = "El campo {0} solo puede tener maximo {1} caracteres.")]
        [Display(Name = "Rack")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Rack { get; set; }
        
    }
}
