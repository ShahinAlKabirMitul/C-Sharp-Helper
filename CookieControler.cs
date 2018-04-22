using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShortInformationEntryProject.BLL
{
    public class CookieControler
    {
        public static string UserName = "_xdhjkashdkashdhaskj";
        public static string CounterID = "_xdhjkkasdfksdhfshdhaskj";


        int expireDate = 1;
        public void ClearCookie(HttpResponse Response, string Key)
        {
            Response.Cookies[Key].Value = null;
            Response.Cookies[Key].Expires = DateTime.Now.AddDays(-1);
        }
        public void ClearCookie(HttpResponse Response)
        {
            Response.Cookies[UserName].Value = null;
            Response.Cookies[UserName].Expires = DateTime.Now.AddDays(-1);

            Response.Cookies[CounterID].Value = null;
            Response.Cookies[CounterID].Expires = DateTime.Now.AddDays(-1);
        }

        public void SetCookie(HttpResponse Response, string Key, string Value)
        {
            Response.Cookies[Key].Value = Value;
            Response.Cookies[Key].Expires = DateTime.Now.AddDays(expireDate);
        }


        public string GetCookie(HttpRequest Request, string Key)
        {
            if (Request.Cookies[Key] != null)
            {

                return Request.Cookies[Key].Value.ToString();
            }

            return "";
        }

        public bool IsCookieNull(HttpRequest Request, string Key)
        {
            if (Request.Cookies[Key] != null)
            {
                return false;
            }
            return true;
        }
    }
}