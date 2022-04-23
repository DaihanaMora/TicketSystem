using System.ComponentModel.DataAnnotations;

namespace TicketSystem.Data.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        [Display(Name = "Usado")]
        public bool WasUsed { get; set; }
        [Display(Name = "Documento")]
        [MaxLength(20)]
        [Required]
        public string Document { get; set; }
        [Display(Name = "Nombre completo")]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        public Entrance Entrance { get; set; }
        [Required]
        [Display(Name = "Fecha")]
        public DateTime? Date { get; set; }
        
    }
}
