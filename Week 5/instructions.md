# Laboratory Activity: Multiplication Table and Grade Statistics Generator

Create a Console Application that asks the user for their information, displays a multiplication table, records quiz scores, computes statistics, and determines the student's remarks.

## Instructions

1. Ask the user to enter the following information:
   - Student ID
   - Full Name

2. Ask the user to enter a number.

   Using a **for loop**, display the multiplication table of the entered number from **1 to 10**.

   **Example:**

   If the user enters **5**, the output should be:

   - 5 × 1 = 5
   - 5 × 2 = 10
   - 5 × 3 = 15
   - ...
   - 5 × 10 = 50

   **Hint:**
   - Use a **for loop** that starts at **1** and ends at **10**.
   - Multiply the entered number by the loop counter.

3. Ask the user how many quizzes they have taken.

   Using another **for loop**, ask the user to enter the score for each quiz.

   Example:

   - Quiz 1 Score
   - Quiz 2 Score
   - Quiz 3 Score

   While accepting the scores, compute the following:

   - Total Score
   - Highest Score
   - Lowest Score

   After all scores have been entered, compute:

   - Average Score

   **Hints:**
   - Initialize **Total Score** to **0**.
   - Initialize **Highest Score** and **Lowest Score** using the **first quiz score**.
   - Add each score to the total.
   - Compare each score to determine the highest and lowest.
   - Compute the average using:

     ```
     Average Score = Total Score ÷ Number of Quizzes
     ```

4. Determine the student's remarks using **if...else if** based on the Average Score.

   Use the following grading scale:

   | Average Score | Remarks |
   |---------------|---------|
   | 95 – 100 | Outstanding |
   | 90 – 94 | Excellent |
   | 85 – 89 | Very Good |
   | 80 – 84 | Good |
   | 75 – 79 | Passed |
   | Below 75 | Failed |

   **Examples:**

   - Average = 97 → Outstanding
   - Average = 92 → Excellent
   - Average = 88 → Very Good
   - Average = 82 → Good
   - Average = 77 → Passed
   - Average = 70 → Failed

   **Hint:**
   - Start checking from the **highest grade range** down to the lowest.
   - Use an **if...else if...else** statement.

5. Display the following information:

   - Student ID
   - Full Name
   - Number of Quizzes
   - Total Score
   - Average Score (display up to 2 decimal places)
   - Highest Score
   - Lowest Score
   - Remarks

## Requirements

- Use variables to store all user inputs.
- Use **two `for` loops**:
  - One for the multiplication table.
  - One for entering quiz scores.
- Use arithmetic operators to compute the total and average.
- Use **if...else if** statements to determine the remarks.
- Display all results clearly in a formatted output.

## Bonus Challenge (Optional)

After displaying the report, ask the user if they want to process another student.

- If the answer is **Y**, repeat the program.
- If the answer is **N**, display a thank-you message and terminate the program.

**Hint:** You may use a **do...while** or **while** loop if you have already learned it. Otherwise, you may skip this part.