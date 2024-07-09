using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Protofolio_Website.Database.Interface;
using Protofolio_Website.Db_Set;

namespace Protofolio_Website.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IContactMe contactMe;

        public MessageController(IContactMe contactMe)
        {
            this.contactMe = contactMe;
        }

        [HttpGet]
        [Route("ContactMe", Name = " Contact Me")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<bool> ContactMe(string name, string email,string subject, string message)
        {
            if(name  == null || email == null || subject == null || message == null)
            {
                return false;
            }

            Message Usermessage = new Message
            {
                Name = name,
                Email = email,
                Subject = subject,
                message = message
            };
            return await this.contactMe.AddMessage(Usermessage);
        }
    }
}
