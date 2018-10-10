    function AreYouSureFunction(source) {
            //Prompt for confirmation

            $.ajax(
                {
                    url: source,
                    success: function (partialView)
                    {
                        $('#cartdetails').html(partialView);
                        alert("Item Added!");
                    }
                });

                //This prevents the default behavior of the actual link (it will hit your controller action)
                return false;
        }

function AddToCartWithQuantity(id){
    //Get
    var qt = $('#product-vqty').val();

            $.ajax(
                {
                    url: "/Cart/AddToCart/"+id+"?quantity="+qt,
                    success: function (partialView)
                    {
                        $('#cartdetails').html(partialView);
                        alert("Item Added!");
                    }
                });
                //This prevents the default behavior of the actual link (it will hit your controller action)
                return false;
}

function RemoveProduct(id){
    var currentQuantity = parseInt($("#quantity-"+id).val());
    var currentSubTotal = parseInt($("#sub-total-"+id).text());
    var currentGrandTotal = parseInt($("#grand-total").text());

    var unitPerProduct = currentSubTotal/currentQuantity

       $.ajax({
                url: "/Cart/RemoveProduct/"+id,
                success: function (partialView)
                    {
                    $('#cartdetails').html(partialView);
                    $('#'+id).remove();
                    $('#cart-'+id).remove();
                    $("#grand-total").text(currentGrandTotal-currentSubTotal);
                    }
                });

    return false;
}

function ClearCart(){
        $.ajax({
                url: "/Cart/ClearCart",
                success: function (partialView) {
                    $('#cartdetails').html(partialView);
                    $('.cart-items').remove();
                    $("#grand-total").text(0)
                    }
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
                success: function (partialView) {
                    $('#cartdetails').html(partialView);
                    $("#quantity-"+id).val(currentQuantity-1);
                    $("#sub-total-"+id).text((currentSubTotal/currentQuantity)*(currentQuantity-1))

                    $("#sub2-total-"+id).text((currentSubTotal/currentQuantity)*(currentQuantity-1))
                    $("#grand-total").text(currentGrandTotal-unitPerProduct)
                    }
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
           success: function (partialView) {
                $('#cartdetails').html(partialView);
                $("#quantity-"+id).val(currentQuantity+1);
                $("#sub-total-"+id).text(unitPerProduct*(currentQuantity+1))
                $("#sub2-total-"+id).text((currentSubTotal/currentQuantity)*(currentQuantity+1))
                $("#grand-total").text(currentGrandTotal+unitPerProduct)
                }
           });          
    return false;
}

function SelectPageSize(url){
  var pageSize = document.getElementById("page-size").value;
  var baseUrl = window.location.pathname

    window.location.href = baseUrl+"?pageSize="+pageSize;

}