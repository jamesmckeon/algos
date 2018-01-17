var chai = require("chai");
var expect = chai.expect;
var quickSort = require("../quickSort");

describe("sort", function() {
  it("sorts ascending", function() {
    var arr = [5, 4, 3, 2, 1, 0, -1];

    quickSort.sort(arr);

    expect([-1, 0, 1, 2, 3, 4, 5]).to.deep.equal(arr);
  });

  it("handles duplicate numbers", function() {
    var arr = [5, 4, 3, 2, 1, 0, -1, 2];

    quickSort.sort(arr);

    expect([-1, 0, 1, 2, 2, 3, 4, 5]).to.deep.equal(arr);
  });
});
