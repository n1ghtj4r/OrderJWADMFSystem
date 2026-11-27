<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Friend WithEvents lblJAJCMNJMMLNMTTitle As Label
    Friend WithEvents lblJAJCMNJMMLNMLName As Label
    Friend WithEvents txtJAJCMNJMMLNMLName As TextBox
    Friend WithEvents lblJAJCMNJMMLNMName As Label
    Friend WithEvents txtJAJCMNJMMLNMName As TextBox
    Friend WithEvents lblJAJCMNJMMLNM_MName As Label
    Friend WithEvents txtJAJCMNJMMLNM_MName As TextBox
    Friend WithEvents grpJAJCMNJMMLNMPizza As GroupBox
    Friend WithEvents optJAJCMNJMMLNMSolo As RadioButton
    Friend WithEvents optJAJCMNJMMLNMRegular As RadioButton
    Friend WithEvents optJAJCMNJMMLNMFamily As RadioButton
    Friend WithEvents grpJAJCMNJMMLNMToppings As GroupBox
    Friend WithEvents chkJAJCMNJMMLNMPine As CheckBox
    Friend WithEvents chkJAJCMNJMMLNMHam As CheckBox
    Friend WithEvents chkJAJCMNJMMLNMCombo As CheckBox
    Friend WithEvents lblJAJCMNJMMLNMDrinks As Label
    Friend WithEvents cmbJAJCMNJMMLNMDrinks As ComboBox
    Friend WithEvents lblJAJCMNJMMLNMAmount As Label
    Friend WithEvents txtJAJCMNJMMLNMAmount As TextBox
    Friend WithEvents btnJAJCMNJMMLNMAmount As Button
    Friend WithEvents btnJAJCMNJMMLNMReceipt As Button
    Friend WithEvents btnJAJCMNJMMLNMClear As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        lblJAJCMNJMMLNMTTitle = New Label()
        lblJAJCMNJMMLNMLName = New Label()
        txtJAJCMNJMMLNMLName = New TextBox()
        lblJAJCMNJMMLNMName = New Label()
        txtJAJCMNJMMLNMName = New TextBox()
        lblJAJCMNJMMLNM_MName = New Label()
        txtJAJCMNJMMLNM_MName = New TextBox()
        grpJAJCMNJMMLNMPizza = New GroupBox()
        optJAJCMNJMMLNMSolo = New RadioButton()
        optJAJCMNJMMLNMRegular = New RadioButton()
        optJAJCMNJMMLNMFamily = New RadioButton()
        grpJAJCMNJMMLNMToppings = New GroupBox()
        chkJAJCMNJMMLNMPine = New CheckBox()
        chkJAJCMNJMMLNMHam = New CheckBox()
        chkJAJCMNJMMLNMCombo = New CheckBox()
        lblJAJCMNJMMLNMDrinks = New Label()
        cmbJAJCMNJMMLNMDrinks = New ComboBox()
        lblJAJCMNJMMLNMAmount = New Label()
        txtJAJCMNJMMLNMAmount = New TextBox()
        btnJAJCMNJMMLNMAmount = New Button()
        btnJAJCMNJMMLNMReceipt = New Button()
        btnJAJCMNJMMLNMClear = New Button()

        SuspendLayout()

        lblJAJCMNJMMLNMTTitle.AutoSize = True
        lblJAJCMNJMMLNMTTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblJAJCMNJMMLNMTTitle.Location = New Point(230, 18)
        lblJAJCMNJMMLNMTTitle.Size = New Size(340, 30)
        lblJAJCMNJMMLNMTTitle.Text = "JAJCMNJMMLNM Pizza Order System"

        lblJAJCMNJMMLNMLName.AutoSize = True
        lblJAJCMNJMMLNMLName.Location = New Point(30, 68)
        lblJAJCMNJMMLNMLName.Text = "Last Name"
        txtJAJCMNJMMLNMLName.Location = New Point(30, 88)
        txtJAJCMNJMMLNMLName.Size = New Size(220, 23)

        lblJAJCMNJMMLNMName.AutoSize = True
        lblJAJCMNJMMLNMName.Location = New Point(290, 68)
        lblJAJCMNJMMLNMName.Text = "First Name"
        txtJAJCMNJMMLNMName.Location = New Point(290, 88)
        txtJAJCMNJMMLNMName.Size = New Size(220, 23)

        lblJAJCMNJMMLNM_MName.AutoSize = True
        lblJAJCMNJMMLNM_MName.Location = New Point(550, 68)
        lblJAJCMNJMMLNM_MName.Text = "Middle Name"
        txtJAJCMNJMMLNM_MName.Location = New Point(550, 88)
        txtJAJCMNJMMLNM_MName.Size = New Size(220, 23)

        grpJAJCMNJMMLNMPizza.Location = New Point(30, 130)
        grpJAJCMNJMMLNMPizza.Size = New Size(740, 125)
        grpJAJCMNJMMLNMPizza.Text = "Pizza Size"

        optJAJCMNJMMLNMSolo.AutoSize = True
        optJAJCMNJMMLNMSolo.Location = New Point(30, 45)
        optJAJCMNJMMLNMSolo.Text = "Solo - 50.00"

        optJAJCMNJMMLNMRegular.AutoSize = True
        optJAJCMNJMMLNMRegular.Location = New Point(290, 45)
        optJAJCMNJMMLNMRegular.Text = "Regular - 100.00"

        optJAJCMNJMMLNMFamily.AutoSize = True
        optJAJCMNJMMLNMFamily.Location = New Point(550, 45)
        optJAJCMNJMMLNMFamily.Text = "Family - 250.00"

        grpJAJCMNJMMLNMPizza.Controls.AddRange(New Control() {optJAJCMNJMMLNMSolo, optJAJCMNJMMLNMRegular, optJAJCMNJMMLNMFamily})

        grpJAJCMNJMMLNMToppings.Location = New Point(30, 270)
        grpJAJCMNJMMLNMToppings.Size = New Size(740, 90)
        grpJAJCMNJMMLNMToppings.Text = "Toppings"

        chkJAJCMNJMMLNMPine.AutoSize = True
        chkJAJCMNJMMLNMPine.Location = New Point(30, 38)
        chkJAJCMNJMMLNMPine.Text = "Pineapple - 20.00"

        chkJAJCMNJMMLNMHam.AutoSize = True
        chkJAJCMNJMMLNMHam.Location = New Point(290, 38)
        chkJAJCMNJMMLNMHam.Text = "Ham and Cheese - 50.00"

        chkJAJCMNJMMLNMCombo.AutoSize = True
        chkJAJCMNJMMLNMCombo.Location = New Point(550, 38)
        chkJAJCMNJMMLNMCombo.Text = "Combo - 100.00"

        grpJAJCMNJMMLNMToppings.Controls.AddRange(New Control() {chkJAJCMNJMMLNMPine, chkJAJCMNJMMLNMHam, chkJAJCMNJMMLNMCombo})

        lblJAJCMNJMMLNMDrinks.AutoSize = True
        lblJAJCMNJMMLNMDrinks.Location = New Point(30, 382)
        lblJAJCMNJMMLNMDrinks.Text = "Drink"
        cmbJAJCMNJMMLNMDrinks.Location = New Point(30, 402)
        cmbJAJCMNJMMLNMDrinks.Size = New Size(220, 23)
        cmbJAJCMNJMMLNMDrinks.DropDownStyle = ComboBoxStyle.DropDownList
        cmbJAJCMNJMMLNMDrinks.Items.AddRange(New Object() {"SOFTDRINKS 30.00", "COFFEE 50.00", "MANGO JUICE 50.00"})

        lblJAJCMNJMMLNMAmount.AutoSize = True
        lblJAJCMNJMMLNMAmount.Location = New Point(290, 382)
        lblJAJCMNJMMLNMAmount.Text = "Amount"
        txtJAJCMNJMMLNMAmount.Location = New Point(290, 402)
        txtJAJCMNJMMLNMAmount.ReadOnly = True
        txtJAJCMNJMMLNMAmount.Size = New Size(220, 23)

        btnJAJCMNJMMLNMAmount.Location = New Point(550, 400)
        btnJAJCMNJMMLNMAmount.Size = New Size(220, 28)
        btnJAJCMNJMMLNMAmount.Text = "Amount to Pay"

        btnJAJCMNJMMLNMReceipt.Location = New Point(30, 455)
        btnJAJCMNJMMLNMReceipt.Size = New Size(220, 35)
        btnJAJCMNJMMLNMReceipt.Text = "View Receipt"

        btnJAJCMNJMMLNMClear.Location = New Point(290, 455)
        btnJAJCMNJMMLNMClear.Size = New Size(220, 35)
        btnJAJCMNJMMLNMClear.Text = "Clear Entries"

        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 520)
        Controls.AddRange(New Control() {lblJAJCMNJMMLNMTTitle, lblJAJCMNJMMLNMLName, txtJAJCMNJMMLNMLName, lblJAJCMNJMMLNMName, txtJAJCMNJMMLNMName, lblJAJCMNJMMLNM_MName, txtJAJCMNJMMLNM_MName, grpJAJCMNJMMLNMPizza, grpJAJCMNJMMLNMToppings, lblJAJCMNJMMLNMDrinks, cmbJAJCMNJMMLNMDrinks, lblJAJCMNJMMLNMAmount, txtJAJCMNJMMLNMAmount, btnJAJCMNJMMLNMAmount, btnJAJCMNJMMLNMReceipt, btnJAJCMNJMMLNMClear})
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "JAJCMNJMMLNM Pizza Ordering System"

        ResumeLayout(False)
        PerformLayout()
    End Sub

End Class
