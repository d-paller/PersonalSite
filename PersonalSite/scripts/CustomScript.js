
// Doc ready
$(function () {

    $('#resume-btn').click(function () {
        ResumeView();
    }); // Google

    $("#bridge-btn").click(function () {
        $("#bridge")
            .css('opacity', 0)
            .slideDown(1000)
            .animate(
            { opacity: 1 }, { queue: false, duration: 2000 });
    });

    InjectPhone();
    InjectEmail();
    $('#hide-btn').click(function () {
        $('#hidden-box').fadeOut(500);
    });


}); // doc ready

// ----- Methods -----

// Inject Phone #
function InjectPhone() {
    $('#phone').click(function () {
        $('#hidden-box').fadeIn('slow');
        $('#hidden-content').text("Phone number: (469)237-9635");
        
    });
}//get phone

// Inject Email
function InjectEmail() {
    $('#email').click(function () {
        $('#hidden-box').fadeIn('slow');
        $('#hidden-content').text("Email: dpaller94@gmail.com");
        $('#hidden-content').children('a').attr("href", "mailto:dpaller94@gmail.com");
        
    });
}//get email

