using System.Web;
using System.Web.Mvc;

namespace DEMOMVC2023Lab10
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
