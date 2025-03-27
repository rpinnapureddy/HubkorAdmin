Option Strict Off
Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Collections
Imports System.Dynamic
Imports System.ComponentModel.Composition
Imports System.Web
Imports runnerDotNet


Namespace runnerDotNet
	<Export(GetType(IGlobalEventProviderVB))>
	Public Class CommonEventsVB : Implements IGlobalEventProviderVB


		' handlers

		' onscreen events

		' table maps, buttons, ajax
		Public Function event_New_Button8(context As Object) As XVar Implements IGlobalEventProviderVB.event_New_Button8
			' context unpacking
			Dim parameters = context("var_params")
			Dim result = context("result")
			Dim keys = context("keys")
			Dim button = context("button")
			Dim ajax = button
			' event code


			' context packing
			context("var_params") = parameters
			context("result") = result
			context("keys") = keys
			context("button") = button
			Return Nothing
		End Function





		Public Function AfterTableInit(context As Object) As XVar Implements IGlobalEventProviderVB.AfterTableInit
			Dim table = context("table")
			Dim query = context("query")
			context("query") = query
			Return Nothing
		End Function

		Public Function GetTablePermissions(permissions As Object, Optional table As Object = Nothing) As XVar Implements IGlobalEventProviderVB.GetTablePermissions
			If table Is Nothing OrElse table = CType("", XVar) Then
				table = GlobalVars.strTableName
			End If
			Return permissions
		End Function

		Public Function IsRecordEditable(values As Object, isEditable As Object, Optional table As Object = Nothing) As XVar Implements IGlobalEventProviderVB.IsRecordEditable
			If table Is Nothing OrElse table = CType("", XVar) Then
				table = GlobalVars.strTableName
			End If
			Return isEditable
		End Function
	End Class
End Namespace