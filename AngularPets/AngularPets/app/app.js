(function() {
    'use strict';

    angular.module('PetsApp', [])
        .controller('PetsController', function() {
            this.dogs = [
                { id: 1, name: 'Stormy', picture: 'images/stormy.jpg' },
                { id: 2, name: 'Goldey', picture: 'images/goldey.jpg' },
                { id: 3, name: 'Smartey', picture: 'images/smartey.jpg' }
            ];
            this.bunnies = [
                { id: 1, name: 'Peter', picture: 'images/peter.png' }
            ];
        });
})();