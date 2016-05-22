(function () {
    'use strict';

    angular.module('app')
   .config(initrouter);

    function initrouter($stateProvider, $locationProvider, $urlRouterProvider) {
        $locationProvider.html5Mode(true);
        $urlRouterProvider.otherwise('/');
        $stateProvider
            .state(
                'home',{
                    url: '/',
                    templateUrl: 'app/home.html',
                    controller: 'HomeController',
                    controllerAs: 'vm'
                }
            )
            .state(
                'employees',{
                    url: '/employees',
                    templateUrl: 'app/employees.html',
                    controller: 'EmployeesController',
                    controllerAs: 'vm'
                }
            )
            .state(
                'create', {
                    url: '/create',
                    templateUrl: 'app/create.html',
                    controller: 'CreateController',
                    controllerAs: 'vm'
                }
            )
    }
})();