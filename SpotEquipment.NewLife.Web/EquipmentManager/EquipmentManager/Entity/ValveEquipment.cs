/*
 * XCoder v4.8.4531.242
 * 作者：sk/DESKTOP-I6PMUKT
 * 时间：2018-11-27 19:51:40
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
    /// <summary></summary>
    [Serializable]
    [DataObject]
    [Description("")]
    [BindIndex("PK_ValveEquipment", true, "ID")]
    [BindTable("ValveEquipment", Description = "", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class ValveEquipment : IValveEquipment
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
        [DataObjectField(false, false, true, 10)]
        [BindColumn(2, "Number1", "设备编号", null, "int", 10, 0, false)]
        public virtual Int32 Number1
        {
            get { return _Number1; }
            set { if (OnPropertyChanging("Number1", value)) { _Number1 = value; OnPropertyChanged("Number1"); } }
        }

        private String _SpotEquipmentNumber1;
        /// <summary>现场设备编号</summary>
        [DisplayName("现场设备编号")]
        [Description("现场设备编号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(3, "SpotEquipmentNumber1", "现场设备编号", null, "nchar(10)", 0, 0, true)]
        public virtual String SpotEquipmentNumber1
        {
            get { return _SpotEquipmentNumber1; }
            set { if (OnPropertyChanging("SpotEquipmentNumber1", value)) { _SpotEquipmentNumber1 = value; OnPropertyChanged("SpotEquipmentNumber1"); } }
        }

        private String _MaterialScience;
        /// <summary>材质</summary>
        [DisplayName("材质")]
        [Description("材质")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(4, "MaterialScience", "材质", null, "nchar(10)", 0, 0, true)]
        public virtual String MaterialScience
        {
            get { return _MaterialScience; }
            set { if (OnPropertyChanging("MaterialScience", value)) { _MaterialScience = value; OnPropertyChanged("MaterialScience"); } }
        }

        private Int32 _Type;
        /// <summary>类型</summary>
        [DisplayName("类型")]
        [Description("类型")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(5, "Type", "类型", null, "int", 10, 0, false)]
        public virtual Int32 Type
        {
            get { return _Type; }
            set { if (OnPropertyChanging("Type", value)) { _Type = value; OnPropertyChanged("Type"); } }
        }

        private String _Caliber;
        /// <summary>口径</summary>
        [DisplayName("口径")]
        [Description("口径")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(6, "Caliber", "口径", null, "nchar(10)", 0, 0, true)]
        public virtual String Caliber
        {
            get { return _Caliber; }
            set { if (OnPropertyChanging("Caliber", value)) { _Caliber = value; OnPropertyChanged("Caliber"); } }
        }

        private String _Purpose1;
        /// <summary>用途</summary>
        [DisplayName("用途")]
        [Description("用途")]
        [DataObjectField(false, false, true, 1073741823)]
        [BindColumn(7, "Purpose1", "用途", null, "ntext", 0, 0, true)]
        public virtual String Purpose1
        {
            get { return _Purpose1; }
            set { if (OnPropertyChanging("Purpose1", value)) { _Purpose1 = value; OnPropertyChanged("Purpose1"); } }
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
                    case "SpotEquipmentNumber1" : return _SpotEquipmentNumber1;
                    case "MaterialScience" : return _MaterialScience;
                    case "Type" : return _Type;
                    case "Caliber" : return _Caliber;
                    case "Purpose1" : return _Purpose1;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "ID" : _ID = Convert.ToInt32(value); break;
                    case "Number1" : _Number1 = Convert.ToInt32(value); break;
                    case "SpotEquipmentNumber1" : _SpotEquipmentNumber1 = Convert.ToString(value); break;
                    case "MaterialScience" : _MaterialScience = Convert.ToString(value); break;
                    case "Type" : _Type = Convert.ToInt32(value); break;
                    case "Caliber" : _Caliber = Convert.ToString(value); break;
                    case "Purpose1" : _Purpose1 = Convert.ToString(value); break;
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
            public static readonly Field SpotEquipmentNumber1 = FindByName("SpotEquipmentNumber1");

            ///<summary>材质</summary>
            public static readonly Field MaterialScience = FindByName("MaterialScience");

            ///<summary>类型</summary>
            public static readonly Field Type = FindByName("Type");

            ///<summary>口径</summary>
            public static readonly Field Caliber = FindByName("Caliber");

            ///<summary>用途</summary>
            public static readonly Field Purpose1 = FindByName("Purpose1");

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IValveEquipment
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 ID { get; set; }

        /// <summary>设备编号</summary>
        Int32 Number1 { get; set; }

        /// <summary>现场设备编号</summary>
        String SpotEquipmentNumber1 { get; set; }

        /// <summary>材质</summary>
        String MaterialScience { get; set; }

        /// <summary>类型</summary>
        Int32 Type { get; set; }

        /// <summary>口径</summary>
        String Caliber { get; set; }

        /// <summary>用途</summary>
        String Purpose1 { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值。</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}