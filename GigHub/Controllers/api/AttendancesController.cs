using GigHub.DTOs;
using GigHub.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;

namespace GigHub.Controllers
{
    [Authorize]
    [RoutePrefix("api/attendances")]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        //Web API don't look for scalar parameter from the body, it expects them from the url
        //So, need to decorate our parameter with [FromBody]
        [HttpPost]
        public IHttpActionResult Attend([FromBody] AttendanceDto gigDto)  
        {
            var userId = User.Identity.GetUserId();

            if ( _context.Attendances.Any(a => a.GigId == gigDto.GigId && a.AttendeeId == userId))
            {
                return BadRequest("The Attendance already exists");
            }
            
            var attendance = new Attendance
            {
                GigId = gigDto.GigId,
                AttendeeId = userId
            };
            _context.Attendances.Add(attendance);
            _context.SaveChanges();
            return Ok();
        }
    }
}
