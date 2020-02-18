(function ($) {
    var slide = function (ele, options) {
        var $ele = $(ele);
        var setting = {
            speed: 1000,
            interval: 4000,

        };

        $.extend(true, setting, options);

        var states = [
            //{ $zIndex: 1, width: 240, height: 200, top: 69, left: 500, $opacity: 0.2 },
            //{ $zIndex: 2, width: 260, height: 300, top: 59, left: 0, $opacity: 0.4 },
            //{ $zIndex: 3, width: 300, height: 300, top: 35, left: 0, $opacity: 0.7 },
            //{ $zIndex: 2, width: 200, height: 200, top: 59, left: 500, $opacity: 0.2 },
            //{ $zIndex: 3, width: 300, height: 300, top: 35, left: 700, $opacity: 0.7 },
            
            //{ $zIndex: 4, width: 400, height: 400, top: 0, left: 300, $opacity: 1 }
            //{ $zIndex: 1, width: 240, height: 200, top: 69, left: 800, $opacity: 0.2 }
            { $zIndex: 4, width: 400, height: 400, top: 100, left: 435, $opacity: 1.0 },
            { $zIndex: 3, width: 300, height: 300, top: 80, left: 415, $opacity: 0.9 },
            { $zIndex: 2, width: 200, height: 200, top: 60, left: 395, $opacity: 0.9 },
            { $zIndex: 1, width: 100, height: 100, top:40, left: 375, $opacity: 0.9 }
            
            
            
        ];

        var $lis = $ele.find('.carousel-item');
        var timer = null;

        $ele.find('.hi-next').on('click', function () {
            next();
        });
        $ele.find('.hi-prev').on('click', function () {
            states.push(states.shift());
            move();
        });
        $ele.on('mouseenter', function () {
            clearInterval(timer);
            timer = null;
        }).on('mouseleave', function () {
            autoPlay();
        });

        move();
        autoPlay();

        //  states 
        function move() {
            $lis.each(function (index, element) {
                var state = states[index];
                $(element).css('zIndex', state.$zIndex).finish().animate(state, setting.speed).find('div').css('opacity', state.$opacity);
            });
        }

        function next() {
            states.unshift(states.pop());
            move();
        }

        function autoPlay() {
            timer = setInterval(next, setting.interval);
        }
    }
    // slide()
    $.fn.hiSlide = function (options) {
        $(this).each(function (index, ele) {
            slide(ele, options);
        });
        return this;
    }
})(jQuery);











