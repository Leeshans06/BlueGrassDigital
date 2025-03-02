using blueGrassDigital.Models;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace blueGrassDigital.ViewComponents
{
    public class HeroCtaBlockViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IPublishedElement content)
        {
            var links = content.Value<IEnumerable<Link>>("primaryCta"); // Retrieve as IEnumerable<Link>
            Link firstLink = null;

            if (links != null && links.Any())
            {
                firstLink = links.First(); // Get the first link
            }
            var model = new HeroCtaBlockModel
            {
                Title = content.Value<string>("title"),
                Description = content.Value<string>("description"),
                ImageUrl = content.Value<IPublishedContent>("image"),
                PrimaryCtaUrl = firstLink
            };
            return View("HeroCtaBlock", model);
        }
    }

}
