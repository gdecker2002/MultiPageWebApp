using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MultiPageWebApp.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Name = "Billy Bob",
                    Number = 8482736846,
                    Address = "512 Tire Street",
                    Note = "Lives on a street named after a tire"
                },
                new Contact
                {
                    ContactId = 2,
                    Name = "Dage Gecker",
                    Number = 8847362396,
                    Address = "718 Street Boulevard",
                    Note = "Odd Name and Street."
                },
                new Contact
                {
                    ContactId = 3,
                    Name = "Bob Billard",
                    Number = 9482736436,
                    Address = "514 Plop Drive",
                    Note = "Likes Pool"
                });
        }
    }
}
