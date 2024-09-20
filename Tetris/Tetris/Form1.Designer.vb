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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Biden = New PictureBox()
        Timer1 = New Timer(components)
        Icecream = New PictureBox()
        GrimReaper = New PictureBox()
        CType(Biden, ComponentModel.ISupportInitialize).BeginInit()
        CType(Icecream, ComponentModel.ISupportInitialize).BeginInit()
        CType(GrimReaper, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Biden
        ' 
        Biden.Image = CType(resources.GetObject("Biden.Image"), Image)
        Biden.Location = New Point(201, 199)
        Biden.Name = "Biden"
        Biden.Size = New Size(140, 155)
        Biden.SizeMode = PictureBoxSizeMode.Zoom
        Biden.TabIndex = 0
        Biden.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Icecream
        ' 
        Icecream.Image = CType(resources.GetObject("Icecream.Image"), Image)
        Icecream.Location = New Point(282, 216)
        Icecream.Name = "Icecream"
        Icecream.Size = New Size(34, 37)
        Icecream.SizeMode = PictureBoxSizeMode.Zoom
        Icecream.TabIndex = 1
        Icecream.TabStop = False
        ' 
        ' GrimReaper
        ' 
        GrimReaper.Image = CType(resources.GetObject("GrimReaper.Image"), Image)
        GrimReaper.Location = New Point(28, 216)
        GrimReaper.Name = "GrimReaper"
        GrimReaper.Size = New Size(118, 157)
        GrimReaper.SizeMode = PictureBoxSizeMode.Zoom
        GrimReaper.TabIndex = 2
        GrimReaper.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(955, 718)
        Controls.Add(GrimReaper)
        Controls.Add(Icecream)
        Controls.Add(Biden)
        Name = "Form1"
        Text = "Form1"
        CType(Biden, ComponentModel.ISupportInitialize).EndInit()
        CType(Icecream, ComponentModel.ISupportInitialize).EndInit()
        CType(GrimReaper, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Biden As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Icecream As PictureBox
    Friend WithEvents GrimReaper As PictureBox

End Class
