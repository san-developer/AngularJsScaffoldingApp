angular
  .module('HomeConfigModule',
  ['HomeControllerModule'])
  .config(function ($routeProvider) {
  $routeProvider
  .when('/Home', {
    templateUrl: 'app/components/Home/Home.html',
    controller: 'HomeController'
  })
});
