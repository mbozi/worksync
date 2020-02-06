
var t = function mediatest() {
    var x = window.matchMedia("(max-width: 1024px)");
    if (x.matches && !isSmall) {
        var elems = document.querySelectorAll('.carousel');
        M.Carousel.getInstance(elems).destroy();
        isSmall = true;

    } else {
        location.reload()
    }
}



var s = function mediastart() {
        isSmall = window.matchMedia("(max-width: 1024px)").matches;
        if (!isSmall) {
            var elems = document.querySelectorAll('.carousel');
            M.Carousel.init(elems);
    }
    window.addEventListener("resize", t, false);
    }

var isSmall = true;
document.addEventListener('DOMContentLoaded', s,false);











