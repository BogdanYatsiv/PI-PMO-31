using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;

namespace TESTIO.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public Microsoft.EntityFrameworkCore.DbSet<User> Users { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Test> Tests { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Question> Questions { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Answer> Answers { get; set; }
    }
}
