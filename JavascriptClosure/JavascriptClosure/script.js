'use strict';

var buttons = document.getElementsByTagName('button');

addClickHandlers(buttons);

function addClickHandlers(buttons) {
    for (var i = 0; i < buttons.length; i++) {
        addClickHandler(i);
    }
}

function addClickHandler(index) {
    buttons[index].addEventListener('click', function() {
        alert('You clicked button ' + buttons[index].innerHTML);
    });
}