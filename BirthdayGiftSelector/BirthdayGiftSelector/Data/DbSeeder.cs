using BirthdayGiftSelector.Models;
using Microsoft.EntityFrameworkCore;

namespace BirthdayGiftSelector.Data;
public class DbSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().HasData(
            new Employee { Id = 1, Name = "Alice", DateOfBirth = new DateTime(1990, 1, 15), Username = "alice", Password = "pass123" },
            new Employee { Id = 2, Name = "Bob", DateOfBirth = new DateTime(1992, 2, 20), Username = "bob", Password = "pass123" }
        );

        modelBuilder.Entity<Gift>().HasData(
            new Gift { Id = 1, Name = "Gift Card" },
            new Gift { Id = 2, Name = "Headphones" }
        );
    }
}

