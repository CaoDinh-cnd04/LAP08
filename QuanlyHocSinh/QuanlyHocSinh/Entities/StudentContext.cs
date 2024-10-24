using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanlyHocSinh.Entities
{
    public partial class StudentContext : DbContext
    {
        public StudentContext()
            : base("name=StudentContext1")
        {
        }

        public virtual DbSet<Students> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
