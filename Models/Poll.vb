Imports System.ComponentModel.DataAnnotations
Imports System.Web.Mvc

Public Class Poll

    Public Property ID As Integer
    Public Property PollerID As Integer
    Public Property Poller As String
    Public Property Comment As String
    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy}")>
    Public Property PollDate As Date
    <DisplayFormat(DataFormatString:="{0:#0.##\%}")>
    Public Property Con As Decimal
    <DisplayFormat(DataFormatString:="{0:#0.##\%}")>
    Public Property Lab As Decimal
    <DisplayFormat(DataFormatString:="{0:#0.##\%}")>
    Public Property LibD As Decimal
    <DisplayFormat(DataFormatString:="{0:#0.##\%}")>
    Public Property Brx As Decimal
    <DisplayFormat(DataFormatString:="{0:#0.##\%}")>
    Public Property Grn As Decimal
    <DisplayFormat(DataFormatString:="{0:#0.##\%}")>
    Public Property SNP As Decimal
    <DisplayFormat(DataFormatString:="{0:#0.##\%}")>
    Public Property PC As Decimal
    <DisplayFormat(DataFormatString:="{0:#0.##\%}")>
    Public Property UKP As Decimal
    <DisplayFormat(DataFormatString:="{0:#0.##\%}")>
    Public ReadOnly Property Lead As Decimal
        Get
            Return Con - Lab
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Sub New(
                  ByVal Optional iID As Integer = 0,
                  ByVal Optional iPollID As Integer = 0,
                  ByVal Optional sPoller As String = "",
                  ByVal Optional sComment As String = "",
                  ByVal Optional dPollDate As Date = Nothing,
                  ByVal Optional nCon As Decimal = 0.0,
                  ByVal Optional nLab As Decimal = 0.0,
                  ByVal Optional nLib As Decimal = 0.0,
                  ByVal Optional nBrx As Decimal = 0.0,
                  ByVal Optional nGrn As Decimal = 0.0,
                  ByVal Optional nSNP As Decimal = 0.0,
                  ByVal Optional nPC As Decimal = 0.0,
                  ByVal Optional nUKP As Decimal = 0.0
                  )
        ID = iID
        PollerID = iPollID
        Poller = sPoller
        Comment = sComment
        PollDate = dPollDate
        Con = nCon
        Lab = nLab
        LibD = nLib
        Brx = nBrx
        Grn = nGrn
        SNP = nSNP
        PC = nPC
        UKP = nUKP
    End Sub

End Class


Public Class PollingCompanies

    Public Property ID As Integer
    Public Property PollerName As String

    Public Sub New()
    End Sub

    Public Sub New(
              ByVal Optional iPollerID As Integer = 0,
              ByVal Optional sPollerName As String = ""
                  )
        ID = iPollerID
        PollerName = sPollerName
    End Sub

End Class

Public Class PollingParms
    Public Property PollData As List(Of Poll)
    Public Property PollComps As SelectList

    Public Sub New(
          ByVal Optional zPollData As List(Of Poll) = Nothing,
          ByVal Optional zPollComps As SelectList = Nothing
              )
        PollData = zPollData
        PollComps = zPollComps
    End Sub
End Class