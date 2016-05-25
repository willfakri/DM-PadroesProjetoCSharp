using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MvpWebApp.Helper
{
    public class Navigator : INavigator
    {
        public void NavigateTo(string pageName)
        {
            HttpContext.Current.Response.Redirect(pageName);
        }

        public void NavigateTo(string pageName, Dictionary<string, string> queryStringParams)
        {
            StringBuilder urlToNavigate = new StringBuilder(pageName);
            urlToNavigate.Append("?");
            for (int i = 0; i < queryStringParams.Count; i++)
            {
                var entry = queryStringParams.ElementAt(i);
                urlToNavigate.Append(entry.Key + "=" + entry.Value + "&");
            }
            urlToNavigate.Remove(urlToNavigate.Length - 1, 1);
            HttpContext.Current.Response.Redirect(urlToNavigate.ToString());
        }
    }
}