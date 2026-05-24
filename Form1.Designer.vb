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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdoSmall = New System.Windows.Forms.RadioButton()
        Me.rdoMedium = New System.Windows.Forms.RadioButton()
        Me.rdoLarge = New System.Windows.Forms.RadioButton()
        Me.chkMushroom = New System.Windows.Forms.CheckBox()
        Me.chkSausage = New System.Windows.Forms.CheckBox()
        Me.chkOnions = New System.Windows.Forms.CheckBox()
        Me.chkGreenPepper = New System.Windows.Forms.CheckBox()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkSupreme = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkPlain = New System.Windows.Forms.CheckBox()
        Me.chkSauce = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(26, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 20)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Pizza Sizes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(203, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(107, 25)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Base Pizza"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(748, 86)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(111, 19)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Supreme Pizza"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(270, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PIZZZA SHOP"
        '
        'rdoSmall
        '
        Me.rdoSmall.AutoSize = True
        Me.rdoSmall.Location = New System.Drawing.Point(26, 125)
        Me.rdoSmall.Name = "rdoSmall"
        Me.rdoSmall.Size = New System.Drawing.Size(93, 20)
        Me.rdoSmall.TabIndex = 4
        Me.rdoSmall.TabStop = True
        Me.rdoSmall.Text = "Small - $10"
        Me.rdoSmall.UseVisualStyleBackColor = True
        '
        'rdoMedium
        '
        Me.rdoMedium.AutoSize = True
        Me.rdoMedium.Location = New System.Drawing.Point(26, 160)
        Me.rdoMedium.Name = "rdoMedium"
        Me.rdoMedium.Size = New System.Drawing.Size(107, 20)
        Me.rdoMedium.TabIndex = 5
        Me.rdoMedium.TabStop = True
        Me.rdoMedium.Text = "Medium - $12"
        Me.rdoMedium.UseVisualStyleBackColor = True
        '
        'rdoLarge
        '
        Me.rdoLarge.AutoSize = True
        Me.rdoLarge.Location = New System.Drawing.Point(26, 198)
        Me.rdoLarge.Name = "rdoLarge"
        Me.rdoLarge.Size = New System.Drawing.Size(94, 20)
        Me.rdoLarge.TabIndex = 6
        Me.rdoLarge.TabStop = True
        Me.rdoLarge.Text = "Large - $15"
        Me.rdoLarge.UseVisualStyleBackColor = True
        '
        'chkMushroom
        '
        Me.chkMushroom.AutoSize = True
        Me.chkMushroom.Location = New System.Drawing.Point(381, 160)
        Me.chkMushroom.Name = "chkMushroom"
        Me.chkMushroom.Size = New System.Drawing.Size(92, 20)
        Me.chkMushroom.TabIndex = 9
        Me.chkMushroom.Text = "Mushroom"
        Me.chkMushroom.UseVisualStyleBackColor = True
        '
        'chkSausage
        '
        Me.chkSausage.AutoSize = True
        Me.chkSausage.Location = New System.Drawing.Point(381, 198)
        Me.chkSausage.Name = "chkSausage"
        Me.chkSausage.Size = New System.Drawing.Size(84, 20)
        Me.chkSausage.TabIndex = 10
        Me.chkSausage.Text = "Sausage"
        Me.chkSausage.UseVisualStyleBackColor = True
        '
        'chkOnions
        '
        Me.chkOnions.AutoSize = True
        Me.chkOnions.Location = New System.Drawing.Point(381, 233)
        Me.chkOnions.Name = "chkOnions"
        Me.chkOnions.Size = New System.Drawing.Size(71, 20)
        Me.chkOnions.TabIndex = 11
        Me.chkOnions.Text = "Onions"
        Me.chkOnions.UseVisualStyleBackColor = True
        '
        'chkGreenPepper
        '
        Me.chkGreenPepper.AutoSize = True
        Me.chkGreenPepper.Location = New System.Drawing.Point(381, 265)
        Me.chkGreenPepper.Name = "chkGreenPepper"
        Me.chkGreenPepper.Size = New System.Drawing.Size(111, 20)
        Me.chkGreenPepper.TabIndex = 12
        Me.chkGreenPepper.Text = "GreenPepper"
        Me.chkGreenPepper.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(343, 381)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(103, 44)
        Me.btnOrder.TabIndex = 13
        Me.btnOrder.Text = "Place Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(970, 492)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(69, 265)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(79, 16)
        Me.lblCost.TabIndex = 15
        Me.lblCost.Text = "Pizza Cost :-"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(69, 301)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(67, 16)
        Me.lblTax.TabIndex = 16
        Me.lblTax.Text = "Tax(6%) :-"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(69, 334)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(96, 16)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.Text = "Total Amount ;-"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(381, 80)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(122, 25)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Extra Toppings"
        '
        'chkSupreme
        '
        Me.chkSupreme.AutoSize = True
        Me.chkSupreme.Location = New System.Drawing.Point(748, 160)
        Me.chkSupreme.Name = "chkSupreme"
        Me.chkSupreme.Size = New System.Drawing.Size(84, 20)
        Me.chkSupreme.TabIndex = 19
        Me.chkSupreme.Text = "Supreme"
        Me.chkSupreme.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(378, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Small = $1, Medium = $1.50, Large = $2.25 each"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(591, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(745, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(271, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Small = $15, Medium = $21, Large = $27 each"
        '
        'chkPlain
        '
        Me.chkPlain.AutoSize = True
        Me.chkPlain.Location = New System.Drawing.Point(203, 126)
        Me.chkPlain.Name = "chkPlain"
        Me.chkPlain.Size = New System.Drawing.Size(59, 20)
        Me.chkPlain.TabIndex = 23
        Me.chkPlain.Text = "Plain"
        Me.chkPlain.UseVisualStyleBackColor = True
        '
        'chkSauce
        '
        Me.chkSauce.AutoSize = True
        Me.chkSauce.Location = New System.Drawing.Point(203, 161)
        Me.chkSauce.Name = "chkSauce"
        Me.chkSauce.Size = New System.Drawing.Size(68, 20)
        Me.chkSauce.TabIndex = 24
        Me.chkSauce.Text = "Sauce"
        Me.chkSauce.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1057, 527)
        Me.Controls.Add(Me.chkSauce)
        Me.Controls.Add(Me.chkPlain)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkSupreme)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.chkGreenPepper)
        Me.Controls.Add(Me.chkOnions)
        Me.Controls.Add(Me.chkSausage)
        Me.Controls.Add(Me.chkMushroom)
        Me.Controls.Add(Me.rdoLarge)
        Me.Controls.Add(Me.rdoMedium)
        Me.Controls.Add(Me.rdoSmall)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rdoSmall As RadioButton
    Friend WithEvents rdoMedium As RadioButton
    Friend WithEvents rdoLarge As RadioButton
    Friend WithEvents chkMushroom As CheckBox
    Friend WithEvents chkSausage As CheckBox
    Friend WithEvents chkOnions As CheckBox
    Friend WithEvents chkGreenPepper As CheckBox
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCost As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkSupreme As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents chkPlain As CheckBox
    Friend WithEvents chkSauce As CheckBox
End Class
