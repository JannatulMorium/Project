  $('#carousel-example-generic').carousel({
    interval: 2000
});



$(window).enllax();


$('.succes-slider').slick({
        slidesToShow: 3,
        dots: false,
        infinite: true,
        prevArrow: '.controler .pre',
        nextArrow: '.controler .next',
        autoplay: true,
        responsive: [
            {
                breakpoint: 768,
                settings: {
                    slidesToShow: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1
                }
            }
        ]
      });

$('.footer-slick').slick({
        slidesToShow: 3,
        dots: false,
        infinite: true,
        prevArrow: '.footer-control .pre',
        nextArrow: '.footer-control .next',
        autoplay: true,
        speed: 2000,
        responsive: [
            {
                breakpoint: 768,
                settings: {
                    slidesToShow: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1
                }
            }
        ]
      });

  $('.news-slick').slick({
        vertical: true,
         autoplay: true,
         speed: 500,
         autoplaySpeed: 2000,
         arrows: false,
        slidesToShow: 4,
        responsive: [{
            breakpoint: 768,
            settings: {
                vertical: true,
                slidesToShow: 4,
                slidesToScroll: 1
            }
        }, {
            breakpoint: 480,
            settings: {
                vertical: true,
                slidesToShow: 3,
                slidesToScroll: 1
            }
        }]
    });

  $('.news-right').slick({
        vertical: true,
         autoplay: true,
         arrows: false,
         speed: 1000,
         slidesToShow: 3,
         responsive: [{
            breakpoint: 768,
            settings: {
                vertical: true,
                slidesToShow: 4,
                slidesToScroll: 1
            }
        }, {
            breakpoint: 480,
            settings: {
                vertical: true,
                slidesToShow: 3,
                slidesToScroll: 1
            }
        }]
    });

(function( $ ) {


	function doAnimations( elems ) {

		var animEndEv = 'webkitAnimationEnd animationend';
		
		elems.each(function () {
			var $this = $(this),
				$animationType = $this.data('animation');
			$this.addClass($animationType).one(animEndEv, function () {
				$this.removeClass($animationType);
			});
		});
	}
	

	var $myCarousel = $('#carousel-example-generic'),
		$firstAnimatingElems = $myCarousel.find('.item:first').find("[data-animation ^= 'animated']");
		

	$myCarousel.carousel();
	

	doAnimations($firstAnimatingElems);
  
	$myCarousel.carousel('pause');
	
	

	$myCarousel.on('slide.bs.carousel', function (e) {
		var $animatingElems = $(e.relatedTarget).find("[data-animation ^= 'animated']");
		doAnimations($animatingElems);
	});  
	
})(jQuery);


  $(document).ready(function(){
		       	$('.back_to_top').click(function(){
					 $('html, body') .animate({
						  scrollTop:0
					  },2000);
				});         
				 }); 





 $(window).scroll(function(){
 var navTop =  $(window).scrollTop();
 $('.model-0').css("top", navTop + 100);
});


alsolike(
  "xbyvmZ", "Radio Button List",
  "XJyqQr", "Loading",
  "VYRzaV", "open close"
);
 
