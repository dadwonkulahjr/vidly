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
        ],
        'language': {
            'emptyTable': 'No data has been added yet!'
        },
        'width': '100%'
    });

}



