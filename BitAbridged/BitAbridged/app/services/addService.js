(function() {
    'use strict';
    angular.module('BitAbridged')
        .factory('addService', addService);

    function addService($window, $q, $http) {
        var service = {};
        var token = $window.sessionStorage.getItem('token');

        service.addLanguage = addLanguage;

        function addLanguage(language) {
            var deferred = $q.defer();
            $http({
                url: '/api/language/add',
                method: 'POST',
                data: language,
                headers: { 'Authorization': 'Bearer ' + token }
            }).success(function(data) {
                if (data) {
                    console.log(data);
                    deferred.resolve();
                } else {
                    console.log('Add error!');
                }
            }).error(function (data) {
                console.log('Add Failed!');
                deferred.reject(data);
            });

            return deferred.promise;
        }

        return service;
    }
})();