using languages_mvc.Helpers;
using System;
using System.Web;
using System.Web.Mvc;

namespace languages_mvc.Controllers
{
    public class BaseController : Controller
    {
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            else
            {
                var userLanguage = Request.UserLanguages;
                var userLang = userLanguage != null ? userLanguage[0] : "";
                if (userLang != "")
                {
                    lang = userLang;
                }
                else
                {
                    lang = LanguageConfig.GetDefaultLanguage();
                }
            }
            new LanguageConfig().SetLanguage(lang);
            return base.BeginExecuteCore(callback, state);
        }

        public ActionResult ChangeLanguage(string lang)
        {
            new LanguageConfig().SetLanguage(lang);
            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}