using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace EndToEndCoding
{
    public class ApiService
    {
        public static OfferApiResponse contactApi()
        {
            using (var w = new WebClient())
            {
                var jsonData = string.Empty;
                try
                {
                    string endPoint = System.Configuration.ConfigurationManager.AppSettings["endpoint"];
                    string apiKey = System.Configuration.ConfigurationManager.AppSettings["apiKey"];
                    w.Encoding = System.Text.Encoding.UTF8;
                    jsonData = w.DownloadString(endPoint + apiKey);
                }
                catch (Exception) {
                    return OfferApiResponse.getInvalidResponse();
                }

                if (string.IsNullOrEmpty(jsonData)) {
                    return OfferApiResponse.getInvalidResponse();
                }
                OfferApiResponse response = JsonConvert.DeserializeObject<OfferApiResponse>(jsonData);
                response.valid = true;
                return response;
            }
        }
    }
}