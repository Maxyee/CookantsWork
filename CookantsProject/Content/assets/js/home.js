function LoadProduct(SubZoneId) {
    var url = "/Food/Index/" + $(SubZoneId).val();
    console.log(url);
    window.location.href = url;
 
};
$("#slideshow > div:gt(0)").hide();

setInterval(function () {
    $('#slideshow > div:first')
      .fadeOut(1000)
      .next()
      .fadeIn(1000)
      .end()
      .appendTo('#slideshow');
}, 3000);
var MaterialItems = []
function LoadMaterialItem(element) {
    if (MaterialItems.length == 0) {
        //ajax function for fetch data
        $.ajax({
            type: "GET",
            url: '/Home/GetAllSubZone',
            success: function (data) {
                MaterialItems = data;
                //render catagory
                renderMaterialItems(element);
            }
        })
    }
    else {
        //render catagory to the element
        renderMaterialItems(element);
    }
}
function renderMaterialItems(element) {
    var $ele = $(element);
    $ele.empty();
    $ele.append($('<option/>').val('0').text('Enter Your Area(e.g. Banani Dhaka)'));
    $.each(MaterialItems, function (i, val) {
        $ele.append($('<option/>').val(val.Id).text(val.Name));
    })
}
LoadMaterialItem($('#materialItem'));
