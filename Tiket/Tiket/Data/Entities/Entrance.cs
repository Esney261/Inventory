using System.ComponentModel.DataAnnotations;

namespace Tiket.Data.Entities
{
    public class Entrance
    {
        public int Id { get; set; }
        [MaxLength(20)]
        [Required(ErrorMessage = "El campo descripcíon es requerido")]
        public string Description { get; set; }
        public ICollection<Ticket> Ticket { get; set; }
    }
}
