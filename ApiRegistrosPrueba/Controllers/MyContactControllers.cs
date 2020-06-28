using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ApiRegistrosPrueba.Models;

namespace ApiRegistrosPrueba.Controllers
{  
    [ApiController]
    [Route("api/[controller]")]
    public class MyContactController: Controller
    {
        private MyContactsContext contactsContext;

        public MyContactController(MyContactsContext context)
        {
            contactsContext = context;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<MyContacts>> Get()
        {
            return contactsContext.MyContactSet.ToList();
        }

        ~MyContactController() 
        {
            contactsContext.Dispose();
        }

    }
}