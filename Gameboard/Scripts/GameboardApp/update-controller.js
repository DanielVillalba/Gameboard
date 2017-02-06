var mainApp = angular.module('GameboardApp');

mainApp.controller('UpdateController', function ($scope, APIService, ShareService) {
    $scope.greeting = 'Please change the values you want to update !';

    var product = ShareService.getStoredProductFromShare();
    $scope.product = product;


    $scope.updateProduct = function () {
        var serviceCall = APIService.updateProduct($scope.product);
    }

});