using System.Web;
using System.Web.Mvc;

namespace get_output_as_xml_or_json_using_global
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
