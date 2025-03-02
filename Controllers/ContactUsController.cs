using blueGrassDigital.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace blueGrassDigital.Controllers
{
    public class ContactUsController : RenderController
    {
        public ContactUsController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor) : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
        }

        public override IActionResult Index()
        {
            // Retrieve Site Settings from Root Node
            var title = CurrentPage.Root().Value<string>("title");
            var navColor = CurrentPage.Root().Value<string>("headerColor");
            var slogan = CurrentPage.Root().Value<string>("slogan");
            var footerText = CurrentPage.Root().Value<string>("footerText");

            // Create and Populate View Model
            var model = new ContactUsPageViewModel
            {
                Title = title,
                HeaderColor = navColor,
                Slogan = slogan,
                FooterText = footerText,
                PageHeader = CurrentPage.Value<BlockGridModel>("pageHeader"),
                MainContent = CurrentPage.Value<BlockGridModel>("mainContent")
            };

            // Pass View Model to View
            ViewData["PageModel"] = model;
            return CurrentTemplate(CurrentPage);
        }
    }
}
