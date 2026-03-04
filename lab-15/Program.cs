using lab_15;
using Microsoft.EntityFrameworkCore;

namespace lab_15
{
    public class Program
    {
        static void Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                 .UseSqlServer("Server=.\\SQLEXPRESS;Database=BookStoreDb;Trusted_Connection=True;TrustServerCertificate=True;")
                 .Options;

            using var context = new ApplicationDbContext(options);
        }
    }
}
