'use strict';
angular
.module('app')
.config(function ($routeProvider) {
  $routeProvider
  .when('/', {
    templateUrl: 'app/components/home/home.html',
    controller: 'HomeController'
  })
  .otherwise({
    redirectTo: '/'
  });
});
