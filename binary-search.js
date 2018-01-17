module.exports = (function() {
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
    }
  };
})();
