jQuery(document).ready(
    function ($) {
        var settings = {
            itemCount: 4,
            itemWidth: 800,
            speed: 1000,
            interval: 4000
        }
        var position = 0;
        settings.itemWidth = parseInt($('div').find('.carousel-item').css("width"));
        var timer = null;
        
        $('div').find('.mprev').on('click', function () {
            slide(-1);
        });
        $('div').find('.mnext').on('click', function () {
            slide(1);
        });

        $(".carousel-item").click(function () {
            window.location = $(this).data("href");
        });


        $(".carousel-utility").on('mouseenter', function () {
            clearInterval(timer);
        }).on('mouseleave', function () {
            autoPlay();
        });

        $(window).resize(function () {
            settings.itemWidth = parseInt($('div').find('.carousel-item').css("width"));
            slide(1);
        });

        autoPlay();


        function autoPlay() {
            timer = setInterval(function () { slide(1); }, settings.interval);
        }

        function slide(x) {
            if ((position - settings.itemCount == -1) && (x == 1)) {
                position = 0;
            } else {
                if ((x == -1) && (position == 0)) {
                    position = 3;
                }
                else {
                    position = (position + x);
                }

            }
            var newPX = position * settings.itemWidth * -1;
            var state = { $zIndex: 1, width: 100, height: 100, top: 40, left: 375, $opacity: 0.9 };
            $('div').find('.carousel').finish().animate({ left: newPX + "px" }, settings.speed);
            autoplay();
        }

    });












