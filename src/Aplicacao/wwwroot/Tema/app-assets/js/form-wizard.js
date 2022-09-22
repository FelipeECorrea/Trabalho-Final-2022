/*=========================================================================================
    File Name: form-wizard.js
    Description: wizard steps page specific js
    ----------------------------------------------------------------------------------------
    Item Name: Apex - Responsive Admin Theme
    Author: PIXINVENT
    Author URL: http://www.themeforest.net/user/pixinvent
==========================================================================================*/

// Wizard tabs with icons setup
$(document).ready(function () {
  $(".icons-tab-steps").steps({
    headerTag: "h6",
    bodyTag: "fieldset",
    transitionEffect: "fade",
    titleTemplate: '<span class="step">#index#</span> #title#',
    labels: {
      finish: 'Submit'
    },
    onFinished: function (event, currentIndex) {
      alert("Form Submitted.");
    }
  });

  // To select event date
  $('.pickadate').pickadate();

  // add btn class
  $('.wizard .actions a[role="menuitem"]').addClass("btn btn-primary");
  $('.wizard .actions a[href="#previous"]').addClass("btn btn-secondary");
});
