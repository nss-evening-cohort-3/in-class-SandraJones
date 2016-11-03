var app = angular.module("BasicsOfForms", []);

app.controller("FormController",  function ($scope) {


    $scope.formSubmit = function (event) {

        //alert("Form Submit Called!");
        
        var form = $("#myform").serialize();
        console.log(form)

        event.preventDefault();
    };
});