$(document).ready(main);

var contador = 1;

function main() {
    $('.menu_bar').click(function () {
        //$('nav').toggle();
        if (contador == 1) {
            $('nav').animate({
                left: '0'
            });
            contador = 0;
        } else {
            contador = 1;
            $('nav').animate({
                left: '-100%'
            });
        }
    });
    $('.contenido').click(function () {
        if (contador == 0) {
            contador = 1;
            $('nav').animate({
                left: '-100%'
            });
        }

    })

    /*MOSTRAMOS Y OCULTAMOS LOS SUBMENUS*/
    $('.submenu').click(function () {
        $(this).children('.children').slideToggle();
    })

};