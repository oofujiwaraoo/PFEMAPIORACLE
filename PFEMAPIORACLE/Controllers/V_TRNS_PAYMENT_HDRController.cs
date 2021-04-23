using PFEMAPIORACLE.Data;
using PFEMAPIORACLE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PFEMAPIORACLE.Controllers
{
    public class V_TRNS_PAYMENT_HDRController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpPost]

        public IQueryable<V_TRNS_PAYMENT_HDR> V_TRNS_PAYMENT_HDR(Request req)
        {
            //db = new ApplicationDbContext("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=10.22.252.201)(PORT=1521))(CONNECT_DATA=(SID=interfac)(SERVER = DEDICATED)));User Id=cisconnect;Password=cisRW");


            return db.V_TRNS_PAYMENT_HDR
                .Where(b => b.YYYY == req.YYYY && b.MM == req.MM && b.HOS_CODE == req.HOS_CODE);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
