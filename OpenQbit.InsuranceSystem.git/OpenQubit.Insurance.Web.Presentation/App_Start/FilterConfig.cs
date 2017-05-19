using System.Web;
using System.Web.Mvc;

namespace OpenQubit.Insurance.Web.Presentation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
