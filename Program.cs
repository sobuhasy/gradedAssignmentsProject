// initalize variables - graded assignments
int currentAssignments = 5;

double[] yaraRomanianGrades = new double[5] { 9.3, 8.7, 9.8, 9.5, 10.0 };
double[] rodneyRomanianGrades = new double[5] { 8.0, 8.3, 8.2, 8.8, 8.5 };
double[] sobuRomanianGrades = new double[5] { 8.4, 9.6, 7.3, 8.5, 7.9 };
double[] baniraRomanianGrades = new double[5] { 9.0, 9.2, 9.8, 10.0, 9.7 };

// Student names
string[] studentNames = new string[4] { "Yara", "Rodney", "Sobu", "Banira" };
double[] studentRomanianGrades = new double[10];

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

    Console.WriteLine($"{currentStudent}:\t{currentRomanianGrade}\t?");

}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
