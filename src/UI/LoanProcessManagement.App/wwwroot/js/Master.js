﻿

$(document).ready(function () {
    $('#selectVideo').click(function () {
        console.log($('#selectVideo').val())
        if ($('#selectVideo').val() == 1) {
            $("#div_dynamicTables").load("../Master/GetRoleMaster");
            //$.ajax({
            //    type: 'GET',
            //    url: "/RoleMaster",
            //    async: false,
            //    contentType: 'application/json',
            //    success: function (data) {

            //        $('#showTable').empty();
            //        $('#div').empty();

            //        masterData = data[Object.keys(data)[3]];
            //        len = data[Object.keys(data)[3]].length;
            //        console.log(masterData);

            //        $('#div').append
            //            (`
            //                <button class="btn-default-submit float-left ml-1" id="act1" onclick="location.href='http://localhost:14018/Master/AddRole'">Add New Role</button>                        
            //            `)
            //        for (i = 0; i < len; i++) {

            //            $('#showTable').append
            //                (`

            //                     <tr>
            //                    <td>${masterData[i].id}</td>
            //                     <td>${masterData[i].roleName}</td>
            //                     <td>${masterData[i].isActive}</td>
            //                     <td>${masterData[i].lastModifiedDate}</td>
            //                     <td>${masterData[i].createdDate}</td>
            //                      <td><button id="updateBtn" class="btn btn-primary btn-md"
            //                          onclick="location.href='http://localhost:14018/Master/UpdateRole/'+'${masterData[i].id}'">Update</button>
            //                          </td>
            //                        <td><a href="DeleteRole", "Master", new { Id = ${masterData[i].id}}" onclick="return confirm('Are you sure you want to Delete?')" class="btn btn-danger">Delete</a></td>
            //                    </tr>

            //            `);
            //        }
            //    },

            //    error: function (error) {
            //        ajaxErrorOccured();
            //    }
            //});
        }
        else if ($('#selectVideo').val() == 5) {
            $("#div_dynamicTables").load("../Master/GetLostLeadReasonMaster");
        }
        else if ($('#selectVideo').val() == 6) {
            $("#div_dynamicTables").load("../Master/GetRejectLeadReasonMaster");
        }
        else if ($('#selectVideo').val() == 2) {
            $("#div_dynamicTables").load("/Master/GetAllBranches");
        }
        else if ($('#selectVideo').val() == 7) {
            $("#div_dynamicTables").load("/Master/GetAllQueryType");
        }
        else if ($('#selectVideo').val() == 8) {
            $("#div_dynamicTables").load("/Master/GetAllScheme");
        }
        else if ($('#selectVideo').val() == 9) {
            $("#div_dynamicTables").load("/Master/GetAllLpmCategories");
        }
        else if ($('#selectVideo').val() == 10) {
            $("#div_dynamicTables").load("/Master/GetAllInstitution");
        }
        else if ($('#selectVideo').val() == 11) {
            $("#div_dynamicTables").load("/Master/GetAllLeadStatus");
        }
        else if ($('#selectVideo').val() == 12) {
            $("#div_dynamicTables").load("/Master/GetAllQualification");
        }
        
    });

});