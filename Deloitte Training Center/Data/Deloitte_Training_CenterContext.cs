using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Deloitte_Training_Center.Models;

namespace Deloitte_Training_Center.Data
{
    public class Deloitte_Training_CenterContext : DbContext
    {
        public Deloitte_Training_CenterContext (DbContextOptions<Deloitte_Training_CenterContext> options)
            : base(options)
        {
        }

        public DbSet<Deloitte_Training_Center.Models.Training> Training { get; set; } = default!;
        public DbSet<Deloitte_Training_Center.Models.User> User { get; set; } = default!;
    }
}
