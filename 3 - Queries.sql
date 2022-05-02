--1. Select all Students from groups 101,105,106
select * from Student
where GroupID = 101 
or GroupID = 105
or GroupID = 106

--2. Select all Students from groups 102,104,106 
--who has bursuary more than 300
select * from Student
where GroupID = 102 
or GroupID = 104
or GroupID = 106
and Bursary > 300

--3.	Select all students with name starts with “D” with average mark from 7.4 to 9.5.
select s.StudentID,s.Name, AVG(sj.Mark) as Average_Mark
from Student s, StudentSubject sj
where Name like 'D%' 
and s.StudentID = sj.StudentID 
group by s.Name, s.StudentID
Having AVG(sj.Mark) between 7.4 and 9.5

--4. Select all students with name letter name "O" and date of birth should
--be in the following format DD MM YYYY
--select *,FORMAT(Birthday, 'dd.MM.yyyy') as new_date from Student
select StudentID, Name,DATENAME(DAY, Birthday) + ' ' + DATENAME(month, Birthday) + ' ' + DATENAME(year, Birthday) as Birthday 
from Student
where Name like '%O%'

--5. Select all students who gets bursuary bonus and who's date of birth after Jan 1, 1988
select *
from Student
where Bonus is not null
and Birthday > CAST(N'1988-01-01' AS Date) --!!! не знал что сработает

--6 Show unique burssaries of students from Gomel
select distinct s.Name, s.Bursary, c.Name
from Student s, City c
where s.CityID = c.CityID and s.CityID = 2

--7 Select all students from Vitevsk and sort them by income
select s.studentID, s.Name, s.Bursary, c.Name CityName
from Student s, City c
where s.CityID = c.CityID and c.CityID=5
order by Bursary

--8 Select all students whose date of birth from Jan 1, 1990 to Jan 1, 1991, city where 
--are they from and sort them by income descending
select studentID, Name, Birthday, Bursary
from student
where Birthday between CAST(N'1990-01-01' AS Date) and CAST(N'1991-01-01' AS Date)
order by Bursary desc

--9 Select students from group 102 and their bursuary like a percent from max bursuary.
 select (s.Bursary*100)/Max(ss.Bursary) BursaryPercent , s.Name
 from Student s, Student ss
 where s.GroupID = 102
 group by s.Bursary, s.Name

 --10 Show student who's not from the following cities: Minsk, Gomel, Grodno.
 --Also show students whose city has not been identified. Sort results alphabetically.

 select s.StudentID, s.Name, c.Name
 from Student s left join City c
 on s.CityID = c.CityID
 where c.Name not in ('Vitebsk', 'Minsk', 'Grodno')
 or c.Name is null
 order by s.Name

 --11 Show students who has special symbol in the name
 select Name
 from student
 where Name like '%[^A-Z]%'

 --12 Show students and their bursary who was born before the Apr 23, 1984.
 --Sort results by group and name
select Name, GroupID, Bursary, Birthday
from student
where Birthday < CAST(N'1984-04-23' AS Date)
order by GroupID, Name

--13 Show teachers and the subject taught by him and its duration
select T.Name, s.Name, s.Duration
from Teacher T, Subject s
where t.SubjectID = s.SubjectID

--14 Show group name, their university name and city of university
select g.name GroupName, u.Name NameUniversity, c.Name City
from dbo.[Group] g, University u, City c
where g.universityID = u.universityID and u.CityID = c.CityID

--15 Show group students, their average mark, city 
--and group name where average mark not more than 6.2

select s.GroupID,s.Name, c.Name, g.Name ,round(AVG(sj.Mark),3) as Average_Mark
from Student s, StudentSubject sj, City c, StudentSubject sj2, [Group] g
where s.StudentID = sj.StudentID and s.CityID = c.CityID and sj.StudentID = sj2.StudentID
and s.GroupID = g.GroupID
group by s.GroupID, c.Name, s.Name, g.Name
Having AVG(sj.Mark) <= 6.2


select * from student
select * from [Group] g, StudentSubject sj2


--16 Show students, their university and city where city 
--name has population not more than 340000 
--and group name contains the following text “Uni”.

select * 
from student s, City c
where s.CityID = c.CityID and c.Population < 340000


select s.Name, u.Name University, c.Name
from student s, [Group] g, University u, City c
where g.GroupID =s.GroupID 
and g.UniversityID = u.UniversityID
and s.CityID = c.CityID
and c.Population <= 340000
and u.Name like '%Uni%'

--17.	Show only those teachers, their wage 
--and university name who has wage not less than 750.

select t.Name, ut.Wage, u.Name
from teacher t, UniversityTeacher ut, University u
where t.teacherID = ut.teacherID
and ut.UniversityID = u.UniversityID
and ut.Wage > 750

--18.	Show teachers, their wage, subjects and groups in which he lectures. 
--Show only groups relate to Minsk and Grodno, exclude English subject. 
--Sort results by subject and group number.

select t.Name, s.Name, ut.Wage, g.GroupID 
from Teacher t, UniversityTeacher ut, [Group] g, University u, Subject s
where t.TeacherID = ut.TeacherID and ut.UniversityID = g.UniversityID 
and u.UniversityID = ut.UniversityID 
and u.CityID in (1,3)
and s.SubjectID =t.SubjectID
and s.Name not like 'English'
order by g.GroupID