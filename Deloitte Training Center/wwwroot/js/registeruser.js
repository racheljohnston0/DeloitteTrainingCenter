function validate() {
    var pwd = document.getElementById("password");
    var confirmpwd = document.getElementById("confirmpassword");
    let button = document.getElementById("registerbutton");
    if (pwd.value == confirmpwd.value) {
        var alert = document.getElementById("alertmessage");
        alert.innerHTML = "";
        button.hidden = false;
    } else {
        var alert = document.getElementById("alertmessage");
        alert.innerHTML = "Passwords do not match";
        button.hidden = true;
    }
}