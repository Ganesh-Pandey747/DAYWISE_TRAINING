using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieManagement.Data;
using MovieManagement.Models;
using MovieManagement.Service;


namespace MovieManagement.Controllers
{  
 [ApiController]
    [Route("[controller]")] 
    public class MovieController
    {
        IMovieRepository _imovierepository;
        public UserController( IUserRepository iuserrepository)
        {
          _iuserrepository=iuserrepository;
        }
        
    }
}