
console.log("helloooo2222");

$(function () {
    console.log("helloooo")
    let cluster_id = "";

    $('#cluster').change(function () {
        cluster_id = $('#cluster').val();
        let items = '';

        $.ajax({
            type: "GET",
            url: "/Cluster/GetEstateByClusterId",
            data: { clusterId: cluster_id },
            dataType: "json",
            success: function (data) {
                $.each(data, function (k, option) {
                    items += "<option value = '" + option.value + "'>" + option.text + " </option>";
                });
                $('#estate').html(items);
            }
        });
    });

    $('#estate').change(function () {
        estate_id = $('#estate').val();
        let items = '';
        $('#unit').empty();
        $.ajax({
            type: "GET",
            url: "/Cluster/GetUnitByEstateId",
            data: { estateId: estate_id },
            dataType: "json",
            success: function (data) {
                $.each(data, function (k, option) {
                    items += "<option value = '" + option.value + "'>" + option.text + " </option>";
                });
                $('#unit').html(items);
            }
        });
    });




});



