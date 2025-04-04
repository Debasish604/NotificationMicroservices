﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NotificatonServices.Controllers
{
    [Route("api/[controller]/Notification")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        // GET: api/<NotificationController>
        [HttpPost]
        [Route("SendNotification")]
        public IEnumerable<string> SendNotificationToJobCreator()
        {
            return new string[] { "value1", "value2" };
        }

        //// GET api/<NotificationController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<NotificationController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<NotificationController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<NotificationController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
