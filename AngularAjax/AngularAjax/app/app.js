(function() {
    angular.module('MyApp', ['ngRoute']).config(function($routeProvider) {
        
        $routeProvider
            .when('/', {
                templateUrl: '/app/views/start.html',
                controller: 'StartController'
            }).when('/create', {
                templateUrl: '/app/views/create.html',
                controller: 'CreateController',
                controllerAs: vm
            });
    });
})();