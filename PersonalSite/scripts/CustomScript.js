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
});


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
});