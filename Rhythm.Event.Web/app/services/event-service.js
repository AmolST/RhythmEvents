eventApp.service('eventService', function ($http) {
    this.getEvents = function () {
        $http.get("http://localhost:50451/api/Event").then(function(response) {
            return JSON.parse(response.data);
        });
    };
});