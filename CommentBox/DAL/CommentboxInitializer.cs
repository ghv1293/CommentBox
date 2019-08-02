using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CommentBox.Models;

namespace CommentBox.DAL
{
    public class CommentboxInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CommentboxContext>
    {
        protected override void Seed(CommentboxContext context)
        {
            var comments = new List<Comment>
            {
            new Comment{Textbox="First Comment",Timestamp=DateTime.Parse("2005-09-01")},
            new Comment{Textbox="Second Comment",Timestamp=DateTime.Parse("2019-09-02")}

            };
            var users = new List<User>
            { new User{name="Harsha" } };

            users.ForEach(s => context.Users.Add(s));

            comments.ForEach(s => context.Comments.Add(s));
            context.SaveChanges();
            
        }
    }
}