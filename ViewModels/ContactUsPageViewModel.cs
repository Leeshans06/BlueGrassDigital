using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.Blocks;

namespace blueGrassDigital.ViewModels
{
    public class ContactUsPageViewModel
    {

        public BlockGridModel? PageHeader { get; set; }
        public BlockGridModel? MainContent { get; set; }
        public string? Title { get; set; }
        public string? HeaderColor { get; set; }
        public string? Slogan { get; set; }
        public string? FooterText { get; set; }
    }
}
