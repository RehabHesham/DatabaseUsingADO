use iti;

--- Select
--one cell
select [St_Age] from [dbo].[Student] where [St_Id] = 10
select [St_Fname] from [dbo].[Student] where [St_Id] = 10

--multi cell
select [St_Fname] from [dbo].[Student]			-- select column
select * from [dbo].[Student] where [St_Id] = 10  -- select row
select [St_Id],[St_Fname],[St_Lname],[St_Address],[St_Age],[Dept_Id] from [dbo].[Student]						-- select table
select * from [dbo].[Student] where [St_Age]> 23 -- select table

select [Dept_Id],[Dept_Name] from [dbo].[Department]


--- Insert
insert into [dbo].[Student]([St_Fname],[St_Lname],[St_Address],[St_Age],[Dept_Id]) values('omar','Ali','Alex',25,20)

--- Update
update [dbo].[Student] set [St_Fname]='ali', [St_Lname]='omar', [St_Address]='Cairo', [St_Age]=23, [Dept_Id]=10  where [St_Id] = 15

--- delete
delete from [dbo].[Student]  where [St_Id] = 15