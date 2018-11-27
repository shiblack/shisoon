using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentManager
{
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
        未知设备,
        //
        智能终端,
        //
        流量设备,
        //
        压力设备,
        //
        水质设备,
        //
        阀门设备,
        //
        高频设备
    }
    public enum NewPurpose
    {
        //设备用途
        官网检测,
        //
        计量分区,
        //
        大表用户,
        //
        二次供水,
        //
        阀门控制
    }
    public enum EState
    {
        //设备状态
        待装,
        //
        运行,
        //
        待检,
        //
        检定,
        //
        报废

    }
    public enum PowerMode
    {
        //供电方式
        未定义,
        //
        市电,
        //
        太阳能,
        //
        锂电池
    }
    public enum ComMode
    { 
        //通讯方式
        //
        _4G,
        //
        NB,
        //
        Lora,
        //
        WiFi,
        //
        BlueTooth,
        //
        GPRS

    }
    public enum MerRange
    {
        //测量范围
        Q1,
        //
        Q2,
        //
        Q3,
        //
        Q4

    }
    public enum ValueType
    {
        //阀门类型
        闸阀,
        //
        蝶阀,
        //
        球阀
    }
}
