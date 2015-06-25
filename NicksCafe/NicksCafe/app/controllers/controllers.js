(function () {
    angular.module('NicksCafe')
        .controller('WelcomeController', WelcomeController)
        .controller('AddController', AddController)
        .controller('MenuController',  MenuController);

    function WelcomeController() {
        var vm = this;
        vm.message = "Welcome page!";
    }

    function MenuController($http, menuService) {
        var vm = this;
        vm.message = "Menu page!";
        function getResults (result) {
            console.log(result);
            vm.menuItems = result;
        }
        menuService.getProducts($http, getResults);

    }


    function AddController(menuService, $location, $http) {
        var vm = this;
        vm.message = "Add page!";

        vm.addItem = function () {
            var product = {
                name: vm.name,
                price: vm.price,
                description: vm.description,
                isBreakfast: vm.isBreakfast ? vm.isBreakfast : false
            };
            var thing = $http;
            function Reload() {
                $location.path('/menu');
            }
            menuService.addProduct($http, product, Reload);

        }
    }
})();