﻿Imports System.Data
Imports System.Web.UI
Imports Oracle.DataAccess.Client
Imports System.IO
Imports System.Exception
Imports System.Linq

Partial Class AdminConfig_Committtee
    Inherits System.Web.UI.Page
    Public Shared eventId As String = "1"

    Protected Sub AdminConfig_Committtee_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (Request.QueryString("EventID") IsNot Nothing) Then
            eventId = Request.QueryString("EventID").ToString
        End If
    End Sub
End Class