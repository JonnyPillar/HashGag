using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using HashGagAPI.Models;

namespace HashGagAPI.Controllers
{
    public class TwitterUserController : ApiController
    {
        private hashGagEntities db = new hashGagEntities();

        // GET api/TwitterUser
        public IQueryable<TwitterUser> GetTwitterUsers()
        {
            return db.TwitterUsers;
        }

        // GET api/TwitterUser/5
        [ResponseType(typeof(TwitterUser))]
        public IHttpActionResult GetTwitterUser(int id)
        {
            TwitterUser twitteruser = db.TwitterUsers.Find(id);
            if (twitteruser == null)
            {
                return NotFound();
            }

            return Ok(twitteruser);
        }

        // PUT api/TwitterUser/5
        public IHttpActionResult PutTwitterUser(int id, TwitterUser twitteruser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != twitteruser.HashgagUserID)
            {
                return BadRequest();
            }

            db.Entry(twitteruser).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TwitterUserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/TwitterUser
        [ResponseType(typeof(TwitterUser))]
        public IHttpActionResult PostTwitterUser(TwitterUser twitteruser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TwitterUsers.Add(twitteruser);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = twitteruser.HashgagUserID }, twitteruser);
        }

        // DELETE api/TwitterUser/5
        [ResponseType(typeof(TwitterUser))]
        public IHttpActionResult DeleteTwitterUser(int id)
        {
            TwitterUser twitteruser = db.TwitterUsers.Find(id);
            if (twitteruser == null)
            {
                return NotFound();
            }

            db.TwitterUsers.Remove(twitteruser);
            db.SaveChanges();

            return Ok(twitteruser);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TwitterUserExists(int id)
        {
            return db.TwitterUsers.Count(e => e.HashgagUserID == id) > 0;
        }
    }
}