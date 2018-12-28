/*
 * XCoder v4.8.4531.242
 * 作者：sk/DESKTOP-I6PMUKT
 * 时间：2018-12-26 09:02:39
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
    /// <summary>备件管理</summary>
    [Serializable]
    [DataObject]
    [Description("")]
    [BindIndex("PK_SpareManagment", true, "ID")]
    [BindTable("SpareManagment", Description = "", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class SpareManagment : ISpareManagment
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

        private String _Name;
        /// <summary>名称</summary>
        [DisplayName("名称")]
        [Description("名称")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(2, "Name", "备件名称", null, "nchar(10)", 0, 0, true)]
        public virtual String Name
        {
            get { return _Name; }
            set { if (OnPropertyChanging("Name", value)) { _Name = value; OnPropertyChanged("Name"); } }
        }

        private String _Specifications;
        /// <summary>规格</summary>
        [DisplayName("规格")]
        [Description("规格")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(3, "Specifications", "规格", null, "nchar(10)", 0, 0, true)]
        public virtual String Specifications
        {
            get { return _Specifications; }
            set { if (OnPropertyChanging("Specifications", value)) { _Specifications = value; OnPropertyChanged("Specifications"); } }
        }

        private String _Company;
        /// <summary>部门</summary>
        [DisplayName("部门")]
        [Description("部门")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(4, "Company", "部门", null, "nchar(10)", 0, 0, true)]
        public virtual String Company
        {
            get { return _Company; }
            set { if (OnPropertyChanging("Company", value)) { _Company = value; OnPropertyChanged("Company"); } }
        }

        private String _Warehouse;
        /// <summary>仓库位置</summary>
        [DisplayName("仓库位置")]
        [Description("仓库位置")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(5, "Warehouse", "仓库位置", null, "nchar(10)", 0, 0, true)]
        public virtual String Warehouse
        {
            get { return _Warehouse; }
            set { if (OnPropertyChanging("Warehouse", value)) { _Warehouse = value; OnPropertyChanged("Warehouse"); } }
        }

        private String _Number;
        /// <summary>数量</summary>
        [DisplayName("数量")]
        [Description("数量")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(6, "Number", "数量", null, "nchar(10)", 0, 0, true)]
        public virtual String Number
        {
            get { return _Number; }
            set { if (OnPropertyChanging("Number", value)) { _Number = value; OnPropertyChanged("Number"); } }
        }

        private String _Person;
        /// <summary>管理员</summary>
        [DisplayName("管理员")]
        [Description("管理员")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(7, "Person", "管理员", null, "nchar(10)", 0, 0, true)]
        public virtual String Person
        {
            get { return _Person; }
            set { if (OnPropertyChanging("Person", value)) { _Person = value; OnPropertyChanged("Person"); } }
        }

        private DateTime _Time;
        /// <summary>入库时间</summary>
        [DisplayName("入库时间")]
        [Description("入库时间")]
        [DataObjectField(false, false, true, 16)]
        [BindColumn(8, "Time", "入库时间", null, "smalldatetime", 0, 0, false)]
        public virtual DateTime Time
        {
            get { return _Time; }
            set { if (OnPropertyChanging("Time", value)) { _Time = value; OnPropertyChanged("Time"); } }
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
                    case "Name" : return _Name;
                    case "Specifications" : return _Specifications;
                    case "Company" : return _Company;
                    case "Warehouse" : return _Warehouse;
                    case "Number" : return _Number;
                    case "Person" : return _Person;
                    case "Time" : return _Time;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "ID" : _ID = Convert.ToInt32(value); break;
                    case "Name" : _Name = Convert.ToString(value); break;
                    case "Specifications" : _Specifications = Convert.ToString(value); break;
                    case "Company" : _Company = Convert.ToString(value); break;
                    case "Warehouse" : _Warehouse = Convert.ToString(value); break;
                    case "Number" : _Number = Convert.ToString(value); break;
                    case "Person" : _Person = Convert.ToString(value); break;
                    case "Time" : _Time = Convert.ToDateTime(value); break;
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
            public static readonly Field Name = FindByName("Name");

            ///<summary></summary>
            public static readonly Field Specifications = FindByName("Specifications");

            ///<summary></summary>
            public static readonly Field Company = FindByName("Company");

            ///<summary></summary>
            public static readonly Field Warehouse = FindByName("Warehouse");

            ///<summary></summary>
            public static readonly Field Number = FindByName("Number");

            ///<summary></summary>
            public static readonly Field Person = FindByName("Person");

            ///<summary></summary>
            public static readonly Field Time = FindByName("Time");

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface ISpareManagment
    {
        #region 属性
        /// <summary></summary>
        Int32 ID { get; set; }

        /// <summary></summary>
        String Name { get; set; }

        /// <summary></summary>
        String Specifications { get; set; }

        /// <summary></summary>
        String Company { get; set; }

        /// <summary></summary>
        String Warehouse { get; set; }

        /// <summary></summary>
        String Number { get; set; }

        /// <summary></summary>
        String Person { get; set; }

        /// <summary></summary>
        DateTime Time { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值。</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}