/*
 * XCoder v4.8.4531.242
 * 作者：sk/DESKTOP-I6PMUKT
 * 时间：2018-12-18 21:42:17
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
    /// <summary>文档管理</summary>
    [Serializable]
    [DataObject]
    [Description("")]
    [BindIndex("PK_Enclosure", true, "ID")]
    [BindTable("Enclosure", Description = "", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class Enclosure : IEnclosure
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

        private String _FileName;
        /// <summary>文件名</summary>
        [DisplayName("文件名")]
        [Description("文件名")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(2, "FileName", "文件名", null, "nvarchar(50)", 0, 0, true)]
        public virtual String FileName
        {
            get { return _FileName; }
            set { if (OnPropertyChanging("FileName", value)) { _FileName = value; OnPropertyChanged("FileName"); } }
        }

        private String _FileType;
        /// <summary>扩展名</summary>
        [DisplayName("扩展名")]
        [Description("扩展名")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn(3, "FileType", "扩展名", null, "nchar(20)", 0, 0, true)]
        public virtual String FileType
        {
            get { return _FileType; }
            set { if (OnPropertyChanging("FileType", value)) { _FileType = value; OnPropertyChanged("FileType"); } }
        }

        private String _Key;
        /// <summary>关联键</summary>
        [DisplayName("关联键")]
        [Description("关联键")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn(4, "Key", "关联键", null, "nchar(20)", 0, 0, true)]
        public virtual String Key
        {
            get { return _Key; }
            set { if (OnPropertyChanging("Key", value)) { _Key = value; OnPropertyChanged("Key"); } }
        }

        private Int32 _EntityID;
        /// <summary>关联编号</summary>
        [DisplayName("关联编号")]
        [Description("关联编号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(5, "EntityID", "关联编号", null, "int", 10, 0, false)]
        public virtual Int32 EntityID
        {
            get { return _EntityID; }
            set { if (OnPropertyChanging("EntityID", value)) { _EntityID = value; OnPropertyChanged("EntityID"); } }
        }

        private String _Route;
        /// <summary>路径</summary>
        [DisplayName("路径")]
        [Description("路径")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(6, "Route", "路径", null, "nvarchar(50)", 0, 0, true)]
        public virtual String Route
        {
            get { return _Route; }
            set { if (OnPropertyChanging("Route", value)) { _Route = value; OnPropertyChanged("Route"); } }
        }

        private String _UploadPerson;
        /// <summary>上传者</summary>
        [DisplayName("上传者")]
        [Description("上传者")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(7, "UploadPerson", "上传者", null, "nchar(10)", 0, 0, true)]
        public virtual String UploadPerson
        {
            get { return _UploadPerson; }
            set { if (OnPropertyChanging("UploadPerson", value)) { _UploadPerson = value; OnPropertyChanged("UploadPerson"); } }
        }

        private DateTime _UploadTime;
        /// <summary>上传时间</summary>
        [DisplayName("上传时间")]
        [Description("上传时间")]
        [DataObjectField(false, false, true, 16)]
        [BindColumn(8, "UploadTime", "上传时间", null, "smalldatetime", 0, 0, false)]
        public virtual DateTime UploadTime
        {
            get { return _UploadTime; }
            set { if (OnPropertyChanging("UploadTime", value)) { _UploadTime = value; OnPropertyChanged("UploadTime"); } }
        }

        private String _UpdatePerson;
        /// <summary>更新人员</summary>
        [DisplayName("更新人员")]
        [Description("更新人员")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(9, "UpdatePerson", "更新人员", null, "nchar(10)", 0, 0, true)]
        public virtual String UpdatePerson
        {
            get { return _UpdatePerson; }
            set { if (OnPropertyChanging("UpdatePerson", value)) { _UpdatePerson = value; OnPropertyChanged("UpdatePerson"); } }
        }

        private DateTime _UpdateTime;
        /// <summary>更新时间</summary>
        [DisplayName("更新时间")]
        [Description("更新时间")]
        [DataObjectField(false, false, true, 16)]
        [BindColumn(10, "UpdateTime", "更新时间", null, "smalldatetime", 0, 0, false)]
        public virtual DateTime UpdateTime
        {
            get { return _UpdateTime; }
            set { if (OnPropertyChanging("UpdateTime", value)) { _UpdateTime = value; OnPropertyChanged("UpdateTime"); } }
        }

        private String _Remark;
        /// <summary>备注</summary>
        [DisplayName("备注")]
        [Description("备注")]
        [DataObjectField(false, false, true, 1073741823)]
        [BindColumn(11, "Remark", "备注", null, "ntext", 0, 0, true)]
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
                    case "FileName" : return _FileName;
                    case "FileType" : return _FileType;
                    case "Key" : return _Key;
                    case "EntityID" : return _EntityID;
                    case "Route" : return _Route;
                    case "UploadPerson" : return _UploadPerson;
                    case "UploadTime" : return _UploadTime;
                    case "UpdatePerson" : return _UpdatePerson;
                    case "UpdateTime" : return _UpdateTime;
                    case "Remark" : return _Remark;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "ID" : _ID = Convert.ToInt32(value); break;
                    case "FileName" : _FileName = Convert.ToString(value); break;
                    case "FileType" : _FileType = Convert.ToString(value); break;
                    case "Key" : _Key = Convert.ToString(value); break;
                    case "EntityID" : _EntityID = Convert.ToInt32(value); break;
                    case "Route" : _Route = Convert.ToString(value); break;
                    case "UploadPerson" : _UploadPerson = Convert.ToString(value); break;
                    case "UploadTime" : _UploadTime = Convert.ToDateTime(value); break;
                    case "UpdatePerson" : _UpdatePerson = Convert.ToString(value); break;
                    case "UpdateTime" : _UpdateTime = Convert.ToDateTime(value); break;
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
            public static readonly Field FileName = FindByName("FileName");

            ///<summary></summary>
            public static readonly Field FileType = FindByName("FileType");

            ///<summary></summary>
            public static readonly Field Key = FindByName("Key");

            ///<summary></summary>
            public static readonly Field EntityID = FindByName("EntityID");

            ///<summary></summary>
            public static readonly Field Route = FindByName("Route");

            ///<summary></summary>
            public static readonly Field UploadPerson = FindByName("UploadPerson");

            ///<summary></summary>
            public static readonly Field UploadTime = FindByName("UploadTime");

            ///<summary></summary>
            public static readonly Field UpdatePerson = FindByName("UpdatePerson");

            ///<summary></summary>
            public static readonly Field UpdateTime = FindByName("UpdateTime");

            ///<summary></summary>
            public static readonly Field Remark = FindByName("Remark");

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IEnclosure
    {
        #region 属性
        /// <summary></summary>
        Int32 ID { get; set; }

        /// <summary></summary>
        String FileName { get; set; }

        /// <summary></summary>
        String FileType { get; set; }

        /// <summary></summary>
        String Key { get; set; }

        /// <summary></summary>
        Int32 EntityID { get; set; }

        /// <summary></summary>
        String Route { get; set; }

        /// <summary></summary>
        String UploadPerson { get; set; }

        /// <summary></summary>
        DateTime UploadTime { get; set; }

        /// <summary></summary>
        String UpdatePerson { get; set; }

        /// <summary></summary>
        DateTime UpdateTime { get; set; }

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