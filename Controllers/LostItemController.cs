using LostFound.Modals;
using LostFound.Services;
using LostFound.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostFound.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LostItemController : ControllerBase
    {
        private ILostItem _lostitem;
        public LostItemController(ILostItem lostitem)
        {
            _lostitem = lostitem;
        }
        // GET: api/<LostItemController>
        [HttpGet]
        public IActionResult GetLostItems()
        {
            return Ok(_lostitem.GetLostItems());
        }

        // GET api/<LostItemController>/5
        [HttpGet("{id}")]
        public IActionResult GetLostItem(LostIItems item)
        {
            return Ok(_lostitem.GetLostItem(item.Id));
        }

        // POST api/<LostItemController>
        [HttpPost]
        public IActionResult AddLostIitem([FromBody] LostIItems item)
        {
            return Ok(_lostitem.AddLostItem(item));
        }

        // PUT api/<LostItemController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateLostIitem(int id, [FromBody] string value)
        {
            return Ok();
        }


        // DELETE api/<LostItemController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteLostIitem(int id)
        {
            return Ok();
        }
    }
}
