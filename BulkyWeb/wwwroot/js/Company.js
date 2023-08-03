var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url:'/admin/company/getall'},
        "columns": [
            { data: 'name', "width": "15%" },
            { data: 'phoneNumber', "width": "15%" },
            { data: 'streetAddress', "width": "20%" },
            { data: 'city', "width": "10%" },
            { data: 'state', "width": "10%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-0 btn btn-group" style="display: flex; justify-content: center;" role="group">
                                <a href="/admin/company/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="fa-regular fa-pen-to-square" style="color: #ffffff;"></i> Edit</a>
                                <a href="/admin/company/delete/${data}" class="btn btn-danger mx-2"> <i class="fa-regular fa-trash-can" style="color: #ffffff;"></i> Delete</a> 
                            </div>`
                },
                "width": "30%"
            }
        ]
    });
}