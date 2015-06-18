'use strict';

var thingA = {
    toString:function() {
        return 'thingA';
    },
    _count:0
}
var thingB = {
    toString: function () {
        return 'thingB';
    },
    _count: 0
}

var addOne = function() {
    this._count++;
    console.log(`${this} has the count ${this._count}`);
}