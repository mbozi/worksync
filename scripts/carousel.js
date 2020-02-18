﻿(function ($) {
    var slide = function (ele, options) {
        var $ele = $(ele);
        var setting = {
            speed: 1000,
            interval: 4000,

        };

        $.extend(true, setting, options);

        var states = ['size1', 'size2', 'size3', 'size4'];

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
                $(element).stop(true, false).switchClass($(element).attr("class"), state, 1000);
                //$(element).stop(true, false).animate(setting.speed).addClass(state, setting.interval);
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











