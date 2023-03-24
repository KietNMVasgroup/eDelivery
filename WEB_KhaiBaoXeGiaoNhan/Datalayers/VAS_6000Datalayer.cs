﻿using AdminPortal.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using WEB_KhaiBaoXeGiaoNhan.VAS6000;

namespace WEB_KhaiBaoXeGiaoNhan.Datalayers
{
    public class VAS_6000Datalayer : DataProvider<VAS_6000Datalayer>
    {
        // Lấy lên danh sách
        public List<VehicleRegisterMobileModel> GetList()
        {
            using (Vas_6000Context context = new Vas_6000Context())
            {
                return context.VehicleRegisterMobileModel.ToList();
            }
        }
        public int InsertVehicleResigter6000(WebModels.VehicleRegisterMobileModel model)
        {
            int result = 0;
            var item = new VehicleRegisterMobileModel
            {
                VehicleRegisterMobileId = model.VehicleRegisterMobileId
                ,
                VehicleNumber = model.VehicleNumber
                ,
                AllowEdit = model.AllowEdit
                ,
                Assets = model.Assets
                ,
                CungDuongCode = model.CungDuongCode
                ,
                CungDuongName = model.CungDuongName
                ,
                DriverIdCard = model.DriverIdCard
                ,
                DriverName = model.DriverName
                ,
                Dvvc = model.Dvvc
                ,
                Dvvccode = model.Dvvccode
                ,
                GiaoNhan = model.GiaoNhan
                ,
                Note = model.Note
                ,
                RegisterTime = model.RegisterTime
                ,
                SoDonHang = model.SoDonHang
                ,
                ThoiGianToiDuKien = model.ThoiGianToiDuKien
                ,
                ThoiGianToiThucTe = model.ThoiGianToiThucTe
                ,
                TrongLuongGiaoDuKien = model.TrongLuongGiaoDuKien
                ,
                TrongLuongGiaoThucTe = model.TrongLuongGiaoThucTe
                ,
                ModifyTime = model.ModifyTime
                ,
                ScaleTicketCode = model.ScaleTicketCode
                ,
                TapChat = model.TapChat
                ,
                IsActive = model.IsActive
                ,
                BonusHour =model.BonusHour
                ,
                Romooc = model.Romooc
                ,
                CompanyCode = model.CompanyCode
            };
            using (Vas_6000Context context = new Vas_6000Context())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.VehicleRegisterMobileModel.Add(item);
                        result = context.SaveChanges();
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        WriteLogErr(ex.Message);
                    }
                }
            }
            return result;
        }

        public int DeleteVehicleResigter6000(WebModels.VehicleRegisterMobileModel model)
        {
            int result = 0;
            var item = new VehicleRegisterMobileModel
            {
                VehicleRegisterMobileId = model.VehicleRegisterMobileId
                ,
                VehicleNumber = model.VehicleNumber
                ,
                AllowEdit = model.AllowEdit
                ,
                Assets = model.Assets
                ,
                CungDuongCode = model.CungDuongCode
                ,
                CungDuongName = model.CungDuongName
                ,
                DriverIdCard = model.DriverIdCard
                ,
                DriverName = model.DriverName
                ,
                Dvvc = model.Dvvc
                ,
                Dvvccode = model.Dvvccode
                ,
                GiaoNhan = model.GiaoNhan
                ,
                Note = model.Note
                ,
                RegisterTime = model.RegisterTime
                ,
                SoDonHang = model.SoDonHang
                ,
                ThoiGianToiDuKien = model.ThoiGianToiDuKien
                ,
                ThoiGianToiThucTe = model.ThoiGianToiThucTe
                ,
                TrongLuongGiaoDuKien = model.TrongLuongGiaoDuKien
                ,
                TrongLuongGiaoThucTe = model.TrongLuongGiaoThucTe
                ,
                ModifyTime = model.ModifyTime
                ,
                ScaleTicketCode = model.ScaleTicketCode
                ,
                TapChat = model.TapChat
                ,
                IsActive = model.IsActive
                ,
                BonusHour = model.BonusHour
                ,
                Romooc = model.Romooc
                ,
                CompanyCode = model.CompanyCode
            };
            using (Vas_6000Context context = new Vas_6000Context())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.VehicleRegisterMobileModel.Remove(item);
                        result = context.SaveChanges();
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        WriteLogErr(ex.Message);
                    }
                }
            }
            return result;
        }

        public int InsertVehicleDetail6000(WebModels.VehicleRegisterPodetailModel model)
        {
            int result = 0;
            var item = new VehicleRegisterPodetailModel
            {
                VehicleRegisterPodetailId = model.VehicleRegisterPodetailId
                    ,
                VehicleRegisterMobileId = model.VehicleRegisterMobileId
                    ,
                ProductName = model.ProductName
                    ,
                ProductCode = model.ProductCode
                    ,
                Ponumber = model.Ponumber
                    ,
                Poline = model.Poline
            };
            using (Vas_6000Context context = new Vas_6000Context())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.VehicleRegisterPodetailModel.Add(item);
                        result = context.SaveChanges();
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        WriteLogErr(ex.Message);
                    }
                }
            }
            return result;
        }

        public int DeleteVehicleDetail6000(WebModels.VehicleRegisterPodetailModel model)
        {
            int result = 0;
            var item = new VehicleRegisterPodetailModel
            {
                VehicleRegisterPodetailId = model.VehicleRegisterPodetailId
                    ,
                VehicleRegisterMobileId = model.VehicleRegisterMobileId
                    ,
                ProductName = model.ProductName
                    ,
                ProductCode = model.ProductCode
                    ,
                Ponumber = model.Ponumber
                    ,
                Poline = model.Poline
            };
            using (Vas_6000Context context = new Vas_6000Context())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.VehicleRegisterPodetailModel.Remove(item);
                        result = context.SaveChanges();
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        WriteLogErr(ex.Message);
                    }
                }
            }
            return result;
        }

        public int UpdateVehicleResigter6000(WebModels.VehicleRegisterMobileModel model)
        {
            int result = 0;
            var item = new VehicleRegisterMobileModel
            {
                VehicleRegisterMobileId = model.VehicleRegisterMobileId
                ,
                VehicleNumber = model.VehicleNumber
                ,
                AllowEdit = model.AllowEdit
                ,
                Assets = model.Assets
                ,
                CungDuongCode = model.CungDuongCode
                ,
                CungDuongName = model.CungDuongName
                ,
                DriverIdCard = model.DriverIdCard
                ,
                DriverName = model.DriverName
                ,
                Dvvc = model.Dvvc
                ,
                Dvvccode = model.Dvvccode
                ,
                GiaoNhan = model.GiaoNhan
                ,
                Note = model.Note
                ,
                RegisterTime = model.RegisterTime
                ,
                SoDonHang = model.SoDonHang
                ,
                ThoiGianToiDuKien = model.ThoiGianToiDuKien
                ,
                ThoiGianToiThucTe = model.ThoiGianToiThucTe
                ,
                TrongLuongGiaoDuKien = model.TrongLuongGiaoDuKien
                ,
                TrongLuongGiaoThucTe = model.TrongLuongGiaoThucTe
                ,
                ModifyTime = model.ModifyTime
                ,
                ScaleTicketCode = model.ScaleTicketCode
                ,
                TapChat = model.TapChat
                ,
                IsActive = model.IsActive
                ,
                BonusHour = model.BonusHour
                ,
                Romooc = model.Romooc
                ,
                CompanyCode = model.CompanyCode
            };
            using (Vas_6000Context context = new Vas_6000Context())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.VehicleRegisterMobileModel.Update(item);
                        result = context.SaveChanges();
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        WriteLogErr(ex.Message);
                    }
                }
            }
            return result;
        }
    }
}