app.service('APIService', function ($http) {
    this.getProducts = function () {
        return $http.get("../api/ProductsAPI")
    }

    this.newProduct = function (newData) {
        $http({
            url: "../api/ProductsAPI",
            dataType: 'json',
            method: 'POST',
            data: newData,
            headers: {
                "Content-Type": "application/json"
            }
        })
        .then(function (data) {
            console.log(data);
        }, function (error) {
            console.log('something went wrong !');
        })
    }
});