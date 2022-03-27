using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1640.Data.EF;
using Project1640.Data.Entities;
using Project1640.Dto.Users;
using Project1640.Service.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1640.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
		private readonly IUserService _userService;
		private readonly Project1640DbContext _context;
		public UserController(IUserService userService, Project1640DbContext context)
        {
			_context = context;
			_userService = userService;
		}
		[HttpGet]
		[Authorize]
		public IEnumerable<User> GetUser()
		{
			var user = _context.Users.Select(s => new User
			{
				Id = s.Id,
				FirstName = s.FirstName,
				LastName = s.LastName,
				Gender = s.Gender,
				DOB = s.DOB,
				UserName = s.UserName,
				Email = s.Email,
				PhoneNumber = s.PhoneNumber
			}).ToList();
			return user;
		}
		[HttpPost("login")]

		public async Task<IActionResult> Login([FromBody] LoginDto request)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);
			var rsToken = await _userService.Login(request);
			if (string.IsNullOrEmpty(rsToken.ResultObj))
			{
				return BadRequest(rsToken);
			}
			return Ok(rsToken);
		}
	}
}
