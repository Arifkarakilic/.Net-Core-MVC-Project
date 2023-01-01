using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AspNetCoreMultilingual.Controllers
{
    public class LangController : Controller
    {
        readonly RequestLocalizationOptions _localizationOptions;

        public LangController(IOptions<RequestLocalizationOptions> localizationOptions)
            => _localizationOptions = localizationOptions.Value;

        public IActionResult AllLanguages()
        {
            IRequestCultureFeature requestCulture = HttpContext.Features.Get<IRequestCultureFeature>();
            var allCultures = _localizationOptions.SupportedCultures
                    .Select(culture => new
                    {
                        Name = culture.Name,
                        Text = culture.DisplayName
                    }).ToList();
            return Ok(allCultures);
        }
    }
}
