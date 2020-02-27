jQuery(document).ready(
    function ($) {
        var settings = {
            itemCount: 4,
            itemWidth: 800,
            speed: 1000,
            interval: 4000
        }
        settings.itemWidth = parseInt($('div').find('.carousel-item').css("width"));

        timer = setInterval(function () { slide(1); }, settings.interval);

        $('div').find('.mprev').on('click', function () {
            slide(-1);
        });
        $('div').find('.mnext').on('click', function () {
            slide(1);
        });

        $(".carousel-item").click(function () {
            window.location = $(this).data("href");
        });

        function slide(x) {
            var currentLeft = parseInt($('div').find('.carousel').position().left / settings.itemWidth);
            var newLeft;
            if ((currentLeft + settings.itemCount == 1) && (x == 1)) {
                newLeft = 0;
            } else {
                if ((x == -1) && (currentLeft == 0)) {
                    newLeft = 1 - settings.itemCount;
                }
                else {
                    newLeft = (currentLeft - x);
                }

            }
            var newPX = newLeft * settings.itemWidth;
            var state = { $zIndex: 1, width: 100, height: 100, top: 40, left: 375, $opacity: 0.9 };
            $('div').find('.carousel').finish().animate({ left: newPX + "px" }, settings.speed);

        }

});










