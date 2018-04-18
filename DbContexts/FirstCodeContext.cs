using Microsoft.EntityFrameworkCore;
using FirstCode.Models;
using FirstCode.Constants;

namespace FirstCode.DbContexts
{
   public class FirstCodeContext : DbContext
   {
       public FirstCodeContext(DbContextOptions<FirstCodeContext> options) : base(options)
       {

       }

       public DbSet<Student> Student { get; set; }
       public DbSet<DormitoryManager> DormitoryManager { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           modelBuilder.Entity<Student>().ToTable(DataBase.StudentTableName);
           modelBuilder.Entity<DormitoryManager>().ToTable(DataBase.DormitoryManagerTableName);
           modelBuilder.Entity<Dormitory>().ToTable(DataBase.DormitoryTableName);
       }
   } 
}