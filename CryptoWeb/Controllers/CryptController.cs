using CryptoWeb.Models;
using CryptoWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace CryptoWeb.Controllers
{



    [ApiController]
    [Route("api/[controller]")]
    public class CryptController : ControllerBase
    {
        private readonly ICryptoService _cryptoService;

        public CryptController(ICryptoService cryptoService)
        {
            _cryptoService = cryptoService;
        }

        [HttpPost("encrypt")]
        public IActionResult Encrypt([FromBody] EncryptRequest request)
        {
            (string encryptedText, string key) = _cryptoService.EncryptMessage(request.PlainText);
            return Ok(new { EncryptedText = encryptedText, Key = key });
        }

        [HttpPost("decrypt")]
        public IActionResult Decrypt([FromBody] DecryptRequest request)
        {
            string decryptedText = _cryptoService.DecryptMessage(request.EncryptedText, request.Key);
            return Ok(new { DecryptedText = decryptedText });
        }

    }
}
