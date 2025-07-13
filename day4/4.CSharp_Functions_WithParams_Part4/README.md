
# C# Practice Tasks with Function Parameters  
### Using Methods That Accept Parameters (Part 4)

This version demonstrates how to pass inputs (name, salary, marks, etc.) as **parameters** to methods instead of using `Console.ReadLine()`.

---

## 📁 File Structure:
- `Program.cs` → Contains `Main()` and sends sample data to each function.
- `Tasks.cs` → Functions are declared with parameters (e.g. name, salary, mark, etc.).
- `README.md` → Explains the benefit of parameterized functions.

---

## 🧠 Why Use Parameters?

| Without Parameters               | With Parameters                      |
|----------------------------------|---------------------------------------|
| Requires user input from console| Input can come from any source        |
| Tightly coupled to Console       | Reusable and testable with any data   |
| Not suitable for unit testing    | ✅ Easy to test                        |
| Harder to maintain/extend        | ✅ Clean and modular                   |

---

## ✨ Function Examples:

```csharp
public void Task1_EmployeeSalary(string employeeName, double salary)
public void Task2_StudentGrading(string studentName, double mark, double fullMark)
public void Task3_PatientBMI(string patientName, double height, double weight)
```

Each function is called from `Main()` with actual values, like:

```csharp
tasks.Task1_EmployeeSalary("Ahmed", 12000);
```

---

## 👨‍💻 Created by  
**Mohamed Alswaify**  
🌐 Website: [mohamed-alswaify.com](https://mohamed-alswaify.com)  
🔗 GitHub: [github.com/mohamedalswaify](https://github.com/mohamedalswaify)
