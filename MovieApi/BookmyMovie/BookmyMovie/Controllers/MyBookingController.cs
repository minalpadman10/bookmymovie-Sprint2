using BookmyMovie.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookmyMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyBookingController : ControllerBase
    {
        mymovieDBContext db;
        public MyBookingController(mymovieDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<FinalBooking> GetMyBookings (string username)
        {
            return db.FinalBookings.Where(x => x.UserName == username).ToList();
        }
        [HttpPost]
        public String post([FromBody] MyBooking tp)
        {
            db.MyBookings.Add(tp);
            db.SaveChanges();
            return "success";
        }
    }
}
