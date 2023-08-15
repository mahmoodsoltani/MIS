USE [Nama_MIS]
GO

/****** Object:  StoredProcedure [dbo].[Rp_EzafeKar]    Script Date: 02/01/2011 11:24:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Rp_EzafeKar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Rp_EzafeKar]
GO

USE [Nama_MIS]
GO

/****** Object:  StoredProcedure [dbo].[Rp_EzafeKar]    Script Date: 02/01/2011 11:24:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Rp_EzafeKar] 
@Srl_Ashkhas as int,
@Fromdate as nvarchar(10),
@ToDate as nvarchar(10)
as
BEGIN
select WorkFormTarikh as تاریخ,Pm_Ashkhas.Name as [نام فرد],
Pm_Ashkhas.PersonalCode as [کد شناسایی],Pm_WorkFrom_Detail.WorkFormNo as [فرم کار],
Pm_HazineCode.Code  as [کد هزینه],pm_post.name as [محل فعالیت],
EzafeKAr as [اضافه کار]
,EzafeKarTaradod AS [اضافه کار تردد],
'00:00:00'as [کسر کار],
convert(nvarchar(8),(DATEDIFF(Minute, '0:00:00',convert(time(0),EzafeKAr ))+
DATEDIFF(Minute, '0:00:00',convert(time(0),EzafeKarTaradod )))/60 )+':'+
convert(nvarchar(8),(DATEDIFF(Minute, '0:00:00',convert(time(0),EzafeKAr ))+
DATEDIFF(Minute, '0:00:00',convert(time(0),EzafeKarTaradod )))%60 )
as[جمع اضافه کار],
(select isnull(COUNT(*),0) from Pm_taghvim where TYPE IN(2,3)
ANd Tarikh = WorkFormTarikh ) as تعطیل
   from Pm_WorkFrom_Detail JOIN Pm_Ashkhas ON Pm_Ashkhas.Srl  = @Srl_Ashkhas AND
WorkFormTarikh >= @FromDate AND
WorkFormTarikh <= @ToDate AND
Srl_Pm_Ashkhas  =Pm_Ashkhas.Srl LEFT JOIN Pm_HazineCode ON
Srl_HazineCode = Pm_HazineCode.Srl LEFT JOIN Pm_Post ON
Srl_Pm_Post_To  = Pm_Post.Srl 
 union 
select Tarikh as تاریخ,Pm_Ashkhas.Name as [نام فرد],Pm_Ashkhas.PersonalCode as [کد شناسایی],
'' as [فرم کار],Pm_HazineCode.Code as [کد هزینه],Pm_Post.Name  as [محل فعالیت],
case (select isnull(COUNT(*),0) from PM_taghvim where TYPE IN(2,3)
ANd PM_taghvim.Tarikh  = Tarikh )
when 0 then CONVERT(time(0),
convert(nvarchar,(DATEDIFF(Minute,'0:00:00',convert(time(0),BeginTimeExtraWork ))+
DATEDIFF(Minute,'0:00:00',convert(time(0),EndTimeExtraWork  )))/60) +':'+
convert(nvarchar,(DATEDIFF(Minute,'0:00:00',convert(time(0),BeginTimeExtraWork ))+
DATEDIFF(Minute,'0:00:00',convert(time(0),EndTimeExtraWork  )))%60))
else

convert(nvarchar,convert(int,((DATEDIFF(Minute,'0:00:00',convert(time(0),HolidayExtraWork))+DATEDIFF(Minute,'0:00:00',convert(time(0),Mamoriyat)))*1.5/60)))+':'+
convert(nvarchar,convert(int,((DATEDIFF(Minute,'0:00:00',convert(time(0),HolidayExtraWork))+DATEDIFF(Minute,'0:00:00',convert(time(0),Mamoriyat)))*1.5%60)))
end as [اضافه کار ],'00:00:00' as [اضافه کار تردد],'00:00:00' as [کسر کار],
case (select isnull(COUNT(*),0) from PM_taghvim where TYPE IN(2,3)
ANd PM_taghvim.Tarikh  = Tarikh )
when 0 then 
convert(nvarchar,(DATEDIFF(Minute,'0:00:00',convert(time(0),BeginTimeExtraWork ))+
DATEDIFF(Minute,'0:00:00',convert(time(0),EndTimeExtraWork  )))/60) +':'+
convert(nvarchar,(DATEDIFF(Minute,'0:00:00',convert(time(0),BeginTimeExtraWork ))+
DATEDIFF(Minute,'0:00:00',convert(time(0),EndTimeExtraWork  )))%60)
else

convert(nvarchar,convert(int,((DATEDIFF(Minute,'0:00:00',convert(time(0),HolidayExtraWork))+DATEDIFF(Minute,'0:00:00',convert(time(0),Mamoriyat)))*1.5/60)))+':'+
convert(nvarchar,convert(int,((DATEDIFF(Minute,'0:00:00',convert(time(0),HolidayExtraWork))+DATEDIFF(Minute,'0:00:00',convert(time(0),Mamoriyat)))*1.5%60)))
end as [جمع اضافه کار ],
(select isnull(COUNT(*),0) from PM_taghvim where TYPE IN(2,3)
ANd PM_taghvim.Tarikh  = Tarikh ) as تعطیل
from Pm_TimeCard   JOIN Pm_Ashkhas ON
Pm_Ashkhas.Srl=@Srl_Ashkhas AND
Pm_TimeCard.Tarikh>=@FromDate AND
Pm_TimeCard.Tarikh<=@ToDate AND
 Srl_Pm_ashkhas=Pm_Ashkhas.Srl LEFT JOIN Pm_HazineCode ON
Pm_HazineCode.Srl = Pm_TimeCard.Srl_Pm_CodeHaizne LEFT JOIN Pm_Post ON
Pm_Post.Srl = Pm_TimeCard.Srl_Pm_Post 

END
GO

