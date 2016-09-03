using System;
using Nancy;

namespace EndToEndCoding
{
    public class App : NancyModule
    {
        public App()
        {
            Get["/"] = _ => "Hello!";
            Get["/api/offer/{id}"] = parameters => getResponse(parameters.id);
        }

        private Response getResponse(string id)
        {
            OfferApiResponse response = ApiService.contactApi();
            if (response.valid)
            {
                int offer = int.Parse(id);
                if (offer >= response.bundleList.Count) {
                    return Response.AsJson("That offer does not exist", HttpStatusCode.BadRequest);
                } else {
                    return Response.AsJson(response.bundleList[offer]);
                }
            }
            else
            {
                return HttpStatusCode.InternalServerError;
            }
        }
    }
}
