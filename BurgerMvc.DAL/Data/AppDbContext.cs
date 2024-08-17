using BurgerMvc.DAL.Entities;
using BurgerMvc.DAL.Entities.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMvc.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<OrdersExtra> OrdersExtras { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ExtraIngredient> ExtraIngredients { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrdersMenu> OrdersMenu { get; set; }
        string hashedPasswordA = Hash256.ComputeSha256Hash("a");
        string hashedPasswordB = Hash256.ComputeSha256Hash("b");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Seed Users
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 3,
                    Name = "John",
                    Surname = "Doe",
                    Email = "b",
                    Password = hashedPasswordB, // Ensure you hash passwords in real applications
                    Photo = "john_doe_photo.jpg",
                    Birthdate = new DateTime(1990, 1, 1),
                    IsAdmin = false
                },
                new User
                {
                    Id = 2,
                    Name = "Jane",
                    Surname = "Smith",
                    Email = "a",
                    Password = hashedPasswordA,
                    Photo = "jane_smith_photo.jpg",
                    Birthdate = new DateTime(1992, 2, 2),
                    IsAdmin = true
                }
            );

            // Seed MenuItems
            modelBuilder.Entity<MenuItem>().HasData(
               new MenuItem
               {
                   Id = 1,
                   Title = "Python Burger",
                   Content = "Siyah çavdar ekmeği, dana köftesi, cheddar peyniri, marul, domates, soğan, özel Python sosu (barbekü sos bazlı, hafif baharatlı).",
                   Price = 7.99m,
                   Photo = "python.jpeg"
               },
               new MenuItem
               {
                   Id = 2,
                   Title = "Java Burger",
                   Content = "Tam buğday ekmeği, tavuk veya dana köftesi, çift cheddar peyniri, bacon, marul, domates,soğan,özelJava       sosu      (kahve ve hardal karışımı).",
                   Price = 8.99m,
                   Photo = "java.jpg"
               },
               new MenuItem
               {
                   Id = 3,
                   Title = "JavaScript Burger",
                   Content = "Siyah ekmek, renkli köfte (kırmızı pancar, havuç gibi sebzelerle), mavi peynir, marul, domates,soğan, özel        JavaScript sosu (tatlı ve ekşi karışımı).",
                   Price = 9.49m,
                   Photo = "javascript.jpeg"
               },
               new MenuItem
               {
                   Id = 4,
                   Title = "C++ Burger",
                   Content = "Tam buğday ekmeği, baharatlı dana köftesi, mavi peynir, jalapeno biber, marul, domates, soğan, özel C++ sosu (acı biber sosu bazlı).",
                   Price = 8.79m,
                   Photo = "c++.jpeg"
               },
               new MenuItem
               {
                   Id = 5,
                   Title = "C# Burger",
                   Content = "Beyaz ekmek, tavuk veya dana köftesi, cheddar peyniri, marul, domates, soğan, özel C# sosu (barbeküsos ve      mayonez    karışımı).",
                   Price = 8.29m,
                   Photo = "csharp.jpeg"
               },
               new MenuItem
               {
                   Id = 6,
                   Title = "Swift Burger",
                   Content = "Siyah ekmek, elma ve cevizli köfte, brie peyniri, marul, elma dilimleri, özel Swift sosu (elma sirkes ve    bal       karışımı).",
                   Price = 9.99m,
                   Photo = "swift.jpeg"
               },
               new MenuItem
               {
                   Id = 7,
                   Title = "Ruby on Rails Burger",
                   Content = "Tam buğday ekmeği, somon veya tofu köftesi, avokado, marul, domates, soğan, özel Ruby on Rails sosu (limonlu        mayonez bazlı).",
                   Price = 10.49m,
                   Photo = "ruby.jpg"
               },
               new MenuItem
               {
                   Id = 8,
                   Title = "PHP Burger",
                   Content = "Beyaz ekmek, dana köftesi, cheddar peyniri, marul, domates, soğan, özel PHP sosu (barbekü sos ve ketçap karışımı).",
                   Price = 7.49m,
                   Photo = "php.jpg"
               },
               new MenuItem
               {
                   Id = 9,
                   Title = "Go Burger",
                   Content = "Tam buğday ekmeği, dana köftesi, cheddar peyniri, marul, domates, soğan, özel Go sosu (soya sosu ve zencefil        karışımı).",
                   Price = 8.59m,
                   Photo = "go.jpg"
               },
               new MenuItem
               {
                   Id = 10,
                   Title = "Kotlin Burger",
                   Content = "Siyah çavdar ekmeği, tavuk veya dana köftesi, gruyère peyniri, marul, domates, soğan, özel Kotlin sos       (hardal,  mayonez ve bal karışımı).",
                   Price = 8.99m,
                   Photo = "kotlin.jpeg"
               });

            modelBuilder.Entity<ExtraIngredient>().HasData(
               new ExtraIngredient { Id = 1, Name = "Cheddar Peyniri", Price = 1.50m, Photo = "cheddar.jpeg" },
               new ExtraIngredient { Id = 2, Name = "Jalapeno Biberi", Price = 1.00m, Photo = "jalapeno.jpeg" },
               new ExtraIngredient { Id = 3, Name = "Mantar", Price = 1.25m, Photo = "mantar.jpeg" },
               new ExtraIngredient { Id = 4, Name = "Soğan", Price = 0.75m, Photo = "soğan.jpeg" },
               new ExtraIngredient { Id = 5, Name = "Turşu", Price = 0.50m, Photo = "turşu.jpeg" },
               new ExtraIngredient { Id = 6, Name = "Domates", Price = 0.75m, Photo = "domates.jpeg" },
               new ExtraIngredient { Id = 7, Name = "Marul", Price = 0.50m, Photo = "marul.jpeg" },
               new ExtraIngredient { Id = 8, Name = "Avokado", Price = 1.75m, Photo = "avokado.jpeg" },
               new ExtraIngredient { Id = 9, Name = "Siyah Zeytin", Price = 1.00m, Photo = "siyahzeytin.jpg" },
               new ExtraIngredient { Id = 10, Name = "Yeşil Zeytin", Price = 1.00m, Photo = "yeşilzeytin.jpeg" }
);

        }
    

    public static string ComputeSha256Hash(string rawData)
    {
        // Create a SHA256   
        using (SHA256 sha256Hash = SHA256.Create())
        {
            // ComputeHash - returns byte array  
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

            // Convert byte array to a string   
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
    }
}
