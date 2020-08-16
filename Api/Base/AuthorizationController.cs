using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Users;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MinhasSenhas.Base
{
    [ApiController]
    [Authorize()]
    public class AuthorizationController : ControllerBase
    {
    }
}
