angular.module('ProductsApp', ['ngRoute'])

    .controller('ProductsCtrl', function ($scope, $http) {
        $scope.getProducts = function () {
            $http.get('/api/ProductsAPI').success(function (ProductData) {
                    $scope.product = ProductData;
            });
        };
    });