var gulp = require('gulp');
var clean = require('gulp-clean');
var concat = require('gulp-concat');
  
var bases = {
 app: '/',
 dist: 'assets/js/',
};
 
 
//Delete the dist directory
gulp.task('clean', function() {
 return gulp.src(bases.dist)
 .pipe(clean());
});
 
// Process scripts and concatenate them into one output file
gulp.task('ngscripts', ['clean'], function() {
 gulp.src('**/*src.js')
 .pipe(concat('main.js'))
 .pipe(gulp.dest(bases.dist));
});

// Process scripts and concatenate them into one output file
gulp.task('libscripts', ['clean'], function() {
 gulp.src(
 	['node_modules/angular/angular.js',
 	 'node_modules/angular-route/angular-route.js'])
 .pipe(concat('lib.js'))
 .pipe(gulp.dest(bases.dist));
});

 
// Define the default task as a sequence of the above tasks
gulp.task('default', ['clean','ngscripts', 'libscripts']); 