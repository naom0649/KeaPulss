using KeaPulss.Models.ViewModels;
using KeaPulss.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Web;

namespace KeaPulss.Core.ViewComponents
{
    [ViewComponent(Name = "Footer")]
    public class FooterViewComponent
    {

        private readonly IUmbracoContextAccessor _contextAccessor;

        public FooterViewComponent(IUmbracoContextAccessor contextAccessor)
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
            var viewModel = new FooterViewModel()
            {
                LogoFooter = root.LogoFooter,
                Slogan = root.Slogan,
                SoMeLinks = root.SoMeLinks,
                Address = root.Address,
                OpeningHours = root.OpeningHours,
                Contact = root.ContactUs


            };




            return View(viewModel);
        }

        private IViewComponentResult View()
        {
            throw new NotImplementedException();
        }

        private IViewComponentResult View(FooterViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
