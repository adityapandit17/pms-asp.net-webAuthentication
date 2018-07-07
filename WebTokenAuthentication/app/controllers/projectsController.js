'use strict';
app.controller('projectsController', function ($scope, $http) {

    $scope.Val = {
        Name: "",
        Description: "",
        Due_date: "",
        status: ""
    };

    $scope.AddProject = function (data) {
        var info =
            {
                Name: $scope.data.Name,
                Description: $scope.data.Description,
                Due_date: $scope.data.Due_date,
                status: $scope.data.status
            }
        $http.post("http://localhost:51514/api/Projects", info).then(function (response) {
            console.log(response);
        });
    }


    $http.get("http://localhost:51514/api/Projects").then(function (response) {
        console.log(response);
        debugger;
        $scope.Data = response.data;
    });


    $scope.DeleteProject = function (data) {
        id = data.ProjectId;
        $http.delete("http://localhost:51514/api/Projects/" + id).then(function (response) {
            console.log(response);
        });


    }



});