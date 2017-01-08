"use strict";

var gulp     = require("gulp");
var rimraf     = require("rimraf");
var browserify = require("browserify");
var bubleify   = require("bubleify");
var source     = require("vinyl-source-stream");
var buffer     = require('vinyl-buffer');
var concat     = require("gulp-concat");
var cssmin     = require("gulp-cssmin");
var uglify     = require('gulp-uglify');

var paths = {
    webroot: "./wwwroot/"
  };

paths.rootJs        = paths.webroot + "js/app.js";
paths.js            = paths.webroot + "js/**/*.js";
paths.minJs         = paths.webroot + "js/**/*.min.js";
paths.css           = paths.webroot + "css/**/*.css";
paths.minCss        = paths.webroot + "css/**/*.min.css";
paths.concatJsDest  = paths.webroot + "public/js";
paths.concatCssDest = paths.webroot + "public/css";

gulp.task("clean:js", function (cb) {
  rimraf(paths.concatJsDest, cb);
});

gulp.task("clean:css", function (cb) {
  rimraf(paths.concatCssDest, cb);
});

gulp.task("clean", ["clean:js", "clean:css"]);

gulp.task("min:js", function(){
  browserify(paths.rootJs)
    .transform(bubleify, ["es2015", "react"])
    .bundle()
    .pipe(source("bundle.js"))
    .pipe(buffer())
    .pipe(uglify())
    .pipe(gulp.dest(paths.concatJsDest))
});

gulp.task("min:css", function () {
  return gulp.src([paths.css, "!" + paths.minCss])
    .pipe(concat(paths.concatCssDest))
    .pipe(cssmin())
    .pipe(gulp.dest("."));
});

gulp.task("min", ["min:js", "min:css"]);

gulp.task("default", ["clean", "min"])
