'use strict';

function Product(name, price) {
    this._name = name;
    this._price = price;
}

Product.prototype = {
    calculateTax: function() {
        return this._price;
    }
}

var product1 = new Product("Milk", 2.33);
var product2 = new Product("Cheese", 4.33);