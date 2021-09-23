var dataTable;

$(document).ready(function () {
    loadList();
});

function loadList() {
    dataTable = $('#movies').DataTable({
        responsive: true,
        'ajax': {
            'url': '/api/movies',
            'type': 'GET',
            'dataSrc': '',
            'dataType': 'json'
        },
        'columns': [
            {
                'data': 'name',
                'render': function (data, type, movie) {
                    return "<a href='/api/movies/edit/" + movie.id + "'>" + movie.name + "</a>";
                }
            },
            {
                'data': 'genre.name'
            },
            {
                'data': 'genre.releaseDate',
                'render': function (data, type, movie) {
                    return moment(movie.releaseDate).format('DD/MM/YYYY');
                }

            },
            {
                'data': 'genre.numberInStock'
            },
            {
                'data': 'id',
                'render': function (data) {
                    return "<button class='btn btn-danger js-delete' data-movie-id=" + data + ">Delete</button>";
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
    $('#movies').on('click', ".js-delete", function () {
        var button = $(this);
        bootbox.confirm('Are you sure you want to delete this movie?', function (result) {
            if (result) {
                $.ajax({
                    url: '/api/movies/' + button.attr('data-movie-id'),
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

