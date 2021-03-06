﻿Imports System.IO
Imports System.Data.SqlClient
Imports System.Web.HttpServerUtility
Imports System.Drawing

Public Class DLayer

    Public Shared Function GetPhotoListFromDirectory(PhotoDirectory As String) As List(Of Photo)
        'Dim imgExtensions As New List(Of String)
        'imgExtensions.AddRange({".jpg", ".jpeg", ".bmp", ".gif", ".png"})
        'imgExtensions.AddRange({".JPG", ".JPEG", ".BMP", ".GIF", ".PNG"})
        'Dim arrPhoto As IEnumerable(Of String) = Directory.EnumerateFiles(HttpContext.Current.Server.MapPath(PhotoDirectory)).Select(Function(fn) Path.GetFileName(fn)).Where(Function(s) imgExtensions.Any(Function(x) x = Path.GetExtension(s)))

        ''Dim imageFiles = Directory.EnumerateFiles(targetFolder) _
        ''         .Where(Function(s) imgExtensions _
        ''         .Any(Function(x) x = Path.GetExtension(s)))


        'Dim output As New List(Of Photo)
        'For Each photo As String In arrPhoto
        '    Dim fullpath As String = PhotoDirectory.Substring(1) & "/" & photo
        '    output.Add(New Photo With {.PhotoTitle = photo, .PhotoSubTitle = arrPhoto.Count.ToString, .PhotoURL = fullpath, .Orientation = GetOrientation(fullpath)})
        'Next
        Dim output As List(Of Photo) = GetPhotosDims(PhotoDirectory)
        Return output
    End Function

    Private Shared Function GetPhotosDims(PhotoDirectory As String) As List(Of Photo)
        Dim output As New List(Of Photo)

        Dim imgExtensions As New List(Of String)
        imgExtensions.AddRange({".jpg", ".jpeg", ".bmp", ".gif", ".png"})
        imgExtensions.AddRange({".JPG", ".JPEG", ".BMP", ".GIF", ".PNG"})
        Dim arrPhoto As IEnumerable(Of String) = Directory.EnumerateFiles(HttpContext.Current.Server.MapPath(PhotoDirectory)).Select(Function(fn) Path.GetFileName(fn)).Where(Function(s) imgExtensions.Any(Function(x) x = Path.GetExtension(s)))
        For Each f As String In arrPhoto
            Dim fullpath As String = HttpContext.Current.Server.MapPath(PhotoDirectory) & "/" & f
            Using strm As Stream = File.OpenRead(fullpath)
                Using si As Image = Image.FromStream(strm, False, False)
                    Dim orientation As String = "oLand"
                    If si.Width < si.Height Then orientation = "oPort"
                    output.Add(New Photo With {
                               .PhotoTitle = f,
                               .Orientation = orientation,
                               .PhotoSubTitle = f,
                               .PhotoURL = PhotoDirectory.Substring(1) & "/" & f
                               }
                               )
                End Using
            End Using

        Next

        Return output
    End Function

    Private Shared Function GetOrientation(filename As String) As String
        Dim output As String = "L"
        Dim bm As New Bitmap(filename)
        Dim pSize As Size = bm.Size
        If pSize.Height > pSize.Width Then output = "P"
        Return output
    End Function

    Private Shared Function GetPollingData() As DataTable
        Dim dt As New DataTable

        Dim strSQL As String = "Select polls.ID, polls.PollerID, comp.PollerName, polls.Comment, polls.PollDate, polls.Con, polls.Lab, polls.Lib, polls.Brx, polls.Grn, polls.SNP, polls.PC, polls.UKP "
        strSQL &= "FROM dbo.Pollers AS comp RIGHT OUTER JOIN "
        strSQL &= "dbo.Polling AS polls ON comp.ID = polls.PollerID"


        'Dim strSQL As String = "SELECT ID, PollerID, PollerName, Comment, PollDate, Con, Lab, Lib, Brx, Grn, SNP, PC, UKP FROM dbo.vwPolls"
        Using conn As New SqlConnection(My.Settings.CS)
            'conn.Open()
            Using dad As New SqlDataAdapter(strSQL, conn)
                dad.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Shared Function GetPollModel() As List(Of Poll)
        Dim output As New List(Of Poll)
        Dim dt As DataTable = GetPollingData()
        For Each row As DataRow In dt.Rows
            output.Add(
            New Poll With {
            .ID = CType(row.Item("ID"), Integer),
            .PollerID = CType(row.Item("PollerID"), Integer),
            .Poller = row.Item("PollerName").ToString,
            .PollDate = CType(row.Item("PollDate"), Date),
            .Comment = row.Item("Comment").ToString,
            .Con = CType(row.Item("Con"), Decimal),
            .Lab = CType(row.Item("Lab"), Decimal),
            .LibD = CType(row.Item("Lib"), Decimal),
            .Brx = CType(row.Item("Brx"), Decimal),
            .SNP = CType(row.Item("SNP"), Decimal),
            .Grn = CType(row.Item("Grn"), Decimal),
            .PC = CType(row.Item("PC"), Decimal),
            .UKP = CType(row.Item("UKP"), Decimal)
            })
        Next
        Return output
    End Function

    Private Shared Function GetPollingCompanies() As DataTable
        Dim dt As New DataTable
        Dim strSQL As String = "Select ID, PollerName FROM dbo.Pollers"
        Using conn As New SqlConnection(My.Settings.CS)
            'conn.Open()
            Using dad As New SqlDataAdapter(strSQL, conn)
                dad.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Shared Function GetPollingCompaniesModel() As List(Of PollingCompanies)
        Dim output As New List(Of PollingCompanies)
        Dim dt As DataTable = GetPollingCompanies()
        output.Add(New PollingCompanies With {.ID = 0, .PollerName = "All Polling Companies"})
        For Each row As DataRow In dt.Rows
            output.Add(
            New PollingCompanies With {
            .ID = CType(row.Item("ID"), Integer),
            .PollerName = row.Item("PollerName").ToString
            })
        Next
        Return output
    End Function
End Class
