using EFC_Ex1.DAL.Moduls;
using Microsoft.EntityFrameworkCore;

namespace EFC_Ex1.DAL
{
    public class Context : DbContext
    {
        private string _connectionStr => "Data Source=DESKTOP-BRQ9LQE\\SQLEXPRESS;Initial Catalog=Games_Archives;Integrated Security=True;Connect Timeout=30;";

        public DbSet<Games> Games { get; set; }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionStr);
        }
    }
}