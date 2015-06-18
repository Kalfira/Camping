if (screen.width <= 800) {
    window.location = "http://m.squaresandrectangles.com";
}

var clickedTime; var createdTime; var reactionTime;

function getRandomColor() {
    var letters = '0123456789ABCDEF'.split('');
    var color = '#';
    for (var i = 0; i < 6; i++) {
        color += letters[Math.floor(Math.random() * 16)];
    }
    return color;
}

function makeBox() {
    var time = Math.random();
    time = time * 5000;
    document.getElementById("thing").style.display = 'none';
    setTimeout(function () {

        var top = Math.random();
        top = top * 300;

        var left = Math.random();
        left = left * 500;

        document.getElementById("box").style.display = "block";
        document.getElementById("box").style.backgroundColor = getRandomColor();
        document.getElementById("box").style.marginTop = top + "px";
        document.getElementById("box").style.marginLeft = left + "px";
        console.log(top);
        createdTime = Date.now();


    }, time);
}

document.getElementById("box").onclick = function () {
    clickedTime = Date.now();
    reactionTime = (clickedTime - createdTime) / 1000;
    this.style.display = "none";
    document.getElementById("info").innerHTML = "It took you " + reactionTime + " seconds to click the box!";
    makeBox();
}



