var chai = require("chai");
var expect = chai.expect;
var binarySearch = require("../binary-search");

describe("indexOf", function() {
  it("returns expected index", function() {
    var arr = [-5, -3, -1, 1, 3, 5];

    var val = 1;
    var expected = 3;

    expect(expected).to.equal(binarySearch.indexOf(arr, val));
  });

  it("returns -1", function() {
    var arr = [-5, -3, -1, 1, 3, 5];

    var val = 0;
    var expected = -1;

    expect(expected).to.equal(binarySearch.indexOf(arr, val));
  });
});

describe("indexOfRecursive", function() {
  it("returns expected index", function() {
    var arr = [-5, -3, -1, 1, 3, 5];

    var val = 1;
    var expected = 3;

    expect(expected).to.equal(binarySearch.indexOfRecursive(arr, val));
  });

  it("returns -1", function() {
    var arr = [-5, -3, -1, 1, 3, 5];

    var val = 0;
    var expected = -1;

    expect(expected).to.equal(binarySearch.indexOfRecursive(arr, val));
  });
});
