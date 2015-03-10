var gulp = require('gulp'),
    xunit = require('gulp-xunit-runner');
 
gulp.task('unit-test', function () {
  return gulp.src(['B:/PROJECTS/Kata/Diamonds/Diamonds.Tests/bin/Release/Diamonds.Tests.dll'], {read: false})
    .pipe(xunit({
      executable: 'B:/PROJECTS/Kata/Diamonds/packages/xunit.runners.1.9.2/tools/xunit.console.clr4.exe',
    }));
});