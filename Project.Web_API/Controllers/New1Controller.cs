using Project.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace Project.Web_API.Controllers
{

    public class New1Controller : ApiController

    {
        [HttpGet]

        public JsonResult<List<UserDto>> GetUsers()
        {
            var UserService = new UserService();

            return Json(UserService.GetAllDisableUsers());
        }




    }

}
