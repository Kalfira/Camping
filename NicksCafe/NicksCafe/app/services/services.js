(function() {
    angular.module('NicksCafe')
        .factory('menuService', menuService)
        .factory('loginService', loginService);

    function menuService($http) {
        var token = $window.sessionStorage.getItem('token');
        var getProducts = function(callback) {
            $http.get({
                url: '/api/menu',
                headers: {'Authorization': 'Bearer '+token}
                })
                .success(function(results) {
                    callback(results);
                }).error(function() {
                    console.error('Could not retrieve products!');
                });
        };

        var addProduct = function($http, product, callback) {
            $http.post({
                    url: '/api/menu',
                    headers: { 'Authorization': 'Bearer ' + token },
                    data: product
                }).success(function(results) {
                    console.log("Successfully added!");
                    callback();
                }).error(function() {
                    console.error('Could not add the product!');
                });
        };

        return {
            getProducts: getProducts,
            addProduct: addProduct
        }
    }

    function loginService() {

        var login = function(username, password, $http, postback) {
            $http({
                url: '/Token',
                method: 'POST',
                data: 'username=' + username + '&password=' + password + '&grant_type=password',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            }).success(function(result) {
                postback(result);
            }).error(function() {
                console.log("LOGIN ERROR");
            });
        };

        return {
            login : login
        }
    }
})();