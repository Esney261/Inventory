using System.ComponentModel.DataAnnotations;

namespace Tiket.Data.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        [Display(Name = "Tiket")]
        public bool WasUsed { get; set; }
        [MaxLength(20)]
        [Required(ErrorMessage = "El campo documento es requerido")]
        public string Document { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Entrance Entrance { get; set; }
    }
}
