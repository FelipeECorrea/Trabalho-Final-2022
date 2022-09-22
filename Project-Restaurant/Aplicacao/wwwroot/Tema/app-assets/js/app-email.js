$(document).ready(function () {

  // Add perfect scrollbar when not touch screen
  if (!$.app.menu.is_touch_device()) {
    // Email app sidebar
    if ($('.email-app-sidebar-content').length > 0) {
      var email_app_sidebar_content = new PerfectScrollbar('.email-app-sidebar-content');
    }
    // Email list
    if ($('.email-app-list').length > 0) {
      var email_app_list = new PerfectScrollbar('.email-app-list');
    }
    // Email content
    if ($('.email-app-mail-content-detail').length > 0) {
      var email_app_mail_content_detail = new PerfectScrollbar('.email-app-mail-content-detail');
    }
  } else {
    $(".email-app-sidebar-content").css("overflow", "scroll")
    $(".email-app-list").css("overflow", "scroll")
    $(".email-app-mail-content-detail").css("overflow", "scroll")
  }

  // Add class active on click of sidebar list folder and label
  $('.email-application').find(".list-group-messages a,.list-group-labels a").on('click', function () {
    var $this = $(this);
    if ($('.email-application').find('.list-group-messages a,.list-group-labels a').hasClass('active')) {
      $('.email-application').find('.list-group-messages a,.list-group-labels a').removeClass('active');
      $this.addClass("active");
    }
  });

  // Sidebar menu close button on click remove show class form both compose mail sidebar and App content overlay
  $('.email-application').find(".sidebar-close-icon").on('click', function () {
    $('.email-app-sidebar').removeClass('show');
    $(".app-content-overlay").removeClass('show');
  });


  $('.email-app-list .list-group-item').on('click', function () {
    $('.email-app-mail-content').addClass('show-email-content');
  });

  $('.back-to-inbox').on('click', function () {
    $('.email-app-mail-content').removeClass('show-email-content');
  });

  $('.email-app-sidebar-toggle').on('click', function () {
    $('.app-content-overlay').addClass('show');
    $('.email-app-sidebar').addClass('show');
  });

  $('.app-content-overlay').on('click', function () {
    $(this).removeClass('show');
    $('.email-app-sidebar').removeClass('show');
    $('.compose-new-mail-sidebar').removeClass('show');
    $('#compose-form').find('input').val(""); // input filed reset when close or cancel
    var file_input = $(".custom-file .custom-file-label"); // file input content
    file_input[0].innerHTML = "Attach File";
    var quill_editor = $("#compose-form .ql-editor"); // quill editor content
    quill_editor[0].innerHTML = "";
  });

  // Compose email sidebar close icon
  $('.email-application').find(".compose-sidebar-close-icon").on('click', function () {
    $('.compose-new-mail-sidebar').removeClass('show');
    $(".app-content-overlay").removeClass('show');
    $('#compose-form').find('input').val(""); // input filed reset when close or cancel
    var file_input = $(".custom-file .custom-file-label"); // file input content
    file_input[0].innerHTML = "Attach File";
    var quill_editor = $("#compose-form .ql-editor"); // quill editor content
    quill_editor[0].innerHTML = "";
  });
  // Compose email sidebar show
  $('.compose-email-btn').on('click', function () {
    $('.email-app-sidebar').removeClass('show');
    $('.app-content-overlay').addClass('show');
    $('.compose-new-mail-sidebar').addClass('show');
  });
  // Cancel button in compose email sidebar
  $('.email-application').find(".compose-cancel-btn").on('click', function () {
    $('.compose-new-mail-sidebar').removeClass('show');
    $(".app-content-overlay").removeClass('show');
    $('#compose-form').find('input').val(""); // input filed reset when close or cancel
    var file_input = $(".custom-file .custom-file-label"); // file input content
    file_input[0].innerHTML = "Attach File";
    var quill_editor = $("#compose-form .ql-editor"); // quill editor content
    quill_editor[0].innerHTML = "";
  });
  //email new compose message compose field
  var composeMailEditor = new Quill('.snow-container .compose-editor', {
    modules: {
      toolbar: '.compose-quill-toolbar'
    },
    placeholder: 'Type something..... ',
    theme: 'snow'
  });

  // window resize
  $(window).on("resize", function () {
    // remove show classes from overlay when resize, if size is > 1200
    if ($(window).width() > 1200) {
      if ($('.app-content-overlay').hasClass("show")) {
        $('.app-content-overlay').removeClass("show");
      }
      if ($('.compose-new-mail-sidebar').hasClass("show")) {
        $('.compose-new-mail-sidebar').removeClass("show");
      }
      if ($('.email-app-sidebar').hasClass("show")) {
        $('.email-app-sidebar').removeClass("show");
      }
    }
  });
});
