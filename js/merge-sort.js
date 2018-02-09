function mergeSort() {
  function sort(arr, start, end) {
    if (typeof start === "undefined") {
      start = 0;
    }

    if (typeof end === "undefined") {
      end = arr.length - 1;
    }

    if (end > start) {
      var mid = start + Math.floor((end - start) / 2);
      sort(arr, start, mid);
      sort(arr, mid + 1, end);
      merge(arr, start, mid, end);
    }
  }

  function merge(arr, start, mid, end) {
    var a = [];
    var i = 0;

    while (i <= arr.length) {
      a.push(arr[i]);
      i++;
    }

    var left = start;
    var right = mid + 1;
    i = start;

    while (left <= mid && right <= end) {
      if (a[left] <= a[right]) {
        arr[i] = a[left];
        left++;
      } else {
        arr[i] = a[right];
        right++;
      }

      i++;
    }

    while (left <= mid) {
      arr[i] = a[left];
      left++;
      i++;
    }

    while (right <= end) {
      arr[i] = a[right];
      right++;
      i++;
    }
  }

  return {
    sort: sort
  };
}

module.exports = mergeSort;
