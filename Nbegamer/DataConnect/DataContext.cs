using Microsoft.EntityFrameworkCore;
using Nbegamer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nbegamer.DataConnect
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<User> Userss { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<SubCatagory> SubCatagories { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserType>().HasData(

                new UserType { UserTypeID = 1, UserTypeName = "Admin"},
                new UserType { UserTypeID = 2, UserTypeName = "Buyer"}

                );
            modelBuilder.Entity<User>().HasData(

                new User { UserID= 1, UserFullName = "SNP SUJON", UserEmail="snpsujon93@gmail.com", UserPhoneNumber = "01782065131", UserPassword = "123", UserTypeID = 1, LastLoginIP ="111.111.111.111", JoinDate= DateTime.Now, ProfilePicture ="1.jpg", IsActive = true }
                

                );
        }


    }
}
