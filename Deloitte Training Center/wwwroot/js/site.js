// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let loginlink = document.getElementById("loginlink");
let registerlink = document.getElementById("registerlink");
let loginStatus = document.getElementById("loginstatus");
let logoutlink = document.getElementById("loginout");

if (loginStatus.innerHTML != "") {
    loginlink.hidden = true;
    registerlink.hidden = true;
    logoutlink.hidden = false;
} else {
    loginlink.hidden = false;
    registerlink.hidden = false;
    logoutlink.hidden = true;
}