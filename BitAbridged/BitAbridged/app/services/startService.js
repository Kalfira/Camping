(function() {
    'use strict';
    angular.module('BitAbridged')
        .factory("languageService", languageService);
    
    var languages = [];

    function languageService($http, $q) {
        var service = {};
        var deferred = $q.defer();

        preloadLanguages();

        service.getLanguages = getLanguages;
        //Start loading API call as soon as iife starts
        function preloadLanguages() {
            $http.get('/api/language')
                .success(function(result) {
                    result.forEach(function(lang) {
                        languages.push(lang);
                    });

                    deferred.resolve(languages);
                }).error(function(result) {
                    console.log(result);
                    deferred.reject();
                });
        };
        //Service property and function definitions
        function getLanguages() {
            return deferred.promise;
        }

        //End of Service
        return service;
    }
})();