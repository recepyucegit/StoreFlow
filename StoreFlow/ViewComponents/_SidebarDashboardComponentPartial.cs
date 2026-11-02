using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace StoreFlow.ViewComponents
{
    public class _SidebarDashboardComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
