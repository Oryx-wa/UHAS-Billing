
Option Strict Off
Option Explicit On

Imports Microsoft.VisualBasic.CompilerServices
Imports SAPbouiCOM
Imports SAPbouiCOM.Framework
Imports SBO.SboAddOnBase
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Threading


<FormAttribute("OryxBillingWinx10.AddOnForms_SBOEDUSchools_b1f", "AddOnForms_SBOEDUSchools.b1f")>
Friend Class SBOEDUSchools
    Inherits UserFormBaseClass
    Private WithEvents StaticText0 As SAPbouiCOM.StaticText
    Private WithEvents EditText0 As SAPbouiCOM.EditText
    Private WithEvents StaticText1 As SAPbouiCOM.StaticText
    Private WithEvents EditText1 As SAPbouiCOM.EditText
    Private WithEvents drgKeySt As SAPbouiCOM.Matrix
    Private WithEvents Button0 As SAPbouiCOM.Button
    Private WithEvents Button1 As SAPbouiCOM.Button
    Private WithEvents EditText2 As SAPbouiCOM.EditText
    Private WithEvents StaticText2 As SAPbouiCOM.StaticText
    Private WithEvents StaticText4 As SAPbouiCOM.StaticText
    Private WithEvents EditText3 As SAPbouiCOM.EditText
    Private WithEvents LinkedButton0 As SAPbouiCOM.LinkedButton

    Public Sub New()
    End Sub



    Public Overrides Sub OnInitializeComponent()
        Me.StaticText0 = CType(Me.GetItem("Item_0").Specific, StaticText)
        Me.EditText0 = CType(Me.GetItem("txtCode").Specific, EditText)
        Me.StaticText1 = CType(Me.GetItem("Item_2").Specific, StaticText)
        Me.EditText1 = CType(Me.GetItem("Item_3").Specific, EditText)
        Me.Button0 = CType(Me.GetItem("1").Specific, Button)
        Me.Button1 = CType(Me.GetItem("2").Specific, Button)
        Me.StaticText2 = CType(Me.GetItem("Item_1").Specific, StaticText)
        Me.EditText2 = CType(Me.GetItem("txtprc").Specific, EditText)
        Me.LinkedButton0 = CType(Me.GetItem("Item_5").Specific, LinkedButton)
        Me.OnCustomInitialize()
    End Sub

    Public Overrides Sub OnInitializeFormEvents()
    End Sub

    Private Sub OnCustomInitialize()
    End Sub

    Private Sub EditText2_ChooseFromListAfter(sboObject As Object, pVal As SBOItemEventArg)
        Try
            Dim arg_11_1 As String = pVal.FormUID
            Dim flag As Boolean = False
            Dim text As String = Me.HandleChooseFromListEvent(arg_11_1, pVal, flag)
            Dim flag2 As Boolean = String.IsNullOrEmpty(text)
            If Not flag2 Then
                Me.DBDS("@OWA_EDUSCHOOLS").SetValue("U_Dim1", Me.DBDS("@OWA_EDUSCHOOLS").Offset, text)
            End If
        Catch expr_4F As Exception
            ProjectData.SetProjectError(expr_4F)
            ProjectData.ClearProjectError()
        End Try
    End Sub
End Class

