// ============================================
// STUDENT INFORMATION
// ============================================

Console.WriteLine("==================================================");
Console.WriteLine("        STUDENT INFORMATION SYSTEM");
Console.WriteLine("==================================================");

Console.Write("Student Number      : ");
string studentNumber = Console.ReadLine();

Console.Write("Full Name           : ");
string fullName = Console.ReadLine();

Console.Write("Age                 : ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Gender              : ");
string gender = Console.ReadLine();

Console.Write("Course              : ");
string course = Console.ReadLine();

Console.Write("Year Level          : ");
string yearLevel = Console.ReadLine();

Console.Write("Section             : ");
string section = Console.ReadLine();

Console.WriteLine();

// ============================================
// PERSONAL INFORMATION
// ============================================

Console.WriteLine("----------- PERSONAL INFORMATION -----------");

Console.Write("Home Address        : ");
string address = Console.ReadLine();

Console.Write("Contact Number      : ");
string contactNumber = Console.ReadLine();

Console.Write("Email Address       : ");
string email = Console.ReadLine();

Console.Write("Guardian Name       : ");
string guardian = Console.ReadLine();

Console.Write("Emergency Contact   : ");
string emergencyContact = Console.ReadLine();

Console.WriteLine();

// ============================================
// ACADEMIC INFORMATION
// ============================================

Console.WriteLine("----------- ACADEMIC INFORMATION -----------");

Console.Write("Adviser Name        : ");
string adviser = Console.ReadLine();

Console.Write("Semester            : ");
string semester = Console.ReadLine();

Console.Write("School Year         : ");
string schoolYear = Console.ReadLine();

Console.Write("Campus              : ");
string campus = Console.ReadLine();

Console.WriteLine();

// ============================================
// SUBJECT GRADES
// ============================================

Console.WriteLine("Enter Student Grades");
Console.WriteLine();

Console.Write("Mathematics        : ");
double math = Convert.ToDouble(Console.ReadLine());

Console.Write("English            : ");
double english = Convert.ToDouble(Console.ReadLine());

Console.Write("Science            : ");
double science = Convert.ToDouble(Console.ReadLine());

Console.Write("Programming        : ");
double programming = Convert.ToDouble(Console.ReadLine());

Console.Write("Database           : ");
double database = Convert.ToDouble(Console.ReadLine());

Console.Write("Web Technologies   : ");
double web = Convert.ToDouble(Console.ReadLine());

Console.Write("Networking         : ");
double networking = Convert.ToDouble(Console.ReadLine());

Console.Write("Physical Education : ");
double pe = Convert.ToDouble(Console.ReadLine());

Console.Write("NSTP               : ");
double nstp = Convert.ToDouble(Console.ReadLine());

Console.Write("History            : ");
double history = Convert.ToDouble(Console.ReadLine());

// ============================================
// COMPUTATIONS
// ============================================

double total =
    math +
    english +
    science +
    programming +
    database +
    web +
    networking +
    pe +
    nstp +
    history;

double average = total / 10;

// ============================================
// DISPLAY REPORT
// ============================================

Console.Clear();

Console.WriteLine("==============================================================");
Console.WriteLine("                 STUDENT GRADE REPORT");
Console.WriteLine("==============================================================");

Console.WriteLine("STUDENT INFORMATION");
Console.WriteLine("--------------------------------------------------------------");

Console.WriteLine($"Student Number : {studentNumber}");
Console.WriteLine($"Full Name      : {fullName}");
Console.WriteLine($"Age            : {age}");
Console.WriteLine($"Gender         : {gender}");
Console.WriteLine($"Course         : {course}");
Console.WriteLine($"Year Level     : {yearLevel}");
Console.WriteLine($"Section        : {section}");

Console.WriteLine();

Console.WriteLine("PERSONAL INFORMATION");
Console.WriteLine("--------------------------------------------------------------");

Console.WriteLine($"Address           : {address}");
Console.WriteLine($"Contact Number    : {contactNumber}");
Console.WriteLine($"Email             : {email}");
Console.WriteLine($"Guardian          : {guardian}");
Console.WriteLine($"Emergency Contact : {emergencyContact}");

Console.WriteLine();

Console.WriteLine("ACADEMIC INFORMATION");
Console.WriteLine("--------------------------------------------------------------");

Console.WriteLine($"Adviser      : {adviser}");
Console.WriteLine($"Semester     : {semester}");
Console.WriteLine($"School Year  : {schoolYear}");
Console.WriteLine($"Campus       : {campus}");

Console.WriteLine();

Console.WriteLine("SUBJECT GRADES");
Console.WriteLine("--------------------------------------------------------------");

Console.WriteLine($"Mathematics         : {math}");
Console.WriteLine($"English             : {english}");
Console.WriteLine($"Science             : {science}");
Console.WriteLine($"Programming         : {programming}");
Console.WriteLine($"Database            : {database}");
Console.WriteLine($"Web Technologies    : {web}");
Console.WriteLine($"Networking          : {networking}");
Console.WriteLine($"Physical Education  : {pe}");
Console.WriteLine($"NSTP                : {nstp}");
Console.WriteLine($"History             : {history}");

Console.WriteLine();

Console.WriteLine("GRADE SUMMARY");
Console.WriteLine("--------------------------------------------------------------");

Console.WriteLine($"Total Grade        : {total}");
Console.WriteLine($"Average Grade      : {average:F2}");

Console.WriteLine();

Console.WriteLine("==============================================================");
Console.WriteLine("          END OF STUDENT GRADE REPORT");
Console.WriteLine("==============================================================");

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();