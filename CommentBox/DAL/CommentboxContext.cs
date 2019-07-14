using CommentBox.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CommentBox.DAL
{
    public class CommentboxContext : DbContext
    {

        public CommentboxContext() : base("CommentboxContext")
        {
        }

        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}