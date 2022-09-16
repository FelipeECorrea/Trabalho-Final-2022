/*!
 =========================================================
 * Apex Angular 4 Bootstrap theme - V1.0
 =========================================================

 * Product Page: https://www.pixinvent.com/product/apex
 * Copyright 2017 Pixinvent Creative Studio (https://www.pixinvent.com)

 =========================================================
*/
$(document).ready(function () {

  // Scroll to top
  $(window).scroll(function(){
    if ($(this).scrollTop() > 400) {
      $('.scroll-top').fadeIn();
    } else {
      $('.scroll-top').fadeOut();
    }
  });

  //Click event to scroll to top
  $('.scroll-top').click(function(){
    $('html, body').animate({scrollTop : 0},1000);
  });

  // Scroll To Active

  if ($('.navigation-main').data('scroll-to-active') === true) {
    var position;
    if ($('.navigation-main').find('li.active').parents('li').length > 0) {
      position = $(".navigation-main").find('li.active').parents('li').last().position();
    }
    else {
      position = $(".navigation-main").find('li.active').position();
    }
    setTimeout(function () {
      if (position !== undefined) {
        $('.sidebar-content.ps-container').animate({
          scrollTop: position.top
        }, 300)

      }
    }, 300)
  }

  var $sidebar = $('.app-sidebar'),
    $sidebar_content = $('.sidebar-content'),
    $sidebar_img = $sidebar.data('image'),
    $sidebar_img_container = $('.sidebar-background'),
    $wrapper = $('.wrapper');

  if($('.sidebar-content').length > 0){
    var ps_sidebar_content = new PerfectScrollbar('.sidebar-content', {
      wheelPropagation: false
    });

  }

  if ($sidebar_img_container.length !== 0 && $sidebar_img !== undefined) {
    $sidebar_img_container.css('background-image', 'url("' + $sidebar_img + '")');
  }

  if (!$wrapper.hasClass('nav-collapsed')) {
    $sidebar_content.find('li.active').parents('li').addClass('open');
  }


  // Match the height of each card in a row
  setTimeout(function () {
    $('.row.match-height').each(function () {
      $(this).find('.card').not('.card .card').matchHeight(); // Not .card .card prevents collapsible cards from taking height
    });
  }, 500);


  $sidebar_content.on('click', '.navigation li a', function () {
    var $this = $(this),
      listItem = $this.parent('li');

    if (listItem.hasClass('has-sub') && listItem.hasClass('open')) {
      collapse(listItem);
    } else {
      if (listItem.hasClass('has-sub')) {
        expand(listItem);
      }

      // If menu collapsible then do not take any action
      if ($sidebar_content.data('collapsible')) {
        return false;
      }
      // If menu accordion then close all except clicked once
      else {
        openListItems = listItem.siblings('.open');
        collapse(openListItems);
        listItem.siblings('.open').find('li.open').removeClass('open');
      }
    }
  });

  function collapse($listItem, callback) {
    var $subList = $listItem.children('ul');

    $subList.show().slideUp(200, function () {
      $(this).css('display', '');

      $(this).find('> li').removeClass('is-shown');

      $listItem.removeClass('open');

      if (callback) {
        callback();
      }
    });

  }

  function expand($listItem, callback) {
    var $subList = $listItem.children('ul');
    var $children = $subList.children('li').addClass('is-hidden');

    $listItem.addClass('open');

    $subList.hide().slideDown(200, function () {
      $(this).css('display', '');

      if (callback) {
        callback();
      }
    });



    setTimeout(function () {
      $children.addClass('is-shown');
      $children.removeClass('is-hidden');
    }, 0);
  }

  $('.logo-text').on('click', function () {

    var listItem = $sidebar_content.find('li.open.has-sub'),
      activeItem = $sidebar_content.find('li.active');

    if (listItem.hasClass('has-sub') && listItem.hasClass('open')) {
      collapse(listItem);
      listItem.removeClass('open');
      if (activeItem.closest('li.has-sub')) {
        openItem = activeItem.closest('li.has-sub');
        expand(openItem);
        openItem.addClass('open');
      }
    } else {
      if (activeItem.closest('li.has-sub')) {
        openItem = activeItem.closest('li.has-sub');
        expand(openItem);
        openItem.addClass('open');
      }
    }
  });


  $('.nav-toggle').on('click', function () {
    var $this = $(this),
      toggle_icon = $this.find('.toggle-icon'),
      toggle = toggle_icon.attr('data-toggle');
    compact_menu_checkbox = $('.cz-compact-menu');

    if (toggle === 'expanded') {
      $wrapper.addClass('nav-collapsed');

      $('.nav-toggle').find('.toggle-icon').removeClass('ft-toggle-right').addClass('ft-toggle-left');
      toggle_icon.attr('data-toggle', 'collapsed');
      if (compact_menu_checkbox.length > 0) {
        compact_menu_checkbox.prop('checked', true);
      }
    } else {
      $wrapper.removeClass('nav-collapsed menu-collapsed');

      $('.nav-toggle').find('.toggle-icon').removeClass('ft-toggle-left').addClass('ft-toggle-right');
      toggle_icon.attr('data-toggle', 'expanded');
      if (compact_menu_checkbox.length > 0) {
        compact_menu_checkbox.prop('checked', false);
      }
    }
  });

  $sidebar.on('mouseenter', function () {
    if ($wrapper.hasClass('nav-collapsed')) {
      $wrapper.removeClass('menu-collapsed');
      var $listItem = $('.navigation li.nav-collapsed-open'),
        $subList = $listItem.children('ul');

      $subList.hide().slideDown(300, function () {
        $(this).css('display', '');
      });

      $sidebar_content.find('li.active').parents('li').addClass('open');
      $listItem.addClass('open').removeClass('nav-collapsed-open');
    }
  }).on('mouseleave', function (event) {
    if ($wrapper.hasClass('nav-collapsed')) {
      $wrapper.addClass('menu-collapsed');
      var $listItem = $('.navigation li.open'),
        $subList = $listItem.children('ul');
      $listItem.addClass('nav-collapsed-open');

      $subList.show().slideUp(300, function () {
        $(this).css('display', '');
      });

      $listItem.removeClass('open');
    }
  });

  if ($(window).width() < 975) {
    $sidebar.addClass('hide-sidebar');
    $wrapper.removeClass('nav-collapsed menu-collapsed');
  }
  $(window).resize(function () {
    if ($(window).width() < 975) {
      $sidebar.addClass('hide-sidebar');
      $wrapper.removeClass('nav-collapsed menu-collapsed');
    }
    if ($(window).width() >= 975) {
      $sidebar.removeClass('hide-sidebar');
      if ($('.toggle-icon').attr('data-toggle') === 'collapsed' && $wrapper.not('.nav-collapsed menu-collapsed')) {
        $wrapper.addClass('nav-collapsed menu-collapsed');
      }
    }
  });

  $(document).on('click', '.navigation li:not(.has-sub)', function () {
    if ($(window).width() < 975) {
      $sidebar.addClass('hide-sidebar');
    }
  });

  $(document).on('click', '.logo-text', function () {
    if ($(window).width() < 975) {
      $sidebar.addClass('hide-sidebar');
    }
  });


  $('.navbar-toggle').on('click', function (e) {
    e.stopPropagation();
    $sidebar.toggleClass('hide-sidebar');
  });

  $('html').on('click', function (e) {
    if ($(window).width() < 975) {
      if (!$sidebar.hasClass('hide-sidebar') && $sidebar.has(e.target).length === 0) {
        $sidebar.addClass('hide-sidebar');
      }
    }
  });

  $('#sidebarClose').on('click', function () {
    $sidebar.addClass('hide-sidebar');
  });

  if($('.noti-list').length > 0){
    var noti_list = new PerfectScrollbar('.noti-list');
  }

  // Page full screen
  $('.apptogglefullscreen').on('click', function (e) {
    if (typeof screenfull != 'undefined') {
      if (screenfull.isEnabled) {
        screenfull.toggle();
      }
    }
  });
  if (typeof screenfull != 'undefined') {
    if (screenfull.isEnabled) {
      $(document).on(screenfull.raw.fullscreenchange, function () {
        if (screenfull.isFullscreen) {
          $('.apptogglefullscreen').find('i').toggleClass('ft-minimize ft-maximize');
        } else {
          $('.apptogglefullscreen').find('i').toggleClass('ft-maximize ft-minimize');
        }
      });
    }
  }


  /********************* Navbar Search starts ***********************/

  // This variable is used for mouseenter and mouseleave events of search list
  var $filename = $(".search-input .input").data("search");

  // Navigation Search area Open
  $(".nav-link-search").on("click", function () {
    var $this = $(this)
    var searchInput = $(this)
      .parent(".nav-search")
      .find(".search-input")
    searchInput.addClass("open")
    $(".search-input .input").focus()
    $(".search-input .search-list li").remove()
    $(".search-input .search-list").addClass("show")
  });

  // Navigation Search area Close
  $(".search-input-close i").on("click", function () {
    var $this = $(this),
      searchInput = $(this).closest(".search-input")
    if (searchInput.hasClass("open")) {
      searchInput.removeClass("open")
      $(".search-input input").val("")
      $(".search-input input").blur()
      $(".search-input .search-list").removeClass("show")
      if ($(".wrapper").hasClass("show-overlay")) {
        $(".wrapper").removeClass("show-overlay")
      }
    }
  });

  // Navigation Search area Close on click of main-content
  $(".main-content").on("click", function () {
    var $this = $(".search-input-close"),
      searchInput = $($this).parent(".search-input"),
      searchList = $(".search-list")
    if (searchInput.hasClass("open")) {
      searchInput.removeClass("open")
    }
    if (searchList.hasClass("show")) {
      searchList.removeClass("show")
    }
    if ($(".wrapper").hasClass("show-overlay")) {
      $(".wrapper").removeClass("show-overlay")
    }
  });

  //----------Filter--------------
  $(".search-input .input").on("keyup", function (e) {
    if (e.keyCode !== 38 && e.keyCode !== 40 && e.keyCode !== 13) {
      if (e.keyCode == 27) {
        // $(".wrapper").removeClass("show-overlay")
        $(".search-input input").val("")
        $(".search-input input").blur()
        $(".search-input").removeClass("open")
        if ($(".search-list").hasClass("show")) {
          $(this).removeClass("show")
          $(".search-input").removeClass("show")
        }
      }
      // Define variables
      var value = $(this)
        .val()
        .toLowerCase(), //get values of input on keyup
        activeClass = "",
        liList = $("ul.search-list li") // get all the list items of the search
      liList.remove()
      // If input value is blank
      if (value != "") {
        $(".wrapper").addClass("show-overlay")
        var $startList = "",
          $otherList = "",
          $htmlList = "",
          $activeItemClass = "",
          a = 0
        // getting json data from file for search results
        $.getJSON("../../../app-assets/data/" + $filename + ".json", function (data) {
          for (var i = 0; i < data.listItems.length; i++) {
            // Search list item start with entered letters and create list
            if (
              data.listItems[i].name.toLowerCase().indexOf(value) == 0 &&
              a < 10 || !(data.listItems[i].name.toLowerCase().indexOf(value) == 0) &&
              data.listItems[i].name.toLowerCase().indexOf(value) > -1 &&
              a < 10
            ) {
              if (a === 0) {
                $activeItemClass = "current_item"
              } else {
                $activeItemClass = ""
              }
              $startList +=
                '<li class="auto-suggestion d-flex align-items-center justify-content-between ' +
                $activeItemClass +
                '">' +
                '<a class="d-flex align-items-center justify-content-between w-100" href=' +
                data.listItems[i].url +
                ">" +
                '<div>' +
                '<span class="' +
                data.listItems[i].icon +
                ' mr-2"></span>' +
                "<span>" +
                data.listItems[i].name +
                "</span>" +
                "</div>"
              a++
            }
          }
          if ($startList == "" && $otherList == "") {
            $otherList =
              '<li class="auto-suggestion d-flex align-items-center justify-content-between">' +
              '<a class="d-flex align-items-center justify-content-between w-100">' +
              '<div>' +
              '<span class="ft-info mr-2"></span>' +
              "<span>No results found.</span>" +
              "</div>" +
              "</a>" +
              "</li>"
          }
          $htmlList = $startList.concat($otherList) // merging start with and other list
          $("ul.search-list").html($htmlList) // Appending list to <ul>
        })
      } else {
        // if search input blank, hide overlay
        if ($(".wrapper").hasClass("show-overlay")) {
          $(".wrapper").removeClass("show-overlay")
        }
      }
    }
  });
  // If we use up key(38) Down key (40) or Enter key(13)
  $(window).on("keydown", function (e) {
    var $current = $(".search-list li.current_item"),
      $next,
      $prev
    if (e.keyCode === 40) {
      $next = $current.next()
      $current.removeClass("current_item")
      $current = $next.addClass("current_item")
    } else if (e.keyCode === 38) {
      $prev = $current.prev()
      $current.removeClass("current_item")
      $current = $prev.addClass("current_item")
    }
    if (e.keyCode === 13 && $(".search-list li.current_item").length > 0) {
      var selected_item = $(".search-list li.current_item a")
      window.location = selected_item.attr("href")
      $(selected_item).trigger("click")
    }
  });
  /********************* Navbar Search ends ***********************/

  //  Notifications & messages scrollable
  $(".scrollable-container").each(function () {
    var scrollable_container = new PerfectScrollbar($(this)[0], {
      wheelPropagation: false
    })
  })

  // Add class on hover of the list
  $(document).on("mouseenter", ".search-list li", function (e) {
    $(this)
      .siblings()
      .removeClass("current_item")
    $(this).addClass("current_item")
  })
  $(document).on("click", ".search-list li", function (e) {
    e.stopPropagation()
  });

});

// Switchery for navbar notification
(function(window, document, $) {
  'use strict';
  var $html = $('html');

  // Switchery
  var i = 0;
  if (Array.prototype.forEach) {

      var elems = $('.switchery');
      $.each( elems, function( key, value ) {
          var $size="", $color="",$sizeClass="", $colorCode="";
          $size = $(this).data('size');
          var $sizes ={
              'lg' : "large",
              'sm' : "small",
              'xs' : "xsmall"
          };
          if($(this).data('size')!== undefined){
              $sizeClass = "switchery switchery-"+$sizes[$size];
          }
          else{
              $sizeClass = "switchery";
          }

          $color = $(this).data('color');
          var $colors ={
            'primary' : "#975AFF",
            'success' : "#40C057",
            'danger' : "#F55252",
            'warning' : "#F77E17",
            'info' : "#2F8BE6"
          };
          if($color !== undefined){
              $colorCode = $colors[$color];
          }
          else{
              $colorCode = "#975AFF";
          }

          var switchery = new Switchery($(this)[0], { className: $sizeClass, color: $colorCode });
      });
  } else {
      var elems1 = document.querySelectorAll('.switchery');

      for (i = 0; i < elems1.length; i++) {
          var $size = elems1[i].data('size');
          var $color = elems1[i].data('color');
          var switchery = new Switchery(elems1[i], { color: '#975AFF' });
      }
  }
  /*  Toggle Ends   */


  // Header Notification Dropdown Remains Opened on click of switch Label
  $(".navbar-container .scrollable-container .custom-switch span").on("click", function (e) {
    e.stopPropagation()
  })


  var vh = window.innerHeight * 0.01;
  document.documentElement.style.setProperty('--vh', vh + "px");

})(window, document, jQuery);
