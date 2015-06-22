(function() {
    angular.module('MyApp', [])
        .controller('FavoriteController', function() {
            //defualt
            this.color = "green";

            //change color
            this.pickColor = function(color) {
                this.color = color;
                document.getElementById("result").style.backgroundColor = color;
            }
        });
})();