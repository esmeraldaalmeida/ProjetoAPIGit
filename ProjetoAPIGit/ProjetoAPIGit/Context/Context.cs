using ProjetoAPIGit.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoAPIGit.Context
{
    public class Context : DbContext
    { 
        public DbSet<Favorito> tbFavorito { get; set; }
    }
}