
$(document).ready(function () {

    $("button").click(function () {
        var lines = [];
        $.each($("input[id='toInvoice']:checked"), function () {
            var price = $(this).data("price");
            var id = $(this).data("id");
            lines.push({
                Price: parseFloat(price.replace(",", ".")), Id: id});
        });
      
        var customerId = $('#customerId :selected').text();// $("#customerId: selected").val();
        $.ajax({
            url: '/Invoice/AddNew/',
            type: 'Post',
            data: {
                lines: lines,
                customerid: null    

            }
        });
    });
    Customer();
});


function Customer() {
    $.ajax({
        type: "GET",
        url: "/Customer/CustomerDDL",
        success: function (result) {
            $("#CustomerResults").html("");
            $("#CustomerResults").append(result);
        },
        error: function () {
            $("#CustomerResults").html("");
            $("#CustomerResults").append("Brak danych");
        }
    });
}
