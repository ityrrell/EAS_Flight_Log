Module Ctl_Common

    Imports System.Collections.Generic
    Imports System.ComponentModel
    Imports System.Drawing
    Imports System.Data
    Imports System.Linq
    Imports System.Text
    Imports System.Threading.Tasks
    Imports System.Windows.Forms
    Imports FSUIPC
    Imports System.Diagnostics

    Partial Public Class ctlExample
        Inherits UserControl
        Implements IExample
        Private ReadOnly referenceManualBaseURL As String = "http://fsuipc.paulhenty.com/Reference/html/"

        Public Sub New()
            Dim referenceDDwidth As Integer = 204
            InitializeComponent()
            Me.tsddReferenceLinks.DropDownItems.Clear()
            Dim refPages As List(Of String) = Me.referencePages
            For Each page As String In refPages
                Dim newLink As New ToolStripButton()
                newLink.Tag = page
                Dim text As String = page
                Dim pos As Integer = text.IndexOf("_1_1")
                If pos > 0 Then
                    text = text.Substring(pos + 4, text.Length - pos - 4 - 5)
                End If
                newLink.Text = text
                newLink.ForeColor = Color.Blue
                AddHandler newLink.Click, AddressOf referenceLink_Click
                newLink.AutoSize = False
                newLink.Width = referenceDDwidth
                newLink.DisplayStyle = ToolStripItemDisplayStyle.Text
                newLink.TextAlign = ContentAlignment.MiddleLeft
                Me.tsddReferenceLinks.DropDownItems.Add(newLink)
            Next
            If Me.tsddReferenceLinks.DropDownItems.Count = 0 Then
                Me.tsddReferenceLinks.Visible = False
            End If
        End Sub

        Private Sub referenceLink_Click(sender As Object, e As EventArgs)
            Dim link As ToolStripButton = TryCast(sender, ToolStripButton)
            If link IsNot Nothing Then
                Process.Start(referenceManualBaseURL & link.Tag.ToString())
            End If
        End Sub

        Protected Overridable ReadOnly Property referencePages() As List(Of String)
            Get
                Return New List(Of String)()
            End Get
        End Property

        Public Overridable Sub SetDocking() Implements IExample.SetDocking
            Me.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        End Sub

        Public Overridable Sub StartExample() Implements IExample.StartExample
            ' Starts the code example 
            setConnectionStatus()
            Me.timerConnection.Start()
        End Sub

        Public Overridable Sub StopExample() Implements IExample.StopExample
            ' Stops the code examaple
            ' Stop all timers and close the connection
            Me.timerConnection.[Stop]()
            Me.timerMain.[Stop]()
            FSUIPCConnection.Close()
        End Sub

        Private Sub timerConnection_Tick(sender As Object, e As EventArgs)
            ' try to open the connection
            If openConnection() Then
                ' connection open
                setConnectionStatus()
                ' stop the timer that looks for a connection
                Me.timerConnection.[Stop]()
                ' start the main timer
                Me.timerMain.Start()
                ' call on connected
                onConnected()
            End If
        End Sub

        Private Function openConnection() As Boolean
            Dim success As Boolean = False
            ' Tries to open a connection to a flight sim.
            Try
                FSUIPCConnection.Open()
                ' If we get here then the connection is open
                success = True
                ' connection failed. No need to do anything, we just keep trying
            Catch
            End Try
            Return success
        End Function

        Private Sub setConnectionStatus()
            ' set the text of the status label depending on the connection status
            If FSUIPCConnection.IsOpen Then
                Me.tslConnectionStatus.Text = "Connected to " & FSUIPCConnection.FlightSimVersionConnected.ToString()
                Me.tslConnectionStatus.ForeColor = Color.DarkGreen
            Else
                Me.tslConnectionStatus.Text = "Disconnected. Looking for Flight Sim..."
                Me.tslConnectionStatus.ForeColor = Color.Red
            End If
        End Sub

        Protected Overridable Sub timerMain_Tick(sender As Object, e As EventArgs)

        End Sub

        Protected Overridable Sub onConnected()
        End Sub


        Private Sub IExample_Hide() Implements IExample.Hide
            Me.Hide()
        End Sub

        Private Sub IExample_Show() Implements IExample.Show
            Me.Show()
        End Sub

        Private Property IExample_Name As String Implements IExample.Name
            Get
                Return Me.Name
            End Get
            Set(value As String)
                Me.Name = value
            End Set
        End Property

        Private Property IExample_Parent As Control Implements IExample.Parent
            Get
                Return Me.Parent
            End Get
            Set(value As Control)
                Me.Parent = value
            End Set
        End Property
    End Class


End Module
