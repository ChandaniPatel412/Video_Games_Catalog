using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Hosting;
using System.Web.Http;

namespace Video_Games_Catalog.Controllers
{
    public class FileController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post()
        {
            int iUploadedCnt = 0;
            string sPath = "";
            sPath = System.Web.Hosting.HostingEnvironment.MapPath("~/Images/");

            System.Web.HttpFileCollection hfc = System.Web.HttpContext.Current.Request.Files;
            
            for (int iCnt = 0; iCnt <= hfc.Count - 1; iCnt++)
            {
                System.Web.HttpPostedFile hpf = hfc[iCnt];

                if (hpf.ContentLength > 0)
                {
                    if (!File.Exists(sPath + Path.GetFileName(hpf.FileName)))
                    {
                        hpf.SaveAs(sPath + Path.GetFileName(hpf.FileName));
                        iUploadedCnt = iUploadedCnt + 1;
                    }
                }
            }
            
            if (iUploadedCnt > 0)
            {
                return Ok(hfc[0].FileName);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
