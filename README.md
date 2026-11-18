# University of Kisubi - Hostel Management System (VB.NET WinForms)

## Run it
1. Open `KisubiHostel.vbproj` in Visual Studio (Insiders). Requires the .NET 8 SDK with the
   ".NET desktop development" workload. (To use a newer SDK, change `net8.0-windows` in the .vbproj.)
2. Press F5. NuGet restores `Microsoft.Data.Sqlite` automatically; the database
   (`kisubi_hostel.db`) is created next to the .exe on first run, with sample hostels/rooms.

## Default logins (change them in System Users after first login)
| Role     | Username | Password    |
|----------|----------|-------------|
| Admin    | admin    | admin123    |
| Warden   | warden   | warden123   |
| Bursar   | bursar   | bursar123   |
| Security | security | security123 |

## Modules
Dashboard, Students, Room Applications, Hostels, Rooms & Beds, Allocation/Check-in/Check-out,
Fees & Payments (auto receipt numbers), Fines & Damages, Visitors Log, Leave/Exeat, Complaints,
Maintenance, Inventory & Assets, Hostel Staff, Notice Board, 15 Reports (export to CSV/Excel),
System Users (role-based menus), Activity Log.

## Built-in rules
Room capacity and "under maintenance" checks, one active room per student, male/female hostel
matching, no negative payments, auto check-out dates, overdue exeat report, fee balance report.

## Editing the forms in the Visual Studio designer
Every screen is a real Windows Form with a `.Designer.vb` file. In Solution Explorer double-click
e.g. `StudentsForm.vb` (or right-click > View Designer) to drag, resize, recolour or add controls.
- Colours used: Maroon (122,31,43), Dark Navy (11,31,75), Mustard (228,169,19), Cream (251,247,234).
- Data screens (Students, Rooms, Payments ...) are linked to the database in the form's `_Load` event with
  `_engine.Bind("DatabaseColumn", "Caption", controlName, required, default, lookupSql)`.
  To add a field: add the column to the table in `Db.vb`, drop a control on the form, add one `Bind` line.
  The control type decides the field type (TextBox, NumericUpDown, DateTimePicker, ComboBox).
- Drop-down choices (Status, Gender ...) are the ComboBox `Items` collection - edit them in the Properties window.
- The logo is loaded from `logo.png` at run time, so it appears when you run the app (not in the designer).
- Build the project once (Ctrl+Shift+B) before opening a form in the designer.

## Files
Theme.vb (colours) | Db.vb (database + schema) | CrudEngine.vb (save/search/delete logic) | Rules.vb (validation rules)
ModuleFactory.vb (menu key -> form) | *Form.vb + *Form.Designer.vb (one pair per screen)
