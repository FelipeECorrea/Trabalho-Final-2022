/*=========================================================================================
    File Name: dashboard2.js
    Description: Dashboard 2
    ----------------------------------------------------------------------------------------
    Item Name: Apex - Responsive Admin Theme
    Author: PIXINVENT
    Author URL: http://www.themeforest.net/user/pixinvent
==========================================================================================*/

var widgetlineChart1, widgetlineChart2, widgetlineChart3, widgetlineChart4, donutChart1, donutChart2, donutChart3, lineChart2, widgetLineChart22, lineArea3;

// chartist chart
// ------------------------------
$(window).on("load", function () {

  //-------------- Line Chart Widget 1 Configuration starts --------------

  widgetlineChart1 = new Chartist.Line('#Widget-line-chart', {
    labels: ["Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug"],
    series: [
      [55, 60, 50, 55, 50, 60, 55, 57]
    ]
  }, {
    axisX: {
      showGrid: false,
      showLabel: false,
      offset: 0,
    },
    axisY: {
      showGrid: false,
      low: 50,
      showLabel: false,
      offset: 0,
    },
    fullWidth: true
  });


  //-------------- Line Chart Widget 2 Configuration starts --------------

  widgetlineChart2 = new Chartist.Line('#Widget-line-chart2', {
    labels: ["Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug"],
    series: [
      [75, 50, 65, 55, 75, 50, 65, 70]
    ]
  }, {
    axisX: {
      showGrid: false,
      showLabel: false,
      offset: 0,
    },
    axisY: {
      showGrid: false,
      low: 50,
      showLabel: false,
      offset: 0,
    },
    fullWidth: true
  });


  //-------------- Line Chart Widget 3 Configuration starts --------------

  widgetlineChart3 = new Chartist.Line('#Widget-line-chart3', {
    labels: ["Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug"],
    series: [
      [57, 60, 55, 65, 50, 70, 60, 65]
    ]
  }, {
    axisX: {
      showGrid: false,
      showLabel: false,
      offset: 0,
    },
    axisY: {
      showGrid: false,
      low: 50,
      showLabel: false,
      offset: 0,
    },
    fullWidth: true
  });


  //-------------- Line Chart Widget 4 Configuration starts --------------

  widgetlineChart4 = new Chartist.Line('#Widget-line-chart4', {
    labels: ["Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug"],
    series: [
      [57, 55, 60, 50, 55, 50, 60, 55]
    ]
  }, {
    axisX: {
      showGrid: false,
      showLabel: false,
      offset: 0,
    },
    axisY: {
      showGrid: false,
      low: 50,
      showLabel: false,
      offset: 0,
    },
    fullWidth: true
  });


  //-------------- Line Chart 1 starts --------------

  var $info = "#2F8BE6",
    $info_light = "#ACE0FC"
  var themeColors = [$info, $info_light];
  var columnChartOptions = {
    chart: {
      height: 350,
      type: 'bar',
      toolbar: {
        show: false
      },
      animations: {
        enabled: false
      }
    },
    colors: themeColors,
    plotOptions: {
      bar: {
        horizontal: false,
        endingShape: 'rounded',
        columnWidth: '25%',
      },
    },
    grid: {
      borderColor: "#BDBDBD44"
    },
    dataLabels: {
      enabled: false
    },
    stroke: {
      show: true,
      width: 2,
      colors: ['transparent']
    },
    series: [{
      name: 'Net Profit',
      data: [40, 50, 110, 90, 85, 115, 100, 90]
    }, {
      name: 'Revenue',
      data: [30, 40, 100, 80, 75, 105, 90, 80]
    }],
    legend: {
      show: false
    },
    xaxis: {
      categories: ['Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep'],
      axisBorder: {
        color: "#BDBDBD44"
      }
    },
    tooltip: {
      y: {
        formatter: function (val) {
          return "$" + val + " thousands"
        }
      }
    }
  }
  var columnChart = new ApexCharts(
    document.querySelector("#line-chart1"),
    columnChartOptions
  );
  columnChart.render();


  //-------------- Donut Chart 1 starts --------------

  donutChart1 = new Chartist.Pie('#donut-chart1', {
    series: [{
        name: 'done',
        className: 'ct-done',
        value: 10
      },
      {
        name: 'outstanding',
        className: 'ct-outstanding',
        value: 3
      }
    ]
  }, {
    donut: true,
    donutWidth: 3,
    startAngle: 0,
    chartPadding: 25,
    total: 13,
    labelInterpolationFnc: function (value) {
      return '\ue8dd';
    }
  });
  donutChart1.on('draw', function (data) {
    if (data.type === 'label') {
      if (data.index === 0) {
        data.element.attr({
          dx: data.element.root().width() / 2,
          dy: ((data.element.root().height() + (data.element.height() / 4)) / 2) - 10,
          class: 'ct-label',
          'font-family': 'feather'
        });
      } else {
        data.element.remove();
      }
    }
  });


  //-------------- Donut Chart 2 starts --------------

  donutChart2 = new Chartist.Pie('#donut-chart2', {
    series: [{
        "name": "done",
        "className": "ct-done",
        "value": 10
      },
      {
        "name": "outstanding",
        "className": "ct-outstanding",
        "value": 3
      }
    ]
  }, {
    donut: true,
    donutWidth: 3,
    startAngle: 90,
    chartPadding: 25,
    labelInterpolationFnc: function (value) {
      return '\ue8f8';
    }
  });
  donutChart2.on('draw', function (data) {
    if (data.type === 'label') {
      if (data.index === 0) {
        data.element.attr({
          dx: data.element.root().width() / 2,
          dy: ((data.element.root().height() + (data.element.height() / 4)) / 2) - 10,
          class: 'ct-label',
          'font-family': 'feather'
        });
      } else {
        data.element.remove();
      }
    }
  });


  //-------------- Donut Chart 3 starts --------------

  donutChart3 = new Chartist.Pie('#donut-chart3', {
    series: [{
        "name": "done",
        "className": "ct-done",
        "value": 10
      },
      {
        "name": "outstanding",
        "className": "ct-outstanding",
        "value": 3
      }
    ]
  }, {
    donut: true,
    donutWidth: 3,
    startAngle: 270,
    chartPadding: 25,
    labelInterpolationFnc: function (value) {
      return '\ue879';
    }
  });
  donutChart3.on('draw', function (data) {
    if (data.type === 'label') {
      if (data.index === 0) {
        data.element.attr({
          dx: data.element.root().width() / 2,
          dy: ((data.element.root().height() + (data.element.height() / 4)) / 2) - 10,
          class: 'ct-label',
          'font-family': 'feather'
        });
      } else {
        data.element.remove();
      }
    }
  });


  //-------------- Line Chart 2 starts --------------

  lineChart2 = new Chartist.Line('#line-chart2', {
    labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"],
    series: [
      [160, 150, 140, 120, 75, 35, 45, 65, 100, 145, 160, 180],
      [100, 95, 90, 100, 110, 120, 130, 140, 130, 95, 75, 80]
    ]
  }, {
    axisX: {
      showGrid: false,
    },
    axisY: {
      low: 0,
      scaleMinSpace: 50,
    },
    fullWidth: true,
    chartPadding: {
      top: 0,
      right: 25,
      bottom: 0,
      left: 0
    },
  },
  [
    ['screen and (max-width: 640px) and (min-width: 381px)', {
      axisX: {
        labelInterpolationFnc: function (value, index) {
          return index % 2 === 0 ? value : null;
        }
      }
    }],
    ['screen and (max-width: 380px)', {
      axisX: {
        labelInterpolationFnc: function (value, index) {
          return index % 3 === 0 ? value : null;
        }
      }
    }]
  ]);
  lineChart2.on('draw', function (data) {
    var circleRadius = 6;
    if (data.type === 'point') {
      var circle = new Chartist.Svg('circle', {
        cx: data.x,
        cy: data.y,
        r: circleRadius,
        class: 'ct-point-circle'
      });
      data.element.replace(circle);
    }
  });


  //-------------- widget Line Chart 2 starts --------------

  widgetLineChart22 = new Chartist.Line('#Widget-line-chart22', {
    labels: ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"],
    series: [
      [50, 45, 60, 55, 70, 55, 60, 55, 65, 57, 60, 53, 53]
    ]
  }, {
    axisX: {
      showGrid: true,
      showLabel: false,
      offset: 0,
    },
    axisY: {
      showGrid: false,
      low: 40,
      showLabel: false,
      offset: 0,
    },
    lineSmooth: Chartist.Interpolation.cardinal({
      tension: 0
    }),
    fullWidth: true
  });
  widgetLineChart22.on('created', function (data) {
    var defs = data.svg.elem('defs');
    defs.elem('linearGradient', {
      id: 'widgradient1',
      x1: 0,
      y1: 1,
      x2: 0,
      y2: 0
    }).elem('stop', {
      offset: 0,
      'stop-color': '#226CC5'
    }).parent().elem('stop', {
      offset: 1,
      'stop-color': '#81C8F7'
    });
  });


  //-------------- Line with Area Chart  starts --------------

  lineArea3 = new Chartist.Line('#line-area-chart', {
    labels: [1, 2, 3, 4, 5, 6, 7, 8],
    series: [
      [0, 5, 15, 8, 15, 9, 30, 0],
      [0, 3, 5, 2, 8, 1, 5, 0]
    ]
  }, {
    low: 0,
    showArea: true,
    fullWidth: true,
    onlyInteger: true,
    axisY: {
      low: 0,
      scaleMinSpace: 50,
    },
    axisX: {
      showGrid: false
    }
  });
  lineArea3.on('draw', function (data) {
    var circleRadius = 6;
    if (data.type === 'point') {
      var circle = new Chartist.Svg('circle', {
        cx: data.x,
        cy: data.y,
        r: circleRadius,
        class: 'ct-point-circle'
      });
      data.element.replace(circle);
    }
  });
});

$(window).on("resize", function(){
  widgetlineChart1.update();
  widgetlineChart2.update();
  widgetlineChart3.update();
  widgetlineChart4.update();
  donutChart1.update();
  donutChart2.update();
  donutChart3.update();
  lineChart2.update();
  widgetLineChart22.update();
  lineArea3.update();
});
