using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Juntos.Domain.Model;

namespace Juntos.DAL.Implementation
{
    internal class JuntosContext : DbContext
    {

        public JuntosContext() { }

        //Optamos por criar um dbContext singleton para evitar problemas de concorrência nas alterações do banco de dados caso seja necessario trocar de abordagem temos que trocar acessibilidade do construtor para public

        private static JuntosContext _instance;

        private JuntosContext(string connectionString) : base(connectionString)
        {
        }

        public static JuntosContext Instance
        {
            get
            {
                _instance = _instance ?? new JuntosContext("JuntosDb");
                return _instance;
            }
        }

        public DbSet<Person> persons { get; set; }
        public DbSet<Consumer> consumers { get; set; }
        public DbSet<Advertiser> advertisers { get; set; }
        public DbSet<Coupon> coupons { get; set; }
        public DbSet<Address> addresses { get; set; }
        public DbSet<Offer> offers { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Purchase> purchases { get; set; }
        public DbSet<Telephone> telephones { get; set; }
        public DbSet<Login> logins { get; set; }
        public DbSet<Coordinate> coordinates { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           //Mapeamento de Chave primária
            modelBuilder.Entity<Person>().HasKey(p => p.Id);
            modelBuilder.Entity<Consumer>().HasKey(c => c.Id);
            modelBuilder.Entity<Advertiser>().HasKey(a => a.Id);
            modelBuilder.Entity<Purchase>().HasKey(p => p.Id);
            modelBuilder.Entity<Offer>().HasKey(o => o.Id);
            modelBuilder.Entity<Payment>().HasKey(p => p.Id);
            modelBuilder.Entity<Coupon>().HasKey(c => c.Id);
            modelBuilder.Entity<Login>().HasKey(l => l.Id);
            modelBuilder.Entity<Coordinate>().HasKey(c => c.Id);
            modelBuilder.Entity<Address>().HasKey(a => a.Id);
            modelBuilder.Entity<Telephone>().HasKey(t => t.Id);

            //Mapeamento de relacionamentos entre os objetos
            /*Person*/
            modelBuilder.Entity<Person>().HasMany(e => e.addresses).WithRequired();
            modelBuilder.Entity<Person>().HasMany(e => e.telephones).WithRequired();
            modelBuilder.Entity<Person>().HasRequired(p => p.login).WithRequiredPrincipal();
            /*Address*/
            modelBuilder.Entity<Address>().HasRequired(p => p.coordinate).WithRequiredPrincipal();
            /*Consumer*/
            modelBuilder.Entity<Consumer>().HasMany(e => e.purchases).WithRequired();
            /*Advertiser*/
            modelBuilder.Entity<Advertiser>().HasMany(e => e.offers).WithRequired();
            /*Offer*/
            modelBuilder.Entity<Offer>().HasRequired(c => c.address).WithRequiredPrincipal();
            modelBuilder.Entity<Offer>().HasRequired(c => c.telephone).WithRequiredPrincipal();
            
            /*Purchase*/
            modelBuilder.Entity<Purchase>().HasMany(e => e.coupons).WithRequired();
            /*Coupon*/
            modelBuilder.Entity<Coupon>().HasRequired(c => c.offer).WithRequiredPrincipal();
            /*Payment*/
            modelBuilder.Entity<Payment>().HasRequired(p => p.purchase)
                .WithOptional(c => c.payment)
                .Map(m => m.MapKey(new string[] { "purchaseId" }));
            




            

        }


    }
}
