(function () {
    'use strict';

    angular
        .module('app')
        .controller('EmployeesController', EmployeesController)

    EmployeesController.$inject = ['$http'];
    function EmployeesController($http) {
        var vm = this;

        vm.employees = [];

        activate();

        function activate() {
            $http.get('/api/employee')
            .then(function (response) {
                vm.employees = response.data;
            })
            .catch(function (err) {
                console.log(err);
            })
        }
    }


})();