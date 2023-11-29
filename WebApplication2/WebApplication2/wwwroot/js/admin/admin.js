// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.getElementById("appdpp").style.display = "none";

function chsenOpt(sel) {
    if (sel.value === "other") {
        document.getElementById("appdpp").style.display = "block";
    }
    else {
        document.getElementById("appdpp").style.display = "none";
    }
}

