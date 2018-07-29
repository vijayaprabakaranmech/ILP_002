using System.Web;
using System.Web.Mvc;

namespace ILP_002_Anglar_VI393317_VijayaprabakaranS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
