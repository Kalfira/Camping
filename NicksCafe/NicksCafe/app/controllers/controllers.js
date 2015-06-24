(function () {
    angular.module('NicksCafe')
        .controller('WelcomeController', WelcomeController)
        .controller('MenuController', MenuController)
        .controller('AddController', AddController);

    function WelcomeController() {
        var vm = this;
        vm.message = "Welcome page!";
    }

    function MenuController(menuService) {
        var vm = this;
        vm.message = "Menu page!";
        vm.menuItems = menuService.getProducts();

    }

    function AddController(menuService, $location) {
        var vm = this;
        vm.message = "Add page!";

        vm.addItem = function () {
            var product = {
                name: vm.name,
                price: vm.price,
                description: vm.description,
                isBreakfast: vm.isBreakfast ? vm.isBreakfast : false
            };
            menuService.addProduct(product);
            $location.path('/menu');

        }
    }
})();