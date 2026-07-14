
Console.WriteLine("==========================================");
Console.WriteLine("MULTIPLICATION TABLE AND GRADE STATISTICS");
Console.WriteLine("==========================================");

Console.Write("Student ID : ");
string studentId = Console.ReadLine();

Console.Write("Full Name  : ");
string fullName = Console.ReadLine();

Console.WriteLine();
// ===========================
// PART 1 - MULTIPLICATION TABLE
// ===========================

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Multiplication Table");
Console.WriteLine("------------------------------");

for (int i = 1; i <= 10; i++)
{
  Console.WriteLine($"{number} x {i} = {number * i}");
}

Console.WriteLine();

// ===========================
// PART 2 - QUIZ SCORES
// ===========================

Console.Write("How many quizzes did you take? ");
int quizCount = Convert.ToInt32(Console.ReadLine());

double total = 0;
double highest = 0;
double lowest = 0;

for (int i = 1; i <= quizCount; i++)
{
  Console.Write($"Quiz {i} Score : ");
  double score = Convert.ToDouble(Console.ReadLine());

  total += score;

  if (i == 1)
  {
      highest = score;
      lowest = score;
  }

  if (score > highest)
      highest = score;

  if (score < lowest)
      lowest = score;
}

double average = total / quizCount;

string remarks;

if (average >= 95)
  remarks = "Outstanding";
else if (average >= 90)
  remarks = "Excellent";
else if (average >= 85)
  remarks = "Very Good";
else if (average >= 80)
  remarks = "Good";
else if (average >= 75)
  remarks = "Passed";
else
  remarks = "Failed";

Console.Clear();

Console.WriteLine("==========================================");
Console.WriteLine("STUDENT GRADE REPORT");
Console.WriteLine("==========================================");

Console.WriteLine($"Student ID       : {studentId}");
Console.WriteLine($"Student Name     : {fullName}");
Console.WriteLine($"Number of Quizzes: {quizCount}");

Console.WriteLine();

Console.WriteLine($"Total Score      : {total}");
Console.WriteLine($"Average Score    : {average:F2}");
Console.WriteLine($"Highest Score    : {highest}");
Console.WriteLine($"Lowest Score     : {lowest}");

Console.WriteLine($"Remarks          : {remarks}");

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();