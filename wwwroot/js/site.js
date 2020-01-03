// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

/* Personnages > Sorts */
// Two Bootstrap's list-groups are used to simulate two columns.
// Fixes the duplicate active class
$(".custom-spell-item").on('click', function() {
    $(".custom-spell-item").each(function(index) {
      $(this).removeClass("active show");
    });
  })
/* END OF : Personnages > Sorts */