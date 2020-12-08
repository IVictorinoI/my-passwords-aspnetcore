using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data;
using Application.Passwords;
using Application.Passwords.Dto;
using Application.Passwords.View;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhasSenhas.Base;

namespace MinhasSenhas.Controllers
{
    [Route("api/v1/passwords")]
    public class PasswordController : AuthorizationController
    {
        [HttpPost]
        public async Task<ActionResult<PasswordView>> Post(
            [FromServices] IAplicPassword aplicPassword,
            [FromBody] PasswordDto dto)
        {
            return await aplicPassword.Insert(dto);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<PasswordView>> Put(
            [FromServices] IAplicPassword aplicPassword,
            int id,
            [FromBody] PasswordDto dto)
        {
            return await aplicPassword.Update(id, dto);
        }

        [HttpGet]
        public async Task<ActionResult<List<PasswordView>>> GetByUser(
            [FromServices] IAplicPassword aplicPassword)
        {
            return await aplicPassword.GetByUser();
        }
    }
}
