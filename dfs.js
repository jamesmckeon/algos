"use strict";

module.exports = (function() {
  return {
    hasValue: function(node, value) {
      if (node.value === value) {
        return true;
      } else {
        var nodes = [];
        nodes.push(node);

        while (nodes.length > 0) {
          var n = nodes[0];
          nodes.splice(0, 1);

          if (!n.visited) {
            if (n.value === value) {
              return true;
            } else {
              n.visited = true;

              if (n.nodes) {
                for (var i = 0; i < n.nodes.length; i++) {
                  nodes.push(n.nodes[i]);
                }
              }
            }
          }
        }

        return false;
      }
    }
  };
})();
