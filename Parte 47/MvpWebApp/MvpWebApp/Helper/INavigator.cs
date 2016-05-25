using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpWebApp.Helper
{
    public interface INavigator
    {
        void NavigateTo(string pageName);

        void NavigateTo(string pageName, Dictionary<string, string> queryStringParams);
    }
}
