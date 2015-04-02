angular
  .module('{{ComponentName}}ConfigModule',
  ['{{ComponentName}}ControllerModule'])
  .config(function ($stateProvider, $urlRouterProvider) {
	 $stateProvider
	  .state('{{ComponentName}}', {
	    url : '/{{ComponentName}}',
	    templateUrl: 'app/components/{{ComponentName}}/{{ComponentName}}.html',
	    controller: '{{ComponentName}}Controller'
	  })
});
