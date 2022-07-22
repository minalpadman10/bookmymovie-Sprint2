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
    public class MovieController : ControllerBase
    {
        mymovieDBContext db;
        public MovieController(mymovieDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<AddMovie> GetAddMovies()
        {
            return db.AddMovies;
        }
    }
}
