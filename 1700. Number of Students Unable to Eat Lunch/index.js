var countStudents = function(students, sandwiches) {
    let rejectN = 0;
    let sandwicheI = 0;

    while (students.length > rejectN &&  students.length !== 0 && sandwicheI < sandwiches.length) {
        var student = students.shift();

        if (sandwiches[sandwicheI] == student) {
            sandwicheI++;
            rejectN = 0;
        } else {
            students.push(student);
            rejectN++;
        }
    }

    return students.length;
};