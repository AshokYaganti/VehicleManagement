$(function () {
$('#registeredUsers').dataTable({
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
         { "orderable": true, className:"min-desktop" },		
	],

    });    
});