using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewLife.Cube;
using NewLife.Cube.Entity;
using NewLife.Web;

namespace SpotEquipment.NewLife.Web.Areas.SpotArea.Controllers
{
    public class PressEquipmentController : EntityController<PressureEquipment>
    {
        /// <summary>
        /// 
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