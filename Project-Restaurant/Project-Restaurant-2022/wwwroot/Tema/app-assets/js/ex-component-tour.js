$(document).ready(function () {
  displayTour();
  $(window).resize(displayTour)
  // tour initialize
  var tour = new Shepherd.Tour({
    defaultStepOptions: {
      classes: 'tour-container shadow-md',
      scrollTo: {
        behavior: 'smooth',
        block: 'center'
      }
    }
  });

  //-------------- Tour steps added here --------------
  // Step 1
  tour.addStep({
    title: 'Try fuzzy Search to visit pages in flash.',
    attachTo: {
      element: '.navbar-header .nav-search .nav-link-search',
      on: 'bottom'
    },
    buttons: [{
        action: function () {
          return this.cancel();
        },
        text: "Skip",
        classes: 'btn bg-light-primary',
      },
      {
        action: function () {
          return this.next();
        },
        text: 'Next',
        classes: 'btn bg-light-primary',
      }
    ],
    id: 'welcome'
  });

  // step 2
  tour.addStep({
    title: 'Notifications',
    text: 'See all your natifications and updates here.',
    attachTo: {
      element: '.dropdown-notification',
      on: 'bottom'
    },
    buttons: [

      {
        action: function () {
          return this.cancel();
        },
        text: "Skip",
        classes: 'btn bg-light-primary',
      },

      {
        action: function () {
          return this.back();
        },
        text: "Previous",
        classes: 'btn bg-light-primary',
      },
      {
        action: function () {
          return this.next();
        },
        text: 'Next',
        classes: 'btn bg-light-primary',
      },
    ]
  });

  // step 3
  tour.addStep({

    title: 'Footer',
    text: 'Here are the rights of your company.',
    attachTo: {
      element: '#pixinventLink',
      on: 'top'
    },
    buttons: [{
        action: function () {
          return this.back();
        },
        text: "Previous",
        classes: 'btn bg-light-primary',
      },

      {
        action: function () {
          return this.next();
        },
        text: "Finish",
        classes: 'btn bg-light-primary',
      },
    ],
  });

  // function to remove tour on small screen
  function displayTour() {
    window.resizeEvt;
    if ($(window).width() > 992) {
      $('#tour').on("click", function () {
        clearTimeout(window.resizeEvt);
        tour.start();
      })
    } else {
      $('#tour').on("click", function () {
        clearTimeout(window.resizeEvt);
        tour.cancel()
        window.resizeEvt = setTimeout(function () {
          alert("Tour only works for large screens!");
        }, 250);;
      })
    }
  }
});
