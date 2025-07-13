
# C# Practice Tasks with Function Separation (Folder 2)  
### Functions in Separate File + Main Calls

This project demonstrates clean separation of logic by placing each function (task) in a separate class file, and calling those functions from the `Main` method.

---

## 📁 File Structure:
- `Program.cs` → Contains only `Main()` which calls the task functions.
- `Tasks.cs` → Contains all the functions using `void` methods.
- `README.md` → Explanation of project structure and objectives.

---

## ✅ Task 1: Employee Salary Classification

**🎯 Objective:**

- Ask the user to enter their **name** and **monthly salary**.
- Calculate the **annual salary**.
- Display the name, monthly salary, and annual salary.
- Classify the salary using `if / else if / else` as follows:

| Salary Range         | Classification      |
|----------------------|---------------------|
| 15,000 or more       | High Salary         |
| 10,000 to < 15,000   | Normal Salary       |
| 5,000 to < 10,000    | Low Salary          |
| Less than 5,000      | Very Low Salary     |

**🧠 Function Name:**  
`Task1_EmployeeSalary();`

---

## ✅ Task 2: Student Grading System

**🎯 Objective:**

- Ask the student to enter:
  - **Name**
  - **Obtained Mark**
  - **Full Mark**
- Calculate the **percentage**:
  ```
  percentage = (mark / fullMark) * 100
  ```
- Display the name, mark, full mark, and percentage.
- Classify the grade based on percentage:

| Percentage Range     | Grade         |
|----------------------|---------------|
| 85% or more          | Excellent     |
| 75% to < 85%         | Very Good     |
| 65% to < 75%         | Good          |
| 50% to < 65%         | Pass          |
| Below 50%            | Failed        |

**🧠 Function Name:**  
`Task2_StudentGrading();`

---

## ✅ Task 3: Patient BMI Category

**🎯 Objective:**

- Ask the patient to enter:
  - **Name**
  - **Height** (in meters)
  - **Weight** (in kilograms)
- Calculate the **BMI** using:
  ```
  BMI = weight / (height * height)
  ```
- Display the name, height, weight, and BMI.
- Classify BMI based on result:

| BMI Value Range      | Category       |
|----------------------|----------------|
| Less than 18.5       | Underweight    |
| 18.5 to < 25         | Normal Weight  |
| 25 to < 30           | Overweight     |
| 30 or more           | Obese          |

**🧠 Function Name:**  
`Task3_PatientBMI();`

---

## 👨‍💻 Created by  
**Mohamed Alswaify**  
🌐 Website: [mohamed-alswaify.com](https://mohamed-alswaify.com)  
🔗 GitHub: [github.com/mohamedalswaify](https://github.com/mohamedalswaify)
