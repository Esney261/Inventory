using System.ComponentModel.DataAnnotations;

namespace Inventory.Data.Entities
{
    public class Box
    {
        
        public int Id { get; set; }
        [MaxLength(50,ErrorMessage ="El campo {0} solo puede tener maximo {1} caracteres.")]
        [Display(Name = "Caja")]
        [Required(ErrorMessage ="El campo {0} es requerido.")]
        public string Name { get; set; }
    }
}
