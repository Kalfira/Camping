(function () {
    angular.module('MyApp')
        .controller('StartController', StartController)
        .controller('CreateController', CreateController);

    function StartController($http) {
        var vm = this;

        vm.fetch = function () {
            if (vm.search) {
                $http.get('/api/food' + vm.search)
                    .success(function (results) {
                        vm.items = results;
                    })
                    .error(function () {
                        console.error('Could not retrieve food!');
                    });
            }
        }
    }

    StartController.$inject = ['$http'];

    function CreateController($http) {
        var vm = this;
        vm.add = add;

        function add() {
            var food = { name: vm.name };
            $http.post('/api/food', food)
                .success(function(id) {
                    console.log(id);
                }).error(function(data) {
                    console.log(data);
                });
        }
    }
    CreateController.$inject = ['$http'];
})();