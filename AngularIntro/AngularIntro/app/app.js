(function () {
    'use strict';

    angular.module('MovieApp', [])
        .controller('MovieListController', function () {
            this.movies = [
                { id: 1, title: 'Batman', director: 'Nolan' },
                { id: 2, title: 'Superman', director: 'Scott' },
                { id: 3, title: 'Spiderman', director: 'Wells' }
            ];
        });
})
();