using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;
using Nop.Web.Models.Home;

namespace Nop.Web.Components
{
    public class HomePageMakeAnAppointmentViewComponent : NopViewComponent
    {
        public HomePageMakeAnAppointmentViewComponent()
        {

        }

        public IViewComponentResult Invoke()
        {
            return View(new MakeAnAppointmentModel());
        }

    }
}
