

var country_id="";
$(document).ready(function () {
    
    $('#cluster').change(function () {
        console.log("solemonnnn");

        country_id = $('#Country').val();
        var items = '';

        $.ajax({
            type: "POST",
            url: "/Inventory/GetState",
            data: { countryid: country_id },
            dataType: "json",
            success: function (data) {
                $.each(data, function (k, option) {
                    items += "<option value = '" + option.stateId + "'>" + option.stateName + " </option>";
                });
                $('#State').html(items);
            }
        });
    });

    $('#State').change(function () {
        state_id = $('#State').val();
            var items = '';
            $('#City').empty();
            $.ajax({
                type: "POST",
            url: "/Inventory/GetCity",
            data: {stateid: state_id },
            dataType: "json",
            success: function (data) {
                $.each(data, function (k, option) {
                    items += "<option value = '" + option.cityId + "'>" + option.cityName + " </option>";
                });
            $('#City').html(items);
            }
        });
    });
});