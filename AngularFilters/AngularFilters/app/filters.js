(function() {
    angular.module('FilterApp').filter('startsWith', startsWith);

    function startsWith() {
        return function(input, expression) {
            expression = expression.toLowerCase();
            return input.filter(function(item) {
                return item.toLowerCase().startsWith(expression);
            })
        }
    }
})();