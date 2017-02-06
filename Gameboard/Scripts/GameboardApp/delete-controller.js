var mainApp = angular.module('GameboardApp');

mainApp.controller('DeleteController', function ($scope, APIService, ShareService) {
    $scope.greeting = 'Are you sure you want to delete this product?';

    var product = ShareService.getStoredProductFromShare();

    console.log('from DeleteController.. ' + product.Id);
    console.log('from DeleteController.. ' + product.Name);
    console.log('from DeleteController.. ' + product.Description);
    console.log('from DeleteController.. ' + product.AgeRestriction);
    console.log('from DeleteController.. ' + product.Company);
    console.log('from DeleteController.. ' + product.Price);

    $scope.product = product;


    $scope.deleteProduct = function () {
        var serviceCall = APIService.deleteProduct(product.Id);
    }

});