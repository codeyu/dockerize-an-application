﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        [Authorize("Bearer")]
        public string Get()
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;

            var id = claimsIdentity.Claims.FirstOrDefault(c => c.Type == "ID").Value;

            return $"Hello! {HttpContext.User.Identity.Name}, your ID is:{id}";
        }
    }
}
