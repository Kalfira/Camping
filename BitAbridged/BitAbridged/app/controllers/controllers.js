(function() {
    'use strict';
    angular.module('BitAbridged')
        .controller('StartController', ['languageService', startController])
        .controller("DetailsController", ['detailsService', '$routeParams', detailsController])
        .controller('AddController', ['addService', '$location', addController])
        .controller('LoginController', ['authService', '$location', loginController])
        .controller('LogoutController', ['authService', logoutController]);

    function startController(languageService) {
        var vm = this;
        vm.message = 'Welcome Page';
        languageService.getLanguages().then(function(languages) {
            vm.languages = languages;
        }, function() {
            
        });
    }

    function detailsController(detailsService, $routeParams) {
        var vm = this;
        vm.message = 'Details Page';
        detailsService.getDetails($routeParams.id).then(function(details) {
            vm.fact1 = details[0].Fact1;
            vm.fact2 = details[0].Fact2;
        });
    }

    function addController(addService, $location) {
        var vm = this;
        vm.message = 'Add Page';
        vm.isLoading = false;

        vm.addLanguage = function () {
            vm.isLoading = true;
            var language = { name: vm.name };
            addService.addLanguage(language).then(redirectToStart());
        };

        function redirectToStart() {
            vm.isLoading = false;
            $location.path('/');
        }

    }

    function loginController(authService, $location){
        var vm = this;

        vm.login = function() {
            authService.login(vm.username, vm.password).then(loginSuccess, loginFail);
        }

        function loginSuccess() {
            $location.path('/');
        }

        function loginFail() {
            console.log("Login Failed!");
        }
    }

    function logoutController(authService) {
        authService.logout();
    }

})();