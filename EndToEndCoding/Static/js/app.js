'use strict';

angular.module('offerApp', [])
  .controller('OfferController', ['$http' ,function ($http) {
      var offer = this;
      
      offer.test = "hello";

      offer.getOffer = function (offerId) {
          $http.get('/api/offer/' + offerId, {}).then(function (response) {
              offer.data = response.data;
          }, function () {

          });
      }
      
  }]);