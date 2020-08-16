using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data;
using Application.Users;
using Application.Users.Dto;
using Application.Users.View;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhasSenhas.Base;

namespace MinhasSenhas.Controllers
{
    [Route("api/v1/users")]
    public class UserController : AuthorizationController
    {
        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<UserView>> Put(
            [FromServices] IAplicUser aplicUser,
            int id,
            [FromBody] UserDto dto)
        {
            return await aplicUser.Update(id, dto);
        }

    }
}
