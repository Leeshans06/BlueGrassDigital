using Umbraco.Cms.Core.Models.PublishedContent;

namespace blueGrassDigital.Models
{
    public class HeroBlockModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public IPublishedContent? Image { get; set; }
    }
}
