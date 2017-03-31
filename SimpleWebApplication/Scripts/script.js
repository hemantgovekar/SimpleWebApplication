/// <reference path="angular.js" />

var url = "http://localhost:3606/api/employee/"
var myApp = angular.module("myApp", []);

var MainController = function ($scope, $http) {

    var onSucess = function (response) { $scope.employees = response.data };

    var onFailure = function (reason) { $scope.error = reason };

    var getAllEmployees = function () {
        $http.get(url)
        .then(onSucess, onFailure)
    };

    getAllEmployees();

};

myApp.controller("MainController", MainController);