angular
  .module('HomeControllerModule', [])
  .controller("HomeController",  ['$scope', function($scope) {

    $scope.msg = "Home";

  }]);