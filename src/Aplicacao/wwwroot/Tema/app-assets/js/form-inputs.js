//Custom File Input
$('.custom-file input').change(function (e) {
  $(this).next('.custom-file-label').html(e.target.files[0].name);
});

// form validation needs was-validated class
(function (window, document, $) {
  'use strict';

  // Fetch all the forms we want to apply custom Bootstrap validation styles to
  // Loop over them and prevent submission
  $("button").click(function () {
    var form = $(".needs-validation");
    if (form[0].checkValidity() === false) {
      event.preventDefault();
      event.stopPropagation();
    }
    form.addClass('was-validated');
  });
})(window, document, jQuery);
