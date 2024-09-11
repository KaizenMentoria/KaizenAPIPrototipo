using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using KaizenAPI.Controllers;

namespace KaizenAPI.Data
{
    public class KaizenContext : DbContext
    {
        public KaizenContext(DbContextOptions<KaizenContext> options) : base(options)
        {
            
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}