using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Loclandes.data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Loclandes.Controllers
{
    [Route("api/MiniExcursion")]
    [ApiController]
    public class MiniExcursionController : ControllerBase
    {
        private readonly IMiniExcursionDal miniExcursionDal;

        public MiniExcursionController(IMiniExcursionDal _miniExcursionDal)
        {
            miniExcursionDal = _miniExcursionDal;
        }

        // GET: api/MiniExcursion
        [HttpGet]
        public ActionResult<IEnumerable<MiniExcursionDao>> Get()
        {
            return Ok(miniExcursionDal.GetAllExcursions());
        }

        // GET: api/MiniExcursion/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<MiniExcursionDao> Get(int id)
        {
            var miniExcursion = miniExcursionDal.GetExcursionById(id);
            if (miniExcursion != null)
            {
                return Ok(miniExcursionDal.GetExcursionById(id));
            }
            else
            {
                var response = $"MiniExcursion id {id} not found.";
                return NotFound(response);
            };
        }

        // POST: api/MiniExcursion
        [HttpPost]
        public void Post(MiniExcursionDao miniExcursion) //ActionResult ?
        {
            miniExcursionDal.InsertMiniExcursion(miniExcursion);
        }

        // PUT: api/MiniExcursion/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, MiniExcursionDao miniExcursion)
        {
            var affectedRows = miniExcursionDal.UpdateMiniExcursion(miniExcursion);
            if (affectedRows > 0 && id == miniExcursion.IdMiniExcursion)
            {

                return NoContent();
            }
            else
            {
                return BadRequest("MiniExcursion has not been updated.");
            };
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var affectedRows = miniExcursionDal.DeleteMiniExcursion(id);

            if (affectedRows > 0)
            {

                return NoContent();
            }
            else
            {
                return BadRequest("MiniExcursion has not been deleted.");
            };
        }
    }
}
