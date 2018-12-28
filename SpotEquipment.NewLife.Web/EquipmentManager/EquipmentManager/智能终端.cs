using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Model
{
    /// <summary>智能终端</summary>
    [Serializable]
    [DataObject]
    [Description("智能终端")]
    [BindTable("IntelligentTerminal", Description = "智能终端", ConnName = "Model", DbType = DatabaseType.SqlServer)]
    public partial class IntelligentTerminal : IIntelligentTerminal
    {
        #region 属性
        private Int32 _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "编号", "int")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private Int32 _Number1;
        /// <summary>设备编号</summary>
        [DisplayName("设备编号")]
        [Description("设备编号")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Number1", "设备编号", "int")]
        public Int32 Number1 { get { return _Number1; } set { if (OnPropertyChanging(__.Number1, value)) { _Number1 = value; OnPropertyChanged(__.Number1); } } }

        private String _SpotEquipmentNumber;
        /// <summary>现场设备编号</summary>
        [DisplayName("现场设备编号")]
        [Description("现场设备编号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("SpotEquipmentNumber", "现场设备编号", "nchar(10)")]
        public String SpotEquipmentNumber { get { return _SpotEquipmentNumber; } set { if (OnPropertyChanging(__.SpotEquipmentNumber, value)) { _SpotEquipmentNumber = value; OnPropertyChanged(__.SpotEquipmentNumber); } } }

        private Int32 _ConnMode;
        /// <summary>通讯方式</summary>
        [DisplayName("通讯方式")]
        [Description("通讯方式")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("ConnMode", "通讯方式", "int")]
        public Int32 ConnMode { get { return _ConnMode; } set { if (OnPropertyChanging(__.ConnMode, value)) { _ConnMode = value; OnPropertyChanged(__.ConnMode); } } }

        private String _TelephoneNumber;
        /// <summary>电话号码</summary>
        [DisplayName("电话号码")]
        [Description("电话号码")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("TelephoneNumber", "电话号码", "nvarchar(50)")]
        public String TelephoneNumber { get { return _TelephoneNumber; } set { if (OnPropertyChanging(__.TelephoneNumber, value)) { _TelephoneNumber = value; OnPropertyChanged(__.TelephoneNumber); } } }

        private String _CostPackage;
        /// <summary>费用套餐</summary>
        [DisplayName("费用套餐")]
        [Description("费用套餐")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("CostPackage", "费用套餐", "nchar(10)")]
        public String CostPackage { get { return _CostPackage; } set { if (OnPropertyChanging(__.CostPackage, value)) { _CostPackage = value; OnPropertyChanged(__.CostPackage); } } }

        private String _RenewalCycle;
        /// <summary>续费周期</summary>
        [DisplayName("续费周期")]
        [Description("续费周期")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("RenewalCycle", "续费周期", "nchar(10)")]
        public String RenewalCycle { get { return _RenewalCycle; } set { if (OnPropertyChanging(__.RenewalCycle, value)) { _RenewalCycle = value; OnPropertyChanged(__.RenewalCycle); } } }

        private DateTime _ThisRenewalTime;
        /// <summary>本次续费时间</summary>
        [DisplayName("本次续费时间")]
        [Description("本次续费时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("ThisRenewalTime", "本次续费时间", "smalldatetime")]
        public DateTime ThisRenewalTime { get { return _ThisRenewalTime; } set { if (OnPropertyChanging(__.ThisRenewalTime, value)) { _ThisRenewalTime = value; OnPropertyChanged(__.ThisRenewalTime); } } }
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
                    case __.Number1 : return _Number1;
                    case __.SpotEquipmentNumber : return _SpotEquipmentNumber;
                    case __.ConnMode : return _ConnMode;
                    case __.TelephoneNumber : return _TelephoneNumber;
                    case __.CostPackage : return _CostPackage;
                    case __.RenewalCycle : return _RenewalCycle;
                    case __.ThisRenewalTime : return _ThisRenewalTime;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.Number1 : _Number1 = Convert.ToInt32(value); break;
                    case __.SpotEquipmentNumber : _SpotEquipmentNumber = Convert.ToString(value); break;
                    case __.ConnMode : _ConnMode = Convert.ToInt32(value); break;
                    case __.TelephoneNumber : _TelephoneNumber = Convert.ToString(value); break;
                    case __.CostPackage : _CostPackage = Convert.ToString(value); break;
                    case __.RenewalCycle : _RenewalCycle = Convert.ToString(value); break;
                    case __.ThisRenewalTime : _ThisRenewalTime = Convert.ToDateTime(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得智能终端字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>设备编号</summary>
            public static readonly Field Number1 = FindByName(__.Number1);

            /// <summary>现场设备编号</summary>
            public static readonly Field SpotEquipmentNumber = FindByName(__.SpotEquipmentNumber);

            /// <summary>通讯方式</summary>
            public static readonly Field ConnMode = FindByName(__.ConnMode);

            /// <summary>电话号码</summary>
            public static readonly Field TelephoneNumber = FindByName(__.TelephoneNumber);

            /// <summary>费用套餐</summary>
            public static readonly Field CostPackage = FindByName(__.CostPackage);

            /// <summary>续费周期</summary>
            public static readonly Field RenewalCycle = FindByName(__.RenewalCycle);

            /// <summary>本次续费时间</summary>
            public static readonly Field ThisRenewalTime = FindByName(__.ThisRenewalTime);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得智能终端字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String ID = "ID";

            /// <summary>设备编号</summary>
            public const String Number1 = "Number1";

            /// <summary>现场设备编号</summary>
            public const String SpotEquipmentNumber = "SpotEquipmentNumber";

            /// <summary>通讯方式</summary>
            public const String ConnMode = "ConnMode";

            /// <summary>电话号码</summary>
            public const String TelephoneNumber = "TelephoneNumber";

            /// <summary>费用套餐</summary>
            public const String CostPackage = "CostPackage";

            /// <summary>续费周期</summary>
            public const String RenewalCycle = "RenewalCycle";

            /// <summary>本次续费时间</summary>
            public const String ThisRenewalTime = "ThisRenewalTime";
        }
        #endregion
    }

    /// <summary>智能终端接口</summary>
    public partial interface IIntelligentTerminal
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 ID { get; set; }

        /// <summary>设备编号</summary>
        Int32 Number1 { get; set; }

        /// <summary>现场设备编号</summary>
        String SpotEquipmentNumber { get; set; }

        /// <summary>通讯方式</summary>
        Int32 ConnMode { get; set; }

        /// <summary>电话号码</summary>
        String TelephoneNumber { get; set; }

        /// <summary>费用套餐</summary>
        String CostPackage { get; set; }

        /// <summary>续费周期</summary>
        String RenewalCycle { get; set; }

        /// <summary>本次续费时间</summary>
        DateTime ThisRenewalTime { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}