(function () {
    'use strict';
    angular.module('BitAbridged')
        .factory("detailsService", detailsService);

    var details = [];

    function detailsService($http, $q) {
        var service = {};
        var deferred = $q.defer();
        var promise;
        preloadDetails();


        service.getDetails = getDetails;
        //Service property and function definitions

        
        function getDetails(id) {
            return promise.then(function (results) {
                return details.filter(function(value) {
                    var val = value.Id == id;
                    console.log(val);
                    return val;
                });
            });
        }
        function preloadDetails() {

            $http.get('/api/language/details/')
                .success(function (result) {
                    result.forEach(function (lang) {
                        details.push(lang);
                    });
                    deferred.resolve(details);
                }).error(function (result) {
                    console.log(result);
                    deferred.reject();
                });

            promise = deferred.promise;
        }

        //End of Service
        return service;
    }
})();