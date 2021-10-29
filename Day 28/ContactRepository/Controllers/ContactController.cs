using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactRepository.Repository;
using ContactRepository.Models;

namespace ContactRepository.Controllers
{
    [ApiController]
    [Route("Taazaa/[controller]")]
    public class ContactController:ControllerBase
    {
    
        IContactsRepository IcontactsRepository;
        public ContactController(IContactsRepository _IcontactsRepository)
        {
            IcontactsRepository=_IcontactsRepository;
        }

        [Route("Create")]
        [HttpPost]
        public async Task<IActionResult> CreateContact(Contact contact)
        {
            if(contact==null)
            {
                return BadRequest();
            }
            await IcontactsRepository.Add(contact);
            return Ok(contact);

        }
        
    }
}