use AdventureWorks2019
/*question 1*/
select 
* 
from Sales.Customer

/*question 2*/
select 
* 
from Sales.Store
order by [name]

/*question 3*/
select top 10 
* 
from HumanResources.Employee as Employees
where Employees.BirthDate > DATETIMEFROMPARTS(1989,09,28,0,0,0,0)

/*question 4*/
select 
Employees.NationalIDNumber,
Employees.LoginID,
Employees.JobTitle
from HumanResources.Employee as Employees
where RIGHT(Employees.LoginID,1) = 0
order by JobTitle DESC

/*question 5*/
select 
*
from Person.Person as PPerson
where YEAR(PPerson.ModifiedDate) = 2008 
	and PPerson.Title IS NULL
	and PPerson.MiddleName IS NOT NULL

/*
My understanding for question 6 
*/
select
	DepartmentNames.DepartName,
	ID,
	MaxData
from(select distinct
	Department.[Name] as DepartName,
	EmployeeHistory.DepartmentID as ID,
	MAX(EmployeeHistory.EndDate) as MaxData
from HumanResources.Department as Department
RIGHT JOIN HumanResources.EmployeeDepartmentHistory as EmployeeHistory
on Department.DepartmentID = EmployeeHistory.DepartmentID
group by 
	Department.[Name],
	EmployeeHistory.DepartmentID) as DepartmentNames 
where 
	MaxData IS NULL

/*question 6*/
select distinct
	Department.[Name] as DepartName
from HumanResources.Department as Department
INNER JOIN HumanResources.EmployeeDepartmentHistory as EmployeeHistory
on Department.DepartmentID = EmployeeHistory.DepartmentID

/*question 7*/
select 
COUNT(CommissionPct) as CommissionPct
from Sales.SalesPerson 
where CommissionPct>0
group by 
	TerritoryID

/*question 8*/
select
*
from HumanResources.Employee as Employee
where VacationHours = (select MAX(VacationHours) from HumanResources.Employee)

/*question 9*/
select *
from HumanResources.Employee
where 
	HumanResources.Employee.JobTitle LIKE '%Sales Representative%'
	OR HumanResources.Employee.JobTitle LIKE '%Network Administrator%'
	OR HumanResources.Employee.JobTitle LIKE '%Network Manager%'
/*question 10*/
select
Employee.*,
PurchaseOrderHeader.*
from HumanResources.Employee as Employee
LEFT JOIN Purchasing.PurchaseOrderHeader as PurchaseOrderHeader
on Employee.BusinessEntityID = PurchaseOrderHeader.EmployeeID

