using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore
{
    public class PaypalConfiguration
    {
        public readonly static string clientId;
        public readonly static string clientSecret;


        static PaypalConfiguration()
        {
            var config = getconfig();
            clientId = "ASe6yrJkEszuyBLgBYYiXo2HovihJmiy5SyU4OZx7LsZSnHp3CWCAjkIdbLzfzkn-1OfOUZ6h865d8r6";
            clientSecret = "EMaugxh3s9YT0bP-lfs1_xjnzYxTUP8QGjqqhGlrKqFacwLZY7JyfO_j4QZfsuDHEobefMrHQVu6c4GF";
        }

        private static Dictionary<string, string> getconfig()
        {
            return PayPal.Api.ConfigManager.Instance.GetProperties();
        }

        private static string GetAccessToken()
        {
            string accessToken = new OAuthTokenCredential(clientId, clientSecret, getconfig()).GetAccessToken();
            return accessToken;
        }
        public static APIContext GetAPIContext()
        {
            APIContext apicontext = new APIContext(GetAccessToken());
            apicontext.Config = getconfig();
            return apicontext;
        }
    }
}