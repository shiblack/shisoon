/*
 * XCoder v4.8.4531.242
 * 作者：sk/DESKTOP-I6PMUKT
 * 时间：2018-11-01 21:13:58
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
    [BindTable("IntelligentTerminal", Description = "", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class IntelligentTerminal : IIntelligentTerminal
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

        private Int32 _Number1;
        /// <summary>设备编号</summary>
        [DisplayName("设备编号")]
        [Description("设备编号")]
        [DataObjectField(false, false, false, 10)]
        [BindColumn(2, "Number1", "设备编号", null, "int", 10, 0, false)]
        public virtual Int32 Number1
        {
            get { return _Number1; }
            set { if (OnPropertyChanging("Number1", value)) { _Number1 = value; OnPropertyChanged("Number1"); } }
        }

        private String _SpotEquipmentNumber;
        /// <summary>现场设备编号</summary>
        [DisplayName("现场设备编号")]
        [Description("现场设备编号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(3, "SpotEquipmentNumber", "现场设备编号", null, "nchar(10)", 0, 0, true)]
        public virtual String SpotEquipmentNumber
        {
            get { return _SpotEquipmentNumber; }
            set { if (OnPropertyChanging("SpotEquipmentNumber", value)) { _SpotEquipmentNumber = value; OnPropertyChanged("SpotEquipmentNumber"); } }
        }

        private String _ConnMode;
        /// <summary>通讯方式</summary>
        [DisplayName("通讯方式")]
        [Description("通讯方式")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(4, "ConnMode", "通讯方式", null, "nvarchar(50)", 0, 0, true)]
        public ComMode ConnMode
        {
            get;set;
        }

        private String _TelephoneNumber;
        /// <summary>电话号码</summary>
        [DisplayName("电话号码")]
        [Description("电话号码")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(5, "TelephoneNumber", "电话号码", null, "nvarchar(50)", 0, 0, true)]
        public virtual String TelephoneNumber
        {
            get { return _TelephoneNumber; }
            set { if (OnPropertyChanging("TelephoneNumber", value)) { _TelephoneNumber = value; OnPropertyChanged("TelephoneNumber"); } }
        }

        private String _CostPackage;
        /// <summary>费用套餐</summary>
        [DisplayName("费用套餐")]
        [Description("费用套餐")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(6, "CostPackage", "费用套餐", null, "nchar(10)", 0, 0, true)]
        public virtual String CostPackage
        {
            get { return _CostPackage; }
            set { if (OnPropertyChanging("CostPackage", value)) { _CostPackage = value; OnPropertyChanged("CostPackage"); } }
        }

        private String _RenewalCycle;
        /// <summary>续费周期</summary>
        [DisplayName("续费周期")]
        [Description("续费周期")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(7, "RenewalCycle", "续费周期", null, "nchar(10)", 0, 0, true)]
        public virtual String RenewalCycle
        {
            get { return _RenewalCycle; }
            set { if (OnPropertyChanging("RenewalCycle", value)) { _RenewalCycle = value; OnPropertyChanged("RenewalCycle"); } }
        }

        private DateTime _ThisRenewalTime;
        /// <summary>本次续费时间</summary>
        [DisplayName("本次续费时间")]
        [Description("本次续费时间")]
        [DataObjectField(false, false, true, 16)]
        [BindColumn(8, "ThisRenewalTime", "本次续费时间", null, "smalldatetime", 0, 0, false)]
        public virtual DateTime ThisRenewalTime
        {
            get { return _ThisRenewalTime; }
            set { if (OnPropertyChanging("ThisRenewalTime", value)) { _ThisRenewalTime = value; OnPropertyChanged("ThisRenewalTime"); } }
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
                    case "Number1" : return _Number1;
                    case "SpotEquipmentNumber" : return _SpotEquipmentNumber;
                    case "ConnMode" : return _ConnMode;
                    case "TelephoneNumber" : return _TelephoneNumber;
                    case "CostPackage" : return _CostPackage;
                    case "RenewalCycle" : return _RenewalCycle;
                    case "ThisRenewalTime" : return _ThisRenewalTime;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "ID" : _ID = Convert.ToInt32(value); break;
                    case "Number1" : _Number1 = Convert.ToInt32(value); break;
                    case "SpotEquipmentNumber" : _SpotEquipmentNumber = Convert.ToString(value); break;
                    case "ConnMode" : _ConnMode = Convert.ToString(value); break;
                    case "TelephoneNumber" : _TelephoneNumber = Convert.ToString(value); break;
                    case "CostPackage" : _CostPackage = Convert.ToString(value); break;
                    case "RenewalCycle" : _RenewalCycle = Convert.ToString(value); break;
                    case "ThisRenewalTime" : _ThisRenewalTime = Convert.ToDateTime(value); break;
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
            public static readonly Field Number1 = FindByName("Number1");

            ///<summary>现场设备编号</summary>
            public static readonly Field SpotEquipmentNumber = FindByName("SpotEquipmentNumber");

            ///<summary>通讯方式</summary>
            public static readonly Field ConnMode = FindByName("ConnMode");

            ///<summary>电话号码</summary>
            public static readonly Field TelephoneNumber = FindByName("TelephoneNumber");

            ///<summary>费用套餐</summary>
            public static readonly Field CostPackage = FindByName("CostPackage");

            ///<summary>续费周期</summary>
            public static readonly Field RenewalCycle = FindByName("RenewalCycle");

            ///<summary>本次续费时间</summary>
            public static readonly Field ThisRenewalTime = FindByName("ThisRenewalTime");

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }
        #endregion
    }

    /// <summary>接口</summary>
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
        ComMode ConnMode { get; set; }

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
        /// <summary>获取/设置 字段值。</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}