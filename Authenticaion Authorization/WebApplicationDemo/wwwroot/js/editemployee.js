$(document).ready(function () {
    alert("Document is ready");
})

$(window).on("load", function () {
    console.log("Window is loaded");
});

$(window).on("unload", function () {
    console.log("Window is unloaded");
});

$(window).resize( function () {
    console.log("Window is resized");
});




function validate() {

    var isValid = true;
    var numberRegex = /^[0-9]*$/;
    var nameRegex = /^[a-zA-Z]+ [a-zA-Z]*$/;

    $("#Age_ErrorMessage").text("");
    $("#Name_ErrorMessage").text("");
    $("#Desig_ErrorMessage").text("");
    $("#Salary_ErrorMessage").text("");



    console.log(isValid);
    if ($("#Name").val().trim() == "") {
        $("#Name_ErrorMessage").text("Name is required");
        isValid = false;
    }

    if ($("#Name").val().trim() != "" && !nameRegex.test($("#Name").val().trim())) {
        console.log("HEREEEEEEEE");
        $("#Name_ErrorMessage").text("Name is Invalid");
        isValid = false;
    }




    if ($("#Age").val().trim() == "") {
        $("#Age_ErrorMessage").text("Age is required");
        isValid = false;
    }

    console.log("Result is " + numberRegex.test($("#Age").val().trim()));
    
    if ($("#Age").val().trim() != "" && !numberRegex.test($("#Age").val().trim())) {
        console.log("HEREEEEEEEE");
        $("#Age_ErrorMessage").text("Age is Invalid");
        isValid = false;
    }
    else {
        $("#Age_ErrorMessage").text("");
        isValid = true;
    }

    if ($("#Designation").val().trim() == "") {
        $("#Desig_ErrorMessage").text("Designation is required");
        isValid = false;
    }

    if ($("#Salary").val().trim() == "") {
        $("#Salary_ErrorMessage").text("Salary is required");
        isValid = false;
    }

    return isValid;
}


function SubmitForm() {
    if (validate()) {
        $("#EmployeeForm").submit();
    }
}


function validateName() {

    /^[a-zA-Z][a-zA-Z]$/;
    if ($("#Name").val().trim() == "") {
        $("#Name_ErrorMessage").text("Name is required");
    }
    else {
        $("#Name_ErrorMessage").text("");
        isValid = true;
    }

  
}

function validateAge() {

    $("#Age_ErrorMessage").text("");
    var numberRegex = /^[0-9]*$/;

    if ($("#Age").val().trim() == "") {
        console.log("it is empty");
        $("#Age_ErrorMessage").text("Age is required");
    }
    //^[1-9][0-9]?$
    console.log("Result is " + numberRegex.test($("#Age").val().trim()));

    if ($("#Age").val().trim() != "" && !numberRegex.test($("#Age").val().trim())) {
        console.log("not empty but invalid");
        $("#Age_ErrorMessage").text("Age is Invalid");
        isValid = false;
    }
    else if ($("#Age").val().trim() != "" && numberRegex.test($("#Age").val().trim())) {
        console.log("All clear");
        $("#Age_ErrorMessage").text("");
    }

    
}


$('#Name').keyup(function () {
    validateName();
})


$('#Age').keyup(function () {
    console.log("Key up on age called");
    validateAge();
})


