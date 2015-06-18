$(form).submit(function(e) {
    e.preventDefault();
    GetGit();
});

function GetGit() {
    $("#results").css("visibility" , "visible");
    var userName = document.forms[0].user.value;
    var repoURL = 'https://api.github.com/users/' + userName + '/repos';
    $.getJSON(repoURL, function (data) {
        for (var repo in data) {
            Populate(data[repo]);
        }
        $("td").css("border", "2px solid black");
        $(".CSharp").css({ "background-color": "blue", "color":"white" });
    });
}

function Populate(entry) {
    var lang = entry.language;
    if (lang === "C#") {
        lang = "CSharp";
    }
    $("#result").append($("<tr><td>"+entry.name+"</td><td class='"+lang+"'>"+entry.language+"</td></tr>"));
}