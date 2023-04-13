string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalGrade = 0;
totalGrade += course1Credit * course1Grade;
totalGrade += course2Credit * course2Grade;
totalGrade += course3Credit * course3Grade;
totalGrade += course4Credit * course4Grade;
totalGrade += course5Credit * course5Grade;

Console.WriteLine($"Student name:" + studentName + "\n");
Console.WriteLine("Course \t\t\t grade \t\t\t Credit Hours");
Console.WriteLine(course1Name + "\t\t\t\t" + course1Grade + "\t\t\t" + course1Credit);
Console.WriteLine(course2Name + "\t\t\t\t" + course2Grade + "\t\t\t" + course2Credit);
Console.WriteLine(course3Name + "\t\t\t\t" + course3Grade + "\t\t\t" + course3Credit);
Console.WriteLine(course4Name + "\t\t\t" + course4Grade + "\t\t\t" + course4Credit);
Console.WriteLine(course5Name + "\t\t\t\t" + course5Grade + "\t\t\t" + course5Credit);
Console.WriteLine(course1Name + "\t\t\t\t" + course1Grade + "\t\t\t" + course1Credit);


decimal sumGrade = course1Grade + course2Grade + course3Grade + course4Grade + course5Grade;
decimal sumCredit = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
decimal sumTotal = sumGrade + sumCredit;

Console.WriteLine($"Total of grade:" + "\t\t\t\t" + "Total of Credit:");
Console.WriteLine($"{totalGrade}" + "\t\t\t\t\t" + sumCredit );

decimal totalOfAvarege = (decimal)totalGrade / (decimal)sumCredit;
int principal = (int)totalOfAvarege ;
int traling = (int)(totalOfAvarege * 100) - (principal *100);
Console.WriteLine($"Total GPA: {principal}.{traling}");