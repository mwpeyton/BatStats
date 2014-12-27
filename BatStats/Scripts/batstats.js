$(document).ready(function () {

    function PlayerPositionViewModel() {
        var self = this;

        self.positions = ko.observableArray(positions);
        self.selectedPosition = ko.observable();

        self.onChange = function () {
            $('.players-stats').hide();
            getPlayersByPosition(self.selectedPosition().text);
        };

        return self;
    };

    function getPlayersByPosition(position) {
        
        $.ajax({
            type: "GET",
            url: "/Home/GetPlayersByPosition",
            data: {'position': position},
            success: function (result) {
                $('#players').html('');
                $("#players").html(result);
            },
            error: function () {
                alert('error');
            }
        });
    };

    var pv = new PlayerPositionViewModel();

    ko.applyBindings(pv);
});