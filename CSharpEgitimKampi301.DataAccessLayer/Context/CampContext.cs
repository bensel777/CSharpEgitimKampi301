using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
    public class CampContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}

/*
   bütün sınıflar bunun içinde yer alıcak           
 public class CampContext : DbContext -- > 
    {   
        public DbSet<Category>       Categories { get; set; }
 c# tarafında kullanacağımız ismi  |   Sql'e yansıyacak olan ismi     

birbirinden ayırt edilsin diye yalın hali class C# | Çoğul halini Sql de kullanılır...
*/