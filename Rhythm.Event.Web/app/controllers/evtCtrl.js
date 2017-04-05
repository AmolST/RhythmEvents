app.controller("eventController", function ($scope, eventService) {
    $scope.events = eventService.getEvents();
 });