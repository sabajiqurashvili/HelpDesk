using System.ComponentModel.DataAnnotations;

namespace HelpDesk_Domain;

public class Ticket
{
    public int TicketId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}