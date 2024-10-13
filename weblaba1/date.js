
var intervalId = setInterval(function() {
    var now = new Date();
    var dd = String(now.getDate()).padStart(2, '0');
    var mm = now.toLocaleString('ru', { month: 'long' });
    var yyyy = now.getFullYear();
    now = dd + ' ' + mm + ' ' + yyyy;
    document.getElementById("data").innerHTML = now;
  }, 1000);