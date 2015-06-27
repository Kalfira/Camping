(function() {
    'use strict';
    angular.module('BitAbridged', ['ngRoute']).config(Config);

    function Config($routeProvider) {
        $routeProvider.when('/', {
            templateUrl: '/app/views/start.html',
            controller: 'StartController',
            controllerAs: 'vm'
        }).when('/details', {
            templateUrl: '/app/views/details.html',
            controller: 'DetailsController',
            controllerAs: 'vm'
        });
    }

    Config.$inject = ['$routeProvider'];
})();