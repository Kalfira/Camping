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
        }).when('/add', {
            templateUrl: '/app/views/add.html',
            controller: 'AddController',
            controllerAs: 'vm'
        }).when('/login', {
            templateUrl: '/app/views/login.html',
            controller: 'LoginController',
            controllerAs: 'vm'
        }).when('/logout', {
            templateUrl: '/app/views/start.html',
            controller: 'LogoutController',
            redirectTo: '/'
        }).otherwise({
            redirectTo: '/'
        });
    }

    Config.$inject = ['$routeProvider'];
})();