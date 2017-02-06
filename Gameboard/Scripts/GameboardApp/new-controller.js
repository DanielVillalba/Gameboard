var mainApp = angular.module('GameboardApp');

mainApp.controller('NewController', function ($scope, APIService) {
    $scope.greeting = 'Enter new products data!';

    $scope.Id;
    $scope.Name;
    $scope.Description;
    $scope.AgeRestriction;
    $scope.Company;
    $scope.Price;

    $scope.saveProduct = function () {
        var newProduct = new Object();
        newProduct.Id = $scope.Id;
        newProduct.Name = $scope.Name;
        newProduct.Description = $scope.Description;
        newProduct.AgeRestriction = $scope.AgeRestriction;
        newProduct.Company = $scope.Company;
        newProduct.Price = $scope.Price;
        var serviceCall = APIService.newProduct(newProduct);
    }
});
