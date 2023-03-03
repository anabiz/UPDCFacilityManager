
$(function () {

    $("body").on('click', '#btnEdit', function () {
        $("#MyPopup").modal("hide");
        const id = $(this).attr('data-id');
        $.ajax({
            url: `Edit/${id}`,
            type: 'GET',
            dataType: 'html',
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                var id = JSON.parse(response).Id;
                var name = JSON.parse(response).FirstName;
                var country = JSON.parse(response).LastName;
                $('#txtId').val(id);
                $('#txtName').val(name);
                $('#txtCountry').val(country);
                $("#MyPopup").modal("show");
            }
        });
    });

});



