using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula7.Model;
using Microsoft.EntityFrameworkCore;

namespace Aula7.Data
{
    //Essa classe é para conectar com o banco de dados
    public class CardContext : DbContext
    {
       public CardContext(DbContextOptions<CardContext> opt) : base(opt) {} 


        public DbSet<Card> Cards { get; set; }
    }
}
