using KeaPulss.Core.Services.Interfaces;
using KeaPulss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common;

namespace KeaPulss.Core.Services
{
    public class EventService : IEventService
    {
        private readonly UmbracoHelper _umbracoHelper;
        private readonly IUmbracoContextAccessor _contextAccessor;
        private readonly ITagService _tagService;

        public EventService(
            IUmbracoContextAccessor contextAccessor,
            ITagService tagService,
            UmbracoHelper umbracoHelper)
        {
            _contextAccessor = contextAccessor;
            _tagService = tagService;
            _umbracoHelper = umbracoHelper;
        }

        public IEnumerable<EventPage>? GetAll()
        {
            if (!_contextAccessor.TryGetUmbracoContext(out var context))
            {
                //todo: handle error
                return null;
            }
            var root = context?.Content?.GetAtRoot().FirstOrDefault(n => n.ContentType.Alias == Root.ModelTypeAlias);
            var frontPage = root?.Children.FirstOrDefault(n => n.ContentType.Alias == FrontPage.ModelTypeAlias);
            var eventContainer = frontPage?.Children.FirstOrDefault(n => n.ContentType.Alias == EventContainerPage.ModelTypeAlias);
            return eventContainer?.Children.OfType<EventPage>().ToList();
        }
    }
}