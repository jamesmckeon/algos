"use strict";

module.exports = (function() {
  function indexOf(arr, start, end, val) {
    if (start === end) {
      if (arr[start] === val) {
        return start;
      } else {
        return -1;
      }
    } else {
      var mid = Math.floor((end - start) / 2) + start;

      if (arr[mid] === val) {
        return mid;
      } else if (arr[mid] > val) {
        return indexOf(arr, start, mid - 1, val);
      } else {
        return indexOf(arr, mid + 1, end, val);
      }
    }
  }
  return {
    indexOf: function(arr, val) {
      var start = 0;
      var end = arr.length - 1;

      while (start <= end) {
        var mid = Math.floor((end - start) / 2) + start;

        if (arr[mid] === val) {
          return mid;
        } else if (arr[mid] > val) {
          end = mid - 1;
        } else {
          start = mid + 1;
        }
      }

      return -1;
    },
    indexOfRecursive: function(arr, val) {
      return indexOf(arr, 0, arr.length - 1, val);
    }
  };
})();
