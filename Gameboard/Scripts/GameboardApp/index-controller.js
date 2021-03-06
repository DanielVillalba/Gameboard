﻿var mainApp = angular.module('GameboardApp');

mainApp.controller('IndexController', function ($scope, APIService, ShareService) {
    $scope.greeting = 'Hola!';
    getProducts();

    function getProducts()
    {
        var serviceCall = APIService.getProducts();
        serviceCall.then(function (data)
        {
            $scope.products = angular.fromJson(data.data);
        }, function (error)
        {
            console.log('something went wrong !');
        })
    }


    $scope.edit = function (id, name, desc, age, com, price) {
        //console.log("Edit " + id);
        //console.log("Edit " + name);
        //console.log("Edit " + desc);
        //console.log("Edit " + age);
        //console.log("Edit " + com);
        //console.log("Edit " + price);
        var productToEdit =
        {
            Id: id,
            Name: name,
            Description: desc,
            AgeRestriction: age,
            Company: com,
            Price: price
        }
        ShareService.storeProductToShare(productToEdit);
    }
    $scope.delete = function (id, name, desc, age, com, price) {
        //console.log("Delete " + id);
        //console.log("Delete " + name);
        //console.log("Delete " + desc);
        //console.log("Delete " + age);
        //console.log("Delete " + com);
        //console.log("Delete " + price);
        var productToEdit =
        {
            Id: id,
            Name: name,
            Description: desc,
            AgeRestriction: age,
            Company: com,
            Price: price
        }
        ShareService.storeProductToShare(productToEdit);
    }

});



