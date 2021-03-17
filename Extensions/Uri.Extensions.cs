using Flurl;
using System;

namespace ObixClientLibrary.Extensions
{
    public static class UriExtensions
    {

        public static Uri Concat(this Uri uri, string uriString)
        {
            if (uriString.Contains(":") && Uri.IsWellFormedUriString(uriString, UriKind.Absolute))
            {
                return new Uri(uriString);
            }
            else if (uriString.StartsWith("/"))
            {
                return new Uri(uri, uriString);
            }
            else
            {
                return new Uri(Url.Combine(uri.ToString(), uriString));
            }
        }

    }
}
