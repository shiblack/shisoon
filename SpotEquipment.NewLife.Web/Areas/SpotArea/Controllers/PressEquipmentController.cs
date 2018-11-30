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
        /// 

        public ActionResult GetSpotEdit(Int32 fid)
        {

            var s = PressureEquipment.Myss(fid);
            Session.Abandon();
            return RedirectToAction("/Edit/" + s.ToString(), "SpotEuipment");
        }
    }
}