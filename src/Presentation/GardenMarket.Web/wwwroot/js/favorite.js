function like(id) {
    $.ajax({
        type: 'POST',
        url: '/api/favorite?id=' + id,
        success: function () {
            // to-do
        },
        error: function () {
            alert("something went wrong!");
            // to-do
        }
    });
}