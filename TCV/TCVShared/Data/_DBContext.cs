using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace TCVShared.Data
{
    public class AppDBContext : IdentityDbContext<AppUser>
    {
        public AppDBContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AccountLog>(b =>
            {
                b.HasIndex(e => e.Action);
                b.HasIndex(e => e.LogTime);
            });

            builder.Entity<Campaign>(b =>
            {
                b.HasIndex(e => e.Code).IsUnique();
            });

            builder.Entity<Taxonomy>(b =>
            {
                b.HasIndex(e => new { e.Name, e.Type });
            });

            builder.Entity<ShopItem>(b =>
            {
                b.HasIndex(e => e.SKU).IsUnique();
                b.HasIndex(e => e.Name);
            });
        }
    }
}

