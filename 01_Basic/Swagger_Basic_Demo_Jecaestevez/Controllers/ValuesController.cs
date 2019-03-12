using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Swagger_Basic_Demo_Jecaestevez.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/Values
        /// <summary>
        /// Gets all the values
        /// </summary>        
        /// <returns>list of values</returns>
        /// <response code="200">Value returned</response>
        /// <response code="404">Value was not able to be found</response>
        /// <response code="400">Id was below 0</response>
        [HttpGet]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Values/5
        /// <summary>
        /// Gets a value by ID.
        /// </summary>
        /// <param name="id">The id of the value you wish to get.</param>
        /// <returns>value</returns>
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Values

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Values/5
        /// <summary>
        /// Save a value by ID.
        /// </summary>
        /// <param name="id">The id of the value you wish to get.</param>
        /// <param name="value">The value you wish to put.</param>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /vALUES
        ///     {
        ///        "id": 1,
        ///        "name": "Item1"
        ///     }
        /// </remarks>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>    
        [HttpPut("{id}")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        /// <summary>
        /// Deletes a specific  item.
        /// </summary>
        /// <param name="id"></param>        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
