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