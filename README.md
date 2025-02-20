# Basic Information

This is a simple C# console application that collects and displays basic user information, 
including name, surname, and age. The program includes error handling for invalid age input.

## Features

- Collect user details:
  - Name
  - Surname
  - Age
- Display the entered details in a formatted message
- Error handling for invalid age input (format exceptions)

### Example

```
Enter your name: John
Enter your surname: Doe
Enter your age: 25
********************************
Name: John
Surname: Doe
Age: 25
********************************
```

### Error Handling

If you enter an invalid age (e.g., a non-numeric value), the program will display an error message:

```
Error: The input for age is not a valid number.
Details: Input string was not in a correct format.
```

---
