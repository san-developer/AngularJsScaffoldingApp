'use strict';

angular
  .module('app', [
    'ngRoute',
    'HomeConfigModule',
  ]).config(function ($routeProvider) {
  $routeProvider
  .when('/', {
    templateUrl: 'app/components/Home/Home.html',
    controller: 'HomeController'
  })
  .otherwise({
    redirectTo: '/'
  });
});
