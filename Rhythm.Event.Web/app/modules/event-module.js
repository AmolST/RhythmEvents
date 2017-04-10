var eventApp = angular.module("eventApp", ["ngRoute"]);

eventApp.config(function ($routeProvider) {
    $routeProvider.when("/events", { template: "<h1>Reached to events</h1>" });
});