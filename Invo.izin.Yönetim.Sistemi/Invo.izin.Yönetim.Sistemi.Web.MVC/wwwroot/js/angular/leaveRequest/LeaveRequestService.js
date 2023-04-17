var app = angular.module("LeaveRequestApp", []);


app.controller("LeaveRequestController", function ($scope, $http) {

    $scope.btntext = 'Kaydet';
  
    $scope.leaveRequest = {};
    $scope.leaveTypes = {};

    $scope.leaveRequest.EmployeeId = 1;
    $scope.leaveRequest.LeaveTime = 1;
    $scope.leaveRequest.IsApproved = false;
    $scope.leaveRequest.Status = "Beklemede";

    $scope.leaveRequestList = {};

    console.log($scope.leaveRequest);
    $scope.SaveLeaveRequest = function () {
   

        $scope.btntext = "Lütfen Bekleyiniz...!";
        
   
        $http({

            method: 'POST',

            url: 'https://localhost:7241/api/LeaveRequest',
            
            data: JSON.stringify($scope.leaveRequest),

        }).then(function (response) {

            $scope.btntext = "Kaydet";

            $scope.leaveRequest = null;

            console.log(response);

            alert('Kayıt Başarılı...!');

        }, function (error) {

            alert('Hata');

        });



    }

    $http({
        method: "GET",
        dataType: 'json',
        headers: {
            "Content-Type": "application/json"
        },
        url: "https://localhost:7241/api/LeaveType/LeaveTypeSelectList"
    }).then(function (response) {
        $scope.leaveTypes = response.data;

    }, function () {
        alert("İzin Tipleri Çekilirken Hata Oluştu!");
    })


    $http({
        method: "GET",
        dataType: 'json',
        headers: {
            "Content-Type": "application/json"
        },
        url: "https://localhost:7241/api/LeaveRequest"
    }).then(function (response) {
        $scope.leaveRequestList = response.data;

    }, function () {
        alert("İzin Listesi Çekilirken Hata Oluştu!");
    })


    $scope.ChangeApproved = function (id){


        $scope.btntext = "Lütfen Bekleyiniz...!";


        $http({

            method: 'POST',

            url: 'https://localhost:7241/api/LeaveRequest',

            data: JSON.stringify($scope.leaveRequest),

        }).then(function (response) {

            $scope.btntext = "Kaydet";

            $scope.leaveRequest = null;

            console.log(response);

            alert('Kayıt Başarılı...!');

        }, function (error) {

            alert('Hata');

        });

    }

});



