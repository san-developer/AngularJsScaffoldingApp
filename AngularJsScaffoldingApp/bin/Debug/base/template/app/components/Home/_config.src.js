angular
  .module('HomeConfigModule',
  ['HomeControllerModule'])
  .config(function ($stateProvider, $urlRouterProvider) {
	 $stateProvider
	  .state('Home', {
	    url : '/',
	    templateUrl: 'app/components/Home/Home.html',
	    controller: 'HomeController'
	  })
});
