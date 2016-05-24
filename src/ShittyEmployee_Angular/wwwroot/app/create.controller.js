(function () {
    'use strict';

    angular
        .module('app')
        .controller('CreateController', CreateController);

    function CreateController($scope, $http) {
        var vm = this;
        $scope.submitForm = function () {
            /*while compiling form, angular created this object*/
            var employee = $scope.employee;
            /*post to SQL*/
            $http.post("/api/employee", employee);
        }

        activate();

        function activate() { }
    }
})();