$(document).ready(function(){
  $('body').scrollspy({ target: '.doc-sidebar-nav' });

  // scroll to a link smoothly
  $('.doc-sidebar .doc-sidebar-nav-list a.nav-link').click(function () {
    $('html, body').animate({
      scrollTop: $($.attr(this, 'href')).offset().top
    }, 1000);
  });
});
