$(function () {
$('#deletedinventory').dataTable({
        responsive: true,
        "columns": [
         { "orderable": true, className:"all" }, 
         { "orderable": true, className:"all" },
         { "orderable": true, className:"all" },
         { "orderable": true, className:"all" },
         { "orderable": true, className:"min-desktop" },
         { "orderable": true, className:"min-desktop" },
         { "orderable": true, className:"none" },
		 { "orderable": true, className:"none" },
		 { "orderable": true, className:"min-desktop" },
         { "orderable": true, className:"min-desktop" },
		 { "orderable": false, className:"min-desktop" },        
         { "orderable": false, className:"min-desktop" }, 	
	],

    });    
});