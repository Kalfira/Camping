(function() {
    angular.module('NicksCafe').factory('menuService', menuService);

    function menuService() {

        var getProducts = function($http, callback) {
            $http.get('/api/menu')
                .success(function(results) {
                    callback(results);
                }).error(function() {
                    console.error('Could not retrieve products!');
                });
        };

        var addProduct = function($http, product, callback) {
            $http.post('/api/menu', product)
                .success(function(results) {
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
})();