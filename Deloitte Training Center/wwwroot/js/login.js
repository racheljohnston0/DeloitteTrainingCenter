function validate() {
    var email = document.getElementById("email");
    var pwd = document.getElementById("password");
    let button = document.getElementById("loginbutton");
    if (pwd.value != "" && email.value != "") {
        button.hidden = true;
    } else {
        button.hidden = false;
    }
}
