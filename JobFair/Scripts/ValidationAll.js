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
        alert('Special Characters are not allowed')
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
        alert('Enter Only Characters')
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
        alert('Enter Only Numeric Values')
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
        alert("Enter a Date");
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

function IsSelectedDDL(ctrl, msg) {
    if (document.getElementById(ctrl).value == "" || document.getElementById(ctrl).text == '--Select--') {
        alert('Select At Least One' + msg); // prompt user
        document.getElementById(ctrl).focus(); //set focus back to control
        return false;
    }
}

function CheckEmail(pEmail) {
    var email = document.getElementById(pEmail);
    var regex = /[\w-]+@([\w-]+\.)+[\w-]+/;
    if (email.value != "" && !regex.test(email.value)) {
        alert("Invalid Email");
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


/***************Grid Scrollable ************************/
var headerHeight = 8;
function GridScroll(gvId, wrapperClass) {
    freezeGridViewHeaderForIEAndFF(gvId, wrapperClass);
}
function freezeGridViewHeaderForIEAndFF(gridViewId, wrapperDivClassName) {
    var grid = document.getElementById(gridViewId);
    if (grid != 'undefined') {
        grid.style.visibility = 'hidden';

        var div = null;
        if (grid.parentNode != 'undefined') {
            //Find wrapper div output by GridView
            div = grid.parentNode;
            if (div.tagName == "DIV") {
                div.className = wrapperDivClassName;
                div.style.overflow = "auto";
            }
        }

        var grid = prepareFixedHeader(grid);
        var tbody = grid.getElementsByTagName('TBODY')[0];

        //Needed for Firefox
        tbody.style.height = (522 - headerHeight) + 'px';

        tbody.style.overflowX = "hidden";
        tbody.overflow = 'auto';
        tbody.overflowX = 'hidden';

        grid.style.visibility = 'visible';
    }
}
function prepareFixedHeader(grid) {
    //Find DOM TBODY element and  and
    var tags = grid.getElementsByTagName('TBODY');
    if (tags != 'undefined') {
        var tbody = tags[0];

        var trs = tbody.getElementsByTagName('TR');

        if (trs != 'undefined') {
            headerHeight += trs[0].offsetHeight;

            //Remove first TR tag from it
            var headTR = tbody.removeChild(trs[0]);

            //create a new element called THEAD
            var head = document.createElement('THEAD');
            head.appendChild(headTR);

            //add to a THEAD element instead of TR so CSS styles
            //can be applied properly in both IE and FireFox
            grid.insertBefore(head, grid.firstChild);
        }
    }
    return grid;
}
/***************Grid Scrollable END************************/

/********** Confirmation Of Delete *******************/
function DeleteComfirm() {
    if (ConfirmDelete()) {
        var Reason = window.prompt("Please Enter Reason To Delete", "");
        if (Reason) {
            if (Reason.trim() != null && Reason.trim() != "") {
                document.getElementById("hdnDeleteRemark").value = Reason.trim();
                return true;
            }
            else {
                alert('Can not delete without reason');
                return false;
            }
        }
        else {
            alert('Can not delete without reason');
            return false;
        }
    }
    else {
        alert('Delete Cancelled: Reason not given');
        return false;
    }
}
function ConfirmDelete() {
    return confirm('Confirm delete?')
}


/********** Editable dropdown *******************/
function AddItem(textId, ddlID, DivID) {
    txt = document.getElementById(textId);
    ddl = document.getElementById(ddlID);
    var strLower = txt.value;
    strLower = strLower.toLowerCase();
    var itemText = "";
    var ent = /Enter/;
    var i, iflag = 0;
    if (strLower.search(ent) != -1) {
        alert("Can't Save Empty Text");
        return false;
    }

    for (i = 0; i < ddl.length; i++) {
        itemText = ddl[i].innerHTML;
        itemText = itemText.toLowerCase();

        if (strLower == "enter new value") {
            return false;
        }
        else if (strLower == itemText) {
            alert("Item Already Exists");
            return false;
        }
    }
    HideDiv(DivID);
    return true;
}
/********** Editable dropdown end*******************/


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


/********** Dropdown extender *****************/
function VisibleMe(ContrilId) {
    $find(ContrilId)._dropWrapperHoverBehavior_onhover();
}

function ShowCheckBoxList() {
    if (!e) var e = window.event;
    e.cancelBubble = true;
    if (e.stopPropagation) e.stopPropagation();
}
/********** Dropdown extender *****************/


/********** Record save Deleted notification *****************/
function FadeOutNotification() {
    $('#Notification').show();
    $('#Notification').fadeOut(2000);
}
/********** Record save Deleted notification End *****************/


/**************** Expport to Html**************************/
function htmlView() {
    //var Id = document.getElementById(visitID).value.split(';')[0];

    window.open(getRootPath() + "HtmlView.htm", "window", "top=10,left=100,height=630px,width=750px,menubar=yes,scrollbars=1,address=0", true);
    return false;
}

function getRootPath() {
    var searchString = document.location.search;

    // strip off the leading '?'
    searchString = searchString.substring(1);

    var nvPairs = searchString.split("/");
    var loc = "";
    for (i = 0; i < nvPairs.length - 3; i++) {
        loc = loc + "../";
    }
    return loc;
}
/*****************Expport to Html End***************************/


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
            alert("Please Enter Valid Mobile Number.");
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
            alert("Please Enter Valid Email Address.");
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

//------------------------//
//-----Progress Window Start------//
//Sys.WebForms.PageRequestManager.getInstance().add_beginRequest(BeginRequestHandler);
//Sys.WebForms.PageRequestManager.getInstance().add_endRequest(endRequestHandler);
//function BeginRequestHandler(sender, args) {
//    var state = document.getElementById('myProgressDivID').style.display;
//    //if (state == 'block') {
//    //    document.getElementById('myProgressDivID').style.display = 'none';
//    //}
//    //else {
//    document.getElementById('myProgressDivID').style.display = 'block';
//    //}
//}
function endRequestHandler(sender, args) {
    //var state = document.getElementById('myProgressDivID').style.display;
    //if (state == 'block') {
    document.getElementById('myProgressDivID').style.display = 'none';
    //}
    //else {
    //    document.getElementById('myProgressDivID').style.display = 'block';

    //}
}
//-----Progress Window End------//

function GetQueryStringParameterByName(name) {
    name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
        results = regex.exec(location.search);
    return results === null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
}