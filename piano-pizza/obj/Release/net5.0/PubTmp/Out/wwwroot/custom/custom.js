$(function () {
    setTimeout(function(){
        $(".customloader").fadeOut("slow");
    },2000);
    var scroll2 = $(window).scrollTop();
    if(scroll2 >= ($('.works-list').offset().top -250)){
        $('[data-aos="fade"]').addClass('aos-animate');
    }
    $(window).scroll(function() {    
        var scroll = $(window).scrollTop();
        if (scroll >= 1) {
            $("#header").addClass("hide-on-scroll");
        }

        $('[data-aos="fade"]').addClass('aos-animate',
          scroll >= $('.works-list').offset().top +200
        );
    }); 
})
var n = "rtl" === $("html").attr("data-textdirection");
function ShowToast(message, code) {
    if (code == "error") {
        return toastr.error("", message, { closeButton: !0, tapToDismiss: !1 });
    }
    if (code == "success") {
        return toastr.success("", message, { closeButton: !0, tapToDismiss: !1 });
    }
    if (code == "warning") {
        return toastr.warning("", message, { closeButton: !0, tapToDismiss: !1 });
    }
    if (code == "info") {
        return toastr.info("", message, { closeButton: !0, tapToDismiss: !1 });
    }
}
function RemoveItem() {
    toastr.error("", "Removed Item 🗑️", { closeButton: !0, tapToDismiss: !1 });
}