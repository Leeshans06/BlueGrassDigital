namespace blueGrassDigital.ViewComponents
{
    using blueGrassDigital.Models;
    using Microsoft.AspNetCore.Mvc;
    using Umbraco.Cms.Core.Models.PublishedContent;

    public class HeroBlockViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IPublishedElement content)
        {
            var model = new HeroBlockModel
            {
                Title = content.Value<string>("title"),
                Description = content.Value<string>("description"),
                Image = content.Value<IPublishedContent>("image")
            };
            return View("HeroBlock", model);
        }
    }
}