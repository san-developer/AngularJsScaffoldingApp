angular
  .module('{{ComponentName}}ConfigModule',
  ['{{ComponentName}}ControllerModule'])
  .config(function ($stateProvider, $urlRouterProvider) {
	 $stateProvider
	  .state('{{ComponentState}}', {
	      url: '/{{ComponentUrl}}',
	    templateUrl: 'app/components/{{ComponentPath}}/{{ComponentName}}.html',
	    controller: '{{ComponentName}}Controller'
	  })
});
