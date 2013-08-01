using Legal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebMatrix.WebData;
using WebMatrix.Data;

namespace Legal.Controllers
{
    public class ReferensiController : Controller
    {
        public LegalMailerContext db { get; set; }
        protected override void Initialize(RequestContext requestContext)
        {
            if (db == null) { db = new LegalMailerContext(); }

            base.Initialize(requestContext);
        }
        //
        // GET: /Referensi/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ListCabang()
        {
            using (var db = Database.Open("DBNASContext"))
            {
                IEnumerable<dynamic> ListKC = null;
                string kdkc = string.Empty;
                using (ESKAPEDEContext db2 = new ESKAPEDEContext())
                {
                    var UserBranch = db2.vwUserProfiles.Where(a => a.Username == User.Identity.Name).Select(a => a.CountryID).SingleOrDefault();
                    switch (UserBranch)
                    {
                        case 1:
                            kdkc = "x";
                            break;
                        case 2:
                            kdkc = "0201";
                            break;
                        case 3:
                            kdkc = "0401";
                            break;
                        case 4:
                            kdkc = "0601";
                            break;
                        case 5:
                            kdkc = "0901";
                            break;
                        case 6:
                            kdkc = "0902";
                            break;
                        case 7:
                            kdkc = "1001";
                            break;
                        case 8:
                            kdkc = "1101";
                            break;
                        case 9:
                            kdkc = "1301";
                            break;
                        case 10:
                            kdkc = "1602";
                            break;
                        case 11:
                            kdkc = "1801";
                            break;
                        case 12:
                            kdkc = "2101";
                            break;
                        case 13:
                            kdkc = "2201";
                            break;
                    }
                }
                if (kdkc != "x") 
                { 
                    ListKC = db.Query(string.Format("SELECT KDKC,NMKC FROM REFKC WHERE KDKC={0}",kdkc));
                }
                else 
                { 
                    ListKC = db.Query("SELECT KDKC,NMKC FROM REFKC");
                }
                var ListCabang = (from xcabang in ListKC
                                  select new
                                  {
                                      KDKC = xcabang.KDKC,
                                      NMKC = xcabang.NMKC
                                  });
                return Json(ListCabang, JsonRequestBehavior.AllowGet);
                
            }
        }

        public JsonResult Tahun()
        {
            using (var db = Database.Open("DBNASContext"))
            {
                var x = db.Query("SELECT KDKC,NMKC FROM REFKC");
                //var x = db.QueryValue("SELECT KDKC,NMKC FROM REFKC");
                var ListCabang = (from xcabang in x
                                  select new
                                  {
                                      KDKC = xcabang.KDKC,
                                      NMKC = xcabang.NMKC
                                  });
                return Json(ListCabang, JsonRequestBehavior.AllowGet);
            }
        }

        public class BRANCH
        {
            public string KDKC {get; set;}
            public string NMKC { get; set; }
        }

    }
}
