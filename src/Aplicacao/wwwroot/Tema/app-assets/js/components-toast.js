// basic toast
$('.toast-toggler').on('click', function () {
  $(this).next('.toast').prependTo('.toast-bs-container .toast-position').toast('show');
});

// toast placement
$('.placement').on('click', function () {
  $('.toast-placement').toast('show');
  $('.toast-placement .toast').toast('show');
});
