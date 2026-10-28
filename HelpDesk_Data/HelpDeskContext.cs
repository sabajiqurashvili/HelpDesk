using Microsoft.EntityFrameworkCore;

namespace HelpDesk_Data;

public class HelpDeskContext :DbContext
{
    public HelpDeskContext(DbContextOptions<HelpDeskContext> options) : base(options)
    {
        
    }
    
}