(function() {
    angular.module('FilterApp', ['ngRoute']).config(Config);

    function Config($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: '/app/views/start.html',
                controller: 'StartController',
                controllerAs: 'vm'
            })
            .when('/about', {
                templateUrl: '/app/views/about.html',
                controller: 'AboutController',
                controllerAs: 'vm'
            });
    }
})();