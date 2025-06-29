EXEC sp_InsertEmployee
    @FirstName = 'Ariana',
    @LastName = 'Green',
    @DepartmentID = 2,
    @Salary = 6200.00,
    @JoinDate = '2024-06-01';
    
EXEC sp_GetEmployeesByDepartment @DeptID = 2;
