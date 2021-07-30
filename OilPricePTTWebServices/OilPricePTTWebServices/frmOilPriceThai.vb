#Region "ABOUT"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More: http://www.g2gnet.com/webboard
' /
' / Purpose: Web Services form PTT to show the daily oil price.
' / Microsoft Visual Basic .NET (2010)
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
#End Region

Imports System.Xml
Imports System.Net
Imports OilPricePTTWebServices.OilPricePTT

'// Web Services from PTT.
'// https://www1.pttor.com/OilPrice.asmx
'// Address ... https://www1.pttor.com/OilPrice.asmx?wsdl

Public Class frmOilPriceThai

    Private Sub frmOilPriceThai_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

    Private Sub frmOilPriceThai_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call LoadProvince()
        dtpDateOilPrice.Value = Now
        lblDateOilPrice.Text = "ราคาน้ำมันวันที่: " & dtpDateOilPrice.Text
        lblLocation.Text = ""
    End Sub

    Private Sub LoadProvince()
        Dim dt As New DataTable
        With dt.Columns
            .Add("Key")
            .Add("Value")
        End With
        With dt
            .Rows.Add(1, "เลือกชื่อจังหวัด")
            .Rows.Add(2, "กระบี่")
            .Rows.Add(3, "กรุงเทพมหานคร")
            .Rows.Add(4, "กาญจนบุรี")
            .Rows.Add(5, "กาฬสินธุ์")
            .Rows.Add(6, "กำแพงเพชร")
            .Rows.Add(7, "ขอนแก่น")
            .Rows.Add(8, "จันทบุรี")
            .Rows.Add(9, "ฉะเชิงเทรา")
            .Rows.Add(10, "ชลบุรี")
            .Rows.Add(11, "ชัยนาท")
            .Rows.Add(12, "ชัยภูมิ")
            .Rows.Add(13, "ชุมพร")
            .Rows.Add(14, "เชียงราย")
            .Rows.Add(15, "เชียงใหม่")
            .Rows.Add(16, "ตรัง")
            .Rows.Add(17, "ตราด")
            .Rows.Add(18, "ตาก")
            .Rows.Add(19, "นครนายก")
            .Rows.Add(20, "นครปฐม")
            .Rows.Add(21, "นครพนม")
            .Rows.Add(22, "นครราชสีมา")
            .Rows.Add(23, "นครศรีธรรมราช")
            .Rows.Add(24, "นครสวรรค์")
            .Rows.Add(25, "นนทบุรี")
            .Rows.Add(26, "นราธิวาส")
            .Rows.Add(27, "น่าน")
            .Rows.Add(28, "บึงกาฬ")
            .Rows.Add(29, "บุรีรัมย์")
            .Rows.Add(30, "ปทุมธานี")
            .Rows.Add(31, "ประจวบคีรีขันธ์")
            .Rows.Add(32, "ปราจีนบุรี")
            .Rows.Add(33, "ปัตตานี")
            .Rows.Add(34, "พระนครศรีอยุธยา")
            .Rows.Add(35, "พะเยา")
            .Rows.Add(36, "พังงา")
            .Rows.Add(37, "พัทลุง")
            .Rows.Add(38, "พิจิตร")
            .Rows.Add(39, "พิษณุโลก")
            .Rows.Add(40, "เพชรบุรี")
            .Rows.Add(41, "เพชรบูรณ์")
            .Rows.Add(42, "แพร่")
            .Rows.Add(43, "ภูเก็ต")
            .Rows.Add(44, "มหาสารคาม")
            .Rows.Add(45, "มุกดาหาร")
            .Rows.Add(46, "แม่ฮ่องสอน")
            .Rows.Add(47, "ยโสธร")
            .Rows.Add(48, "ยะลา")
            .Rows.Add(49, "ร้อยเอ็ด")
            .Rows.Add(50, "ระนอง")
            .Rows.Add(51, "ระยอง")
            .Rows.Add(52, "ราชบุรี")
            .Rows.Add(53, "ลพบุรี")
            .Rows.Add(54, "ลำปาง")
            .Rows.Add(55, "ลำพูน")
            .Rows.Add(56, "เลย")
            .Rows.Add(57, "ศรีสะเกษ")
            .Rows.Add(58, "สกลนคร")
            .Rows.Add(59, "สงขลา")
            .Rows.Add(60, "สตูล")
            .Rows.Add(61, "สมุทรปราการ")
            .Rows.Add(62, "สมุทรสงคราม")
            .Rows.Add(63, "สมุทรสาคร")
            .Rows.Add(64, "สระแก้ว")
            .Rows.Add(65, "สระบุรี")
            .Rows.Add(66, "สิงห์บุรี")
            .Rows.Add(67, "สุโขทัย")
            .Rows.Add(68, "สุพรรณบุรี")
            .Rows.Add(69, "สุราษฎร์ธานี")
            .Rows.Add(70, "สุรินทร์")
            .Rows.Add(71, "หนองคาย")
            .Rows.Add(72, "หนองบัวลำภู")
            .Rows.Add(73, "อ่างทอง")
            .Rows.Add(74, "อำนาจเจริญ")
            .Rows.Add(75, "อุดรธานี")
            .Rows.Add(76, "อุตรดิตถ์")
            .Rows.Add(77, "อุทัยธานี")
            .Rows.Add(78, "อุบลราชธานี")
        End With
        cmbProvince.Items.Clear()
        With cmbProvince
            .DisplayMember = "Value"
            .ValueMember = "Key"
            .DataSource = dt
        End With
        cmbProvince.SelectedIndex = 0
    End Sub

    '// เลือกจังหวัด
    Private Sub cmbProvince_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbProvince.SelectedIndexChanged
        Dim SoapClient As New OilPricePTT.OilPriceSoapClient
        Dim MyDate As DateTime = GetDate(dtpDateOilPrice.Text)
        Dim strXML As String = String.Empty
        If cmbProvince.Text = "เลือกชื่อจังหวัด" Then
            cmbAmphur.DataSource = Nothing
            cmbAmphur.Items.Clear()
            For Each c As Control In Me.Controls
                If TypeOf c Is TextBox Then c.Text = "0.00"
            Next
            Exit Sub
        End If
        Try
            If cmbProvince.Text = "กรุงเทพมหานคร" Then
                '// Thailand, วันที่, เดือน, ปี
                strXML = SoapClient.GetOilPrice( _
                    "TH", _
                    Microsoft.VisualBasic.Left(MyDate, 2), _
                    Microsoft.VisualBasic.Mid(MyDate, 4, 2), _
                    Microsoft.VisualBasic.Right(MyDate, 4))
                cmbAmphur.DataSource = Nothing
                cmbAmphur.Items.Clear()
                cmbAmphur.Enabled = False

            Else
                strXML = SoapClient.GetOilPriceProvincial( _
                    "TH", _
                    Microsoft.VisualBasic.Left(MyDate, 2), _
                    Microsoft.VisualBasic.Mid(MyDate, 4, 2), _
                    Microsoft.VisualBasic.Right(MyDate, 4), _
                    cmbProvince.Text.Trim)
                cmbAmphur.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(cmbProvince.Text & vbCrLf & ex.Message)
        End Try
        '//
        If strXML.Length > 12 Then Call ParserXMLProvince(strXML)
    End Sub

    '// แยกข้อมูลราคาน้ำมัน XML ของแต่ละจังหวัด
    Sub ParserXMLProvince(ByVal xmlDoc As String)
        Dim doc As New XmlDocument()
        '// โหลดเอกสาร XML
        doc.LoadXml(xmlDoc)
        '// จุดเริ่มต้นของ Node
        Dim nodes As XmlNodeList
        Try
            If cmbProvince.Text = "กรุงเทพมหานคร" Then
                nodes = doc.GetElementsByTagName("FUEL")
                Dim Price_Date As String = String.Empty, Product As String = "", Price As String = ""
                For Each node As XmlNode In nodes
                    Product = node("PRODUCT").InnerText
                    If IsNothing(node.Item("PRICE")) Then
                        Price = "0.00"
                    Else
                        Price = Format(CDbl(node.SelectSingleNode("PRICE").InnerText), "0.00")
                    End If
                    Select Case Product
                        '// กรองเอาเฉพาะประเภทที่ต้องการ
                        Case "Gasohol 91"
                            txtGasohol91.Text = Price
                        Case "Diesel B7"
                            txtDieselB7.Text = Price
                        Case "Diesel B5"
                            txtDieselPremium.Text = Price
                        Case "Premium Diesel B7"
                            txtDieselPremium.Text = Price
                        Case "Diesel"
                            txtDiesel.Text = Price
                        Case "Diesel B20"
                            txtDieselB20.Text = Price
                        Case "Gasohol E85"
                            txtGasoholE85.Text = Price
                        Case "Gasoline 95"
                            txtBenzine.Text = Price
                        Case "Gasohol 95"
                            txtGasohol95.Text = Price
                        Case "Gasohol E20"
                            txtGasoholE20.Text = Price
                        Case "NGV"
                            txtNGV.Text = Price
                    End Select
                Next
                lblLocation.Text = "ราคา: " & cmbProvince.Text

                '// ต่างจังหวัด
            Else
                nodes = doc.GetElementsByTagName("FUEL_PROVINCIAL")
                Dim dt As New DataTable
                dt.Columns.Add("Key", GetType(Integer))
                dt.Columns.Add("Value", GetType(String))
                Dim i As Byte = 0
                For Each node As XmlNode In nodes
                    i += 1
                    dt.Rows.Add(i, node("LOCATION").InnerText)
                Next
                Dim DuplicateValue = (From r In dt.AsEnumerable() Select r("Value")).Distinct().ToList()
                With cmbAmphur
                    .DisplayMember = "Value"
                    .ValueMember = "Key"
                    .DataSource = DuplicateValue
                End With
                cmbAmphur.SelectedIndex = 0
                lblLocation.Text = cmbAmphur.Text & "/" & cmbProvince.Text
            End If

        Catch ex As Exception
            MessageBox.Show(cmbProvince.Text & vbCrLf & ex.Message)
            lblLocation.Text = ""
            cmbAmphur.DataSource = Nothing
            cmbAmphur.Items.Clear()
        End Try

    End Sub

    '// แยกข้อมูลราคาน้ำมัน XML ของแต่ละอำเภอ
    Sub ParserXMLAmphur(ByVal xmlDoc As String)
        Dim doc As New XmlDocument()
        '// โหลดเอกสาร XML
        doc.LoadXml(xmlDoc)
        Try
            '// จุดเริ่มต้นของ Node
            Dim nodes As XmlNodeList = doc.GetElementsByTagName("FUEL_PROVINCIAL")
            Dim Price_Date As String = String.Empty, Product As String = "", Price As String = "0.00"
            txtNGV.Text = "N/A"
            For Each node As XmlNode In nodes
                If node("LOCATION").InnerText = cmbAmphur.Text.Trim Then
                    Price_Date = node("PRICE_DATE").InnerText
                    Product = node("PRODUCT").InnerText
                    '// ข้อมูลบางตัวอาจจะไม่มี Element ที่ชื่อ PRICE
                    If IsNothing(node("PRICE")) Then
                        Price = "0.00"
                    Else
                        Price = Format(CDbl(node("PRICE").InnerText), "0.00")
                    End If
                    Select Case Product
                        '// กรองเอาเฉพาะประเภทที่ต้องการ
                        Case "Gasohol 91"
                            txtGasohol91.Text = Price
                        Case "Diesel B7"
                            txtDieselB7.Text = Price
                        Case "Diesel B5"
                            txtDieselPremium.Text = Price
                        Case "Premium Diesel B7"
                            txtDieselPremium.Text = Price
                        Case "Diesel"
                            txtDiesel.Text = Price
                        Case "Diesel B20"
                            txtDieselB20.Text = Price
                        Case "Gasohol E85"
                            txtGasoholE85.Text = Price
                        Case "Gasoline 95"
                            txtBenzine.Text = Price
                        Case "Gasohol 95"
                            txtGasohol95.Text = Price
                        Case "Gasohol E20"
                            txtGasoholE20.Text = Price
                        Case "NGV"
                            txtNGV.Text = Price
                    End Select
                End If
            Next
            lblLocation.Text = cmbAmphur.Text & "/" & cmbProvince.Text
        Catch ex As Exception
            MessageBox.Show(cmbProvince.Text & vbCrLf & ex.Message)
        End Try
    End Sub

    '// เลือกอำเภอ
    Private Sub cmbAmphur_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbAmphur.SelectedIndexChanged
        Try
            Dim SoapClient As New OilPricePTT.OilPriceSoapClient
            Dim MyDate As DateTime = GetDate(dtpDateOilPrice.Text)
            Dim strXML As String = SoapClient.GetOilPriceProvincial( _
                "TH", _
                Microsoft.VisualBasic.Left(MyDate, 2), _
                Microsoft.VisualBasic.Mid(MyDate, 4, 2), _
                Microsoft.VisualBasic.Right(MyDate, 4), _
                cmbProvince.Text.Trim)
            '//
            Call ParserXMLAmphur(strXML)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function GetDate(ByVal d As DateTime) As String
        Return d.ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
    End Function

    Private Sub dtpDateOilPrice_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpDateOilPrice.ValueChanged
        lblDateOilPrice.Text = "ราคาน้ำมันวันที่: " & dtpDateOilPrice.Text
        If (cmbProvince.SelectedIndex > 0 AndAlso cmbAmphur.Items.Count > 0) Or cmbProvince.Text = "กรุงเทพมหานคร" Then Call cmbProvince_SelectedIndexChanged(sender, e)
    End Sub

    '// ----------------------------------------------------------------------------------
    '// ป้องกันการกดคีย์ใดๆในเหตุการณ์ TextBox_KeyPress ... กำหนดให้ e.Handled = True
    Private Sub txtBenzine_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBenzine.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtDiesel_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiesel.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtDieselB20_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDieselB20.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtDieselB7_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDieselB7.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtDieselPremium_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDieselPremium.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtGasohol91_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtGasohol91.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtGasohol95_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtGasohol95.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtGasoholE20_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtGasoholE20.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtGasoholE85_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtGasoholE85.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtNGV_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNGV.KeyPress
        e.Handled = True
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripStatusLabel2.Click
        Process.Start("https://www.facebook.com/g2gnet")
    End Sub
End Class
