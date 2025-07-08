$(document).ready(function () {
    // Initially hide all accordion bodies
    $(".accordion-body").hide();

    // Handle all toggle buttons
    $("#accordionContainer").on("click", "#toggleAccordionBtn", function () {
        const $button = $(this);
        const $body = $button.closest(".accordion-header").next(".accordion-body");
        if ($body.is(":visible")) {
            $body.slideUp();
        } else {
            $(".accordion-body").slideUp(); 
            $body.slideDown();
        }
    });
});
