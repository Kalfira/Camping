'use strict';

var module = (function () {
    //private methods
    function _calculatePrice(price) {
        return price + _calculateTax(price);
    }

    function _calculateTax(price) {
        return price * .08;
    }
    //exports
    return {
        calculatePrice : _calculatePrice
    }
})();

var price = module.calculatePrice(45.99);
var body = document.getElementById("body");
body.innerHTML = price;