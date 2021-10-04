﻿using BlogApp.Identity.Models;
using BlogApp.Identity.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Identity.Data
{
    public class BlogAppDbContext : IdentityDbContext<User>
    {
        public BlogAppDbContext(DbContextOptions<BlogAppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(
               users =>
               {
                   users.HasMany(x => x.Claims)
                   .WithOne()
                   .HasForeignKey(x => x.UserId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);

                   users.ToTable("Users").Property(p => p.Id).HasColumnName("UserId");
               });

            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
        }
    }
}
