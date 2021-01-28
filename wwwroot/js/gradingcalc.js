$("#submitButton").click(function () {

    // Calculate the grade percentage

    finalScore = Number($("#assignments").val()) * .5 +
        Number($("#groupProjects").val()) * .1 +
        Number($("#quizzes").val()) * .1 +
        Number($("#exams").val()) * .2 +
        Number($("#intex").val() * .1)

    letterGrade = ""

    // Calculate the letter Grade
    if (finalScore >= 93) {
        letterGrade = "A"
    } else if (finalScore >= 90) {
        letterGrade = "A-"
    } else if (finalScore >= 87) {
        letterGrade = "B+"
    } else if (finalScore >= 83) {
        letterGrade = "B"
    } else if (finalScore >= 80) {
        letterGrade = "B-"
    } else if (finalScore >= 77) {
        letterGrade = "C+"
    } else if (finalScore >= 73) {
        letterGrade = "C"
    } else if (finalScore >= 70) {
        letterGrade = "C-"
    } else if (finalScore >= 67) {
        letterGrade = "D+"
    } else if (finalScore >= 63) {
        letterGrade = "D"
    } else if (finalScore >= 60) {
        letterGrade = "D-"
    } else {
        letterGrade = "E"
    }


    document.getElementById("finalScore").innerHTML = ("Final Score: " + String(finalScore)
        + "%")
    document.getElementById("letterGrade").innerHTML = ("Letter Grade: " + letterGrade)
});