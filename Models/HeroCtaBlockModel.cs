using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace blueGrassDigital.Models
{
    public class HeroCtaBlockModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public IPublishedContent? ImageUrl { get; set; }
        public Link? PrimaryCtaUrl { get; set; }
    }
}
