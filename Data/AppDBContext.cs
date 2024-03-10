//using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
// Remove these static imports
//using  static Student; // Replace YourNamespaceContainingStudentClass with the actual namespace of the Student class
//using static Teacher; // Replace YourNamespaceContainingTeacherClass with the actual namespace of the Teacher class
//using static Event; // Replace YourNamespaceContainingEventClass with the actual namespace of the Event class
//using static OfficeHour; // Replace YourNamespaceContainingProposalClass with the actual namespace of the Proposal class
//using static Probosal; // Replace YourNamespaceContainingOfficeHourClass with the actual namespace of the OfficeHour class

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
        
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Event> Events { get; set; }
    // Corrected spelling of Proposal here
    public DbSet<Probosal> Proposals { get; set; }
    public DbSet<OfficeHour> OfficeHours { get; set; }
}
