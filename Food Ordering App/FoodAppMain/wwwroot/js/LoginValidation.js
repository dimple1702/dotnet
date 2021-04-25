

function validateLogin() {
     isValid = true;
     emailRegex = /[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}/

    if ($("#UserEmail").val().trim() == "") {
        $("#UserEmail_ErrorMessage").text("UserName is required");
        isValid = false;
    }

    if ($("#UserEmail").val().trim() != "" && !emailRegex.test($("#UserEmail").val().trim())) {
        console.log("user name ot validd");
        $("#UserEmail_ErrorMessage").text("UserEmail is Invalid");
        isValid = false;
    }

    if ($("#Password").val().trim() == "") {
        $("#Password_ErrorMessage").text("Password is required");   // Password empty
        isValid = false;
    }

    if ($("#Password").val().trim() != "" && $("#Password").val().trim().length < 6) {      //Password length 
        console.log("Password invalid ");
        $("#Password_ErrorMessage").text("Password must be at least 6 characters in lenght");
        isValid = false;
    }
    return isValid;
}

function submitForm() {
    console.log("asdfadfa");
    if (validateLogin()) {
        $("#LoginForm").submit();
    }
}

$("#UserEmail").keyup(function () {
    console.log("uffff touch kyu kiya")
    validateEmail();
})
function validateEmail() {
    isValid = true;
    emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/
    var useremail = $("#UserEmail").val().trim();

    if (useremail == "") {
        $("#UserEmail_ErrorMessage").text("Email is required");
    }
    if (useremail != "" && !emailRegex.test(useremail)) {
        console.log("user name not validd");
        $("#UserEmail_ErrorMessage").text("Email is Invalid");
    }
    else if (useremail != "" && emailRegex.test(useremail)) {
        console.log("All clear");
        $("#UserEmail_ErrorMessages").text("Please enter a Valid email");
    }
}