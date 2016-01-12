$(document).ready(function () {
    $("#refresh_btn").click(function () {
        refreshpage();
    });
});

function refreshpage() {
    location.reload(true);
};