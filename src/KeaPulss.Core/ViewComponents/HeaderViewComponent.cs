using Umbraco.Cms.Core.Web;
using KeaPulss.Models.ViewModels;
using KeaPulss.Models;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;
using Umbraco.Cms.Core.Models;


namespace KeaPulss.Core.ViewComponents
{
    [ViewComponent(Name = "Header")]

    public class HeaderViewComponent : ViewComponent
    {
        private readonly IUmbracoContextAccessor _contextAccessor;
      
        public HeaderViewComponent(IUmbracoContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
            
        }

        public IViewComponentResult Invoke()
        {
            if (!_contextAccessor.TryGetUmbracoContext(out var context))
            {
                // TODO: håndter fejl
                return View();
            }

            var root = context?.Content?
                .GetAtRoot()
                .FirstOrDefault(hej => hej.ContentType.Alias == Root.ModelTypeAlias) as Root;

            if (root is null)
            {
                // TODO: håndter fejl
                return View();
            }

            // Sørg for, at objekterne er initialiseret, før du forsøger at tilgå deres egenskaber
            var viewModel = new HeaderViewModel()
            {
                Logo = root.HasValue("logo") ? root.Value<MediaWithCrops>("logo") : null,
                NewsUrl = root.NewsLink?.Url,
                NewsLinkTitle = root.NewsLink?.Name,
                EventUrl = root.EventLink?.Url,
                EventTitle = root.EventLink?.Name,
                StudielivUrl = root.StudielivLink?.Url,
                StudielivTitle = root.StudielivLink?.Name,
                LoginUrl = root.LoginLink?.Url,
                FredagsbarUrl = root.Fredagsbarlink?.Url,
                ApplicationUrl = root.ApplicationLink?.Url,
                ParisAftaleUrlUrl = root.ParisAftaleLink?.Url,
                FrontPageUrl = root.Fredagsbarlink?.Url

              

               

            };

            return View(viewModel);
        }


    }
}
