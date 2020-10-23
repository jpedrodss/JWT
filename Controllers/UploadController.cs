using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWT.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromForm] IFormFile arquivo)
        {
            try
            {
                if (arquivo != null)
                {
                    var urlImagem = Upload.Local(arquivo);

                    return Ok(new { url = urlImagem });
                }

                return BadRequest(new
                {
                    messagem = "Arquivo não informado"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
