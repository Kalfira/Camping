(function () {
    angular.module('NicksCafe')
        .controller('WelcomeController', WelcomeController)
        .controller('AddController', ['$window', AddController])
        .controller('MenuController', ['$window', '$rootScope', 'menuService', MenuController])
        .controller('LoginController', ['$window', LoginController]);

    function WelcomeController() {
        var vm = this;
        vm.message = "Welcome page!";
    }

    function MenuController($window, $rootScope, menuService) {
        var vm = this;
        vm.message = "Menu page!";
        function getResults (result) {
            vm.menuItems = result;
        }

        console.log(menuService);
        menuService.getProducts(getResults);

    }


    function AddController(menuService, $location, $http) {
        var vm = this;
        vm.message = "Add page!";
        vm.isPosting = false;

        vm.addItem = function () {
            vm.isPosting = true;
            var product = {
                name: vm.name,
                price: vm.price,
                description: vm.description,
                isBreakfast: vm.isBreakfast ? vm.isBreakfast : false
            };
            function Reload() {
                $location.path('/menu');
                vm.isPosting = false;
            }
            menuService.addProduct($http, product, Reload);

        }
    }

    function LoginController(loginService, $http) {
        var vm = this;
        function Postback(result) {
            $window.sessionStorage.setItem('token', result.access_token);
        }
        vm.login= function() {
            loginService.login(vm.username, vm.password, $http, Postback);
        }
    }
})();