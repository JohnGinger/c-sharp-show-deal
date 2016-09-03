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
                    String endPoint = System.Configuration.ConfigurationManager.AppSettings["endpoint"];
                    String apiKey = System.Configuration.ConfigurationManager.AppSettings["apiKey"];
       
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