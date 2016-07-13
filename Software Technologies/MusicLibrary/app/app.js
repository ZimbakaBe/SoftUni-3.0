'use strict';

// Declare app level module which depends on views, and components
angular.module('MusicLibrary', [
  'ngRoute',
  'ngCookies',
  'angular.filter'
])
    .config(['$routeProvider', function($routeProvider) {
  $routeProvider.otherwise({redirectTo: '/#'});

}])
    .constant('BASE_URL', 'http://softuni-issue-tracker.azurewebsites.net/');
