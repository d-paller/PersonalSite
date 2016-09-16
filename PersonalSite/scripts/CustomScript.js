//Get Elevator code
$.getScript("elevator.js-master/elevator.js", function () {

})


//Set page height to window height
$(document).ready(function () {
    function setHeight() {
        windowHeight = $(window).innerHeight();
        $('.page-div').css('min-height', windowHeight);
    };
    setHeight();

    $(window).resize(function () {
        setHeight();
    });
});

//set top page margin to height of navbar

$(document).ready(function () {
    function setMargin() {
        navbarHeight = $('.navbar').height();
        $('.page-div').css('padding-top', navbarHeight + 15);
    };
    setMargin();

    $('.navbar').resize(function () {
        setHeight();
    });
});