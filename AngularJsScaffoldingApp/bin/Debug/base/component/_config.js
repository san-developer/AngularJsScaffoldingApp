angular
  .module('{{ComponentName}}ConfigModule',
  ['{{ComponentName}}ControllerModule'])
  .config(function ($routeProvider) {
  $routeProvider
  .when('/{{ComponentName}}', {
    templateUrl: 'app/components/{{ComponentName}}/{{ComponentName}}.html',
    controller: '{{ComponentName}}Controller'
  })
});
