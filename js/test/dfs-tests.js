var chai = require("chai");
var assert = chai.assert;
//var expect = chai.expect;
var dfs = require("../dfs");

describe("dfs", function() {
  describe("hasValue", function() {
    it("returns true", function() {
      var top = {};
      var current = top;

      for (var i = 1; i < 11; i++) {
        current.value = i;
        current.nodes = [];

        for (var j = 1; j <= 5; j++) {
          current.nodes.push({ value: i + j });
        }
        current = current.nodes[0];
      }

      assert.isTrue(dfs.hasValue(top, 10));
    });

    it("returns false", function() {
      var top = {};
      var current = top;

      for (var i = 1; i < 11; i++) {
        current.value = i;
        current.nodes = [];

        for (var j = 1; j <= 5; j++) {
          current.nodes.push({ value: i + j });
        }
        current = current.nodes[0];
      }

      assert.isFalse(dfs.hasValue(top, -1));
    });

    it("handles cycles", function() {
      var top = {};
      var current = top;

      for (var i = 1; i < 11; i++) {
        current.value = i;
        current.nodes = [];

        for (var j = 1; j <= 5; j++) {
          current.nodes.push({ value: i + j });
        }
        current = current.nodes[0];
      }

      if (!current.nodes) {
        current.nodes = [];
      }

      current.nodes.push(top); //create a cycle
      assert.isTrue(dfs.hasValue(top, 10));
    });
  });
});
