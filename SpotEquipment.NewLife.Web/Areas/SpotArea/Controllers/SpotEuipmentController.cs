using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewLife.Cube;
using NewLife.Cube.Entity;
using NewLife.Web;

namespace SpotEquipment.NewLife.Web.Areas.SpotArea.Controllers
{
    public class SpotEuipmentController : EntityController<SpotEuipments>
    {
        public override ActionResult Delete(Int32 id)
        {
            //return base.Delete(id);
            throw new Exception("不允许删除");
        }

    }
}