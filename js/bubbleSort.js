module.exports = (function() {
  return {
    sort: function(arr) {
      if (arr.length > 1) {
        var swapped = true;

        while (swapped) {
          swapped = false;
          for (var i = 0; i < arr.length - 1; i++) {
            if (arr[i] > arr[i + 1]) {
              swapped = true;
              var tmp = arr[i];
              arr[i] = arr[i + 1];
              arr[i + 1] = tmp;
            }
          }
        }
      }
    }
  };
})();
