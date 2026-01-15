# Expense Tracker - C# Windows Forms Application
A comprehensive desktop application for tracking personal expenses with a user-friendly interface and data visualization capabilities.

# 📊 Features

Core Functionality
Add Expenses: Record new expenses with date, description, category, and amount

View All Expenses: Display all records in a sortable DataGridView

Edit Expenses: Update existing expense entries

Delete Expenses: Remove unwanted expense records

Data Visualization: Pie chart showing expense distribution by category

Monthly Summaries: View expenses filtered by month

User Experience
Intuitive Windows Forms interface

Input validation and error handling

Clear data presentation with search/sort capabilities

Responsive design with visual feedback

# Database Structure
markdown
sql
CREATE DATABASE ExpenseDB;
GO

-- Use the newly created database
USE ExpenseDB;
GO

-- Create Expenses Table
CREATE TABLE Expenses
(
    Id INT IDENTITY(1,1) PRIMARY KEY,      -- Auto-incrementing primary key
    Date DATE NOT NULL,                    -- Date of the expense
    Description NVARCHAR(100) NOT NULL,    -- Expense description (max 100 chars)
    Category NVARCHAR(50) NOT NULL,        -- Expense category (Food, Transport, etc.)
    Amount DECIMAL(10,2) NOT NULL          -- Expense amount (max 999999.99)
);
GO
<img width="1343" height="899" alt="deepseek_mermaid_20260112_c61bb0" src="https://github.com/user-attachments/assets/e5d47732-7d08-46e8-894e-c9cdfe8d7269" />

# 🚀Installation & Setup

# Prerequisites
Windows OS

.NET Framework 4.7.2 or higher

SQL Server Express/LocalDB

Visual Studio 2019 or later (recommended)

# Step-by-Step Setup

1]Clone the Repository

bash
git clone https://github.com/yourusername/expense-tracker-csharp.git
cd expense-tracker-csharp
2]Create Database

Open SQL Server Management Studio

Execute the SQL script provided above

Or use the provided DatabaseSetup.sql file

3]Configure Connection String

csharp
// Update in Form1.cs
string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ExpenseDB;Integrated Security=True;";

4]Build and Run

Open ExpenseTracker.sln in Visual Studio

Build the solution (Ctrl+Shift+B)

Run the application (F5)

# 📁 Project Structure
<img width="582" height="445" alt="image" src="https://github.com/user-attachments/assets/39d1008c-a0d0-4370-8fc9-fdd4368f4af6" />

# 🎨 Application Architecture
<img width="2342" height="1845" alt="deepseek_mermaid_20260112_262fcd" src="https://github.com/user-attachments/assets/0050677f-aa4a-4a66-b754-e239c0f2fe0d" />

# 🖥️ User Interface

# Main Form Layout
<img width="620" height="671" alt="image" src="https://github.com/user-attachments/assets/5bc4c2d0-ef70-4b41-94c9-ccb9fc7641e1" />

# 📝 Code Examples

# Adding an Expense
csharp
private void btnAdd_Click(object sender, EventArgs e)
{
    if (ValidateInput())
    {
        using(SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Expenses(Date, Description, Category, Amount) VALUES(@Date, @Description, @Category, @Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            cmd.Parameters.AddWithValue("@Category", cmbCategory.Text);
            cmd.Parameters.AddWithValue("@Amount", decimal.Parse(txtAmount.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Expense Added!");
            LoadExpenses();
            ClearFields();
        }
    }
}
# Input Validation

csharp
{
private bool ValidateInput()
{
    if (string.IsNullOrWhiteSpace(txtDescription.Text))
    {
        MessageBox.Show("Please enter a description.");
        return false;
    }
    
    if (string.IsNullOrWhiteSpace(cmbCategory.Text))
    {
        MessageBox.Show("Please select a category.");
        return false;
    }
    
    if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
    {
        MessageBox.Show("Please enter a valid amount.");
        return false;
    }
    
    return true;
}
# 🔧 Configuration
Connection Strings
xml
<!-- App.config -->
<connectionStrings>
    <add name="ExpenseTrackerDB" 
         connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=ExpenseDB;Integrated Security=True;"
         providerName="System.Data.SqlClient" />
</connectionStrings>
Categories
Default categories included:

-Food
-Transport
-Bills
-Shopping
-Entertainment
-Healthcare
-Other

# 🧪 Testing
Sample Data
sql
INSERT INTO Expenses (Date, Description, Category, Amount) VALUES
('2024-01-01', 'Lunch at restaurant', 'Food', 25.50),
('2024-01-01', 'Monthly bus pass', 'Transport', 50.00),
('2024-01-02', 'Electricity bill', 'Bills', 120.75),
('2024-01-03', 'Groceries', 'Food', 85.30),
('2024-01-04', 'Movie tickets', 'Entertainment', 40.00);
# Test Cases
.Add new expense with valid data

.Update existing expense

.Delete selected expense

.Clear all input fields

.Load and display chart data

.Handle invalid input gracefully

# 📈 Future Enhancements
Planned Features
User authentication system

Expense filtering by date range

Export to Excel/PDF

Recurring expenses tracking

Budget planning module

Multi-user support

Cloud synchronization

Mobile companion app

Technical Improvements
Implement Repository Pattern

Add unit tests

Implement MVVM pattern

Add logging with Serilog

Dependency injection with Unity Container

# 🤝 Contributing
Fork the repository

Create a feature branch (git checkout -b feature/AmazingFeature)

Commit your changes (git commit -m 'Add some AmazingFeature')

Push to the branch (git push origin feature/AmazingFeature)

Open a Pull Request

# 🆘 Support
For support, please:

Check the Issues page

Create a new issue with detailed description

Include screenshots if applicable

# 🎯 Quick Start Checklist
Install SQL Server Express

Run DatabaseSetup.sql

Update connection string if needed

Build the solution in Visual Studio

Run the application

Add sample data for testing







