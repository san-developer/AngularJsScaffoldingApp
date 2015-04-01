angular
  .module('{{ComponentName}}ControllerModule', [])
  .controller("{{ComponentName}}Controller",  ['$scope', function($scope) {

    $scope.yes = "{{ComponentName}}";

  }]);