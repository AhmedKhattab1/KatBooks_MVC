var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url:'/admin/product/getall'},
        "columns": [
            { data: 'title', "width": "20%" },
            { data: 'author', "width": "20%" },
            { data: 'isbn', "width": "10%" },
            { data: 'listPrice', "width": "10%" },
            { data: 'category.name', "width": "10%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-0 btn btn-group" style="display: flex; justify-content: center;" role="group">
                                <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="fa-regular fa-pen-to-square" style="color: #ffffff;"></i> Edit</a>
                                <a href="/admin/product/delete/${data}" class="btn btn-danger mx-2"> <i class="fa-regular fa-trash-can" style="color: #ffffff;"></i> Delete</a> 
                            </div>`
                },
                "width": "25%"
            }
        ]
    });
}