<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bitenGorevler
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_bitenGorevler = New System.Windows.Forms.Label()
        Me.lb_bitenGorevler = New System.Windows.Forms.ListBox()
        Me.btn_rapor = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_bitenGorevler
        '
        Me.lbl_bitenGorevler.AutoSize = True
        Me.lbl_bitenGorevler.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_bitenGorevler.Location = New System.Drawing.Point(31, 29)
        Me.lbl_bitenGorevler.Name = "lbl_bitenGorevler"
        Me.lbl_bitenGorevler.Size = New System.Drawing.Size(93, 16)
        Me.lbl_bitenGorevler.TabIndex = 0
        Me.lbl_bitenGorevler.Text = "Biten Görevler"
        '
        'lb_bitenGorevler
        '
        Me.lb_bitenGorevler.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lb_bitenGorevler.FormattingEnabled = True
        Me.lb_bitenGorevler.ItemHeight = 16
        Me.lb_bitenGorevler.Items.AddRange(New Object() {"Personel ->Biten Görev 1", "Personel ->Biten Görev 2", "Personel ->Biten Görev 3", "Personel ->Biten Görev 4"})
        Me.lb_bitenGorevler.Location = New System.Drawing.Point(34, 57)
        Me.lb_bitenGorevler.Name = "lb_bitenGorevler"
        Me.lb_bitenGorevler.Size = New System.Drawing.Size(277, 564)
        Me.lb_bitenGorevler.TabIndex = 1
        '
        'btn_rapor
        '
        Me.btn_rapor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_rapor.Location = New System.Drawing.Point(914, 577)
        Me.btn_rapor.Name = "btn_rapor"
        Me.btn_rapor.Size = New System.Drawing.Size(98, 31)
        Me.btn_rapor.TabIndex = 2
        Me.btn_rapor.Text = "Rapor Oluştur"
        Me.btn_rapor.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(454, 57)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(46, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Gün"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(454, 80)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox2.TabIndex = 3
        Me.CheckBox2.Text = "Hafta"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(454, 103)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "Ay"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(368, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tarih:"
        '
        'bitenGorevler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1024, 620)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btn_rapor)
        Me.Controls.Add(Me.lb_bitenGorevler)
        Me.Controls.Add(Me.lbl_bitenGorevler)
        Me.MaximizeBox = False
        Me.Name = "bitenGorevler"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biten Görevler"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_bitenGorevler As Label
    Friend WithEvents lb_bitenGorevler As ListBox
    Friend WithEvents btn_rapor As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label1 As Label
End Class
