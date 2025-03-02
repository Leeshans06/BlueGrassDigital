using blueGrassDigital.Models;
using blueGrassDigital.Views.Components.RTEBlock;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace blueGrassDigital.ViewComponents
{
    public class RteBlockViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IPublishedElement content)
        {
            var contentString = content.Value<string>("Content");
            IHtmlContent contentValue = null;

            if (!string.IsNullOrEmpty(contentString))
            {
                contentValue = new HtmlString(contentString);
            }

            var model = new RteBlockModel
            {
                Content = contentValue
            };
            return View("RTEBlock", model);
        }        
    }
}
