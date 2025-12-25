Description
A small console application demonstrating basic object-oriented design in C#. It models a simple library system with a base LibraryItem class and two derived types: Book and Magazines. The application prints initial items, simulates borrowing an item (toggling availability), and prints updated item details.
Key classes/files
•	Program.cs:12-19:15 — single source file containing:
•	LibraryItem — base class with Title, ItemId, and IsAvailable.
•	Book — derives from LibraryItem, adds Author.
•	Magazines — derives from LibraryItem, adds IssueNumber.
•	program — contains Main(string[]) that creates sample items and demonstrates borrowing.
•	Project file: Assignment1.csproj

Requirements
•	.NET 8 SDK
•	C# 12 (project is set up for .NET 8/C# 12)
Build & Run
From the repository root:
•	Build:
•	dotnet build Assignment1\Assignment1.csproj
•	Run:
•	dotnet run --project Assignment1\Assignment1.csproj

What the program does
•	Creates two Book objects and one Magazines object.
•	Displays initial item details.
•	Simulates borrowing book1 by setting IsAvailable = false.
•	Shows updated availability and prints updated details.
Sample output (trimmed)

Library Management System
------|------- 
Initial Library Items:
------|-------
Book Details 
Item ID:101 
Title : Pather Panchali 
Available: True 
Author Name:Bibhutibhushan Bandyopadhyay ...
Borrowing Process: ------|-------
Before borrowing: Book 'Pather Panchali' - Available: True
After borrowing: Book 'Pather Panchali' - Available: False
