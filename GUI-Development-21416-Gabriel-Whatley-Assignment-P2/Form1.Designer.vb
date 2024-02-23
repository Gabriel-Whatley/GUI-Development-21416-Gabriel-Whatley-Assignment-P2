<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pic_box_1 = New PictureBox()
        btn_compute = New Button()
        btn_clear = New Button()
        btn_exit = New Button()
        lbl_payroll_calculator = New Label()
        Label1 = New Label()
        lbl_gross_pay = New Label()
        box_input = New TextBox()
        lbl_fica = New Label()
        lbl_fed = New Label()
        lbl_state = New Label()
        lbl_net = New Label()
        out_fica = New Label()
        out_fed = New Label()
        out_state = New Label()
        out_net = New Label()
        CType(pic_box_1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pic_box_1
        ' 
        pic_box_1.Image = My.Resources.Resources.payroll
        pic_box_1.Location = New Point(0, 0)
        pic_box_1.Name = "pic_box_1"
        pic_box_1.Size = New Size(347, 232)
        pic_box_1.SizeMode = PictureBoxSizeMode.Zoom
        pic_box_1.TabIndex = 0
        pic_box_1.TabStop = False
        ' 
        ' btn_compute
        ' 
        btn_compute.BackColor = SystemColors.Highlight
        btn_compute.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btn_compute.ForeColor = SystemColors.ControlLightLight
        btn_compute.Location = New Point(129, 336)
        btn_compute.Name = "btn_compute"
        btn_compute.Size = New Size(160, 50)
        btn_compute.TabIndex = 1
        btn_compute.Text = "Compute"
        btn_compute.UseVisualStyleBackColor = False
        ' 
        ' btn_clear
        ' 
        btn_clear.BackColor = SystemColors.Highlight
        btn_clear.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btn_clear.ForeColor = SystemColors.ControlLightLight
        btn_clear.Location = New Point(328, 336)
        btn_clear.Name = "btn_clear"
        btn_clear.Size = New Size(160, 50)
        btn_clear.TabIndex = 2
        btn_clear.Text = "Clear"
        btn_clear.UseVisualStyleBackColor = False
        ' 
        ' btn_exit
        ' 
        btn_exit.BackColor = SystemColors.Highlight
        btn_exit.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btn_exit.ForeColor = SystemColors.ControlLightLight
        btn_exit.Location = New Point(526, 336)
        btn_exit.Name = "btn_exit"
        btn_exit.Size = New Size(160, 50)
        btn_exit.TabIndex = 3
        btn_exit.Text = "Exit"
        btn_exit.UseVisualStyleBackColor = False
        ' 
        ' lbl_payroll_calculator
        ' 
        lbl_payroll_calculator.AutoSize = True
        lbl_payroll_calculator.Font = New Font("Palatino Linotype", 36F, FontStyle.Bold)
        lbl_payroll_calculator.Location = New Point(367, 9)
        lbl_payroll_calculator.Name = "lbl_payroll_calculator"
        lbl_payroll_calculator.Size = New Size(423, 65)
        lbl_payroll_calculator.TabIndex = 4
        lbl_payroll_calculator.Text = "Payroll Calculator"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palatino Linotype", 36F, FontStyle.Bold)
        Label1.Location = New Point(440, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 130)
        Label1.TabIndex = 5
        Label1.Text = "Paycheck" & vbCrLf & "Calculation"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_gross_pay
        ' 
        lbl_gross_pay.AutoSize = True
        lbl_gross_pay.Font = New Font("Palatino Linotype", 25F, FontStyle.Bold)
        lbl_gross_pay.Location = New Point(212, 267)
        lbl_gross_pay.Name = "lbl_gross_pay"
        lbl_gross_pay.Size = New Size(276, 46)
        lbl_gross_pay.TabIndex = 6
        lbl_gross_pay.Text = "Enter Gross Pay:"
        ' 
        ' box_input
        ' 
        box_input.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        box_input.Location = New Point(494, 273)
        box_input.Name = "box_input"
        box_input.Size = New Size(162, 39)
        box_input.TabIndex = 7
        ' 
        ' lbl_fica
        ' 
        lbl_fica.AutoSize = True
        lbl_fica.Font = New Font("Palatino Linotype", 16F, FontStyle.Bold)
        lbl_fica.Location = New Point(69, 432)
        lbl_fica.Name = "lbl_fica"
        lbl_fica.Size = New Size(72, 29)
        lbl_fica.TabIndex = 8
        lbl_fica.Text = "FICA:"
        ' 
        ' lbl_fed
        ' 
        lbl_fed.AutoSize = True
        lbl_fed.Font = New Font("Palatino Linotype", 16F, FontStyle.Bold)
        lbl_fed.Location = New Point(287, 432)
        lbl_fed.Name = "lbl_fed"
        lbl_fed.Size = New Size(134, 29)
        lbl_fed.TabIndex = 9
        lbl_fed.Text = "Federal Tax:"
        ' 
        ' lbl_state
        ' 
        lbl_state.AutoSize = True
        lbl_state.Font = New Font("Palatino Linotype", 16F, FontStyle.Bold)
        lbl_state.Location = New Point(577, 432)
        lbl_state.Name = "lbl_state"
        lbl_state.Size = New Size(109, 29)
        lbl_state.TabIndex = 10
        lbl_state.Text = "State Tax:"
        ' 
        ' lbl_net
        ' 
        lbl_net.AutoSize = True
        lbl_net.Font = New Font("Palatino Linotype", 16F, FontStyle.Bold)
        lbl_net.Location = New Point(249, 495)
        lbl_net.Name = "lbl_net"
        lbl_net.Size = New Size(240, 29)
        lbl_net.TabIndex = 11
        lbl_net.Text = "Net Paycheck Income: "
        ' 
        ' out_fica
        ' 
        out_fica.AutoSize = True
        out_fica.Font = New Font("Palatino Linotype", 16F, FontStyle.Bold)
        out_fica.Location = New Point(147, 432)
        out_fica.Name = "out_fica"
        out_fica.Size = New Size(74, 29)
        out_fica.TabIndex = 12
        out_fica.Text = "100.00"
        ' 
        ' out_fed
        ' 
        out_fed.AutoSize = True
        out_fed.Font = New Font("Palatino Linotype", 16F, FontStyle.Bold)
        out_fed.Location = New Point(427, 432)
        out_fed.Name = "out_fed"
        out_fed.Size = New Size(74, 29)
        out_fed.TabIndex = 13
        out_fed.Text = "100.00"
        ' 
        ' out_state
        ' 
        out_state.AutoSize = True
        out_state.Font = New Font("Palatino Linotype", 16F, FontStyle.Bold)
        out_state.Location = New Point(692, 432)
        out_state.Name = "out_state"
        out_state.Size = New Size(74, 29)
        out_state.TabIndex = 14
        out_state.Text = "100.00"
        ' 
        ' out_net
        ' 
        out_net.AutoSize = True
        out_net.Font = New Font("Palatino Linotype", 16F, FontStyle.Bold)
        out_net.Location = New Point(495, 495)
        out_net.Name = "out_net"
        out_net.Size = New Size(74, 29)
        out_net.TabIndex = 15
        out_net.Text = "100.00"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(819, 570)
        Controls.Add(out_net)
        Controls.Add(out_state)
        Controls.Add(out_fed)
        Controls.Add(out_fica)
        Controls.Add(lbl_net)
        Controls.Add(lbl_state)
        Controls.Add(lbl_fed)
        Controls.Add(lbl_fica)
        Controls.Add(box_input)
        Controls.Add(lbl_gross_pay)
        Controls.Add(Label1)
        Controls.Add(lbl_payroll_calculator)
        Controls.Add(btn_exit)
        Controls.Add(btn_clear)
        Controls.Add(btn_compute)
        Controls.Add(pic_box_1)
        Name = "Form1"
        Text = "Payroll Every Two Weeks"
        CType(pic_box_1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pic_box_1 As PictureBox
    Friend WithEvents btn_compute As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_payroll_calculator As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_gross_pay As Label
    Friend WithEvents box_input As TextBox
    Friend WithEvents lbl_fica As Label
    Friend WithEvents lbl_fed As Label
    Friend WithEvents lbl_state As Label
    Friend WithEvents lbl_net As Label
    Friend WithEvents out_fica As Label
    Friend WithEvents out_fed As Label
    Friend WithEvents out_state As Label
    Friend WithEvents out_net As Label

End Class
