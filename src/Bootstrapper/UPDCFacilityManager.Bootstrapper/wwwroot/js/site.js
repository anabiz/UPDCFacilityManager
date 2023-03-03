
$(function () {

    $("#global-search-submit").on("click", function () {
        const url_param = window.location.pathname.trim();
        document.getElementById("global-search").action = url_param;
        document.getElementById("global-search").submit();
    });

});



