/*=========================================================================================
    File Name: picker-date-time.js
    Description: Pick a date/time Picker, Date Range Picker JS
    ----------------------------------------------------------------------------------------
    Item Name: Apex - Responsive Admin Theme
    Author: Pixinvent
    Author URL: hhttp://www.themeforest.net/user/pixinvent
==========================================================================================*/
(function (window, document, $) {
  'use strict';

  /********************	Pick-a-date Picker	********************/

  // Basic date
  if ($('.pickadate').length > 0) {
    $('.pickadate').pickadate();
  }

  // Change Day & Month strings
  if ($('.pickadate-short-string').length > 0) {
    $('.pickadate-short-string').pickadate({
      weekdaysShort: ['Su', 'M', 'Tu', 'W', 'Th', 'F', 'Sa'],
      showMonthsShort: true
    });
  }

  // Change first weekday
  if ($('.pickadate-firstday').length > 0) {
    $('.pickadate-firstday').pickadate({
      firstDay: 1
    });
  }

  // Date limits
  if ($('.pickadate-limits').length > 0) {
    $('.pickadate-limits').pickadate({
      min: [2019, 12, 20],
      max: [2020, 1, 25]
    });
  }

  // Format options
  if ($('.pickadate-format').length > 0) {
    $('.pickadate-format').pickadate({
      // Escape any 'rule' characters with an exclamation mark (!).
      format: 'Selecte!d Date : dddd, dd mmmm, yyyy',
      formatSubmit: 'mm/dd/yyyy',
      hiddenPrefix: 'prefix__',
      hiddenSuffix: '__suffix'
    });
  }

  // Picker Translations
  if ($('.pickadate-translations').length > 0) {
    $('.pickadate-translations').pickadate({
      formatSubmit: 'dd/mm/yyyy',
      monthsFull: ['Janvier', 'Février', 'Mars', 'Avril', 'Mai', 'Juin', 'Juillet', 'Août', 'Septembre', 'Octobre', 'Novembre', 'Décembre'],
      monthsShort: ['Jan', 'Fev', 'Mar', 'Avr', 'Mai', 'Juin', 'Juil', 'Aou', 'Sep', 'Oct', 'Nov', 'Dec'],
      weekdaysShort: ['Dim', 'Lun', 'Mar', 'Mer', 'Jeu', 'Ven', 'Sam'],
      today: 'aujourd\'hui',
      clear: 'clair',
      close: 'Fermer'
    });
  }

  // Disable weekday range
  if ($('.pickadate-disable-weekday').length > 0) {
    $('.pickadate-disable-weekday').pickadate({
      disable: [
        3
      ]
    });
  }

  // Month & Year selectors
  if ($('.pickadate-selectors').length > 0) {
    $('.pickadate-selectors').pickadate({
      labelMonthNext: 'Next month',
      labelMonthPrev: 'Previous month',
      labelMonthSelect: 'Pick a Month',
      labelYearSelect: 'Pick a Year',
      selectMonths: true,
      selectYears: true
    });
  }

  // Events
  if ($('.pickadate-events').length > 0) {
    $('.pickadate-events').pickadate({
      onStart: function () {
        console.log('Hi there!!!');
      },
      onRender: function () {
        console.log('Holla... rendered new');
      },
      onOpen: function () {
        console.log('Picker Opened');
      },
      onClose: function () {
        console.log("I'm Closed now");
      },
      onStop: function () {
        console.log('Have a great day ahead!!');
      },
      onSet: function (context) {
        console.log('All stuff:', context);
      }
    });
  }
  if ($('.pickadate-minmax').length) {
    $('.pickadate-minmax').pickadate({
      min: -8,
      max: true
    });
  }

  // Date Range from & to
  if ($('#picker_from').length) {
    var from_$input = $('#picker_from').pickadate(),
      from_picker = from_$input.pickadate('picker');
  }
  if ($('#picker_to').length) {
    var to_$input = $('#picker_to').pickadate(),
      to_picker = to_$input.pickadate('picker');
  }


  // Check if there’s a “from” or “to” date to start with.
  if (from_$input.length && from_picker.get('value')) {
    to_picker.set('min', from_picker.get('select'));
  }
  if (to_$input.length && to_picker.get('value')) {
    from_picker.set('max', to_picker.get('select'));
  }

  // When something is selected, update the “from” and “to” limits.
  if (from_$input.length && to_$input.length) {
    from_picker.on('set', function (event) {
      if (event.select) {
        to_picker.set('min', from_picker.get('select'));
      } else if ('clear' in event) {
        to_picker.set('min', false);
      }
    });
    to_picker.on('set', function (event) {
      if (event.select) {
        from_picker.set('max', to_picker.get('select'));
      } else if ('clear' in event) {
        from_picker.set('max', false);
      }
    });
  }

  // Select Year
  if ($('.pickadate-select-year').length > 0) {
    $('.pickadate-select-year').pickadate({
      selectYears: 8
    });
  }

  // Button options
  if ($('.pickadate-buttons').length > 0) {
    $('.pickadate-buttons').pickadate({
      today: '',
      close: 'Close Picker',
      clear: ''
    });
  }
  if ($('.pickadate-arrow').length > 0) {
    $('.pickadate-arrow').pickadate({
      monthPrev: '&larr;',
      monthNext: '&rarr;',
      weekdaysShort: ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'],
      showMonthsFull: false
    });
  }

  // Disable dates
  if ($('.pickadate-disable-dates').length > 0) {
    $('.pickadate-disable-dates').pickadate({
      disable: [
        [2016, 5, 10],
        [2016, 5, 15],
        [2016, 5, 20]
      ]
    });
  }

  // With Select
  if ($('.pickadate-dropdown').length > 0) {
    $('.pickadate-dropdown').pickadate({
      selectMonths: true,
      selectYears: true
    });
  }


  /*************************** Pick-a-time Picker	********************/

  // Basic time
  if ($('.pickatime').length > 0) {
    $('.pickatime').pickatime();
  }

  // Format options
  if ($('.pickatime-format').length) {
    $('.pickatime-format').pickatime({
      // Escape any “rule” characters with an exclamation mark (!).
      format: 'T!ime selected: h:i a',
      formatLabel: 'h:i a',
      formatSubmit: 'HH:i',
      hiddenPrefix: 'prefix__',
      hiddenSuffix: '__suffix'
    });
  }

  // Format options
  if ($('.pickatime-formatTime').length) {
    $('.pickatime-formatTime').pickatime({
      // Escape any “rule” characters with an exclamation mark (!).
      format: 'T!ime selected: h:i a',
      formatLabel: '<b>h</b>:i <!i>a</!i>',
      formatSubmit: 'HH:i',
      hiddenPrefix: 'prefix__',
      hiddenSuffix: '__suffix'
    });
  }

  // Format options
  if ($('.pickatime-formatlabel').length) {
    $('.pickatime-formatlabel').pickatime({
      formatLabel: function (time) {
        var hours = (time.pick - this.get('now').pick) / 60,
          label = hours < 0 ? ' !hours to now' : hours > 0 ? ' !hours from now' : 'now';
        return 'h:i a <sm!all>' + (hours ? Math.abs(hours) : '') + label + '</sm!all>';
      }
    });
  }

  // Intervals
  if ($('.pickatime-intervals').length) {
    $('.pickatime-intervals').pickatime({
      interval: 150
    });
  }

  //	Diasable Time sets
  if ($('.pickatime-disable').length) {
    $('.pickatime-disable').pickatime({
      // Disable Using Javascript
      disable: [
        new Date(2016, 3, 20, 4, 30),
        new Date(2016, 3, 20, 9)
      ]
    });
  }

  // Disable using integers
  if ($('.pickatime-disable-integer').length) {
    $('.pickatime-disable-integer').pickatime({
      disable: [
        3, 5, 7, 13, 17, 21
      ]
    });
  }

  // Disable using object
  if ($('.pickatime-disable-object').length) {
    $('.pickatime-disable-object').pickatime({
      disable: [{
        from: [2, 0],
        to: [5, 30]
      }]
    });
  }

  // Close on a user action
  if ($('.pickatime-close-action').length) {
    $('.pickatime-close-action').pickatime({
      closeOnSelect: false,
      closeOnClear: false
    });
  }

  // Hide Button
  if ($('.pickatime-button').length) {
    $('.pickatime-button').pickatime({
      clear: '',
    });
  }

  // Date range to select
  if ($('.pickatime-minmax').length) {
    $('.pickatime-minmax').pickatime({
      min: new Date(2015, 3, 20, 7),
      max: new Date(2015, 7, 14, 18, 30)
    });
  }

  // Time using Integer & Boolean
  if ($('.pickatime-limits').length) {
    $('.pickatime-limits').pickatime({
      // An integer (positive/negative) sets it as intervals relative from now.
      min: -5,
      // 'true' sets it to now. 'false' removes any limits.
      max: true
    });
  }

  // Disable All
  if ($('.pickatime-disable-all').length) {
    $('.pickatime-disable-all').pickatime({
      disable: [
        true,
        3, 5, 7,
        [0, 30],
        [2, 0],
        [8, 30],
        [9, 0]
      ]
    });
  }

  // Events
  if ($('.pickatime-events').length) {
    $('.pickatime-events').pickatime({
      onStart: function () {
        console.log('This is PickATime!!!');
      },
      onRender: function () {
        console.log('Holla... PickATime Here');
      },
      onOpen: function () {
        console.log('PickATime Opened');
      },
      onClose: function () {
        console.log("I'm Closed now");
      },
      onStop: function () {
        console.log('Have a great day ahead!!');
      },
      onSet: function (context) {
        console.log('All stuff:', context);
      }
    });
  }

  // Picker Translations
  if ($('.pickatime-translations').length) {
    $('.pickatime-translations').pickatime({
      formatSubmit: 'dd/mm/yyyy',
      monthsFull: ['Janvier', 'Février', 'Mars', 'Avril', 'Mai', 'Juin', 'Juillet', 'Août', 'Septembre', 'Octobre', 'Novembre', 'Décembre'],
      monthsShort: ['Jan', 'Fev', 'Mar', 'Avr', 'Mai', 'Juin', 'Juil', 'Aou', 'Sep', 'Oct', 'Nov', 'Dec'],
      weekdaysShort: ['Dim', 'Lun', 'Mar', 'Mer', 'Jeu', 'Ven', 'Sam'],
      today: 'aujourd\'hui',
      clear: 'clair',
      close: 'Fermer'
    });
  }
})(window, document, jQuery);
