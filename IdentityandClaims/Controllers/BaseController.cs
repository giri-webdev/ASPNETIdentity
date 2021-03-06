﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;
using IdentityandClaims.Utility;

namespace IdentityandClaims.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        public HttpClient client;
        //The URL of the WEB API Service
        string baseurl = "http://localhost:55626/";

        public BaseController()
        {
           
                client = new HttpClient();
                client.BaseAddress = new Uri(baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                if (!string.IsNullOrEmpty(TokenUtility.AccessToken))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenUtility.AccessToken);
                }
            
        }
    }
}