using ASP.NetCV.Models.Entities;
using ASP.NetCV.Models.Entities.Membership;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCV.Models.DataContext
{
    public class CvDbContext:IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public CvDbContext(DbContextOptions<CvDbContext> options): base(options)
        {

        }
        // Database olan membershiplerin ADi qabaginda bu kod vasitesile qeyd edrik
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>(e => {
                // adi   //ADI qabagindaki
                e.ToTable("Users", "Membership");

            });

            builder.Entity<Role>(e => {
           
                e.ToTable("Roles", "Membership");

            });

            builder.Entity<UserRole>(e => {
                
                e.ToTable("UserRoles", "Membership");

            });

            builder.Entity<UserClaim>(e => {
               
                e.ToTable("UserClaims", "Membership");

            });

            builder.Entity<RoleClaim>(e => {
                
                e.ToTable("RoleClaims", "Membership");

            });
            builder.Entity<UserToken>(e => {
            
                e.ToTable("UserTokens", "Membership");

            });
            builder.Entity<UserLogin>(e => {
                
                e.ToTable("UserLogins", "Membership");

            });
        }

        public DbSet<Skills> Skills { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<UserInfo> userInfos { get; set; }
        public DbSet<BioSkilsInfo> BioSkilsInfos { get; set; }
        public DbSet<Expirence> Expirences { get; set; }
        public DbSet<ResumeSkils> ResumeSkils { get; set; } 
        public DbSet<ResumeBackground> ResumeBackgrounds { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; } 
        
        public DbSet<ContactPost> ContactPosts { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Icons> Icons { get; set; }
        public DbSet<Services> Services { get; set; } 
        




    }
}
