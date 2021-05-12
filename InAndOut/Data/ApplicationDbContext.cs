using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Data
{
    public class ApplicationDbContextL :DbContext
    {
        public ApplicationDbContextL(DbContextOptions<ApplicationDbContextL> options) : base(options)
        {

        }
    }
}
