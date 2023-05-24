using Microsoft.AspNetCore.Identity;
using UserDatasetLibrary.Core.Dtos.User;
using UserDatasetLibrary.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace UserDatasetLibrary.WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            UserDto? dto = userService.GetUserById(id);
            if (dto is null)
            {
                return NotFound();
            }
            return Ok(dto); // TODO: add message object and mapping
        }
        
        [HttpGet()]
        public IActionResult GetAllUsers()
        {
            UserDto[] arrayDto = userService.GetAllUsers();
            //if (arrayDto is null)     //{return NotFound();}
            return Ok(arrayDto); // TODO: add message object and mapping
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserDto user) // TODO: use request object instead of core dto
        {
            await userService.CreateUser(user);
            return Created(nameof(GetById), user);
        }

        [HttpDelete("{id}")]
        //TODO:make it async
        public IActionResult DeleteUserById([FromRoute] Guid id) // TODO: use request object instead of core dto
        {
            UserDto? dto = userService.DeleteUserById(id);
            if (dto is null)
            {
                return NotFound();
            }
            return Ok(dto);
            //Deleted(nameof(GetById), user);
        }
        /*
        public IHttpActionResult DeleteUser(int id)
        {
            User user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            users.Remove(user);
            return Ok(user);
        }*/
    }
}





/*
[HttpPost]
public async Task<IActionResult> OnPostAsync(string returnUrl = null)
{
    returnUrl = returnUrl ?? Url.Content("~/");
    ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync())
                                          .ToList();
    if (ModelState.IsValid)
    {
        var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
        var result = await _userManager.CreateAsync(user, Input.Password);
        if (result.Succeeded)
        {
            _logger.LogInformation("User created a new account with password.");

            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { area = "Identity", userId = user.Id, code = code },
                protocol: Request.Scheme);

            await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            if (_userManager.Options.SignIn.RequireConfirmedAccount)
            {
                return RedirectToPage("RegisterConfirmation",
                                      new { email = Input.Email });
            }
            else
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return LocalRedirect(returnUrl);
            }
        }
        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }
    }

    // If we got this far, something failed, redisplay form
    return Page();
}


    //await fotoService.CreateFoto(foto);
    //return Created(nameof(GetById), foto);
}
}
*/
