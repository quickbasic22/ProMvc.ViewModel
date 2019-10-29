using System.Web;
using System.Web.Mvc;

namespace ProMvc5.ViewModel
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
