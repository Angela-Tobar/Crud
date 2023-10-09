// script.js
$(document).ready(function() {
    $("a").click(function(event) {
        event.preventDefault();
        var pageToLoad = $(this).attr("href");
        $("#content").load(pageToLoad);
    });
});

