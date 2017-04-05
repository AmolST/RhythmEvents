app.service('eventService', function ($http,$location) {
    this.getEvents = function () {
        $http.get("http://localhost:50451/api/Event").then(function (response) {
            return JSON.parse(response.data);
        })
    };
});