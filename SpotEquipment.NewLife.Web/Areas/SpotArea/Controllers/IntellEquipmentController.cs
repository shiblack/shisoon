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
    public class IntellEquipmentController : EntityController<IntelligentTerminal>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public ActionResult GetSpotEdit(Int32 fid)
        {

            var s = IntelligentTerminal.Myss(fid);
            Session.Abandon();
            return RedirectToAction("/Edit/" + s.ToString(), "SpotEuipment");
        }

    }
}