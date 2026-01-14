# TicketSystem (VB.NET WinForms)

Lightweight Windows Forms ticket manager that stores ticket records in MongoDB and provides simple pricing, printing, inventory and CRUD operations via the `TicketManager` class (`Ticketmanager.vb`).

## Features
- Pricing by stage (`group_stage`, `quarter_finals`, `semi_finals`, `final`)
- Inventory tracking per stage
- Calculate totals, print ticket summary, update inventory
- Persistent CRUD operations against a MongoDB `Tickets` collection using `MongoDB.Driver`

## Requirements
- Visual Studio 2022
- .NET (Windows Forms / VB.NET) — open the solution in Visual Studio to determine the exact target TFM
- MongoDB running and reachable (default expects `mongodb://localhost:27017`)
- NuGet package: `MongoDB.Driver`

## Quick setup
1. Ensure MongoDB is running locally (or update connection string — see Configuration).
2. Open the solution in Visual Studio 2022.
3. Restore NuGet packages: use __Restore NuGet Packages__ or right-click the solution and choose __Manage NuGet Packages__.
   - Or run in Package Manager Console:
     ```
     Install-Package MongoDB.Driver
     ```
4. Build the solution: use __Build Solution__.
5. Run via __Start Debugging__ or __Start Without Debugging__.

## Configuration
The connection string is currently hard-coded in `Ticketmanager.vb`: