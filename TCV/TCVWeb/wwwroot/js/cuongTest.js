    function AreYouSureFunction(source) {
            //Prompt for confirmation
                $.ajax({
                    url: source,
                }).done(function () {
                    //Item created!
                    alert("Item Added!");
                });
                //This prevents the default behavior of the actual link (it will hit your controller action)
                return false;
        }

function AddToCartWithQuantity(id){
    //Get
    var qt = $('#product-vqty').val();

        $.ajax({
                url: "/Cart/AddToCart/"+id+"?quantity="+qt,
                }).done(function () {
                    //Item created!
                    alert("Item Added!");
                });
   return false;
}

function RemoveProduct(id){
    var currentQuantity = parseInt($("#quantity-"+id).val());
    var currentSubTotal = parseInt($("#sub-total-"+id).text());
    var currentGrandTotal = parseInt($("#grand-total").text());

    var unitPerProduct = currentSubTotal/currentQuantity

       $.ajax({
                url: "/Cart/RemoveProduct/"+id,
                }).done(function () {
                    $('#'+id).remove();
                    $('#cart-'+id).remove();

                    $("#grand-total").text(currentGrandTotal-currentSubTotal);
                });
    return false;
}

function ClearCart(){
        $.ajax({
                url: "/Cart/ClearCart",
                }).done(function () {
                    $('.cart-items').remove();
                    $("#grand-total").text(0)
                });
    return false;       
}

function DecreaseQuantity(id) {
    var currentQuantity = parseInt($("#quantity-"+id).val());
    var currentSubTotal = parseInt($("#sub-total-"+id).text());
    var currentGrandTotal = parseInt($("#grand-total").text());

    var unitPerProduct = currentSubTotal/currentQuantity

    if (currentQuantity != 1){
        $.ajax({
                url: "/Cart/DecreaseQuantity/"+id,
                }).done(function () {
                    $("#quantity-"+id).val(currentQuantity-1);
                    $("#sub-total-"+id).text((currentSubTotal/currentQuantity)*(currentQuantity-1))

                    $("#sub2-total-"+id).text((currentSubTotal/currentQuantity)*(currentQuantity-1))
                    $("#grand-total").text(currentGrandTotal-unitPerProduct)
                });
    }
    return false;
}

function IncreaseQuantity(id) {
    var currentQuantity = parseInt($("#quantity-"+id).val());
    var currentSubTotal = parseInt($("#sub-total-"+id).text());
    var currentGrandTotal = parseInt($("#grand-total").text());

    var unitPerProduct = currentSubTotal/currentQuantity

    $.ajax({
           url: "/Cart/IncreaseQuantity/"+id,
           }).done(function () {
                $("#quantity-"+id).val(currentQuantity+1);
                $("#sub-total-"+id).text(unitPerProduct*(currentQuantity+1))
                $("#sub2-total-"+id).text((currentSubTotal/currentQuantity)*(currentQuantity+1))
                $("#grand-total").text(currentGrandTotal+unitPerProduct)
           });          
    return false;
}

function SelectPageSize(url){
  var pageSize = document.getElementById("page-size").value;
  var baseUrl = window.location.pathname

    window.location.href = baseUrl+"?pageSize="+pageSize;

}