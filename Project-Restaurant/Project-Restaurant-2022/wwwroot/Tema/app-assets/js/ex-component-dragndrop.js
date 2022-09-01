/*=========================================================================================
	File Name: dragndrop.js
	Description: drag & drop elements using dragula js
	--------------------------------------------------------------------------------------
	Item Name: Apex - Responsive Admin Theme
	Author: PIXINVENT
	Author URL: http://www.themeforest.net/user/pixinvent
==========================================================================================*/


$(document).ready(function () {

  // Draggable Cards
  dragula([document.getElementById('card-drag-area')]);

  // Sortable Lists
  dragula([document.getElementById('basic-list-group')]);
  dragula([document.getElementById('multiple-list-group-a'), document.getElementById('multiple-list-group-b')]);

  // Cloning
  dragula([document.getElementById('badge-list-1'), document.getElementById('badge-list-2')], {
    copy: true
  });

  // With Handle
  dragula([document.getElementById("handle-list-1"), document.getElementById("handle-list-2")], {
    moves: function (el, container, handle) {
      return handle.classList.contains('handle');
    }
  });
});
