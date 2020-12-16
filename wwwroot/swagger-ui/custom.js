var a = document.querySelector('head > link:nth-child(4)');
if (a) {
    a.setAttribute('href', 'favicon.ico')
}
var b = document.querySelector('head > link:nth-child(5)');
if (b) {
    b.setAttribute('href', 'favicon.ico')
}

var c = document.querySelector('#swagger-ui > section > div.topbar > div > div > a');
var t = "Rock Api";
c.appendChild(t);