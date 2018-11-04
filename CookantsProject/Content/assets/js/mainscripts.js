;(function($) {
	$('.chef-carousel').owlCarousel({
    loop:true,
    autoplay:true,
    autoplayTimeout:1000,
    margin:10,
    nav:true,
    navText: ["<i class='mdi mdi-chevron-left'></i>","<i class='mdi mdi-chevron-right'></i>"],
    responsive:{
        0:{
            items:1
        },
        600:{
            items:3
        },
        1000:{
            items:5
        }
    }
});
    $('.investors-carousel').owlCarousel({
        loop:false,
        margin:10,
        nav:true,
        navText: ["<i class='mdi mdi-chevron-left'></i>","<i class='mdi mdi-chevron-right'></i>"],
        responsive:{
            0:{
                items:1
            },
            600:{
                items:3
            },
            1000:{
                items:5
            }
        }
    });
    $('.calendar').owlCarousel({
        loop:false,
        nav:true,
        navText: ["<i class='mdi mdi-chevron-left'></i>","<i class='mdi mdi-chevron-right'></i>"],
        items: 7
    });
        $('.tesimonials-carousel').owlCarousel({
        loop:false,
        items: 1,
        dotsEach: true
    });

	// select 2 -----------------------
	$('.food').select2({
		placeholder: "Food Choice",
	});
	$('.city').select2({
		placeholder: "city",
	});
	$('.location').select2({
        placeholder: "location",
    });

    //Cart-list ------------------------
    $('.floating-cart-list').hide();
    $('.floating-cart-btn').on('click', function(){
        $(this).hide();
        $('.floating-cart-list').show();
    });
    $('.floating-cart-list .close').on('click', function(){
        $('.floating-cart-btn').show();
        $('.floating-cart-list').hide();
    });
    $('.cart-cancel a').on('click', function(){
        $(this).parent('li.cart-item').remove();
    });
	
})(jQuery);