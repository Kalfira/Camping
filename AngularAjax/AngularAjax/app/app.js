(function () {
    angular.module('MyApp', ['ngRoute']).config(Config);

    function Config($routeProvider) {
        $routeProvider.when('/', {
            templateUrl: '/app/views/start.html',
            controller: 'StartController',
            controllerAs: 'vm'
        }).when('/create', {
            templateUrl: '/app/views/create.html',
            controller: 'CreateController',
            controllerAs: 'vm'
        });
    }

    Config.$inject = ['$routeProvider'];
})();