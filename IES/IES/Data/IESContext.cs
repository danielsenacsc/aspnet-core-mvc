﻿using Modelo.Cadastros;
using Microsoft.EntityFrameworkCore;

namespace IES.Data
{
    public class IESContext : DbContext
    {
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }

        public IESContext(DbContextOptions<IESContext> options) : base(options)
        {

        }
    }
}
