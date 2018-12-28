/*
 * XCoder v4.8.4531.242
 * 作者：sk/DESKTOP-I6PMUKT
 * 时间：2018-12-26 10:00:00
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
    /// <summary>设备维修</summary>
    [Serializable]
    [DataObject]
    [Description("")]
    [BindIndex("PK_SpotRepair", true, "ID")]
    [BindTable("SpotRepairEquipment", Description = "", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class SpotRepairEquipment : ISpotRepairEquipment
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

        private Int32 _SpotNumber;
        /// <summary>现场设备编号</summary>
        [DisplayName("现场设备编号")]
        [Description("现场设备编号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(2, "SpotNumber", "现场设备编号", null, "int", 10, 0, false)]
        public virtual Int32 SpotNumber
        {
            get { return _SpotNumber; }
            set { if (OnPropertyChanging("SpotNumber", value)) { _SpotNumber = value; OnPropertyChanged("SpotNumber"); } }
        }

        private String _Type;
        /// <summary>设备类型</summary>
        [DisplayName("设备类型")]
        [Description("设备类型")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(3, "Type", "设备类型", null, "nchar(10)", 0, 0, true)]
        public virtual String Type
        {
            get { return _Type; }
            set { if (OnPropertyChanging("Type", value)) { _Type = value; OnPropertyChanged("Type"); } }
        }

        private DateTime _OccurTime;
        /// <summary>发生时间</summary>
        [DisplayName("发生时间")]
        [Description("发生时间")]
        [DataObjectField(false, false, true, 16)]
        [BindColumn(4, "OccurTime", "发生时间", null, "smalldatetime", 0, 0, false)]
        public virtual DateTime OccurTime
        {
            get { return _OccurTime; }
            set { if (OnPropertyChanging("OccurTime", value)) { _OccurTime = value; OnPropertyChanged("OccurTime"); } }
        }

        private String _OccurPation;
        /// <summary>发生地点</summary>
        [DisplayName("发生地点")]
        [Description("发生地点")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn(5, "OccurPation", "发生地点", null, "nchar(20)", 0, 0, true)]
        public virtual String OccurPation
        {
            get { return _OccurPation; }
            set { if (OnPropertyChanging("OccurPation", value)) { _OccurPation = value; OnPropertyChanged("OccurPation"); } }
        }

        private String _OccerPreson;
        /// <summary>发生原因</summary>
        [DisplayName("发生原因")]
        [Description("发生原因")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(6, "OccerPreson", "发生原因", null, "nchar(10)", 0, 0, true)]
        public virtual String OccerPreson
        {
            get { return _OccerPreson; }
            set { if (OnPropertyChanging("OccerPreson", value)) { _OccerPreson = value; OnPropertyChanged("OccerPreson"); } }
        }

        private String _RepairPreson;
        /// <summary>维修人员</summary>
        [DisplayName("维修人员")]
        [Description("维修人员")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(7, "RepairPreson", "维修人员", null, "nchar(10)", 0, 0, true)]
        public virtual String RepairPreson
        {
            get { return _RepairPreson; }
            set { if (OnPropertyChanging("RepairPreson", value)) { _RepairPreson = value; OnPropertyChanged("RepairPreson"); } }
        }

        private DateTime _RepairTime;
        /// <summary>维修时间</summary>
        [DisplayName("维修时间")]
        [Description("维修时间")]
        [DataObjectField(false, false, true, 16)]
        [BindColumn(8, "RepairTime", "维修时间", null, "smalldatetime", 0, 0, false)]
        public virtual DateTime RepairTime
        {
            get { return _RepairTime; }
            set { if (OnPropertyChanging("RepairTime", value)) { _RepairTime = value; OnPropertyChanged("RepairTime"); } }
        }

        private String _Remark;
        /// <summary>备注</summary>
        [DisplayName("备注")]
        [Description("备注")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(9, "Remark", "备注", null, "nvarchar(50)", 0, 0, true)]
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
                    case "SpotNumber" : return _SpotNumber;
                    case "Type" : return _Type;
                    case "OccurTime" : return _OccurTime;
                    case "OccurPation" : return _OccurPation;
                    case "OccerPreson" : return _OccerPreson;
                    case "RepairPreson" : return _RepairPreson;
                    case "RepairTime" : return _RepairTime;
                    case "Remark" : return _Remark;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "ID" : _ID = Convert.ToInt32(value); break;
                    case "SpotNumber" : _SpotNumber = Convert.ToInt32(value); break;
                    case "Type" : _Type = Convert.ToString(value); break;
                    case "OccurTime" : _OccurTime = Convert.ToDateTime(value); break;
                    case "OccurPation" : _OccurPation = Convert.ToString(value); break;
                    case "OccerPreson" : _OccerPreson = Convert.ToString(value); break;
                    case "RepairPreson" : _RepairPreson = Convert.ToString(value); break;
                    case "RepairTime" : _RepairTime = Convert.ToDateTime(value); break;
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
            public static readonly Field SpotNumber = FindByName("SpotNumber");

            ///<summary></summary>
            public static readonly Field Type = FindByName("Type");

            ///<summary></summary>
            public static readonly Field OccurTime = FindByName("OccurTime");

            ///<summary></summary>
            public static readonly Field OccurPation = FindByName("OccurPation");

            ///<summary></summary>
            public static readonly Field OccerPreson = FindByName("OccerPreson");

            ///<summary></summary>
            public static readonly Field RepairPreson = FindByName("RepairPreson");

            ///<summary></summary>
            public static readonly Field RepairTime = FindByName("RepairTime");

            ///<summary></summary>
            public static readonly Field Remark = FindByName("Remark");

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface ISpotRepairEquipment
    {
        #region 属性
        /// <summary></summary>
        Int32 ID { get; set; }

        /// <summary></summary>
        Int32 SpotNumber { get; set; }

        /// <summary></summary>
        String Type { get; set; }

        /// <summary></summary>
        DateTime OccurTime { get; set; }

        /// <summary></summary>
        String OccurPation { get; set; }

        /// <summary></summary>
        String OccerPreson { get; set; }

        /// <summary></summary>
        String RepairPreson { get; set; }

        /// <summary></summary>
        DateTime RepairTime { get; set; }

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