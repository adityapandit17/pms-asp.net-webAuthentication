'use strict';
app.factory('projectsService', ['$http', function ($http) {

    var serviceBase = 'http://localhost:51514/';
    var projectsServiceFactory = {};

    var _getProjects = function () {

        return $http.get(serviceBase + 'api/Projects').then(function (results) {
            return results;
        });
    };

    projectsServiceFactory.getprojects = _getProjects;

    return projectsServiceFactory;

}]);