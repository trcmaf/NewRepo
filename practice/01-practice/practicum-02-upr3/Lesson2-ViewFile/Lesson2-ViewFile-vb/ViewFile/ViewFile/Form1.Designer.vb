<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.showButton = New System.Windows.Forms.Button
        Me.browseButton = New System.Windows.Forms.Button
        Me.displayTextBox = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.locationTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'showButton
        '
        Me.showButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showButton.Location = New System.Drawing.Point(476, 12)
        Me.showButton.Name = "showButton"
        Me.showButton.Size = New System.Drawing.Size(75, 23)
        Me.showButton.TabIndex = 9
        Me.showButton.Text = "View file"
        Me.showButton.UseVisualStyleBackColor = True
        '
        'browseButton
        '
        Me.browseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.browseButton.Location = New System.Drawing.Point(386, 13)
        Me.browseButton.Name = "browseButton"
        Me.browseButton.Size = New System.Drawing.Size(84, 23)
        Me.browseButton.TabIndex = 8
        Me.browseButton.Text = "Browse"
        Me.browseButton.UseVisualStyleBackColor = True
        '
        'displayTextBox
        '
        Me.displayTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.displayTextBox.Location = New System.Drawing.Point(17, 38)
        Me.displayTextBox.Multiline = True
        Me.displayTextBox.Name = "displayTextBox"
        Me.displayTextBox.ReadOnly = True
        Me.displayTextBox.Size = New System.Drawing.Size(535, 432)
        Me.displayTextBox.TabIndex = 7
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(18, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(51, 13)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Location:"
        '
        'locationTextBox
        '
        Me.locationTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.locationTextBox.Location = New System.Drawing.Point(75, 12)
        Me.locationTextBox.Name = "locationTextBox"
        Me.locationTextBox.Size = New System.Drawing.Size(305, 20)
        Me.locationTextBox.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 482)
        Me.Controls.Add(Me.showButton)
        Me.Controls.Add(Me.browseButton)
        Me.Controls.Add(Me.displayTextBox)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.locationTextBox)
        Me.MinimumSize = New System.Drawing.Size(250, 150)
        Me.Name = "Form1"
        Me.Text = "View File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents showButton As System.Windows.Forms.Button
    Private WithEvents browseButton As System.Windows.Forms.Button
    Private WithEvents displayTextBox As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents locationTextBox As System.Windows.Forms.TextBox

End Class
