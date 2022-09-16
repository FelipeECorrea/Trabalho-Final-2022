$(document).ready(function () {
  // knowledge-base search
  $(function () {
    "use strict";
    // Filter
    $("#searchbar").on("keyup", function () {
      var value = $(this).val().toLowerCase();
      if (value != "") {
        $(".kb-content-info .kb-content-card").filter(function () {
          $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1);
        });
        var search_row = $(".kb-content-info .kb-content-card:visible").length;
        // if search-content doesn't have row, then show a message
        if (search_row == 0) {
          $('.kb-content-info .kb-no-content').removeClass('d-none');
        }
      }
      else {
        // If filter box is empty
        $(".kb-content-info .kb-content-card").show();
        // Hide the message when search is empty
        $('.kb-content-info .kb-no-content').addClass('d-none');
      }
    });
  });
  // knowledge-base-categories & knowledge-base-question sidebar
  if ($('button').hasClass('kb-menu')) {
    // on click of button
    $('.kb-menu').on('click', function () {
      $(".kb-sidebar").toggleClass('show');
      $(".kb-overlay").toggleClass('show');
      $("body").css("overflow", "hidden");
      $(".card").addClass("shadow-none");
    });
    // on click of close-icon or overlay
    $('.kb-close-icon, .kb-overlay').on('click', function () {
      $(".kb-sidebar").removeClass('show');
      $(".kb-overlay").removeClass('show');
      $("body").css("overflow", "auto");
      $(".card").removeClass("shadow-none");
    });
  }
});
$(".kb-categories .users-list li").on("click", function(e) {
  e.stopPropagation();
});
