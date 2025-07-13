
# C# Practice Tasks Using Return-Based Functions (Part 5)  
### Clean, Testable, Reusable Code Using `return`

---

## 📁 File Structure:
- `Program.cs` → Calls the return-based functions and prints results.
- `Tasks.cs` → Contains methods that return values instead of printing them.
- `ExamplesForTrainer.cs` → Demonstrates difference between `return` vs `void`.
- `README.md` → Explains use case and advantages of return-based methods.

---

## 🧠 Why Use `return`?

| Feature                 | `void` method                         | `return` method                    |
|--------------------------|----------------------------------------|-------------------------------------|
| Reusability              | ❌ Must be rewritten or copied          | ✅ Can be reused anywhere           |
| Testability              | ❌ Hard to test output                  | ✅ Easy to test with inputs/outputs |
| Flexibility              | ❌ Output always printed to console     | ✅ Return value can be reused       |
| Clean code               | ❌ More side effects                    | ✅ Fewer side effects               |

---

## ✨ Examples:

### Using `return`:
```csharp
double bmi = tasks.CalculateBMI(1.75, 85);
Console.WriteLine("BMI: " + bmi);
```

### Using `void`:
```csharp
tasks.DisplayBMI(1.75, 85); // Must print inside function
```

---

## 🎓 Trainer Notes:
Check `ExamplesForTrainer.cs` for a clear explanation comparing:
- `int MultiplyReturn(int a, int b)`
- `void MultiplyAndDisplay(int a, int b)`

---

## 👨‍💻 Created by  
**Mohamed Alswaify**  
🌐 Website: [mohamed-alswaify.com](https://mohamed-alswaify.com)  
🔗 GitHub: [github.com/mohamedalswaify](https://github.com/mohamedalswaify)
