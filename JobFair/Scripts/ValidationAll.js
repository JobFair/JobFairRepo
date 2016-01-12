/******** Created By Avadhoot Mane Date: 0/11/2015 *********/

function getRootWebSitePath() {
    var _location = document.location.toString();
    var applicationNameIndex = _location.indexOf('/', _location.indexOf('://') + 3);
    var applicationName = _location.substring(0, applicationNameIndex) + '/';
    var webFolderIndex = _location.indexOf('/', _location.indexOf(applicationName) + applicationName.length);
    var webFolderFullPath = _location.substring(0, webFolderIndex);

    return webFolderFullPath;
}

function ForgotPwdWindow() {
   // window.location.host
    window.open(getRootWebSitePath() + "/ForgotPassword.aspx", "window", "top=220,left=220,height=200px,width=490px", true);
}
function GetPwdWindow() {
    window.open("GetPassword.aspx", "window", "top=190,left=220,height=140px,width=350px", true);
}
function CapLock(e) {
    kc = e.keyCode ? e.keyCode : e.which;
    sk = e.shiftKey ? e.shiftKey : ((kc == 16) ? true : false);
    if (((kc >= 65 && kc <= 90) && !sk) || ((kc >= 97 && kc <= 122) && sk))
        document.getElementById('divMayus').style.visibility = 'visible';
    else
        document.getElementById('divMayus').style.visibility = 'hidden';
}
function MouseOver(obj) {
    obj.style.textDecoration = 'underline'
    obj.style.fontWeight = 'bold';
}
function MouseOut(obj) {
    obj.style.textDecoration = 'none'
    obj.style.fontWeight = 'bold';
}


/******************* DIV Show Hide *************************/
function ViewHide(divShow, divHide) {
    document.getElementById(divShow).style.display = "block";
    document.getElementById(divHide).style.display = "none";
    return false;
}
function ShowDiv(DivID) {
    $get(DivID).style.display = 'block';
    return false;
}
function HideDiv(DivID) {
    $get(DivID).style.display = 'none';
    return false;
}
/******************* DIV Show Hide End *************************/


/******************* Allow Only Number or aplha numeric or charcters only *************************/
function AllowOnlyNumric(e) {
    // Get the ASCII value of the key that the user entered
    if (window.event) // IE
    {
        iKeyCode = window.event.keyCode;
    }
    else if (e.which)  // Netscape/Firefox/Opera
    {
        iKeyCode = e.which;
    }
    if (iKeyCode > 31 && (iKeyCode < 48 || iKeyCode > 57))
        return false;
    return true;
}
 function CheckAlphaNumeric(controlId) {
    var textBoxContent = document.getElementById(controlId).value;
    var chk = /[^a-zA-Z 0-9 . - ( )]+/;
    if (chk.test(textBoxContent)) {
        var ErrorMsgWindow = window.open("", "ErrorMsgWindow", "top=190,left=220,height=140px,width=350px");
        ErrorMsgWindow.document.write("<center>This is 'Error Message Window'</center><hr/><center><h3><font color=red>Special Characters are not allowed</font></h3></center");
        textBoxContent = textBoxContent.replace(/[^a-zA-Z 0-9 . - ( )]+/g, '');
        document.getElementById(controlId).value = textBoxContent;
        return false;
    }
    else {
        return true;
    }
}
function CheckOnlyChar(controlId) {
    var textBoxContent = document.getElementById(controlId).value.trim();
    var chk = /[^a-zA-Z]+/;
    if (chk.test(textBoxContent)) {
        var ErrorMsgWindow = window.open("", "ErrorMsgWindow", "top=190,left=220,height=140px,width=350px");
        ErrorMsgWindow.document.write("<center>This is 'Error Message Window'</center><hr/><center><h3><font color=red>Enter Only Characters</font></h3></center");
        //response.Write("<script language='javascript'>alert('Enter Only Characters')</script>");
        //onmessage.alert('Enter Only Characters')
        textBoxContent = textBoxContent.replace(/[^a-zA-Z]+/g, '');
        document.getElementById(controlId).value = textBoxContent;
        return false;
    }
    else {
        return true;
    }
}
function CheckIsNum(txtObj) {
    obj = document.getElementById(txtObj);
    var regex = /^[0-9]+$/;
    if (!regex.test(obj.value)) {
        obj.value = theVal = obj.value.replace(/[^0-9]/g, '');
        if (theVal > "") {
            obj.value = parseFloat("0" + theVal);
            obj.focus()
        }
        var ErrorMsgWindow = window.open("", "ErrorMsgWindow", "top=190,left=220,height=140px,width=350px");
        ErrorMsgWindow.document.write("<center>This is 'Error Message Window'</center><hr/><center><h3><font color=red>Enter Only Numeric Values</font></h3></center");
    }
}
function CheckIsNumDec(txtObj) {
    obj = document.getElementById(txtObj);
    if (!/^\d+(\.\d*)?$/.test(obj.value)) {
        obj.value = theVal = obj.value.replace(/[^0-9.]/g, '');
        if (theVal > "") {
            obj.value = parseFloat("0" + theVal);
            obj.focus()
        }
    }
}
//function CheckRange(txtObj) {
//    obj = parseInt(document.getElementById(txtObj).value);
//    var regex = /^[0-9]+$/;
//    if (regex.test(obj.value) > 35 && regex.test(obj.value) < 100 && theVal > "") {
//        obj.value = theVal = obj.value.replace(/[^0-9]/g, '');
//        if (theVal > "") {
//            obj.value = parseFloat("0" + theVal);
//            obj.focus()
//        }
//    }
//    alert('Enter Numeric Values Between 35 to 100');
//}
function CheckRange(controlId) {
    var txtVal = document.getElementById(controlId).value;
        if (txtVal >= 35 && txtVal <= 100) {               
            return true;
        }          
    else
            var ErrorMsgWindow = window.open("", "ErrorMsgWindow", "top=190,left=220,height=140px,width=350px");
            ErrorMsgWindow.document.write("<center>This is 'Error Message Window'</center><hr/><center><h3><font color=red>Enter Numeric Values Between 35 to 100</font></h3></center");
            document.getElementById(controlId).value = '';
            document.getElementById(controlId).focus();
        return false;
}
/************* Allow Only Number or aplha numeric or charcters only End**************/


/*************** Functions for date time *************************/
function CheckValidTime(fromValue, toValue) {
    var timeExpression = /^([0][1-9]|[1][0-2]):([0-5][0-9]) ([^ap][^m])$/;
    var fromValResult = timeExpression.test(fromValue);
    var toValResult = timeExpression.test(toValue);

    if (fromValue != "" && toValue != 'T') {
        if (fromValResult && toValResult) {
            return true;
        }
        else {
            alert('Enter Valid Time');
            return false;
        }
    }
    else {
        if (fromValResult) {
            return true;
        }
        else {
            alert('Enter Valid Time');
            return false;
        }
    }
}
function CheckOnlyDate(fromDate, toDate) {
    var chk = /^(((((0[1-9])|(1\d)|(2[0-8]))\/((0[1-9])|(1[0-2])))|((31\/((0[13578])|(1[02])))|((29|30)\/((0[1,3-9])|(1[0-2])))))\/((20[0-9][0-9])|(19[0-9][0-9])))|((29\/02\/(19|20)(([02468][048])|([13579][26]))))$/
    if (fromDate.value != "" && toDate.value != "" && toDate != 'T') {
        if (chk.test(fromDate.value) && chk.test(toDate.value)) {
            return true;
        }
        else {
            alert('Invalid Date')
            return false;
        }
    }
    else {
        if (chk.test(fromDate.value)) {
            return true;
        }
        else {
            alert('Invalid Date')
            return false;
        }
    }
}

//validating " from date" - "to date"
//btnShow.Attributes.Add("onclick", "return ValidDate('" + txtFromDate.ClientID + "','" + txtToDate.ClientID + "');");
function ValidDate(optionFrom, optionTo) {
    var dateFrom = document.getElementById(optionFrom);
    var dateTo = document.getElementById(optionTo);
    if (dateFrom.value == "" || dateTo.value == "") {
        alert('Date cannot be blank');
        return false;
    }
    if (CheckValidDate(dateFrom, dateTo)) {
        return true;
    }
    else
        return false;


}

function CheckValidDate(fromDate, toDate) {
    var chk = /^(((((0[1-9])|(1\d)|(2[0-8]))\/((0[1-9])|(1[0-2])))|((31\/((0[13578])|(1[02])))|((29|30)\/((0[1,3-9])|(1[0-2])))))\/((20[0-9][0-9])|(19[0-9][0-9])))|((29\/02\/(19|20)(([02468][048])|([13579][26]))))$/
    if (fromDate.value != "" && toDate.value != "" && toDate != 'T') {
        if (chk.test(fromDate.value) && chk.test(toDate.value)) {
            if (FormatDate(fromDate.value) > FormatDate(toDate.value)) {
                alert('From Date shouldnt be greater than To Date');
                return false;
            }
            else
                return true;
        }
        else {
            alert('Invalid Date');
            return false;
        }
    }
    else {
        if (chk.test(fromDate.value)) {
            if (FormatDate(fromDate.value) > FormatDate(document.getElementById("hdnTodayDate").value)) {
                alert('Selected Date should be less than or equal to current date');
                return false;
            }
            else
                return true;
        }
        else {
            alert('Invalid Date')
            return false;
        }
    }
}

function FormatDate(val) {
    var tmpDate = val.split("/");
    var DD = tmpDate[0];
    var MM = tmpDate[1];
    var YYYY = tmpDate[2];
    var fDate = new Date(MM + "/" + DD + "/" + YYYY);
    return fDate;
}


/*************** Functions for date time end*************************/


function IsValidTime(ctrl) {
    try {
        var flag = true;
        var time = document.getElementById(ctrl);
        var totaltime = time.value.split(' ')[0]
        var hours = totaltime.split(':')[0]
        var minutes = totaltime.split(':')[1]
        if (time.value == "")
            flag = false;
        if (hours == 12 && minutes == 00) {
            return true;
        }
        if (hours > 12 || hours == 00)
            flag = false;
        if (minutes > 59) flag = false;
        if (!flag) {
            alert("Enter Valid Time");
            time.focus();
        }
        return flag;
    } catch (e) {

    }
}

function IsValidDate(ctrl) {
    var chk = /^(((((0[1-9])|(1\d)|(2[0-8]))\/((0[1-9])|(1[0-2])))|((31\/((0[13578])|(1[02])))|((29|30)\/((0[1,3-9])|(1[0-2])))))\/((20[0-9][0-9])|(19[0-9][0-9])))|((29\/02\/(19|20)(([02468][048])|([13579][26]))))$/
    var control = document.getElementById(ctrl);
    if (control.value.replace(/^\s+|\s+$/g, "") == "") {
       // alert("Enter a Date");
        control.focus();
        return false;
    }
    else {
        if (!chk.test(control.value)) {
            alert('Invalid Date');
            control.focus();
            return false;
        }
    }
    return true;
}

/*******Function To Check Current Financial Year Login Date*********/
function CheckFinancialDate(FromDate, ToDate) {
    var StartDate = document.getElementById("hdnFromDate").value;
    var EndDate = document.getElementById("hdnToDate").value;
    var chk = /^(((((0[1-9])|(1\d)|(2[0-8]))\/((0[1-9])|(1[0-2])))|((31\/((0[13578])|(1[02])))|((29|30)\/((0[1,3-9])|(1[0-2])))))\/((20[0-9][0-9])|(19[0-9][0-9])))|((29\/02\/(19|20)(([02468][048])|([13579][26]))))$/
    if (FromDate.value != "" && ToDate.value != "" && ToDate != 'T') {
        if (chk.test(FromDate.value) && chk.test(ToDate.value)) {
            if (FormatDate(FromDate.value) > FormatDate(ToDate.value)) {
                alert('From Date shouldnt be greater than To Date');
                return false;
            }
            else {
                if ((FormatDate(FromDate.value) < FormatDate(StartDate)) || (FormatDate(ToDate.value) > FormatDate(EndDate))) {
                    alert('Select Date In Current Financial Year');
                    return false;
                }
            }
        }
        else {
            alert('Invalid Date');
            return false;
        }
    }
    return true;
}

function ValidateFinancialDate(TranDate) {
    var StartDate = document.getElementById("hdnFromDate").value;
    var EndDate = document.getElementById("hdnToDate").value;
    var chk = /^(((((0[1-9])|(1\d)|(2[0-8]))\/((0[1-9])|(1[0-2])))|((31\/((0[13578])|(1[02])))|((29|30)\/((0[1,3-9])|(1[0-2])))))\/((20[0-9][0-9])|(19[0-9][0-9])))|((29\/02\/(19|20)(([02468][048])|([13579][26]))))$/
    if (TranDate.value != "") {
        if (chk.test(TranDate.value)) {
            if ((FormatDate(TranDate.value) < FormatDate(StartDate)) || (FormatDate(TranDate.value) > FormatDate(EndDate))) {
                alert('Select Date In Current Financial Year');
                return false;
            }
            else if (FormatDate(TranDate.value) > FormatDate(document.getElementById("hdnTodayDate").value)) {
                alert('Date Shouldnt Be Greater Than Todays Date');
                return false;
            }
        }
        else {
            alert('Invalid Date');
            return false;
        }
    }
    return true;
}


/********** other controls validation ************************/
function IsSelected(ctrl, ctrlType, msg) {
    debugger;
    var selectedTest = document.getElementById(ctrl);
    if (selectedTest != null) {
        var elements = selectedTest.getElementsByTagName("input");
        var bReturn = false;
        for (i = 1; i < elements.length; i++) {
            if (elements[i].type == ctrlType) {
                if (elements[i].checked) {
                    bReturn = true;
                    break;
                }
            }
        }
        if (bReturn == false) {
            alert('Select At Least One ' + msg);
            return false
        }
        else {
            return true;
        }
    }
    else {
        return false;
    }
}
function Dropdown_Validation(ddlId) {
    var empty = document.getElementById(ddlId).value;

    if (empty == "0") {
        alert('Please select an item');
        return false;
    }
    return true;
}

function ValidateDropdown() {
    var result = document.getElementById('<%=ddlTeamSize%>').value;
    if (result == "0") {
        alert("Please Select Education");
        return false;
    }
    return false;
}
function IsSelectedDDL(ctrl) {
    if (document.getElementById(ctrl).value == "" || document.getElementById(ctrl).text == '--Select--') {
        alert('Select At Least One'); // prompt user
        document.getElementById(ctrl).focus(); //set focus back to control
        return false;
    }
}

function CheckEmail(pEmail) {
    var email = document.getElementById(pEmail);
    var regex = /[\w-]+@([\w-]+\.)+[\w-]+/;
    if (email.value != "" && !regex.test(email.value)) {
        //alert("Invalid Email");
        var ErrorMsgWindow = window.open("", "ErrorMsgWindow", "top=190,left=220,height=140px,width=350px");
        ErrorMsgWindow.document.write("<center>This is 'Error Message Window'</center><hr/><center><h3><font color=red>Invalid Email</font></h3></center");
        email.focus();
        email.value = "";
        return false;
    }
}
function CheckAllCheckBox(chkAll, chkList) {
    var chkAll = document.getElementById(chkAll);
    var list = document.getElementById(chkList);
    var inputs = list.getElementsByTagName("input");
    var counter = 0;
    if (chkAll.checked == true) {
        for (var i = 0; i < inputs.length; i++) {
            inputs[i].checked = true;
        }
    }
    else if (chkAll.checked == false) {
        for (var i = 0; i < inputs.length; i++) {
            inputs[i].checked = false;
        }
    }
    return true;
}
function CheckRadio(theRadio) {
    if (theRadio.getAttribute("wasChecked") == "true") {
        theRadio.checked = false;
        theRadio.setAttribute("wasChecked", "false");
    }
    else {
        theRadio.setAttribute("wasChecked", "true");
    }
}
/********** other controls validation End************************/

/********** Text With List *******************/
function AddText(chkID, textID) {
    var List = document.getElementById(chkID);
    var chkExists = 0;

    for (j = 0; j < List.childNodes.length; j++) {
        if (List.childNodes[j].selected) {
            if (textID.value.length > 0) {
                var str = textID.value.split(',');
                for (var i = 0; i < str.length; i++) {
                    if (List.childNodes[j].innerHTML.trim() == str[i].trim()) {
                        chkExists = 1;
                        alert('Already Exists!');
                        break;
                    }
                }
                if (chkExists == 0) {
                    textID.value += ", " + List.childNodes[j].innerHTML;
                }
            }
            else {
                textID.value += List.childNodes[j].innerHTML;
            }
        }
    }
}
/********** TextWithList End *******************/

//SET SELECTED INDEX
function SetSelectedIndex(dropdownlist, sVal) {
    var a = document.getElementById(dropdownlist);
    for (i = 0; i < a.length; i++) {
        if (a.options[i].value == sVal) {
            a.selectedIndex = i;
        }
    }
}


/***************Function To Valid Mobile Number******************/
function IsValidMobNumber(ctrl) {
    try {
        var chkNumber = /^([1-9]{1})+([0-9]{9})+$/i;
        if (!chkNumber.test(document.getElementById(ctrl).value.trim())) {
            var ErrorMsgWindow = window.open("", "ErrorMsgWindow", "top=190,left=220,height=140px,width=350px");
            ErrorMsgWindow.document.write("<center>This is 'Error Message Window'</center><hr/><center><h3><font color=red>Please Enter Valid Mobile Number</font></h3></center");
            document.getElementById(ctrl).focus();
            return false;
        }
        return true;
    } catch (e) {
        alert(e.toString());
        return false;
    }
}
/***************Function To Valid Mobile Number End******************/


/***************Function To Valid Email Address******************/
function IsValidEmail(ctrl) {
    try {
        //var chkEmail = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
        //var chkEmail = /^(([^<>()[\]\.,;:\s@\"]+(\.[^<>()[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/i;
        var chkEmail = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{3,})+$/i;
        if (!chkEmail.test(document.getElementById(ctrl).value.trim())) {
            var ErrorMsgWindow = window.open("", "ErrorMsgWindow", "top=190,left=220,height=140px,width=350px");
            ErrorMsgWindow.document.write("<center>This is 'Error Message Window'</center><hr/><center><h3><font color=red>Please Enter Valid Email Address</font></h3></center");
            document.getElementById(ctrl).focus();
            return false;
        }
        return true;
    } catch (e) {
        alert(e.toString());
        return false;
    }
}

function NumberOnly(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (evt.type != "textarea") if (charCode == 13) event.preventDefault()
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false
    return true
}
function AlphaNumeric(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (evt.type != "textarea") if (charCode == 13) event.preventDefault()
    if (charCode > 32 && (charCode < 40 || charCode > 57)) if (charCode > 90 || charCode < 60) if (charCode < 97 || charCode > 122) return false;
    return true;
}
function CharOnly(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (evt.type != "textarea") if (charCode == 13) event.preventDefault()
    if (charCode > 32 && ((charCode < 65 || charCode > 90) && (charCode < 97 || charCode > 122)))
        return false
    return true
}
function CharNumberOnly(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (evt.type != "textarea") if (charCode == 13) event.preventDefault()
    if (charCode > 32 && (charCode < 47 || charCode > 57)) if (charCode > 90 || charCode < 65) if (charCode < 97 || charCode > 122) return false
    return true
}
function Validation(ControlID, Message) {
    var Control = document.getElementById(ControlID);
    if (Control.type == "text" || Control.type == "textarea") {
        if (Control.value.replace(/^\s+|\s+$/g, "") == "") { alert(Message); Control.focus(); return false }
    }
    if (Control.type == "select-one") { if (Control.selectedIndex == "0") { alert(Message); Control.focus(); return false; } }
    return true;
}

function onlyDouble(evt, value) {
    var val1;
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (!(charCode == 46 || (charCode >= 48 && charCode <= 57)))
        return false
    if (charCode == 46 && evt.srcElement.value.length == 0)
        return false
    var parts = evt.srcElement.value.split('.')
    if (parts.length > 2)
        return false
    if (charCode == 46)
        return (parts.length == 1)
    if (charCode != 46) {
        var currVal = String.fromCharCode(charCode)
        val1 = parseFloat(String(evt.srcElement.value).substring(0, evt.srcElement.selectionStart) + String(currVal) + String(evt.srcElement.value).substring(evt.srcElement.selectionStart));
    }
    if (val1 > parseFloat(value, 10))
        return false;
    if (parts.length == 2 && parts[1].length >= 2) {
        if (val1.toString().split('.')[1].length == 2 && val1 <= parseFloat(value, 10))
            return true;
        else
            return false;
    }
}

function CheckUncheck(gridView, checkboxId, indexes) {
    var grid = document.getElementById(gridView)
    var arrIndex = indexes.toString().split(',');
    if (grid.rows.length > 0) {
        for (i = 1; i < grid.rows.length; i++) {
            for (var k = 0; k < arrIndex.length; k++) {
                if (arrIndex[k] > 0) {
                    cell = grid.rows[i].cells[arrIndex[k]]
                    for (j = 0; j < cell.childNodes.length; j++) {
                        if (cell.childNodes[j].type == "checkbox") {
                            cell.childNodes[j].checked = document.getElementById(checkboxId).checked
                        }
                    }
                }
            }
        }
    }
}

function ScrollGrid(Grid, height, flag) {
    var color;
    var grid = Grid;
    if (grid.rows.length > 1) {
        var header = grid.getElementsByTagName("th");
        var firstRow = grid.getElementsByTagName("tr")[1];
        var headRow = grid.getElementsByTagName("tr")[0];
        var headerCellWidths = new Array();
        var headerText = new Array();
        var gridWidth = grid.offsetWidth;
        if (grid.offsetWidth == "0") {
            gridWidth = grid.style.width;
        }
        for (var i = 0; i < header.length; i++)
            headerText[i] = header[i].innerHTML;
        //        for (var i = 0; i < firstRow.cells.length; i++) {
        //            if (firstRow.cells[i].offsetWidth == "" || firstRow.cells[i].offsetWidth == "0")
        //                headerCellWidths[i] = (parseInt(firstRow.cells[i].style.width));
        //            else
        //                headerCellWidths[i] = (parseInt(firstRow.cells[i].offsetWidth) );
        //        }
        for (var i = 0; i < firstRow.cells.length; i++) {
            if (firstRow.cells[i].style.width != "")
                headerCellWidths[i] = firstRow.cells[i].style.width;
            else
                headerCellWidths[i] = firstRow.cells[i].offsetWidth + "px";
        }
        var trChild = grid.getElementsByTagName("tr");
        var className = headRow.className;
        var computedStyle = getComputedStyle(headRow, null)
        color = computedStyle.backgroundColor;
        $(headRow).remove();
        for (var i = 0; i < firstRow.cells.length; i++) {
            firstRow.getElementsByTagName("td")[i].width = headerCellWidths[i]
        }
        //}

        var parentDiv = grid.parentNode
        var table = document.createElement("table");
        for (i = 0; i < grid.attributes.length; i++) {
            if (grid.attributes[i].specified && grid.attributes[i].name != "id") {
                table.setAttribute(grid.attributes[i].name, grid.attributes[i].value);
            }
        }
        //Add given color/style if cssClass is not given for GridView
        var tr = document.createElement("tr");
        if (className == "") {
            tr.style.backgroundColor = color;
        }
        else {
            $(tr).addClass(className);
        }
        table.appendChild(tr);
        var unit;
        for (i = 0; i < firstRow.cells.length; i++) {
            var th = document.createElement("th");
            th.style.cssText = "width:" + headerCellWidths[i];
            th.innerHTML = headerText[i];
            tr.appendChild(th);
        }
        var parentdiv = grid.parentNode;
        var divHead = grid.parentNode.appendChild(document.createElement("div"));
        var divGrid = document.createElement("div");

        divHead.style.cssText = "overflow-y: scroll;overflow-x:hidden;";
        divGrid.style.cssText = "overflow-y: scroll;height:" + height + "px;";

        divHead.style.width = parseInt(gridWidth);
        divGrid.style.width = parseInt(gridWidth);

        divHead.appendChild(table); //append header table
        parentDiv.removeChild(grid);
        parentDiv.appendChild(divHead);
        divGrid.appendChild(grid)
        parentDiv.appendChild(divGrid);
        //        divGrid.attributes.Add("onscroll", OnScrollDiv(this));
    }

}

function GetQueryStringParameterByName(name) {
    name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
        results = regex.exec(location.search);
    return results === null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
}