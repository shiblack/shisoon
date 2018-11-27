/*
 * XCoder v4.8.4531.242
 * 作者：sk/DESKTOP-I6PMUKT
 * 时间：2018-11-01 15:21:27
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
    [BindTable("FlowEquipment", Description = "", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class FlowEquipment : IFlowEquipment
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

        private String _WMaterNumber;
        /// <summary>水表编号</summary>
        [DisplayName("水表编号")]
        [Description("水表编号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(4, "WMaterNumber", "水表编号", null, "nchar(10)", 0, 0, true)]
        public virtual String WMaterNumber
        {
            get { return _WMaterNumber; }
            set { if (OnPropertyChanging("WMaterNumber", value)) { _WMaterNumber = value; OnPropertyChanged("WMaterNumber"); } }
        }

        private String _CustNumber;
        /// <summary>客户编号</summary>
        [DisplayName("客户编号")]
        [Description("客户编号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(5, "CustNumber", "客户编号", null, "nchar(10)", 0, 0, true)]
        public virtual String CustNumber
        {
            get { return _CustNumber; }
            set { if (OnPropertyChanging("CustNumber", value)) { _CustNumber = value; OnPropertyChanged("CustNumber"); } }
        }

        private String _Brand;
        /// <summary>品牌</summary>
        [DisplayName("品牌")]
        [Description("品牌")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn(6, "Brand", "品牌", null, "nchar(20)", 0, 0, true)]
        public virtual String Brand
        {
            get { return _Brand; }
            set { if (OnPropertyChanging("Brand", value)) { _Brand = value; OnPropertyChanged("Brand"); } }
        }

        private String _Caliber;
        /// <summary>口径</summary>
        [DisplayName("口径")]
        [Description("口径")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(7, "Caliber", "口径", null, "nchar(10)", 0, 0, true)]
        public virtual String Caliber
        {
            get { return _Caliber; }
            set { if (OnPropertyChanging("Caliber", value)) { _Caliber = value; OnPropertyChanged("Caliber"); } }
        }

        private NewType _Accuracy;
        /// <summary>精度</summary>
        [DisplayName("精度")]
        [Description("精度")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(8, "Accuracy", "精度", null, "NewType", 0, 0, true)]
        public virtual NewType Accuracy
        {

            get { return _Accuracy; }
            set { if (OnPropertyChanging("Accuracy", value)) { _Accuracy = value; OnPropertyChanged("Accuracy"); } }
        }
        private String _RangeRatio;
        /// <summary>量程比</summary>
        [DisplayName("量程比")]
        [Description("量程比")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(9, "RangeRatio", "量程比", null, "nchar(10)", 0, 0, true)]
        public virtual String RangeRatio
        {
            get { return _RangeRatio; }
            set { if (OnPropertyChanging("RangeRatio", value)) { _RangeRatio = value; OnPropertyChanged("RangeRatio"); } }
        }

        private MerRange _MeasureRange;
        /// <summary>测量范围</summary>
        [DisplayName("测量范围")]
        [Description("测量范围")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(10, "MeasureRange", "测量范围", null, "MerRange", 0, 0, true)]
        public virtual MerRange MeasureRange
        {
            get { return _MeasureRange; }
            set { if (OnPropertyChanging("MeasureRange", value)) { _MeasureRange = value; OnPropertyChanged("MeasureRange"); } }
        }
        private String _MaxIndication;
        /// <summary>最大示值</summary>
        [DisplayName("最大示值")]
        [Description("最大示值")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(11, "MaxIndication", "最大示值", null, "nchar(10)", 0, 0, true)]
        public virtual String MaxIndication
        {
            get { return _MaxIndication; }
            set { if (OnPropertyChanging("MaxIndication", value)) { _MaxIndication = value; OnPropertyChanged("MaxIndication"); } }
        }

        private String _ConnInterface;
        /// <summary>通讯接口</summary>
        [DisplayName("通讯接口")]
        [Description("通讯接口")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(12, "ConnInterface", "通讯接口", null, "nchar(10)", 0, 0, true)]
        public virtual String ConnInterface
        {
            get { return _ConnInterface; }
            set { if (OnPropertyChanging("ConnInterface", value)) { _ConnInterface = value; OnPropertyChanged("ConnInterface"); } }
        }

        private String _ConversionCoefficient;
        /// <summary>转换系数</summary>
        [DisplayName("转换系数")]
        [Description("转换系数")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(13, "ConversionCoefficient", "转换系数", null, "nchar(10)", 0, 0, true)]
        public virtual String ConversionCoefficient
        {
            get { return _ConversionCoefficient; }
            set { if (OnPropertyChanging("ConversionCoefficient", value)) { _ConversionCoefficient = value; OnPropertyChanged("ConversionCoefficient"); } }
        }

        private String _VerificationPeriod;
        /// <summary>检定周期（年）</summary>
        [DisplayName("检定周期（年）")]
        [Description("检定周期（年）")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(14, "VerificationPeriod", "检定周期（年）", null, "nchar(10)", 0, 0, true)]
        public virtual String VerificationPeriod
        {
            get { return _VerificationPeriod; }
            set { if (OnPropertyChanging("VerificationPeriod", value)) { _VerificationPeriod = value; OnPropertyChanged("VerificationPeriod"); } }
        }

        private DateTime _VerificationDay;
        /// <summary>检定周期</summary>
        [DisplayName("检定周期")]
        [Description("检定周期")]
        [DataObjectField(false, false, true, 16)]
        [BindColumn(15, "VerificationDay", "检定周期", null, "smalldatetime", 0, 0, false)]
        public virtual DateTime VerificationDay
        {
            get { return _VerificationDay; }
            set { if (OnPropertyChanging("VerificationDay", value)) { _VerificationDay = value; OnPropertyChanged("VerificationDay"); } }
        }

        private DateTime _ExpirationDateF;
        /// <summary>有效期限</summary>
        [DisplayName("有效期限")]
        [Description("有效期限")]
        [DataObjectField(false, false, true, 16)]
        [BindColumn(16, "ExpirationDateF", "有效期限", null, "smalldatetime", 0, 0, false)]
        public virtual DateTime ExpirationDateF
        {
            get { return _ExpirationDateF; }
            set { if (OnPropertyChanging("ExpirationDateF", value)) { _ExpirationDateF = value; OnPropertyChanged("ExpirationDateF"); } }
        }

        private String _VerificationCertificateNumber;
        /// <summary>鉴定证书编号</summary>
        [DisplayName("鉴定证书编号")]
        [Description("鉴定证书编号")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn(17, "VerificationCertificateNumber", "鉴定证书编号", null, "nchar(20)", 0, 0, true)]
        public virtual String VerificationCertificateNumber
        {
            get { return _VerificationCertificateNumber; }
            set { if (OnPropertyChanging("VerificationCertificateNumber", value)) { _VerificationCertificateNumber = value; OnPropertyChanged("VerificationCertificateNumber"); } }
        }

        private String _VerificationConclusion;
        /// <summary>检定结论</summary>
        [DisplayName("检定结论")]
        [Description("检定结论")]
        [DataObjectField(false, false, true, 1073741823)]
        [BindColumn(18, "VerificationConclusion", "检定结论", null, "ntext", 0, 0, true)]
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
                    case "WMaterNumber" : return _WMaterNumber;
                    case "CustNumber" : return _CustNumber;
                    case "Brand" : return _Brand;
                    case "Caliber" : return _Caliber;
                    case "Accuracy" : return _Accuracy;
                    case "RangeRatio" : return _RangeRatio;
                    case "MeasureRange" : return _MeasureRange;
                    case "MaxIndication" : return _MaxIndication;
                    case "ConnInterface" : return _ConnInterface;
                    case "ConversionCoefficient" : return _ConversionCoefficient;
                    case "VerificationPeriod" : return _VerificationPeriod;
                    case "VerificationDay" : return _VerificationDay;
                    case "ExpirationDateF" : return _ExpirationDateF;
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
                    case "WMaterNumber" : _WMaterNumber = Convert.ToString(value); break;
                    case "CustNumber" : _CustNumber = Convert.ToString(value); break;
                    case "Brand" : _Brand = Convert.ToString(value); break;
                    case "Caliber" : _Caliber = Convert.ToString(value); break;
                    case "Accuracy" : _Accuracy = (NewType)value; break;
                    case "RangeRatio" : _RangeRatio = Convert.ToString(value); break;
                    case "MeasureRange" : _MeasureRange = (MerRange)value; break;
                    case "MaxIndication" : _MaxIndication = Convert.ToString(value); break;
                    case "ConnInterface" : _ConnInterface = Convert.ToString(value); break;
                    case "ConversionCoefficient" : _ConversionCoefficient = Convert.ToString(value); break;
                    case "VerificationPeriod" : _VerificationPeriod = Convert.ToString(value); break;
                    case "VerificationDay" : _VerificationDay = Convert.ToDateTime(value); break;
                    case "ExpirationDateF" : _ExpirationDateF = Convert.ToDateTime(value); break;
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
            ///<summary></summary>
            public static readonly Field ID = FindByName("ID");

            ///<summary></summary>
            public static readonly Field Number1 = FindByName("Number1");

            ///<summary></summary>
            public static readonly Field SpotEquipmentNumber = FindByName("SpotEquipmentNumber");

            ///<summary></summary>
            public static readonly Field WMaterNumber = FindByName("WMaterNumber");

            ///<summary></summary>
            public static readonly Field CustNumber = FindByName("CustNumber");

            ///<summary></summary>
            public static readonly Field Brand = FindByName("Brand");

            ///<summary></summary>
            public static readonly Field Caliber = FindByName("Caliber");

            ///<summary></summary>
            public static readonly Field Accuracy = FindByName("Accuracy");

            ///<summary></summary>
            public static readonly Field RangeRatio = FindByName("RangeRatio");

            ///<summary></summary>
            public static readonly Field MeasureRange = FindByName("MeasureRange");

            ///<summary></summary>
            public static readonly Field MaxIndication = FindByName("MaxIndication");

            ///<summary></summary>
            public static readonly Field ConnInterface = FindByName("ConnInterface");

            ///<summary></summary>
            public static readonly Field ConversionCoefficient = FindByName("ConversionCoefficient");

            ///<summary></summary>
            public static readonly Field VerificationPeriod = FindByName("VerificationPeriod");

            ///<summary></summary>
            public static readonly Field VerificationDay = FindByName("VerificationDay");

            ///<summary></summary>
            public static readonly Field ExpirationDateF = FindByName("ExpirationDateF");

            ///<summary></summary>
            public static readonly Field VerificationCertificateNumber = FindByName("VerificationCertificateNumber");

            ///<summary></summary>
            public static readonly Field VerificationConclusion = FindByName("VerificationConclusion");

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IFlowEquipment
    {
        #region 属性
        /// <summary></summary>
        Int32 ID { get; set; }

        /// <summary></summary>
        Int32 Number1 { get; set; }

        /// <summary></summary>
        String SpotEquipmentNumber { get; set; }

        /// <summary></summary>
        String WMaterNumber { get; set; }

        /// <summary></summary>
        String CustNumber { get; set; }

        /// <summary></summary>
        String Brand { get; set; }

        /// <summary></summary>
        String Caliber { get; set; }

        /// <summary></summary>
        NewType Accuracy { get; set; }

        /// <summary></summary>
        String RangeRatio { get; set; }

        /// <summary></summary>
        MerRange MeasureRange { get; set; }

        /// <summary></summary>
        String MaxIndication { get; set; }

        /// <summary></summary>
        String ConnInterface { get; set; }

        /// <summary></summary>
        String ConversionCoefficient { get; set; }

        /// <summary></summary>
        String VerificationPeriod { get; set; }

        /// <summary></summary>
        DateTime VerificationDay { get; set; }

        /// <summary></summary>
        DateTime ExpirationDateF { get; set; }

        /// <summary></summary>
        String VerificationCertificateNumber { get; set; }

        /// <summary></summary>
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