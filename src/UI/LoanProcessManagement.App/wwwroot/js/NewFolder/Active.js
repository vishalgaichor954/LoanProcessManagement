﻿$(document).ready(function () {
    var path = window.location.pathname;
    var temp = path.split('/');
    if (temp[2] == 'leadstatus') {
        var element = $(".nav-item a[href='" + path + "']");
        element.addClass("active");
    }
    else if (temp[1] == 'Leadlist') {
        var element = $(".nav-item a[href='" + path + "']");
        element.addClass("active");
    }
    else if (temp[1] == 'ChangePasswordUI') {
        var element = $(".nav-item a[href='" + path + "']");
        element.addClass("active");
    }
    else if (temp[1] == 'AddUser') {
        var element = $(".nav-item a[href='" + path + "']");
        element.addClass("active");
    }
    else if (temp[1] == 'UserList') {
        var element = $(".nav-item a[href='" + path + "']");
        element.addClass("active");
    }
    else if (temp[1] == 'MenuList') {
        var element = $(".nav-item a[href='" + path + "']");
        element.addClass("active");
    }
    else if (temp[1] == 'AddLead') {
        var element = $(".nav-item a[href='" + path + "']");
        element.addClass("active");
    }
    else if (temp[1] == 'TrainingVideos') {
        var element = $(".nav-item a[href='" + path + "']");
        element.addClass("sub");
    }
    else if (temp[1] == 'ReportsLeadList') {
        var element = $(".nav-item a[href='" + path + "']");
        element.addClass("sub");
    }
});



