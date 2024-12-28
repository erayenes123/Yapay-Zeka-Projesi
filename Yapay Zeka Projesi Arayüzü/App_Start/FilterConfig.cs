using System.Web;
using System.Web.Mvc;

namespace Yapay_Zeka_Projesi_Arayüzü
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
