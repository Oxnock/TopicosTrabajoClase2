using System.Web;
using System.Web.Mvc;

namespace Trabajo3Multiplicacion
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
