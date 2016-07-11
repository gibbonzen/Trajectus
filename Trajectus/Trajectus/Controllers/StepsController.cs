﻿using System;
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
    public class StepsController : ApiController
    {
        private Db db = new Db();

        // GET: api/Steps
        public IQueryable<Step> GetSteps()
        {
            return db.Steps;
        }

        // GET: api/Steps/5
        [ResponseType(typeof(Step))]
        public async Task<IHttpActionResult> GetStep(int id)
        {
            Step step = await db.Steps.FindAsync(id);
            if (step == null)
            {
                return NotFound();
            }

            return Ok(step);
        }

        // PUT: api/Steps/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutStep(int id, Step step)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != step.StepID)
            {
                return BadRequest();
            }

            db.Entry(step).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StepExists(id))
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

        // POST: api/Steps
        [ResponseType(typeof(Step))]
        public async Task<IHttpActionResult> PostStep(Step step)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Steps.Add(step);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = step.StepID }, step);
        }

        // DELETE: api/Steps/5
        [ResponseType(typeof(Step))]
        public async Task<IHttpActionResult> DeleteStep(int id)
        {
            Step step = await db.Steps.FindAsync(id);
            if (step == null)
            {
                return NotFound();
            }

            db.Steps.Remove(step);
            await db.SaveChangesAsync();

            return Ok(step);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StepExists(int id)
        {
            return db.Steps.Count(e => e.StepID == id) > 0;
        }
    }
}