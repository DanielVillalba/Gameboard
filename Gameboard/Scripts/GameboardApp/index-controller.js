var mainApp = angular.module('GameboardApp');

mainApp.controller('IndexController', function ($scope, APIService) {
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

});

app.service('APIService', function ($http)
{
    this.getProducts = function ()
    {
        return $http.get("../api/ProductsAPI")
    }
});

