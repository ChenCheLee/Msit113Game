﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GameAllEntities : DbContext
    {
        public GameAllEntities()
            : base("name=GameAllEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tActiveRegion> tActiveRegion { get; set; }
        public virtual DbSet<tActiveRegionVSMember> tActiveRegionVSMember { get; set; }
        public virtual DbSet<tAD> tAD { get; set; }
        public virtual DbSet<tArticle> tArticle { get; set; }
        public virtual DbSet<tArticleType> tArticleType { get; set; }
        public virtual DbSet<tBuyRecord> tBuyRecord { get; set; }
        public virtual DbSet<tCart> tCart { get; set; }
        public virtual DbSet<tDesigner> tDesigner { get; set; }
        public virtual DbSet<tDesignerVSGame> tDesignerVSGame { get; set; }
        public virtual DbSet<tGame> tGame { get; set; }
        public virtual DbSet<tGameCategories> tGameCategories { get; set; }
        public virtual DbSet<tGameCategoriesVSGame> tGameCategoriesVSGame { get; set; }
        public virtual DbSet<tGameFile> tGameFile { get; set; }
        public virtual DbSet<tGameFileType> tGameFileType { get; set; }
        public virtual DbSet<tGameMechanisms> tGameMechanisms { get; set; }
        public virtual DbSet<tGameMechanismsVSGame> tGameMechanismsVSGame { get; set; }
        public virtual DbSet<tGameTheme> tGameTheme { get; set; }
        public virtual DbSet<tGameThemeVSGame> tGameThemeVSGame { get; set; }
        public virtual DbSet<tMember> tMember { get; set; }
        public virtual DbSet<tPair> tPair { get; set; }
        public virtual DbSet<tPairJoinMember> tPairJoinMember { get; set; }
        public virtual DbSet<tPairRecord> tPairRecord { get; set; }
        public virtual DbSet<tPlayRecord> tPlayRecord { get; set; }
        public virtual DbSet<tPublisher> tPublisher { get; set; }
        public virtual DbSet<tPublisherVSGame> tPublisherVSGame { get; set; }
        public virtual DbSet<tScoreRecord> tScoreRecord { get; set; }
        public virtual DbSet<tTrade> tTrade { get; set; }
        public virtual DbSet<tWishlist> tWishlist { get; set; }
    }
}
