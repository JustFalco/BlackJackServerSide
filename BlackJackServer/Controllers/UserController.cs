using DatabaseLayer.DAL.DomainModels;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using System.Security.Claims;
using DatabaseLayer.Repositories;
using GameLibrary.Controllers;
using Microsoft.AspNetCore.Identity;
using Shared.DTOs;
using Azure;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlackJackServer.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IPlayerController _playerController;
        private readonly IConfiguration _configuration;
        private readonly UserManager<Player> _userManager;
        private readonly SignInManager<Player> _signInManager;
        private IEnumerable<IdentityError> _errors { get; set; }

        public UserController(IPlayerRepository playerRepository, IPlayerController playerController, IConfiguration configuration, UserManager<Player> userManager, SignInManager<Player> signInManager)
        {
            _playerRepository = playerRepository;
            _playerController = playerController;
            _configuration = configuration;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: api/<UserController>
        [Authorize]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/user/register
        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> RegisterPost([FromBody] PlayerDTO player)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("Model is good!");

                if (Teapot(player.Email))
                {
                    return StatusCode(418);
                }

                var userExists = await _userManager.FindByEmailAsync(player.Email);
                if (userExists != null)
                    return BadRequest("User already exists!");


                var result = await _playerController.NewPlayer(player);
                var loginResult = await _signInManager.PasswordSignInAsync(result, player.Password, true, false);

                if (!loginResult.Succeeded) return BadRequest(new LoginResult { Successful = false, Error = "Username and password are invalid." });
            }
            else
            {
                //Adds the errors to the modelstate which will be returned in JSON format on a failed POST
                foreach (var error in _errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
            }
           
            

            return Ok(new LoginResult { Successful = true, Email = player.Email});
        }

        // POST api/user/login
        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> LoginPost([FromBody] PlayerDTO player)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("Model is good!");

                if (Teapot(player.Email))
                {
                    return StatusCode(418);
                }

                var result = await _userManager.FindByEmailAsync(player.Email);
                if (result == null)
                    return NotFound();

                var loginResult = await _signInManager.PasswordSignInAsync(result, player.Password, true, false);

                if (!loginResult.Succeeded) return BadRequest(new LoginResult { Successful = false, Error = "Username and password are invalid." });

                await _userManager.AddClaimAsync(result, new Claim(ClaimTypes.Email, player.Email));

                var claims = new[]
                {
                    new Claim(ClaimTypes.Email, player.Email)
                };

                var jwtConfig = _configuration.GetSection("JWT");
                var secretKey = jwtConfig["secret"];

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var expiry = DateTime.Now.AddDays(Convert.ToInt32(jwtConfig["expiresIn"]));

                var token = new JwtSecurityToken(
                    jwtConfig["validIssuer"],
                    jwtConfig["validAudience"],
                    claims,
                    expires: expiry,
                    signingCredentials: creds
                );

                return Ok(new LoginResult { Successful = true, Token = new JwtSecurityTokenHandler().WriteToken(token), Email = player.Email});

            }
            else
            {
                //Adds the errors to the modelstate which will be returned in JSON format on a failed POST
                foreach (var error in _errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
            }

            return StatusCode(500, "Internal server error");

        }

        private bool Teapot(string Input)
        {
            return Input.ToLower() == "teapot@teapot.teapot";
        }
    }
}
