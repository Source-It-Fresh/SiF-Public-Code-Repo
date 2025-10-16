/*
### ### ### ### ### ### ###
SourceItFresh - Copyright (C) 2020
This SiF file is licensed under v3 of the GNU Affero General Public License.
### ### ###
GNU AGPLv3 lets people do almost anything they want with the project, except distributing closed-source versions.

Permissions of this strongest copyleft license are conditioned on:
Making available the complete source code of works and modifications, 
 which include larger works using a licensed work, under the same license.
Copyright and license notices must be preserved.
Contributors provide an express grant of patent rights.
When a modified version is used to provide a service over a network,
 the complete source code of the modified version must be made available.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY,
 without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
### ### ###
See LICENSE.txt for more details or visit <https://www.gnu.org/licenses/>
### ### ### ### ### ### ###
*/

//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
//using Microsoft.Extensions.Configuration;
//using SourceItFresh.Areas.Core_Identity.Data;
using SourceItFresh;
using SourceItFresh.Areas.Base_Discover.Models.dbo;
using SourceItFresh.Areas.Base_Discover.Models.plt;
using SourceItFresh.Areas.Base_Learn.Models.dbo;
using SourceItFresh.Areas.Configure_PaidServices.Models.dbo;
using SourceItFresh.Areas.Configure_Settings.Models.acc;
using SourceItFresh.Areas.Core_Help.Configuration.dbo;
using SourceItFresh.Areas.Core_Help.Models.dbo;
using SourceItFresh.Areas.Core_Help.Models.log;
using SourceItFresh.Areas.Core_Login.Models.acc;
using SourceItFresh.Areas.Core_Login.Models.dbo;
using SourceItFresh.Areas.Manage_Commodities.Configuration.dbo;
using SourceItFresh.Areas.Manage_Commodities.Models.cmd;
using SourceItFresh.Areas.Manage_Commodities.Models.dbo;
using SourceItFresh.Areas.Manage_Farm.Configuration.dbo;
using SourceItFresh.Areas.Manage_Farm.Models.dbo;
using SourceItFresh.Areas.Manage_Farm.Models.frm;
using SourceItFresh.Areas.Manage_Farm.Models.log;
using SourceItFresh.Areas.ManageOrg_Accounts.Models.sec;
using SourceItFresh.Areas.ManageOrg_ActionLogs.Models.log;
using SourceItFresh.Areas.ManageOrg_TraderEntity.Configuration.dbo;
using SourceItFresh.Areas.ManageOrg_TraderEntity.Models.dbo;
using SourceItFresh.Areas.ManageOrg_TraderEntity.Models.trd;
using SourceItFresh.Areas.Market_Consumer.Models.mar;
using SourceItFresh.Areas.Market_Vendor.Configuration.dbo;
using SourceItFresh.Areas.Market_Vendor.Models.dbo;
using SourceItFresh.Areas.Market_Vendor.Models.mar;
using System;
using System.Collections.Generic;
//using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

//ToDo: DB~add .HasComputedColumnSql to modelBuilder.Entity properties

namespace SourceItFresh.AppData.Data
{
    public partial class SIF_Data_DbContext : DbContext
    {
        public SIF_Data_DbContext()
        {
        }

        public SIF_Data_DbContext(DbContextOptions<SIF_Data_DbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(@"Server=localhost;Database=Source_It_Fresh_POC;Trusted_Connection=True;Encrypt=false;MultipleActiveResultSets=true");
                //optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            }
        }

        #region Base_Discover
        #region dbo
        public virtual DbSet<TrefleData> TrefleDatas { get; set; } = null!;
        #endregion dbo

        #region plt
        public virtual DbSet<Division> Divisions { get; set; } = null!;
        public virtual DbSet<DivisionClass> DivisionClasses { get; set; } = null!;
        public virtual DbSet<DivisionClass_DivisionOrder> DivisionClass_DivisionOrders { get; set; } = null!;
        public virtual DbSet<DivisionOrder> DivisionOrders { get; set; } = null!;
        public virtual DbSet<DivisionOrder_Family> DivisionOrder_Families { get; set; } = null!;
        public virtual DbSet<Division_DivisionClass> Division_DivisionClasses { get; set; } = null!;
        public virtual DbSet<Family> Families { get; set; } = null!;
        public virtual DbSet<Family_Genus> Family_Genera { get; set; } = null!;
        public virtual DbSet<Genus> Genera { get; set; } = null!;
        public virtual DbSet<Genus_Plant> Genus_Plants { get; set; } = null!;
        public virtual DbSet<Kingdom> Kingdoms { get; set; } = null!;
        public virtual DbSet<Kingdom_SubKingdom> Kingdom_SubKingdoms { get; set; } = null!;
        public virtual DbSet<Plant> Plants { get; set; } = null!;
        public virtual DbSet<Plant_Species> Plant_Specieses { get; set; } = null!;
        public virtual DbSet<Species> Specieses { get; set; } = null!;
        public virtual DbSet<SubKingdom> SubKingdoms { get; set; } = null!;
        public virtual DbSet<SubKingdom_Division> SubKingdom_Divisions { get; set; } = null!;
        #endregion plt

        #region log
        #endregion log
        #endregion Base_Discover

        #region Base_Learn
        #region dbo
        public virtual DbSet<GoldPriceZ> GoldPriceZs { get; set; } = null!;
        #endregion dbo

        #region ppp
        #endregion ppp

        #region log
        #endregion log
        #endregion Base_Learn

        #region Core_Help
        #region dbo
        public virtual DbSet<FeedbackCategory> FeedbackCategories { get; set; } = null!;
        public virtual DbSet<FeedbackType> FeedbackTypes { get; set; } = null!;
        #endregion dbo

        #region ppp
        #endregion ppp

        #region log
        public virtual DbSet<Feedback> Feedbacks { get; set; } = null!;
        public virtual DbSet<FeedbackMetadata> FeedbackMetadata { get; set; } = null!;
        public virtual DbSet<Response> Responses { get; set; } = null!;
        #endregion log
        #endregion Core_Help

        #region Core_Identity
        #region dbo
        #endregion dbo

        #region acc
        //Identity TBL's
        //public virtual DbSet<SIF_Role> SIF_Roles { get; set; } = null!;
        //public virtual DbSet<SIF_RoleClaim> SIF_RoleClaims { get; set; } = null!;
        //public virtual DbSet<SIF_User> SIF_Users { get; set; } = null!;
        //public virtual DbSet<SIF_UserClaim> SIF_UserClaims { get; set; } = null!;
        //public virtual DbSet<SIF_UserLogin> SIF_UserLogins { get; set; } = null!;
        //public virtual DbSet<SIF_UserRole> SIF_UserRoles { get; set; } = null!;
        //public virtual DbSet<SIF_UserToken> SIF_UserTokens { get; set; } = null!;
        #endregion acc

        #region log
        #endregion log
        #endregion Core_Identity

        #region Core_Login
        #region dbo
        public virtual DbSet<SystemParameter> SystemParameters { get; set; } = null!;
        #endregion dbo

        #region acc
        public virtual DbSet<User_SecurityGroup> User_SecurityGroups { get; set; } = null!;
        public virtual DbSet<User_TraderEntity> User_TraderEntities { get; set; } = null!;
        #endregion acc

        #region log
        #endregion log
        #endregion Core_Login

        #region Configure_AddIns
        #region dbo
        #endregion dbo

        #region ppp
        #endregion ppp

        #region log
        #endregion log
        #endregion Configure_AddIns

        #region Configure_Setting
        #region dbo
        #endregion dbo

        #region acc
        public virtual DbSet<TraderEntitySettingsDatum> TraderEntitySettingsData { get; set; } = null!;
        #endregion acc

        #region log
        #endregion log
        #endregion Configure_Setting

        #region Configure_PaidServices
        #region dbo
        public virtual DbSet<PaidService> PaidServices { get; set; } = null!;
        #endregion dbo

        #region ppp
        #endregion ppp

        #region log
        #endregion log
        #endregion Configure_PaidServices

        #region ManageOrg_TraderEntity
        #region dbo
        public virtual DbSet<MunicipalityDetail> MunicipalityDetails { get; set; } = null!;
        public virtual DbSet<TraderType> TraderTypes { get; set; } = null!;
        #endregion dbo

        #region trd
        public virtual DbSet<TraderContactDetail> TraderContactDetails { get; set; } = null!;
        public virtual DbSet<TraderEntity> TraderEntities { get; set; } = null!;
        public virtual DbSet<TraderLocation> TraderLocations { get; set; } = null!;
        #endregion trd

        #region log
        #endregion log
        #endregion ManageOrg_TraderEntity

        #region ManageOrg_ActionLogs
        #region dbo
        #endregion dbo

        #region ppp
        #endregion ppp

        #region log
        public virtual DbSet<ActionHistory> ActionHistories { get; set; } = null!;
        #endregion log
        #endregion ManageOrg_ActionLogs

        #region ManageOrg_Accounts
        #region dbo
        #endregion dbo

        #region sec
        public virtual DbSet<ApplicationSection> ApplicationSections { get; set; } = null!;
        public virtual DbSet<PermissionDetail> PermissionDetails { get; set; } = null!;
        public virtual DbSet<SecurityGroup> SecurityGroups { get; set; } = null!;
        #endregion sec

        #region log
        #endregion log
        #endregion ManageOrg_Accounts

        #region Manage_Farm
        #region dbo
        public virtual DbSet<CropLifeCycleStage> CropLifeCycleStages { get; set; } = null!;
        public virtual DbSet<FarmAgriculture> FarmAgricultures { get; set; } = null!;
        public virtual DbSet<FarmCulture> FarmCultures { get; set; } = null!;
        public virtual DbSet<GrowMediumDetail> GrowMediumDetails { get; set; } = null!;
        public virtual DbSet<GrowMediumType> GrowMediumTypes { get; set; } = null!;
        public virtual DbSet<GrowSpaceDataEntryType> GrowSpaceDataEntryTypes { get; set; } = null!;
        public virtual DbSet<GrowSpaceLightSourceType> GrowSpaceLightSourceTypes { get; set; } = null!;
        public virtual DbSet<GrowSpaceSetupType> GrowSpaceSetupTypes { get; set; } = null!;
        public virtual DbSet<GrowSpaceType> GrowSpaceTypes { get; set; } = null!;
        public virtual DbSet<ZoneClassification> ZoneClassifications { get; set; } = null!;
        public virtual DbSet<ZoneClimateType> ZoneClimateTypes { get; set; } = null!;
        #endregion dbo

        #region frm
        public virtual DbSet<Farm> Farms { get; set; } = null!;
        public virtual DbSet<GrowSpace> GrowSpaces { get; set; } = null!;
        public virtual DbSet<SubArea> SubAreas { get; set; } = null!;
        public virtual DbSet<Zone> Zones { get; set; } = null!;
        #endregion frm

        #region log
        public virtual DbSet<GrowSpaceDatum> GrowSpaceData { get; set; } = null!;
        public virtual DbSet<SubAreaHarvestDatum> SubAreaHarvestData { get; set; } = null!;
        public virtual DbSet<SubAreaPlantfoodDatum> SubAreaPlantfoodData { get; set; } = null!;
        public virtual DbSet<SubAreaStatusDatum> SubAreaStatusData { get; set; } = null!;
        public virtual DbSet<SubAreaWaterDatum> SubAreaWaterData { get; set; } = null!;
        #endregion log
        #endregion Manage_Farm

        #region Manage_Commodities
        #region dbo
        public virtual DbSet<DeliveryMethod> DeliveryMethods { get; set; } = null!;
        #endregion dbo

        #region cmd
        public virtual DbSet<AvailabilitySchedule> AvailabilitySchedules { get; set; } = null!;
        public virtual DbSet<Commodity> Commodities { get; set; } = null!;
        public virtual DbSet<Consumable> Consumables { get; set; } = null!;
        public virtual DbSet<DeliveryConfig> DeliveryConfigs { get; set; } = null!;
        public virtual DbSet<Packaging> Packagings { get; set; } = null!;
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; } = null!;
        public virtual DbSet<Permit> Permits { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        #endregion cmd

        #region log
        #endregion log
        #endregion Manage_Commodities

        #region Market_Consumer
        #region dbo
        #endregion dbo

        #region mar
        public virtual DbSet<Wishlist> Wishlists { get; set; } = null!;
        #endregion mar

        #region log
        #endregion log
        #endregion Market_Consumer

        #region Market_Vendor
        #region dbo
        public virtual DbSet<CurrencyISO4217> CurrencyISO4217s { get; set; } = null!;
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
        public virtual DbSet<PaymentType> PaymentTypes { get; set; } = null!;
        #endregion dbo

        #region mar
        public virtual DbSet<Credit> Credits { get; set; } = null!;
        public virtual DbSet<Logistic> Logistics { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderProduct> OrderProducts { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Stock> Stocks { get; set; } = null!;
        #endregion mar

        #region log
        #endregion log
        #endregion Market_Vendor

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //// Customize the ASP.NET Identity model and override the defaults if needed.
            //// For example, you can rename the ASP.NET Identity table names and more.
            //// Add your customizations after calling base.OnModelCreating(builder);

            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            #region CustomIdentity

            //modelBuilder.HasDefaultSchema("acc");
            //modelBuilder.Entity<SIF_ApplicationUser>(entity =>
            //{
            //    entity.ToTable(name: "SIF_User");
            //});
            //modelBuilder.Entity<SIF_ApplicationRole>(entity =>
            //{
            //    entity.ToTable(name: "SIF_Role");
            //});
            //modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            //{
            //    entity.ToTable("SIF_UserRoles");
            //});
            //modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            //{
            //    entity.ToTable("SIF_UserClaims");
            //});
            //modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            //{
            //    entity.ToTable("SIF_UserLogins");
            //});
            //modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            //{
            //    entity.ToTable("SIF_RoleClaims");
            //});
            //modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            //{
            //    entity.ToTable("SIF_UserTokens");
            //});

            //builder.Entity<SourceItFresh.Areas.Core_Identity.Data.SIF_ApplicationUser>(entity =>
            //{
            //    entity.Property(e => e.DateCreated).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

            //    entity.Property(e => e.DateModified).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

            //    entity.Property(e => e.RowVersion)
            //        .IsRowVersion()
            //        .IsConcurrencyToken();

            //    entity.HasOne(d => d.DefaultAuthenticationProvider)
            //        .WithMany(p => p.Users)
            //        .HasForeignKey(d => d.DefaultAuthenticationProviderId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_User_defaultAuthenticationProviderId");

            //    entity.HasOne(d => d.FacebookUserInfoFederated)
            //        .WithOne(p => p.User)
            //        .HasForeignKey<SourceItFresh.Areas.Core_Identity.Data.SIF_ApplicationUser>(d => d.FacebookUserInfoFederatedId)
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .HasConstraintName("FK_User_FacebookUserInfo");

            //    entity.HasOne(d => d.GoogleUserInfoFederated)
            //        .WithOne(p => p.User)
            //        .HasForeignKey<SourceItFresh.Areas.Core_Identity.Data.SIF_ApplicationUser>(d => d.GoogleUserInfoFederatedId)
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .HasConstraintName("FK_User_GoogleUserInfo");

            //    entity.HasOne(d => d.MicrosoftUserInfoFederated)
            //        .WithOne(p => p.User)
            //        .HasForeignKey<SourceItFresh.Areas.Core_Identity.Data.SIF_ApplicationUser>(d => d.MicrosoftUserInfoFederatedId)
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .HasConstraintName("FK_User_MicrosoftUserInfo");
            //});

            #endregion CustomIdentity

            #region Base_Discover
            #region dbo
            modelBuilder.Entity<TrefleData>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_TrefleData_id")
                    .IsUnique()
                    .HasFillFactor(90);
            });
            #endregion dbo

            #region plt
            modelBuilder.Entity<Division>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Division_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<DivisionClass>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_DivisionClass_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<DivisionClass_DivisionOrder>(entity =>
            {
                entity.HasKey(e => new { e.DivisionClassId, e.DivisionOrderId });

                entity.HasIndex(e => new { e.DivisionClassId, e.DivisionOrderId }, "UQ_DivisionClass_DivisionOrder_ID")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DivisionClass)
                    .WithMany(p => p.DivisionClass_DivisionOrders)
                    .HasForeignKey(d => d.DivisionClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DivisionClass_DivisionOrder_DivisionClass");

                entity.HasOne(d => d.DivisionOrder)
                    .WithMany(p => p.DivisionClass_DivisionOrders)
                    .HasForeignKey(d => d.DivisionOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DivisionClass_DivisionOrder_DivisionOrder");
            });

            modelBuilder.Entity<DivisionOrder>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_DivisionOrder_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<DivisionOrder_Family>(entity =>
            {
                entity.HasKey(e => new { e.DivisionOrderId, e.FamilyId });

                entity.HasIndex(e => new { e.DivisionOrderId, e.FamilyId }, "UQ_DivisionOrder_Family_ID")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DivisionOrder)
                    .WithMany(p => p.DivisionOrder_Families)
                    .HasForeignKey(d => d.DivisionOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DivisionOrder_Family_Division");

                entity.HasOne(d => d.Family)
                    .WithMany(p => p.DivisionOrder_Families)
                    .HasForeignKey(d => d.FamilyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DivisionOrder_Family_DivisionOrder");
            });

            modelBuilder.Entity<Division_DivisionClass>(entity =>
            {
                entity.HasKey(e => new { e.DivisionId, e.DivisionClassId });

                entity.HasIndex(e => new { e.DivisionId, e.DivisionClassId }, "UQ_Division_DivisionClass_ID")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DivisionClass)
                    .WithMany(p => p.Division_DivisionClasses)
                    .HasForeignKey(d => d.DivisionClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Division_DivisionClass_DivisionClass");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.Division_DivisionClasses)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Division_DivisionClass_Division");
            });

            modelBuilder.Entity<Family>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Family_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Family_Genus>(entity =>
            {
                entity.HasKey(e => new { e.FamilyId, e.GenusId });

                entity.HasIndex(e => new { e.FamilyId, e.GenusId }, "UQ_Family_Genus_ID")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Family)
                    .WithMany(p => p.Family_Genus)
                    .HasForeignKey(d => d.FamilyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Family_Genus_Family");

                entity.HasOne(d => d.Genus)
                    .WithMany(p => p.Family_Genus)
                    .HasForeignKey(d => d.GenusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Family_Genus_Genus");
            });

            modelBuilder.Entity<Genus>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Genus_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Genus_Plant>(entity =>
            {
                entity.HasKey(e => new { e.GenusId, e.PlantId });

                entity.HasIndex(e => new { e.GenusId, e.PlantId }, "UQ_Genus_Plant_ID")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Genus)
                    .WithMany(p => p.Genus_Plants)
                    .HasForeignKey(d => d.GenusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Genus_Plant_Genus");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Genus_Plants)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Genus_Plant_Plant");
            });

            modelBuilder.Entity<Kingdom>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Kingdom_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Kingdom_SubKingdom>(entity =>
            {
                entity.HasKey(e => new { e.KingdomId, e.SubKingdomId });

                entity.HasIndex(e => new { e.KingdomId, e.SubKingdomId }, "UQ_Kingdom_SubKingdom_ID")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Kingdom)
                    .WithMany(p => p.Kingdom_SubKingdoms)
                    .HasForeignKey(d => d.KingdomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kingdom_SubKingdom_Kingdom");

                entity.HasOne(d => d.SubKingdom)
                    .WithMany(p => p.Kingdom_SubKingdoms)
                    .HasForeignKey(d => d.SubKingdomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kingdom_SubKingdom_SubKingdom");
            });

            modelBuilder.Entity<Plant>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Plant_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Plant_Species>(entity =>
            {
                entity.HasKey(e => new { e.PlantId, e.SpeciesId });

                entity.HasIndex(e => new { e.PlantId, e.SpeciesId }, "UQ_Plant_Species_ID")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Plant_Species)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plant_Species_Plant");

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.Plant_Species)
                    .HasForeignKey(d => d.SpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plant_Species_Species");
            });

            modelBuilder.Entity<Species>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Species_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<SubKingdom>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_SubKingdom_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<SubKingdom_Division>(entity =>
            {
                entity.HasKey(e => new { e.SubKingdomId, e.DivisionId });

                entity.HasIndex(e => new { e.SubKingdomId, e.DivisionId }, "UQ_SubKingdom_Division_ID")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.SubKingdom_Divisions)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubKingdom_Division_Division");

                entity.HasOne(d => d.SubKingdom)
                    .WithMany(p => p.SubKingdom_Divisions)
                    .HasForeignKey(d => d.SubKingdomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubKingdom_Division_SubKingdom");
            });
            #endregion plt

            #region log
            #endregion log
            #endregion Base_Discover

            #region Base_Learn
            #region dbo
            #endregion dbo

            #region ppp
            #endregion ppp

            #region log
            #endregion log
            #endregion Base_Learn

            #region Core_Help
            #region dbo
            modelBuilder.Entity<FeedbackCategory>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ_FeedbackCategory_Name")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<FeedbackType>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ_FeedbackType_Name")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });
            #endregion dbo

            #region ppp
            #endregion ppp

            #region log
            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Feedback_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FeedbackCategory)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.FeedbackCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_FeedbackCategory");

                entity.HasOne(d => d.FeedbackMetadata)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.FeedbackMetadataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_FeedbackMetadata");

                entity.HasOne(d => d.FeedbackType)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.FeedbackTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_FeedbackType");
            });

            modelBuilder.Entity<FeedbackMetadata>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_FeedbackMetadata_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Response>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Response_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Feedback)
                    .WithMany(p => p.Responses)
                    .HasForeignKey(d => d.FeedbackId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Response_Feedback");
            });
            #endregion log
            #endregion Core_Help

            #region Core_Identity
            #region dbo
            #endregion dbo

            #region acc
            //modelBuilder.Entity<SIF_Role>(entity =>
            //{
            //    entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
            //        .IsUnique()
            //        .HasFilter("([NormalizedName] IS NOT NULL)");
            //});

            //SIF_RoleClaim

            //modelBuilder.Entity<SIF_User>(entity =>
            //{
            //    entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
            //        .IsUnique()
            //        .HasFilter("([NormalizedUserName] IS NOT NULL)");

            //    entity.HasMany(d => d.Roles)
            //        .WithMany(p => p.Users)
            //        .UsingEntity<Dictionary<string, object>>(
            //            "SifUserRole",
            //            l => l.HasOne<SifRole>().WithMany().HasForeignKey("RoleId"),
            //            r => r.HasOne<SifUser>().WithMany().HasForeignKey("UserId"),
            //            j =>
            //            {
            //                j.HasKey("UserId", "RoleId");

            //                j.ToTable("SIF_UserRole", "acc");

            //                j.HasIndex(new[] { "RoleId" }, "IX_SIF_UserRole_RoleId");
            //            });
            //});

            //SIF_UserClaim

            //modelBuilder.Entity<SIF_UserLogin>(entity =>
            //{
            //    entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
            //});

            //SIF_UserRole

            //modelBuilder.Entity<SIF_UserToken>(entity =>
            //{
            //    entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            //});
            #endregion acc

            #region log
            #endregion log
            #endregion Core_Identity

            #region Core_Login
            #region dbo
            modelBuilder.Entity<SystemParameter>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ_SystemParameter_Name")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });
            #endregion dbo

            #region acc
            modelBuilder.Entity<User_SecurityGroup>(entity =>
            {
                entity.HasKey(e => new { e.UserBaseId, e.SecurityGroupId });

                entity.HasIndex(e => new { e.UserBaseId, e.SecurityGroupId }, "UQ_User_SecurityGroup_Id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                //entity.HasOne(d => d.SecurityGroup)
                //    .WithMany(p => p.User_SecurityGroups)
                //    .HasForeignKey(d => d.SecurityGroupId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_User_SecurityGroup_SecurityGroup");

                //entity.HasOne(d => d.UserBase)
                //    .WithMany(p => p.User_SecurityGroups)
                //    .HasForeignKey(d => d.UserBaseId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_User_SecurityGroup_User");
            });

            modelBuilder.Entity<User_TraderEntity>(entity =>
            {
                entity.HasKey(e => new { e.UserBaseId, e.TraderEntityId });

                entity.HasIndex(e => new { e.UserBaseId, e.TraderEntityId }, "UQ_User_TraderEntity_Id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                //entity.HasOne(d => d.TraderEntity)
                //    .WithMany(p => p.User_TraderEntities)
                //    .HasForeignKey(d => d.TraderEntityId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_User_TraderEntity_TraderEntity");

                //entity.HasOne(d => d.TraderEntitySettingsDatum)
                //    .WithMany(p => p.UserTraderEntities)
                //    .HasForeignKey(d => d.TraderEntitySettingsDatumId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_User_TraderEntity_TraderEntitySettingsDatum");

                //entity.HasOne(d => d.UserBase)
                //    .WithMany(p => p.User_TraderEntities)
                //    .HasForeignKey(d => d.UserBaseId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_User_TraderEntity_User");
            });
            #endregion acc

            #region log
            #endregion log
            #endregion Core_Login

            #region Configure_AddIns
            #region dbo
            #endregion dbo

            #region ppp
            #endregion ppp

            #region log
            #endregion log
            #endregion Configure_AddIns

            #region Configure_Setting
            #region dbo
            #endregion dbo

            #region acc
            modelBuilder.Entity<TraderEntitySettingsDatum>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_TraderEntitySettingsDatum_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                //entity.Property(e => e.DateModified).HasComputedColumnSql("(getutcdate())", stored: true);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                //entity.HasOne(d => d.UserCreatedNavigation)
                //    .WithMany(p => p.TraderEntityuserCreatedNavigations)
                //    .HasForeignKey(d => d.UserCreated)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_TraderEntity_UserC");

                //entity.HasOne(d => d.UserModifiedNavigation)
                //    .WithMany(p => p.TraderEntityuserModifiedNavigations)
                //    .HasForeignKey(d => d.UserModified)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_TraderEntity_UserM");
            });
            #endregion acc

            #region log
            #endregion log
            #endregion Configure_Setting

            #region Configure_PaidServices
            #region dbo
            modelBuilder.Entity<PaidService>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_PaidService_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });
            #endregion dbo

            #region ppp
            #endregion ppp

            #region log
            #endregion log
            #endregion Configure_PaidServices

            #region ManageOrg_TraderEntity
            #region dbo
            modelBuilder.Entity<MunicipalityDetail>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ_MunicipalityDetail_Name")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TraderType>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ_TraderType_Name")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });
            #endregion dbo

            #region trd
            modelBuilder.Entity<TraderContactDetail>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_TraderContactDetail_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateModified).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                //entity.HasOne(d => d.UserModifiedNavigation)
                //    .WithMany(p => p.TraderContactDetails)
                //    .HasForeignKey(d => d.UserModified)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_TraderContactDetail_User");
            });

            modelBuilder.Entity<TraderEntity>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_TraderEntity_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateModified).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VatNumber).HasDefaultValueSql("('Not Supplied')");

                entity.HasOne(d => d.ContactDetails)
                    .WithMany(p => p.TraderEntities)
                    .HasForeignKey(d => d.ContactDetailId)
                    .HasConstraintName("FK_TraderEntity_TraderContactDetail");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.TraderEntities)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_TraderEntity_TraderLocation");

                entity.HasOne(d => d.TraderType)
                    .WithMany(p => p.TraderEntities)
                    .HasForeignKey(d => d.TraderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraderEntity_TraderType");

                //entity.HasOne(d => d.UserCreatedNavigation)
                //    .WithMany(p => p.TraderEntityuserCreatedNavigations)
                //    .HasForeignKey(d => d.UserCreated)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_TraderEntity_UserC");

                //entity.HasOne(d => d.UserModifiedNavigation)
                //    .WithMany(p => p.TraderEntityuserModifiedNavigations)
                //    .HasForeignKey(d => d.UserModified)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_TraderEntity_UserM");
            });

            modelBuilder.Entity<TraderLocation>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_TraderLocation_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateModified).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.MunicipalityId).HasDefaultValueSql("('00000000-0000-0000-0000-000000000000')");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Municipality)
                    .WithMany(p => p.TraderLocations)
                    .HasForeignKey(d => d.MunicipalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraderLocation_MunicipalityDetail");

                //entity.HasOne(d => d.UserModifiedNavigation)
                //    .WithMany(p => p.TraderLocations)
                //    .HasForeignKey(d => d.UserModified)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_TraderLocation_User");
            });
            #endregion trd

            #region log
            #endregion log
            #endregion ManageOrg_TraderEntity

            #region ManageOrg_ActionLogs
            #region dbo
            #endregion dbo

            #region ppp
            #endregion ppp

            #region log
            modelBuilder.Entity<ActionHistory>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_ActionHistory_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                //entity.HasOne(d => d.Area)
                //    .WithMany(p => p.ActionHistories)
                //    .HasForeignKey(d => d.AreaId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_ActionHistory_ApplicationSection");

                //entity.HasOne(d => d.BaseUser)
                //    .WithMany(p => p.ActionHistories)
                //    .HasForeignKey(d => d.BaseUserId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_ActionHistory_User");

                //entity.HasOne(d => d.TraderEntity)
                //    .WithMany(p => p.ActionHistories)
                //    .HasForeignKey(d => d.TraderEntityId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_ActionHistory_TraderEntity");
            });
            #endregion log
            #endregion ManageOrg_ActionLogs

            #region ManageOrg_Accounts
            #region dbo
            #endregion dbo

            #region sec
            modelBuilder.Entity<ApplicationSection>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ_ApplicationSection_Name")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<PermissionDetail>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_PermissionDetail_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateModified).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ApplicationSection)
                    .WithMany(p => p.PermissionDetails)
                    .HasForeignKey(d => d.ApplicationSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionDetail_ApplicationSection");

                entity.HasOne(d => d.SecurityGroup)
                    .WithMany(p => p.PermissionDetails)
                    .HasForeignKey(d => d.SecurityGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionDetail_SecurityGroup");

                //entity.HasOne(d => d.UserModifiedNavigation)
                //    .WithMany(p => p.PermissionDetails)
                //    .HasForeignKey(d => d.UserModified)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_PermissionDetail_User");
            });

            modelBuilder.Entity<SecurityGroup>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_SecurityGroup_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateModified).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                //entity.HasOne(d => d.TraderEntityOwner)
                //    .WithMany(p => p.SecurityGroups)
                //    .HasForeignKey(d => d.TraderEntityOwnerId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_SecurityGroup_TraderEntity");

                //entity.HasOne(d => d.UserCreatedNavigation)
                //    .WithMany(p => p.SecurityGroupuserCreatedNavigations)
                //    .HasForeignKey(d => d.UserCreated)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_SecurityGroup_UserC");

                //entity.HasOne(d => d.UserModifiedNavigation)
                //    .WithMany(p => p.SecurityGroupuserModifiedNavigations)
                //    .HasForeignKey(d => d.UserModified)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_SecurityGroup_UserM");
            });
            #endregion sec

            #region log
            #endregion log
            #endregion ManageOrg_Accounts

            #region Manage_Farm
            #region dbo
            modelBuilder.Entity<CropLifeCycleStage>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_CropLifeCycleStage_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<FarmAgriculture>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_FarmAgriculture_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<FarmCulture>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_FarmCulture_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<GrowMediumDetail>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_GrowMediumDetail_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.GrowMediumType)
                    .WithMany(p => p.GrowMediumDetails)
                    .HasForeignKey(d => d.GrowMediumTypeId)
                    .HasConstraintName("FK_GrowMediumDetail_growMediumTypeId");
            });

            modelBuilder.Entity<GrowMediumType>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_GrowMediumType_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<GrowSpaceDataEntryType>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_GrowSpaceDataEntryType_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<GrowSpaceLightSourceType>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_GrowSpaceLightSourceType_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<GrowSpaceSetupType>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_GrowSpaceSetupType_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<GrowSpaceType>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_GrowSpaceType_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ZoneClassification>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_ZoneClassification_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ZoneClimateType>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_ZoneClimatType_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });
            #endregion dbo

            #region frm
            modelBuilder.Entity<Farm>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Farm_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                //entity.Property(e => e.DiseaseControlManagement).HasDefaultValueSql("((1))");

                //entity.Property(e => e.EnergyManagement).HasDefaultValueSql("((1))");

                //entity.Property(e => e.NutrientsManagement).HasDefaultValueSql("((1))");

                //entity.Property(e => e.PestsManagement).HasDefaultValueSql("((1))");

                entity.Property(e => e.PropertyArea_m2).HasDefaultValueSql("((0))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                //entity.Property(e => e.SoilAndGrowMedium).HasDefaultValueSql("((1))");

                //entity.Property(e => e.SustainabilityManagement).HasDefaultValueSql("((1))");

                //entity.Property(e => e.WaterManagement).HasDefaultValueSql("((1))");

                //entity.Property(e => e.WeedsManagement).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.AgricultureApproach)
                    .WithMany(p => p.Farms)
                    .HasForeignKey(d => d.AgricultureApproachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Farm_agricultureApproachId");

                entity.HasOne(d => d.Culture)
                    .WithMany(p => p.Farms)
                    .HasForeignKey(d => d.CultureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Farm_cultureId");

                //entity.HasOne(d => d.TraderEntity)
                //    .WithMany(p => p.Farms)
                //    .HasForeignKey(d => d.TraderEntityId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Farm_traderEntityId");
            });

            modelBuilder.Entity<GrowSpace>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_GrowSpace_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                //entity.HasOne(d => d.AssignedWorker)
                //    .WithMany(p => p.GrowSpaces)
                //    .HasForeignKey(d => d.AssignedWorkerId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_GrowSpace_assignedWorkerId");

                entity.HasOne(d => d.GrowmediumType)
                    .WithMany(p => p.GrowSpaces)
                    .HasForeignKey(d => d.GrowMediumTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrowSpace_growmediumTypeId");

                entity.HasOne(d => d.GrowSpaceType)
                    .WithMany(p => p.GrowSpaces)
                    .HasForeignKey(d => d.GrowSpaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrowSpace_growSpaceTypeId");

                entity.HasOne(d => d.GrowSpaceSetupType)
                    .WithMany(p => p.GrowSpaces)
                    .HasForeignKey(d => d.SetupTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zone_setupTypeIdId");

                entity.HasOne(d => d.LightSourceType)
                    .WithMany(p => p.GrowSpaces)
                    .HasForeignKey(d => d.LightSourceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrowSpace_lightSourceTypeId");

                entity.HasOne(d => d.Zone)
                    .WithMany(p => p.GrowSpaces)
                    .HasForeignKey(d => d.ZoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrowSpace_zoneId");
            });

            modelBuilder.Entity<SubArea>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_SubArea_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DatePlanted).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.EstHarvestDate).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                //entity.HasOne(d => d.Crop)
                //    .WithMany(p => p.SubAreas)
                //    .HasForeignKey(d => d.CropId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_SubArea_cropId");

                entity.HasOne(d => d.GrowSpace)
                    .WithMany(p => p.SubAreas)
                    .HasForeignKey(d => d.GrowSpaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubArea_growSpaceId");
            });

            modelBuilder.Entity<Zone>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Zone_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ClimateTypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ClassificationType)
                    .WithMany(p => p.Zones)
                    .HasForeignKey(d => d.ClassificationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zone_classificationTypeId");

                entity.HasOne(d => d.ClimateType)
                    .WithMany(p => p.Zones)
                    .HasForeignKey(d => d.ClimateTypeId)
                    .HasConstraintName("FK_Zone_climateTypeId");

                entity.HasOne(d => d.Farm)
                    .WithMany(p => p.Zones)
                    .HasForeignKey(d => d.FarmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zone_farmId");

                //entity.HasOne(d => d.ManagerBaseUser)
                //    .WithMany(p => p.Zones)
                //    .HasForeignKey(d => d.ManagerBaseUserId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Zone_managerBaseUserId");
            });
            #endregion frm

            #region log
            modelBuilder.Entity<GrowSpaceDatum>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_GrowSpaceDatum_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.EntryType)
                    .WithMany(p => p.GrowSpaceData)
                    .HasForeignKey(d => d.EntryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrowSpaceDatum_entryTypeId");

                entity.HasOne(d => d.GrowSpace)
                    .WithMany(p => p.GrowSpaceData)
                    .HasForeignKey(d => d.GrowSpaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrowSpaceDatum_growSpaceId");
            });

            modelBuilder.Entity<SubAreaHarvestDatum>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_SubAreaHarvestDatum_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateHarvested).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                //entity.HasOne(d => d.Plant)
                //    .WithMany(p => p.SubAreaHarvestData)
                //    .HasForeignKey(d => d.PlantId)
                //    .HasConstraintName("FK_SubAreaHarvestDatum_Plant");

                entity.HasOne(d => d.SubArea)
                    .WithMany(p => p.SubAreaHarvestData)
                    .HasForeignKey(d => d.SubAreaId)
                    .HasConstraintName("FK_SubAreaHarvestDatum_SubArea");
            });

            modelBuilder.Entity<SubAreaPlantfoodDatum>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_SubAreaPlantfoodDatum_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.SubArea)
                    .WithMany(p => p.SubAreaPlantfoodData)
                    .HasForeignKey(d => d.SubAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubAreaPlantfoodDatum_subAreaId");
            });

            modelBuilder.Entity<SubAreaStatusDatum>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_SubAreaStatusDatum_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CropLifeCycleStage)
                    .WithMany(p => p.SubAreaStatusData)
                    .HasForeignKey(d => d.CropLifeCycleStageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubAreaStatusDatum_cropLifeCycleStageId");

                entity.HasOne(d => d.SubArea)
                    .WithMany(p => p.SubAreaStatusData)
                    .HasForeignKey(d => d.SubAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubAreaStatusDatum_subAreaId");
            });

            modelBuilder.Entity<SubAreaWaterDatum>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_SubAreaWaterDatum_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.SubArea)
                    .WithMany(p => p.SubAreaWaterData)
                    .HasForeignKey(d => d.SubAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubAreaWaterDatum_subAreaId");
            });
            #endregion log
            #endregion Manage_Farm

            #region Manage_Commodities
            #region dbo
            modelBuilder.Entity<DeliveryMethod>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_DeliveryMethod_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });
            #endregion dbo

            #region cmd
            modelBuilder.Entity<AvailabilitySchedule>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_AvailabilitySchedule_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Commodity)
                    .WithMany(p => p.AvailabilitySchedules)
                    .HasForeignKey(d => d.CommodityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AvailabilitySchedule_Commodity");

                entity.HasOne(d => d.DeliveryConfig)
                    .WithMany(p => p.AvailabilitySchedules)
                    .HasForeignKey(d => d.DeliveryConfigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AvailabilitySchedule_DeliveryConfig");
            });

            modelBuilder.Entity<Commodity>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Commodity_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                //entity.HasOne(d => d.TraderEntity)
                //    .WithMany(p => p.Commodities)
                //    .HasForeignKey(d => d.TraderEntityId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Commodity_traderEntityId");
            });

            modelBuilder.Entity<Consumable>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Consumable_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateProduced).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Commodity)
                    .WithMany(p => p.Consumables)
                    .HasForeignKey(d => d.CommodityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Consumable_Commodity");

                //entity.HasOne(d => d.Harvest)
                //    .WithMany(p => p.Consumables)
                //    .HasForeignKey(d => d.HarvestId)
                //    .HasConstraintName("FK_Consumable_SubAreaHarvestDatum");

                //entity.HasOne(d => d.Plant)
                //    .WithMany(p => p.Consumables)
                //    .HasForeignKey(d => d.PlantId)
                //    .HasConstraintName("FK_Consumable_Plant");
            });

            modelBuilder.Entity<DeliveryConfig>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_DeliveryConfig_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Commodity)
                    .WithMany(p => p.DeliveryConfigs)
                    .HasForeignKey(d => d.CommodityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeliveryConfig_Commodity");

                entity.HasOne(d => d.DeliveryMethod)
                    .WithMany(p => p.DeliveryConfigs)
                    .HasForeignKey(d => d.DeliveryMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeliveryConfig_DeliveryMethod");
            });

            modelBuilder.Entity<Packaging>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Packaging_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Commodity)
                    .WithMany(p => p.Packagings)
                    .HasForeignKey(d => d.CommodityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Packaging_Commodity");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_PaymentMethod_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Commodity)
                    .WithMany(p => p.PaymentMethods)
                    .HasForeignKey(d => d.CommodityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentMethod_Commodity");

                //entity.HasOne(d => d.PaymentType)
                //    .WithMany(p => p.PaymentMethods)
                //    .HasForeignKey(d => d.PaymentTypeId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_PaymentMethod_PaymentType");
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_PaymentMethod_PaymentType");
            });

            modelBuilder.Entity<Permit>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Permit_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ExpirationDate).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.IssuedDate).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Commodity)
                    .WithMany(p => p.Permits)
                    .HasForeignKey(d => d.CommodityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permit_Commodity");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Product_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DatePackaged).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SaleEndDate).HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.HasOne(d => d.Commodity)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CommodityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Commodity");

                entity.HasOne(d => d.Consumable)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ConsumableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Consumable");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Package");
            });
            #endregion cmd

            #region log
            #endregion log
            #endregion Manage_Commodities

            #region Market_Consumer
            #region dbo
            #endregion dbo

            #region mar
            modelBuilder.Entity<Wishlist>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Wishlist_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });
            #endregion mar

            #region log
            #endregion log
            #endregion Market_Consumer

            #region Market_Vendor
            #region dbo
            modelBuilder.Entity<CurrencyISO4217>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_CurrencyISO4217_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_OrderStatus_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_PaymentType_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });
            #endregion dbo

            #region mar
            modelBuilder.Entity<Credit>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Credit_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                //entity.HasOne(d => d.Creditor)
                //    .WithMany(p => p.CreditCreditors)
                //    .HasForeignKey(d => d.CreditorId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Credit_creditorId");

                entity.HasOne(d => d.CurrencyISO4217)
                    .WithMany(p => p.Credits)
                    .HasForeignKey(d => d.CurrencyISO4217Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Credit_currencyISO4217Id");

                //entity.HasOne(d => d.Debtor)
                //    .WithMany(p => p.CreditDebtors)
                //    .HasForeignKey(d => d.DebtorId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Credit_debtorId");
            });

            modelBuilder.Entity<Logistic>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Logistic_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                //entity.HasOne(d => d.DeliveryConfig)
                //    .WithMany(p => p.Logistics)
                //    .HasForeignKey(d => d.DeliveryConfigId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Logistics_deliveryConfigId");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Logistics)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Logistics_orderId");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Order_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                //entity.HasOne(d => d.Buyer_TE)
                //    .WithMany(p => p.Orders)
                //    .HasForeignKey(d => d.Buyer_TE_Id)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Order_buyer_TE_Id");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_orderStatusId");
            });

            modelBuilder.Entity<OrderProduct>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_OrderProducts_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CurrencyISO4217)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.CurrencyISO4217Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderProducts_currencyISO4217Id");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderProducts_orderId");

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.OrderProducts)
                //    .HasForeignKey(d => d.ProductId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_OrderProducts_productId");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Payment_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CurrencyISO4217)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.CurrencyISO4217Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_currencyISO4217Id");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_orderId");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_paymentTypeId");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ_Stock_id")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });
            #endregion mar

            #region log
            #endregion log
            #endregion Market_Vendor

            #region Initialize dbo db data with config seeds

            //modelBuilder.ApplyConfiguration(new SourceItFresh.Configuration.dbo.SystemParameterConfiguration());
            //modelBuilder.ApplyConfiguration(new SourceItFresh.Configuration.dbo.PaidServiceConfiguration());
            modelBuilder.ApplyConfiguration(new FeedbackTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FeedbackCategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new AuthenticationProvidersConfiguration());
            modelBuilder.ApplyConfiguration(new TraderTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new SourceItFresh.Configuration.dbo.MunicipalityDetailConfiguration());
            modelBuilder.ApplyConfiguration(new FarmCultureConfiguration());
            modelBuilder.ApplyConfiguration(new FarmAgricultureConfiguration());
            modelBuilder.ApplyConfiguration(new ZoneClassificationConfiguration());
            modelBuilder.ApplyConfiguration(new GrowSpaceSetupTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ZoneClimateTypeConfiguration());
            modelBuilder.ApplyConfiguration(new GrowSpaceTypeConfiguration());
            modelBuilder.ApplyConfiguration(new GrowSpaceLightSourceTypeConfiguration());
            modelBuilder.ApplyConfiguration(new GrowSpaceDataEntryTypeConfiguration());
            modelBuilder.ApplyConfiguration(new GrowMediumTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new GrowMediumDetailConfiguration());
            modelBuilder.ApplyConfiguration(new CropLifeCycleStageConfiguration());
            modelBuilder.ApplyConfiguration(new OrderStatusConfiguration());
            modelBuilder.ApplyConfiguration(new DeliveryMethodConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CurrencyISO4217Configuration());
            //modelBuilder.ApplyConfiguration(new TrefleDataConfiguration());

            #endregion Initialize dbo db data with config seeds

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}