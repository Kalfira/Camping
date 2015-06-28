(function() {
    'use strict';
    angular.module('BitAbridged')
        .controller('StartController', ['languageService', startController])
        .controller("DetailsController", ['detailsService', '$routeParams', detailsController]);

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
        }, function() {
            
        });
    }

})();