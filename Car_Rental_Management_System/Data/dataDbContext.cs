using Microsoft.EntityFrameworkCore;

namespace Car_Rental_Management_System.Data
{
    public class dataDbContext : DbContext
    {
        public dataDbContext(DbContextOptions<dataDbContext> options): base(options) 
        {
            
        }


    }
}
