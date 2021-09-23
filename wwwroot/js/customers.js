var dataTable;

$(document).ready(function () {
    loadList();
});

function loadList() {
    dataTable = $('#customers').DataTable({
        responsive: true,
        'ajax': {
            'url': '/api/customers',
            'type': 'GET',
            'dataSrc': '',
            'dataType': 'json'
        },
        'columns': [
            {
                'data': 'name',
                'render': function (data, type, customer) {
                    return "<a href='/api/customers/edit/" + customer.id + "'>" + customer.name + "</a>";
                }
            },
            {
                'data': 'membershipType.name'
            },
            {
                'data': 'gender.name'
            },
            {
                'data': 'birthDate',
                'render': function (data, type, customer) {
                    return moment(customer.birthDate).format('DD/MM/YYYY');
                }

            },
            {
                'data': 'id',
                'render': function (data) {
                    return "<button class='btn btn-danger js-delete' data-customer-id=" + data + ">Delete</button>";
                }
            }

        ],
        'language': {
            'emptyTable': 'No data has been added yet!'
        },
        'width': '100%'
    });

}



$(document).ready(function () {
    $('#customers').on('click', ".js-delete", function () {
        var button = $(this);
        bootbox.confirm('Are you sure you want to delete this customer?', function (result) {
            if (result) {
                $.ajax({
                    url: '/api/customers/' + button.attr('data-customer-id'),
                    method: 'DELETE',
                    success: function (data) {
                        if (data.success) {
                            dataTable.row(button.parents('tr')).remove().draw();
                            toastr.success(data.message);
                            dataTable.ajax.reload();
                        } else {
                            toastr.error(data.message);
                        }
                    }
                })
            }
        });
    });
});

