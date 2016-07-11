using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Trajectus.Models;

namespace Trajectus.Controllers
{
    public class PathsController : ApiController
    {
        private Db db = new Db();

        // GET: api/Paths
        public IQueryable<Path> GetPaths()
        {
            return db.Paths;
        }

        // GET: api/Paths/5
        [ResponseType(typeof(Path))]
        public async Task<IHttpActionResult> GetPath(int id)
        {
            Path path = await db.Paths.FindAsync(id);
            if (path == null)
            {
                return NotFound();
            }

            return Ok(path);
        }

        // PUT: api/Paths/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPath(int id, Path path)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != path.PathID)
            {
                return BadRequest();
            }

            db.Entry(path).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PathExists(id))
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

        // POST: api/Paths
        [ResponseType(typeof(Path))]
        public async Task<IHttpActionResult> PostPath(Path path)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Paths.Add(path);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = path.PathID }, path);
        }

        // DELETE: api/Paths/5
        [ResponseType(typeof(Path))]
        public async Task<IHttpActionResult> DeletePath(int id)
        {
            Path path = await db.Paths.FindAsync(id);
            if (path == null)
            {
                return NotFound();
            }

            db.Paths.Remove(path);
            await db.SaveChangesAsync();

            return Ok(path);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PathExists(int id)
        {
            return db.Paths.Count(e => e.PathID == id) > 0;
        }
    }
}