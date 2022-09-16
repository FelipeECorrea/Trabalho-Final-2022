$(document).ready(function () {

  // Notification sidebar toggle & close button click events  [Remove code from production]
  $('.notification-sidebar-toggle').on('click', function (e) {
    $('.notification-sidebar').toggleClass('open');
    $(".main-content").css("cursor", "pointer");
  });
  $('.notification-sidebar-close').on('click', function () {
    $('.notification-sidebar').removeClass('open');
    $(".main-content").css("cursor", "auto");
  });

  // Perfect Scrollbar for the nav tab content
  if ($('.notification-sidebar-content').length > 0) {
    var notification_sidebar_content = new PerfectScrollbar('.notification-tab-content', {
      wheelPropagation: false
    });
  }

  // Click on main-content closes the notification drawer and ends pointer cursor
  $(".main-content").on("click", function () {
    if ($(".notification-sidebar.open").length) {
      $('.notification-sidebar').removeClass('open');
      $(".main-content").css("cursor", "auto");
    }
  })
});
