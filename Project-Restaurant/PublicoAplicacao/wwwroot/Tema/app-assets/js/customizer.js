$(document).ready(function() {
  /********************************
   *           Customizer          *
   ********************************/
  var body = $("body"),
    mainMenu = $(".app-sidebar"),
    mainMenuContent = $(".main-menu-content"),
    default_bg_color = mainMenu.attr("data-background-color"),
    default_bg_image = mainMenu.attr("data-image"),
    customizer = $(".customizer");

  $('.cz-bg-color span[data-bg-color="' + default_bg_color + '"]').addClass("selected");
  $('.cz-bg-color span[data-bg-color="' + default_bg_color + '"]').addClass("selected");
  $('.cz-bg-image img[src$="' + default_bg_image + '"]').addClass("selected");

  // Customizer toggle & close button click events  [Remove customizer code from production]
  $(".customizer-toggle").on("click", function() {
    customizer.toggleClass("open");
  });
  $(".customizer-close").on("click", function() {
    customizer.removeClass("open");
  });

  // Customizer perfect scrollbar
  if ($(".customizer-content").length > 0) {
    var customizer_content = new PerfectScrollbar('.customizer-content', {
      theme: "dark",
      wheelPropagation: false
    });
  }

  // Layout Config
  if ($("body.layout-dark").length > 0) {
    $(".layout-switch").find(".dark-layout #dl-switch").attr("checked", true);
    $(".sb-color-options").find(".gradient-man-of-steel").removeClass("selected");
    $(".sb-color-options").find(".bg-black").addClass("selected");
  }
  if ($("body.navbar-static").length > 0) {
    $('#nav-static').attr('checked',true);
  }
  if ($("body.navbar-sticky").length > 0) {
    $('#nav-fixed').attr('checked',true);
  }
  if ($("body.navbar-static").length > 0) {
    $('#nav-static').attr('checked',true);
  }
  if ($("body.layout-dark.layout-transparent").length > 0) {
    $(".layout-switch").find(".dark-layout #dl-switch").attr("checked", false);
    $(".layout-switch").find(".transparent-layout #tl-switch").attr("checked", true);

    var data_bg_img = $('body').attr('data-bg-img');
    $('.customizer').find("[data-bg-image='" + data_bg_img + "']").addClass("selected");
    $('.customizer').find("[data-bg-color='" + data_bg_img + "']").addClass("selected");


    $("#dl-switch").on("click", function() {
      mainMenu.attr("data-background-color", "black");
    });
    $("#ll-switch").on("click", function() {
      $(".sidebar-background").css("background-image","../../../app-assets/img/sidebar-bg/01.jpg");
    });
  }

  // check the checkbox if menu is collapsed
  if ($("body.nav-collapsed, body.menu-collapsed").length > 0) {
    $(".cz-compact-menu").attr("checked", true);
    $(".ct-sidebar-size").toggleClass('hide').toggle();
  }

  // Navbar Type Switch : Static / Fixed
  $(".navbar-switch #nav-static").on('click', function(){
    $body = $("body");
    $body.removeClass('navbar-sticky').addClass('navbar-static');
    if($body.hasClass('horizontal-menu')){
      $navMenu = $("body .navbar-horizontal");
      $navMenu.addClass('d-block');
    }else{
      $navMenu = $("body nav.navbar");
    }
    $navMenu.removeAttr('style');
    $navMenu.removeClass("navbar-fixed").addClass("navbar-sticky");
    if($navMenu.hasClass('d-block')){
      setTimeout(function(){
        $navMenu.removeClass('d-block');
      }, 200);
    }
  });

  $(".navbar-switch #nav-fixed").on('click', function(){
    $body = $("body");
    $body.removeClass('navbar-static').addClass('navbar-sticky');
    if($body.hasClass('horizontal-menu')){
      $navMenu = $("body .navbar-horizontal");
      $navMenu.addClass('d-block');
    }else{
      $navMenu = $("body nav.navbar");
    }
    $navMenu.removeClass("navbar-sticky").addClass("navbar-fixed");
    if($navMenu.hasClass('d-block')){
      setTimeout(function(){
        $navMenu.removeClass('d-block');
      }, 200);
    }
  });

  // Change Sidebar Background Color
  $(".cz-bg-color span").on("click", function() {
    var $this = $(this),
    bgColor = $this.attr("data-bg-color");

    $this.closest(".cz-bg-color").find("span.selected").removeClass("selected");
    $this.addClass("selected");

    mainMenu.attr("data-background-color", bgColor);
    if (bgColor == "white") {
      $(".logo-img img").attr("src", "../../../app-assets/img/logo-dark.png");
    } else {
      if ($(".logo-img img").attr("src") =="../../../app-assets/img/logo-dark.png") {
        $(".logo-img img").attr("src", "../../../app-assets/img/logo.png");
      }
    }
  });

  // Change Background Image
  $(".cz-bg-image img").on("click", function() {
    var sidebar_img_checkbox = $('#sidebar-bg-img');
    sidebar_img_checkbox.prop('checked', true);
    var $this = $(this),
      src = $this.attr("src");
    $(".sidebar-background").css("background-image", "url(" + src + ")");
    $this.closest(".cz-bg-image").find(".selected").removeClass("selected");
    $this.addClass("selected");
  });

  // To show/hide bg image in vertical menu
  $(".cz-bg-image-display").on("click", function() {
    var $this = $(this);
    var src = $(".cz-bg-image img.sb-bg-01").attr("src");
    if ($this.prop("checked") === true) {
      $(".sidebar-background").css("background-image", "url(" + src + ")");
      $(".cz-bg-image img.sb-bg-01").addClass("selected");
    } else {
      $(".sidebar-background, .app-sidebar").css("background-image", "none");
    }
  });

  // compact/collapsed menu toggle
  $(".cz-compact-menu").on("click", function() {
    if ($(body).hasClass("menu-expanded")) {
      body.removeClass("menu-expanded").addClass("nav-collapsed");
      mainMenu.removeClass("expanded");
      mainMenu.find(".sidebar-group-active").removeClass("open").addClass("nav-collapsed-open");
      mainMenu.find(".has-sub:not(.sidebar-group-active)").removeClass("open");
      mainMenuContent.find('li.active').parents('li').removeClass('open');

    }else {
      body.removeClass("nav-collapsed").addClass("menu-expanded");
      mainMenu.find(".sidebar-group-active").addClass("open").removeClass("nav-collapsed-open");
      mainMenuContent.find('li.active').parents('li').addClass('open');
    }
    $(".ct-sidebar-size").toggleClass('hide').toggle();
  });

  // Vertical menu size switches
  $(".cz-sidebar-width input[name='cz-btn-radio']").on("change", function() {
    var $this = $(this),
      width_val = this.value;

    if (width_val === "small") {
      $(body)
        .removeClass("sidebar-lg")
        .addClass("sidebar-sm");
    } else if (width_val === "large") {
      $(body)
        .removeClass("sidebar-sm")
        .addClass("sidebar-lg");
    } else {
      $(body).removeClass("sidebar-sm sidebar-lg");
    }
  });

  // To toggle sidebar image checkbox
  $("#sidebar-bg-img").on("click", function() {
    if ($(this).is(":checked")) {
      $(this).removeAttr("checked", false);
    } else {
      $(this).attr("checked", true);
      $(".sb-bg-img img.selected").removeClass("selected");
    }
  });

  // To Toggle Light Layout
  $("#ll-switch").on("click", function() {
    // Removes Layout Dark and Transparent Classes
    $("body, nav.navbar").removeClass(
      "layout-transparent layout-dark bg-glass-hibiscus bg-glass-purple-pizzazz bg-glass-blue-lagoon bg-glass-electric-violet bg-glass-portage bg-glass-tundora bg-glass-1 bg-glass-2 bg-glass-3 bg-glass-4"
    ).removeAttr('data-bg-img');
    $(".sb-color-options").find(".selected").removeClass("selected");
    $(".sb-color-options").find(".gradient-man-of-steel").addClass("selected");
    if($(body).data('menu') == "horizontal-menu"){
      $(".logo-img img").attr("src", "../../../app-assets/img/logo-dark.png");
    }
    else{
      $(".logo-img img").attr("src", "../../../app-assets/img/logo.png");
    }
    $(".navbar").removeAttr('style');
    // Selected Image
    var src = $(".cz-bg-image img.sb-bg-01").attr("src");
    $(".sidebar-background").css("background-image", "url(" + src + ")");
    mainMenu.css("background-image", "url(" + src + ")");

    // Selected Background Color
    var bgColor = $(".cz-bg-color span.selected").attr("data-bg-color");
    mainMenu.attr("data-background-color", bgColor);
  });

  // To Toggle Dark Layout
  $("#dl-switch").on("click", function() {
    // Removes Unwanted Classes if any and adds layout-dark to body
    if ($("body").hasClass("layout-transparent")) {
      $("body, nav.navbar").removeClass(
        "layout-transparent bg-glass-hibiscus bg-glass-purple-pizzazz bg-glass-blue-lagoon bg-glass-electric-violet bg-glass-portage bg-glass-tundora bg-glass-1 bg-glass-2 bg-glass-3 bg-glass-4"
      ).removeAttr('data-bg-img');
      $("body").addClass("layout-dark");
      $(".sidebar-background").css("background-image","url(../../../app-assets/img/sidebar-bg/01.jpg)");
      $(".navbar").removeAttr('style');
      mainMenu.attr("data-background-color", "black");
    } else {
      $(".navbar").removeAttr('style');
      $("body").addClass("layout-dark");
      $(".sb-color-options span.selected").removeClass("selected");
      $(".sb-color-options .bg-black").addClass("selected");
      mainMenu.attr("data-background-color", "black");
      $(".logo-img img").attr("src", "../../../app-assets/img/logo.png");
    }
  });
  // To Toggle Transparent Layout
  $("#tl-switch").on("click", function() {
    $(".navbar").removeAttr('style');
    $(".navbar-horizontal").removeClass(
      "layout-transparent bg-glass-hibiscus bg-glass-purple-pizzazz bg-glass-blue-lagoon bg-glass-electric-violet bg-glass-portage bg-glass-tundora bg-glass-1 bg-glass-2 bg-glass-3 bg-glass-4"
    ).removeAttr('data-bg-img');
    $("body").addClass("layout-transparent layout-dark bg-glass-1").attr('data-bg-img',"bg-glass-1");
    mainMenu.attr("data-background-color", "black");
    $(".cz-tl-bg-color .row .col span.selected").removeClass("selected");
    $(".tl-bg-img .rounded.selected").removeClass("selected");
    $(".cz-tl-bg-image .bg-glass-1").addClass("selected");
    $(".sidebar-background").css("background-image", "none");
    $(".logo-img img").attr("src", "../../../app-assets/img/logo.png");

    var tl = $(".layout-dark.layout-transparent");
    var tl_bg_color = tl.attr("data-bg-img");
    $("body .header-navbar").addClass(tl_bg_color);
  });

  // To Change Background Colors In Transparent Layout

  // Toggle Selected
  // Adds and removes selected class on click on colors
  $(".customizer .cz-tl-bg-color .col .rounded").on("click", function() {
    $("body").removeClass(
      "bg-glass-hibiscus bg-glass-purple-pizzazz bg-glass-blue-lagoon bg-glass-electric-violet bg-glass-portage bg-glass-tundora bg-glass-1 bg-glass-2 bg-glass-3 bg-glass-4"
    );
    $(".cz-tl-bg-color")
      .find(".selected")
      .removeClass("selected");
    $(this).addClass("selected");
    if ($(".cz-tl-bg-image .col-sm-3 .ct-glass-bg.rounded").hasClass("selected")) {
      $(".cz-tl-bg-image .col-sm-3 .ct-glass-bg.rounded").removeClass("selected");
    }
  });


  // Adds and removes selected class for images
  $(".cz-tl-bg-image .ct-glass-bg.rounded").on("click", function() {
    $("body").removeClass(
      "bg-glass-hibiscus bg-glass-purple-pizzazz bg-glass-blue-lagoon bg-glass-electric-violet bg-glass-portage bg-glass-tundora bg-glass-1 bg-glass-2 bg-glass-3 bg-glass-4"
    );
    $("body nav.header-navbar").removeClass(
      "bg-glass-hibiscus bg-glass-purple-pizzazz bg-glass-blue-lagoon bg-glass-electric-violet bg-glass-portage bg-glass-tundora bg-glass-1 bg-glass-2 bg-glass-3 bg-glass-4"
    );
    $(".cz-tl-bg-image").find(".selected").removeClass("selected");
    $(this).addClass("selected");
    if ($(".customizer .cz-tl-bg-color .col .rounded").hasClass("selected")) {
      $(".customizer .cz-tl-bg-color .col .rounded").removeClass("selected");
    }

    var $this = $(this),
    $img_class = $this.attr("data-bg-image");
    var tl = $(".layout-dark.layout-transparent");
    var tl_bg_color = tl.attr("data-bg-img");
    $("body").addClass($img_class).attr('data-bg-img',$img_class);
    $("body .header-navbar").removeAttr( 'style' ).removeClass(tl_bg_color).addClass($img_class);
  });

  // Transparent Layout Background Colors
  $(".customizer-content .ct-color-bg").on("click", function() {
    var $this = $(this),
    $img_class = $this.attr("data-bg-color");
    var tl = $(".layout-dark.layout-transparent");
    var tl_bg_color = tl.attr("data-bg-img");
    $("body").addClass($img_class).attr('data-bg-img',$img_class);;
    $("body .header-navbar").removeClass(tl_bg_color).addClass($img_class);
  });
});
