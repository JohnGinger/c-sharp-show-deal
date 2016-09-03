using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EndToEndCoding
{
    public class OfferApiResponse
    {
        public Boolean valid { get; set; }
        public List<Offer> bundleList { get; set; }

        public static OfferApiResponse getInvalidResponse() {
            OfferApiResponse offer = new OfferApiResponse();
            offer.valid = false;
            return offer;
        }
    }

}