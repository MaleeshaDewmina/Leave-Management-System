# Known limitations (source inspection only)

This repository is an academic snapshot. The GitHub-ready preparation excludes generated output and machine-specific SQL Server computer names. It does not claim the project builds or runs successfully.

## Database schema
- `EmployeeLoginForm.cs` authenticates with `Employee_Details (Employee_ID, Password)`.
- `ApplyLeaveForm.cs` inserts into `TableLeave (Employee_ID, Leave_Type, Reason, Leave_Start, Leave_End)`.
- `ViewLeaveStatusForm.cs` queries `TableLeave` by `Employee_ID`.
- `DeleteLeaveForm.cs` has handlers that delete from `TableEmployee` and `TableLeave`, respectively; the `TableEmployee` handler appears inconsistent with a leave deletion action.
- `Leave_Apply.cs` inserts into a different `Leave_Table`, with an `Employee_Name` and `Status`.
- `ApplyLeaveForm.CalculateRemainingLeaves` reads `Leaves (LeaveStart, LeaveEnd, LeaveType, EmployeeID)`, which differs from the `Leaves` typed DataSet schema and `TableLeave` requests.
- Some generated TableAdapters expect tables and columns beyond what the starter SQL schema supplies.

## Security
- The employee-login query concatenates user input, allowing SQL injection.
- Employee password comparison is plaintext, without hashing or access-control hardening.
- Additional SELECT/DELETE queries concatenate employee ID input; use parameters consistently.
- Dispose `SqlConnection`, `SqlCommand` and readers reliably; some code paths leave connections open when the user cancels an operation.

## Functionality and validation
- The delete action removes all leave rows for an employee rather than a selected leave ID.
- `int.Parse` can throw when employee-ID input is blank or non-numeric.
- Null leave-type selection may throw; the date range is not validated.
- `EmployeeLoginForm` navigates directly to `ApplyLeaveForm` rather than `EmployeeMainForm`.
- Leave allowances are hardcoded (30 annual / 12 casual / 6 monthly short) and the balance calculation queries a different table from submitted leaves.
- Several buttons and form handlers are placeholders.
- `LeaveForm.cs` in `docs/legacy` was not compiled in the supplied `.csproj` and contains incomplete duplicate-class/handler code. The reference copy has `.txt` extension to avoid confusing tooling.

## Recommended next development
1. Consolidate the database into one employee table and one leave-request table.
2. Introduce parameterized queries and hashed credentials.
3. Use per-user session state, approval statuses, and deletion by leave ID with confirmation.
4. Apply form validation, error handling, and connection disposal.
5. Rebuild generated typed DataSets or replace with a small repository/service layer.
6. Add a smoke test for login, create, view, cancel and balance calculation.
