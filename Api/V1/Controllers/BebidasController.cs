using Api.V1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("0.9", Deprecated = true)]
    [Route("api/[controller]")]
    public class BebidasController : ControllerBase
    {
        /// <summary>
        /// Obtem lista de Bebidas
        /// </summary>
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<BebidaViewModel>), 200)]
        public IEnumerable<BebidaViewModel> Get()
        {
            return new List<BebidaViewModel>
            {
                new BebidaViewModel{ Alcolica = false, Id = Guid.NewGuid(), Nome = "Bud" },
                new BebidaViewModel{ Alcolica = true, Id = Guid.NewGuid(), Nome = "Goiano" },
            };
        }

        /// <summary>
        /// Obtem Bebida por Id
        /// </summary>
        [HttpGet("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BebidaViewModel), 200)]
        public BebidaViewModel Get(Guid id)
        {
            return new BebidaViewModel { Alcolica = true, Id = id, Nome = "Goiano" };
        }

        /// <summary>
        /// Grava nova bebida
        /// </summary>
        /// <param name="bebida"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(BebidaViewModel), 201)]
        [ProducesResponseType(400)]
        public IActionResult Post([FromBody] BebidaViewModel bebida)
        {
            return CreatedAtAction(nameof(Get), bebida.Id, bebida);
        }

        /// <summary>
        /// Atualiza Bebida
        /// </summary>
        /// <param name="bebida"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(BebidaViewModel), 201)]
        [ProducesResponseType(400)]
        public IActionResult Put(int id, [FromBody] BebidaViewModel bebida)
        {
            return CreatedAtAction(nameof(Get), bebida.Id, bebida);
        }

        /// <summary>
        /// Deleta a Bebida
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(BebidaViewModel), 200)]
        [ProducesResponseType(400)]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
