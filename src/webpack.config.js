var path = require("path");
var webpack = require("webpack");

module.exports = {
  devtool: "source-map",
  entry: "./bin/src/test1.js",
  target: "node",
  output: {
    libraryTarget: "commonjs2",
    path: path.join(__dirname, "../out"),
    filename: "bundle.js"
  },
  externals: [
    function(context, request, callback) {
      if (/^FuseJS/.test(request)){
        return callback(null, 'commonjs ' + request);
      }
      callback();
    }
  ],
  module: {
    rules: [{
      loader: "source-map-loader",
      enforce: "pre",
      test: /\.js$/,
      exclude: /node_modules/
    }]
  }
};
