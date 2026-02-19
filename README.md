# Library Management System – Arbeidskrav 1
Gokstad Akademiet – 2nd Semester

## Description
This project is a simple Library Management System developed in C#.  
The system demonstrates Object-Oriented Programming principles such as:

- Inheritance
- Encapsulation
- Abstraction
- Polymorphism
- Use of Lists and Collections

The system allows the library to manage media items, users, and loans.

---

## Features

### Media Types
The system supports multiple media types:

- Book
- AudioBook
- EBook
- Magazine

Each media item:
- Has a unique MediaID (M001, M002…)
- Can be borrowed and returned
- Has a specific loan period

---

### Users

Two user types are implemented:

- Member
- Staff

Each user:
- Has a unique UserID (U001, U002…)
- Has name and validated email
- Can borrow media depending on rules

---

### Loan System

The Loan class handles:
- Loan creation
- Due date calculation
- Return handling
- Late check functionality

Each loan:
- Has a unique LoanID (L001, L002…)
- Stores LoanDate and DueDate
- Tracks ReturnedDate

---

### Library Class

The Library class manages:

- Adding media
- Adding users
- Borrowing media
- Returning media
- Searching media by title

---

## How to Run the Program

1. Open terminal in the project folder
2. Run:



---

## Technologies Used

- C#
- .NET
- Visual Studio Code

---

## Author

Babita Sharma
2nd Semester – Backend Development
Gokstad Akademiet
