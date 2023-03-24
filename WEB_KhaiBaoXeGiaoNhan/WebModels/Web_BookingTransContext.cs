﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.Common;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WEB_KhaiBaoXeGiaoNhan.WebModels
{
    public partial class Web_BookingTransContext : DbContext
    {
        public Web_BookingTransContext()
        {
        }

        public Web_BookingTransContext(DbContextOptions<Web_BookingTransContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CompanyModel> CompanyModel { get; set; }
        public virtual DbSet<CungDuongModel> CungDuongModel { get; set; }
        public virtual DbSet<CustomerModel> CustomerModel { get; set; }
        public virtual DbSet<DriverRegister> DriverRegister { get; set; }
        public virtual DbSet<OrderMapping> OrderMapping { get; set; }
        public virtual DbSet<PogiaKhacMapping> PogiaKhacMapping { get; set; }
        public virtual DbSet<PolineModel> PolineModel { get; set; }
        public virtual DbSet<PomasterModel> PomasterModel { get; set; }
        public virtual DbSet<ProviderModel> ProviderModel { get; set; }
        public virtual DbSet<SolineModel> SolineModel { get; set; }
        public virtual DbSet<SomasterModel> SomasterModel { get; set; }
        public virtual DbSet<SyncTable> SyncTable { get; set; }
        public virtual DbSet<TransportModel> TransportModel { get; set; }
        public virtual DbSet<UserModel> UserModel { get; set; }
        public virtual DbSet<VehicleInfoMapping> VehicleInfoMapping { get; set; }
        public virtual DbSet<VehicleModel> VehicleModel { get; set; }
        public virtual DbSet<VehicleOwnerModel> VehicleOwnerModel { get; set; }
        public virtual DbSet<VehicleRegisterMobileModel> VehicleRegisterMobileModel { get; set; }
        public virtual DbSet<VehicleRegisterPodetailModel> VehicleRegisterPodetailModel { get; set; }
        public virtual DbSet<VehicleVehicleOwnerMapping> VehicleVehicleOwnerMapping { get; set; }
        public virtual DbSet<RegisterForShip> RegisterForShip { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Config.getInstance().connWeb);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyModel>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyName).HasMaxLength(200);
            });

            modelBuilder.Entity<CungDuongModel>(entity =>
            {
                entity.HasKey(e => e.CungDuongCode);

                entity.Property(e => e.CungDuongCode).ValueGeneratedNever();

                entity.Property(e => e.CungDuongName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.KhoangCach).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Plant)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerModel>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Address).HasMaxLength(4000);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CungDuongName).HasMaxLength(500);

                entity.Property(e => e.CustomerCode).HasMaxLength(100);

                entity.Property(e => e.CustomerName).HasMaxLength(1000);

                entity.Property(e => e.IsSapdata).HasColumnName("isSAPData");

                entity.Property(e => e.LastEditedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DriverRegister>(entity =>
            {
                entity.HasKey(e => e.DriverId);

                entity.Property(e => e.DriverId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DriverCardNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DriverName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.VehicleNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<OrderMapping>(entity =>
            {
                entity.HasKey(e => e.MappingId)
                    .HasName("PK_OrderMapping_1");

                entity.Property(e => e.MappingId)
                    .HasColumnName("MappingID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BillNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.MasterId).HasColumnName("MasterID");

                entity.Property(e => e.OrderNumber).HasMaxLength(50);

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
                
                entity.Property(e => e.ShipNumber).HasMaxLength(200);

                entity.Property(e => e.SoLuong).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SoLuongCont).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<PogiaKhacMapping>(entity =>
            {
                entity.ToTable("POGiaKhacMapping");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.PoNumber)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PolineModel>(entity =>
            {
                entity.HasKey(e => new { e.Ponumber, e.Poline })
                    .HasName("PK_POLineModel_1");

                entity.ToTable("POLineModel");

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(100);

                entity.Property(e => e.Poline)
                    .HasColumnName("POLine")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyCode).HasMaxLength(100);

                entity.Property(e => e.DeliveryDate).HasColumnType("date");

                entity.Property(e => e.DocumentDate).HasColumnType("date");

                entity.Property(e => e.IsDeliveryCompleted).HasColumnName("isDeliveryCompleted");

                entity.Property(e => e.IsPmccompleted).HasColumnName("isPMCCompleted");

                entity.Property(e => e.IsRelease).HasColumnName("isRelease");

                entity.Property(e => e.IsUnlimited).HasColumnName("isUnlimited");

                entity.Property(e => e.OverTolerance).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.ProductCode).HasMaxLength(100);

                entity.Property(e => e.ProductName).HasMaxLength(1000);

                entity.Property(e => e.ProviderCode).HasMaxLength(100);

                entity.Property(e => e.ProviderName).HasMaxLength(1000);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SoLuongDaNhap).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnderTolerance).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.Unit)
                    .HasColumnName("UNIT")
                    .HasMaxLength(3);

                entity.Property(e => e.WarehouseCode).HasMaxLength(100);
            });

            modelBuilder.Entity<PomasterModel>(entity =>
            {
                entity.HasKey(e => e.Ponumber);

                entity.ToTable("POMasterModel");

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyCode).HasMaxLength(100);

                entity.Property(e => e.IsCompelete).HasColumnName("isCompelete");

                entity.Property(e => e.IsNhapKhau).HasColumnName("isNhapKhau");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.ProviderCode).HasMaxLength(100);

                entity.Property(e => e.ProviderName).HasMaxLength(1000);

                entity.Property(e => e.QtyTotal).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SoLuongDaNhap).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<ProviderModel>(entity =>
            {
                entity.HasKey(e => e.ProviderId);

                entity.Property(e => e.ProviderId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AccountGroup).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(4000);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.IsSapdata).HasColumnName("isSAPData");

                entity.Property(e => e.LastEditedTime).HasColumnType("datetime");

                entity.Property(e => e.ProviderCode).HasMaxLength(100);

                entity.Property(e => e.ProviderName).HasMaxLength(1000);
            });

            modelBuilder.Entity<SolineModel>(entity =>
            {
                entity.HasKey(e => new { e.Soline, e.Sonumber });

                entity.ToTable("SOLineModel");

                entity.Property(e => e.Soline)
                    .HasColumnName("SOLine")
                    .HasMaxLength(100);

                entity.Property(e => e.Sonumber)
                    .HasColumnName("SONumber")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyCode).HasMaxLength(100);

                entity.Property(e => e.CustomerCode).HasMaxLength(100);

                entity.Property(e => e.CustomerName).HasMaxLength(1000);

                entity.Property(e => e.DocumentDate).HasColumnType("date");

                entity.Property(e => e.IsClosed).HasColumnName("isClosed");

                entity.Property(e => e.IsComplete).HasColumnName("isComplete");

                entity.Property(e => e.IsUnlimited).HasColumnName("isUnlimited");

                entity.Property(e => e.OverTolerance).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(35);

                entity.Property(e => e.ProductCode).HasMaxLength(100);

                entity.Property(e => e.ProductName).HasMaxLength(1000);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SoLuongDaXuat).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnderTolerance).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.Unit)
                    .HasColumnName("UNIT")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<SomasterModel>(entity =>
            {
                entity.HasKey(e => e.Sonumber);

                entity.ToTable("SOMasterModel");

                entity.Property(e => e.Sonumber)
                    .HasColumnName("SONumber")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerCode).HasMaxLength(100);

                entity.Property(e => e.CustomerName).HasMaxLength(1000);

                entity.Property(e => e.IsCompelete).HasColumnName("isCompelete");

                entity.Property(e => e.IsNhapKhau).HasColumnName("isNhapKhau");

                entity.Property(e => e.QtyTotal).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.SoLuongDaXuat).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<SyncTable>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TransportModel>(entity =>
            {
                entity.HasKey(e => e.TransportId)
                    .HasName("PK__Transpor__19E9A11DF321F254");

                entity.Property(e => e.TransportId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AccountGroup).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(4000);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.IsSapdata).HasColumnName("isSAPData");

                entity.Property(e => e.LastEditedTime).HasColumnType("datetime");

                entity.Property(e => e.TransportCode).HasMaxLength(100);

                entity.Property(e => e.TransportName).HasMaxLength(1000);
            });

            modelBuilder.Entity<UserModel>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CompanyCode).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Fullname)
                    .HasColumnName("fullname")
                    .HasMaxLength(100);

                entity.Property(e => e.Memberof).HasColumnName("memberof");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Rolecode).HasColumnName("rolecode");

                entity.Property(e => e.Taxcode)
                    .IsRequired()
                    .HasColumnName("taxcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserType).HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehicleInfoMapping>(entity =>
            {
                entity.HasKey(e => new { e.VehicleId, e.VehicleOwner });

                entity.Property(e => e.VehicleOwner).HasMaxLength(100);
            });

            modelBuilder.Entity<VehicleModel>(entity =>
            {
                entity.HasKey(e => e.VehicleId);

                entity.Property(e => e.VehicleId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DriverCardNo).HasMaxLength(100);

                entity.Property(e => e.DriverName).HasMaxLength(100);

                entity.Property(e => e.IsContainer).HasColumnName("isContainer");

                entity.Property(e => e.IsDauKeo).HasColumnName("isDauKeo");

                entity.Property(e => e.IsLock).HasColumnName("isLock");

                entity.Property(e => e.IsLockEdit).HasColumnName("isLockEdit");

                entity.Property(e => e.IsRoMooc).HasColumnName("isRoMooc");

                entity.Property(e => e.LastEditTime).HasColumnType("datetime");

                entity.Property(e => e.TempWeight).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TrongLuongDangKiem).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TyLeVuot).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateTempWeightTime).HasColumnType("datetime");

                entity.Property(e => e.VehicleNumber).HasMaxLength(50);

                entity.Property(e => e.VehicleOwner).HasMaxLength(100);

                entity.Property(e => e.VehicleWeight).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<VehicleOwnerModel>(entity =>
            {
                entity.HasKey(e => e.VehicleOwner);

                entity.Property(e => e.VehicleOwner).HasMaxLength(100);

                entity.Property(e => e.CustomerCode).HasMaxLength(100);

                entity.Property(e => e.ProviderCode).HasMaxLength(100);

                entity.Property(e => e.VehicleOwnerName).HasMaxLength(1000);
            });

            modelBuilder.Entity<VehicleRegisterMobileModel>(entity =>
            {
                entity.HasKey(e => e.VehicleRegisterMobileId);

                entity.Property(e => e.VehicleRegisterMobileId).ValueGeneratedNever();

                entity.Property(e => e.Assets).HasMaxLength(4000);

                entity.Property(e => e.CompanyCode).HasMaxLength(100);

                entity.Property(e => e.CungDuongName).HasMaxLength(512);

                entity.Property(e => e.DriverIdCard).HasMaxLength(50);

                entity.Property(e => e.DriverName).HasMaxLength(200);

                entity.Property(e => e.Dvvc)
                    .HasColumnName("DVVC")
                    .HasMaxLength(255);

                entity.Property(e => e.Dvvccode)
                    .HasColumnName("DVVCCode")
                    .HasMaxLength(255);

                entity.Property(e => e.GiaoNhan).HasMaxLength(10);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.RegisterTime).HasColumnType("datetime");

                entity.Property(e => e.Romooc).HasMaxLength(50);

                entity.Property(e => e.ScaleTicketCode).HasMaxLength(50);

                entity.Property(e => e.SoDonHang).HasMaxLength(255);

                entity.Property(e => e.TapChat).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThoiGianToiDuKien).HasColumnType("datetime");

                entity.Property(e => e.ThoiGianToiThucTe).HasColumnType("datetime");

                entity.Property(e => e.TrongLuongGiaoDuKien).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TrongLuongGiaoThucTe).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VehicleNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<VehicleRegisterPodetailModel>(entity =>
            {
                entity.HasKey(e => e.VehicleRegisterPodetailId);

                entity.ToTable("VehicleRegisterPODetailModel");

                entity.Property(e => e.VehicleRegisterPodetailId)
                    .HasColumnName("VehicleRegisterPODetailId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Poline)
                    .HasColumnName("POLine")
                    .HasMaxLength(100);

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(100);

                entity.Property(e => e.ProductCode).HasMaxLength(100);

                entity.Property(e => e.ProductName).HasMaxLength(1000);

                entity.Property(e => e.TiLe).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TrongLuong).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehicleVehicleOwnerMapping>(entity =>
            {
                entity.HasKey(e => new { e.VehicleId, e.VehicleOwner });

                entity.ToTable("Vehicle_VehicleOwner_Mapping");

                entity.Property(e => e.VehicleOwner).HasMaxLength(100);
            });

            modelBuilder.Entity<RegisterForShip>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("RegisterForShip_Id_IDX")
                    .IsUnique();
                entity.ToTable("RegisterForShip");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}