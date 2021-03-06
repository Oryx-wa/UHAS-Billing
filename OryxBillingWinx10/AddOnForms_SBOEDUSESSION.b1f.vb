
Option Strict Off
Option Explicit On

Imports OWA.SBO.OryxBillingLib10
Imports SAPbouiCOM
Imports SAPbouiCOM.Framework
Imports SBO.SboAddOnBase
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Threading


<FormAttribute("OryxBillingWinx10.AddOnForms_SBOEDUSESSION_b1f", "AddOnForms_SBOEDUSESSION.b1f")>
Friend Class SBOEDUSession
    Inherits UserFormBaseClass

    Private WithEvents Button0 As SAPbouiCOM.Button
    Private WithEvents Button1 As SAPbouiCOM.Button
    Private WithEvents StaticText0 As SAPbouiCOM.StaticText
    Private WithEvents EditText0 As SAPbouiCOM.EditText
    Private WithEvents StaticText1 As SAPbouiCOM.StaticText
    Private WithEvents EditText1 As SAPbouiCOM.EditText
    Private WithEvents StaticText2 As SAPbouiCOM.StaticText
    Private WithEvents EditText2 As SAPbouiCOM.EditText
    Private WithEvents StaticText3 As SAPbouiCOM.StaticText
    Private WithEvents EditText3 As SAPbouiCOM.EditText

    Public Sub New()
    End Sub

    Protected Overrides Sub InitBase(pAddOn As SboAddon)
        MyBase.InitBase(pAddOn)
        Me.CreateObject(New SBOEDUSessionObj(pAddOn, Me.UIAPIRawForm))
    End Sub

    Public Overrides Sub OnInitializeComponent()
        Me.Button1 = CType(Me.GetItem("2").Specific, Button)
        Me.Button0 = CType(Me.GetItem("1").Specific, Button)
        Me.StaticText0 = CType(Me.GetItem("Item_0").Specific, StaticText)
        Me.EditText0 = CType(Me.GetItem("txtCode").Specific, EditText)
        Me.StaticText1 = CType(Me.GetItem("Item_2").Specific, StaticText)
        Me.EditText1 = CType(Me.GetItem("txtName").Specific, EditText)
        Me.StaticText2 = CType(Me.GetItem("Item_1").Specific, StaticText)
        Me.EditText2 = CType(Me.GetItem("txtStart").Specific, EditText)
        Me.StaticText3 = CType(Me.GetItem("Item_4").Specific, StaticText)
        Me.EditText3 = CType(Me.GetItem("txtEnd").Specific, EditText)
        Me.OnCustomInitialize()
    End Sub

    Public Overrides Sub OnInitializeFormEvents()
        AddHandler Me.LoadAfter, AddressOf Me.Form_LoadAfter
    End Sub

    Private Sub Form_LoadAfter(pVal As SBOItemEventArg)
    End Sub

    Private Sub OnCustomInitialize()
    End Sub

    Private Sub SBOEDUSession_DataAddAfter(ByRef pVal As BusinessObjectInfo)
    End Sub
End Class

