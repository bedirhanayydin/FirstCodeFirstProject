using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Classlar
{
    class OtoparkDbContext:DbContext //miras aldık dbcontext
    {
        public DbSet<Marka> TBLMarka { get; set; }
        public DbSet<Seri> TBLSeri { get; set; }
        public DbSet<Personel> TBLPersonel { get; set; }
       

        //aracpark bilgileri ıd ile seride ıd yi eşleştirmek için

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

    }
}
