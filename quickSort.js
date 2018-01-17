module.exports = (function() {
  function sort(arr, start, end) {
    if (start < end) {
      var p = partition(arr, start, end);

      //console.log(arr);
      sort(arr, start, p - 1);
      sort(arr, p + 1, end);
    }
  }

  function swap(arr, a, b) {
    var tmp = arr[a];
    arr[a] = arr[b];
    arr[b] = tmp;
  }

  function partition(arr, start, end) {
    var p = arr[end];
    var i = start - 1;

    for (var j = start; j <= end - 1; j++) {
      if (arr[j] <= p) {
        i++;
        swap(arr, j, i);
      }
    }

    swap(arr, i + 1, end);
    return i + 1;
  }
  return {
    sort: function(arr) {
      return sort(arr, 0, arr.length - 1);
    }
  };
})();
