using MvcPL.Infrastructure.Handlers;
using System.Web;
using System.Web.Mvc;

namespace MvcPL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new HandleAllErrorAttribute());
        }
    }
}