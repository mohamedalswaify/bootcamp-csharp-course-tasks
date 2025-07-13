
# C# Static vs Non-Static Functions – Practical Example

This project contains a practical comparison between `static` and `non-static` methods in C# to help you decide **when to use each**.

---

## 🧪 Code Structure:

### ✅ Static Method:
```csharp
public static double StaticAdd(double a, double b)
```
- Belongs to the class `Calculator` itself.
- Called without creating an object.
- Ideal for utility/helper methods.
- Example usage:
```csharp
Calculator.StaticAdd(10, 20);
```

---

### ✅ Non-Static (Instance) Method:
```csharp
public double InstanceMultiply(double a, double b)
```
- Belongs to a specific object (instance of `Calculator`).
- Requires creating an object to use.
- Used when the method may interact with object-level data.
- Example usage:
```csharp
Calculator calc = new Calculator();
calc.InstanceMultiply(5, 4);
```

---

## 🎯 When to Use Which?

| Use Case                        | Use `static`            | Use non-`static`              |
|----------------------------------|--------------------------|-------------------------------|
| No object data required          | ✅                        | ❌                             |
| Accessing shared/class-level logic | ✅                        | ❌                             |
| Managing object-specific state   | ❌                        | ✅                             |
| Reusable utility logic           | ✅                        | ❌                             |

---

## 👨‍💻 Created by  
**Mohamed Alswaify**  
🌐 [mohamed-alswaify.com](https://mohamed-alswaify.com)  
🔗 [github.com/mohamedalswaify](https://github.com/mohamedalswaify)
