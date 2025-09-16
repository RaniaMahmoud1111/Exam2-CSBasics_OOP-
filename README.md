# Examination System (C# Console Application)

## 📌 Overview
This project is a **console-based Examination System** built with **C#**.  
It simulates an exam environment where subjects contain exams, and exams contain different types of questions.  
The system demonstrates **OOP principles** such as **inheritance, polymorphism, interfaces, and constructor chaining**.

---

## 🛠 Features
- **Question Types**
  - True/False (Final Exam only)
  - Multiple Choice Questions (MCQ)
- **Exam Types**
  - **Final Exam**: Shows questions, answers, and final grade.
  - **Practical Exam**: Shows the correct answers after completion.
- **Subject Management**
  - Each subject has an exam assigned.
  - Supports creating exams dynamically.
- **OOP Concepts**
  - Base `Question` class with derived types (`TrueFalseQuestion`, `MCQQuestion`).
  - `Answer` class for handling answer options.
  - Base `Exam` class with `FinalExam` and `PracticalExam` specializations.
  - Implements `ICloneable`, `IComparable`, `ToString()`.
  - Constructor chaining.

---

