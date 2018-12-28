using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Model
{
    /// <summary>压力设备</summary>
    [Serializable]
    [DataObject]
    [Description("压力设备")]
    [BindTable("PressureEquipment", Description = "压力设备", ConnName = "Model", DbType = DatabaseType.SqlServer)]
    public partial class PressureEquipment : IPressureEquipment
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

        private String _PrecisionGrade;
        /// <summary>精度等级</summary>
        [DisplayName("精度等级")]
        [Description("精度等级")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("PrecisionGrade", "精度等级", "nchar(10)")]
        public String PrecisionGrade { get { return _PrecisionGrade; } set { if (OnPropertyChanging(__.PrecisionGrade, value)) { _PrecisionGrade = value; OnPropertyChanged(__.PrecisionGrade); } } }

        private String _RangeMin;
        /// <summary>量程下限</summary>
        [DisplayName("量程下限")]
        [Description("量程下限")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("RangeMin", "量程下限", "nchar(10)")]
        public String RangeMin { get { return _RangeMin; } set { if (OnPropertyChanging(__.RangeMin, value)) { _RangeMin = value; OnPropertyChanged(__.RangeMin); } } }

        private String _RangeMax;
        /// <summary>量程上限</summary>
        [DisplayName("量程上限")]
        [Description("量程上限")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("RangeMax", "量程上限", "nchar(10)")]
        public String RangeMax { get { return _RangeMax; } set { if (OnPropertyChanging(__.RangeMax, value)) { _RangeMax = value; OnPropertyChanged(__.RangeMax); } } }

        private String _VerificationPeriod;
        /// <summary>检定周期(年)</summary>
        [DisplayName("检定周期")]
        [Description("检定周期(年)")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("VerificationPeriod", "检定周期(年)", "nchar(10)")]
        public String VerificationPeriod { get { return _VerificationPeriod; } set { if (OnPropertyChanging(__.VerificationPeriod, value)) { _VerificationPeriod = value; OnPropertyChanged(__.VerificationPeriod); } } }

        private DateTime _VerificationDay;
        /// <summary>检定日期</summary>
        [DisplayName("检定日期")]
        [Description("检定日期")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("VerificationDay", "检定日期", "smalldatetime")]
        public DateTime VerificationDay { get { return _VerificationDay; } set { if (OnPropertyChanging(__.VerificationDay, value)) { _VerificationDay = value; OnPropertyChanged(__.VerificationDay); } } }

        private DateTime _ExpirationDate;
        /// <summary>有效期限</summary>
        [DisplayName("有效期限")]
        [Description("有效期限")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("ExpirationDate", "有效期限", "smalldatetime")]
        public DateTime ExpirationDate { get { return _ExpirationDate; } set { if (OnPropertyChanging(__.ExpirationDate, value)) { _ExpirationDate = value; OnPropertyChanged(__.ExpirationDate); } } }

        private String _VerificationCertificateNumber;
        /// <summary>检定证书编号</summary>
        [DisplayName("检定证书编号")]
        [Description("检定证书编号")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn("VerificationCertificateNumber", "检定证书编号", "nchar(20)")]
        public String VerificationCertificateNumber { get { return _VerificationCertificateNumber; } set { if (OnPropertyChanging(__.VerificationCertificateNumber, value)) { _VerificationCertificateNumber = value; OnPropertyChanged(__.VerificationCertificateNumber); } } }

        private String _VerificationConclusion;
        /// <summary>检定结论</summary>
        [DisplayName("检定结论")]
        [Description("检定结论")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("VerificationConclusion", "检定结论", "nchar(10)")]
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
                    case __.PrecisionGrade : return _PrecisionGrade;
                    case __.RangeMin : return _RangeMin;
                    case __.RangeMax : return _RangeMax;
                    case __.VerificationPeriod : return _VerificationPeriod;
                    case __.VerificationDay : return _VerificationDay;
                    case __.ExpirationDate : return _ExpirationDate;
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
                    case __.PrecisionGrade : _PrecisionGrade = Convert.ToString(value); break;
                    case __.RangeMin : _RangeMin = Convert.ToString(value); break;
                    case __.RangeMax : _RangeMax = Convert.ToString(value); break;
                    case __.VerificationPeriod : _VerificationPeriod = Convert.ToString(value); break;
                    case __.VerificationDay : _VerificationDay = Convert.ToDateTime(value); break;
                    case __.ExpirationDate : _ExpirationDate = Convert.ToDateTime(value); break;
                    case __.VerificationCertificateNumber : _VerificationCertificateNumber = Convert.ToString(value); break;
                    case __.VerificationConclusion : _VerificationConclusion = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得压力设备字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>设备编号</summary>
            public static readonly Field Number1 = FindByName(__.Number1);

            /// <summary>现场设备编号</summary>
            public static readonly Field SpotEquipmentNumber = FindByName(__.SpotEquipmentNumber);

            /// <summary>精度等级</summary>
            public static readonly Field PrecisionGrade = FindByName(__.PrecisionGrade);

            /// <summary>量程下限</summary>
            public static readonly Field RangeMin = FindByName(__.RangeMin);

            /// <summary>量程上限</summary>
            public static readonly Field RangeMax = FindByName(__.RangeMax);

            /// <summary>检定周期(年)</summary>
            public static readonly Field VerificationPeriod = FindByName(__.VerificationPeriod);

            /// <summary>检定日期</summary>
            public static readonly Field VerificationDay = FindByName(__.VerificationDay);

            /// <summary>有效期限</summary>
            public static readonly Field ExpirationDate = FindByName(__.ExpirationDate);

            /// <summary>检定证书编号</summary>
            public static readonly Field VerificationCertificateNumber = FindByName(__.VerificationCertificateNumber);

            /// <summary>检定结论</summary>
            public static readonly Field VerificationConclusion = FindByName(__.VerificationConclusion);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得压力设备字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String ID = "ID";

            /// <summary>设备编号</summary>
            public const String Number1 = "Number1";

            /// <summary>现场设备编号</summary>
            public const String SpotEquipmentNumber = "SpotEquipmentNumber";

            /// <summary>精度等级</summary>
            public const String PrecisionGrade = "PrecisionGrade";

            /// <summary>量程下限</summary>
            public const String RangeMin = "RangeMin";

            /// <summary>量程上限</summary>
            public const String RangeMax = "RangeMax";

            /// <summary>检定周期(年)</summary>
            public const String VerificationPeriod = "VerificationPeriod";

            /// <summary>检定日期</summary>
            public const String VerificationDay = "VerificationDay";

            /// <summary>有效期限</summary>
            public const String ExpirationDate = "ExpirationDate";

            /// <summary>检定证书编号</summary>
            public const String VerificationCertificateNumber = "VerificationCertificateNumber";

            /// <summary>检定结论</summary>
            public const String VerificationConclusion = "VerificationConclusion";
        }
        #endregion
    }

    /// <summary>压力设备接口</summary>
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
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}