$(document).ready(function () {
    console.log("Hello world");

    var theForm = $("#theForm");
    theForm.hide();

    var button = $("#buyButton");
    button.on("click", function () {
        console.log("Buying item....")

    });

    var productInfo = $(".productProps li");
    productInfo.on("click", function () {
        console.log("you have clicked on" + $(this).text());
    });

    
    var $loginToggle = $("#loginToggle");
    
    var $popupForm = $(".popupForm");
    
    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(1000);
    })
    







});