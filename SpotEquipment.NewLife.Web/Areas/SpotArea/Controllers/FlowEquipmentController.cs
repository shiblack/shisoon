using NewLife.Cube;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewLife.Cube.Entity;
using NewLife.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace SpotEquipment.NewLife.Web.Areas.SpotArea.Controllers
{

    public class FlowEquipmentController : EntityController<FlowEquipment>
    {
        /// GET: SpotArea/Equipment

        //static FlowEquipmentController()
        //{
        //    ListFields.RemoveField("CreateUserID");
        //    ListFields.RemoveField("UpdateUserID");
        //}
        //protected override FlowEquipment Find(Object key)
        //{
        //    return base.Find(key);
        //}
        
        protected override IEnumerable<FlowEquipment> Search(Pager p)
        {
            var classid = p["Number1"].ToInt();
            return FlowEquipment.Search(p["q"], "ID", 0, 1);
        }
        /// <summary>
        /// 查找现场设备id
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int foundid(int number)
        {
            string cnstr = ConfigurationManager.ConnectionStrings["Membership"].ConnectionString; ;
            int i = 0;
            using (SqlConnection cn = new SqlConnection(cnstr))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                //必须使用@参数
                cmd.CommandText = "select ID from SpotEuipments where Number=@number";
                cmd.Parameters.AddWithValue("@number", number);

                i = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return i;
        }
    }
}