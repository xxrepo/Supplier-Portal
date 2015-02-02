SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

IF EXISTS(SELECT * FROM sys.objects WHERE type='P' AND name='USP_Tools_WhoLock') 
     DROP PROCEDURE USP_Tools_WhoLock 
GO

CREATE PROCEDURE [dbo].USP_Tools_WhoLock 
AS 
begin      
   declare @spid int      
   declare @blk int      
   declare @count int      
   declare @index int      
   declare @lock tinyint      
   set @lock=0      
   create table #temp_who_lock      
 (      
  id int identity(1,1),      
  spid int,      
  blk int      
 )      
 if @@error<>0 return @@error      
 insert into #temp_who_lock(spid,blk)      
 select 0 ,blocked       
 from (select * from master..sysprocesses where blocked>0)a      
 where not exists(select * from  master..sysprocesses where a.blocked =spid and blocked>0)      
 union select spid,blocked from  master..sysprocesses where blocked>0      
 if @@error<>0 return @@error      
 select @count=count(*),@index=1 from #temp_who_lock      
 if @@error<>0 return @@error      
 if @count=0      
 begin      
  select 'û��������������Ϣ'      
  return 0      
 end      
 while @index<=@count       
 begin      
  if exists(select 1 from #temp_who_lock a where id>@index and exists(select 1 from #temp_who_lock where id<=@index and a.blk=spid))      
  begin      
   set @lock=1      
   select @spid=spid,@blk=blk from #temp_who_lock where id=@index      
   select '�������ݿ���������: '+ CAST(@spid AS VARCHAR(10)) + '���̺�,��ִ�е�SQL�﷨����'      
   select  @spid, @blk    
   dbcc inputbuffer(@spid)      
   dbcc inputbuffer(@blk)      
  end      
  set @index=@index+1      
 end      
 if @lock=0       
 begin      
  set @index=1      
  while @index<=@count       
  begin      
   select @spid=spid,@blk=blk from #temp_who_lock where id=@index      
   if @spid=0      
    select '������������:'+cast(@blk as varchar(10))+ '���̺�,��ִ�е�SQL�﷨����'      
   else       
    select '���̺�SPID��'+ CAST(@spid AS VARCHAR(10))+ '��' + '���̺�SPID��'+ CAST(@blk AS VARCHAR(10)) +'����,�䵱ǰ����ִ�е�SQL�﷨����'      
   dbcc inputbuffer(@spid)    
   dbcc inputbuffer(@blk)      
   set @index=@index+1      
  end      
 end      
 drop table #temp_who_lock      
 return 0      
end            