using Umbraco.Cms.Core.Web;
using KeaPulss.Models.ViewModels;
using KeaPulss.Models;
using Microsoft.AspNetCore.Mvc;


namespace KeaPulss.Core.ViewComponents
{
    [ViewComponent(Name ="Header")]

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
                //todo: handle error
            }

            var root = context?.Content?
                .GetAtRoot()
                .FirstOrDefault(hej => hej.ContentType.Alias == Root.ModelTypeAlias) as Root;

            if (root is null)
            {
                //todo: handle error
                return View();
            }

            //Enrich view model
            var viewModel = new HeaderViewModel()
            {
                Logo = root?.Logo,
                NewsUrl = root?.NewsLink?.Url,
                NewsLinkTitle = root?.NewsLink?.Name,
                EventUrl = root?.EventLink?.Url,
                EventTitle = root?.EventLink.Name,
                StudielivUrl = root?.StudielivLink?.Url,
                StudielivTitle = root?.StudielivLink?.Name
               
            };

            return View(viewModel);
        }

    }
}
