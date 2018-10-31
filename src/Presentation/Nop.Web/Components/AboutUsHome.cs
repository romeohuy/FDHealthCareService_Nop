using Microsoft.AspNetCore.Mvc;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;

namespace Nop.Web.Components
{
    public class AboutUsHomeViewComponent : NopViewComponent
    {
        private readonly ITopicModelFactory _topicModelFactory;

        public AboutUsHomeViewComponent(ITopicModelFactory topicModelFactory)
        {
            this._topicModelFactory = topicModelFactory;
        }

        public IViewComponentResult Invoke(string systemName)
        {
            var model = _topicModelFactory.PrepareTopicModelBySystemName(systemName);
            if (model == null)
                return Content("");
            return View(model);
        }
    }
}
