using IdentityMail.Web.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

public class _DefaultHeaderViewComponent(UserManager<AppUser> _userManager) : ViewComponent
{

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var user = await _userManager.GetUserAsync(HttpContext.User);

        ViewBag.ProfileImage = user.ProfileImageUrl;

        return View();
    }
}