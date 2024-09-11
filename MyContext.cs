using Test_2.Models;
using Microsoft.EntityFrameworkCore;

namespace Test_2
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AHMED\\MSSQLSERVERR;Database=Final_DB;Trusted_Connection=True;Encrypt=false");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            

            var _Categories= new List<Category>
            {
                new Category { Id = 1, Name = "Storage"    ,         Description = "This is Descriotion" },
                new Category { Id = 2, Name = "Desktop" ,      Description = "This is Descriotion" },
                new Category { Id = 3, Name = "Accessories" ,   Description = "This is Descriotion" },
                new Category { Id = 4, Name = "monitors" ,         Description = "This is Descriotion" }
            };






            var _Products = new List<Product>
            {
                new Product { Id = 1, Title = " Mouse",             Quantity = 22, Price = 1234,    Description = "This is Description",  ImagePath = "Image_Path"  ,   CategoryId = 1 },
                new Product { Id = 2, Title = " Gaming Monitor  " , Quantity = 11, Price = 2234,    Description = "This is Description",  ImagePath = "Image_Path"  ,   CategoryId = 2 },
                new Product { Id = 3, Title = " Keyboard  ",        Quantity = 23, Price = 3234,    Description = "This is Description",  ImagePath = "Image_Path"  ,   CategoryId = 3 },
                new Product { Id = 4, Title = " Gaming Headset",    Quantity = 18, Price = 4234,    Description = "This is Description",  ImagePath = "Image_Path"  ,   CategoryId = 4 },
                new Product { Id = 5, Title = " Motherboard ",      Quantity = 8,  Price = 5234,    Description = "This is Description",  ImagePath = "Image_Path"  ,   CategoryId = 1 },
                new Product { Id = 6, Title = " Mouse pad",         Quantity = 3,  Price = 6234,    Description = "This is Description",  ImagePath = "Image_Path"  ,   CategoryId = 2 },
                new Product { Id = 7, Title = " RAM ",              Quantity = 2,  Price = 7234,    Description = "This is Description",  ImagePath = "Image_Path"  ,   CategoryId = 3 },
                new Product { Id = 8, Title = " Usb driver",        Quantity = 5,  Price = 8234,    Description = "This is Description",  ImagePath = "Image_Path"  ,   CategoryId = 4 },
                new Product { Id = 9, Title = " Hard disk ",        Quantity = 6,  Price = 9234,    Description = "This is Description",  ImagePath = "Image_Path"  ,   CategoryId = 1 },
                new Product { Id = 10,Title = " SSD ",              Quantity = 4,  Price = 10234,   Description = "This is Description",  ImagePath = "Image_Path"  ,   CategoryId = 2 },
                new Product { Id = 11,Title = " Proccessor ",       Quantity = 16, Price = 10234,   Description = "This is Description",  ImagePath = "Image_Path"  ,   CategoryId = 3 },
                new Product { Id = 12,Title = " Graphics card ",    Quantity = 26, Price = 10234,   Description = "This is Description",  ImagePath = "Image_Path"  ,   CategoryId = 4 }
            };
            var _Users = new List<User>
            {
                new User { Id = 1, FirstName = "Ahmed"  ,LastName = "Sabri" ,Email = "Ahmed123@mail.com"   ,Password ="123 "},
                new User { Id = 2, FirstName = "Rami" ,  LastName = "Sabri" ,Email = "Rami123@mail.com"   ,Password ="123 "},
                new User { Id = 3, FirstName = "Hadi" , LastName = "Mohammed"  ,Email = "Hadi123@mail.com"   ,Password ="123 "},
                new User { Id = 4, FirstName = "Karim"  ,LastName = "Ibrahim" ,Email = "Karim123@mail.com"   ,Password ="123 "}

            };



            modelBuilder.Entity<User>().HasData(_Users);
            modelBuilder.Entity<Category>().HasData(_Categories);
            modelBuilder.Entity<Product>().HasData(_Products);

        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<User> Users { get; set; }

    }
}

