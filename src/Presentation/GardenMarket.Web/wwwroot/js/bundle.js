$(function(){
  'use strict';


  $('#spark1').sparkline('html', {
    type: 'bar',
    barWidth: 8,
    height: 30,
    barColor: '#29B0D0',
    chartRangeMax: 12
  });

  $('#spark2').sparkline('html', {
    type: 'bar',
    barWidth: 8,
    height: 30,
    barColor: '#6F42C1',
    chartRangeMax: 12
  });

  $('#spark3').sparkline('html', {
    type: 'bar',
    barWidth: 8,
    height: 30,
    barColor: '#20C997',
    chartRangeMax: 12
  });

  $('#spark4').sparkline('html', {
    type: 'bar',
    barWidth: 8,
    height: 30,
    barColor: '#0866C6',
    chartRangeMax: 12
  });

  // peity charts
  $('.peity-line').peity('line');
  $('.peity-donut').peity('donut');


  var rs1 = new Rickshaw.Graph({
    element: document.querySelector('#rickshaw1'),
    renderer: 'bar',
    stack: false,
    max: 50,
    series: [{
      data: [
        { x: 0, y: 20 },
        { x: 1, y: 25 },
        { x: 2, y: 10 },
        { x: 3, y: 15 },
        { x: 4, y: 20 },
        { x: 5, y: 40 },
        { x: 6, y: 15 },
        { x: 7, y: 40 },
        { x: 8, y: 25 }
      ],
      color: '#5058AB'
    },
    {
      data: [
        { x: 0, y: 10 },
        { x: 1, y: 30 },
        { x: 2, y: 45 },
        { x: 3, y: 30 },
        { x: 4, y: 42 },
        { x: 5, y: 20 },
        { x: 6, y: 30 },
        { x: 7, y: 15 },
        { x: 8, y: 20 }
      ],
      color: '#14A0C1'
    }]
  });

  rs1.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    rs1.configure({
      width: $('#rickshaw1').width(),
      height: $('#rickshaw1').height()
    });
    rs1.render();
  });

  var rs2 = new Rickshaw.Graph({
    element: document.querySelector('#rickshaw2'),
    renderer: 'area',
    max: 50,
    series: [{
      data: [
        { x: 0, y: 40 },
        { x: 1, y: 49 },
        { x: 2, y: 38 },
        { x: 3, y: 30 },
        { x: 4, y: 32 },
        { x: 5, y: 40 },
        { x: 6, y: 20 },
        { x: 7, y: 10 },
        { x: 8, y: 20 },
        { x: 9, y: 25 },
        { x: 10, y: 35 },
        { x: 11, y: 20 },
        { x: 12, y: 40 },
        { x: 13, y: 25 }
      ],
      color: '#01CB99'
    }]
  });
  rs2.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    rs2.configure({
      width: $('#rickshaw2').width(),
      height: $('#rickshaw2').height()
    });
    rs2.render();
  });

  var ch5 = new Rickshaw.Graph({
    element: document.querySelector('#ch5'),
    renderer: 'area',
    max: 80,
    series: [{
      data: [
        { x: 0, y: 40 },
        { x: 1, y: 45 },
        { x: 2, y: 30 },
        { x: 3, y: 40 },
        { x: 4, y: 50 },
        { x: 5, y: 40 },
        { x: 6, y: 20 },
        { x: 7, y: 10 },
        { x: 8, y: 20 },
        { x: 9, y: 25 },
        { x: 10, y: 35 },
        { x: 11, y: 20 },
        { x: 12, y: 40 }
      ],
      color: '#0866C6'
    }]
  });
  ch5.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    ch5.configure({
      width: $('#ch5').width(),
      height: $('#ch5').height()
    });
    ch5.render();
  });

  var ch6 = new Rickshaw.Graph({
    element: document.querySelector('#ch6'),
    renderer: 'area',
    max: 80,
    series: [{
      data: [
        { x: 0, y: 40 },
        { x: 1, y: 45 },
        { x: 2, y: 30 },
        { x: 3, y: 40 },
        { x: 4, y: 50 },
        { x: 5, y: 40 },
        { x: 6, y: 20 },
        { x: 7, y: 10 },
        { x: 8, y: 20 },
        { x: 9, y: 25 },
        { x: 10, y: 35 },
        { x: 11, y: 20 },
        { x: 12, y: 40 }
      ],
      color: '#6F42C1'
    }]
  });
  ch6.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    ch6.configure({
      width: $('#ch6').width(),
      height: $('#ch6').height()
    });
    ch6.render();
  });

  var ch7 = new Rickshaw.Graph({
    element: document.querySelector('#ch7'),
    renderer: 'area',
    max: 80,
    series: [{
      data: [
        { x: 0, y: 40 },
        { x: 1, y: 45 },
        { x: 2, y: 30 },
        { x: 3, y: 40 },
        { x: 4, y: 50 },
        { x: 5, y: 40 },
        { x: 6, y: 20 },
        { x: 7, y: 10 },
        { x: 8, y: 20 },
        { x: 9, y: 25 },
        { x: 10, y: 35 },
        { x: 11, y: 20 },
        { x: 12, y: 40 }
      ],
      color: '#20C997'
    }]
  });
  ch7.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    ch7.configure({
      width: $('#ch7').width(),
      height: $('#ch7').height()
    });
    ch7.render();
  });

  var ch8 = new Rickshaw.Graph({
    element: document.querySelector('#ch8'),
    renderer: 'area',
    max: 50,
    series: [{
      data: [
        { x: 0, y: 40 },
        { x: 1, y: 49 },
        { x: 2, y: 38 },
        { x: 3, y: 30 },
        { x: 4, y: 32 },
        { x: 5, y: 40 },
        { x: 6, y: 20 },
        { x: 7, y: 10 },
        { x: 8, y: 20 },
        { x: 9, y: 25 },
        { x: 10, y: 35 },
        { x: 11, y: 20 },
        { x: 12, y: 35 }
      ],
      color: '#0866C6'
    }]
  });
  ch8.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    ch8.configure({
      width: $('#ch8').width(),
      height: $('#ch8').height()
    });
    ch8.render();
  });

  var ch9 = new Rickshaw.Graph({
    element: document.querySelector('#ch9'),
    renderer: 'area',
    max: 50,
    series: [{
      data: [
        { x: 0, y: 35 },
        { x: 1, y: 49 },
        { x: 2, y: 38 },
        { x: 3, y: 30 },
        { x: 4, y: 32 },
        { x: 5, y: 40 },
        { x: 6, y: 20 },
        { x: 7, y: 10 },
        { x: 8, y: 20 },
        { x: 9, y: 25 },
        { x: 10, y: 35 },
        { x: 11, y: 20 },
        { x: 12, y: 40 }
      ],
      color: '#0866C6'
    }]
  });
  ch9.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    ch9.configure({
      width: $('#ch9').width(),
      height: $('#ch9').height()
    });
    ch9.render();
  });


  var ch10 = new Rickshaw.Graph({
    element: document.querySelector('#ch10'),
    renderer: 'bar',
    max: 50,
    series: [{
      data: [
        { x: 0, y: 40 },
        { x: 1, y: 49 },
        { x: 2, y: 38 },
        { x: 3, y: 30 },
        { x: 4, y: 32 },
        { x: 5, y: 40 },
        { x: 6, y: 20 },
        { x: 7, y: 10 },
        { x: 8, y: 20 },
        { x: 9, y: 25 },
        { x: 10, y: 35 },
        { x: 11, y: 20 },
        { x: 12, y: 35 }
      ],
      color: '#6F42C1'
    }]
  });
  ch10.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    ch10.configure({
      width: $('#ch10').width(),
      height: $('#ch10').height()
    });
    ch10.render();
  });

  var ch11 = new Rickshaw.Graph({
    element: document.querySelector('#ch11'),
    renderer: 'bar',
    max: 50,
    series: [{
      data: [
        { x: 0, y: 35 },
        { x: 1, y: 49 },
        { x: 2, y: 38 },
        { x: 3, y: 30 },
        { x: 4, y: 32 },
        { x: 5, y: 40 },
        { x: 6, y: 20 },
        { x: 7, y: 10 },
        { x: 8, y: 20 },
        { x: 9, y: 25 },
        { x: 10, y: 35 },
        { x: 11, y: 20 },
        { x: 12, y: 40 }
      ],
      color: '#6F42C1'
    }]
  });
  ch11.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    ch11.configure({
      width: $('#ch11').width(),
      height: $('#ch11').height()
    });
    ch11.render();
  });

});

// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/**
 * Copyright Marc J. Schmidt. See the LICENSE file at the top-level
 * directory of this distribution and at
 * https://github.com/marcj/css-element-queries/blob/master/LICENSE.
 */
;

'use strict';

(function (root, factory) {
    if (typeof define === "function" && define.amd) {
        define(factory);
    } else if (typeof exports === "object") {
        module.exports = factory();
    } else {
        root.ResizeSensor = factory();
    }
}(typeof window !== 'undefined' ? window : this, function () {

    // Make sure it does not throw in a SSR (Server Side Rendering) situation
    if (typeof window === "undefined") {
        return null;
    }
    // Only used for the dirty checking, so the event callback count is limited to max 1 call per fps per sensor.
    // In combination with the event based resize sensor this saves cpu time, because the sensor is too fast and
    // would generate too many unnecessary events.
    var requestAnimationFrame = window.requestAnimationFrame ||
        window.mozRequestAnimationFrame ||
        window.webkitRequestAnimationFrame ||
        function (fn) {
            return window.setTimeout(fn, 20);
        };

    /**
     * Iterate over each of the provided element(s).
     *
     * @param {HTMLElement|HTMLElement[]} elements
     * @param {Function}                  callback
     */
    function forEachElement(elements, callback){
        var elementsType = Object.prototype.toString.call(elements);
        var isCollectionTyped = ('[object Array]' === elementsType
            || ('[object NodeList]' === elementsType)
            || ('[object HTMLCollection]' === elementsType)
            || ('[object Object]' === elementsType)
            || ('undefined' !== typeof jQuery && elements instanceof jQuery) //jquery
            || ('undefined' !== typeof Elements && elements instanceof Elements) //mootools
        );
        var i = 0, j = elements.length;
        if (isCollectionTyped) {
            for (; i < j; i++) {
                callback(elements[i]);
            }
        } else {
            callback(elements);
        }
    }

    /**
     * Class for dimension change detection.
     *
     * @param {Element|Element[]|Elements|jQuery} element
     * @param {Function} callback
     *
     * @constructor
     */
    var ResizeSensor = function(element, callback) {
        /**
         *
         * @constructor
         */
        function EventQueue() {
            var q = [];
            this.add = function(ev) {
                q.push(ev);
            };

            var i, j;
            this.call = function() {
                for (i = 0, j = q.length; i < j; i++) {
                    q[i].call();
                }
            };

            this.remove = function(ev) {
                var newQueue = [];
                for(i = 0, j = q.length; i < j; i++) {
                    if(q[i] !== ev) newQueue.push(q[i]);
                }
                q = newQueue;
            }

            this.length = function() {
                return q.length;
            }
        }

        /**
         *
         * @param {HTMLElement} element
         * @param {Function}    resized
         */
        function attachResizeEvent(element, resized) {
            if (!element) return;
            if (element.resizedAttached) {
                element.resizedAttached.add(resized);
                return;
            }

            element.resizedAttached = new EventQueue();
            element.resizedAttached.add(resized);

            element.resizeSensor = document.createElement('div');
            element.resizeSensor.className = 'resize-sensor';
            var style = 'position: absolute; left: 0; top: 0; right: 0; bottom: 0; overflow: hidden; z-index: -1; visibility: hidden;';
            var styleChild = 'position: absolute; left: 0; top: 0; transition: 0s;';

            element.resizeSensor.style.cssText = style;
            element.resizeSensor.innerHTML =
                '<div class="resize-sensor-expand" style="' + style + '">' +
                    '<div style="' + styleChild + '"></div>' +
                '</div>' +
                '<div class="resize-sensor-shrink" style="' + style + '">' +
                    '<div style="' + styleChild + ' width: 200%; height: 200%"></div>' +
                '</div>';
            element.appendChild(element.resizeSensor);

            if (element.resizeSensor.offsetParent !== element) {
                element.style.position = 'relative';
            }

            var expand = element.resizeSensor.childNodes[0];
            var expandChild = expand.childNodes[0];
            var shrink = element.resizeSensor.childNodes[1];
            var dirty, rafId, newWidth, newHeight;
            var lastWidth = element.offsetWidth;
            var lastHeight = element.offsetHeight;

            var reset = function() {
                expandChild.style.width = '100000px';
                expandChild.style.height = '100000px';

                expand.scrollLeft = 100000;
                expand.scrollTop = 100000;

                shrink.scrollLeft = 100000;
                shrink.scrollTop = 100000;
            };

            reset();

            var onResized = function() {
                rafId = 0;

                if (!dirty) return;

                lastWidth = newWidth;
                lastHeight = newHeight;

                if (element.resizedAttached) {
                    element.resizedAttached.call();
                }
            };

            var onScroll = function() {
                newWidth = element.offsetWidth;
                newHeight = element.offsetHeight;
                dirty = newWidth != lastWidth || newHeight != lastHeight;

                if (dirty && !rafId) {
                    rafId = requestAnimationFrame(onResized);
                }

                reset();
            };

            var addEvent = function(el, name, cb) {
                if (el.attachEvent) {
                    el.attachEvent('on' + name, cb);
                } else {
                    el.addEventListener(name, cb);
                }
            };

            addEvent(expand, 'scroll', onScroll);
            addEvent(shrink, 'scroll', onScroll);
        }

        forEachElement(element, function(elem){
            attachResizeEvent(elem, callback);
        });

        this.detach = function(ev) {
            ResizeSensor.detach(element, ev);
        };
    };

    ResizeSensor.detach = function(element, ev) {
        forEachElement(element, function(elem){
            if (!elem) return
            if(elem.resizedAttached && typeof ev == "function"){
                elem.resizedAttached.remove(ev);
                if(elem.resizedAttached.length()) return;
            }
            if (elem.resizeSensor) {
                if (elem.contains(elem.resizeSensor)) {
                    elem.removeChild(elem.resizeSensor);
                }
                delete elem.resizeSensor;
                delete elem.resizedAttached;
            }
        });
    };

    return ResizeSensor;

}));

$(function() {

  'use strict';

  var styleShiftWorker = [{
    'featureType': 'administrative',
    'elementType': 'all',
    'stylers': [{
      'visibility': 'on'
    }, {
      'lightness': 33
    }]
  }, {
    'featureType': 'administrative',
    'elementType': 'labels',
    'stylers': [{
      'saturation': '-100'
    }]
  }, {
    'featureType': 'administrative',
    'elementType': 'labels.text',
    'stylers': [{
      'gamma': '0.75'
    }]
  }, {
    'featureType': 'administrative.neighborhood',
    'elementType': 'labels.text.fill',
    'stylers': [{
      'lightness': '-37'
    }]
  }, {
    'featureType': 'landscape',
    'elementType': 'geometry',
    'stylers': [{
      'color': '#f9f9f9'
    }]
  }, {
    'featureType': 'landscape.man_made',
    'elementType': 'geometry',
    'stylers': [{
      'saturation': '-100'
    }, {
      'lightness': '40'
    }, {
      'visibility': 'off'
    }]
  }, {
    'featureType': 'landscape.natural',
    'elementType': 'labels.text.fill',
    'stylers': [{
      'saturation': '-100'
    }, {
      'lightness': '-37'
    }]
  }, {
    'featureType': 'landscape.natural',
    'elementType': 'labels.text.stroke',
    'stylers': [{
      'saturation': '-100'
    }, {
      'lightness': '100'
    }, {
      'weight': '2'
    }]
  }, {
    'featureType': 'landscape.natural',
    'elementType': 'labels.icon',
    'stylers': [{
      'saturation': '-100'
    }]
  }, {
    'featureType': 'poi',
    'elementType': 'geometry',
    'stylers': [{
      'saturation': '-100'
    }, {
      'lightness': '80'
    }]
  }, {
    'featureType': 'poi',
    'elementType': 'labels',
    'stylers': [{
      'saturation': '-100'
    }, {
      'lightness': '0'
    }]
  }, {
    'featureType': 'poi.attraction',
    'elementType': 'geometry',
    'stylers': [{
      'lightness': '-4'
    }, {
      'saturation': '-100'
    }]
  }, {
    'featureType': 'poi.park',
    'elementType': 'geometry',
    'stylers': [{
      'color': '#c5dac6'
    }, {
      'visibility': 'on'
    }, {
      'saturation': '-95'
    }, {
      'lightness': '62'
    }]
  }, {
    'featureType': 'poi.park',
    'elementType': 'labels',
    'stylers': [{
      'visibility': 'on'
    }, {
      'lightness': 20
    }]
  }, {
    'featureType': 'road',
    'elementType': 'all',
    'stylers': [{
      'lightness': 20
    }]
  }, {
    'featureType': 'road',
    'elementType': 'labels',
    'stylers': [{
      'saturation': '-100'
    }, {
      'gamma': '1.00'
    }]
  }, {
    'featureType': 'road',
    'elementType': 'labels.text',
    'stylers': [{
      'gamma': '0.50'
    }]
  }, {
    'featureType': 'road',
    'elementType': 'labels.icon',
    'stylers': [{
      'saturation': '-100'
    }, {
      'gamma': '0.50'
    }]
  }, {
    'featureType': 'road.highway',
    'elementType': 'geometry',
    'stylers': [{
      'color': '#c5c6c6'
    }, {
      'saturation': '-100'
    }]
  }, {
    'featureType': 'road.highway',
    'elementType': 'geometry.stroke',
    'stylers': [{
      'lightness': '-13'
    }]
  }, {
    'featureType': 'road.highway',
    'elementType': 'labels.icon',
    'stylers': [{
      'lightness': '0'
    }, {
      'gamma': '1.09'
    }]
  }, {
    'featureType': 'road.arterial',
    'elementType': 'geometry',
    'stylers': [{
      'color': '#e4d7c6'
    }, {
      'saturation': '-100'
    }, {
      'lightness': '47'
    }]
  }, {
    'featureType': 'road.arterial',
    'elementType': 'geometry.stroke',
    'stylers': [{
      'lightness': '-12'
    }]
  }, {
    'featureType': 'road.arterial',
    'elementType': 'labels.icon',
    'stylers': [{
      'saturation': '-100'
    }]
  }, {
    'featureType': 'road.local',
    'elementType': 'geometry',
    'stylers': [{
      'color': '#fbfaf7'
    }, {
      'lightness': '77'
    }]
  }, {
    'featureType': 'road.local',
    'elementType': 'geometry.fill',
    'stylers': [{
      'lightness': '-5'
    }, {
      'saturation': '-100'
    }]
  }, {
    'featureType': 'road.local',
    'elementType': 'geometry.stroke',
    'stylers': [{
      'saturation': '-100'
    }, {
      'lightness': '-15'
    }]
  }, {
    'featureType': 'transit.station.airport',
    'elementType': 'geometry',
    'stylers': [{
      'lightness': '47'
    }, {
      'saturation': '-100'
    }]
  }, {
    'featureType': 'water',
    'elementType': 'all',
    'stylers': [{
      'visibility': 'on'
    }, {
      'color': '#14a0c1'
    }]
  }, {
    'featureType': 'water',
    'elementType': 'geometry',
    'stylers': [{
      'saturation': '53'
    }]
  }, {
    'featureType': 'water',
    'elementType': 'labels.text.fill',
    'stylers': [{
      'lightness': '-42'
    }, {
      'saturation': '17'
    }]
  }, {
    'featureType': 'water',
    'elementType': 'labels.text.stroke',
    'stylers': [{
      'lightness': '61'
    }]
  }];

  var mapShiftWorker = new GMaps({
    el: '#mapShiftWorker',
    zoom: 14,
    lat: 40.702247,
    lng: -73.996349
  });

  // Map style is based on:
  // https://snazzymaps.com/style/4183/mostly-grayscale
  mapShiftWorker.addStyle({
    styledMapName:'Shift Worker Map',
    styles: styleShiftWorker,
    mapTypeId: 'map_shift_worker'
  });

  mapShiftWorker.setStyle('map_shift_worker');

});

$(function() {

  'use strict';

  var styleShadesOfGrey = [{
    'featureType': 'all',
    'elementType': 'labels.text.fill',
    'stylers': [{
      'saturation': 36
    }, {
      'color': '#000000'
    }, {
      'lightness': 40
    }]
  }, {
    'featureType': 'all',
    'elementType': 'labels.text.stroke',
    'stylers': [{
      'visibility': 'on'
    }, {
      'color': '#000000'
    }, {
      'lightness': 16
    }]
  }, {
    'featureType': 'all',
    'elementType': 'labels.icon',
    'stylers': [{
      'visibility': 'off'
    }]
  }, {
    'featureType': 'administrative',
    'elementType': 'geometry.fill',
    'stylers': [{
      'color': '#000000'
    }, {
      'lightness': 20
    }]
  }, {
    'featureType': 'administrative',
    'elementType': 'geometry.stroke',
    'stylers': [{
      'color': '#000000'
    }, {
      'lightness': 17
    }, {
      'weight': 1.2
    }]
  }, {
    'featureType': 'landscape',
    'elementType': 'geometry',
    'stylers': [{
      'color': '#000000'
    }, {
      'lightness': 20
    }]
  }, {
    'featureType': 'poi',
    'elementType': 'geometry',
    'stylers': [{
      'color': '#000000'
    }, {
      'lightness': 21
    }]
  }, {
    'featureType': 'road.highway',
    'elementType': 'geometry.fill',
    'stylers': [{
      'color': '#000000'
    }, {
      'lightness': 17
    }]
  }, {
    'featureType': 'road.highway',
    'elementType': 'geometry.stroke',
    'stylers': [{
      'color': '#000000'
    }, {
      'lightness': 29
    }, {
      'weight': 0.2
    }]
  }, {
    'featureType': 'road.arterial',
    'elementType': 'geometry',
    'stylers': [{
      'color': '#000000'
    }, {
      'lightness': 18
    }]
  }, {
    'featureType': 'road.local',
    'elementType': 'geometry',
    'stylers': [{
      'color': '#000000'
    }, {
      'lightness': 16
    }]
  }, {
    'featureType': 'transit',
    'elementType': 'geometry',
    'stylers': [{
      'color': '#000000'
    }, {
      'lightness': 19
    }]
  }, {
    'featureType': 'water',
    'elementType': 'geometry',
    'stylers': [{
      'color': '#000000'
    }, {
      'lightness': 17
    }]
  }];

  var mapShadesOfGrey = new GMaps({
    el: '#mapShadesOfGrey',
    zoom: 14,
    lat: 40.702247,
    lng: -73.996349
  });


  // Map style is based on:
  // https://snazzymaps.com/style/4183/mostly-grayscale
  mapShadesOfGrey.addStyle({
    styledMapName:'Shades Of Grey Map',
    styles: styleShadesOfGrey,
    mapTypeId: 'map_shades_of_grey'
  });

  mapShadesOfGrey.setStyle('map_shades_of_grey');

});

$(function() {

  'use strict';

  var styleMapBox = [{
    'featureType': 'water',
    'stylers': [{
      'saturation': 43
    }, {
      'lightness': -11
    }, {
      'hue': '#0088ff'
    }]
  }, {
    'featureType': 'road',
    'elementType': 'geometry.fill',
    'stylers': [{
      'hue': '#ff0000'
    }, {
      'saturation': -100
    }, {
      'lightness': 99
    }]
  }, {
    'featureType': 'road',
    'elementType': 'geometry.stroke',
    'stylers': [{
      'color': '#808080'
    }, {
      'lightness': 54
    }]
  }, {
    'featureType': 'landscape.man_made',
    'elementType': 'geometry.fill',
    'stylers': [{
      'color': '#ece2d9'
    }]
  }, {
    'featureType': 'poi.park',
    'elementType': 'geometry.fill',
    'stylers': [{
      'color': '#ccdca1'
    }]
  }, {
    'featureType': 'road',
    'elementType': 'labels.text.fill',
    'stylers': [{
      'color': '#767676'
    }]
  }, {
    'featureType': 'road',
    'elementType': 'labels.text.stroke',
    'stylers': [{
      'color': '#ffffff'
    }]
  }, {
    'featureType': 'poi',
    'stylers': [{
      'visibility': 'off'
    }]
  }, {
    'featureType': 'landscape.natural',
    'elementType': 'geometry.fill',
    'stylers': [{
      'visibility': 'on'
    }, {
      'color': '#b8cb93'
    }]
  }, {
    'featureType': 'poi.park',
    'stylers': [{
      'visibility': 'on'
    }]
  }, {
    'featureType': 'poi.sports_complex',
    'stylers': [{
      'visibility': 'on'
    }]
  }, {
    'featureType': 'poi.medical',
    'stylers': [{
      'visibility': 'on'
    }]
  }, {
    'featureType': 'poi.business',
    'stylers': [{
      'visibility': 'simplified'
    }]
  }];

  var mapMapBox = new GMaps({
    el: '#mapMapBox',
    zoom: 14,
    lat: 40.702247,
    lng: -73.996349
  });


  // Map style is based on:
  // https://snazzymaps.com/style/4183/mostly-grayscale
  mapMapBox.addStyle({
    styledMapName:'MapBox',
    styles: styleMapBox,
    mapTypeId: 'map_mapbox'
  });

  mapMapBox.setStyle('map_mapbox');

});

$(function() {

  'use strict';

  var styleBlueWater = [{
    'featureType': 'administrative',
    'elementType': 'labels.text.fill',
    'stylers': [{
      'color': '#444444'
    }]
  }, {
    'featureType': 'landscape',
    'elementType': 'all',
    'stylers': [{
      'color': '#f2f2f2'
    }]
  }, {
    'featureType': 'poi',
    'elementType': 'all',
    'stylers': [{
      'visibility': 'off'
    }]
  }, {
    'featureType': 'road',
    'elementType': 'all',
    'stylers': [{
      'saturation': -100
    }, {
      'lightness': 45
    }]
  }, {
    'featureType': 'road.highway',
    'elementType': 'all',
    'stylers': [{
      'visibility': 'simplified'
    }]
  }, {
    'featureType': 'road.arterial',
    'elementType': 'labels.icon',
    'stylers': [{
      'visibility': 'off'
    }]
  }, {
    'featureType': 'transit',
    'elementType': 'all',
    'stylers': [{
      'visibility': 'off'
    }]
  }, {
    'featureType': 'water',
    'elementType': 'all',
    'stylers': [{
      'color': '#0866C6'
    }, {
      'visibility': 'on'
    }]
  }];

  var mapBlueWater = new GMaps({
    el: '#mapBlueWater',
    zoom: 14,
    lat: 40.702247,
    lng: -73.996349
  });


  // Map style is based on:
  // https://snazzymaps.com/style/4183/mostly-grayscale
  mapBlueWater.addStyle({
    styledMapName:'Blue Water Map',
    styles: styleBlueWater,
    mapTypeId: 'map_blue_water'
  });

  mapBlueWater.setStyle('map_blue_water');

});

$(function() {

  'use strict';

  var styleApple = [{
    'featureType': 'landscape.man_made',
    'elementType': 'geometry',
    'stylers': [{
      'color': '#f7f1df'
    }]
  }, {
    'featureType': 'landscape.natural',
    'elementType': 'geometry',
    'stylers': [{
      'color': '#d0e3b4'
    }]
  }, {
    'featureType': 'landscape.natural.terrain',
    'elementType': 'geometry',
    'stylers': [{
      'visibility': 'off'
    }]
  }, {
    'featureType': 'poi',
    'elementType': 'labels',
    'stylers': [{
      'visibility': 'off'
    }]
  }, {
    'featureType': 'poi.business',
    'elementType': 'all',
    'stylers': [{
      'visibility': 'off'
    }]
  }, {
    'featureType': 'poi.medical',
    'elementType': 'geometry',
    'stylers': [{
      'color': '#fbd3da'
    }]
  }, {
    'featureType': 'poi.park',
    'elementType': 'geometry',
    'stylers': [{
      'color': '#bde6ab'
    }]
  }, {
    'featureType': 'road',
    'elementType': 'geometry.stroke',
    'stylers': [{
      'visibility': 'off'
    }]
  }, {
    'featureType': 'road',
    'elementType': 'labels',
    'stylers': [{
      'visibility': 'off'
    }]
  }, {
    'featureType': 'road.highway',
    'elementType': 'geometry.fill',
    'stylers': [{
      'color': '#ffe15f'
    }]
  }, {
    'featureType': 'road.highway',
    'elementType': 'geometry.stroke',
    'stylers': [{
      'color': '#efd151'
    }]
  }, {
    'featureType': 'road.arterial',
    'elementType': 'geometry.fill',
    'stylers': [{
      'color': '#ffffff'
    }]
  }, {
    'featureType': 'road.local',
    'elementType': 'geometry.fill',
    'stylers': [{
      'color': 'black'
    }]
  }, {
    'featureType': 'transit.station.airport',
    'elementType': 'geometry.fill',
    'stylers': [{
      'color': '#cfb2db'
    }]
  }, {
    'featureType': 'water',
    'elementType': 'geometry',
    'stylers': [{
      'color': '#a2daf2'
    }]
  }];

  var mapApple = new GMaps({
    el: '#mapApple',
    zoom: 14,
    lat: 40.702247,
    lng: -73.996349
  });


  // Map style is based on:
  // https://snazzymaps.com/style/4183/mostly-grayscale
  mapApple.addStyle({
    styledMapName:'Shades Of Grey Map',
    styles: styleApple,
    mapTypeId: 'map_apple'
  });

  mapApple.setStyle('map_apple');

});

var sample_data = {"af":"16.63","al":"11.58","dz":"158.97","ao":"85.81","ag":"1.1","ar":"351.02","am":"8.83","au":"1219.72","at":"366.26","az":"52.17","bs":"7.54","bh":"21.73","bd":"105.4","bb":"3.96","by":"52.89","be":"461.33","bz":"1.43","bj":"6.49","bt":"1.4","bo":"19.18","ba":"16.2","bw":"12.5","br":"2023.53","bn":"11.96","bg":"44.84","bf":"8.67","bi":"1.47","kh":"11.36","cm":"21.88","ca":"1563.66","cv":"1.57","cf":"2.11","td":"7.59","cl":"199.18","cn":"5745.13","co":"283.11","km":"0.56","cd":"12.6","cg":"11.88","cr":"35.02","ci":"22.38","hr":"59.92","cy":"22.75","cz":"195.23","dk":"304.56","dj":"1.14","dm":"0.38","do":"50.87","ec":"61.49","eg":"216.83","sv":"21.8","gq":"14.55","er":"2.25","ee":"19.22","et":"30.94","fj":"3.15","fi":"231.98","fr":"2555.44","ga":"12.56","gm":"1.04","ge":"11.23","de":"3305.9","gh":"18.06","gr":"305.01","gd":"0.65","gt":"40.77","gn":"4.34","gw":"0.83","gy":"2.2","ht":"6.5","hn":"15.34","hk":"226.49","hu":"132.28","is":"12.77","in":"1430.02","id":"695.06","ir":"337.9","iq":"84.14","ie":"204.14","il":"201.25","it":"2036.69","jm":"13.74","jp":"5390.9","jo":"27.13","kz":"129.76","ke":"32.42","ki":"0.15","kr":"986.26","undefined":"5.73","kw":"117.32","kg":"4.44","la":"6.34","lv":"23.39","lb":"39.15","ls":"1.8","lr":"0.98","ly":"77.91","lt":"35.73","lu":"52.43","mk":"9.58","mg":"8.33","mw":"5.04","my":"218.95","mv":"1.43","ml":"9.08","mt":"7.8","mr":"3.49","mu":"9.43","mx":"1004.04","md":"5.36","mn":"5.81","me":"3.88","ma":"91.7","mz":"10.21","mm":"35.65","na":"11.45","np":"15.11","nl":"770.31","nz":"138","ni":"6.38","ne":"5.6","ng":"206.66","no":"413.51","om":"53.78","pk":"174.79","pa":"27.2","pg":"8.81","py":"17.17","pe":"153.55","ph":"189.06","pl":"438.88","pt":"223.7","qa":"126.52","ro":"158.39","ru":"1476.91","rw":"5.69","ws":"0.55","st":"0.19","sa":"434.44","sn":"12.66","rs":"38.92","sc":"0.92","sl":"1.9","sg":"217.38","sk":"86.26","si":"46.44","sb":"0.67","za":"354.41","es":"1374.78","lk":"48.24","kn":"0.56","lc":"1","vc":"0.58","sd":"65.93","sr":"3.3","sz":"3.17","se":"444.59","ch":"522.44","sy":"59.63","tw":"426.98","tj":"5.58","tz":"22.43","th":"312.61","tl":"0.62","tg":"3.07","to":"0.3","tt":"21.2","tn":"43.86","tr":"729.05","tm":0,"ug":"17.12","ua":"136.56","ae":"239.65","gb":"2258.57","us":"14624.18","uy":"40.71","uz":"37.72","vu":"0.72","ve":"285.21","vn":"101.99","ye":"30.02","zm":"15.69","zw":"5.57"};
$(function(){
  'use strict'

  var ch1 = new Chartist.Line('#ch1', {
    labels: [1, 2, 3, 4, 5, 6, 7, 8],
    series: [
      [5, 9, 7, 8, 5, 3, 5, 4],
      [10, 15, 10, 17, 8, 11, 16, 10]
    ]
  }, {
    high: 30,
    low: 0,
    axisY: {
      onlyInteger: true
    },
    showArea: true,
    fullWidth: true,
    chartPadding: {
      bottom: 0,
      left: 0
    }
  });

  // resize chart when container changest it's width
  new ResizeSensor($('.br-mainpanel'), function(){
    ch1.update();
    ch1.update();
  });

  $('#sparkline1').sparkline('html', {
    width: 100,
    height: 30,
    lineColor: '#0083CD',
    fillColor: 'rgba(0,131,205,0.2)',
  });

  $('#sparkline2').sparkline('html', {
    width: 100,
    height: 30,
    lineColor: '#1CAF9A',
    fillColor: 'rgba(28,175,154,0.2)',
  });

  $('#sparkline3').sparkline('html', {
    width: 100,
    height: 30,
    lineColor: '#F49917',
    fillColor: 'rgba(244,153,23,0.2)',
  });

  $('#sparkline4').sparkline('html', {
    width: 100,
    height: 30,
    lineColor: '#ED2475',
    fillColor: 'rgba(237,36,117,0.2)',
  });

  $('#sparkline5').sparkline('html', {
    width: 100,
    height: 30,
    lineColor: '#1CAF9A',
    fillColor: 'rgba(28,175,154,0.2)',
  });


  $('#sparkline6').sparkline('html', {
    type: 'bar',
    barWidth: 5,
    chartRangeMin: 0,
    chartRangeMax: 10,
    width: 100,
    height: 40,
    barColor: '#5E37A6'
  });

  $('#sparkline7').sparkline('html', {
    type: 'bar',
    barWidth: 5,
    chartRangeMin: 0,
    chartRangeMax: 10,
    width: 100,
    height: 40,
    barColor: '#17A2B8'
  });

  var line1 = new Rickshaw.Graph({
    element: document.querySelector('#chartLine1'),
    renderer: 'area',
    max: 80,
    series: [{
      data: [
        { x: 0, y: 30 },
        { x: 1, y: 35 },
        { x: 2, y: 30 },
        { x: 3, y: 20 },
        { x: 4, y: 32 },
        { x: 5, y: 40 },
        { x: 6, y: 25 },
        { x: 7, y: 20 },
        { x: 8, y: 25 },
        { x: 9, y: 35 },
        { x: 10, y: 20 },
        { x: 11, y: 30 },
        { x: 12, y: 35 },
        { x: 13, y: 40 }
      ],
      color: '#1061b4' //'rgba(255,255,255,0.2)'
    },{
      data: [
        { x: 0, y: 20 },
        { x: 1, y: 29 },
        { x: 2, y: 28 },
        { x: 3, y: 20 },
        { x: 4, y: 22 },
        { x: 5, y: 5 },
        { x: 6, y: 10 },
        { x: 7, y: 15 },
        { x: 8, y: 20 },
        { x: 9, y: 15 },
        { x: 10, y: 25 },
        { x: 11, y: 10 },
        { x: 12, y: 20 },
        { x: 13, y: 15 }
      ],
      color: 'rgba(255,255,255,0.4)'
    }]
  });
  line1.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    line1.configure({
      width: $('#chartLine1').width(),
      height: $('#chartLine1').height()
    });
    line1.render();
  });

  // peity charts
  $('.peity-line').peity('line');
  $('.peity-donut').peity('donut');

});

$(function(){
  'use strict'

  /***************** LINE CHARTS *****************/
  $('#sparkline1').sparkline('html', {
    width: 200,
    height: 70,
    lineColor: '#0083CD',
    fillColor: false
  });

  $('#sparkline2').sparkline('html', {
    width: 200,
    height: 70,
    lineColor: '#B654C3',
    fillColor: false
  });


  /************** AREA CHARTS ********************/

  $('#sparkline3').sparkline('html', {
    width: 200,
    height: 70,
    lineColor: '#0083CD',
    fillColor: 'rgba(0,131,205,0.2)',
  });

  $('#sparkline4').sparkline('html', {
    width: 200,
    height: 70,
    lineColor: '#B654C3',
    fillColor: 'rgba(182,84,195,0.2)'
  });


  /******************* BAR CHARTS *****************/

  $('#sparkline5').sparkline('html', {
    type: 'bar',
    barWidth: 10,
    height: 70,
    barColor: '#0083CD',
    chartRangeMax: 12
  });

  $('#sparkline6').sparkline('html', {
    type: 'bar',
    barWidth: 10,
    height: 70,
    barColor: '#B654C3',
    chartRangeMax: 12
  });

  /***************** STACKED BAR CHARTS ****************/

  $('#sparkline7').sparkline('html', {
    type: 'bar',
    barWidth: 10,
    height: 70,
    barColor: '#0083CD',
    chartRangeMax: 12
  });

  $('#sparkline7').sparkline([4,5,6,7,4,5,8,7,6,6,4,7,6,4,7], {
    composite: true,
    type: 'bar',
    barWidth: 10,
    height: 70,
    barColor: '#11546F',
    chartRangeMax: 12
  });

  $('#sparkline8').sparkline('html', {
    type: 'bar',
    barWidth: 10,
    height: 70,
    barColor: '#E97B9E',
    chartRangeMax: 12
  });

  $('#sparkline8').sparkline([4,5,6,7,4,5,8,7,6,6,4,7,6,4,7], {
    composite: true,
    type: 'bar',
    barWidth: 10,
    height: 70,
    barColor: '#92288D',
    chartRangeMax: 12
  });


  /**************** PIE CHART ****************/

  $('#sparkline9').sparkline('html', {
    type: 'pie',
    height: 70,
    sliceColors: ['#F4C62B', '#F6931E', '#8CC63E']
  });

  $('#sparkline10').sparkline('html', {
    type: 'pie',
    height: 70,
    sliceColors: ['#F4C62B', '#F6931E', '#8CC63E', '#93268F', '#EB1E79', '#828BC4', '#E97A9B', '#0083CD']
  });

});

$(function(){
  'use strict'


  var bar1 = new Rickshaw.Graph({
    element: document.querySelector('#chartBar1'),
    renderer: 'bar',
    max: 80,
    series: [{
      data: [
        { x: 0, y: 40 },
        { x: 1, y: 49 },
        { x: 2, y: 38 },
        { x: 3, y: 30 },
        { x: 4, y: 32 },
        { x: 5, y: 40 },
        { x: 6, y: 20 },
        { x: 7, y: 10 },
        { x: 8, y: 20 },
        { x: 9, y: 25 },
        { x: 10, y: 35 },
        { x: 11, y: 20 },
        { x: 12, y: 40 },
        { x: 13, y: 25 }
      ],
      color: '#26A2E2'
    }]
  });
  bar1.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    bar1.configure({
      width: $('#chartBar1').width(),
      height: $('#chartBar1').height()
    });
    bar1.render();
  });


  /*********************** BAR 2 *********************/

  var bar2 = new Rickshaw.Graph({
    element: document.querySelector('#chartBar2'),
    renderer: 'bar',
    max: 80,
    series: [{
      data: [
        { x: 0, y: 40 },
        { x: 1, y: 49 },
        { x: 2, y: 38 },
        { x: 3, y: 30 },
        { x: 4, y: 32 },
        { x: 5, y: 40 },
        { x: 6, y: 20 },
        { x: 7, y: 10 },
        { x: 8, y: 20 },
        { x: 9, y: 25 },
        { x: 10, y: 35 },
        { x: 11, y: 20 },
        { x: 12, y: 40 },
        { x: 13, y: 25 }
      ],
      color: '#8CC343'
    }]
  });

  bar2.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    bar2.configure({
      width: $('#chartBar2').width(),
      height: $('#chartBar2').height()
    });
    bar2.render();
  });


  /************* STACKED BAR1 *************/

  var stacked1 = new Rickshaw.Graph({
    element: document.querySelector('#chartStackedBar1'),
    renderer: 'bar',
    max: 100,
    series: [{
      data: [
        { x: 0, y: 20 },
        { x: 1, y: 30 },
        { x: 2, y: 10 },
        { x: 3, y: 15 },
        { x: 4, y: 10 },
        { x: 5, y: 20 },
        { x: 6, y: 15 },
        { x: 7, y: 20 },
        { x: 8, y: 25 },
        { x: 9, y: 20 },
        { x: 10, y: 25 },
        { x: 11, y: 10 },
        { x: 12, y: 15 },
        { x: 13, y: 10 }
      ],
      color: '#466C79'
    },
    {
      data: [
        { x: 0, y: 10 },
        { x: 1, y: 10 },
        { x: 2, y: 15 },
        { x: 3, y: 20 },
        { x: 4, y: 12 },
        { x: 5, y: 20 },
        { x: 6, y: 10 },
        { x: 7, y: 15 },
        { x: 8, y: 20 },
        { x: 9, y: 25 },
        { x: 10, y: 15 },
        { x: 11, y: 10 },
        { x: 12, y: 20 },
        { x: 13, y: 25 }
      ],
      color: '#26A2E2'
    },
    {
      data: [
        { x: 0, y: 10 },
        { x: 1, y: 15 },
        { x: 2, y: 15 },
        { x: 3, y: 20 },
        { x: 4, y: 32 },
        { x: 5, y: 30 },
        { x: 6, y: 20 },
        { x: 7, y: 10 },
        { x: 8, y: 20 },
        { x: 9, y: 25 },
        { x: 10, y: 35 },
        { x: 11, y: 20 },
        { x: 12, y: 20 },
        { x: 13, y: 25 }
      ],
      color: '#8CC343'
    }]
  });
  stacked1.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    stacked1.configure({
      width: $('#chartStackedBar1').width(),
      height: $('#chartStackedBar1').height()
    });
    stacked1.render();
  });


  /*************** STACKED 2 **********************/
  var stacked2 = new Rickshaw.Graph({
    element: document.querySelector('#chartStackedBar2'),
    renderer: 'bar',
    max: 100,
    series: [{
      data: [
        { x: 0, y: 20 },
        { x: 1, y: 30 },
        { x: 2, y: 10 },
        { x: 3, y: 15 },
        { x: 4, y: 10 },
        { x: 5, y: 20 },
        { x: 6, y: 15 },
        { x: 7, y: 20 },
        { x: 8, y: 25 },
        { x: 9, y: 20 },
        { x: 10, y: 25 },
        { x: 11, y: 10 },
        { x: 12, y: 15 },
        { x: 13, y: 10 }
      ],
      color: '#065381'
    },
    {
      data: [
        { x: 0, y: 10 },
        { x: 1, y: 10 },
        { x: 2, y: 15 },
        { x: 3, y: 20 },
        { x: 4, y: 12 },
        { x: 5, y: 20 },
        { x: 6, y: 10 },
        { x: 7, y: 15 },
        { x: 8, y: 20 },
        { x: 9, y: 25 },
        { x: 10, y: 15 },
        { x: 11, y: 10 },
        { x: 12, y: 20 },
        { x: 13, y: 25 }
      ],
      color: '#8B103E'
    },
    {
      data: [
        { x: 0, y: 10 },
        { x: 1, y: 15 },
        { x: 2, y: 15 },
        { x: 3, y: 20 },
        { x: 4, y: 32 },
        { x: 5, y: 30 },
        { x: 6, y: 20 },
        { x: 7, y: 10 },
        { x: 8, y: 20 },
        { x: 9, y: 25 },
        { x: 10, y: 35 },
        { x: 11, y: 20 },
        { x: 12, y: 20 },
        { x: 13, y: 25 }
      ],
      color: '#E34856'
    }]
  });
  stacked2.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    stacked2.configure({
      width: $('#chartStackedBar2').width(),
      height: $('#chartStackedBar2').height()
    });
    stacked2.render();
  });


  /***************** MULTIPLE BOX ********************/

  var multibar = new Rickshaw.Graph({
    element: document.querySelector('#chartMultiBar1'),
    renderer: 'bar',
    stack: false,
    max: 60,
    series: [{
      data: [
        { x: 0, y: 20 },
        { x: 1, y: 25 },
        { x: 2, y: 10 },
        { x: 3, y: 15 },
        { x: 4, y: 20 },
        { x: 5, y: 40 },
        { x: 6, y: 15 },
        { x: 7, y: 40 },
        { x: 8, y: 25 }
      ],
      color: '#065381'
    },
    {
      data: [
        { x: 0, y: 10 },
        { x: 1, y: 30 },
        { x: 2, y: 45 },
        { x: 3, y: 30 },
        { x: 4, y: 42 },
        { x: 5, y: 20 },
        { x: 6, y: 30 },
        { x: 7, y: 15 },
        { x: 8, y: 20 }
      ],
      color: '#34B2E4'
    }]
  });

  multibar.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    multibar.configure({
      width: $('#chartMultiBar1').width(),
      height: $('#chartMultiBar1').height()
    });
    multibar.render();
  });


  /**************** MULTI BAR 2 ***************/

  var multibar2 = new Rickshaw.Graph({
    element: document.querySelector('#chartMultiBar2'),
    renderer: 'bar',
    stack: false,
    max: 60,
    series: [{
      data: [
        { x: 0, y: 20 },
        { x: 1, y: 25 },
        { x: 2, y: 10 },
        { x: 3, y: 15 },
        { x: 4, y: 20 },
        { x: 5, y: 40 },
        { x: 6, y: 15 },
        { x: 7, y: 40 },
        { x: 8, y: 25 }
      ],
      color: '#0282C9'
    },
    {
      data: [
        { x: 0, y: 10 },
        { x: 1, y: 30 },
        { x: 2, y: 45 },
        { x: 3, y: 30 },
        { x: 4, y: 42 },
        { x: 5, y: 20 },
        { x: 6, y: 30 },
        { x: 7, y: 15 },
        { x: 8, y: 20 }
      ],
      color: '#E97C9C'
    },
    {
      data: [
        { x: 0, y: 20 },
        { x: 1, y: 50 },
        { x: 2, y: 25 },
        { x: 3, y: 10 },
        { x: 4, y: 22 },
        { x: 5, y: 40 },
        { x: 6, y: 10 },
        { x: 7, y: 25 },
        { x: 8, y: 40 }
      ],
      color: '#818AC3'
    }]
  });
  multibar2.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    multibar2.configure({
      width: $('#chartMultiBar2').width(),
      height: $('#chartMultiBar2').height()
    });
    multibar2.render();
  });


  /*************** LINE BAR 1 *****************/

  var line1 = new Rickshaw.Graph({
    element: document.querySelector('#chartLine1'),
    renderer: 'line',
    max: 80,
    series: [{
      data: [
        { x: 0, y: 40 },
        { x: 1, y: 49 },
        { x: 2, y: 38 },
        { x: 3, y: 30 },
        { x: 4, y: 32 },
        { x: 5, y: 40 },
        { x: 6, y: 20 },
        { x: 7, y: 10 },
        { x: 8, y: 20 },
        { x: 9, y: 25 },
        { x: 10, y: 35 },
        { x: 11, y: 20 },
        { x: 12, y: 40 },
        { x: 13, y: 25 }
      ],
      color: '#26A2E2'
    }]
  });
  line1.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    line1.configure({
      width: $('#chartLine1').width(),
      height: $('#chartLine1').height()
    });
    line1.render();
  });


  /***************** LINE CHART 2 **********************/

  var line2 = new Rickshaw.Graph({
    element: document.querySelector('#chartLine2'),
    renderer: 'line',
    stack: false,
    max: 60,
    series: [{
      data: [
        { x: 0, y: 20 },
        { x: 1, y: 25 },
        { x: 2, y: 10 },
        { x: 3, y: 15 },
        { x: 4, y: 20 },
        { x: 5, y: 40 },
        { x: 6, y: 15 },
        { x: 7, y: 40 },
        { x: 8, y: 25 }
      ],
      color: '#0282C9'
    },
    {
      data: [
        { x: 0, y: 10 },
        { x: 1, y: 30 },
        { x: 2, y: 45 },
        { x: 3, y: 30 },
        { x: 4, y: 42 },
        { x: 5, y: 20 },
        { x: 6, y: 30 },
        { x: 7, y: 15 },
        { x: 8, y: 20 }
      ],
      color: '#E97C9C'
    }]
  });
  line2.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    line2.configure({
      width: $('#chartLine2').width(),
      height: $('#chartLine2').height()
    });
    line2.render();
  });


  /******************** AREA CHART 1 ******************/

  var area1 = new Rickshaw.Graph({
    element: document.querySelector('#chartArea1'),
    renderer: 'area',
    max: 80,
    series: [{
      data: [
        { x: 0, y: 40 },
        { x: 1, y: 49 },
        { x: 2, y: 38 },
        { x: 3, y: 30 },
        { x: 4, y: 32 },
        { x: 5, y: 40 },
        { x: 6, y: 20 },
        { x: 7, y: 10 },
        { x: 8, y: 20 },
        { x: 9, y: 25 },
        { x: 10, y: 35 },
        { x: 11, y: 20 },
        { x: 12, y: 40 },
        { x: 13, y: 25 }
      ],
      color: '#26A2E2'
    }]
  });
  area1.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    area1.configure({
      width: $('#chartArea1').width(),
      height: $('#chartArea1').height()
    });
    area1.render();
  });


  /****************** AREA CHART 2 ******************/
  var area2 = new Rickshaw.Graph({
    element: document.querySelector('#chartArea2'),
    renderer: 'area',
    stack: false,
    max: 80,
    series: [{
      data: [
        { x: 0, y: 45 },
        { x: 1, y: 60 },
        { x: 2, y: 55 },
        { x: 3, y: 40 },
        { x: 4, y: 52 },
        { x: 5, y: 45 },
        { x: 6, y: 35 },
        { x: 7, y: 25 },
        { x: 8, y: 30 },
        { x: 9, y: 45 },
        { x: 10, y: 40 },
        { x: 11, y: 30 },
        { x: 12, y: 45 },
        { x: 13, y: 35 }
      ],
      color: '#0282C9'
    },
    {
      data: [
        { x: 0, y: 40 },
        { x: 1, y: 49 },
        { x: 2, y: 38 },
        { x: 3, y: 30 },
        { x: 4, y: 32 },
        { x: 5, y: 40 },
        { x: 6, y: 20 },
        { x: 7, y: 10 },
        { x: 8, y: 20 },
        { x: 9, y: 25 },
        { x: 10, y: 35 },
        { x: 11, y: 20 },
        { x: 12, y: 40 },
        { x: 13, y: 25 }
      ],
      color: '#E97C9C'
    }]
  });
  area2.render();

  // Responsive Mode
  new ResizeSensor($('.br-mainpanel'), function(){
    area2.configure({
      width: $('#chartArea2').width(),
      height: $('#chartArea2').height()
    });
    area2.render();
  });


});

$(function(){
  'use strict'

  // Line chart
  $('.peity-line').peity('line');

  // Pie chart
  $('.peity-pie').peity('pie');

  // Donut chart
  $('.peity-donut').peity('donut');

  // Bar chart is already initialized found in bracket.js
});

$(function(){
  'use strict';

  new Morris.Bar({
    element: 'morrisBar1',
    data: [
      { y: '2006', a: 100, b: 90 },
      { y: '2007', a: 75,  b: 65 },
      { y: '2008', a: 50,  b: 40 },
      { y: '2009', a: 75,  b: 65 },
      { y: '2010', a: 50,  b: 40 },
    ],
    xkey: 'y',
    ykeys: ['a', 'b'],
    labels: ['Series A', 'Series B'],
    barColors: ['#5058AB', '#14A0C1'],
    gridTextSize: 11,
    hideHover: 'auto',
    resize: true
  });

  new Morris.Bar({
    element: 'morrisBar2',
    data: [
      { y: '2006', a: 100, b: 90 },
      { y: '2007', a: 75,  b: 65 },
      { y: '2008', a: 50,  b: 40 },
      { y: '2009', a: 75,  b: 65 },
      { y: '2010', a: 50,  b: 40 },
    ],
    xkey: 'y',
    ykeys: ['a', 'b'],
    labels: ['Series A', 'Series B'],
    barColors: ['#5058AB', '#14A0C1'],
    stacked: true,
    gridTextSize: 11,
    hideHover: 'auto',
    resize: true
  });

  new Morris.Bar({
    element: 'morrisBar3',
    data: [
      { y: '2006', a: 100, b: 90, c: 80 },
      { y: '2007', a: 75,  b: 65, c: 75 },
      { y: '2008', a: 50,  b: 40, c: 45 },
      { y: '2009', a: 75,  b: 65, c: 85 },
    ],
    xkey: 'y',
    ykeys: ['a', 'b', 'c'],
    labels: ['Series A', 'Series B', 'Series C'],
    barColors: ['#5058AB', '#14A0C1','#01CB99'],
    gridTextSize: 11,
    hideHover: 'auto',
    resize: true
  });

  new Morris.Bar({
    element: 'morrisBar4',
    data: [
      { y: '2006', a: 100, b: 90, c: 80 },
      { y: '2007', a: 75,  b: 65, c: 75 },
      { y: '2008', a: 50,  b: 40, c: 45 },
      { y: '2009', a: 75,  b: 65, c: 85 },
      { y: '2009', a: 65,  b: 60, c: 60 },
    ],
    xkey: 'y',
    ykeys: ['a', 'b', 'c'],
    labels: ['Series A', 'Series B', 'Series C'],
    barColors: ['#5058AB', '#14A0C1','#01CB99'],
    stacked: true,
    gridTextSize: 11,
    hideHover: 'auto',
    resize: true
  });


  new Morris.Line({
    element: 'morrisLine1',
    data: [
      { y: '2006', a: 20, b: 10 },
      { y: '2007', a: 30,  b: 15 },
      { y: '2008', a: 60,  b: 40 },
      { y: '2009', a: 40,  b: 25 },
      { y: '2010', a: 30,  b: 15 },
      { y: '2011', a: 45,  b: 20 },
      { y: '2012', a: 60, b: 40 }
    ],
    xkey: 'y',
    ykeys: ['a', 'b'],
    labels: ['Series A', 'Series B'],
    lineColors: ['#14A0C1', '#5058AB'],
    lineWidth: 1,
    ymax: 'auto 100',
    gridTextSize: 11,
    hideHover: 'auto',
    smooth: false,
    resize: true
  });

  new Morris.Line({
    element: 'morrisLine2',
    data: [
      { y: '2006', a: 20, b: 10, c: 40 },
      { y: '2007', a: 30, b: 15, c: 45 },
      { y: '2008', a: 50, b: 40, c: 65 },
      { y: '2009', a: 40, b: 25, c: 55 },
      { y: '2010', a: 30, b: 15, c: 45 },
      { y: '2011', a: 45, b: 20, c: 65 },
      { y: '2012', a: 60, b: 40, c: 70 }
    ],
    xkey: 'y',
    ykeys: ['a', 'b', 'c'],
    labels: ['Series A', 'Series B', 'Series C'],
    lineColors: ['#14A0C1', '#5058AB', '#72DF00'],
    lineWidth: 1,
    ymax: 'auto 100',
    gridTextSize: 11,
    hideHover: 'auto',
    resize: true
  });

  new Morris.Area({
    element: 'morrisArea1',
    data: [
      { y: '2006', a: 50, b: 40 },
      { y: '2007', a: 25,  b: 15 },
      { y: '2008', a: 20,  b: 40 },
      { y: '2009', a: 75,  b: 65 },
      { y: '2010', a: 50,  b: 40 },
      { y: '2011', a: 75,  b: 65 },
      { y: '2012', a: 100, b: 90 }
    ],
    xkey: 'y',
    ykeys: ['a', 'b'],
    labels: ['Series A', 'Series B'],
    lineColors: ['#14A0C1', '#5058AB'],
    lineWidth: 1,
    fillOpacity: 0.5,
    gridTextSize: 11,
    hideHover: 'auto',
    resize: true
  });

  new Morris.Area({
    element: 'morrisArea2',
    data: [
      { y: '2006', a: 20, b: 10, c: 40 },
      { y: '2007', a: 30, b: 15, c: 45 },
      { y: '2008', a: 50, b: 40, c: 65 },
      { y: '2009', a: 40, b: 25, c: 55 },
      { y: '2010', a: 30, b: 15, c: 45 },
      { y: '2011', a: 45, b: 20, c: 65 },
      { y: '2012', a: 60, b: 40, c: 70 }
    ],
    xkey: 'y',
    ykeys: ['a', 'b', 'c'],
    labels: ['Series A', 'Series B', 'Series C'],
    lineColors: ['#14A0C1', '#5058AB', '#72DF00'],
    lineWidth: 1,
    fillOpacity: 0.5,
    gridTextSize: 11,
    hideHover: 'auto',
    resize: true
  });

  new Morris.Donut({
    element: 'morrisDonut1',
    data: [
      {label: "Men", value: 12},
      {label: "Women", value: 30},
      {label: "Kids", value: 20}
    ],
    colors: ['#3D449C','#268FB2','#74DE00'],
    resize: true
  });

  new Morris.Donut({
    element: 'morrisDonut2',
    data: [
      {label: "Men", value: 12},
      {label: "Women", value: 30},
      {label: "Kids", value: 20},
      {label: "Infant", value: 25}
    ],
    colors: ['#3D449C','#268FB2','#2DC486','#74DE00'],
    resize: true
  });

});

$(function() {
  'use strict';

  $.plot("#flotBar1", [{
    data: [[0, 3], [2, 8], [4, 5], [6, 13],[8,5], [10,7],[12,4], [14,6]]
  }], {
    series: {
      bars: {
        show: true,
        lineWidth: 0,
        fillColor: '#4E6577'
      }
    },
    grid: {
      borderWidth: 1,
      borderColor: '#D9D9D9'
    },
    yaxis: {
      tickColor: '#d9d9d9',
      font: {
        color: '#666',
        size: 10
      }
    },
    xaxis: {
      tickColor: '#d9d9d9',
      font: {
        color: '#666',
        size: 10
      }
    }
  });

  $.plot("#flotBar2", [{
    data: [[0, 3], [2, 8], [4, 5], [6, 13],[8,5], [10,7],[12,8], [14,10]],
    bars: {
      show: true,
      lineWidth: 0,
      fillColor: '#4E6577'
    }
  },{
    data: [[1, 5], [3, 7], [5, 10], [7, 7],[9,9], [11,5],[13,4], [15,6]],
    bars: {
      show: true,
      lineWidth: 0,
      fillColor: '#BD9DC7'
    }
  }], {
    grid: {
      borderWidth: 1,
      borderColor: '#D9D9D9'
    },
    yaxis: {
      tickColor: '#d9d9d9',
      font: {
        color: '#666',
        size: 10
      }
    },
    xaxis: {
      tickColor: '#d9d9d9',
      font: {
        color: '#666',
        size: 10
      }
    }
  });

  var newCust = [[0, 2], [1, 3], [2,6], [3, 5], [4, 7], [5, 8], [6, 10]];
  var retCust = [[0, 1], [1, 2], [2,5], [3, 3], [4, 5], [5, 6], [6,9]];

  var plot = $.plot($('#flotLine1'),[
    {
      data: newCust,
      label: 'New Customer',
      color: '#BD9DC7'
    },
    {
      data: retCust,
      label: 'Returning Customer',
      color: '#4E6577'
    }],
    {
      series: {
        lines: {
          show: true,
          lineWidth: 1
        },
        shadowSize: 0
      },
      points: {
        show: false,
      },
      legend: {
        noColumns: 1,
        position: 'nw'
      },
      grid: {
        hoverable: true,
        clickable: true,
        borderColor: '#ddd',
        borderWidth: 0,
        labelMargin: 5,
        backgroundColor: '#fff'
      },
      yaxis: {
        min: 0,
        max: 15,
        color: '#eee',
        font: {
          size: 10,
          color: '#999'
        }
      },
      xaxis: {
        color: '#eee',
        font: {
          size: 10,
          color: '#999'
        }
      }
    });

    var plot = $.plot($('#flotLine2'),[
      {
        data: newCust,
        label: 'New Customer',
        color: '#BD9DC7'
      },
      {
        data: retCust,
        label: 'Returning Customer',
        color: '#4E6577'
      }],
      {
        series: {
          lines: {
            show: false
          },
          splines: {
            show: true,
            tension: 0.4,
            lineWidth: 1,
            //fill: 0.4
          },
          shadowSize: 0
        },
        points: {
          show: false,
        },
        legend: {
          noColumns: 1,
          position: 'nw'
        },
        grid: {
          hoverable: true,
          clickable: true,
          borderColor: '#ddd',
          borderWidth: 0,
          labelMargin: 5,
          backgroundColor: '#fff'
        },
        yaxis: {
          min: 0,
          max: 15,
          color: '#eee',
          font: {
            size: 10,
            color: '#999'
          }
        },
        xaxis: {
          color: '#eee',
          font: {
            size: 10,
            color: '#999'
          }
        }
      });

      var newCust2 = [[0, 10], [1, 7], [2, 8], [3, 9], [4, 6], [5, 5], [6, 7]];
      var retCust2 = [[0, 8], [1, 5], [2, 6], [3, 8], [4, 4], [5, 3], [6,6]];

      var plot = $.plot($('#flotLine3'),[
        {
          data: newCust2,
          label: 'New Customer',
          color: '#F37AAD'
        },
        {
          data: retCust2,
          label: 'Returning Customer',
          color: '#6AC3C9'
        }],
        {
          series: {
            lines: {
              show: true,
              lineWidth: 1
            },
            shadowSize: 0
          },
          points: {
            show: true,
          },
          legend: {
            noColumns: 1,
            position: 'nw'
          },
          grid: {
            hoverable: true,
            clickable: true,
            borderColor: '#ddd',
            borderWidth: 0,
            labelMargin: 5,
            backgroundColor: '#fff'
          },
          yaxis: {
            min: 0,
            max: 15,
            color: '#eee',
            font: {
              size: 10,
              color: '#999'
            }
          },
          xaxis: {
            color: '#eee',
            font: {
              size: 10,
              color: '#999'
            }
          }
        });

        var plot = $.plot($('#flotLine4'),[
          {
            data: newCust2,
            label: 'New Customer',
            color: '#F37AAD'
          },
          {
            data: retCust2,
            label: 'Returning Customer',
            color: '#6AC3C9'
          }],
          {
            series: {
              lines: {
                show: false
              },
              splines: {
                show: true,
                tension: 0.4,
                lineWidth: 1,
                //fill: 0.4
              },
              shadowSize: 0
            },
            points: {
              show: true,
            },
            legend: {
              noColumns: 1,
              position: 'nw'
            },
            grid: {
              hoverable: true,
              clickable: true,
              borderColor: '#ddd',
              borderWidth: 0,
              labelMargin: 5,
              backgroundColor: '#fff'
            },
            yaxis: {
              min: 0,
              max: 15,
              color: '#eee',
              font: {
                size: 10,
                color: '#999'
              }
            },
            xaxis: {
              color: '#eee',
              font: {
                size: 10,
                color: '#999'
              }
            }
          });

          var plot = $.plot($('#flotArea1'),[
            {
              data: newCust,
              label: 'New Customer',
              color: '#BD9DC7'
            },
            {
              data: retCust,
              label: 'Returning Customer',
              color: '#4E6577'
            }],
            {
              series: {
                lines: {
                  show: true,
                  lineWidth: 0,
                  fill: 0.8
                },
                shadowSize: 0
              },
              points: {
                show: false,
              },
              legend: {
                noColumns: 1,
                position: 'nw'
              },
              grid: {
                hoverable: true,
                clickable: true,
                borderColor: '#ddd',
                borderWidth: 0,
                labelMargin: 5,
                backgroundColor: '#fff'
              },
              yaxis: {
                min: 0,
                max: 15,
                color: '#eee',
                font: {
                  size: 10,
                  color: '#999'
                }
              },
              xaxis: {
                color: '#eee',
                font: {
                  size: 10,
                  color: '#999'
                }
              }
            });

            var plot = $.plot($('#flotArea2'),[
              {
                data: newCust,
                label: 'New Customer',
                color: '#BD9DC7'
              },
              {
                data: retCust,
                label: 'Returning Customer',
                color: '#4E6577'
              }],
              {
                series: {
                  lines: {
                    show: false
                  },
                  splines: {
                    show: true,
                    tension: 0.4,
                    lineWidth: 0,
                    fill: 0.8
                  },
                  shadowSize: 0
                },
                points: {
                  show: false,
                },
                legend: {
                  noColumns: 1,
                  position: 'nw'
                },
                grid: {
                  hoverable: true,
                  clickable: true,
                  borderColor: '#ddd',
                  borderWidth: 0,
                  labelMargin: 5,
                  backgroundColor: '#fff'
                },
                yaxis: {
                  min: 0,
                  max: 15,
                  color: '#eee',
                  font: {
                    size: 10,
                    color: '#999'
                  }
                },
                xaxis: {
                  color: '#eee',
                  font: {
                    size: 10,
                    color: '#999'
                  }
                }
              });

    var previousPoint = null;

    $('#flotLine3, #flotLine4').bind('plothover', function (event, pos, item) {
      $('#x').text(pos.x.toFixed(2));
      $('#y').text(pos.y.toFixed(2));

      if(item) {
        if (previousPoint != item.dataIndex) {
          previousPoint = item.dataIndex;

          $('#tooltip').remove();
          var x = item.datapoint[0].toFixed(2),
          y = item.datapoint[1].toFixed(2);

          showTooltip(item.pageX, item.pageY, item.series.label + ' of ' + x + ' = ' + y);
        }
      } else {

        $('#tooltip').remove();
        previousPoint = null;
      }
    });

    $('#flotLine3, #flotLine4').bind('plotclick', function (event, pos, item) {
      if (item) {
        plot.highlight(item.series, item.datapoint);
      }
    });

    function showTooltip(x, y, contents) {
  		$('<div id="tooltip" class="tooltipflot">' + contents + '</div>').css( {
  		  position: 'absolute',
  		  display: 'none',
  		  top: y + 5,
  		  left: x + 5
  		}).appendTo('body').fadeIn(200);
  	}


    /*********** REAL TIME UPDATES **************/

    var data = [], totalPoints = 50;

    function getRandomData() {
      if (data.length > 0)
      data = data.slice(1);
      while (data.length < totalPoints) {
        var prev = data.length > 0 ? data[data.length - 1] : 50,
        y = prev + Math.random() * 10 - 5;
        if (y < 0) {
          y = 0;
        } else if (y > 100) {
          y = 100;
        }
        data.push(y);
      }
      var res = [];
      for (var i = 0; i < data.length; ++i) {
        res.push([i, data[i]])
      }
      return res;
    }


    // Set up the control widget
	 var updateInterval = 1000;

   var plot4 = $.plot('#flotRealtime1', [ getRandomData() ], {
      colors: ['#BD9DC7'],
		  series: {
        lines: {
          show: true,
          lineWidth: 1
        },
        shadowSize: 0	// Drawing is faster without shadows
		  },
      grid: {
        borderColor: '#ddd',
        borderWidth: 1,
        labelMargin: 5
		  },
      xaxis: {
        color: '#eee',
        font: {
          size: 10,
          color: '#999'
        }
      },
		  yaxis: {
				min: 0,
				max: 100,
        color: '#eee',
        font: {
          size: 10,
          color: '#999'
        }
		  }
	 });

   var plot5 = $.plot('#flotRealtime2', [ getRandomData() ], {
      colors: ['#BD9DC7'],
		  series: {
        lines: {
          show: true,
          lineWidth: 0,
          fill: 0.9
        },
        shadowSize: 0	// Drawing is faster without shadows
		  },
      grid: {
        borderColor: '#ddd',
        borderWidth: 1,
        labelMargin: 5
		  },
      xaxis: {
        color: '#eee',
        font: {
          size: 10,
          color: '#999'
        }
      },
		  yaxis: {
				min: 0,
				max: 100,
        color: '#eee',
        font: {
          size: 10,
          color: '#999'
        }
		  }
	 });

	 function update_plot4() {
		  plot4.setData([getRandomData()]);
		  plot4.draw();
		  setTimeout(update_plot4, updateInterval);
	 }

   function update_plot5() {
		  plot5.setData([getRandomData()]);
		  plot5.draw();
		  setTimeout(update_plot5, updateInterval);
	 }

	 update_plot4();
   update_plot5();


   /**************** PIE CHART *******************/
   var piedata = [
      { label: "Series 1", data: [[1,10]], color: '#9A3267'},
      { label: "Series 2", data: [[1,30]], color: '#ED4151'},
      { label: "Series 3", data: [[1,90]], color: '#F89D44'},
      { label: "Series 4", data: [[1,70]], color: '#85C441'},
      { label: "Series 5", data: [[1,80]], color: '#36B3E3'}
	 ];

    $.plot('#flotPie1', piedata, {
      series: {
        pie: {
          show: true,
          radius: 1,
          label: {
            show: true,
            radius: 2/3,
            formatter: labelFormatter,
            threshold: 0.1
          }
        }
      },
      grid: {
        hoverable: true,
        clickable: true
      }
    });

    $.plot('#flotPie2', piedata, {
      series: {
        pie: {
          show: true,
          radius: 1,
          innerRadius: 0.5,
          label: {
            show: true,
            radius: 2/3,
            formatter: labelFormatter,
            threshold: 0.1
          }
        }
      },
      grid: {
        hoverable: true,
        clickable: true
      }
    });

    function labelFormatter(label, series) {
		  return "<div style='font-size:8pt; text-align:center; padding:2px; color:white;'>" + label + "<br/>" + Math.round(series.percent) + "%</div>";
	  }

});

$(function(){

  'use strict'

  /************************ BAR CHART 1 *************************/
  var chartdata = [
    {
      name: 'Oranges',
      type: 'bar',
      data: [20, 20, 36, 12, 15]
    },
    {
      name: 'Apples',
      type: 'bar',
      data: [8, 5, 25, 10, 10]
    }
  ];

  var chart = document.getElementById('chartBar1');
  var barChart = echarts.init(chart);

  var option = {
    grid: {
      top: '6',
      right: '0',
      bottom: '17',
      left: '25',
    },
    xAxis: {
      data: [ '2006', '2008', '2010', '2012', '2014'],
      axisLine: {
        lineStyle: {
          color: '#ccc'
        }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    yAxis: {
      splitLine: {
        lineStyle: {
          color: '#ddd'
        }
      },
      axisLine: {
        lineStyle: {
          color: '#ccc'
        }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    series: chartdata
  };

  barChart.setOption(option);


  /********************** BAR CHART 2 **************************/
  var chartdata2 = [
    {
      name: 'Oranges',
      type: 'bar',
      data: [20, 20, 36, 12, 15]
    },
    {
      name: 'Apples',
      type: 'bar',
      data: [8, 5, 25, 10, 10]
    },
    {
      name: 'Grapes',
      type: 'bar',
      data: [15, 10, 20, 20, 25]
    }
  ];

  var chart2 = document.getElementById('chartBar2');
  var barChart2 = echarts.init(chart2);

  var option2 = {
    grid: {
      top: '6',
      right: '0',
      bottom: '17',
      left: '25',
    },
    xAxis: {
      data: [ '2006', '2008', '2010', '2012', '2014'],
      axisLine: {
        lineStyle: {
          color: '#ccc'
        }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    yAxis: {
      splitLine: {
        lineStyle: {
          color: '#ddd'
        }
      },
      axisLine: {
        lineStyle: {
          color: '#ccc'
        }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    series: chartdata2,
    color:[ '#693391','#E7016E','#109EDC']
  };

  barChart2.setOption(option2);


  /***************** BAR CHART 3 ********************/
  var option3 = {
    grid: {
      top: '6',
      right: '0',
      bottom: '17',
      left: '32',
    },
    xAxis: {
      type: 'value',
      axisLine: {
        lineStyle: {
          color: '#ccc'
        }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    yAxis: {
      type: 'category',
      data: [ '2006', '2008', '2010', '2012', '2014'],
      splitLine: {
        lineStyle: {
          color: '#ddd'
        }
      },
      axisLine: {
        lineStyle: {
          color: '#ccc'
        }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    series: chartdata
  };

  var chart3 = document.getElementById('chartBar3');
  var barChart3 = echarts.init(chart3);
  barChart3.setOption(option3);


  /***************** BAR CHART 4 *********************/
  var option4 = {
    grid: {
      top: '6',
      right: '0',
      bottom: '17',
      left: '32',
    },
    xAxis: {
      type: 'value',
      axisLine: {
        lineStyle: {
          color: '#ccc'
        }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    yAxis: {
      type: 'category',
      data: [ '2006', '2008', '2010', '2012', '2014'],
      splitLine: {
        lineStyle: {
          color: '#ddd'
        }
      },
      axisLine: {
        lineStyle: {
          color: '#ccc'
        }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    series: chartdata2,
    color:[ '#693391','#E7016E','#109EDC']
  };

  var chart4 = document.getElementById('chartBar4');
  var barChart4 = echarts.init(chart4);
  barChart4.setOption(option4);


  

  /****************** STACKED BAR CHART ********************/
  var chartdata3 = [
    {
      name: 'Oranges',
      type: 'bar',
      stack: 'Stack',
      data: [20, 20, 36, 12, 15]
    },
    {
      name: 'Apples',
      type: 'bar',
      stack: 'Stack',
      data: [8, 5, 25, 10, 10]
    },
    {
      name: 'Grapes',
      type: 'bar',
      stack: 'Stack',
      data: [15, 10, 20, 20, 25]
    }
  ];

  var option5 = {
    grid: {
      top: '6',
      right: '0',
      bottom: '17',
      left: '25',
    },
    xAxis: {
      data: [ '2006', '2008', '2010', '2012', '2014'],
      axisLine: {
        lineStyle: {
          color: '#ccc'
        }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    yAxis: {
      splitLine: {
        lineStyle: {
          color: '#ddd'
        }
      },
      axisLine: {
        lineStyle: {
          color: '#ccc'
        }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    series: chartdata3
  };

  var chart5 = document.getElementById('chartBar5');
  var barChart5 = echarts.init(chart5);
  barChart5.setOption(option5);



  /****************** BAR CHART 6 *******************/
  var option6 = {
    grid: {
      top: '6',
      right: '10',
      bottom: '17',
      left: '32',
    },
    xAxis: {
      type: 'value',
      axisLine: {
        lineStyle: {
          color: '#ccc'
        }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    yAxis: {
      type: 'category',
      data: [ '2006', '2008', '2010', '2012', '2014'],
      splitLine: {
        lineStyle: {
          color: '#ddd'
        }
      },
      axisLine: {
        lineStyle: {
          color: '#ccc'
        }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    series: chartdata3
  };

  var chart6 = document.getElementById('chartBar6');
  var barChart6 = echarts.init(chart6);
  barChart6.setOption(option6);


  /********************** LINE CHART ***********************/
  var chartdata4 = [
    {
      name: 'Oranges',
      type: 'line',
      data: [20, 20, 36, 18, 15, 20, 25, 20]
    }
  ];

  var option7 = {
    grid: {
      top: '6',
      right: '0',
      bottom: '17',
      left: '25',
    },
    xAxis: {
      data: [ '2006', '2008', '2010', '2012', '2014', '2015','2016', '2017'],
      axisLine: {
        lineStyle: {
          color: '#ccc'
        }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    yAxis: {
      splitLine: {
        lineStyle: {
          color: '#ddd'
        }
      },
      axisLine: {
        lineStyle: {
          color: '#ccc'
        }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    series: chartdata4
  };

  var chart7 = document.getElementById('chartLine1');
  var lineChart = echarts.init(chart7);
  lineChart.setOption(option7);


  /** ***************** LINE CHART 2 ********************/
  var chartdata5 = [
    {
      name: 'Oranges',
      type: 'line',
      smooth: true,
      data: [20, 20, 36, 18, 15, 20, 25, 20]
    }
  ];

  var option8 = {
    grid: {
      top: '6',
      right: '0',
      bottom: '17',
      left: '25',
    },
    xAxis: {
      data: [ '2006', '2008', '2010', '2012', '2014', '2015','2016', '2017'],
      axisLine: {
        lineStyle: {
          color: '#ccc'
        }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    yAxis: {
      splitLine: {
        lineStyle: {
          color: '#ddd'
        }
      },
      axisLine: {
        lineStyle: {
          color: '#ccc'
        }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    series: chartdata5,
    color:[ '#693391']
  };

  var chart8 = document.getElementById('chartLine2');
  var lineChart2 = echarts.init(chart8);
  lineChart2.setOption(option8);


  /*************** AREA CHARTS *****************/
  var areaData = [
    {
      name: 'Oranges',
      type: 'line',
      data: [20, 20, 36, 12, 15,25],
      lineStyle: {
        normal: { width: 1 }
      },
      itemStyle: {
        normal: {
          areaStyle: { type: 'default' }
        }
      }
    },
    {
      name: 'Apples',
      type: 'line',
      data: [8, 5, 25, 10, 10, 20],
      lineStyle: {
        normal: { width: 1 }
      },
      itemStyle: {
        normal: {
          areaStyle: { type: 'default' }
        }
      }
    }
  ];

  var optionArea = {
    grid: {
      top: '6',
      right: '12',
      bottom: '17',
      left: '25',
    },
    xAxis: {
      data: [ '2006', '2008', '2010', '2012', '2014', '2016'],
      boundaryGap: false,
      axisLine: {
        lineStyle: { color: '#ccc' }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    yAxis: {
      splitLine: {
        lineStyle: { color: '#ddd' }
      },
      axisLine: {
        lineStyle: { color: '#ccc' }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    series: areaData
  };


  var chartArea = document.getElementById('chartArea1');
  var areaChart = echarts.init(chartArea);
  areaChart.setOption(optionArea);


  /***************** AREA DATA 2 *****************/
  var areaData2 = [
    {
      name: 'Oranges',
      type: 'line',
      smooth: true,
      data: [20, 20, 36, 12, 15,25],
      lineStyle: {
        normal: { width: 1 }
      },
      itemStyle: {
        normal: {
          areaStyle: { type: 'default' }
        }
      }
    },
    {
      name: 'Apples',
      type: 'line',
      smooth: true,
      data: [8, 5, 25, 10, 10, 20],
      lineStyle: {
        normal: { width: 1 }
      },
      itemStyle: {
        normal: {
          areaStyle: { type: 'default' }
        }
      }
    }
  ];

  var optionArea2 = {
    grid: {
      top: '6',
      right: '12',
      bottom: '17',
      left: '25',
    },
    xAxis: {
      data: [ '2006', '2008', '2010', '2012', '2014', '2016'],
      boundaryGap: false,
      axisLine: {
        lineStyle: { color: '#ccc' }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    yAxis: {
      splitLine: {
        lineStyle: { color: '#ddd' }
      },
      axisLine: {
        lineStyle: { color: '#ccc' }
      },
      axisLabel: {
        fontSize: 10,
        color: '#666'
      }
    },
    series: areaData2,
    color:[ '#693391','#E7016E']
  };

  var chartArea2 = document.getElementById('chartArea2');
  var areaChart2 = echarts.init(chartArea2);
  areaChart2.setOption(optionArea2);


  /**************** PIE CHART ************/
  var pieData = [{
    name: 'Fruits',
    type: 'pie',
    radius: '80%',
    center: ['50%', '57.5%'],
    data: [
      {value: 335, name: 'Apple'},
      {value: 310, name: 'Orange'},
      {value: 234, name: 'Grapes'},
      {value: 135, name: 'Lemon'},
      {value: 154, name: 'Banana'}
    ],
    label: {
      normal: {
        fontFamily: 'Roboto, sans-serif',
        fontSize: 11
      }
    },
    labelLine: {
      normal: {
        show: false
      }
    },
    markLine: {
      lineStyle: {
        normal: {
          width: 1
        }
      }
    }
  }];

  var pieOption = {
    tooltip: {
      trigger: 'item',
      formatter: '{a} <br/>{b}: {c} ({d}%)',
      textStyle: {
        fontSize: 11,
        fontFamily: 'Roboto, sans-serif'
      }
    },
    series: pieData
  };

  var pie = document.getElementById('chartPie');
  var pieChart = echarts.init(pie);
  pieChart.setOption(pieOption);


  /**************** DONUT CHART ************/
  var donutData = [{
    name: 'Fruits',
    type: 'pie',
    radius: ['40%','80%'],
    center: ['50%', '57.5%'],
    data: [
      {value: 335, name: 'Apple'},
      {value: 310, name: 'Orange'},
      {value: 234, name: 'Grapes'},
      {value: 135, name: 'Lemon'},
      {value: 154, name: 'Banana'}
    ],
    label: {
      normal: {
        fontFamily: 'Roboto, sans-serif',
        fontSize: 11
      }
    },
    labelLine: {
      normal: {
        show: false
      }
    },
    markLine: {
      lineStyle: {
        normal: {
          width: 1
        }
      }
    }
  }];

  var donutOption = {
    tooltip: {
      trigger: 'item',
      formatter: '{a} <br/>{b}: {c} ({d}%)',
      textStyle: {
        fontSize: 11,
        fontFamily: 'Roboto, sans-serif'
      }
    },
    series: donutData
  };

  var donut = document.getElementById('chartDonut');
  var donutChart = echarts.init(donut);
  donutChart.setOption(donutOption);



  /** making all charts responsive when resize **/
  function resizeAllECharts() {
    barChart.resize();
    barChart2.resize();
    barChart3.resize();
    barChart4.resize();
    barChart5.resize();
    barChart6.resize();
    lineChart.resize();
    lineChart2.resize();
    areaChart.resize();
    areaChart2.resize();
    pieChart.resize();
    donutChart.resize();
  }

  new ResizeSensor($('.br-mainpanel'), function(){
    resizeAllECharts();
  });

});

$(function(){
  'use strict';

  var ctx1 = document.getElementById('chartBar1').getContext('2d');
  var myChart1 = new Chart(ctx1, {
    type: 'bar',
    data: {
      labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun'],
      datasets: [{
        label: '# of Votes',
        data: [12, 39, 20, 10, 25, 18],
        backgroundColor: '#27AAC8'
      }]
    },
    options: {
      legend: {
        display: false,
          labels: {
            display: false
          }
      },
      scales: {
        yAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 10,
            max: 80
          }
        }],
        xAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 11
          }
        }]
      }
    }
  });

  var ctx2 = document.getElementById('chartBar2').getContext('2d');
  var myChart2 = new Chart(ctx2, {
    type: 'bar',
    data: {
      labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun'],
      datasets: [{
        label: '# of Votes',
        data: [12, 39, 20, 10, 25, 18],
        backgroundColor: [
          '#29B0D0',
          '#2A516E',
          '#F07124',
          '#CBE0E3',
          '#979193'
        ]
      }]
    },
    options: {
      legend: {
        display: false,
          labels: {
            display: false
          }
      },
      scales: {
        yAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 10,
            max: 80
          }
        }],
        xAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 11
          }
        }]
      }
    }
  });

  var ctb3 = document.getElementById('chartBar3').getContext('2d');
  new Chart(ctb3, {
    type: 'horizontalBar',
    data: {
      labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun'],
      datasets: [{
        label: '# of Votes',
        data: [12, 39, 20, 10, 25, 18],
        backgroundColor: '#27AAC8'
      }]
    },
    options: {
      legend: {
        display: false,
          labels: {
            display: false
          }
      },
      scales: {
        yAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 10,
          }
        }],
        xAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 11,
            max: 80
          }
        }]
      }
    }
  });

  var ctb4 = document.getElementById('chartBar4').getContext('2d');
  new Chart(ctb4, {
    type: 'horizontalBar',
    data: {
      labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun'],
      datasets: [{
        label: '# of Votes',
        data: [12, 39, 20, 10, 25, 18],
        backgroundColor: [
          '#29B0D0',
          '#2A516E',
          '#F07124',
          '#CBE0E3',
          '#979193'
        ]
      }]
    },
    options: {
      legend: {
        display: false,
          labels: {
            display: false
          }
      },
      scales: {
        yAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 10
          }
        }],
        xAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 11,
            max: 80
          }
        }]
      }
    }
  });

  /* LINE CHART */
  var ctx3 = document.getElementById('chartLine1');
  var myChart3 = new Chart(ctx3, {
    type: 'line',
    data: {
      labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun'],
      datasets: [{
        label: '# of Votes',
        data: [12, 39, 20, 10, 25, 18],
        borderColor: '#27AAC8',
        borderWidth: 1,
        fill: false
      }]
    },
    options: {
      legend: {
        display: false,
          labels: {
            display: false
          }
      },
      scales: {
        yAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 10,
            max: 80
          }
        }],
        xAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 11
          }
        }]
      }
    }
  });

  var ctx4 = document.getElementById('chartLine2');
  var myChart4 = new Chart(ctx4, {
    type: 'line',
    data: {
      labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun'],
      datasets: [{
        data: [12, 39, 20, 10, 20, 18],
        borderColor: '#2E5773',
        borderWidth: 1,
        fill: false
      },{
        data: [30, 50, 28, 23, 25, 28],
        borderColor: '#F47322',
        borderWidth: 1,
        fill: false
      }]
    },
    options: {
      legend: {
        display: false,
          labels: {
            display: false
          }
      },
      scales: {
        yAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 10,
            max: 80
          }
        }],
        xAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 11
          }
        }]
      }
    }
  });


  /** AREA CHART **/
  var ctx5 = document.getElementById('chartArea1');
  var myChart5 = new Chart(ctx5, {
    type: 'line',
    data: {
      labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun'],
      datasets: [{
        data: [12, 39, 20, 10, 25, 18],
        backgroundColor: '#F07124', //rgba(240, 113, 36, 0.4)
        fill: true,
        borderWidth: 0,
        borderColor: '#fff'
      }]
    },
    options: {
      legend: {
        display: false,
          labels: {
            display: false
          }
      },
      scales: {
        yAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 10,
            max: 80
          }
        }],
        xAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 11
          }
        }]
      }
    }
  });

  var ctx6 = document.getElementById('chartArea2');
  new Chart(ctx6, {
    type: 'line',
    data: {
      labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun'],
      datasets: [{
        data: [10, 24, 20, 25, 35, 50],
        backgroundColor: '#2E5773',
        borderWidth: 1,
        fill: true
      },{
        data: [20, 30, 28, 33, 45, 65],
        backgroundColor: '#F47322',
        borderWidth: 1,
        fill: true
      }]
    },
    options: {
      legend: {
        display: false,
          labels: {
            display: false
          }
      },
      scales: {
        yAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 10,
            max: 80
          }
        }],
        xAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 11
          }
        }]
      }
    }
  });

  /** STACKED BAR CHART **/
  var ctx7 = document.getElementById('chartStacked1');
  new Chart(ctx7, {
    type: 'bar',
    data: {
      labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun'],
      datasets: [{
        data: [10, 24, 20, 25, 35, 50],
        backgroundColor: '#29B0D0',
        borderWidth: 1,
        fill: true
      },{
        data: [10, 24, 20, 25, 35, 50],
        backgroundColor: '#2E5773',
        borderWidth: 1,
        fill: true
      },{
        data: [20, 30, 28, 33, 45, 65],
        backgroundColor: '#F47322',
        borderWidth: 1,
        fill: true
      }]
    },
    options: {
      legend: {
        display: false,
          labels: {
            display: false
          }
      },
      scales: {
        yAxes: [{
          stacked: true
        }],
        xAxes: [{
          stacked: true
        }]
      }
    }
  });

  var ctx8 = document.getElementById('chartStacked2');
  new Chart(ctx8, {
    type: 'horizontalBar',
    data: {
      labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun'],
      datasets: [{
        data: [10, 24, 20, 25, 35, 50],
        backgroundColor: '#29B0D0',
        borderWidth: 1,
        fill: true
      },{
        data: [10, 24, 20, 25, 35, 50],
        backgroundColor: '#2E5773',
        borderWidth: 1,
        fill: true
      },{
        data: [20, 30, 28, 33, 45, 65],
        backgroundColor: '#F47322',
        borderWidth: 1,
        fill: true
      }]
    },
    options: {
      legend: {
        display: false,
          labels: {
            display: false
          }
      },
      scales: {
        yAxes: [{
          stacked: true
        }],
        xAxes: [{
          stacked: true
        }]
      }
    }
  });

  /** SPECIFIC GRID LINE COLOR **/
  var ctx9 = document.getElementById('chartArea3');
  new Chart(ctx9, {
    type: 'line',
    data: {
      labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun'],
      datasets: [{
        data: [10, 24, 20, 25, 35, 50],
        backgroundColor: 'rgba(46,87,115,.4)',
        borderWidth: 1,
        fill: true
      },{
        data: [20, 30, 28, 33, 45, 65],
        backgroundColor: 'rgba(41,176,208,.4)',
        borderWidth: 1,
        fill: true
      }]
    },
    options: {
      legend: {
        display: false,
          labels: {
            display: false
          }
      },
      scales: {
        yAxes: [{
          gridLines: {
            drawBorder: false,
            color: ['', '', '#cc0000']
          },
          ticks: {
            beginAtZero:true,
            fontSize: 10,
            max: 80
          }
        }],
        xAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 11
          }
        }]
      }
    }
  });

  var ctx10 = document.getElementById('chartArea4');
  new Chart(ctx10, {
    type: 'line',
    data: {
      labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun'],
      datasets: [{
        data: [10, 24, 20, 25, 35, 50],
        backgroundColor: 'rgba(46,87,115,.4)',
        borderWidth: 1,
        fill: true
      },{
        data: [20, 30, 28, 33, 45, 65],
        backgroundColor: 'rgba(41,176,208,.4)',
        borderWidth: 1,
        fill: true
      }]
    },
    options: {
      legend: {
        display: false,
          labels: {
            display: false
          }
      },
      scales: {
        yAxes: [{
          gridLines: {
            drawBorder: false,
            color: ['', '#cc0000', '#0ad013']
          },
          ticks: {
            beginAtZero:true,
            fontSize: 10,
            max: 80
          }
        }],
        xAxes: [{
          ticks: {
            beginAtZero:true,
            fontSize: 11
          }
        }]
      }
    }
  });


  /** PIE CHART **/
  var randomScalingFactor = function() {
    return Math.round(Math.random() * 100);
  };

  var datapie = {
    datasets: [{
      data: [
        randomScalingFactor(),
        randomScalingFactor(),
        randomScalingFactor(),
        randomScalingFactor(),
        randomScalingFactor(),
      ],
      backgroundColor: [
        '#29B0D0',
        '#4C6579',
        '#F57E2E',
        '#C8E0E4',
        '#A6A7AC'
      ]
    }]
  };

  var optionpie = {
    responsive: true,
    legend: {
      display: false,
    },
    animation: {
      animateScale: true,
      animateRotate: true
    }
  };

  // For a doughnut chart
  var ctx6 = document.getElementById('chartPie');
  var myPieChart6 = new Chart(ctx6, {
    type: 'doughnut',
    data: datapie,
    options: optionpie
  });

  // For a pie chart
  var ctx7 = document.getElementById('chartDonut');
  var myPieChart7 = new Chart(ctx7, {
    type: 'pie',
    data: datapie,
    options: optionpie
  });

});

$(function(){
  'use strict'


  /************ LINE CHART 1 ***************/

  var line1 = new Chartist.Line('#chartLine1', {
    labels: ['Mon', 'Tue', 'Wed', 'Thu', 'Fri'],
    series: [
      [12, 9, 7, 8, 5]
    ]
  },{
    high: 30,
    axisY: {
      onlyInteger: true
    },
    fullWidth: true,
    chartPadding: {
      bottom: 0,
      left: 0
    }
  });

  // resize chart when container changest it's width
  new ResizeSensor($('.br-mainpanel'), function(){
    line1.update();
  });


  /*********** LINE CHART 2 ******************/
  var line2 = new Chartist.Line('#chartLine2', {
    labels: ['Mon', 'Tue', 'Wed', 'Thu', 'Fri'],
    series: [
      [12, 9, 7, 8, 5],
      [2, 1, 5, 7, 3],
      [1, 3, 4, 5, 6]
    ]
  },{
    high: 30,
    axisY: {
      onlyInteger: true
    },
    fullWidth: true,
    chartPadding: {
      bottom: 0,
      left: 0
    }
  });

  // resize chart when container changest it's width
  new ResizeSensor($('.br-mainpanel'), function(){
    line2.update();
  });


  /*********************** AREA CHART 1 *********************/

  var area1 = new Chartist.Line('#chartArea1', {
    labels: [1, 2, 3, 4, 5, 6, 7, 8],
    series: [
      [5, 9, 7, 8, 5, 3, 5, 4]
    ]
  }, {
    high: 30,
    low: 0,
    axisY: {
      onlyInteger: true
    },
    showArea: true,
    fullWidth: true,
    chartPadding: {
      bottom: 0,
      left: 0
    }
  });

  var area2 = new Chartist.Line('#chartArea2', {
    labels: [1, 2, 3, 4, 5, 6, 7, 8],
    series: [
      [5, 9, 7, 8, 5, 3, 5, 4],
      [10, 15, 10, 20, 18, 11, 16, 18]
    ]
  }, {
    high: 30,
    low: 0,
    axisY: {
      onlyInteger: true
    },
    showArea: true,
    fullWidth: true,
    chartPadding: {
      bottom: 0,
      left: 0
    }
  });

  // resize chart when container changest it's width
  new ResizeSensor($('.br-mainpanel'), function(){
    area1.update();
    area2.update();
  });


  /********************* BAR CHART ****************/
  var bar1 = new Chartist.Bar('#chartBar1', {
    labels: [1, 2, 3, 4, 5, 6, 7, 8],
    series: [
      [5, 9, 7, 8, 5, 3, 5, 4]
    ]
  }, {
    high: 30,
    low: 0,
    axisY: {
      onlyInteger: true
    },
    showArea: true,
    fullWidth: true,
    chartPadding: {
      bottom: 0,
      left: 0
    }
  });

  var bar2 = new Chartist.Bar('#chartBar2', {
    labels: [1, 2, 3, 4, 5, 6, 7, 8],
    series: [
      [5, 9, 7, 8, 5, 3, 5, 4],
      [10, 15, 10, 20, 18, 11, 16, 18]
    ]
  }, {
    high: 30,
    low: 0,
    axisY: {
      onlyInteger: true
    },
    showArea: true,
    fullWidth: true,
    chartPadding: {
      bottom: 0,
      left: 0
    }
  });


  // resize chart when container changest it's width
  new ResizeSensor($('.br-mainpanel'), function(){
    bar1.update();
    bar2.update();
  });


  /********************* HORIZONTAL BARS CHART ****************/

  var bar3 = new Chartist.Bar('#chartBar3', {
    labels: ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'],
    series: [
      [5, 9, 7, 8, 5, 3, 5]
    ]
  }, {
    high: 30,
    low: 0,
    axisY: {
      onlyInteger: true
    },
    horizontalBars: true,
    showArea: true,
    fullWidth: true,
    chartPadding: {
      bottom: 0,
      left: 40
    }
  });

  var bar4 = new Chartist.Bar('#chartBar4', {
    labels: ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'],
    series: [
      [5, 9, 7, 8, 5, 3, 5],
      [10, 15, 10, 20, 18, 11, 16]
    ]
  }, {
    high: 30,
    low: 0,
    axisY: {
      onlyInteger: true
    },
    horizontalBars: true,
    showArea: true,
    fullWidth: true,
    chartPadding: {
      bottom: 0,
      left: 40
    }
  });


  // resize chart when container changest it's width
  new ResizeSensor($('.br-mainpanel'), function(){
    bar3.update();
    bar4.update();
  });



  /***************** STACKED BAR CHARTS ********************/

  var bar5 = new Chartist.Bar('#chartBar5', {
    labels: ['Q1', 'Q2', 'Q3', 'Q4'],
    series: [
      [800000, 1200000, 1400000, 1300000],
      [200000, 400000, 500000, 300000],
      [100000, 200000, 400000, 600000]
    ]
  }, {
    stackBars: true,
    axisY: {
      labelInterpolationFnc: function(value) {
        return (value / 1000) + 'k';
      }
    }
  }).on('draw', function(data) {
    if(data.type === 'bar') {
      data.element.attr({
        style: 'stroke-width: 30px'
      });
    }
  });


  var bar6 = new Chartist.Bar('#chartBar6', {
    labels: ['Q1', 'Q2', 'Q3', 'Q4'],
    series: [
      [800000, 1200000, 1400000, 1300000],
      [200000, 400000, 500000, 300000],
      [100000, 200000, 400000, 600000]
    ]
  }, {
    stackBars: true,
    horizontalBars: true,
    axisX: {
      labelInterpolationFnc: function(value) {
        return (value / 1000) + 'k';
      }
    },
    chartPadding: {
      bottom: 0,
      left: 0,
      right: 40
    }
  }).on('draw', function(data) {
    if(data.type === 'bar') {
      data.element.attr({
        style: 'stroke-width: 30px'
      });
    }
  });

  // resize chart when container changest it's width
  new ResizeSensor($('.br-mainpanel'), function(){
    bar5.update();
    bar6.update();
  });



  /********************* PIE CHART *********************/

  var sum = function(a, b) { return a + b };

  var data = {
    series: [5, 3, 4]
  };

  var pie1 = new Chartist.Pie('#chartPie1', data, {
    labelInterpolationFnc: function(value) {
      return Math.round(value / data.series.reduce(sum) * 100) + '%';
    }
  });


  /**************** PIE CHART 2 *******************/

  var data2 = {
    series: [5, 3, 4, 6, 2]
  };

  var pie2 = new Chartist.Pie('#chartPie2', data2, {
    labelInterpolationFnc: function(value) {
      return Math.round(value / data.series.reduce(sum) * 100) + '%';
    }
  });


  // resize chart when container changest it's width
  new ResizeSensor($('.br-mainpanel'), function(){
    pie1.update();
    pie2.update();
  });


  /**************** DONUT CHARTS ****************/
  var donut1 = new Chartist.Pie('#chartDonut1', {
    series: [20, 10, 30]
  }, {
    donut: true,
    donutWidth: 60,
    donutSolid: true,
    startAngle: 270,
    showLabel: true
  });

  var donut2 = new Chartist.Pie('#chartDonut2', {
    series: [20, 10, 30, 40, 25]
  }, {
    donut: true,
    donutWidth: 60,
    donutSolid: true,
    startAngle: 270,
    showLabel: true
  });

  // resize chart when container changest it's width
  new ResizeSensor($('.br-mainpanel'), function(){
    donut1.update();
    donut2.update();
  });


});