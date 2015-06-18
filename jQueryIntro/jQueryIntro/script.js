alertify.alert("Hello!")

alertify.confirm("Message", function(e) {
    if (e) {
        //user clicked ok
    } else {
        //user clicked cancel
    }
})