using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Model
{
    /// <summary>阀门设备</summary>
    [Serializable]
    [DataObject]
    [Description("阀门设备")]
    [BindTable("ValveEquipment", Description = "阀门设备", ConnName = "Model", DbType = DatabaseType.SqlServer)]
    public partial class ValveEquipment : IValveEquipment
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

        private String _SpotEquipmentNumber1;
        /// <summary>现场设备编号</summary>
        [DisplayName("现场设备编号")]
        [Description("现场设备编号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("SpotEquipmentNumber1", "现场设备编号", "nchar(10)")]
        public String SpotEquipmentNumber1 { get { return _SpotEquipmentNumber1; } set { if (OnPropertyChanging(__.SpotEquipmentNumber1, value)) { _SpotEquipmentNumber1 = value; OnPropertyChanged(__.SpotEquipmentNumber1); } } }

        private String _MaterialScience;
        /// <summary>材质</summary>
        [DisplayName("材质")]
        [Description("材质")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("MaterialScience", "材质", "nchar(10)")]
        public String MaterialScience { get { return _MaterialScience; } set { if (OnPropertyChanging(__.MaterialScience, value)) { _MaterialScience = value; OnPropertyChanged(__.MaterialScience); } } }

        private Int32 _Type;
        /// <summary>类型</summary>
        [DisplayName("类型")]
        [Description("类型")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Type", "类型", "int")]
        public Int32 Type { get { return _Type; } set { if (OnPropertyChanging(__.Type, value)) { _Type = value; OnPropertyChanged(__.Type); } } }

        private String _Caliber;
        /// <summary>口径</summary>
        [DisplayName("口径")]
        [Description("口径")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("Caliber", "口径", "nchar(10)")]
        public String Caliber { get { return _Caliber; } set { if (OnPropertyChanging(__.Caliber, value)) { _Caliber = value; OnPropertyChanged(__.Caliber); } } }

        private String _Purpose1;
        /// <summary>用途</summary>
        [DisplayName("用途")]
        [Description("用途")]
        [DataObjectField(false, false, true, -1)]
        [BindColumn("Purpose1", "用途", "ntext")]
        public String Purpose1 { get { return _Purpose1; } set { if (OnPropertyChanging(__.Purpose1, value)) { _Purpose1 = value; OnPropertyChanged(__.Purpose1); } } }
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
                    case __.SpotEquipmentNumber1 : return _SpotEquipmentNumber1;
                    case __.MaterialScience : return _MaterialScience;
                    case __.Type : return _Type;
                    case __.Caliber : return _Caliber;
                    case __.Purpose1 : return _Purpose1;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.Number1 : _Number1 = Convert.ToInt32(value); break;
                    case __.SpotEquipmentNumber1 : _SpotEquipmentNumber1 = Convert.ToString(value); break;
                    case __.MaterialScience : _MaterialScience = Convert.ToString(value); break;
                    case __.Type : _Type = Convert.ToInt32(value); break;
                    case __.Caliber : _Caliber = Convert.ToString(value); break;
                    case __.Purpose1 : _Purpose1 = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得阀门设备字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>设备编号</summary>
            public static readonly Field Number1 = FindByName(__.Number1);

            /// <summary>现场设备编号</summary>
            public static readonly Field SpotEquipmentNumber1 = FindByName(__.SpotEquipmentNumber1);

            /// <summary>材质</summary>
            public static readonly Field MaterialScience = FindByName(__.MaterialScience);

            /// <summary>类型</summary>
            public static readonly Field Type = FindByName(__.Type);

            /// <summary>口径</summary>
            public static readonly Field Caliber = FindByName(__.Caliber);

            /// <summary>用途</summary>
            public static readonly Field Purpose1 = FindByName(__.Purpose1);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得阀门设备字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String ID = "ID";

            /// <summary>设备编号</summary>
            public const String Number1 = "Number1";

            /// <summary>现场设备编号</summary>
            public const String SpotEquipmentNumber1 = "SpotEquipmentNumber1";

            /// <summary>材质</summary>
            public const String MaterialScience = "MaterialScience";

            /// <summary>类型</summary>
            public const String Type = "Type";

            /// <summary>口径</summary>
            public const String Caliber = "Caliber";

            /// <summary>用途</summary>
            public const String Purpose1 = "Purpose1";
        }
        #endregion
    }

    /// <summary>阀门设备接口</summary>
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
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}