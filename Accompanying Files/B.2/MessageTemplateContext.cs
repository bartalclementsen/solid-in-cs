using Admin.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Admin.DataAccess.Sql
{
    /// <summary>
    /// Entity Framework context class for accessing
    /// <see cref="MessageTemplate"/> instances in the underlying
    /// database.
    /// </summary>
    public class MessageTemplateContext : DbContext
    {
        /// <summary>
        /// Provides IQueryable-access to the <see cref="MessageTemplate"/>
        /// instances in the underlying table.
        /// </summary>
        public DbSet<MessageTemplate> MessageTemplates { get; set; }

        /// <summary>
        /// Configures Entity Framework to use the SQL Express database.
        /// </summary>
        /// <param name="optionsBuilder">Options builder for configuration Entity Framework with your choices.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=90322;Trusted_Connection=True;");
        }
    }
}

