﻿(function() {
    'use strict';
    angular.module('BitAbridged')
        .factory("startService", startService);
    
    var languages = [];

    function startService($http, $q) {
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
                }).error(function() {
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