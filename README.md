# Clinic Appointment Management System

A clinic management system that saves time for receptionists and doctors by automating appointment scheduling, preventing double-booking, and generating daily reports.

## Key Features

- Manage patient records with automated file number generation
- Maintain doctor profiles with specialty assignments
- Schedule and track patient appointments
- Prevent double-booking conflicts
- Prevent duplicate appointments for active patient-doctor pairs
- Generate daily appointment reports
- Process payments for completed appointments
- Cancel appointments when needed

## Technologies & Tools

**Backend:**
- C# (.NET Framework 4.8)
- ADO.NET for database operations
- SQL Server with advanced features:
  - Stored Procedures
  - Transactions with HOLDLOCK for concurrency control
  - Output parameters
  - Dynamic SQL with variables and control flow

**Frontend:**
- WinForms
- Custom form dragging using Windows API (User32.dll)
- Event-driven UI components

**Architecture & Patterns:**
- 3-Tier Architecture (Presentation → Business Logic → Data Access)
- Data Transfer Objects (DTOs) for layer communication
- Result Pattern (OperationResult) for consistent error handling
- Repository/Service Layer pattern

**Database Design:**
- Normalized relational schema
- Foreign key relationships
- Audit columns (CreatedAt, UpdatedAt, CreatedByUserID)

## Technical Highlights

### 1. Preventing Double-Booking with Database Locking
In a multi-user clinic environment, two receptionists could simultaneously attempt to book the same appointment time slot for a doctor. Both patients would show up expecting to see the doctor, forcing staff to resolve the conflict on the spot. Using HOLDLOCK, the system locks the appointment slot so nobody else can book it while checking availability, ensuring only one booking succeeds.

### 2. Reusable Search Component with Event-Driven Architecture
The application needed to search for both patients and doctors in multiple screens. Instead of duplicating search code, I created a reusable SearchControl component that raises events to notify the parent form when a search is performed. This approach follows DRY principle, making the codebase more maintainable and allowing the same component to handle different search contexts.

### 3. Business Logic: Duplicate Appointment Prevention
The system enforces a business rule that prevents patients from having multiple active appointments with the same doctor. This prevents scheduling confusion and ensures appointment slots are used efficiently. The validation is implemented in the stored procedure level, checking for existing active appointments (status = Scheduled) before allowing a new booking for the same patient-doctor combination.

## Screenshots

### 1. Appointments Management Dashboard
*Shows the main appointments list with filtering, status counts, and context menu actions*
[Screenshot placeholder - add image]

### 2. Add New Appointment
*Demonstrates the reusable search controls for patient and doctor selection, with date/time pickers*
[Screenshot placeholder - add image]

### 3. Patient Management
*Patient records list with search and file number display*
[Screenshot placeholder - add image]

### 4. Add Payment
*Payment processing screen showing completed appointment details and payment options - highlights the business logic flow*
[Screenshot placeholder - add image]

### 5. Daily Appointments Report
*Operational report with status breakdown and date filtering*
[Screenshot placeholder - add image]

## Setup Instructions

### Prerequisites
- Visual Studio 2022 (or later)
- SQL Server Developer Edition (or Express)
- .NET Framework 4.8

### Database Setup
1. Open SQL Server Management Studio (SSMS)
2. Create a new database named `Clinic_Appointment_System`
3. Run the `DatabaseSetup.sql` script to create tables and stored procedures

### Application Setup
1. Clone this repository
2. Open the solution in Visual Studio
3. Update the connection string in `App.config` if needed:
```xml
  <connectionStrings>
		<add name="ClinicAppointment" connectionString="Server=.;Initial Catalog=Clinic_Appointment_System;Integrated Security=True" providerName="System.Data.SqlClient"/>
	</connectionStrings>
```
   - Replace `Server=.` with your SQL Server instance name if different
   - Ensure Windows Authentication (Integrated Security) is enabled, or update with SQL credentials

4. Build and run the application

## Future Enhancements (V2)

- **User Management System**: Implement role-based authentication with login functionality for admins, receptionists, and doctors
- **Medical Records**: Add capability for doctors to document diagnosis, prescriptions, and treatment notes for each appointment
- **Multiple Payment Support**: Allow partial payments and payment installments for appointments
- **SMS/Email Notifications**: Send appointment reminders to patients automatically
- **Doctor Availability Management**: Track doctor schedules, working hours, and time-off

## License & Copyright

© 2025 Ahmed Elhebir. All rights reserved.

This project is licensed under the MIT License - see the LICENSE file for details.

## Contact

Ahmed Elhebir  
Email: ahmed.elheber010@gmail.com  
LinkedIn: https://linkedin.com/in/ahmed-elhebir  
Location: Riyadh, Saudi Arabia  
