using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace ContactForm.Core.Models
{
    public class CookeViewModel : ContentModel
    {
        public bool SocialMedia { get; set; }
        public bool GoogleAnalytics { get; set; }

        public CookeViewModel(IPublishedContent content) : base(content)
        {
        }
    }
}
