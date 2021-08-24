using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MicroService.Jira.Integrated.Api.Context
{
    public class JiraDbContext:DbContext
    {
        public JiraDbContext(DbContextOptions<JiraDbContext> options)
         : base(options)
        {
        }
    }
}
