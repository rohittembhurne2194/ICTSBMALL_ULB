$(document).ready(function () {
    var UserId = $('#selectnumber').val();

    $.ajax({
        type: "post",
        url: "/Location/UserList",
        data: { userId: UserId, },
        datatype: "json",
        traditional: true,
        success: function (data) {
            district = '<option value="-1">Select Employee</option>';
            for (var i = 0; i < data.length; i++) {
                district = district + '<option value=' + data[i].Value + '>' + data[i].Text + '</option>';
            }
            //district = district + '</select>';
            $('#selectnumber').html(district);
        }
    });

    var table = $("#demoGrid").DataTable({

    
        "sDom": "ltipr",
        "order": [[0, "desc"]],
     //   "processing": true, // for show progress bar
        "serverSide": true, // for process server side
        "filter": true, // this is for disable filter (search box)
        "orderMulti": false, // for disable multiple column at once
        "pageLength": 10,

        "ajax": {
            "url": "/Datable/GetJqGridJson?rn=BCDumpYardTrip",
            "type": "POST",
            "datatype": "json"
        },

        "columnDefs":
            [{
                "targets": [0],
                "visible": false,
                "searchable": false
            }
                ,
                {
                    "targets": [1],
                    "visible": false,
                    "searchable": false
                },

                {
                    "targets": [12],

                    "visible": true,

                    "render": function (data, type, full, meta) {

                     

                        if (full["TStatus"] == "0") {
                            return "<div class='circle' style='height: 20px;width: 20px;background-color: #f44336;border-radius: 50%;    vertical-align: middle;display: inline-flex;'></div> (Failed !)";
                        }
                        else if (full["TStatus"] == "1") {
                            return "<div class='circle' style='height: 20px;width: 20px;background-color: #388e3c;border-radius: 50%;vertical-align: middle;display: inline-flex;'></div> (Success)";

                        }
                        else {
                            return "<div class='circle' style='height: 20px;width: 20px;background-color: #0086c3;border-radius: 50%;vertical-align: middle;display: inline-flex;'></div> (In Process)";

                        }

                    },
                },
            ],

        "columns": [
            { "data": "TransBcId", "name": "TransBcId", "autoWidth": false },
            { "data": "bcTransId", "name": "bcTransId", "autoWidth": false },
            { "data": "startDateTime", "name": "startDateTime", "autoWidth": false },
            { "data": "endDateTime", "name": "endDateTime", "autoWidth": false },
            { "data": "dyId", "name": "dyId", "autoWidth": false },
            { "data": "userName", "name": "userName", "autoWidth": false },
            { "data": "vehicleNumber", "name": "vehicleNumber","autoWidth": false },
            { "data": "tripNo", "name": "tripNo", "autoWidth": false },
            { "data": "totalGcWeight", "name": "totalGcWeight", "autoWidth": false },
            { "data": "totalDryWeight", "name": "totalDryWeight", "autoWidth": false },
            { "data": "totalWetWeight", "name": "totalWetWeight", "autoWidth": false },
            {
                "data": "bcTransId",
                "render": function (data, type, row, meta) {
                    if (type === 'display') {
                        data = '<a target="_blank" href="https://mumbai.polygonscan.com/tx/' + data + '">View Transaction</a>';
                    }

                    return data;
                }
            },

            { "data": "TStatus", "name": "TStatus", "autoWidth": false },
        ]
    });
});

function ViewBT(bcTransId) {
    debugger;
    window.location.href = "https://mumbai.polygonscan.com/tx/" + bcTransId;
};

function noImageNotification() {
    document.getElementById("snackbar").innerHTML = "Image not uploaded...";
    var x = document.getElementById("snackbar");
    x.className = "show";
    setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
}

function PopImages(cel) {

    $('#myModal_Image').modal('toggle');

    var addr = $(cel).find('.addr-length').text();
    var date = $(cel).find('.li_date').text();
    var imgsrc = $(cel).find('img').attr('src');
    var head = $(cel).find('.li_title').text();
    jQuery("#latlongData").text(addr);
    jQuery("#dateData").text(date);
    jQuery("#imggg").attr('src', imgsrc);
    //jQuery("#latlongData").text(cellValue);
    jQuery("#header_data").html(head);
}
function showInventoriesGrid() {
    Search();
}

function Search() {
    var txt_fdate, txt_tdate, Client, UserId;
    var name = [];
    var arr = [$('#txt_fdate').val(), $('#txt_tdate').val()];

    for (var i = 0; i <= arr.length - 1; i++) {
        name = arr[i].split("/");
        arr[i] = name[1] + "/" + name[0] + "/" + name[2];
    }

    txt_fdate = arr[0];
    txt_tdate = arr[1];
    UserId = $('#selectnumber').val();
    ZoneId = $('#ZoneId').val();
    WardId = $('#WardNo').val();
    AreaId = $('#AreaId').val();
    Client = " ";
    NesEvent = " ";
    var Product = "";
    var catProduct = "";
    var value = txt_fdate + "," + txt_tdate + "," + UserId + "," + $("#s").val() + "," + ZoneId + "," + WardId + "," + AreaId;//txt_fdate + "," + txt_tdate + "," + UserId + "," + Client + "," + NesEvent + "," + Product + "," + catProduct + "," + 1;
    // alert(value );
    oTable = $('#demoGrid').DataTable();
    oTable.search(value).draw();
    oTable.search("");
    document.getElementById('USER_ID_FK').value = -1;
}