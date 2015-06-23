(function() {
    angular.module('FilterApp').controller('StartController', StartController);
    var vm = this;
    function StartController() {
        
        vm.message = "Start View";
        //vm.food = [
        //    { name: 'Milk', price: '2.33', dateCreated:new Date('01/05/1990') },
        //    { name: 'Marzipan', price: '2.33', dateCreated: new Date('12/15/1991') },
        //    { name: 'Mustard', price: '0.75', dateCreated: new Date('11/21/1959') },
        //    { name: 'Eggs', price: '4:75', dateCreated: new Date('12/04/1963') }
        //];
    }

    vm.fetch= function() {
        var all = [
            'Milk',
            'Marzipan',
            'Mustard',
            'Eggs'
        ];

        var search = vm.search.toLowerCase();
        vm.food = all.filter(function(item) {
            return item.toLowerCase().startsWith(search);
        });
    }

})();