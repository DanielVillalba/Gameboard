var mainApp = angular.module('GameboardApp');

mainApp.controller('NewController', function ($scope, APIService) {
    $scope.greeting = 'Adding new controller!';

    var newProduct = new Object();
    newProduct.Id = 1;
    newProduct.Name = "Added";
    newProduct.Description = "Added des";
    newProduct.AgeRestriction = 1;
    newProduct.Company = "added company";
    newProduct.Price = 12.45;




    newProducts(newProduct);

    function newProducts(Data) {
        var serviceCall = APIService.newProduct(Data);
        //serviceCall.then(function (data) {
        //    console.log(data);
        //}, function (error) {
        //    console.log('something went wrong !');
        //})
    }

});



//var TestCtrl = function ($scope, $http) {

//    $scope.SendData = function (Data) {
//        var GetAll = new Object();
//        GetAll.FirstName = Data.firstName;
//        GetAll.SecondName = Data.lastName;
//        GetAll.SecondGet = new Object();
//        GetAll.SecondGet.Mobile = Data.mobile;
//        GetAll.SecondGet.EmailId = Data.email;
//        $http({
//            url: "NewRoute/firstCall",
//            dataType: 'json',
//            method: 'POST',
//            data: GetAll,
//            headers: {
//                "Content-Type": "application/json"
//            }
//        }).success(function (response) {
//            $scope.value = response;
//        })
//           .error(function (error) {
//               alert(error);
//           });
//    }
//};