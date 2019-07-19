function addToCart(id) {
    $.ajax({
        type: 'POST',
        url: '/api/cart?id=' + id,
        success: function () {
            alert("item added to cart");
        },
        error: function () {
            alert("something went wrong!");
            // to-do
        }
    });
}