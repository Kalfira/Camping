(function() {
    'use strict';
    angular.module('BitAbridged', ['ngRoute']).config(Config);

    function Config($routeProvider) {
        $routeProvider.when('/', {
            templateUrl: '/app/views/start.html',
            controller: 'StartController',
            controllerAs: 'vm'
        }).when('/details/:id', {
            templateUrl: '/app/views/details.html',
            controller: 'DetailsController',
            controllerAs: 'vm'
        }).otherwise({
            redirectTo: '/'
        });
    }

    Config.$inject = ['$routeProvider'];
})();