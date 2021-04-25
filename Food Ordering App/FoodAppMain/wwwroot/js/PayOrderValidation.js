
function submitForm() {
    console.log("Pay Order Validation");
    if (validate()) {
        $("#PaymentForm").submit();
    }
}

function validate() {
    isValid = true;
    emailRegex = /[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}/
    
    if ($("#UserEmailAddress").val().trim() == "") {
        $("#UserEmailAddress_ErrorMessage").text("Email Address is required");
        isValid = false;
    }

    if ($("#UserEmailAddress").val().trim() != "" && !emailRegex.test($("#UserEmailAddress").val().trim())) {
        $("#UserEmailAddress_ErrorMessage").text("UserEmail is Invalid");
        isValid = false;
    }

    if ($("#UserResidenceAddress").val().trim() == "") {
        $("#UserResidenceAddress_ErrorMessage").text("Residence Address is required");
        isValid = false;
    }

    if ($("#PhoneNumber").val().trim() == "") {
        $("#PhoneNumber_ErrorMessage").text("Phone Number is required");
        isValid = false;
    }

    if ($("#PaymentMethod").val().trim() == "") {
        $("#PaymentMethod_ErrorMessage").text("Payment Method is required");
        isValid = false;
    }

    return isValid;
}