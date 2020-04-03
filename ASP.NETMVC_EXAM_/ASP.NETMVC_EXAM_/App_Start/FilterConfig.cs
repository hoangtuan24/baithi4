using System.Web;
using System.Web.Mvc;

namespace ASP.NETMVC_EXAM_VU
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
