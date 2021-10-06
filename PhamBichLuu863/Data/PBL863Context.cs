using Microsoft.EntityFrameworkCore;
using PhamBichLuu863.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhamBichLuu863.Data
{
    public class PBL863Context:DbContext
    {
        public PBL863Context(DbContextOptions<PBL863Context> options)
            : base(options)
        {
        }

        public DbSet<PersonPBL863> PersonPBL863 { get; set; }
    }
}
