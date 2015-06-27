(function() {
    'use strict';
    angular.module('BitAbridged')
        .controller('StartController', ['startService', startController])
        .controller("DetailsController", detailsController)

    function startController(startService) {
        var vm = this;
        vm.message = 'Welcome Page';
        console.log(startService);
        startService.getLanguages().then(function(languages) {
            vm.languages = languages;
        }, function() {
            
        });
    }

    function detailsController() {
        var vm = this;

        vm.message = 'Details Page';
    }
})();