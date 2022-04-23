using System.ComponentModel.DataAnnotations;

namespace TicketSystem.Data.Entities
{
    public class Entrance
    {
        public int Id { get; set; }
        [Display(Name =  "Descripción")]
        [MaxLength(50)]
        [Required]
        public string Description { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        [Display(Name = "Numer Ticket")]
        public int TiketsNumber => Tickets == null ? 0 : Tickets.Count;
    }
}
