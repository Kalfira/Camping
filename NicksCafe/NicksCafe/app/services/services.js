(function() {
    angular.module('NicksCafe').factory('menuService', menuService);

    function menuService() {
        var products = [
            {
                name: "Banana",
                price: .75,
                description: "Comes high in potassium!",
                isBreakfast: true
            }
        ];

        var getProducts = function() {
            return products;
        };

        var addProduct = function(product) {
            products.push(product);
        };

        return {
            getProducts: getProducts,
            addProduct: addProduct
        }
    }
})();