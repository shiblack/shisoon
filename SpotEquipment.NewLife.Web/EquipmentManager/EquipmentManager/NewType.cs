using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentManager
{
    /// <summary>
    /// 枚举类
    /// </summary>
    public enum NewType
    {
        //计量精度等级
        A级=0,
        //
        B级=1,
        //
        C级=2,
        //
        D级=3
    }
    public enum EType
    {
        //设备类型
        未知设备=0,
        //
        智能终端=1,
        //
        流量设备=2,
        //
        压力设备=3,
        //
        水质设备=4,
        //
        阀门设备=5,
        //
        高频设备=6
    }
    public enum NewPurpose
    {
        //设备用途
        官网检测=0,
        //
        计量分区=1,
        //
        大表用户=2,
        //
        二次供水=3,
        //
        阀门控制=4
    }
    public enum EState
    {
        //设备状态
        待装=0,
        //
        运行=1,
        //
        待检=2,
        //
        检定=3,
        //
        报废=4

    }
    public enum PowerMode
    {
        //供电方式
        未定义=0,
        //
        市电=1,
        //
        太阳能=2,
        //
        锂电池=3
    }
    public enum ComMode
    { 
        //通讯方式
        //
        _4G=0,
        //
        NB=1,
        //
        Lora=2,
        //
        WiFi=3,
        //
        BlueTooth=4,
        //
        GPRS=5

    }
    public enum MerRange
    {
        //测量范围
        Q1=0,
        //
        Q2=1,
        //
        Q3=2,
        //
        Q4=3

    }
    public enum VType
    {
        //阀门类型
        闸阀=0,
        //
        蝶阀=1,
        //
        球阀=2
    }
}
