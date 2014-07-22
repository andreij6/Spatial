//(function () {
//    
//});

myApp = angular.module('myApp', []);

myApp.controller('ChatCtrl', function ($scope) {
    $scope.Message = "";
    $scope.Messages = [];

    var Hub = $.connection.spatialHub;

    //$.connection.hub.logging = true;

    $.connection.hub.start();

    Hub.client.newMessage = function (message) {
        $scope.$apply(function (){
            $scope.Messages.push(message);
        })
    }

    $scope.sendMessage = function () {
        Hub.server.send($scope.Message);
        $scope.Message = "";
    }
        
    //$scope.addMessage = function (message) {
    //    $scope.Messages.push(message);
    //}

});