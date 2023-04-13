var floors = 28;
for (var i = 1; i <= floors; i++) {
  if (i == 13) {
    // no floor here
    continue;
  }
  document.writeln('At floor: ' + i + '<br>');
}
