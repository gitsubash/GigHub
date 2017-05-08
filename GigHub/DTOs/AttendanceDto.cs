using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigHub.DTOs
{
    //Architectural pattern to send data across processes (using Data Transfer Objects concept)
    //Communicate between two different pieces of code running in server and client
    public class AttendanceDto
    {
        public int GigId { get; set; }
    }
}