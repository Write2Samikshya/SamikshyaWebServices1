using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SamikshyaWebServices1
{
    /// <summary>
    /// Summary description for Addition1
    /// </summary>
    [WebService(Namespace = "https://github.com/Write2Samikshya/WebServices")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Addition1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        public int  Addition(int a, int b)
        {
            return a + b;

        }
    }
}
