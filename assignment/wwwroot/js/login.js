

function validateLogin() {
    console.log("Checkkkinggg waitt!!")
    isValid = true;
//    emailRegex = \A(?: [a - z0 - 9!#$%& '*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&' * +/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z

    if ($("#UserName").val().trim() == "") {
        $("#UserName_ErrorMessage").text("UserName is required").css("color","#cc0000");
        isValid = false;
    }

   /* if ($("#UserName").val().trim() != "" && !emailRegex.test($("#UserName").val().trim())) {
        console.log("user name is invalid");
        $("#UserName_ErrorMessage").text("username is Invalid").css("color", "#cc0000");
        isValid = false;
    }*/

    if ($("#Password").val().trim() == "") {
        $("#Password_ErrorMessage").text("Password is required").css("color", "#cc0000");
        isValid = false;
    }

    if ($("#Password").val().trim() != "" && $("#Password").val().trim().length < 6) {
        console.log("Password invalid ");
        $("#Password_ErrorMessage").text("Password is Invalid").css("color", "#cc0000");
        isValid = false;
    }
    return isValid;
}

function submitForm() {
    console.log("Checkkk NOwww!!!");
    if (validateLogin()) {
        $("#LoginForm").submit();
    }
}