using IdentityMail.Web.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

public class _DefaultSidebarViewComponent(UserManager<AppUser> _userManager) : ViewComponent
{

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var user = await _userManager.GetUserAsync(HttpContext.User);

        ViewBag.FullName = $"{user.FirstName} {user.LastName}";
        ViewBag.ProfileImage = user.ProfileImageUrl;

        return View();
    }
}