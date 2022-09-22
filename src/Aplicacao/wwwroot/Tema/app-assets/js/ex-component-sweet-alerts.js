$(document).ready(function () {

  //-------------- Basic --------------

  // Basic
  $('.basic-alert').on('click', function () {
    Swal.fire({
      title: 'Any fool can use a computer',
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });

  // With title
  $('.with-title').on('click', function () {
    Swal.fire({
      title: 'The Internet?',
      text: "That thing is still around?",
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });

  // With footer
  $('.footer-alert').on('click', function () {
    Swal.fire({
      type: 'error',
      title: 'Oops...',
      text: 'Something went wrong!',
      footer: '<a href = "javascript:void(0);">Why do I have this issue?</a>',
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });

  // HTML
  $('.html-alert').on('click', function () {
    Swal.fire({
      title: '<strong>HTML <u>example</u></strong>',
      type: 'info',
      html: 'You can use <b>bold text</b>, ' +
        '<a href="https://pixinvent.com/" target="_blank">links</a> ' +
        'and other HTML tags',
      showCloseButton: true,
      showCancelButton: true,
      focusConfirm: false,
      confirmButtonText: '<i class="fa fa-thumbs-o-up"></i> Great!',
      confirmButtonAriaLabel: 'Thumbs up, great!',
      cancelButtonText: '<i class="fa fa-thumbs-o-down"></i>',
      cancelButtonAriaLabel: 'Thumbs down',
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
      cancelButtonClass: 'btn btn-danger ml-1',
    });
  });


  //-------------- Position --------------

  // Top-start
  $('.position-top-start').on('click', function () {
    Swal.fire({
      position: 'top-start',
      type: 'success',
      title: 'Your work has been saved',
      showConfirmButton: false,
      timer: 1500,
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });

  // Top-end
  $('.position-top-end').on('click', function () {
    Swal.fire({
      position: 'top-end',
      type: 'success',
      title: 'Your work has been saved',
      showConfirmButton: false,
      timer: 1500,
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });

  // Bottom-start
  $('.position-bottom-start').on('click', function () {
    Swal.fire({
      position: 'bottom-start',
      type: 'success',
      title: 'Your work has been saved',
      showConfirmButton: false,
      timer: 1500,
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });

  // Bottom-end
  $('.position-bottom-end').on('click', function () {
    Swal.fire({
      position: 'bottom-end',
      type: 'success',
      title: 'Your work has been saved',
      showConfirmButton: false,
      timer: 1500,
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });


  //-------------- Animations --------------

  // Bounce-in
  $(".bounce-in-animation").on('click', function () {
    Swal.fire({
      title: 'Bounce In Animation',
      animation: false,
      customClass: 'animated bounceIn',
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });

  // Fade-in
  $(".fade-in-animation").on('click', function () {
    Swal.fire({
      title: 'Fade In Animation',
      animation: false,
      customClass: 'animated fadeIn',
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });

  // Flip-in
  $(".flip-x-animation").on('click', function () {
    Swal.fire({
      title: 'Flip In Animation',
      animation: false,
      customClass: 'animated flipInX',
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });

  // Tada
  $(".tada-animation").on('click', function () {
    Swal.fire({
      title: 'Tada Animation',
      animation: false,
      customClass: 'animated tada',
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });

  // Shake
  $(".shake-animation").on('click', function () {
    Swal.fire({
      title: 'Shake Animation',
      animation: false,
      customClass: 'animated shake',
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });


  //-------------- Types --------------

  // Success
  $('.type-success').on('click', function () {
    Swal.fire({
      title: "Good job!",
      text: "You clicked the button!",
      type: "success",
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });

  // Info
  $('.type-info').on('click', function () {
    Swal.fire({
      title: "Info!",
      text: "You clicked the button!",
      type: "info",
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });

  // Warning
  $('.type-warning').on('click', function () {
    Swal.fire({
      title: "Warning!",
      text: " You clicked the button!",
      type: "warning",
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });

  // Error
  $('.type-error').on('click', function () {
    Swal.fire({
      title: "Error!",
      text: " You clicked the button!",
      type: "error",
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });


  //-------------- Options --------------

  // Custom-icon
  $('.custom-icon').on('click', function () {
    Swal.fire({
      title: 'Sweet!',
      text: 'Modal with a custom image.',
      imageUrl: '../../../app-assets/img/gallery/13.jpg',
      imageWidth: 400,
      imageHeight: 200,
      imageAlt: 'Custom image',
      animation: false,
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });

  // Auto-close
  $('.auto-close').on('click', function () {
    var timerInterval
    Swal.fire({
      title: 'Auto close alert!',
      html: 'I will close in <strong></strong> seconds.',
      timer: 2000,
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
      onBeforeOpen: function () {
        Swal.showLoading()
        timerInterval = setInterval(function () {
          Swal.getContent().querySelector('strong')
            .textContent = Swal.getTimerLeft()
        }, 100)
      },
      onClose: function () {
        clearInterval(timerInterval)
      }
    }).then(function (result) {
      if (
        // Read more about handling dismissals
        result.dismiss === Swal.DismissReason.timer
      ) {
        console.log('I was closed by the timer')
      }
    });
  });

  // Outside-click
  $('.outside-click').on('click', function () {
    Swal.fire({
      title: 'Outside click is disabled!',
      text: 'This is a cool message!',
      allowOutsideClick: false,
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
    });
  });

  // Prompt-function
  $('.prompt-function').on('click', function () {
    Swal.mixin({
      input: 'text',
      confirmButtonText: 'Next &rarr;',
      showCancelButton: true,
      progressSteps: ['1', '2', '3'],
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
      cancelButtonClass: "btn btn-danger ml-1"
    }).queue([{
        title: 'Question 1',
        text: 'Chaining swal2 modals is easy'
      },
      'Question 2',
      'Question 3'
    ]).then(function (result) {
      if (result.value) {
        Swal.fire({
          title: 'All done!',
          html: 'Your answers: <pre><code>' +
            JSON.stringify(result.value) +
            '</code></pre>',
          confirmButtonText: 'Lovely!'
        })
      }
    });
  });

  // AJAX-request
  $('.ajax-request').on('click', function () {
    Swal.fire({
      title: 'Search for a user',
      input: 'text',
      confirmButtonClass: 'btn btn-primary',
      buttonsStyling: false,
      inputAttributes: {
        autocapitalize: 'off'
      },
      showCancelButton: true,
      confirmButtonText: 'Look up',
      showLoaderOnConfirm: true,
      cancelButtonClass: "btn btn-danger ml-1",
      preConfirm: function (login) {
        return fetch("//api.github.com/users/" + login + "")
          .then(function (response) {
            if (!response.ok) {
              console.log(response)
              throw new Error(response.statusText)
            }
            return response.json()
          })
          .catch(function (error) {
            Swal.showValidationMessage(
              "Request failed:  " + error
            )
          })
      },
      allowOutsideClick: function () {
        !Swal.isLoading()
      }
    }).then(function (result) {
      if (result.value) {
        Swal.fire({
          title: "" + result.value.login + "'s avatar",
          imageUrl: result.value.avatar_url
        });
      }
    });
  });


  //-------------- Confirm-options --------------

  // Confirm-text
  $('.confirm-text').on('click', function () {
    Swal.fire({
      title: 'Are you sure?',
      text: "You won't be able to revert this!",
      type: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#2F8BE6',
      cancelButtonColor: '#F55252',
      confirmButtonText: 'Your text here!',
      confirmButtonClass: 'btn btn-primary',
      cancelButtonClass: 'btn btn-danger ml-1',
      buttonsStyling: false,
    }).then(function (result) {
      if (result.value) {
        Swal.fire({
          type: "success",
          title: 'Deleted!',
          text: 'Your file has been deleted.',
          confirmButtonClass: 'btn btn-success',
        })
      }
    });
  });

  // Confirm-color
  $('.confirm-color').on('click', function () {
    Swal.fire({
      title: 'Are you sure?',
      text: "You won't be able to revert this!",
      type: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#2F8BE6',
      cancelButtonColor: '#F55252',
      confirmButtonText: 'Yes, delete it!',
      confirmButtonClass: 'btn btn-warning',
      cancelButtonClass: 'btn btn-danger ml-1',
      buttonsStyling: false,
    }).then(function (result) {
      if (result.value) {
        Swal.fire({
          type: "success",
          title: 'Deleted!',
          text: 'Your imaginary file has been deleted.',
          confirmButtonClass: 'btn btn-success',
        })
      } else if (result.dismiss === Swal.DismissReason.cancel) {
        Swal.fire({
          title: 'Cancelled',
          text: 'Your imaginary file is safe :)',
          type: 'error',
          confirmButtonClass: 'btn btn-success',
        })
      }
    });
  });
});
