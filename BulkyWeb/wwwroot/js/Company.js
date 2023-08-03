var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url:'/admin/company/getall'},
        "columns": [
            { data: 'name', "width": "30%" },
            { data: 'phoneNumber', "width": "20%" },
            { data: 'streetAddress', "width": "10%" },
            { data: 'city', "width": "5%" },
            { data: 'state', "width": "10%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                                <a href="/admin/company/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="fa-regular fa-pen-to-square" style="color: #ffffff;"></i> Edit</a>
                                <a href="/admin/company/delete/${data}" class="btn btn-danger mx-2"> <i class="fa-regular fa-square-minus" style="color: #ffffff;"></i> Delete</a> 
                            </div>`
                },
                "width": "25%"
            }
        ]
    });
}