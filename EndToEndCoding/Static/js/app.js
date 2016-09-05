﻿'use strict';

angular.module('offerApp', [])
  .controller('OfferController', ['$http' ,function ($http) {
      var offer = this;
      
      offer.loaded = false;
      offer.showDetailedCost = false;

      offer.getAverageMonthlyCost = function () {

      }

      offer.getOffer = function (offerId) {
          $http.get('/api/offer/' + offerId, {}).then(function (response) {
              offer.data = response.data;
              offer.loaded = true;
          }, function () {
              offer.error = true;
          });
      }
      
  }]);