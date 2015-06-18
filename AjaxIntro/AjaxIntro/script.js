//var xhr = new XMLHttpRequest();

//xhr.addEventListener('load', function(e) {
//    var data = JSON.parse(xhr.responseText);
//    console.dir(data);
//});
//xhr.addEventListener('progress', function (e) {
//    if (e.lengthComputable) {
//        var percentComplete = Math.round(e.loaded / e.total * 100);
//        console.info(percentComplete + '% loaded.');
//    } else {
//        console.info('loading...');
//    }
//});

//xhr.open('GET', '/products.json');
//xhr.send();

$.ajax({ url: "products.json", success: function(data) { CreateDiv(data); } });

function CreateDiv(result) {
    for (var prod in result) {
        $("ul").append($("<li></li>").text(result[prod].name+" costs: "+result[prod].price));
    }
}