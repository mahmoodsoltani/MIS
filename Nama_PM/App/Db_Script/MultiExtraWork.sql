USE [Nama_MIS]
GO

/****** Object:  StoredProcedure [dbo].[Rp_MultiEzafeKar]    Script Date: 06/22/2012 19:19:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [dbo].[Rp_MultiEzafeKar] 
@Srl_Ashkhas as nvarchar(max),
@Fromdate as nvarchar(10),
@ToDate as nvarchar(10)
as
BEGIN
select * from (
select Pm_WorkFrom_Detail.WorkFormTarikh as تاریخ,Pm_Ashkhas.Srl ,Pm_Ashkhas.Name+' '+Pm_Ashkhas.Family  as [نام فرد],
Pm_Ashkhas.PersonalCode as [کد شناسایی],Pm_WorkFrom_Detail.WorkFormNo as [فرم کار],
convert(nvarchar,Pm_WorkForm_Master .No) as [شماره],
Pm_HazineCode.Code  as [کد هزینه],pm_post.name as [محل فعالیت],
isnull(EzafeKAr,'00:00') as [اضافه کار]
,isnull(EzafeKarTaradod,'00:00') AS [اضافه کار تردد],
isnull(convert(nvarchar(8),(DATEDIFF(Minute, '0:00:00',convert(time(0),MazadEzafeKar  )))/60 )+':'+
convert(nvarchar(8),(DATEDIFF(Minute, '0:00:00',convert(time(0),MazadEzafeKar )))%60 ),'00:00')
as [کسر کار],
isnull(convert(nvarchar(8),(DATEDIFF(Minute, '0:00:00',convert(time(0),EzafeKAr ))+
DATEDIFF(Minute, '0:00:00',convert(time(0),EzafeKarTaradod ))-
DATEDIFF(Minute, '0:00:00',convert(time(0),MazadEzafeKar  )))/60 )+':'+
convert(nvarchar(8),(DATEDIFF(Minute, '0:00:00',convert(time(0),EzafeKAr ))+
DATEDIFF(Minute, '0:00:00',convert(time(0),EzafeKarTaradod ))-
DATEDIFF(Minute, '0:00:00',convert(time(0),MazadEzafeKar  )))%60 ),'00:00')
as[جمع اضافه کار],
(select isnull(COUNT(*),0) from Pm_taghvim where TYPE IN(2,3)
ANd Pm_taghvim.Tarikh = Pm_WorkFrom_Detail.WorkFormTarikh ) as تعطیل
   from Pm_WorkFrom_Detail JOIN Pm_WorkForm_Master ON Srl_Pm_WorkForm_Master =Pm_WorkForm_Master .Srl 
    JOIN Pm_Ashkhas ON (Pm_Ashkhas.Srl in  (select * from split(@Srl_Ashkhas,','))   OR @Srl_Ashkhas='-1')AND
Pm_WorkFrom_Detail.WorkFormTarikh >= @FromDate AND
Pm_WorkFrom_Detail.WorkFormTarikh <= @ToDate AND
Srl_Pm_Ashkhas  =Pm_Ashkhas.Srl LEFT JOIN Pm_HazineCode ON
Pm_WorkFrom_Detail.Srl_HazineCode = Pm_HazineCode.Srl LEFT JOIN Pm_Post ON
Pm_WorkFrom_Detail.Srl_Pm_Post_From  = Pm_Post.Srl 
 union 
select Pm_TimeCard.Tarikh as تاریخ,Pm_Ashkhas.Srl ,Pm_Ashkhas.Name+' '+Pm_Ashkhas.Family as [نام فرد],
Pm_Ashkhas.PersonalCode as [کد شناسایی],
'' as [فرم کار],
case EndTimeExtraWork
when '00:00:00' then 
	(case HolidayExtraWork
		when '00:00:00' then ''
		when '0:0' then ''
		else convert(nvarchar,isnull(TimeCardNumber,''))
		end )
when '0:0' then 
	(case HolidayExtraWork
		when '00:00:00' then ''
		when '0:0' then ''
		else convert(nvarchar,isnull(TimeCardNumber,''))
		end )
else

convert(nvarchar,isnull(TimeCardNumber,''))
end
as [شماره],CodeHazine as [کد هزینه],ActivityPlace  as [محل فعالیت],
convert(nvarchar,ISNULL(case (select isnull(COUNT(*),0) from PM_taghvim where TYPE IN(2,3)
ANd PM_taghvim.Tarikh  = Pm_TimeCard .Tarikh )
when 0 then 
convert(nvarchar,(DATEDIFF(Minute,'0:00:00',convert(time(0),ISNULL(BeginTimeExtraWork,'00:00') ))+
DATEDIFF(Minute,'0:00:00',convert(time(0),ISNULL(EndTimeExtraWork ,'00:00') )))/60) +':'+
convert(nvarchar,(DATEDIFF(Minute,'0:00:00',convert(time(0),ISNULL(BeginTimeExtraWork,'00:00') ))+
DATEDIFF(Minute,'0:00:00',convert(time(0),ISNULL(EndTimeExtraWork,'00:00')  )))%60)
else

convert(nvarchar,convert(int,((DATEDIFF(Minute,'0:00:00',convert(time(0),ISNULL(HolidayExtraWork,'00:00'))))/60)))+':'+
convert(nvarchar,convert(int,((DATEDIFF(Minute,'0:00:00',convert(time(0),ISNULL(HolidayExtraWork,'00:00'))))%60)))
end,'00:00')) as [اضافه کار ],
'00:00' as [اضافه کار تردد],'00:00' as [کسر کار],
case (select isnull(COUNT(*),0) from PM_taghvim where TYPE IN(2,3)
ANd PM_taghvim.Tarikh  = Pm_TimeCard.Tarikh )
when 0 then 
convert(nvarchar,(DATEDIFF(Minute,'0:00:00',convert(time(0),ISNULL(BeginTimeExtraWork,'00:00') ))+
DATEDIFF(Minute,'0:00:00',convert(time(0),ISNULL(EndTimeExtraWork,'00:00')  )))/60) +':'+
convert(nvarchar,(DATEDIFF(Minute,'0:00:00',convert(time(0),ISNULL(BeginTimeExtraWork,'00:00') ))+
DATEDIFF(Minute,'0:00:00',convert(time(0),ISNULL(EndTimeExtraWork,'00:00')  )))%60)
else

convert(nvarchar,convert(int,((DATEDIFF(Minute,'0:00:00',convert(time(0),ISNULL(HolidayExtraWork,'00:00'))))/60)))+':'+
convert(nvarchar,convert(int,((DATEDIFF(Minute,'0:00:00',convert(time(0),ISNULL(HolidayExtraWork,'00:00'))))%60)))
end as [جمع اضافه کار ],
(select isnull(COUNT(*),0) from PM_taghvim where TYPE IN(2,3)
ANd PM_taghvim.Tarikh  = Pm_TimeCard.Tarikh ) as تعطیل
from Pm_TimeCard   JOIN Pm_Ashkhas ON
(Pm_Ashkhas.Srl in  (select * from split(@Srl_Ashkhas,','))   OR @Srl_Ashkhas='-1') AND
Pm_TimeCard.Tarikh>=@FromDate AND
Pm_TimeCard.Tarikh<=@ToDate AND
 Srl_Pm_ashkhas=Pm_Ashkhas.Srl 
) as t
order by t.Srl 
END



GO

