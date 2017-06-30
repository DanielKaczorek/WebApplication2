
function CheckIfFileUploaded() {
    if ($("#selectFile").val() == "") {
        alert("Upload a file please!")
        return false;
    }
}


    function IsFirstNameEmpty() {
        if ($("#TxtFName").val == "") {
            return 'First Name should not be empty';
        }
        else { return ""; }
    }

    function IsFirstNameInValid() {
        if (document.getElementById('TxtFName').value.indexOf("@") != -1) {
            return 'First Name should not contain @';
        }
        else { return ""; }
    }
    function IsLastNameInValid() {
        if ($('#TxtLName').val.length >= 10) {
            return 'Last Name should not contain more than 5 character';
        }
        else { return ""; }
    }
    function IsSalaryEmpty() {
        if ($('#TxtSalary').val == "") {
            return 'Salary should not be empty';
        }
        else { return ""; }
    }
    function IsSalaryInValid() {
        var num = $('#TxtSalary').val();
        if (isNaN(num)) {
            return 'Enter valid salary';
        }
        else { return ""; }
    }

    function IsValid() {
        console.log('isValid entry');

        var FirstNameEmptyMessage = IsFirstNameEmpty();
        var FirstNameInValidMessage = IsFirstNameInValid();
        var LastNameInValidMessage = IsLastNameInValid();
        var SalaryEmptyMessage = IsSalaryEmpty();
        var SalaryInvalidMessage = IsSalaryInValid();

        var FinalErrorMessage = "Errors:";
        if (FirstNameEmptyMessage != "")
            FinalErrorMessage += "\n" + FirstNameEmptyMessage;
        if (FirstNameInValidMessage != "")
            FinalErrorMessage += "\n" + FirstNameInValidMessage;
        if (LastNameInValidMessage != "")
            FinalErrorMessage += "\n" + LastNameInValidMessage;
        if (SalaryEmptyMessage != "")
            FinalErrorMessage += "\n" + SalaryEmptyMessage;
        if (SalaryInvalidMessage != "")
            FinalErrorMessage += "\n" + SalaryInvalidMessage;

        console.log('FinalErrorMessage=' + FinalErrorMessage);
        if (FinalErrorMessage != "Errors:") {
            alert(FinalErrorMessage);
            return false;
        }
        else {
            return true;
        }
    }
