﻿using Microsoft.EntityFrameworkCore;
using SAEP_vitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAEP_vitor.Data
{
    public class Contexto : DbContext 
    {
        public Contexto(DbContextOptions<Contexto> options)
                    : base(options)
        {
        }

        public DbSet<Perfis> Perfis { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Equipamentos> Equipamentos { get; set; }
        public DbSet<Comentarios> Comentarios { get; set; }
    }
}
