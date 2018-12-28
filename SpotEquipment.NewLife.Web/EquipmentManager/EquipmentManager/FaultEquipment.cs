using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Model
{
    /// <summary></summary>
    [Serializable]
    [DataObject]
    [BindTable("FaultEquipment", Description = "", ConnName = "Model", DbType = DatabaseType.SqlServer)]
    public partial class FaultEquipment : IFaultEquipment
    {
        #region 属性
        private Int32 _ID;
        /// <summary>ID</summary>
        [DisplayName("ID")]
        [Description("ID")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("ID", "ID", "int")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private Int32 _SpotEquipmentNumber1;
        /// <summary>设备编号</summary>
        [DisplayName("设备编号")]
        [Description("设备编号")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("SpotEquipmentNumber1", "设备编号", "int")]
        public Int32 SpotEquipmentNumber1 { get { return _SpotEquipmentNumber1; } set { if (OnPropertyChanging(__.SpotEquipmentNumber1, value)) { _SpotEquipmentNumber1 = value; OnPropertyChanged(__.SpotEquipmentNumber1); } } }

        private String _Type;
        /// <summary>设备类型</summary>
        [DisplayName("设备类型")]
        [Description("设备类型")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("Type", "设备类型", "nchar(10)")]
        public String Type { get { return _Type; } set { if (OnPropertyChanging(__.Type, value)) { _Type = value; OnPropertyChanged(__.Type); } } }

        private DateTime _InstallationTime;
        /// <summary>安装时间</summary>
        [DisplayName("安装时间")]
        [Description("安装时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("InstallationTime", "安装时间", "smalldatetime")]
        public DateTime InstallationTime { get { return _InstallationTime; } set { if (OnPropertyChanging(__.InstallationTime, value)) { _InstallationTime = value; OnPropertyChanged(__.InstallationTime); } } }

        private String _OccurLocation;
        /// <summary>发生地点</summary>
        [DisplayName("发生地点")]
        [Description("发生地点")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn("OccurLocation", "发生地点", "nvarchar(20)")]
        public String OccurLocation { get { return _OccurLocation; } set { if (OnPropertyChanging(__.OccurLocation, value)) { _OccurLocation = value; OnPropertyChanged(__.OccurLocation); } } }

        private DateTime _OccurTime;
        /// <summary>发生时间</summary>
        [DisplayName("发生时间")]
        [Description("发生时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("OccurTime", "发生时间", "smalldatetime")]
        public DateTime OccurTime { get { return _OccurTime; } set { if (OnPropertyChanging(__.OccurTime, value)) { _OccurTime = value; OnPropertyChanged(__.OccurTime); } } }

        private String _FaultReason;
        /// <summary>故障原因</summary>
        [DisplayName("故障原因")]
        [Description("故障原因")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("FaultReason", "故障原因", "nchar(50)")]
        public String FaultReason { get { return _FaultReason; } set { if (OnPropertyChanging(__.FaultReason, value)) { _FaultReason = value; OnPropertyChanged(__.FaultReason); } } }

        private DateTime _RepairTime;
        /// <summary>维修时间</summary>
        [DisplayName("维修时间")]
        [Description("维修时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("RepairTime", "维修时间", "smalldatetime")]
        public DateTime RepairTime { get { return _RepairTime; } set { if (OnPropertyChanging(__.RepairTime, value)) { _RepairTime = value; OnPropertyChanged(__.RepairTime); } } }

        private String _RepairPreson;
        /// <summary>维修人员</summary>
        [DisplayName("维修人员")]
        [Description("维修人员")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("RepairPreson", "维修人员", "nchar(10)")]
        public String RepairPreson { get { return _RepairPreson; } set { if (OnPropertyChanging(__.RepairPreson, value)) { _RepairPreson = value; OnPropertyChanged(__.RepairPreson); } } }

        private String _Remark;
        /// <summary>备注</summary>
        [DisplayName("备注")]
        [Description("备注")]
        [DataObjectField(false, false, true, -1)]
        [BindColumn("Remark", "备注", "text")]
        public String Remark { get { return _Remark; } set { if (OnPropertyChanging(__.Remark, value)) { _Remark = value; OnPropertyChanged(__.Remark); } } }
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
                    case __.SpotEquipmentNumber1 : return _SpotEquipmentNumber1;
                    case __.Type : return _Type;
                    case __.InstallationTime : return _InstallationTime;
                    case __.OccurLocation : return _OccurLocation;
                    case __.OccurTime : return _OccurTime;
                    case __.FaultReason : return _FaultReason;
                    case __.RepairTime : return _RepairTime;
                    case __.RepairPreson : return _RepairPreson;
                    case __.Remark : return _Remark;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.SpotEquipmentNumber1 : _SpotEquipmentNumber1 = Convert.ToInt32(value); break;
                    case __.Type : _Type = Convert.ToString(value); break;
                    case __.InstallationTime : _InstallationTime = Convert.ToDateTime(value); break;
                    case __.OccurLocation : _OccurLocation = Convert.ToString(value); break;
                    case __.OccurTime : _OccurTime = Convert.ToDateTime(value); break;
                    case __.FaultReason : _FaultReason = Convert.ToString(value); break;
                    case __.RepairTime : _RepairTime = Convert.ToDateTime(value); break;
                    case __.RepairPreson : _RepairPreson = Convert.ToString(value); break;
                    case __.Remark : _Remark = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得FaultEquipment字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>ID</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>设备编号</summary>
            public static readonly Field SpotEquipmentNumber1 = FindByName(__.SpotEquipmentNumber1);

            /// <summary>设备类型</summary>
            public static readonly Field Type = FindByName(__.Type);

            /// <summary>安装时间</summary>
            public static readonly Field InstallationTime = FindByName(__.InstallationTime);

            /// <summary>发生地点</summary>
            public static readonly Field OccurLocation = FindByName(__.OccurLocation);

            /// <summary>发生时间</summary>
            public static readonly Field OccurTime = FindByName(__.OccurTime);

            /// <summary>故障原因</summary>
            public static readonly Field FaultReason = FindByName(__.FaultReason);

            /// <summary>维修时间</summary>
            public static readonly Field RepairTime = FindByName(__.RepairTime);

            /// <summary>维修人员</summary>
            public static readonly Field RepairPreson = FindByName(__.RepairPreson);

            /// <summary>备注</summary>
            public static readonly Field Remark = FindByName(__.Remark);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得FaultEquipment字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>ID</summary>
            public const String ID = "ID";

            /// <summary>设备编号</summary>
            public const String SpotEquipmentNumber1 = "SpotEquipmentNumber1";

            /// <summary>设备类型</summary>
            public const String Type = "Type";

            /// <summary>安装时间</summary>
            public const String InstallationTime = "InstallationTime";

            /// <summary>发生地点</summary>
            public const String OccurLocation = "OccurLocation";

            /// <summary>发生时间</summary>
            public const String OccurTime = "OccurTime";

            /// <summary>故障原因</summary>
            public const String FaultReason = "FaultReason";

            /// <summary>维修时间</summary>
            public const String RepairTime = "RepairTime";

            /// <summary>维修人员</summary>
            public const String RepairPreson = "RepairPreson";

            /// <summary>备注</summary>
            public const String Remark = "Remark";
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IFaultEquipment
    {
        #region 属性
        /// <summary>ID</summary>
        Int32 ID { get; set; }

        /// <summary>设备编号</summary>
        Int32 SpotEquipmentNumber1 { get; set; }

        /// <summary>设备类型</summary>
        String Type { get; set; }

        /// <summary>安装时间</summary>
        DateTime InstallationTime { get; set; }

        /// <summary>发生地点</summary>
        String OccurLocation { get; set; }

        /// <summary>发生时间</summary>
        DateTime OccurTime { get; set; }

        /// <summary>故障原因</summary>
        String FaultReason { get; set; }

        /// <summary>维修时间</summary>
        DateTime RepairTime { get; set; }

        /// <summary>维修人员</summary>
        String RepairPreson { get; set; }

        /// <summary>备注</summary>
        String Remark { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}