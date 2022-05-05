using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NguoiDungLH.Models
{
    public partial class NguoiDungDB : DbContext
    {
        public NguoiDungDB()
            : base("name=NguoiDungDB")
        {
        }

        public virtual DbSet<Nguoidung> Nguoidungs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nguoidung>()
                .Property(e => e.dienthoai)
                .IsFixedLength();
        }
    }
}
