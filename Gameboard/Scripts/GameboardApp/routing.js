var mainApp = angular.module('GameboardApp');

mainApp.config(function ($routeProvider) {
    $routeProvider
    .when("/", {
        templateUrl: "/Templates/AllProducts.html",
        controller: "IndexController"
    })
    .when("/newTest", {
        templateUrl: "/Templates/AddNewProduct.html"
    })
    .when("/blue", {
        templateUrl: "blue.htm"
    });


});


