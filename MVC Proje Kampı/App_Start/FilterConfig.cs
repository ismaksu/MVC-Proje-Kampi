using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Kampı
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
