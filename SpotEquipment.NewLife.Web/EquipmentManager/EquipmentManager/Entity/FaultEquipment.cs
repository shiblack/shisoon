/*
 * XCoder v4.8.4531.242
 * 作者：sk/DESKTOP-I6PMUKT
 * 时间：2018-12-05 16:59:49
 * 版权：版权所有 (C) 新生命开发团队 2018
*/
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NewLife.Cube.Entity
{
    /// <summary>故障设备</summary>
    [Serializable]
    [DataObject]
    [Description("")]
    [BindTable("FaultEquipment", Description = "", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class FaultEquipment : IFaultEquipment
    {
        #region 属性
        private Int32 _ID;
        /// <summary>ID</summary>
        [DisplayName("ID")]
        [Description("ID")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(1, "ID", "ID", null, "int", 10, 0, false)]
        public virtual Int32 ID
        {
            get { return _ID; }
            set { if (OnPropertyChanging("ID", value)) { _ID = value; OnPropertyChanged("ID"); } }
        }

        private Int32 _SpotEquipmentNumber1;
        /// <summary>设备编号</summary>
        [DisplayName("SpotEquipmentNumber1")]
        [Description("设备编号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(2, "SpotEquipmentNumber1", "设备编号", null, "int", 10, 0, false)]
        public virtual Int32 SpotEquipmentNumber1
        {
            get { return _SpotEquipmentNumber1; }
            set { if (OnPropertyChanging("SpotEquipmentNumber1", value)) { _SpotEquipmentNumber1 = value; OnPropertyChanged("SpotEquipmentNumber1"); } }
        }

        private String _Type;
        /// <summary>设备类型</summary>
        [DisplayName("Type")]
        [Description("设备类型")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(3, "Type", "设备类型", null, "nchar(10)", 0, 0, true)]
        public virtual String Type
        {
            get { return _Type; }
            set { if (OnPropertyChanging("Type", value)) { _Type = value; OnPropertyChanged("Type"); } }
        }

        private DateTime _InstallationTime;
        /// <summary>安装时间</summary>
        [DisplayName("InstallationTime")]
        [Description("安装时间")]
        [DataObjectField(false, false, true, 16)]
        [BindColumn(4, "InstallationTime", "安装时间", null, "smalldatetime", 0, 0, false)]
        public virtual DateTime InstallationTime
        {
            get { return _InstallationTime; }
            set { if (OnPropertyChanging("InstallationTime", value)) { _InstallationTime = value; OnPropertyChanged("InstallationTime"); } }
        }

        private String _OccurLocation;
        /// <summary>发生地点</summary>
        [DisplayName("OccurLocation")]
        [Description("发生地点")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn(5, "OccurLocation", "发生地点", null, "nvarchar(20)", 0, 0, true)]
        public virtual String OccurLocation
        {
            get { return _OccurLocation; }
            set { if (OnPropertyChanging("OccurLocation", value)) { _OccurLocation = value; OnPropertyChanged("OccurLocation"); } }
        }

        private DateTime _OccurTime;
        /// <summary>发生时间</summary>
        [DisplayName("OccurTime")]
        [Description("发生时间")]
        [DataObjectField(false, false, true, 16)]
        [BindColumn(6, "OccurTime", "发生时间", null, "smalldatetime", 0, 0, false)]
        public virtual DateTime OccurTime
        {
            get { return _OccurTime; }
            set { if (OnPropertyChanging("OccurTime", value)) { _OccurTime = value; OnPropertyChanged("OccurTime"); } }
        }

        private String _FaultReason;
        /// <summary故障原因</summary>
        [DisplayName("FaultReason")]
        [Description("故障原因")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(7, "FaultReason", "故障原因", null, "nchar(50)", 0, 0, true)]
        public virtual String FaultReason
        {
            get { return _FaultReason; }
            set { if (OnPropertyChanging("FaultReason", value)) { _FaultReason = value; OnPropertyChanged("FaultReason"); } }
        }

        private DateTime _RepairTime;
        /// <summary>维修时间</summary>
        [DisplayName("RepairTime")]
        [Description("维修时间")]
        [DataObjectField(false, false, true, 16)]
        [BindColumn(8, "RepairTime", "维修时间", null, "smalldatetime", 0, 0, false)]
        public virtual DateTime RepairTime
        {
            get { return _RepairTime; }
            set { if (OnPropertyChanging("RepairTime", value)) { _RepairTime = value; OnPropertyChanged("RepairTime"); } }
        }

        private String _RepairPreson;
        /// <summary>维修人员</summary>
        [DisplayName("RepairPreson")]
        [Description("维修人员")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(9, "RepairPreson", "维修人员", null, "nchar(10)", 0, 0, true)]
        public virtual String RepairPreson
        {
            get { return _RepairPreson; }
            set { if (OnPropertyChanging("RepairPreson", value)) { _RepairPreson = value; OnPropertyChanged("RepairPreson"); } }
        }

        private String _Remark;
        /// <summary>备注</summary>
        [DisplayName("Remark")]
        [Description("备注")]
        [DataObjectField(false, false, true, 2147483647)]
        [BindColumn(10, "Remark", "备注", null, "text", 0, 0, false)]
        public virtual String Remark
        {
            get { return _Remark; }
            set { if (OnPropertyChanging("Remark", value)) { _Remark = value; OnPropertyChanged("Remark"); } }
        }
		#endregion

        #region 获取/设置 字段值
        /// <summary>
        /// 获取/设置 字段值。
        /// 一个索引，基类使用反射实现。
        /// 派生实体类可重写该索引，以避免反射带来的性能损耗
        /// </summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case "ID" : return _ID;
                    case "SpotEquipmentNumber1" : return _SpotEquipmentNumber1;
                    case "Type" : return _Type;
                    case "InstallationTime" : return _InstallationTime;
                    case "OccurLocation" : return _OccurLocation;
                    case "OccurTime" : return _OccurTime;
                    case "FaultReason" : return _FaultReason;
                    case "RepairTime" : return _RepairTime;
                    case "RepairPreson" : return _RepairPreson;
                    case "Remark" : return _Remark;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "ID" : _ID = Convert.ToInt32(value); break;
                    case "SpotEquipmentNumber1" : _SpotEquipmentNumber1 = Convert.ToInt32(value); break;
                    case "Type" : _Type = Convert.ToString(value); break;
                    case "InstallationTime" : _InstallationTime = Convert.ToDateTime(value); break;
                    case "OccurLocation" : _OccurLocation = Convert.ToString(value); break;
                    case "OccurTime" : _OccurTime = Convert.ToDateTime(value); break;
                    case "FaultReason" : _FaultReason = Convert.ToString(value); break;
                    case "RepairTime" : _RepairTime = Convert.ToDateTime(value); break;
                    case "RepairPreson" : _RepairPreson = Convert.ToString(value); break;
                    case "Remark" : _Remark = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得字段信息的快捷方式</summary>
        public class _
        {
            ///<summary></summary>
            public static readonly Field ID = FindByName("ID");

            ///<summary></summary>
            public static readonly Field SpotEquipmentNumber1 = FindByName("SpotEquipmentNumber1");

            ///<summary></summary>
            public static readonly Field Type = FindByName("Type");

            ///<summary></summary>
            public static readonly Field InstallationTime = FindByName("InstallationTime");

            ///<summary></summary>
            public static readonly Field OccurLocation = FindByName("OccurLocation");

            ///<summary></summary>
            public static readonly Field OccurTime = FindByName("OccurTime");

            ///<summary></summary>
            public static readonly Field FaultReason = FindByName("FaultReason");

            ///<summary></summary>
            public static readonly Field RepairTime = FindByName("RepairTime");

            ///<summary></summary>
            public static readonly Field RepairPreson = FindByName("RepairPreson");

            ///<summary></summary>
            public static readonly Field Remark = FindByName("Remark");

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IFaultEquipment
    {
        #region 属性
        /// <summary></summary>
        Int32 ID { get; set; }

        /// <summary></summary>
        Int32 SpotEquipmentNumber1 { get; set; }

        /// <summary></summary>
        String Type { get; set; }

        /// <summary></summary>
        DateTime InstallationTime { get; set; }

        /// <summary></summary>
        String OccurLocation { get; set; }

        /// <summary></summary>
        DateTime OccurTime { get; set; }

        /// <summary></summary>
        String FaultReason { get; set; }

        /// <summary></summary>
        DateTime RepairTime { get; set; }

        /// <summary></summary>
        String RepairPreson { get; set; }

        /// <summary></summary>
        String Remark { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值。</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}