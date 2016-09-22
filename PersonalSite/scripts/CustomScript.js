//Set page height to window height
$(document).ready(function () {
    function setHeight() {
        windowHeight = $(window).height();
        $('.page-div').css('min-height', windowHeight - $('.footer').height());
        //window.alert("Window Height is " + windowHeight
        //    + "\nThe ");
    };
    
    setHeight();

    $(window).resize(function () {
        setHeight();
    });
}());


// Set pdf view to Height and Width of page

$(document).ready(
    function () {
        function setDim() {
            var pageHeight = $(window).height();
            $('#resume').css('min-height', pageHeight - $('.footer').height());

            var pageWidth = $(window).width();
            $('.pdfView').css('min-width', pageWidth);

            $('.pdfView').css('min-height', $('#resume').height() - $('.download-btn').height() - $('.footer').height());
        };

        setDim();

        $(window).resize(function () {
            setDim();
        });
    }());

// .active menu animation
// NOT IMPLIMENTED CORRECTLY

//$(document).ready(
//    function () {
//        function activeMenuAnimation() {
//            $('.active').hover(function(){$(this).toggleClass('menu-active')});
//            };
//            activeMenuAnimation();
//    }());


// Get Phone number and email
$(document).ready(

    function getPhone() {
        $('#phone').click(function () {
            alert("Phone number: (469)237-9635");
        });
    }(),//get phone

    function getEmail(){
        $('#email').click(function () {
            alert("Email: dpaller94@gmail.com");
        });
    }()//get email

    );//ready
    
    