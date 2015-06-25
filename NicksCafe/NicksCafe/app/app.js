(function() {
    angular.module('NicksCafe', ['ngRoute']).config(Config);

    function Config($routeProvider) {
        $routeProvider.when('/', {
            templateUrl: '/app/views/welcome.html',
            controller: 'WelcomeController',
            controllerAs: 'vm'
        }).when('/menu', {
            templateUrl: '/app/views/menu.html',
            controller: 'MenuController',
            controllerAs: 'vm'
        }).when('/add', {
            templateUrl: '/app/views/add.html',
            controller: 'AddController',
            controllerAs: 'vm'
        }).when('/login', {
            templateUrl: '/app/views/login.html',
            controller: 'LoginController',
            controllerAs: 'vm'
            }).otherwise({
            redirectTo: '/'
        });
    }
})();