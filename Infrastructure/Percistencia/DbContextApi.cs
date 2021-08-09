using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Percistencia
{
    public class DbContextApi : DbContext
    {
        public DbContextApi(DbContextOptions<DbContextApi> options) : base(options)
        {

        }
    }
}
