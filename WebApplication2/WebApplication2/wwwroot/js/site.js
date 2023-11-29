// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function menu() {
    var x = document.getElementById("colItems");

    var y = x.style.display;

    if (y === 'none') {
        x.style.display = 'block';
    }
    else if (y === 'block') {
        x.style.display = 'none';
    }
    else {
        x.style.display = 'block';
    }

    window.onresize = function () {
        x.style.display = 'none';
    }
}

function myf(num) {
    var j = document.getElementById(num);
    var k = document.getElementById(num).getAttribute("aria-expanded");

    if (k == "false") {
        j.innerHTML = '<i class="fa-solid fa-caret-down" style="color:darkslategrey"></i>';
    }
    else {
        j.innerHTML = '<i class="fa-solid fa-caret-down fa-flip-vertical" style="color:darkslategrey"></i>';
    }
}