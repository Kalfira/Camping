(function() {
    angular.module('Calc', [])
        .controller('CalcController', function($scope) {
            $scope.Sum = function () {
                $scope.result = parseInt($scope.first) + parseInt($scope.second);
            }
        });
})();