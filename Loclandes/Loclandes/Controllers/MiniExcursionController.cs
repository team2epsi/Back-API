﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<MiniExcursionDao> Get()
        {
            return miniExcursionDal.Get();
        }

        // GET: api/MiniExcursion/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MiniExcursion
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
        }
    }
}
