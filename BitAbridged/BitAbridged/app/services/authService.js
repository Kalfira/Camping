﻿(function() {
    'use strict';
    angular.module('BitAbridged')
        .factory('authService', authService);

    function authService($http, $q, $window) {
        var service = {};

        service.login = login;
        service.logout = logout;

        function login(username, password) {
            var deferred = $q.defer();

            $http({
                url: '/Token',
                method: 'POST',
                data: 'username=' + username + '&password=' + password + '&grant_type=password',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            }).success(function(data) {
                $window.sessionStorage.setItem('token', data.access_token);
                deferred.resolve();
            }).error(function() {
                deferred.reject();
            });
            return deferred.promise;
        }

        function logout() {
            $window.sessionStorage.removeItem('token');
        }
        return service;
    }

})();