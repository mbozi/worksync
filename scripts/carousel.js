(function ($) {
    var settings = {
        itemCount: 4,
        itemWidth: 800,
        speed: 1000,
        interval: 4000
    }
    //alert($('div').find('.carousel-item').css("width"));
    settings.itemWidth = parseInt($('div').find('.carousel-item').css("width"));
    $('div').find('.mprev').on('click', function () {
            slide(-1);
    });
    $('div').find('.mnext').on('click', function () {
        slide(1);
    });

    function slide(x) {
        var currentLeft = parseInt($('div').find('.carousel').position().left / settings.itemWidth);
        var newLeft;
        if ((currentLeft + settings.itemCount  == 1) && (x==1)) {
            newLeft = 0;
        } else {
            if ((x==-1) && (currentLeft == 0)) {
                newLeft = 1-settings.itemCount;
            }
            else {
                newLeft = (currentLeft - x);
            }
            
        }
        var newPX = newLeft * settings.itemWidth;
        var state = { $zIndex: 1, width: 100, height: 100, top:40, left: 375, $opacity: 0.9 };
        $('div').find('.carousel').finish().animate({ left: newPX + "px" }, settings.speed);
        
    }
    
})(jQuery);


//(function ($) {
//    var slide = function (ele, options) {
//        var $ele = $(ele);
//        var setting = {
//            speed: 1000,
//            interval: 4000,

//        };

//        $.extend(true, setting, options);

//        var states = ['size1', 'size2', 'size3', 'size4'];

//        var $lis = $ele.find('.carousel-item');
//        var timer = null;

//        $ele.find('.hi-next').on('click', function () {
//            next();
//        });
//        $ele.find('.hi-prev').on('click', function () {
//            states.push(states.shift());
//            move();
//        });
//        $ele.on('mouseenter', function () {
//            clearInterval(timer);
//            timer = null;
//        }).on('mouseleave', function () {
//            autoPlay();
//        });

//        move();
//        autoPlay();

//        //  states 
//        function move() {
//            $lis.each(function (index, element) {
//                var state = states[index];
//                $(element).stop(true, false).switchClass($(element).attr("class"), state, 1000);
//                //$(element).stop(true, false).animate(setting.speed).addClass(state, setting.interval);
//            });
//        }

//        function next() {
//            states.unshift(states.pop());
//            move();
//        }

//        function autoPlay() {
//            timer = setInterval(next, setting.interval);
//        }
//    }
//    // slide()
//    $.fn.hiSlide = function (options) {
//        $(this).each(function (index, ele) {
//            slide(ele, options);
//        });
//        return this;
//    }
//})(jQuery);











