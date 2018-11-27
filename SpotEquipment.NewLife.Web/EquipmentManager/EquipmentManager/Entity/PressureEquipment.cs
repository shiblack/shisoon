/*
 * XCoder v4.8.4531.242
 * 作者：sk/DESKTOP-I6PMUKT
 * 时间：2018-11-27 19:50:37
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
    /// <summary>压力设备</summary>
    [Serializable]
    [DataObject]
    [Description("压力设备")]
    [BindTable("PressureEquipment", Description = "压力设备", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class PressureEquipment : IPressureEquipment
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

        private String _PrecisionGrade;
        /// <summary>精度等级</summary>
        [DisplayName("精度等级")]
        [Description("精度等级")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(4, "PrecisionGrade", "精度等级", null, "nchar(10)", 0, 0, true)]
        public virtual String PrecisionGrade
        {
            get { return _PrecisionGrade; }
            set { if (OnPropertyChanging("PrecisionGrade", value)) { _PrecisionGrade = value; OnPropertyChanged("PrecisionGrade"); } }
        }

        private String _RangeMin;
        /// <summary>量程下限</summary>
        [DisplayName("量程下限")]
        [Description("量程下限")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(5, "RangeMin", "量程下限", null, "nchar(10)", 0, 0, true)]
        public virtual String RangeMin
        {
            get { return _RangeMin; }
            set { if (OnPropertyChanging("RangeMin", value)) { _RangeMin = value; OnPropertyChanged("RangeMin"); } }
        }

        private String _RangeMax;
        /// <summary>量程上限</summary>
        [DisplayName("量程上限")]
        [Description("量程上限")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(6, "RangeMax", "量程上限", null, "nchar(10)", 0, 0, true)]
        public virtual String RangeMax
        {
            get { return _RangeMax; }
            set { if (OnPropertyChanging("RangeMax", value)) { _RangeMax = value; OnPropertyChanged("RangeMax"); } }
        }

        private String _VerificationPeriod;
        /// <summary>检定周期(年)</summary>
        [DisplayName("检定周期年")]
        [Description("检定周期(年)")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(7, "VerificationPeriod", "检定周期(年)", null, "nchar(10)", 0, 0, true)]
        public virtual String VerificationPeriod
        {
            get { return _VerificationPeriod; }
            set { if (OnPropertyChanging("VerificationPeriod", value)) { _VerificationPeriod = value; OnPropertyChanged("VerificationPeriod"); } }
        }

        private DateTime _VerificationDay;
        /// <summary>检定日期</summary>
        [DisplayName("检定日期")]
        [Description("检定日期")]
        [DataObjectField(false, false, true, 16)]
        [BindColumn(8, "VerificationDay", "检定日期", null, "smalldatetime", 0, 0, false)]
        public virtual DateTime VerificationDay
        {
            get { return _VerificationDay; }
            set { if (OnPropertyChanging("VerificationDay", value)) { _VerificationDay = value; OnPropertyChanged("VerificationDay"); } }
        }

        private DateTime _ExpirationDate;
        /// <summary>有效期限</summary>
        [DisplayName("有效期限")]
        [Description("有效期限")]
        [DataObjectField(false, false, true, 16)]
        [BindColumn(9, "ExpirationDate", "有效期限", null, "smalldatetime", 0, 0, false)]
        public virtual DateTime ExpirationDate
        {
            get { return _ExpirationDate; }
            set { if (OnPropertyChanging("ExpirationDate", value)) { _ExpirationDate = value; OnPropertyChanged("ExpirationDate"); } }
        }

        private String _VerificationCertificateNumber;
        /// <summary>检定证书编号</summary>
        [DisplayName("检定证书编号")]
        [Description("检定证书编号")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn(10, "VerificationCertificateNumber", "检定证书编号", null, "nchar(20)", 0, 0, true)]
        public virtual String VerificationCertificateNumber
        {
            get { return _VerificationCertificateNumber; }
            set { if (OnPropertyChanging("VerificationCertificateNumber", value)) { _VerificationCertificateNumber = value; OnPropertyChanged("VerificationCertificateNumber"); } }
        }

        private String _VerificationConclusion;
        /// <summary>检定结论</summary>
        [DisplayName("检定结论")]
        [Description("检定结论")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(11, "VerificationConclusion", "检定结论", null, "nchar(10)", 0, 0, true)]
        public virtual String VerificationConclusion
        {
            get { return _VerificationConclusion; }
            set { if (OnPropertyChanging("VerificationConclusion", value)) { _VerificationConclusion = value; OnPropertyChanged("VerificationConclusion"); } }
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
                    case "PrecisionGrade" : return _PrecisionGrade;
                    case "RangeMin" : return _RangeMin;
                    case "RangeMax" : return _RangeMax;
                    case "VerificationPeriod" : return _VerificationPeriod;
                    case "VerificationDay" : return _VerificationDay;
                    case "ExpirationDate" : return _ExpirationDate;
                    case "VerificationCertificateNumber" : return _VerificationCertificateNumber;
                    case "VerificationConclusion" : return _VerificationConclusion;
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
                    case "PrecisionGrade" : _PrecisionGrade = Convert.ToString(value); break;
                    case "RangeMin" : _RangeMin = Convert.ToString(value); break;
                    case "RangeMax" : _RangeMax = Convert.ToString(value); break;
                    case "VerificationPeriod" : _VerificationPeriod = Convert.ToString(value); break;
                    case "VerificationDay" : _VerificationDay = Convert.ToDateTime(value); break;
                    case "ExpirationDate" : _ExpirationDate = Convert.ToDateTime(value); break;
                    case "VerificationCertificateNumber" : _VerificationCertificateNumber = Convert.ToString(value); break;
                    case "VerificationConclusion" : _VerificationConclusion = Convert.ToString(value); break;
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

            ///<summary>精度等级</summary>
            public static readonly Field PrecisionGrade = FindByName("PrecisionGrade");

            ///<summary>量程下限</summary>
            public static readonly Field RangeMin = FindByName("RangeMin");

            ///<summary>量程上限</summary>
            public static readonly Field RangeMax = FindByName("RangeMax");

            ///<summary>检定周期(年)</summary>
            public static readonly Field VerificationPeriod = FindByName("VerificationPeriod");

            ///<summary>检定日期</summary>
            public static readonly Field VerificationDay = FindByName("VerificationDay");

            ///<summary>有效期限</summary>
            public static readonly Field ExpirationDate = FindByName("ExpirationDate");

            ///<summary>检定证书编号</summary>
            public static readonly Field VerificationCertificateNumber = FindByName("VerificationCertificateNumber");

            ///<summary>检定结论</summary>
            public static readonly Field VerificationConclusion = FindByName("VerificationConclusion");

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IPressureEquipment
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 ID { get; set; }

        /// <summary>设备编号</summary>
        Int32 Number1 { get; set; }

        /// <summary>现场设备编号</summary>
        String SpotEquipmentNumber { get; set; }

        /// <summary>精度等级</summary>
        String PrecisionGrade { get; set; }

        /// <summary>量程下限</summary>
        String RangeMin { get; set; }

        /// <summary>量程上限</summary>
        String RangeMax { get; set; }

        /// <summary>检定周期(年)</summary>
        String VerificationPeriod { get; set; }

        /// <summary>检定日期</summary>
        DateTime VerificationDay { get; set; }

        /// <summary>有效期限</summary>
        DateTime ExpirationDate { get; set; }

        /// <summary>检定证书编号</summary>
        String VerificationCertificateNumber { get; set; }

        /// <summary>检定结论</summary>
        String VerificationConclusion { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值。</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}