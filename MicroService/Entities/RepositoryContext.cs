using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
namespace Entities
{
    public class RepositoryContext:DbContext 
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
       : base(options)
        {
        }
        public DbSet<Jiraissue> Jiraissues { get; set; }
        public DbSet<IssueStatus> IssueStatuss { get; set; }
        public DbSet<IssueType> IssueTypes { get; set; }
        public DbSet<JiraAction> JiraActions { get; set; }
        public DbSet<WorkLog> WorkLogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jiraissue>().ToTable("jiraissue");
            modelBuilder.Entity<Jiraissue>().Property(i => i.Id ).HasColumnName("ID");
            modelBuilder.Entity<Jiraissue>().Property(i => i.pkey).HasColumnName("pKey");
            modelBuilder.Entity<Jiraissue>().Property(i => i.Project).HasColumnName("PROJECT");
            modelBuilder.Entity<Jiraissue>().Property(i => i.Reporter).HasColumnName("REPORTER");
            modelBuilder.Entity<Jiraissue>().Property(i => i.Assignee).HasColumnName("ASSIGNEE");
            modelBuilder.Entity<Jiraissue>().Property(i => i.issueType).HasColumnName("issuetype");
            modelBuilder.Entity<Jiraissue>().Property(i => i.Summary).HasColumnName("SUMMARY");
            modelBuilder.Entity<Jiraissue>().Property(i => i.Description).HasColumnName("DESCRIPTION");
            modelBuilder.Entity<Jiraissue>().Property(i => i.Environment).HasColumnName("ENVIRONMENT");
            modelBuilder.Entity<Jiraissue>().Property(i => i.Priority).HasColumnName("PRIORITY");
            modelBuilder.Entity<Jiraissue>().Property(i => i.Resolution).HasColumnName("RESOLUTION");
            modelBuilder.Entity<Jiraissue>().Property(i => i.issueStatus).HasColumnName("issuestatus");
            modelBuilder.Entity<Jiraissue>().Property(i => i.Created).HasColumnName("CREATED");
            modelBuilder.Entity<Jiraissue>().Property(i => i.Updated).HasColumnName("UPDATED");
            modelBuilder.Entity<Jiraissue>().Property(i => i.Dudate).HasColumnName("DUEDATE");
            modelBuilder.Entity<Jiraissue>().Property(i => i.resolutionDate).HasColumnName("RESOLUTIONDATE");
            modelBuilder.Entity<Jiraissue>().Property(i => i.Votes).HasColumnName("VOTES");

            modelBuilder.Entity<Jiraissue>().Property(i => i.Watches).HasColumnName("WATCHES");
            modelBuilder.Entity<Jiraissue>().Property(i => i.timeorigianEstimate).HasColumnName("TIMEORIGINALESTIMATE");
            modelBuilder.Entity<Jiraissue>().Property(i => i.timeEstimate).HasColumnName("TIMEESTIMATE");
            modelBuilder.Entity<Jiraissue>().Property(i => i.timeSpent).HasColumnName("TIMESPENT");
            modelBuilder.Entity<Jiraissue>().Property(i => i.WorkFlow_Id).HasColumnName("WORKFLOW_ID");
            modelBuilder.Entity<Jiraissue>().Property(i => i.Security).HasColumnName("SECURITY");
            modelBuilder.Entity<Jiraissue>().Property(i => i.Fixfor).HasColumnName("FIXFOR");
            modelBuilder.Entity<Jiraissue>().Property(i => i.Component).HasColumnName("COMPONENT");
        }
    }
}
