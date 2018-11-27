/*
 * XCoder v4.8.4531.242
 * 作者：sk/DESKTOP-I6PMUKT
 * 时间：2018-11-03 00:04:23
 * 版权：版权所有 (C) 新生命开发团队 2018
*/
using EquipmentManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NewLife.Cube.Entity
{
    /// <summary></summary>
    [Serializable]
    [DataObject]
    [Description("")]
    [BindIndex("PK_SpotEuipment", true, "ID")]
    [BindTable("SpotEuipments", Description = "", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class SpotEuipments : ISpotEuipments
    {
        #region 属性
        private Int32 _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 10)]
        [BindColumn(1, "ID", "编号", null, "int", 10, 0, false)]
        public virtual Int32 ID
        {
            get { return _ID; }
            set { if (OnPropertyChanging("ID", value)) { _ID = value; OnPropertyChanged("ID"); } }
        }

        private Int32 _Number;
        /// <summary>设备编号</summary>
        [DisplayName("设备编号")]
        [Description("设备编号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(2, "Number", "设备编号", null, "int", 10, 0, false)]
        public virtual Int32 Number
        {
            get { return _Number; }
            set { if (OnPropertyChanging("Number", value)) { _Number = value; OnPropertyChanged("Number"); } }
        }

        private String _OwnedEnterprise;
        /// <summary>所属企业</summary>
        [DisplayName("所属企业")]
        [Description("所属企业")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(3, "OwnedEnterprise", "所属企业", null, "nvarchar(50)", 0, 0, true)]
        public virtual String OwnedEnterprise
        {
            get { return _OwnedEnterprise; }
            set { if (OnPropertyChanging("OwnedEnterprise", value)) { _OwnedEnterprise = value; OnPropertyChanged("OwnedEnterprise"); } }
        }

        private String _AssetNumber;
        /// <summary>资产编码</summary>
        [DisplayName("资产编码")]
        [Description("资产编码")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(4, "AssetNumber", "资产编码", null, "nvarchar(50)", 0, 0, true)]
        public virtual String AssetNumber
        {
            get { return _AssetNumber; }
            set { if (OnPropertyChanging("AssetNumber", value)) { _AssetNumber = value; OnPropertyChanged("AssetNumber"); } }
        }

        private String _Name;
        /// <summary>名称</summary>
        [DisplayName("名称")]
        [Description("名称")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(5, "Name", "名称", null, "nchar(10)", 0, 0, true)]
        public virtual String Name
        {
            get { return _Name; }
            set { if (OnPropertyChanging("Name", value)) { _Name = value; OnPropertyChanged("Name"); } }
        }

        private String _SpecificationModel;
        /// <summary>规格型号</summary>
        [DisplayName("规格型号")]
        [Description("规格型号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(6, "SpecificationModel", "规格型号", null, "nchar(10)", 0, 0, true)]
        public virtual String SpecificationModel
        {
            get { return _SpecificationModel; }
            set { if (OnPropertyChanging("SpecificationModel", value)) { _SpecificationModel = value; OnPropertyChanged("SpecificationModel"); } }
        }

        private String _EquipmentType;
        /// <summary>设备类型</summary>
        [DisplayName("设备类型")]
        [Description("设备类型")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(7, "EquipmentType", "设备类型", null, "nchar(10)", 0, 0, true)]
        public EType EquipmentType
        {
            get;set;
        }

        private String _Manufacturer;
        /// <summary>生产厂家</summary>
        [DisplayName("生产厂家")]
        [Description("生产厂家")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(8, "Manufacturer", "生产厂家", null, "nchar(10)", 0, 0, true)]
        public virtual String Manufacturer
        {
            get { return _Manufacturer; }
            set { if (OnPropertyChanging("Manufacturer", value)) { _Manufacturer = value; OnPropertyChanged("Manufacturer"); } }
        }

        private String _DeviceSerialNumber;
        /// <summary>设备序列号</summary>
        [DisplayName("设备序列号")]
        [Description("设备序列号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(9, "DeviceSerialNumber", "设备序列号", null, "nchar(10)", 0, 0, true)]
        public virtual String DeviceSerialNumber
        {
            get { return _DeviceSerialNumber; }
            set { if (OnPropertyChanging("DeviceSerialNumber", value)) { _DeviceSerialNumber = value; OnPropertyChanged("DeviceSerialNumber"); } }
        }

        private String _Purpose;
        /// <summary>用途</summary>
        [DisplayName("用途")]
        [Description("用途")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(10, "Purpose", "用途", null, "nchar(10)", 0, 0, true)]
        public  NewPurpose Purpose
        {
           get;set;
        }

        private DateTime _InstallationTime;
        /// <summary>安装时间</summary>
        [DisplayName("安装时间")]
        [Description("安装时间")]
        [DataObjectField(false, false, true, 16)]
        [BindColumn(11, "InstallationTime", "安装时间", null, "smalldatetime", 0, 0, false)]
        public virtual DateTime InstallationTime
        {
            get { return _InstallationTime; }
            set { if (OnPropertyChanging("InstallationTime", value)) { _InstallationTime = value; OnPropertyChanged("InstallationTime"); } }
        }

        private String _IntstallationPerson;
        /// <summary>安装人员</summary>
        [DisplayName("安装人员")]
        [Description("安装人员")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(12, "IntstallationPerson", "安装人员", null, "nchar(10)", 0, 0, true)]
        public virtual String IntstallationPerson
        {
            get { return _IntstallationPerson; }
            set { if (OnPropertyChanging("IntstallationPerson", value)) { _IntstallationPerson = value; OnPropertyChanged("IntstallationPerson"); } }
        }

        private String _DetailedInstallPlace;
        /// <summary>详细安装地址</summary>
        [DisplayName("详细安装地址")]
        [Description("详细安装地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(13, "DetailedInstallPlace", "详细安装地址", null, "nchar(50)", 0, 0, true)]
        public virtual String DetailedInstallPlace
        {
            get { return _DetailedInstallPlace; }
            set { if (OnPropertyChanging("DetailedInstallPlace", value)) { _DetailedInstallPlace = value; OnPropertyChanged("DetailedInstallPlace"); } }
        }

        private String _Position;
        /// <summary>位置</summary>
        [DisplayName("位置")]
        [Description("位置")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(14, "Position", "位置", null, "nvarchar(50)", 0, 0, true)]
        public virtual String Position
        {
            get { return _Position; }
            set { if (OnPropertyChanging("Position", value)) { _Position = value; OnPropertyChanged("Position"); } }
        }

        private String _LiveTips;
        /// <summary>现场提示</summary>
        [DisplayName("现场提示")]
        [Description("现场提示")]
        [DataObjectField(false, false, true, 1073741823)]
        [BindColumn(15, "LiveTips", "现场提示", null, "ntext", 0, 0, true)]
        public virtual String LiveTips
        {
            get { return _LiveTips; }
            set { if (OnPropertyChanging("LiveTips", value)) { _LiveTips = value; OnPropertyChanged("LiveTips"); } }
        }

        private String _GPSPosition;
        /// <summary>GPS位置</summary>
        [DisplayName("GPS位置")]
        [Description("GPS位置")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(16, "GPSPosition", "GPS位置", null, "nvarchar(50)", 0, 0, true)]
        public virtual String GPSPosition
        {
            get { return _GPSPosition; }
            set { if (OnPropertyChanging("GPSPosition", value)) { _GPSPosition = value; OnPropertyChanged("GPSPosition"); } }
        }

        private String _LiveImage;
        /// <summary>现场图片</summary>
        [DisplayName("现场图片")]
        [Description("现场图片")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(17, "LiveImage", "现场图片", null, "nchar(10)", 0, 0, true)]
        public virtual String LiveImage
        {
            get { return _LiveImage; }
            set { if (OnPropertyChanging("LiveImage", value)) { _LiveImage = value; OnPropertyChanged("LiveImage"); } }
        }

        private String _EquipmentState;
        /// <summary>设备状态</summary>
        [DisplayName("设备状态")]
        [Description("设备状态")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(18, "EquipmentState", "设备状态", null, "nchar(10)", 0, 0, true)]
        public EState EquipmentState
        {
            get;set;
        }

        private String _PowerSupplyMode;
        /// <summary>供电方式</summary>
        [DisplayName("供电方式")]
        [Description("供电方式")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(19, "PowerSupplyMode", "供电方式", null, "nchar(10)", 0, 0, true)]
        public PowerMode PowerSupplyMode { get; set; }
        private DateTime _DiscardedTime;
        /// <summary>报废时间</summary>
        [DisplayName("报废时间")]
        [Description("报废时间")]
        [DataObjectField(false, false, true, 16)]
        [BindColumn(20, "DiscardedTime", "报废时间", null, "smalldatetime", 0, 0, false)]
        public virtual DateTime DiscardedTime
        {
            get { return _DiscardedTime; }
            set { if (OnPropertyChanging("DiscardedTime", value)) { _DiscardedTime = value; OnPropertyChanged("DiscardedTime"); } }
        }

        private String _DiscardedReason;
        /// <summary>报废原因</summary>
        [DisplayName("报废原因")]
        [Description("报废原因")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(21, "DiscardedReason", "报废原因", null, "nchar(10)", 0, 0, true)]
        public virtual String DiscardedReason
        {
            get { return _DiscardedReason; }
            set { if (OnPropertyChanging("DiscardedReason", value)) { _DiscardedReason = value; OnPropertyChanged("DiscardedReason"); } }
        }

        private String _Remarks;
        /// <summary>备注</summary>
        [DisplayName("备注")]
        [Description("备注")]
        [DataObjectField(false, false, true, 1073741823)]
        [BindColumn(22, "Remarks", "备注", null, "ntext", 0, 0, true)]
        public virtual String Remarks
        {
            get { return _Remarks; }
            set { if (OnPropertyChanging("Remarks", value)) { _Remarks = value; OnPropertyChanged("Remarks"); } }
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
                    case "Number" : return _Number;
                    case "OwnedEnterprise" : return _OwnedEnterprise;
                    case "AssetNumber" : return _AssetNumber;
                    case "Name" : return _Name;
                    case "SpecificationModel" : return _SpecificationModel;
                    case "EquipmentType" : return _EquipmentType;
                    case "Manufacturer" : return _Manufacturer;
                    case "DeviceSerialNumber" : return _DeviceSerialNumber;
                    case "Purpose" : return _Purpose;
                    case "InstallationTime" : return _InstallationTime;
                    case "IntstallationPerson" : return _IntstallationPerson;
                    case "DetailedInstallPlace" : return _DetailedInstallPlace;
                    case "Position" : return _Position;
                    case "LiveTips" : return _LiveTips;
                    case "GPSPosition" : return _GPSPosition;
                    case "LiveImage" : return _LiveImage;
                    case "EquipmentState" : return _EquipmentState;
                    case "PowerSupplyMode" : return _PowerSupplyMode;
                    case "DiscardedTime" : return _DiscardedTime;
                    case "DiscardedReason" : return _DiscardedReason;
                    case "Remarks" : return _Remarks;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "ID" : _ID = Convert.ToInt32(value); break;
                    case "Number" : _Number = Convert.ToInt32(value); break;
                    case "OwnedEnterprise" : _OwnedEnterprise = Convert.ToString(value); break;
                    case "AssetNumber" : _AssetNumber = Convert.ToString(value); break;
                    case "Name" : _Name = Convert.ToString(value); break;
                    case "SpecificationModel" : _SpecificationModel = Convert.ToString(value); break;
                    case "EquipmentType" : _EquipmentType = Convert.ToString(value); break;
                    case "Manufacturer" : _Manufacturer = Convert.ToString(value); break;
                    case "DeviceSerialNumber" : _DeviceSerialNumber = Convert.ToString(value); break;
                    case "Purpose" : _Purpose = Convert.ToString(value); break;
                    case "InstallationTime" : _InstallationTime = Convert.ToDateTime(value); break;
                    case "IntstallationPerson" : _IntstallationPerson = Convert.ToString(value); break;
                    case "DetailedInstallPlace" : _DetailedInstallPlace = Convert.ToString(value); break;
                    case "Position" : _Position = Convert.ToString(value); break;
                    case "LiveTips" : _LiveTips = Convert.ToString(value); break;
                    case "GPSPosition" : _GPSPosition = Convert.ToString(value); break;
                    case "LiveImage" : _LiveImage = Convert.ToString(value); break;
                    case "EquipmentState" : _EquipmentState = Convert.ToString(value); break;
                    case "PowerSupplyMode" : _PowerSupplyMode = Convert.ToString(value); break;
                    case "DiscardedTime" : _DiscardedTime = Convert.ToDateTime(value); break;
                    case "DiscardedReason" : _DiscardedReason = Convert.ToString(value); break;
                    case "Remarks" : _Remarks = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得字段信息的快捷方式</summary>
        public class _
        {
            ///<summary>编号</summary>
            public static readonly Field ID = FindByName("ID");

            ///<summary>设备编号</summary>
            public static readonly Field Number = FindByName("Number");

            ///<summary>所属企业</summary>
            public static readonly Field OwnedEnterprise = FindByName("OwnedEnterprise");

            ///<summary>资产编码</summary>
            public static readonly Field AssetNumber = FindByName("AssetNumber");

            ///<summary>名称</summary>
            public static readonly Field Name = FindByName("Name");

            ///<summary>规格型号</summary>
            public static readonly Field SpecificationModel = FindByName("SpecificationModel");

            ///<summary>设备类型</summary>
            public static readonly Field EquipmentType = FindByName("EquipmentType");

            ///<summary>生产厂家</summary>
            public static readonly Field Manufacturer = FindByName("Manufacturer");

            ///<summary>设备序列号</summary>
            public static readonly Field DeviceSerialNumber = FindByName("DeviceSerialNumber");

            ///<summary>用途</summary>
            public static readonly Field Purpose = FindByName("Purpose");

            ///<summary>安装时间</summary>
            public static readonly Field InstallationTime = FindByName("InstallationTime");

            ///<summary>安装人员</summary>
            public static readonly Field IntstallationPerson = FindByName("IntstallationPerson");

            ///<summary>详细安装地址</summary>
            public static readonly Field DetailedInstallPlace = FindByName("DetailedInstallPlace");

            ///<summary>位置</summary>
            public static readonly Field Position = FindByName("Position");

            ///<summary>现场提示<</summary>
            public static readonly Field LiveTips = FindByName("LiveTips");

            ///<summary>GPS位置</summary>
            public static readonly Field GPSPosition = FindByName("GPSPosition");

            ///<summary>现场图片</summary>
            public static readonly Field LiveImage = FindByName("LiveImage");

            ///<summary>设备状态</summary>
            public static readonly Field EquipmentState = FindByName("EquipmentState");

            ///<summary>供电方式</summary>
            public static readonly Field PowerSupplyMode = FindByName("PowerSupplyMode");

            ///<summary>报废时间</summary>
            public static readonly Field DiscardedTime = FindByName("DiscardedTime");

            ///<summary>报废原因</summary>
            public static readonly Field DiscardedReason = FindByName("DiscardedReason");

            ///<summary>备注</summary>
            public static readonly Field Remarks = FindByName("Remarks");

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface ISpotEuipments
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 ID { get; set; }

        /// <summary>设备编号</summary>
        Int32 Number { get; set; }

        /// <summary>所属企业</summary>
        String OwnedEnterprise { get; set; }

        /// <summary>资产编码</summary>
        String AssetNumber { get; set; }

        /// <summary>名称</summary>
        String Name { get; set; }

        /// <summary>规格型号</summary>
        String SpecificationModel { get; set; }

        /// <summary>设备类型</summary>
        EType EquipmentType { get; set; }

        /// <summary>生产厂家</summary>
        String Manufacturer { get; set; }

        /// <summary>设备序列号</summary>
        String DeviceSerialNumber { get; set; }

        /// <summary>用途</summary>
        NewPurpose Purpose { get; set; }

        /// <summary>安装时间</summary>
        DateTime InstallationTime { get; set; }

        /// <summary>安装人员</summary>
        String IntstallationPerson { get; set; }

        /// <summary>详细安装地址</summary>
        String DetailedInstallPlace { get; set; }

        /// <summary>位置</summary>
        String Position { get; set; }

        /// <summary>现场提示<</summary>
        String LiveTips { get; set; }

        /// <summary>GPS位置</summary>
        String GPSPosition { get; set; }

        /// <summary>现场图片</summary>
        String LiveImage { get; set; }

        /// <summary>设备状态</summary>
        EState EquipmentState { get; set; }

        /// <summary>供电方式</summary>
        PowerMode PowerSupplyMode { get; set; }

        /// <summary>报废时间</summary>
        DateTime DiscardedTime { get; set; }

        /// <summary>报废原因</summary>
        String DiscardedReason { get; set; }

        /// <summary>备注</summary>
        String Remarks { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值。</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}