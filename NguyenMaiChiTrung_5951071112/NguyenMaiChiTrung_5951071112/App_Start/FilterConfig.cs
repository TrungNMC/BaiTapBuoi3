using System.Web;
using System.Web.Mvc;

namespace NguyenMaiChiTrung_5951071112
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
