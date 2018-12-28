using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Model
{
    /// <summary>流量设备</summary>
    [Serializable]
    [DataObject]
    [Description("流量设备")]
    [BindTable("FlowEquipment", Description = "流量设备", ConnName = "Model", DbType = DatabaseType.SqlServer)]
    public partial class FlowEquipment : IFlowEquipment
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
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Number1", "设备编号", "int")]
        public Int32 Number1 { get { return _Number1; } set { if (OnPropertyChanging(__.Number1, value)) { _Number1 = value; OnPropertyChanged(__.Number1); } } }

        private String _SpotEquipmentNumber;
        /// <summary>现场设备编号</summary>
        [DisplayName("现场设备编号")]
        [Description("现场设备编号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("SpotEquipmentNumber", "现场设备编号", "nchar(10)")]
        public String SpotEquipmentNumber { get { return _SpotEquipmentNumber; } set { if (OnPropertyChanging(__.SpotEquipmentNumber, value)) { _SpotEquipmentNumber = value; OnPropertyChanged(__.SpotEquipmentNumber); } } }

        private String _WMaterNumber;
        /// <summary>水表编号</summary>
        [DisplayName("水表编号")]
        [Description("水表编号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("WMaterNumber", "水表编号", "nchar(10)")]
        public String WMaterNumber { get { return _WMaterNumber; } set { if (OnPropertyChanging(__.WMaterNumber, value)) { _WMaterNumber = value; OnPropertyChanged(__.WMaterNumber); } } }

        private String _CustNumber;
        /// <summary>客户编号</summary>
        [DisplayName("客户编号")]
        [Description("客户编号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("CustNumber", "客户编号", "nchar(10)")]
        public String CustNumber { get { return _CustNumber; } set { if (OnPropertyChanging(__.CustNumber, value)) { _CustNumber = value; OnPropertyChanged(__.CustNumber); } } }

        private String _Brand;
        /// <summary>品牌</summary>
        [DisplayName("品牌")]
        [Description("品牌")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn("Brand", "品牌", "nchar(20)")]
        public String Brand { get { return _Brand; } set { if (OnPropertyChanging(__.Brand, value)) { _Brand = value; OnPropertyChanged(__.Brand); } } }

        private String _Caliber;
        /// <summary>口径</summary>
        [DisplayName("口径")]
        [Description("口径")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("Caliber", "口径", "nchar(10)")]
        public String Caliber { get { return _Caliber; } set { if (OnPropertyChanging(__.Caliber, value)) { _Caliber = value; OnPropertyChanged(__.Caliber); } } }

        private Int32 _Accuracy;
        /// <summary>精度</summary>
        [DisplayName("精度")]
        [Description("精度")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Accuracy", "精度", "int")]
        public Int32 Accuracy { get { return _Accuracy; } set { if (OnPropertyChanging(__.Accuracy, value)) { _Accuracy = value; OnPropertyChanged(__.Accuracy); } } }

        private String _RangeRatio;
        /// <summary>量程比</summary>
        [DisplayName("量程比")]
        [Description("量程比")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("RangeRatio", "量程比", "nchar(10)")]
        public String RangeRatio { get { return _RangeRatio; } set { if (OnPropertyChanging(__.RangeRatio, value)) { _RangeRatio = value; OnPropertyChanged(__.RangeRatio); } } }

        private Int32 _MeasureRange;
        /// <summary>测量范围</summary>
        [DisplayName("测量范围")]
        [Description("测量范围")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("MeasureRange", "测量范围", "int")]
        public Int32 MeasureRange { get { return _MeasureRange; } set { if (OnPropertyChanging(__.MeasureRange, value)) { _MeasureRange = value; OnPropertyChanged(__.MeasureRange); } } }

        private String _MaxIndication;
        /// <summary>最大示值</summary>
        [DisplayName("最大示值")]
        [Description("最大示值")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("MaxIndication", "最大示值", "nchar(10)")]
        public String MaxIndication { get { return _MaxIndication; } set { if (OnPropertyChanging(__.MaxIndication, value)) { _MaxIndication = value; OnPropertyChanged(__.MaxIndication); } } }

        private String _ConnInterface;
        /// <summary>通讯接口</summary>
        [DisplayName("通讯接口")]
        [Description("通讯接口")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("ConnInterface", "通讯接口", "nchar(10)")]
        public String ConnInterface { get { return _ConnInterface; } set { if (OnPropertyChanging(__.ConnInterface, value)) { _ConnInterface = value; OnPropertyChanged(__.ConnInterface); } } }

        private String _ConversionCoefficient;
        /// <summary>转换系数</summary>
        [DisplayName("转换系数")]
        [Description("转换系数")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("ConversionCoefficient", "转换系数", "nchar(10)")]
        public String ConversionCoefficient { get { return _ConversionCoefficient; } set { if (OnPropertyChanging(__.ConversionCoefficient, value)) { _ConversionCoefficient = value; OnPropertyChanged(__.ConversionCoefficient); } } }

        private String _VerificationPeriod;
        /// <summary>检定周期（年）</summary>
        [DisplayName("检定周期")]
        [Description("检定周期（年）")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("VerificationPeriod", "检定周期（年）", "nchar(10)")]
        public String VerificationPeriod { get { return _VerificationPeriod; } set { if (OnPropertyChanging(__.VerificationPeriod, value)) { _VerificationPeriod = value; OnPropertyChanged(__.VerificationPeriod); } } }

        private DateTime _VerificationDay;
        /// <summary>检定周期</summary>
        [DisplayName("检定周期")]
        [Description("检定周期")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("VerificationDay", "检定周期", "smalldatetime")]
        public DateTime VerificationDay { get { return _VerificationDay; } set { if (OnPropertyChanging(__.VerificationDay, value)) { _VerificationDay = value; OnPropertyChanged(__.VerificationDay); } } }

        private DateTime _ExpirationDateF;
        /// <summary>有效期限</summary>
        [DisplayName("有效期限")]
        [Description("有效期限")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("ExpirationDateF", "有效期限", "smalldatetime")]
        public DateTime ExpirationDateF { get { return _ExpirationDateF; } set { if (OnPropertyChanging(__.ExpirationDateF, value)) { _ExpirationDateF = value; OnPropertyChanged(__.ExpirationDateF); } } }

        private String _VerificationCertificateNumber;
        /// <summary>鉴定证书编号</summary>
        [DisplayName("鉴定证书编号")]
        [Description("鉴定证书编号")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn("VerificationCertificateNumber", "鉴定证书编号", "nchar(20)")]
        public String VerificationCertificateNumber { get { return _VerificationCertificateNumber; } set { if (OnPropertyChanging(__.VerificationCertificateNumber, value)) { _VerificationCertificateNumber = value; OnPropertyChanged(__.VerificationCertificateNumber); } } }

        private String _VerificationConclusion;
        /// <summary>检定结论</summary>
        [DisplayName("检定结论")]
        [Description("检定结论")]
        [DataObjectField(false, false, true, -1)]
        [BindColumn("VerificationConclusion", "检定结论", "ntext")]
        public String VerificationConclusion { get { return _VerificationConclusion; } set { if (OnPropertyChanging(__.VerificationConclusion, value)) { _VerificationConclusion = value; OnPropertyChanged(__.VerificationConclusion); } } }
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
                    case __.WMaterNumber : return _WMaterNumber;
                    case __.CustNumber : return _CustNumber;
                    case __.Brand : return _Brand;
                    case __.Caliber : return _Caliber;
                    case __.Accuracy : return _Accuracy;
                    case __.RangeRatio : return _RangeRatio;
                    case __.MeasureRange : return _MeasureRange;
                    case __.MaxIndication : return _MaxIndication;
                    case __.ConnInterface : return _ConnInterface;
                    case __.ConversionCoefficient : return _ConversionCoefficient;
                    case __.VerificationPeriod : return _VerificationPeriod;
                    case __.VerificationDay : return _VerificationDay;
                    case __.ExpirationDateF : return _ExpirationDateF;
                    case __.VerificationCertificateNumber : return _VerificationCertificateNumber;
                    case __.VerificationConclusion : return _VerificationConclusion;
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
                    case __.WMaterNumber : _WMaterNumber = Convert.ToString(value); break;
                    case __.CustNumber : _CustNumber = Convert.ToString(value); break;
                    case __.Brand : _Brand = Convert.ToString(value); break;
                    case __.Caliber : _Caliber = Convert.ToString(value); break;
                    case __.Accuracy : _Accuracy = Convert.ToInt32(value); break;
                    case __.RangeRatio : _RangeRatio = Convert.ToString(value); break;
                    case __.MeasureRange : _MeasureRange = Convert.ToInt32(value); break;
                    case __.MaxIndication : _MaxIndication = Convert.ToString(value); break;
                    case __.ConnInterface : _ConnInterface = Convert.ToString(value); break;
                    case __.ConversionCoefficient : _ConversionCoefficient = Convert.ToString(value); break;
                    case __.VerificationPeriod : _VerificationPeriod = Convert.ToString(value); break;
                    case __.VerificationDay : _VerificationDay = Convert.ToDateTime(value); break;
                    case __.ExpirationDateF : _ExpirationDateF = Convert.ToDateTime(value); break;
                    case __.VerificationCertificateNumber : _VerificationCertificateNumber = Convert.ToString(value); break;
                    case __.VerificationConclusion : _VerificationConclusion = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得流量设备字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>设备编号</summary>
            public static readonly Field Number1 = FindByName(__.Number1);

            /// <summary>现场设备编号</summary>
            public static readonly Field SpotEquipmentNumber = FindByName(__.SpotEquipmentNumber);

            /// <summary>水表编号</summary>
            public static readonly Field WMaterNumber = FindByName(__.WMaterNumber);

            /// <summary>客户编号</summary>
            public static readonly Field CustNumber = FindByName(__.CustNumber);

            /// <summary>品牌</summary>
            public static readonly Field Brand = FindByName(__.Brand);

            /// <summary>口径</summary>
            public static readonly Field Caliber = FindByName(__.Caliber);

            /// <summary>精度</summary>
            public static readonly Field Accuracy = FindByName(__.Accuracy);

            /// <summary>量程比</summary>
            public static readonly Field RangeRatio = FindByName(__.RangeRatio);

            /// <summary>测量范围</summary>
            public static readonly Field MeasureRange = FindByName(__.MeasureRange);

            /// <summary>最大示值</summary>
            public static readonly Field MaxIndication = FindByName(__.MaxIndication);

            /// <summary>通讯接口</summary>
            public static readonly Field ConnInterface = FindByName(__.ConnInterface);

            /// <summary>转换系数</summary>
            public static readonly Field ConversionCoefficient = FindByName(__.ConversionCoefficient);

            /// <summary>检定周期（年）</summary>
            public static readonly Field VerificationPeriod = FindByName(__.VerificationPeriod);

            /// <summary>检定周期</summary>
            public static readonly Field VerificationDay = FindByName(__.VerificationDay);

            /// <summary>有效期限</summary>
            public static readonly Field ExpirationDateF = FindByName(__.ExpirationDateF);

            /// <summary>鉴定证书编号</summary>
            public static readonly Field VerificationCertificateNumber = FindByName(__.VerificationCertificateNumber);

            /// <summary>检定结论</summary>
            public static readonly Field VerificationConclusion = FindByName(__.VerificationConclusion);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得流量设备字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String ID = "ID";

            /// <summary>设备编号</summary>
            public const String Number1 = "Number1";

            /// <summary>现场设备编号</summary>
            public const String SpotEquipmentNumber = "SpotEquipmentNumber";

            /// <summary>水表编号</summary>
            public const String WMaterNumber = "WMaterNumber";

            /// <summary>客户编号</summary>
            public const String CustNumber = "CustNumber";

            /// <summary>品牌</summary>
            public const String Brand = "Brand";

            /// <summary>口径</summary>
            public const String Caliber = "Caliber";

            /// <summary>精度</summary>
            public const String Accuracy = "Accuracy";

            /// <summary>量程比</summary>
            public const String RangeRatio = "RangeRatio";

            /// <summary>测量范围</summary>
            public const String MeasureRange = "MeasureRange";

            /// <summary>最大示值</summary>
            public const String MaxIndication = "MaxIndication";

            /// <summary>通讯接口</summary>
            public const String ConnInterface = "ConnInterface";

            /// <summary>转换系数</summary>
            public const String ConversionCoefficient = "ConversionCoefficient";

            /// <summary>检定周期（年）</summary>
            public const String VerificationPeriod = "VerificationPeriod";

            /// <summary>检定周期</summary>
            public const String VerificationDay = "VerificationDay";

            /// <summary>有效期限</summary>
            public const String ExpirationDateF = "ExpirationDateF";

            /// <summary>鉴定证书编号</summary>
            public const String VerificationCertificateNumber = "VerificationCertificateNumber";

            /// <summary>检定结论</summary>
            public const String VerificationConclusion = "VerificationConclusion";
        }
        #endregion
    }

    /// <summary>流量设备接口</summary>
    public partial interface IFlowEquipment
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 ID { get; set; }

        /// <summary>设备编号</summary>
        Int32 Number1 { get; set; }

        /// <summary>现场设备编号</summary>
        String SpotEquipmentNumber { get; set; }

        /// <summary>水表编号</summary>
        String WMaterNumber { get; set; }

        /// <summary>客户编号</summary>
        String CustNumber { get; set; }

        /// <summary>品牌</summary>
        String Brand { get; set; }

        /// <summary>口径</summary>
        String Caliber { get; set; }

        /// <summary>精度</summary>
        Int32 Accuracy { get; set; }

        /// <summary>量程比</summary>
        String RangeRatio { get; set; }

        /// <summary>测量范围</summary>
        Int32 MeasureRange { get; set; }

        /// <summary>最大示值</summary>
        String MaxIndication { get; set; }

        /// <summary>通讯接口</summary>
        String ConnInterface { get; set; }

        /// <summary>转换系数</summary>
        String ConversionCoefficient { get; set; }

        /// <summary>检定周期（年）</summary>
        String VerificationPeriod { get; set; }

        /// <summary>检定周期</summary>
        DateTime VerificationDay { get; set; }

        /// <summary>有效期限</summary>
        DateTime ExpirationDateF { get; set; }

        /// <summary>鉴定证书编号</summary>
        String VerificationCertificateNumber { get; set; }

        /// <summary>检定结论</summary>
        String VerificationConclusion { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}