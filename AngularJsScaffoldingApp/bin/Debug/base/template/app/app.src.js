'use strict';

angular
  .module('app', [
    'ui.router',
    'HomeConfigModule',
  ]).config(function ($urlRouterProvider) {
   $urlRouterProvider.otherwise("/");
});
