INSERT INTO [dbo].[ReminderItem](
	[Id] ,
	[ContactId] , 
	[TargetDate] ,
	[Message] , 
	[StatusId] ,
	[CreatedDate] ,
	[UpdatedDate] )
	
	VALUES (
	'00000000-000-000-0000-111111111111',
	'ContactId_1',
	'2020-01-01 00:00:00 +00:00',
	'testmessage',
	0,
	'2019-01-01 00:00:00 +00:00',
	'2019-01-01 00:00:00 +00:00'
	 )

	 INSERT INTO [dbo].[ReminderItem](
	[Id] ,
	[ContactId] , 
	[TargetDate] ,
	[Message] , 
	[StatusId] ,
	[CreatedDate] ,
	[UpdatedDate] )
	
	VALUES ('00000000-000-000-0000-111111111111','ContactId_1',	'2020-01-01 00:00:00 +00:00','testmessage0',	0,	'2019-01-01 00:00:00 +00:00',	'2019-01-01 00:00:00 +00:00' ),
		   ('00000000-000-000-0000-111111111111','ContactId_2',	'2020-01-01 00:00:00 +00:00','testmessage1',	1,	'2019-01-01 00:00:00 +00:00',	'2019-01-01 00:00:00 +00:00' ),
		   ('00000000-000-000-0000-111111111111','ContactId_3',	'2020-01-01 00:00:00 +00:00','testmessage2',	2,	'2019-01-01 00:00:00 +00:00',	'2019-01-01 00:00:00 +00:00' )