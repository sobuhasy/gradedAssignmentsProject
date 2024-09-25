// initalize variables - graded assignments
int currentAssignments = 5;

double[] yaraRomanianGrades = new double[5] { 9.3, 8.7, 9.8, 9.5, 10.0 };
double[] rodneyRomanianGrades = new double[5] { 8.0, 8.3, 8.2, 8.8, 8.5 };
double[] sobuRomanianGrades = new double[5] { 8.4, 9.6, 7.3, 8.5, 7.9 };
double[] baniraRomanianGrades = new double[5] { 9.0, 9.2, 9.8, 10.0, 9.7 };

// Student names
string[] studentNames = new string[4] { "Yara", "Rodney", "Sobu", "Banira" };
double[] studentRomanianGrades = new double[10];
string studentGermanGrades = "";

// Write the Report Header to the console
Console.WriteLine("Student Grade\n");
Console.WriteLine("\t\tRO\t\tDE");

foreach (var student in studentNames){
    string currentStudent = student;
    if (currentStudent == "Yara"){
        studentRomanianGrades = yaraRomanianGrades;
    }
    else if (currentStudent == "Rodney"){
        studentRomanianGrades = rodneyRomanianGrades;
    }
    else if (currentStudent == "Sobu"){
        studentRomanianGrades = sobuRomanianGrades;
    }
    else if (currentStudent == "Banira"){
        studentRomanianGrades = baniraRomanianGrades;
    }

    // initialize/reset the sum of the Romanian grades
    double sumAssignmentRomanianGrades = 0.0;

    // initialize/reset the calculated average Romanian grade
    double currentRomanianGrade = 0.0;

    foreach (var romanianGrade in studentRomanianGrades){
        // add the grade to the sum
        sumAssignmentRomanianGrades += romanianGrade;
    }

    currentRomanianGrade = Math.Round(sumAssignmentRomanianGrades / currentAssignments, 1);

    if (currentRomanianGrade == 10.0){
        studentGermanGrades = "1,0";
    }
    else if (currentRomanianGrade >= 9.5){
        studentGermanGrades = "1,3";
    }
    else if (currentRomanianGrade >= 9.0){
        studentGermanGrades = "1,7";
    }
    else if (currentRomanianGrade >= 8.5){
        studentGermanGrades = "2,0";
    }
    else if (currentRomanianGrade >= 8.0){
        studentGermanGrades = "2,3";
    }
    else if (currentRomanianGrade >= 7.5){
        studentGermanGrades = "2,7";
    }
    else if (currentRomanianGrade >= 7.0){
        studentGermanGrades = "3,0";
    }
    else if (currentRomanianGrade >= 6.5){
        studentGermanGrades = "3,3";
    }
    else if (currentRomanianGrade >= 6.0){
        studentGermanGrades = "3,7";
    }
    else if (currentRomanianGrade >= 5.0){
        studentGermanGrades = "4.0";
    }
    else if (currentRomanianGrade < 5.0 && currentRomanianGrade >= 1.0){
        studentGermanGrades = "5.0";
    }
    else{
        Console.WriteLine("Error: Invalid Romanian Grade");
    }
    Console.WriteLine($"{currentStudent}:\t\t{currentRomanianGrade}\t\t{studentGermanGrades}");
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
