Create a Console Application that asks the user for student information, computes the tuition fees, applies a scholarship discount (if applicable), determines the student's academic standing, and displays an enrollment summary.

Ask the user to enter the following information:
Student ID
Full Name
Age
Ask the user to select a course using a switch statement.
Choices:
BSIT
BSCS
BSIS
BSEMC

Display the selected course.

Ask the user to select a year level using a switch statement.
Choices:
First Year
Second Year
Third Year
Fourth Year

Display the selected year level.

Ask the user to enter the following:
Tuition Fee
Miscellaneous Fee
Laboratory Fee

Compute the Total Fees.

Formula:
Total Fees = Tuition Fee + Miscellaneous Fee + Laboratory Fee

Ask the user if they have a scholarship (Y/N).

If the answer is Yes, ask for the scholarship percentage (25%, 50%, 75%, or 100%).

Compute the following:

Scholarship Discount = Total Fees × (Scholarship Percentage / 100)

Remaining Balance = Total Fees − Scholarship Discount

If the answer is No:

Scholarship Discount = 0

Remaining Balance = Total Fees

Example:

Total Fees = 25,000

Scholarship Percentage = 50%

Scholarship Discount = 25,000 × (50 / 100)

Scholarship Discount = 12,500

Remaining Balance = 25,000 − 12,500

Remaining Balance = 12,500

Ask the user to enter their General Average.

Determine the Academic Standing using if...else if.

95–100 = Outstanding

90–94 = Excellent

85–89 = Very Good

80–84 = Good

75–79 = Passed

Below 75 = Failed

Examples:

Average = 96 → Outstanding

Average = 91 → Excellent

Average = 87 → Very Good

Average = 82 → Good

Average = 78 → Passed

Average = 70 → Failed

Ask the user to select a payment method using a switch statement.

Choices:

Cash
Installment
Online Payment

Display the selected payment method.

At the end of the program, display the following information:

Student ID
Full Name
Age
Selected Course
Selected Year Level
Total Fees
Scholarship Discount
Remaining Balance
General Average
Academic Standing
Payment Method

Requirements:

Use variables to store all user inputs.
Use arithmetic operators to perform all calculations.
Use if / else if statements to determine the scholarship computation and academic standing.
Use switch statements to determine the selected course, year level, and payment method.
Display all information and computed results in a clear and organized format.