using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Model
{
    /// <summary>现场设备</summary>
    [Serializable]
    [DataObject]
    [Description("现场设备")]
    [BindTable("SpotEuipments", Description = "现场设备", ConnName = "Model", DbType = DatabaseType.SqlServer)]
    public partial class SpotEuipments : ISpotEuipments
    {
        #region 属性
        private Int32 _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "编号", "int")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private Int32 _Number;
        /// <summary>设备编号</summary>
        [DisplayName("设备编号")]
        [Description("设备编号")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Number", "设备编号", "int")]
        public Int32 Number { get { return _Number; } set { if (OnPropertyChanging(__.Number, value)) { _Number = value; OnPropertyChanged(__.Number); } } }

        private String _OwnedEnterprise;
        /// <summary>所属企业</summary>
        [DisplayName("所属企业")]
        [Description("所属企业")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("OwnedEnterprise", "所属企业", "nvarchar(50)")]
        public String OwnedEnterprise { get { return _OwnedEnterprise; } set { if (OnPropertyChanging(__.OwnedEnterprise, value)) { _OwnedEnterprise = value; OnPropertyChanged(__.OwnedEnterprise); } } }

        private String _AssetNumber;
        /// <summary>资产编码</summary>
        [DisplayName("资产编码")]
        [Description("资产编码")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("AssetNumber", "资产编码", "nvarchar(50)")]
        public String AssetNumber { get { return _AssetNumber; } set { if (OnPropertyChanging(__.AssetNumber, value)) { _AssetNumber = value; OnPropertyChanged(__.AssetNumber); } } }

        private String _Name;
        /// <summary>名称</summary>
        [DisplayName("名称")]
        [Description("名称")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("Name", "名称", "nchar(10)", Master = true)]
        public String Name { get { return _Name; } set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } } }

        private String _SpecificationModel;
        /// <summary>规格型号</summary>
        [DisplayName("规格型号")]
        [Description("规格型号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("SpecificationModel", "规格型号", "nchar(10)")]
        public String SpecificationModel { get { return _SpecificationModel; } set { if (OnPropertyChanging(__.SpecificationModel, value)) { _SpecificationModel = value; OnPropertyChanged(__.SpecificationModel); } } }

        private Int32 _EquipmentType;
        /// <summary>设备类型</summary>
        [DisplayName("设备类型")]
        [Description("设备类型")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("EquipmentType", "设备类型", "int")]
        public Int32 EquipmentType { get { return _EquipmentType; } set { if (OnPropertyChanging(__.EquipmentType, value)) { _EquipmentType = value; OnPropertyChanged(__.EquipmentType); } } }

        private String _Manufacturer;
        /// <summary>生产厂家</summary>
        [DisplayName("生产厂家")]
        [Description("生产厂家")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("Manufacturer", "生产厂家", "nchar(10)")]
        public String Manufacturer { get { return _Manufacturer; } set { if (OnPropertyChanging(__.Manufacturer, value)) { _Manufacturer = value; OnPropertyChanged(__.Manufacturer); } } }

        private String _DeviceSerialNumber;
        /// <summary>设备序列号</summary>
        [DisplayName("设备序列号")]
        [Description("设备序列号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("DeviceSerialNumber", "设备序列号", "nchar(10)")]
        public String DeviceSerialNumber { get { return _DeviceSerialNumber; } set { if (OnPropertyChanging(__.DeviceSerialNumber, value)) { _DeviceSerialNumber = value; OnPropertyChanged(__.DeviceSerialNumber); } } }

        private Int32 _Purpose;
        /// <summary>用途</summary>
        [DisplayName("用途")]
        [Description("用途")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Purpose", "用途", "int")]
        public Int32 Purpose { get { return _Purpose; } set { if (OnPropertyChanging(__.Purpose, value)) { _Purpose = value; OnPropertyChanged(__.Purpose); } } }

        private DateTime _InstallationTime;
        /// <summary>安装时间</summary>
        [DisplayName("安装时间")]
        [Description("安装时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("InstallationTime", "安装时间", "smalldatetime")]
        public DateTime InstallationTime { get { return _InstallationTime; } set { if (OnPropertyChanging(__.InstallationTime, value)) { _InstallationTime = value; OnPropertyChanged(__.InstallationTime); } } }

        private String _IntstallationPerson;
        /// <summary>安装人员</summary>
        [DisplayName("安装人员")]
        [Description("安装人员")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("IntstallationPerson", "安装人员", "nchar(10)")]
        public String IntstallationPerson { get { return _IntstallationPerson; } set { if (OnPropertyChanging(__.IntstallationPerson, value)) { _IntstallationPerson = value; OnPropertyChanged(__.IntstallationPerson); } } }

        private String _DetailedInstallPlace;
        /// <summary>详细安装地址</summary>
        [DisplayName("详细安装地址")]
        [Description("详细安装地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("DetailedInstallPlace", "详细安装地址", "nchar(50)")]
        public String DetailedInstallPlace { get { return _DetailedInstallPlace; } set { if (OnPropertyChanging(__.DetailedInstallPlace, value)) { _DetailedInstallPlace = value; OnPropertyChanged(__.DetailedInstallPlace); } } }

        private String _Position;
        /// <summary>位置</summary>
        [DisplayName("位置")]
        [Description("位置")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Position", "位置", "nvarchar(50)")]
        public String Position { get { return _Position; } set { if (OnPropertyChanging(__.Position, value)) { _Position = value; OnPropertyChanged(__.Position); } } }

        private String _LiveTips;
        /// <summary>现场提示<</summary>
        [DisplayName("现场提示<")]
        [Description("现场提示<")]
        [DataObjectField(false, false, true, -1)]
        [BindColumn("LiveTips", "现场提示<", "ntext")]
        public String LiveTips { get { return _LiveTips; } set { if (OnPropertyChanging(__.LiveTips, value)) { _LiveTips = value; OnPropertyChanged(__.LiveTips); } } }

        private String _GPSPosition;
        /// <summary>GPS位置</summary>
        [DisplayName("GPS位置")]
        [Description("GPS位置")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("GPSPosition", "GPS位置", "nvarchar(50)")]
        public String GPSPosition { get { return _GPSPosition; } set { if (OnPropertyChanging(__.GPSPosition, value)) { _GPSPosition = value; OnPropertyChanged(__.GPSPosition); } } }

        private String _LiveImage;
        /// <summary>现场图片</summary>
        [DisplayName("现场图片")]
        [Description("现场图片")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("LiveImage", "现场图片", "nchar(10)")]
        public String LiveImage { get { return _LiveImage; } set { if (OnPropertyChanging(__.LiveImage, value)) { _LiveImage = value; OnPropertyChanged(__.LiveImage); } } }

        private Int32 _EquipmentState;
        /// <summary>设备状态</summary>
        [DisplayName("设备状态")]
        [Description("设备状态")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("EquipmentState", "设备状态", "int")]
        public Int32 EquipmentState { get { return _EquipmentState; } set { if (OnPropertyChanging(__.EquipmentState, value)) { _EquipmentState = value; OnPropertyChanged(__.EquipmentState); } } }

        private Int32 _PowerSupplyMode;
        /// <summary>供电方式</summary>
        [DisplayName("供电方式")]
        [Description("供电方式")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("PowerSupplyMode", "供电方式", "int")]
        public Int32 PowerSupplyMode { get { return _PowerSupplyMode; } set { if (OnPropertyChanging(__.PowerSupplyMode, value)) { _PowerSupplyMode = value; OnPropertyChanged(__.PowerSupplyMode); } } }

        private DateTime _DiscardedTime;
        /// <summary>报废时间</summary>
        [DisplayName("报废时间")]
        [Description("报废时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("DiscardedTime", "报废时间", "smalldatetime")]
        public DateTime DiscardedTime { get { return _DiscardedTime; } set { if (OnPropertyChanging(__.DiscardedTime, value)) { _DiscardedTime = value; OnPropertyChanged(__.DiscardedTime); } } }

        private String _DiscardedReason;
        /// <summary>报废原因</summary>
        [DisplayName("报废原因")]
        [Description("报废原因")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("DiscardedReason", "报废原因", "nchar(10)")]
        public String DiscardedReason { get { return _DiscardedReason; } set { if (OnPropertyChanging(__.DiscardedReason, value)) { _DiscardedReason = value; OnPropertyChanged(__.DiscardedReason); } } }

        private String _Remarks;
        /// <summary>备注</summary>
        [DisplayName("备注")]
        [Description("备注")]
        [DataObjectField(false, false, true, -1)]
        [BindColumn("Remarks", "备注", "ntext")]
        public String Remarks { get { return _Remarks; } set { if (OnPropertyChanging(__.Remarks, value)) { _Remarks = value; OnPropertyChanged(__.Remarks); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.ID : return _ID;
                    case __.Number : return _Number;
                    case __.OwnedEnterprise : return _OwnedEnterprise;
                    case __.AssetNumber : return _AssetNumber;
                    case __.Name : return _Name;
                    case __.SpecificationModel : return _SpecificationModel;
                    case __.EquipmentType : return _EquipmentType;
                    case __.Manufacturer : return _Manufacturer;
                    case __.DeviceSerialNumber : return _DeviceSerialNumber;
                    case __.Purpose : return _Purpose;
                    case __.InstallationTime : return _InstallationTime;
                    case __.IntstallationPerson : return _IntstallationPerson;
                    case __.DetailedInstallPlace : return _DetailedInstallPlace;
                    case __.Position : return _Position;
                    case __.LiveTips : return _LiveTips;
                    case __.GPSPosition : return _GPSPosition;
                    case __.LiveImage : return _LiveImage;
                    case __.EquipmentState : return _EquipmentState;
                    case __.PowerSupplyMode : return _PowerSupplyMode;
                    case __.DiscardedTime : return _DiscardedTime;
                    case __.DiscardedReason : return _DiscardedReason;
                    case __.Remarks : return _Remarks;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.Number : _Number = Convert.ToInt32(value); break;
                    case __.OwnedEnterprise : _OwnedEnterprise = Convert.ToString(value); break;
                    case __.AssetNumber : _AssetNumber = Convert.ToString(value); break;
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.SpecificationModel : _SpecificationModel = Convert.ToString(value); break;
                    case __.EquipmentType : _EquipmentType = Convert.ToInt32(value); break;
                    case __.Manufacturer : _Manufacturer = Convert.ToString(value); break;
                    case __.DeviceSerialNumber : _DeviceSerialNumber = Convert.ToString(value); break;
                    case __.Purpose : _Purpose = Convert.ToInt32(value); break;
                    case __.InstallationTime : _InstallationTime = Convert.ToDateTime(value); break;
                    case __.IntstallationPerson : _IntstallationPerson = Convert.ToString(value); break;
                    case __.DetailedInstallPlace : _DetailedInstallPlace = Convert.ToString(value); break;
                    case __.Position : _Position = Convert.ToString(value); break;
                    case __.LiveTips : _LiveTips = Convert.ToString(value); break;
                    case __.GPSPosition : _GPSPosition = Convert.ToString(value); break;
                    case __.LiveImage : _LiveImage = Convert.ToString(value); break;
                    case __.EquipmentState : _EquipmentState = Convert.ToInt32(value); break;
                    case __.PowerSupplyMode : _PowerSupplyMode = Convert.ToInt32(value); break;
                    case __.DiscardedTime : _DiscardedTime = Convert.ToDateTime(value); break;
                    case __.DiscardedReason : _DiscardedReason = Convert.ToString(value); break;
                    case __.Remarks : _Remarks = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得现场设备字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>设备编号</summary>
            public static readonly Field Number = FindByName(__.Number);

            /// <summary>所属企业</summary>
            public static readonly Field OwnedEnterprise = FindByName(__.OwnedEnterprise);

            /// <summary>资产编码</summary>
            public static readonly Field AssetNumber = FindByName(__.AssetNumber);

            /// <summary>名称</summary>
            public static readonly Field Name = FindByName(__.Name);

            /// <summary>规格型号</summary>
            public static readonly Field SpecificationModel = FindByName(__.SpecificationModel);

            /// <summary>设备类型</summary>
            public static readonly Field EquipmentType = FindByName(__.EquipmentType);

            /// <summary>生产厂家</summary>
            public static readonly Field Manufacturer = FindByName(__.Manufacturer);

            /// <summary>设备序列号</summary>
            public static readonly Field DeviceSerialNumber = FindByName(__.DeviceSerialNumber);

            /// <summary>用途</summary>
            public static readonly Field Purpose = FindByName(__.Purpose);

            /// <summary>安装时间</summary>
            public static readonly Field InstallationTime = FindByName(__.InstallationTime);

            /// <summary>安装人员</summary>
            public static readonly Field IntstallationPerson = FindByName(__.IntstallationPerson);

            /// <summary>详细安装地址</summary>
            public static readonly Field DetailedInstallPlace = FindByName(__.DetailedInstallPlace);

            /// <summary>位置</summary>
            public static readonly Field Position = FindByName(__.Position);

            /// <summary>现场提示<</summary>
            public static readonly Field LiveTips = FindByName(__.LiveTips);

            /// <summary>GPS位置</summary>
            public static readonly Field GPSPosition = FindByName(__.GPSPosition);

            /// <summary>现场图片</summary>
            public static readonly Field LiveImage = FindByName(__.LiveImage);

            /// <summary>设备状态</summary>
            public static readonly Field EquipmentState = FindByName(__.EquipmentState);

            /// <summary>供电方式</summary>
            public static readonly Field PowerSupplyMode = FindByName(__.PowerSupplyMode);

            /// <summary>报废时间</summary>
            public static readonly Field DiscardedTime = FindByName(__.DiscardedTime);

            /// <summary>报废原因</summary>
            public static readonly Field DiscardedReason = FindByName(__.DiscardedReason);

            /// <summary>备注</summary>
            public static readonly Field Remarks = FindByName(__.Remarks);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得现场设备字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String ID = "ID";

            /// <summary>设备编号</summary>
            public const String Number = "Number";

            /// <summary>所属企业</summary>
            public const String OwnedEnterprise = "OwnedEnterprise";

            /// <summary>资产编码</summary>
            public const String AssetNumber = "AssetNumber";

            /// <summary>名称</summary>
            public const String Name = "Name";

            /// <summary>规格型号</summary>
            public const String SpecificationModel = "SpecificationModel";

            /// <summary>设备类型</summary>
            public const String EquipmentType = "EquipmentType";

            /// <summary>生产厂家</summary>
            public const String Manufacturer = "Manufacturer";

            /// <summary>设备序列号</summary>
            public const String DeviceSerialNumber = "DeviceSerialNumber";

            /// <summary>用途</summary>
            public const String Purpose = "Purpose";

            /// <summary>安装时间</summary>
            public const String InstallationTime = "InstallationTime";

            /// <summary>安装人员</summary>
            public const String IntstallationPerson = "IntstallationPerson";

            /// <summary>详细安装地址</summary>
            public const String DetailedInstallPlace = "DetailedInstallPlace";

            /// <summary>位置</summary>
            public const String Position = "Position";

            /// <summary>现场提示<</summary>
            public const String LiveTips = "LiveTips";

            /// <summary>GPS位置</summary>
            public const String GPSPosition = "GPSPosition";

            /// <summary>现场图片</summary>
            public const String LiveImage = "LiveImage";

            /// <summary>设备状态</summary>
            public const String EquipmentState = "EquipmentState";

            /// <summary>供电方式</summary>
            public const String PowerSupplyMode = "PowerSupplyMode";

            /// <summary>报废时间</summary>
            public const String DiscardedTime = "DiscardedTime";

            /// <summary>报废原因</summary>
            public const String DiscardedReason = "DiscardedReason";

            /// <summary>备注</summary>
            public const String Remarks = "Remarks";
        }
        #endregion
    }

    /// <summary>现场设备接口</summary>
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
        Int32 EquipmentType { get; set; }

        /// <summary>生产厂家</summary>
        String Manufacturer { get; set; }

        /// <summary>设备序列号</summary>
        String DeviceSerialNumber { get; set; }

        /// <summary>用途</summary>
        Int32 Purpose { get; set; }

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
        Int32 EquipmentState { get; set; }

        /// <summary>供电方式</summary>
        Int32 PowerSupplyMode { get; set; }

        /// <summary>报废时间</summary>
        DateTime DiscardedTime { get; set; }

        /// <summary>报废原因</summary>
        String DiscardedReason { get; set; }

        /// <summary>备注</summary>
        String Remarks { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}