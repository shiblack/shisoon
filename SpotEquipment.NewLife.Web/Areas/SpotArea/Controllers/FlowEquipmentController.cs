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
using XCode;
using System.IO;

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


        //protected override IEnumerable<FlowEquipment> Search(Pager p)
        //{
        //    var classid = p["Number1"].ToInt();
        //    return FlowEquipment.Search(p["q"], "ID", 0, 1);
        //}
        

        
        public ActionResult GetSpotEdit(Int32 fid) 
        {
            
            var s = FlowEquipment.Myss(fid);
            Session.Abandon();
            return RedirectToAction("/Edit/"+s.ToString(), "SpotEuipment");
        }
        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            ViewBag.Recount = "/FlowEquipment/Upload";
            if (file != null)
            {
                string fileName = Path.GetFileName(file.FileName);
                string path = Server.MapPath(string.Format("~/{0}", "Resouce"));
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                file.SaveAs(Path.Combine(path, fileName));
            }
            return View();
        }
    }
}