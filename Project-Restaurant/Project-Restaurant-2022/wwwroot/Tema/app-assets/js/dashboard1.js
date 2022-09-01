/*=========================================================================================
    File Name: dashboard1.js
    Description: Dashboard 1
    ----------------------------------------------------------------------------------------
    Item Name: Apex - Responsive Admin Theme
    Author: PIXINVENT
    Author URL: http://www.themeforest.net/user/pixinvent
==========================================================================================*/

var lineArea, widgetlineChart, widgetlineChart1, widgetlineChart2, widgetlineChart3, stackbarchart, lineArea2, lineChart, barChart, donut;

// chartist chart
// ------------------------------
$(window).on("load", function () {

  //-------------- Line Chart Widget 1 Configuration starts --------------

  widgetlineChart = new Chartist.Line(
    "#Widget-line-chart", {
      labels: [
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10"
      ],
      series: [
        [50, 45, 60, 55, 70, 55, 60, 55, 65, 57]
      ]
    }, {
      axisX: {
        showGrid: true,
        showLabel: false,
        offset: 0
      },
      axisY: {
        showGrid: false,
        low: 40,
        showLabel: false,
        offset: 0
      },
      lineSmooth: Chartist.Interpolation.cardinal({
        tension: 0
      }),
      fullWidth: true
    }
  )


  //-------------- Line Chart Widget 2 Configuration starts --------------

  widgetlineChart1 = new Chartist.Line(
    "#Widget-line-chart1", {
      labels: [
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10"
      ],
      series: [
        [80, 60, 70, 50, 60, 53, 71, 48, 65, 60]
      ]
    }, {
      axisX: {
        showGrid: true,
        showLabel: false,
        offset: 0
      },
      axisY: {
        showGrid: false,
        low: 40,
        showLabel: false,
        offset: 0
      },
      lineSmooth: Chartist.Interpolation.cardinal({
        tension: 0
      }),
      fullWidth: true
    }
  )


  //-------------- Line Chart Widget 3 Configuration starts --------------

  widgetlineChart2 = new Chartist.Line(
    "#Widget-line-chart2", {
      labels: [
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10"
      ],
      series: [
        [45, 55, 51, 65, 50, 62, 58, 70, 48, 57]
      ]
    }, {
      axisX: {
        showGrid: true,
        showLabel: false,
        offset: 0
      },
      axisY: {
        showGrid: false,
        low: 40,
        showLabel: false,
        offset: 0
      },
      lineSmooth: Chartist.Interpolation.cardinal({
        tension: 0
      }),
      fullWidth: true
    }
  )


  //-------------- Line Chart Widget 4 Configuration starts --------------

  widgetlineChart3 = new Chartist.Line(
    "#Widget-line-chart3", {
      labels: [
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10"
      ],
      series: [
        [70, 55, 90, 49, 65, 60, 78, 55, 80, 68]
      ]
    }, {
      axisX: {
        showGrid: true,
        showLabel: false,
        offset: 0
      },
      axisY: {
        showGrid: false,
        low: 40,
        showLabel: false,
        offset: 0
      },
      lineSmooth: Chartist.Interpolation.cardinal({
        tension: 0
      }),
      fullWidth: true
    }
  )


  //-------------- Line with Area Chart starts --------------

  lineArea = new Chartist.Line(
    "#line-area", {
      labels: [1, 2, 3, 4, 5, 6, 7, 8],
      series: [
        [0, 20, 10, 45, 20, 36, 21, 0],
        [0, 5, 22, 14, 32, 12, 28, 0]
      ]
    }, {
      low: 0,
      showArea: true,
      fullWidth: true,
      onlyInteger: true,
      axisY: {
        low: 0,
        scaleMinSpace: 50
      },
      axisX: {
        showGrid: false
      }
    }
  )
  lineArea.on("created", function (data) {
    var defs = data.svg.elem("defs")
    defs
      .elem("linearGradient", {
        id: "gradient",
        x1: 0,
        y1: 1,
        x2: 1,
        y2: 0
      })
      .elem("stop", {
        offset: 0,
        "stop-color": "rgba(0, 201, 255, 1)"
      })
      .parent()
      .elem("stop", {
        offset: 1,
        "stop-color": "rgba(146, 254, 157, 1)"
      })
    defs
      .elem("linearGradient", {
        id: "gradient1",
        x1: 0,
        y1: 1,
        x2: 1,
        y2: 0
      })
      .elem("stop", {
        offset: 0,
        "stop-color": "rgba(132, 60, 247, 1)"
      })
      .parent()
      .elem("stop", {
        offset: 1,
        "stop-color": "rgba(56, 184, 242, 1)"
      })
  })


  //-------------- bar Chart starts --------------

  stackbarchart = new Chartist.Bar(
    "#Stack-bar-chart", {
      labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun"],
      series: [
        [8, 9, 5, 6, 7, 4],
        [2, 1, 5, 4, 3, 6]
      ]
    }, {
      stackBars: true,
      fullWidth: true,
      axisX: {
        showGrid: false
      },
      axisY: {
        showGrid: false,
        showLabel: false,
        offset: 0
      },
      chartPadding: 30
    }
  )
  stackbarchart.on("created", function (data) {
    var defs = data.svg.elem("defs")
    defs
      .elem("linearGradient", {
        id: "linear",
        x1: 0,
        y1: 1,
        x2: 0,
        y2: 0
      })
      .elem("stop", {
        offset: 0,
        "stop-color": "#7441DB"
      })
      .parent()
      .elem("stop", {
        offset: 1,
        "stop-color": "#C89CFF"
      })
  })
  stackbarchart.on("draw", function (data) {
    if (data.type === "bar") {
      data.element.attr({
        style: "stroke-width: 5px",
        x1: data.x1 + 0.001
      })
    } else if (data.type === "label") {
      data.element.attr({
        y: 270
      })
    }
  })

  //-------------- Line with Area Chart 2 starts --------------

  lineArea2 = new Chartist.Line(
    "#line-area2", {
      labels: [
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "Jun",
        "Jul",
        "Aug",
        "Sep",
        "Oct",
        "Nov",
        "Dec"
      ],
      series: [
        [5, 30, 25, 55, 45, 65, 60, 105, 80, 110, 120, 150],
        [80, 95, 87, 155, 140, 147, 130, 180, 160, 175, 165, 200]
      ]
    }, {
      showArea: true,
      fullWidth: true,
      lineSmooth: Chartist.Interpolation.none(),
      axisX: {
        showGrid: false
      },
      axisY: {
        low: 0,
        scaleMinSpace: 50
      }
    },
    [
      [
        "screen and (max-width: 640px) and (min-width: 381px)",
        {
          axisX: {
            labelInterpolationFnc: function (value, index) {
              return index % 2 === 0 ? value : null
            }
          }
        }
      ],
      [
        "screen and (max-width: 380px)",
        {
          axisX: {
            labelInterpolationFnc: function (value, index) {
              return index % 3 === 0 ? value : null
            }
          }
        }
      ]
    ]
  )
  lineArea2.on("created", function (data) {
    var defs = data.svg.elem("defs")
    defs
      .elem("linearGradient", {
        id: "gradient2",
        x1: 0,
        y1: 1,
        x2: 0,
        y2: 0
      })
      .elem("stop", {
        offset: 0,
        "stop-opacity": "0.2",
        "stop-color": "transparent"
      })
      .parent()
      .elem("stop", {
        offset: 1,
        "stop-opacity": "0.2",
        "stop-color": "#60AFF0"
      })
    defs
      .elem("linearGradient", {
        id: "gradient3",
        x1: 0,
        y1: 1,
        x2: 0,
        y2: 0
      })
      .elem("stop", {
        offset: 0.3,
        "stop-opacity": "0.2",
        "stop-color": "transparent"
      })
      .parent()
      .elem("stop", {
        offset: 1,
        "stop-opacity": "0.2",
        "stop-color": "#6CD975"
      })
  })
  lineArea2.on("draw", function (data) {
    var circleRadius = 4
    if (data.type === "point") {
      var circle = new Chartist.Svg("circle", {
        cx: data.x,
        cy: data.y,
        r: circleRadius,
        class: "ct-point-circle"
      })
      data.element.replace(circle)
    } else if (data.type === "label") {
      // adjust label position for rotation
      var dX = data.width / 2 + (30 - data.width)
      data.element.attr({
        x: data.element.attr("x") - dX
      })
    }
  })


  //-------------- Line Chart starts --------------

  lineChart = new Chartist.Line(
    "#lineChart", {
      labels: ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"],
      series: [
        [80, 85, 75, 65, 63, 70, 82]
      ]
    }, {
      axisX: {
        showGrid: false
      },
      axisY: {
        showGrid: false,
        showLabel: false,
        low: 0,
        high: 100,
        offset: 0
      },
      fullWidth: true,
      offset: 0
    }
  )
  lineChart.on("created", function (data) {
    var circleRadius = 4
    if (data.type === "point") {
      var circle = new Chartist.Svg("circle", {
        cx: data.x,
        cy: data.y,
        r: circleRadius,
        class: "ct-point-circle"
      })
      data.element.replace(circle)
    } else if (data.type === "label") {
      // adjust label position for rotation
      var dX = data.width / 2 + (30 - data.width)
      data.element.attr({
        x: data.element.attr("x") - dX
      })
    }
  })

  //-------------- Bar Chart starts --------------

  barChart = new Chartist.Bar(
    "#bar-chart", {
      labels: ["Sport", "Music", "Travel", "News"],
      series: [
        [53, 23, 40, 30]
      ]
    }, {
      axisX: {
        showGrid: false
      },
      axisY: {
        showGrid: false,
        showLabel: false,
        offset: 0
      },
      low: 0,
      high: 60
    },
    [
      [
        "screen and (max-width: 640px)",
        {
          seriesBarDistance: 5,
          axisX: {
            labelInterpolationFnc: function (value) {
              return value[0]
            }
          }
        }
      ]
    ]
  )
  barChart.on("created", function (data) {
    var defs = data.svg.elem("defs")
    defs
      .elem("linearGradient", {
        id: "gradient4",
        x1: 0,
        y1: 1,
        x2: 0,
        y2: 0
      })
      .elem("stop", {
        offset: 0,
        "stop-color": "#8E1A38"
      })
      .parent()
      .elem("stop", {
        offset: 1,
        "stop-color": "#FAA750"
      })
    defs
      .elem("linearGradient", {
        id: "gradient5",
        x1: 0,
        y1: 1,
        x2: 0,
        y2: 0
      })
      .elem("stop", {
        offset: 0,
        "stop-color": "#1750A5"
      })
      .parent()
      .elem("stop", {
        offset: 1,
        "stop-color": "#40C057"
      })
    defs
      .elem("linearGradient", {
        id: "gradient6",
        x1: 0,
        y1: 1,
        x2: 0,
        y2: 0
      })
      .elem("stop", {
        offset: 0,
        "stop-color": "#3B1C93"
      })
      .parent()
      .elem("stop", {
        offset: 1,
        "stop-color": "#60AFF0"
      })
    defs
      .elem("linearGradient", {
        id: "gradient7",
        x1: 0,
        y1: 1,
        x2: 0,
        y2: 0
      })
      .elem("stop", {
        offset: 0,
        "stop-color": "#562DB7"
      })
      .parent()
      .elem("stop", {
        offset: 1,
        "stop-color": "#F55252"
      })
  })
  barChart.on("draw", function (data) {
    var barHorizontalCenter, barVerticalCenter, label, value
    if (data.type === "bar") {
      data.element.attr({
        y1: 195,
        x1: data.x1 + 0.001
      })
    }
  })


  //-------------- Donut Chart starts --------------

  var Donutdata = {
    series: [{
        name: "done",
        className: "ct-done",
        value: 23
      },
      {
        name: "progress",
        className: "ct-progress",
        value: 14
      },
      {
        name: "outstanding",
        className: "ct-outstanding",
        value: 35
      },
      {
        name: "started",
        className: "ct-started",
        value: 28
      }
    ]
  }
  donut = new Chartist.Pie(
    "#donut-dashboard-chart", {
      series: [{
          name: "done",
          className: "ct-done",
          value: 23
        },
        {
          name: "progress",
          className: "ct-progress",
          value: 14
        },
        {
          name: "outstanding",
          className: "ct-outstanding",
          value: 35
        },
        {
          name: "started",
          className: "ct-started",
          value: 28
        }
      ]
    }, {
      donut: true,
      startAngle: 0,
      labelInterpolationFnc: function (value) {
        var total = Donutdata.series.reduce(function (prev, series) {
          return prev + series.value
        }, 0)
        return total + "%"
      }
    }
  )
  donut.on("draw", function (data) {
    if (data.type === "label") {
      if (data.index === 0) {
        data.element.attr({
          dx: data.element.root().width() / 2,
          dy: data.element.root().height() / 2
        })
      } else {
        data.element.remove()
      }
    }
  })
});

$(window).on("resize", function(){
  lineArea.update();
  widgetlineChart.update();
  widgetlineChart1.update();
  widgetlineChart2.update();
  widgetlineChart3.update();
  stackbarchart.update();
  lineArea2.update();
  lineChart.update();
  barChart.update();
  donut.update();
});
