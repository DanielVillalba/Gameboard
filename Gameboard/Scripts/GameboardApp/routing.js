var mainApp = angular.module('GameboardApp');

mainApp.config(function ($routeProvider) {
    $routeProvider
    .when("/", {
        templateUrl: "/Templates/AllProducts.html",
        controller: "IndexController"
    })
    .when("/newTest", {
        templateUrl: "/Templates/AddNewProduct.html",
        controller: "NewController"
    })
    .when("/updateProduct", {
        templateUrl: "/Templates/UpdateProduct.html"
    })
    .when("/deleteProduct", {
        templateUrl: "/Templates/DeleteProduct.html",
        controller: "DeleteController"
    });


});


