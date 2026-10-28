namespace HelpDesk_Domain;

public class Ticket
{
    public int TicketId { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public Status TicketStatus { get; set; } = Status.Open;
    public Priority TicketPriority { get; set; } =  Priority.Medium;
    public DateTime CreatedAt { get; set; } =  DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DueDate { get; set; }
    
    // one ticket can have many tags 'many-to-many relation to tag'
    public ICollection<Tag> Tags { get; set; } = new List<Tag>();
    
    // ticket have 1 user who created it  '1-to-many relation'
    public User CreatedByUser { get; set; } = null!;
    public int CreatedByUserId { get; set; }
    
    // Ticket can have Comments '1-to-many relation'
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    
    //Ticket maybe assign to 1 agent 
    public User? AssignedAgent { get; set; }
    public int?  AssignedAgentId { get; set; }
    
    
    
    
    
    
    
}