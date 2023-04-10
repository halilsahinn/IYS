"use strict";

var app = angular.module("EmployeeApp", []);


app.controller("EmployeeController", function ($scope, $http) {

    $scope.employees = [];
    $scope.departments = [];
    $scope.employeeTitle = [];
    $scope.branchOffice = [];
    $scope.users = [];
    $scope.employee = {};
      



    $scope.GetEmployeeList = function () {
        $http({
            method: "GET",
            dataType: 'json',
            headers: {
                "Content-Type": "application/json"
            },
            url: "https://localhost:7241/api/Employee/EmployeeList"
        }).then(function (response) {
            $scope.employees = response.data;

        }, function () {
            alert("Çalışan Listesi Çekilirken Hata Oluştu!");
        })
    };

    $http({
        method: "GET",
        dataType: 'json',
        headers: {
            "Content-Type": "application/json"
        },
        url: "https://localhost:7241/api/Department/DepartmentSelectList"
    }).then(function (response) {
        $scope.departments = response.data;

    }, function () {
        alert("Departman Listesi Çekilirken Hata Oluştu!");
    })


    $http({
        method: "GET",
        dataType: 'json',
        headers: {
            "Content-Type": "application/json"
        },
        url: "https://localhost:7241/api/EmployeeTitle/EmployeeTitleSelectList"
    }).then(function (response) {
        $scope.employeeTitle = response.data;

    }, function () {
        alert("Ünvan Listesi Çekilirken Hata Oluştu!");
    })

    $http({
        method: "GET",
        dataType: 'json',
        headers: {
            "Content-Type": "application/json"
        },
        url: "  https://localhost:7241/api/BranchOffice/BranchOfficeSelectList"
    }).then(function (response) {
        $scope.branchOffice = response.data;

    }, function () {
        alert("Şube Listesi Çekilirken Hata Oluştu!");
    })

    $http({
        method: "GET",
        dataType: 'json',
        headers: {
            "Content-Type": "application/json"
        },
        url: "https://localhost:7241/api/User/UserSelectList"
    }).then(function (response) {
        $scope.users = response.data;

    }, function () {
        alert("Kullanıcı Listesi Çekilirken Hata Oluştu!");
    })

 
 


    $scope.btntext = "Kaydet";

    $scope.SaveEmployee = function () {

        $scope.btntext = "Lütfen Bekleyiniz...!";

        $http({

            method: 'POST',

            url: 'https://localhost:7241/api/Employee',

            data: JSON.stringify($scope.employee),

        }).then(function (response) {

            $scope.btntext = "Kaydet";

            $scope.employee = null;

            alert('Kayıt Başarılı...!');

        }, function (error) {

            alert('Hata');

        });

         

    }



});



