Imports System.Data
Imports System.Web.UI
Imports Oracle.DataAccess.Client
Imports System.IO
Imports System.Exception

Imports System.Linq
Imports System.Data.Linq

Partial Class AdminConfig_Committtee
    Inherits System.Web.UI.Page

    'Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    LoadAllData(1)

    'End Sub
    'Sub LoadAllData(ByVal num As String)
    '    Dim dt As New DataTable
    '    Dim result As String = "<table class='table table-striped table-bordered table-hover' border='1'>"
    '    result &= "<thead><tr><th>สถานธนานุบาลกรุงเทพมหานคร</th><th>คณะกรรมการประเมินทรัพย์หลุดจำนำ</th><th>ตำแหน่ง</th></tr></thead>"

    '    dt = getCommitteeMemberByEventId(num)

    '    'ชุดข้อมูลของจำนวนแถวชุดข้อมูล
    '    Dim distDTRowNum = dt.AsEnumerable().Select(Function(row) New With {
    '            Key .RowNum = row.Field(Of Decimal)("RowNum")
    '    }).Distinct()

    '    For Each row In distDTRowNum
    '        result &= "<tr>"

    '        'ชุดข้อมูลของสาขา
    '        Dim distDTBranch = dt.AsEnumerable().Select(Function(rowData) New With {
    '            Key .RowNum = rowData.Field(Of Decimal)("RowNum"),
    '            Key .BranchName = rowData.Field(Of String)("BranchName")
    '            }).Distinct().Where(Function(rownum) rownum.RowNum = row.RowNum)
    '        result &= "<td>"
    '        For Each distDTBranchRow In distDTBranch
    '            result &= distDTBranchRow.BranchName & "<br />"
    '        Next
    '        result &= "</td>"
    '        'จบชุดข้อมูลของสาขา

    '        'ชุดข้อมูลของพนักงาน
    '        Dim MemberTypeNameVal = ""
    '        Dim distDTEmp = dt.AsEnumerable().Select(Function(rowData) New With {
    '            Key .RowNum = rowData.Field(Of Decimal)("RowNum"),
    '            Key .FullName = rowData.Field(Of String)("FULLNAME"),
    '            Key .MemberTypeName = rowData.Field(Of String)("MemberTypeName")
    '            }).Distinct().Where(Function(rownum) rownum.RowNum = row.RowNum)
    '        result &= "<td>"
    '        For Each distDTEmpRow In distDTEmp
    '            result &= distDTEmpRow.FullName & "<br />"
    '            MemberTypeNameVal &= distDTEmpRow.MemberTypeName & "<br />"
    '        Next
    '        result &= "</td>"
    '        'จบชุดข้อมูลของพนักงาน

    '        'ชุดข้อมูตำแหน่ง
    '        result &= "<td>" & MemberTypeNameVal & "</td>"

    '        result &= "</tr>"
    '    Next

    '    result &= "</table>"
    '    dataTable.InnerHtml = result
    '    'Response.Write(result)

    'End Sub

    'Public Shared Function getAssetConnection() As OracleConnection
    '    Dim con As New OracleConnection(ConfigurationManager.ConnectionStrings("PawnAsset").ToString)
    '    con.Open()
    '    Return con
    'End Function

    'Public Shared Function getCommitteeMemberByEventId(ByVal eventId As Integer) As DataTable
    '    Dim dt As New DataTable
    '    Dim da As New OracleDataAdapter
    '    Dim con As New OracleConnection
    '    Dim cmd As New OracleCommand
    '    con = getAssetConnection()
    '    cmd.Connection = con
    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.CommandText = """sp_getCommitteeMemberByEventId"""
    '    cmd.Parameters.Add(New OracleParameter("vEventId", OracleDbType.Int32)).Value = eventId
    '    cmd.Parameters.Add(New OracleParameter("cur", OracleDbType.RefCursor)).Direction = ParameterDirection.Output

    '    Try
    '        da.SelectCommand = cmd
    '        da.Fill(dt)
    '    Catch ex As Exception

    '    Finally
    '        con.Close()
    '    End Try

    '    Return dt
    'End Function
End Class
