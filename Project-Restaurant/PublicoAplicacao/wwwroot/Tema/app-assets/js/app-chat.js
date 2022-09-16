$(document).ready(function () {
  $('.chat-application').height($(window).height() - $('.navbar').height() - 100);
  $(window).resize(function () {
    $('.chat-application').height($(window).height() - $('.navbar').height() - 100);
  });

  // Add perfect scrollbar when not touch screen
  if (!$.app.menu.is_touch_device()) {
    // Chat list
    if ($('.users-list-padding').length > 0) {
      var email_app_sidebar_content = new PerfectScrollbar('.users-list-padding', {
        wheelPropagation: false
      });
    }
    // Chat content
    if ($('.chat-app-window').length > 0) {
      var email_app_mail_content_detail = new PerfectScrollbar('.chat-app-window', {
        wheelPropagation: false
      });
    }
  } else {
    $(".users-list-padding").css("overflow", "scroll")
    $(".chat-app-window").css("overflow", "scroll")
  }

  // Sidebar menu close button on click remove show class form both compose mail sidebar and App content overlay
  $('.chat-application').find(".sidebar-close-icon").on('click', function () {
    $('.chat-sidebar').removeClass('d-block');
    $(".app-content-overlay").removeClass('show');
  });

  $('.chat-app-sidebar-toggle').on('click', function () {
    $('.app-content-overlay').addClass('show');
  });

  $('.app-content-overlay').on('click', function () {
    $(this).removeClass('show');
  });

  // window resize
  $(window).on("resize", function () {
    // remove show classes from overlay when resize, if size is > 767
    if ($(window).width() > 767) {
      if ($('.app-content-overlay').hasClass("show")) {
        $('.app-content-overlay').removeClass("show");
      }
    }
  });
});

// Add message to chat
function chatMessagesSend(source) {
  var message = $(".chat-message-send").val();
  if ((message != "") && message != " ") {
    var html = '<div class="chat-content">' + "<p>" + message + "</p>" + "</div>";
    $(".chat-app-window .chat:last-child .chat-body").append(html);
    $(".chat-message-send").val("");
    $(".chat-app-window").scrollTop($(".chat-app-window > .chats").height());
  }
}
