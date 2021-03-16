

function validateLogin() {
     isValid = true;
    emailRegex = /^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$/

    if ($("#UserName").val().trim() == "") {
        $("#UserName_ErrorMessage").text("UserName is required");
        isValid = false;
    }

    if ($("#UserName").val().trim() != "" && !emailRegex.test($("#UserName").val().trim())) {
        console.log("user name ot validd");
        $("#UserName_ErrorMessage").text("username is Invalid");
        isValid = false;
    }

    if ($("#Password").val().trim() == "") {
        $("#Password_ErrorMessage").text("Password is required");
        isValid = false;
    }

    if ($("#Password").val().trim() != "" && $("#Password").val().trim().length < 6) {
        console.log("Password invalid ");
        $("#Password_ErrorMessage").text("Password is Invalid");
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