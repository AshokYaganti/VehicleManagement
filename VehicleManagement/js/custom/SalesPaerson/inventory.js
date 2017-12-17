$(function () {
$('#carsinventory').dataTable({
        responsive: true,
        "columns": [ 
         { "orderable": true, className:"all" },
         { "orderable": true, className:"all" },
         { "orderable": true, className:"all" },
         { "orderable": true, className:"min-desktop" },
         { "orderable": true, className:"min-desktop" },
         { "orderable": true, className:"min-desktop" },
		 { "orderable": true, className:"min-desktop" },
		 { "orderable": true, className:"min-desktop" },
         { "orderable": true, className:"min-desktop" },
		 { "orderable": false, className:"min-desktop" },
          { "orderable": false, className:"min-desktop" },
         { "orderable": false, className:"min-desktop" },
         { "orderable": false, className:"min-desktop" },	
	],

    });

      $(".updatecls").click(function (e2) {
        e2.preventDefault();
        var vin = $(this).closest("tr").find('td:eq(0)').text();
        var make = $(this).closest("tr").find('td:eq(1)').text();
        var modal = $(this).closest("tr").find('td:eq(2)').text();
        var price = $(this).closest("tr").find('td:eq(6)').text();
        var inventoryid = $(this).closest("tr").find('td:eq(11)').text();

        $('#vin').val(vin);
        $('#make').val(make);
        $('#modal').val(modal);
        $('#price').val(price);
        $('#inventoryid').val(inventoryid);


    });


    $(".deleteecls").click(function (e3) {
        e3.preventDefault();
         var inventoryid = $(this).closest("tr").find('td:eq(11)').text();
        $('#iid').val(inventoryid);
    });

      $("#updatebtn").click(function () {

        var price = $("#price").val();        
        var inventoryid = $("#inventoryid").val();          
            $.ajax({
                type: "POST",
                url: "ManageInventory.aspx/updateInventory",
                data: "{ price:\"" + price + "\", inventoryid:\"" + inventoryid + "\"}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    if (data.d == "success") {
                        $("#updatebtn").remove();
                        $("#updateModel .modal-body").html("Car inventory record has been updated");
                        $('.closebtn').click(function () { location.reload(); });                       
                    } else {
                        $("#updatebtn").remove();
                        $("#updateModel .modal-body").html("Something went wrong with this request.Please try again later");
                    }
                },
                error: function () {
                    $("#updatebtn").remove();
                    $("#updateModel .modal-body").html("Something went wrong with this request.Please try again later");
                }

            });       

    });

    $("#deletebtn").click(function () {

        var iid = $("#iid").val();

        $.ajax({
            type: "POST",
            url: "ManageInventory.aspx/deleteInventory",
            data: "{ iid:\"" + iid + "\" }",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                if (data.d == "success") {
                    $("#deletebtn").remove();
                    $("#deleteModal .modal-body").html("Car inventory record has been deleted");
                    $('.closebtn').click(function () { location.reload(); });                   
                } else {
                    $("#deletebtn").remove();
                    $("#deleteModal .modal-body").html("Something went wrong with this request.Please try again later");
                }
            },
            error: function () {
                $("#deletebtn").remove();
                $("#deleteModal .modal-body").html("Something went wrong with this request.Please try again later");
            }

        });
    });
});