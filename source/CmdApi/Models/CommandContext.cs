namespace CmdApi.Models
{
    using Microsoft.EntityFrameworkCore;

    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options)
        {
        }

        public DbSet<Command> CommandItems { get; set; }
    }
}