using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AbilitySaleCloud.Articles.Models.DatabaseContext.Base;

namespace AbilitySaleCloud.Articles.Models.DatabaseContext
{
    public class ArticleContext : DbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }

        public DbSet<ArticlePrices> ArticlePrices { get; set; }

        public DbSet<ArticleActivation> ArticleActivations { get; set; }

        public DbSet<ArticleGroups> ArticleGroups { get; set; }

        public DbSet<ArticleActivity> ArticleActivities { get; set; }

        public DbSet<ArticlePackages> ArticlePackages { get; set; }

        public DbSet<TaxGroup> TaxGroups { get; set; }

        public DbSet<UoMGroup> UoMGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Article>()
                .HasQueryFilter(c => !c.IsDeleted)
                .HasOne(c => c.CreatedBy);
            //.OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<ArticleGroups>()
                .HasOne(c => c.CreatedBy);
            //.OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<TaxGroup>()
                .HasOne(c => c.CreatedBy);
            //.OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<UoMGroup>()
                .HasOne(c => c.CreatedBy);
            //.OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }

        private void ApplyAuditInformation()
            => this.ChangeTracker
                .Entries()
                .ToList()
                .ForEach(entry =>
                {
                    var userName = "betty"; //this.currentUser.GetUserName();

                    if (entry.Entity is IDeletableEntity deletableEntity)
                    {
                        if (entry.State == EntityState.Deleted)
                        {
                            deletableEntity.DeletedOn = DateTime.UtcNow;
                            deletableEntity.DeletedBy = userName;
                            deletableEntity.IsDeleted = true;

                            entry.State = EntityState.Modified;

                            return;
                        }
                    }

                    if (entry.Entity is IEntity entity)
                    {
                        if (entry.State == EntityState.Added)
                        {
                            entity.CreatedOn = DateTime.UtcNow;
                            entity.CreatedBy = userName;
                        }
                        else if (entry.State == EntityState.Modified)
                        {
                            entity.ModifiedOn = DateTime.UtcNow;
                            entity.ModifiedBy = userName;
                        }
                    }
                });
    }
}

