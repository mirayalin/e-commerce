using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIBanka.Controllers
{
    using Models;
    using SingletonPattern;
    using ViewModel;
    public class PaymentController : ApiController
    {
        BankaDBEntities db = DBTool.DBInstance;

        [HttpPost]
        public IHttpActionResult ReceivePayment(PaymentVM item)
        {
            if (db.CardInfoes.Any(x=>x.CardNumber==item.Number))
            {
                CardInfo ci = db.CardInfoes.Where(x => x.CardNumber == item.Number).Single();
                if (ci.CardUserName==item.UserName&&ci.CardExpiryMonth==item.ExpiryMonth&&ci.CardExpiryYear==item.ExpiryYear)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest("Not Valid");
                }
            }
            else
            {
                return BadRequest("Wrong Info");
            }
        }
    }
}
