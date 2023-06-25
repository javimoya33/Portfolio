// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function clickPestana(elemento) {
    $(elemento).css("font-weight", "bold");
}

function efectoBotonGithub(elemento) {

    $(elemento).find('a').css("display", "flex");
    $(elemento).find('a').css("align-items", "center");
    $(elemento).find('a').css("justify-content", "right");

    $(elemento).find('div').css("display", "block");
    $(elemento).find('div').css("color", "#efd81d");
}

function restaurarBotonGithub(elemento) {
    $(elemento).find('div').css("display", "none");
}