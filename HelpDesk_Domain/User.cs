namespace HelpDesk_Domain;

public class User
{
    public int UserId { get; set; }
    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
    public UserRole Role { get; set; } = UserRole.User;
    
    //User can create many tickets '1-to-many relation'
    public ICollection<Ticket> CreatedTickets { get; set; }= new List<Ticket>();
    
    //user can be an Agent and can have assigned many tickets '1-to-many relation' 
    public ICollection<Ticket> AssignedTickets { get; set; } = new List<Ticket>();
    
    
    
    
    
}