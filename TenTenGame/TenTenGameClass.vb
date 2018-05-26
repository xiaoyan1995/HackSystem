﻿Imports System.Windows.Forms
Imports ProgramTemplate

Public Class TenTenGameClass
    Inherits ProgramTemplateClass

    Public Sub New()
        Name = "1010"
        Description = "1010 [via : Leon]"
        Icon = My.Resources.TenTenGameResource.TenTenGameIcon
    End Sub


    Public Overrides ReadOnly Property FileName As String
        Get
            Return System.Reflection.Assembly.GetExecutingAssembly().ManifestModule.ScopeName
        End Get
    End Property

    Protected Overrides Function CreateProgramForm() As Form
        Return New TenTenGameForm
    End Function

End Class
