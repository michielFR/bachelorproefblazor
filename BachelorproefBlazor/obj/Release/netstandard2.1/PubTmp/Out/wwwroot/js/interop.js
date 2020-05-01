function createAlert() {
    alert("dit is een alert");
}

function startAnimation() {
    var elem = document.getElementById("animate");
    var pos = 0;
    var id = setInterval(frame, 5);
    function frame() {
        if (pos == 350) {
            clearInterval(id);
        } else {
            pos++;
            elem.style.top = pos + "px";
            elem.style.left = pos + "px";
        }
    }
}

function helloUser() {
    var txt;
    var person = prompt("Wat is je naam?", "Harry Potter");
    if (person == null || person == "") {
        txt = "gebruiker heeft geannuleerd.";
    } else {
        txt = "Dag " + person + "! Wat vind je van de animatie?";
    }
    document.getElementById("demo").innerHTML = txt;
}

