function gotoLesson(id) {
    if(event.ctrlKey){
        window.open('/Troop/Lesson/' + id + "?troopUserId=11072&sectionId=85", "blank");
    }
    else{
        window.location = '/Troop/Lesson/' + id + "?troopUserId=11072&sectionId=85";
    }
}