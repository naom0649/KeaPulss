using KeaPulss.Models.ViewModels;
using KeaPulss.Models;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Web;

namespace KeaPulss.Core.ViewComponents
{
    [ViewComponent(Name = "News")]
    public class NewsViewComponent : ViewComponent
    {
        private readonly IUmbracoContextAccessor _contextAccessor;

        public NewsViewComponent(IUmbracoContextAccessor contextAccessor)
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
            var viewModel = new NewsViewModel()
            {
             

            };




            return View(viewModel);
        }

    }
}
