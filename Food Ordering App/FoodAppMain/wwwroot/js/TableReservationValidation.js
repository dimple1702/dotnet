function submitForm() {
    console.log("Table Reservation Validation");
    if (validate()) {
        $("#ReservationTable").submit();
    }
}

function validate() {
    isValid = true;
    console.log($("#CustomerName").val().trim())
    console.log($("#NumberOfCustomers").val())
    console.log($("#ReservationDate").val());

    if ($("#CustomerName").val().trim() == "") {
        $("#CustomerName_ErrorMessage").text("CustomerName is required");
        isValid = false;
    }
    if ($("#CustomerName").val().trim() != "" && $("#CustomerName").val().trim().length < 3) {     
        $("#CustomerName_ErrorMessage").text("Customer name must be at least 3 characters in length");
        isValid = false;
    }
    if ($("#NumberOfCustomers").val() < 1) {
        $("#NumberOfCustomers_ErrorMessage").text("Please enter a valid number");
        isValid = false;
    }
    if (!validateDate()) {
        $("#ReservationDate_ErrorMessage").text("Please enter a valid number");
        isValid = false;
    }    
    return isValid;
}
function validateDate() {
    var todayDate = new Date(); 
    var anyDate = new Date($("#ReservationDate").val());

    console.log(anyDate)
    if (todayDate > anyDate) {
        return false;
    } else {
        return true;
    }
}
$("#CustomerName").keyup(function () {
    console.log("Touch kyu kiya")
    validateEmail();
})
function validateEmail() {
    isValid = true;
    if ($("#CustomerName").val().trim() == "") {
        $("#CustomerName_ErrorMessage").text("CustomerName is required");
        isValid = false;
    }
    if ($("#CustomerName").val().trim() != "" && $("#CustomerName").val().trim().length < 3) {
        $("#CustomerName_ErrorMessage").text("Customer name must be at least 3 characters in length");
        isValid = false;
    }
}