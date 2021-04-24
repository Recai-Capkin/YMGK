using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YMGKWebService.Data.Models;

namespace YMGKWebService.Data
{
    public class YMGKContext : DbContext
    {
        public DbSet<File> Files { get; set; }
    }
}
