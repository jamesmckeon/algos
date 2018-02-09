var chai = require("chai");
var expect = chai.expect;
var mergeSort = require("../merge-sort");

describe("merge-sort", function() {
  it("sorts ascending", function() {
    var arr = [5, 4, 3, 2, 1, 0, -1];

    mergeSort().sort(arr);

    expect([-1, 0, 1, 2, 3, 4, 5]).to.deep.equal(arr);
  });
});
