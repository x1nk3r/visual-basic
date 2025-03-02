Imports System
Imports System.Windows.Forms

Public Class MyForm
    Inherits Form

    ' Declare the label and button as class-level variables
    Private lblName As Label
    Private btnDisplay As Button

    ' Constructor for the form
    Public Sub New()
        ' Initialize the form
        Me.Text = "Display Name Example"
        Me.Size = New Drawing.Size(300, 200)

        ' Initialize the label
        lblName = New Label()
        lblName.Name = "lblName"
        lblName.Text = "" ' Initially empty text
        lblName.Location = New Drawing.Point(100, 50)
        lblName.Size = New Drawing.Size(200, 30)

        ' Initialize the button
        btnDisplay = New Button()
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Text = "Click Me"
        btnDisplay.Location = New Drawing.Point(100, 100)
        btnDisplay.Size = New Drawi
