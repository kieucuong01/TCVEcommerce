using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace TCVShared.Data
{
    public class AppDBContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<MediaAlbum> MediaAlbums { get; set; }
        public virtual DbSet<MediaFile> MediaFiles { get; set; }
        public virtual DbSet<Taxonomy> Taxonomies { get; set; }
        public virtual DbSet<BlogPost> BlogPosts { get; set; }
        public virtual DbSet<BlogPostTaxo> BlogPostTaxoes { get; set; }

        public virtual DbSet<UserThread> UserThreads { get; set; }
        public virtual DbSet<UserMessage> UserMessages { get; set; }

        public virtual DbSet<ShopAttrib> ShopAttribs { get; set; }
        public virtual DbSet<ShopItem> ShopItems { get; set; }
        public virtual DbSet<ShopItemTaxo> ShopItemTaxoes { get; set; }
        public virtual DbSet<ShopItemAttrib> ShopItemAttribs { get; set; }
        public virtual DbSet<ShopCart> ShopCarts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<ShopWish> ShopWishes { get; set; }
        public virtual DbSet<WishItem> WishItems { get; set; }
        public virtual DbSet<ShopOrder> ShopOrders { get; set; }

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

