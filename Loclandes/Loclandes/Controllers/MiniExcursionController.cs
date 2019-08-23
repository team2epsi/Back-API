using System.Collections.Generic;
using System.Net;
using System.Net.Http;

using Loclandes.data;

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
        public ActionResult<IEnumerable<MiniExcursionDao>> GetAllMiniExcursions()
        {
            return Ok(miniExcursionDal.GetAllMiniExcursions());
        }

        // GET: api/MiniExcursion/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<IEnumerable<MiniExcursionDao>> GetMiniExcursionById(int id)
        {
            return Ok(miniExcursionDal.GetMiniExcursionById(id));
        }

        // POST: api/MiniExcursion
        [HttpPost]
        public HttpResponseMessage Post([FromBody] MiniExcursionDao mini)
        {
            if (ModelState.IsValid)
            { miniExcursionDal.AddMiniExcursion(mini); return new HttpResponseMessage(HttpStatusCode.OK); }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        // PUT: api/MiniExcursion/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            miniExcursionDal.DeleteMiniExcursion(id);
        }
    }
}
