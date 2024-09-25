// initalize variables - graded assignments
int currentAssignments = 5;

double yara1 = 9.3;
double yara2 = 8.7;
double yara3 = 9.8;
double yara4 = 9.5;
double yara5 = 10.0;
double yaraSum = Math.Round(yara1 + yara2 + yara3 + yara4 + yara5, 1);

double rodney1 = 8.0;
double rodney2 = 8.3;
double rodney3 = 8.2;
double rodney4 = 8.8;
double rodney5 = 8.5;
double rodneySum = Math.Round(rodney1 + rodney2 + rodney3 + rodney4 + rodney5, 1);

double sobu1 = 8.4;
double sobu2 = 9.6;
double sobu3 = 7.3;
double sobu4 = 8.5;
double sobu5 = 7.9;
double sobuSum = Math.Round(sobu1 + sobu2 + sobu3 + sobu4 + sobu5, 1);

double banira1 = 9.0;
double banira2 = 9.2;
double banira3 = 9.8;
double banira4 = 10.0;
double banira5 = 9.7;
double baniraSum = Math.Round(banira1 + banira2 + banira3 + banira4 + banira5, 1);

double yaraScore = Math.Round(yaraSum / currentAssignments, 1);
double rodneyScore = Math.Round(rodneySum / currentAssignments, 1);
double sobuScore = Math.Round(sobuSum / currentAssignments, 1);
double baniraScore = Math.Round(baniraSum / currentAssignments, 1);

Console.WriteLine("Student Grade\n");
Console.WriteLine("\t\tRO\t\tDE");
Console.WriteLine($"Yara:\t{yaraScore}\t\t1,3");
Console.WriteLine($"Rodney:\t{rodneyScore}\t\t2,3");
Console.WriteLine($"Sobu:\t{sobuScore}\t\t2,3");
Console.WriteLine($"Banira:\t{baniraScore}\t\t1,3");
