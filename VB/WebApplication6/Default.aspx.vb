Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web

Namespace WebApplication6
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub ASPxMenu1_DataBound(ByVal sender As Object, ByVal e As EventArgs)
			Dim url As String = ""
			For i As Integer = 0 To ASPxMenu1.Items.Count - 1

				url = ASPxMenu1.Items(i).NavigateUrl
				Dim lab As ASPxLabel = TryCast(ASPxMenu1.Items(i).FindControl("ASPxLabel1"), ASPxLabel)
				If lab IsNot Nothing Then
				   lab.ClientSideEvents.Click = "function(s,e){window.location = '" & url & "';}"

				   Select Case lab.Text
					   Case "Yahoo!"
							   lab.BackColor = System.Drawing.Color.LightPink
							   Exit Select
					   Case "MSN"
							   lab.BackColor = System.Drawing.Color.LightSkyBlue
							   Exit Select
					   Case "Google"
							   lab.BackColor = System.Drawing.Color.LightSeaGreen
							   Exit Select
				   End Select
				End If
			Next i
		End Sub


	End Class
End Namespace
