var app = angular.module("BasicsOfForms", []);

app.controller("BasicsController", function ($scope) {
    $scope.formSubmit = function (event) {
        console.log("form");
    };
});