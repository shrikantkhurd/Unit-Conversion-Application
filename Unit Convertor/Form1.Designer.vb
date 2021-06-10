<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtConvert = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbtmCMtoM = New System.Windows.Forms.RadioButton()
        Me.RbtnFTtoIN = New System.Windows.Forms.RadioButton()
        Me.RbtnMtoFT = New System.Windows.Forms.RadioButton()
        Me.RbtnMtoKM = New System.Windows.Forms.RadioButton()
        Me.RbtnKMtoM = New System.Windows.Forms.RadioButton()
        Me.RbtnMLtoL = New System.Windows.Forms.RadioButton()
        Me.RbtnLtoML = New System.Windows.Forms.RadioButton()
        Me.RbtnGtoKG = New System.Windows.Forms.RadioButton()
        Me.RbtnKGtoG = New System.Windows.Forms.RadioButton()
        Me.RbtnKelvin = New System.Windows.Forms.RadioButton()
        Me.RbtnFtoC = New System.Windows.Forms.RadioButton()
        Me.RbtnCtoF = New System.Windows.Forms.RadioButton()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblConvert = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(221, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(529, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Application Of unit Conversion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(63, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(416, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter The Value To Convert : "
        '
        'txtConvert
        '
        Me.txtConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtConvert.Location = New System.Drawing.Point(521, 107)
        Me.txtConvert.Name = "txtConvert"
        Me.txtConvert.Size = New System.Drawing.Size(242, 38)
        Me.txtConvert.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbtmCMtoM)
        Me.GroupBox1.Controls.Add(Me.RbtnFTtoIN)
        Me.GroupBox1.Controls.Add(Me.RbtnMtoFT)
        Me.GroupBox1.Controls.Add(Me.RbtnMtoKM)
        Me.GroupBox1.Controls.Add(Me.RbtnKMtoM)
        Me.GroupBox1.Controls.Add(Me.RbtnMLtoL)
        Me.GroupBox1.Controls.Add(Me.RbtnLtoML)
        Me.GroupBox1.Controls.Add(Me.RbtnGtoKG)
        Me.GroupBox1.Controls.Add(Me.RbtnKGtoG)
        Me.GroupBox1.Controls.Add(Me.RbtnKelvin)
        Me.GroupBox1.Controls.Add(Me.RbtnFtoC)
        Me.GroupBox1.Controls.Add(Me.RbtnCtoF)
        Me.GroupBox1.Controls.Add(Me.lblLength)
        Me.GroupBox1.Controls.Add(Me.lblWeight)
        Me.GroupBox1.Controls.Add(Me.lblTemperature)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(921, 344)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Unit For Conversion "
        '
        'RbtmCMtoM
        '
        Me.RbtmCMtoM.AutoSize = True
        Me.RbtmCMtoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RbtmCMtoM.Location = New System.Drawing.Point(645, 294)
        Me.RbtmCMtoM.Name = "RbtmCMtoM"
        Me.RbtmCMtoM.Size = New System.Drawing.Size(275, 33)
        Me.RbtmCMtoM.TabIndex = 14
        Me.RbtmCMtoM.TabStop = True
        Me.RbtmCMtoM.Text = "Centimeter To Meter"
        Me.RbtmCMtoM.UseVisualStyleBackColor = True
        '
        'RbtnFTtoIN
        '
        Me.RbtnFTtoIN.AutoSize = True
        Me.RbtnFTtoIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RbtnFTtoIN.Location = New System.Drawing.Point(645, 245)
        Me.RbtnFTtoIN.Name = "RbtnFTtoIN"
        Me.RbtnFTtoIN.Size = New System.Drawing.Size(209, 33)
        Me.RbtnFTtoIN.TabIndex = 13
        Me.RbtnFTtoIN.TabStop = True
        Me.RbtnFTtoIN.Text = "Feet To Inches"
        Me.RbtnFTtoIN.UseVisualStyleBackColor = True
        '
        'RbtnMtoFT
        '
        Me.RbtnMtoFT.AutoSize = True
        Me.RbtnMtoFT.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RbtnMtoFT.Location = New System.Drawing.Point(645, 192)
        Me.RbtnMtoFT.Name = "RbtnMtoFT"
        Me.RbtnMtoFT.Size = New System.Drawing.Size(200, 33)
        Me.RbtnMtoFT.TabIndex = 12
        Me.RbtnMtoFT.TabStop = True
        Me.RbtnMtoFT.Text = "Meter To Feet"
        Me.RbtnMtoFT.UseVisualStyleBackColor = True
        '
        'RbtnMtoKM
        '
        Me.RbtnMtoKM.AutoSize = True
        Me.RbtnMtoKM.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RbtnMtoKM.Location = New System.Drawing.Point(645, 140)
        Me.RbtnMtoKM.Name = "RbtnMtoKM"
        Me.RbtnMtoKM.Size = New System.Drawing.Size(260, 33)
        Me.RbtnMtoKM.TabIndex = 11
        Me.RbtnMtoKM.TabStop = True
        Me.RbtnMtoKM.Text = "Meter To Kilometer"
        Me.RbtnMtoKM.UseVisualStyleBackColor = True
        '
        'RbtnKMtoM
        '
        Me.RbtnKMtoM.AutoSize = True
        Me.RbtnKMtoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RbtnKMtoM.Location = New System.Drawing.Point(645, 91)
        Me.RbtnKMtoM.Name = "RbtnKMtoM"
        Me.RbtnKMtoM.Size = New System.Drawing.Size(253, 33)
        Me.RbtnKMtoM.TabIndex = 10
        Me.RbtnKMtoM.TabStop = True
        Me.RbtnKMtoM.Text = "KilometerTo Meter"
        Me.RbtnKMtoM.UseVisualStyleBackColor = True
        '
        'RbtnMLtoL
        '
        Me.RbtnMLtoL.AutoSize = True
        Me.RbtnMLtoL.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RbtnMLtoL.Location = New System.Drawing.Point(328, 245)
        Me.RbtnMLtoL.Name = "RbtnMLtoL"
        Me.RbtnMLtoL.Size = New System.Drawing.Size(219, 33)
        Me.RbtnMLtoL.TabIndex = 9
        Me.RbtnMLtoL.TabStop = True
        Me.RbtnMLtoL.Text = "Mililiter To Liter"
        Me.RbtnMLtoL.UseVisualStyleBackColor = True
        '
        'RbtnLtoML
        '
        Me.RbtnLtoML.AutoSize = True
        Me.RbtnLtoML.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RbtnLtoML.Location = New System.Drawing.Point(328, 192)
        Me.RbtnLtoML.Name = "RbtnLtoML"
        Me.RbtnLtoML.Size = New System.Drawing.Size(209, 33)
        Me.RbtnLtoML.TabIndex = 8
        Me.RbtnLtoML.TabStop = True
        Me.RbtnLtoML.Text = "Liter to Mililiter"
        Me.RbtnLtoML.UseVisualStyleBackColor = True
        '
        'RbtnGtoKG
        '
        Me.RbtnGtoKG.AutoSize = True
        Me.RbtnGtoKG.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RbtnGtoKG.Location = New System.Drawing.Point(328, 140)
        Me.RbtnGtoKG.Name = "RbtnGtoKG"
        Me.RbtnGtoKG.Size = New System.Drawing.Size(238, 33)
        Me.RbtnGtoKG.TabIndex = 7
        Me.RbtnGtoKG.TabStop = True
        Me.RbtnGtoKG.Text = "Gram to Kilogram"
        Me.RbtnGtoKG.UseVisualStyleBackColor = True
        '
        'RbtnKGtoG
        '
        Me.RbtnKGtoG.AutoSize = True
        Me.RbtnKGtoG.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RbtnKGtoG.Location = New System.Drawing.Point(328, 91)
        Me.RbtnKGtoG.Name = "RbtnKGtoG"
        Me.RbtnKGtoG.Size = New System.Drawing.Size(248, 33)
        Me.RbtnKGtoG.TabIndex = 6
        Me.RbtnKGtoG.TabStop = True
        Me.RbtnKGtoG.Text = "Kilogram To Gram"
        Me.RbtnKGtoG.UseVisualStyleBackColor = True
        '
        'RbtnKelvin
        '
        Me.RbtnKelvin.AutoSize = True
        Me.RbtnKelvin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RbtnKelvin.Location = New System.Drawing.Point(21, 192)
        Me.RbtnKelvin.Name = "RbtnKelvin"
        Me.RbtnKelvin.Size = New System.Drawing.Size(106, 33)
        Me.RbtnKelvin.TabIndex = 5
        Me.RbtnKelvin.TabStop = True
        Me.RbtnKelvin.Text = "Kelvin"
        Me.RbtnKelvin.UseVisualStyleBackColor = True
        '
        'RbtnFtoC
        '
        Me.RbtnFtoC.AutoSize = True
        Me.RbtnFtoC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RbtnFtoC.Location = New System.Drawing.Point(21, 140)
        Me.RbtnFtoC.Name = "RbtnFtoC"
        Me.RbtnFtoC.Size = New System.Drawing.Size(292, 33)
        Me.RbtnFtoC.TabIndex = 4
        Me.RbtnFtoC.TabStop = True
        Me.RbtnFtoC.Text = "Fahrenheit To Celsius"
        Me.RbtnFtoC.UseVisualStyleBackColor = True
        '
        'RbtnCtoF
        '
        Me.RbtnCtoF.AutoSize = True
        Me.RbtnCtoF.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RbtnCtoF.Location = New System.Drawing.Point(21, 91)
        Me.RbtnCtoF.Name = "RbtnCtoF"
        Me.RbtnCtoF.Size = New System.Drawing.Size(292, 33)
        Me.RbtnCtoF.TabIndex = 3
        Me.RbtnCtoF.TabStop = True
        Me.RbtnCtoF.Text = "Celsius To Fahrenheit"
        Me.RbtnCtoF.UseVisualStyleBackColor = True
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLength.Location = New System.Drawing.Point(708, 44)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(108, 32)
        Me.lblLength.TabIndex = 2
        Me.lblLength.Text = "Length"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblWeight.Location = New System.Drawing.Point(398, 44)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(109, 32)
        Me.lblWeight.TabIndex = 1
        Me.lblWeight.Text = "Weight"
        '
        'lblTemperature
        '
        Me.lblTemperature.AutoSize = True
        Me.lblTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTemperature.Location = New System.Drawing.Point(21, 44)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(187, 32)
        Me.lblTemperature.TabIndex = 0
        Me.lblTemperature.Text = "Temperature"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(228, 526)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Convert :"
        '
        'lblConvert
        '
        Me.lblConvert.AutoSize = True
        Me.lblConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblConvert.Location = New System.Drawing.Point(491, 526)
        Me.lblConvert.Name = "lblConvert"
        Me.lblConvert.Size = New System.Drawing.Size(0, 32)
        Me.lblConvert.TabIndex = 5
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnReset.Location = New System.Drawing.Point(132, 578)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(162, 43)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnConvert.Location = New System.Drawing.Point(445, 578)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(162, 43)
        Me.btnConvert.TabIndex = 7
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnClose.Location = New System.Drawing.Point(744, 578)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(162, 43)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 647)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblConvert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtConvert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "unit Conversion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtConvert As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblLength As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblTemperature As Label
    Friend WithEvents RbtmCMtoM As RadioButton
    Friend WithEvents RbtnFTtoIN As RadioButton
    Friend WithEvents RbtnMtoFT As RadioButton
    Friend WithEvents RbtnMtoKM As RadioButton
    Friend WithEvents RbtnKMtoM As RadioButton
    Friend WithEvents RbtnMLtoL As RadioButton
    Friend WithEvents RbtnLtoML As RadioButton
    Friend WithEvents RbtnGtoKG As RadioButton
    Friend WithEvents RbtnKGtoG As RadioButton
    Friend WithEvents RbtnKelvin As RadioButton
    Friend WithEvents RbtnFtoC As RadioButton
    Friend WithEvents RbtnCtoF As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents lblConvert As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClose As Button
End Class
