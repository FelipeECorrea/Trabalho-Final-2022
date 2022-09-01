/*=========================================================================================
    File Name: components-modal.js
    Description: Modals are streamlined, but flexible, dialog prompts with the minimum
				required functionality and smart defaults.
    ----------------------------------------------------------------------------------------
    Item Name: Apex - Responsive Admin Theme
    Author: Pixinvent
    Author URL: hhttp://www.themeforest.net/user/pixinvent
==========================================================================================*/

(function (window, document, $) {
  'use strict';

  // append modal to body
  $('.modal').appendTo("body");

  // on Show event
  $('#onshow').on('show.bs.modal', function () {
    alert('onShow event fired.');
  });

  // on Shown event
  $('#onshown').on('shown.bs.modal', function () {
    alert('onShown event fired.');
  });

  // on Hide event
  $('#onhide').on('hide.bs.modal', function () {
    alert('onHide event fired.');
  });

  // on Hidden event
  $('#onhidden').on('hidden.bs.modal', function () {
    alert('onHidden event fired.');
  });
})(window, document, jQuery);
