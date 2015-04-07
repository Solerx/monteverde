SET IDENTITY_INSERT [dbo].[Role] ON
INSERT INTO [dbo].[Role] ([id_role], [role_name], [role_description]) VALUES (1, N'Parent-Administrator', N'Parent Admin')
INSERT INTO [dbo].[Role] ([id_role], [role_name], [role_description]) VALUES (2, N'Administrator', N'Normal Admin')
INSERT INTO [dbo].[Role] ([id_role], [role_name], [role_description]) VALUES (3, N'User', N'Single User')
SET IDENTITY_INSERT [dbo].[Role] OFF
