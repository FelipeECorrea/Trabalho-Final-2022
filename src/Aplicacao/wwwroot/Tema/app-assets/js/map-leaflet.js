$(document).ready(function () {
  $(".maps-leaflet-container").css("height", "450px");

  //-------------- Basic map --------------
  var mapsLeafletBasic = L.map('maps-leaflet-basic').setView([42.35, -71.08], 10);
  L.tileLayer('https://{s}.tile.osm.org/{z}/{x}/{y}.png', {
    attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',
    maxZoom: 18,
  }).addTo(mapsLeafletBasic);


  //-------------- Marker map --------------
  var mapsLeafletMarker = L.map('maps-leaflet-marker').setView([51.5, -0.09], 13);
  var marker = L.marker([51.5, -0.09]).addTo(mapsLeafletMarker);
  var circle = L.circle([51.508, -0.11], {
    color: 'red',
    fillColor: '#D23B48',
    fillOpacity: 0.5,
    radius: 500
  }).addTo(mapsLeafletMarker);
  var polygon = L.polygon([
    [51.509, -0.08],
    [51.503, -0.06],
    [51.51, -0.047]
  ]).addTo(mapsLeafletMarker);
  L.tileLayer('https://{s}.tile.osm.org/{z}/{x}/{y}.png', {
    attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',
    maxZoom: 18,
  }).addTo(mapsLeafletMarker);


  //-------------- Dragable Marker map --------------
  var mapsLeafletMarkerDragable = L.map('maps-leaflet-marker-dragable').setView([48.822152, 2.4150], 12);
  var mapsLeafletMarkerLoc = L.marker([48.822152, 2.4150], {
    draggable: 'true'
  }).addTo(mapsLeafletMarkerDragable);
  mapsLeafletMarkerLoc.bindPopup("<b>Hello world!</b><br>I am a popup.").openPopup();
  L.tileLayer('https://{s}.tile.osm.org/{z}/{x}/{y}.png', {
    attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',
    maxZoom: 18,
  }).addTo(mapsLeafletMarkerDragable);


  //-------------- User Location map --------------
  var mapsLeafletUserLocation = L.map('maps-leaflet-user-location').setView([42.35, -71.08], 10);
  mapsLeafletUserLocation.locate({
    setView: true,
    maxZoom: 16
  });
  function onLocationFound(e) {
    var radius = e.accuracy;
    L.marker(e.latlng).addTo(mapsLeafletUserLocation)
      .bindPopup("You are within " + radius + " meters from this point").openPopup();
    L.circle(e.latlng, radius).addTo(mapsLeafletUserLocation);
  }
  mapsLeafletUserLocation.on('locationfound', onLocationFound);
  L.tileLayer('https://{s}.tile.osm.org/{z}/{x}/{y}.png', {
    attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',
    maxZoom: 18,
  }).addTo(mapsLeafletUserLocation);


  //-------------- Cutom Icons map --------------
  var mapsLeafletCustomIcons = L.map('maps-leaflet-custom-icons').setView([51.5, -0.29], 9);
  var customIconBlue = L.icon({
    iconUrl: '../../../app-assets/img/map/leaflet/map-marker-blue.png',
    iconSize: [52, 52], // size of the icon
    iconAnchor: [22, 94], // point of the icon which will correspond to marker's location
    popupAnchor: [-3, -76] // point from which the popup should open relative to the iconAnchor
  });
  var customIconRed = L.icon({
    iconUrl: '../../../app-assets/img/map/leaflet/leaf-red.png',
    iconSize: [38, 95], // size of the icon
    shadowUrl: '../../../app-assets/img/map/leaflet/leaf-shadow.png',
    shadowSize: [50, 64], // size of the shadow
    shadowAnchor: [4, 62], // the same for the shadow
    iconAnchor: [22, 94], // point of the icon which will correspond to marker's location
    popupAnchor: [-3, -76] // point from which the popup should open relative to the iconAnchor
  });
  L.marker([51.5, -0.09], {
    icon: customIconRed
  }).addTo(mapsLeafletCustomIcons);
  L.marker([51.4, -0.51], {
    icon: customIconBlue
  }).addTo(mapsLeafletCustomIcons);
  L.tileLayer('https://{s}.tile.osm.org/{z}/{x}/{y}.png', {
    attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',
    maxZoom: 18,
  }).addTo(mapsLeafletCustomIcons);


  //-------------- GeoJSON map --------------
  var mapsLeafletGeojson = L.map('maps-leaflet-geojson').setView([44.2669, -95.576], 3);
  var mapsLeafletGeojsoonUsState = L.geoJson(statesData).addTo(mapsLeafletGeojson);
  function getColor(d) {
    return d > 1000 ? '#750F33' :
      d > 500 ? '#8E1A38' :
      d > 200 ? '#B02940' :
      d > 100 ? '#D23B48' :
      d > 50 ? '#F55252' :
      d > 20 ? '#F9877C' :
      d > 10 ? '#FCA897' :
      '#FECBBA';
  }
  function style(feature) {
    return {
      fillColor: getColor(feature.properties.density),
      weight: 2,
      opacity: 1,
      color: 'white',
      dashArray: '3',
      fillOpacity: 0.7
    };
  }
  L.geoJson(statesData, {
    style: style
  }).addTo(mapsLeafletGeojson);
  L.tileLayer('https://{s}.tile.osm.org/{z}/{x}/{y}.png', {
    attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',
    maxZoom: 18,
  }).addTo(mapsLeafletGeojson);


  //-------------- Layer Groups and Layers Control map --------------
  var littleton = L.marker([39.61, -105.02]).bindPopup('This is Littleton, CO.'),
    denver = L.marker([39.74, -104.99]).bindPopup('This is Denver, CO.'),
    aurora = L.marker([39.73, -104.8]).bindPopup('This is Aurora, CO.'),
    golden = L.marker([39.77, -105.23]).bindPopup('This is Golden, CO.');
  var cities = L.layerGroup([littleton, denver, aurora, golden]);
  var street = L.tileLayer('https://{s}.tile.osm.org/{z}/{x}/{y}.png', {
      attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',
      maxZoom: 18,
    }),
    watercolor = L.tileLayer('http://tile.stamen.com/watercolor/{z}/{x}/{y}.jpg', {
      attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',
      maxZoom: 18,
    });
  var mapsLeafletGroupControl = L.map('maps-leaflet-groups-control', {
    center: [39.73, -104.99],
    zoom: 9,
    layers: [street, cities]
  });
  var baseMaps = {
    "Street": street,
    "Watercolor": watercolor
  };
  var overlayMaps = {
    "Cities": cities
  };
  L.control.layers(baseMaps, overlayMaps).addTo(mapsLeafletGroupControl);
  L.tileLayer('https://c.tile.osm.org/{z}/{x}/{y}.png', {
    attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',
    maxZoom: 18,
  }).addTo(mapsLeafletGroupControl);
});
