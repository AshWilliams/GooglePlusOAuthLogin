using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using GooglePlusOAuthLogin.Models;

namespace GooglePlusOAuthLogin
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            OAuthWebSecurity.RegisterClient(new GooglePlusClient("808748037769.apps.googleusercontent.com", "GwaMKxJSA6v-9ItP4iAdRZZ5"), "Google+", null);
        }
    }
}
