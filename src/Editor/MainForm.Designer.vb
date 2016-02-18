<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.lstTerme = New System.Windows.Forms.ListBox
        Me.lblTerme = New System.Windows.Forms.Label
        Me.btnPlusTerme = New System.Windows.Forms.Button
        Me.btnMoinsTerme = New System.Windows.Forms.Button
        Me.lblAjoutTerme = New System.Windows.Forms.Label
        Me.lblValeurTerme = New System.Windows.Forms.Label
        Me.txtValeurTerme = New System.Windows.Forms.TextBox
        Me.btnAjouterTerme = New System.Windows.Forms.Button
        Me.pnlTerme = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.btnChargement = New System.Windows.Forms.Button
        Me.txtSujet = New System.Windows.Forms.TextBox
        Me.txtAuteurs = New System.Windows.Forms.TextBox
        Me.lblDomaine = New System.Windows.Forms.Label
        Me.txtNomFichier = New System.Windows.Forms.TextBox
        Me.lblNomFichier = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.btnSauvegarde = New System.Windows.Forms.Button
        Me.lstRegleDom = New System.Windows.Forms.ListBox
        Me.lblRegleDom = New System.Windows.Forms.Label
        Me.lblAuteur = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblSujet = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lblFait = New System.Windows.Forms.Label
        Me.btnMoinsFait = New System.Windows.Forms.Button
        Me.btnPlusFait = New System.Windows.Forms.Button
        Me.lstFait = New System.Windows.Forms.ListBox
        Me.pnlFait = New System.Windows.Forms.Panel
        Me.lblQuestionFait = New System.Windows.Forms.Label
        Me.txtQuestionFait = New System.Windows.Forms.TextBox
        Me.btnAjoutFait = New System.Windows.Forms.Button
        Me.lblCommFait = New System.Windows.Forms.Label
        Me.lblNomFait = New System.Windows.Forms.Label
        Me.txtCommFait = New System.Windows.Forms.TextBox
        Me.txtNomFait = New System.Windows.Forms.TextBox
        Me.btnTermeDch = New System.Windows.Forms.Button
        Me.btnTermeCh = New System.Windows.Forms.Button
        Me.lblTermeChoisi = New System.Windows.Forms.Label
        Me.lblTermeDis = New System.Windows.Forms.Label
        Me.lstTermeChoisi = New System.Windows.Forms.ListBox
        Me.lstTermeDis = New System.Windows.Forms.ListBox
        Me.lblAjoutFait = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.btnMoinsRegle = New System.Windows.Forms.Button
        Me.btnPlusRegle = New System.Windows.Forms.Button
        Me.lblRegle = New System.Windows.Forms.Label
        Me.lstRegle = New System.Windows.Forms.ListBox
        Me.pnlRegle = New System.Windows.Forms.Panel
        Me.lstFaitChoisiPost = New System.Windows.Forms.ListBox
        Me.btnFaitPostDch = New System.Windows.Forms.Button
        Me.btnFaitPostCh = New System.Windows.Forms.Button
        Me.lblPostCond = New System.Windows.Forms.Label
        Me.btnAjoutRegle = New System.Windows.Forms.Button
        Me.lblNomRegle = New System.Windows.Forms.Label
        Me.txtNomRegle = New System.Windows.Forms.TextBox
        Me.btnFaitPreDch = New System.Windows.Forms.Button
        Me.btnFaitPreCh = New System.Windows.Forms.Button
        Me.lblFaitChoisi = New System.Windows.Forms.Label
        Me.lblFaitDis = New System.Windows.Forms.Label
        Me.lstFaitChoisiPre = New System.Windows.Forms.ListBox
        Me.lstFaitDis = New System.Windows.Forms.ListBox
        Me.lblAjoutRegle = New System.Windows.Forms.Label
        Me.chkNegatif = New System.Windows.Forms.CheckBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.pnlTerme.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.pnlFait.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.pnlRegle.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripSeparator1, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(147, 22)
        Me.ToolStripMenuItem2.Text = "New"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(147, 22)
        Me.ToolStripMenuItem3.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(144, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.CloseToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(24, 20)
        Me.AboutToolStripMenuItem.Text = "?"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripMenuItem1.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Image = CType(resources.GetObject("AboutToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.AboutToolStripMenuItem1.Text = "About..."
        '
        'lstTerme
        '
        Me.lstTerme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTerme.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTerme.FormattingEnabled = True
        Me.lstTerme.ItemHeight = 19
        Me.lstTerme.Location = New System.Drawing.Point(128, 44)
        Me.lstTerme.Name = "lstTerme"
        Me.lstTerme.Size = New System.Drawing.Size(283, 116)
        Me.lstTerme.TabIndex = 18
        '
        'lblTerme
        '
        Me.lblTerme.AllowDrop = True
        Me.lblTerme.AutoSize = True
        Me.lblTerme.BackColor = System.Drawing.Color.White
        Me.lblTerme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTerme.Font = New System.Drawing.Font("Rockwell Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerme.Location = New System.Drawing.Point(204, 13)
        Me.lblTerme.Name = "lblTerme"
        Me.lblTerme.Size = New System.Drawing.Size(136, 24)
        Me.lblTerme.TabIndex = 19
        Me.lblTerme.Text = "Liste des termes"
        Me.lblTerme.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnPlusTerme
        '
        Me.btnPlusTerme.BackColor = System.Drawing.Color.White
        Me.btnPlusTerme.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlusTerme.Image = CType(resources.GetObject("btnPlusTerme.Image"), System.Drawing.Image)
        Me.btnPlusTerme.Location = New System.Drawing.Point(207, 180)
        Me.btnPlusTerme.Name = "btnPlusTerme"
        Me.btnPlusTerme.Size = New System.Drawing.Size(47, 23)
        Me.btnPlusTerme.TabIndex = 6
        Me.btnPlusTerme.UseVisualStyleBackColor = False
        '
        'btnMoinsTerme
        '
        Me.btnMoinsTerme.BackColor = System.Drawing.Color.White
        Me.btnMoinsTerme.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoinsTerme.Image = CType(resources.GetObject("btnMoinsTerme.Image"), System.Drawing.Image)
        Me.btnMoinsTerme.Location = New System.Drawing.Point(294, 180)
        Me.btnMoinsTerme.Name = "btnMoinsTerme"
        Me.btnMoinsTerme.Size = New System.Drawing.Size(46, 23)
        Me.btnMoinsTerme.TabIndex = 7
        Me.btnMoinsTerme.UseVisualStyleBackColor = False
        '
        'lblAjoutTerme
        '
        Me.lblAjoutTerme.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAjoutTerme.BackColor = System.Drawing.Color.White
        Me.lblAjoutTerme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAjoutTerme.Font = New System.Drawing.Font("Rockwell Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAjoutTerme.Location = New System.Drawing.Point(0, 17)
        Me.lblAjoutTerme.Name = "lblAjoutTerme"
        Me.lblAjoutTerme.Size = New System.Drawing.Size(482, 27)
        Me.lblAjoutTerme.TabIndex = 22
        Me.lblAjoutTerme.Text = "Ajout d'un terme"
        Me.lblAjoutTerme.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblValeurTerme
        '
        Me.lblValeurTerme.AutoSize = True
        Me.lblValeurTerme.BackColor = System.Drawing.Color.White
        Me.lblValeurTerme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblValeurTerme.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValeurTerme.Location = New System.Drawing.Point(27, 61)
        Me.lblValeurTerme.Name = "lblValeurTerme"
        Me.lblValeurTerme.Size = New System.Drawing.Size(53, 21)
        Me.lblValeurTerme.TabIndex = 26
        Me.lblValeurTerme.Text = "Valeur"
        '
        'txtValeurTerme
        '
        Me.txtValeurTerme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValeurTerme.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValeurTerme.Location = New System.Drawing.Point(104, 58)
        Me.txtValeurTerme.Name = "txtValeurTerme"
        Me.txtValeurTerme.Size = New System.Drawing.Size(98, 26)
        Me.txtValeurTerme.TabIndex = 4
        '
        'btnAjouterTerme
        '
        Me.btnAjouterTerme.BackColor = System.Drawing.Color.White
        Me.btnAjouterTerme.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouterTerme.Image = CType(resources.GetObject("btnAjouterTerme.Image"), System.Drawing.Image)
        Me.btnAjouterTerme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjouterTerme.Location = New System.Drawing.Point(190, 135)
        Me.btnAjouterTerme.Name = "btnAjouterTerme"
        Me.btnAjouterTerme.Size = New System.Drawing.Size(156, 30)
        Me.btnAjouterTerme.TabIndex = 5
        Me.btnAjouterTerme.Text = "Ajouter le terme"
        Me.btnAjouterTerme.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjouterTerme.UseVisualStyleBackColor = False
        '
        'pnlTerme
        '
        Me.pnlTerme.BackColor = System.Drawing.Color.Transparent
        Me.pnlTerme.Controls.Add(Me.btnAjouterTerme)
        Me.pnlTerme.Controls.Add(Me.lblAjoutTerme)
        Me.pnlTerme.Controls.Add(Me.lblValeurTerme)
        Me.pnlTerme.Controls.Add(Me.txtValeurTerme)
        Me.pnlTerme.Location = New System.Drawing.Point(18, 228)
        Me.pnlTerme.Name = "pnlTerme"
        Me.pnlTerme.Size = New System.Drawing.Size(485, 168)
        Me.pnlTerme.TabIndex = 36
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(536, 590)
        Me.TabControl1.TabIndex = 44
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImage = Global.Editor.My.Resources.Resources.arnold_conan_republican
        Me.TabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage4.Controls.Add(Me.btnChargement)
        Me.TabPage4.Controls.Add(Me.txtSujet)
        Me.TabPage4.Controls.Add(Me.txtAuteurs)
        Me.TabPage4.Controls.Add(Me.lblDomaine)
        Me.TabPage4.Controls.Add(Me.txtNomFichier)
        Me.TabPage4.Controls.Add(Me.lblNomFichier)
        Me.TabPage4.Controls.Add(Me.txtDescription)
        Me.TabPage4.Controls.Add(Me.btnSauvegarde)
        Me.TabPage4.Controls.Add(Me.lstRegleDom)
        Me.TabPage4.Controls.Add(Me.lblRegleDom)
        Me.TabPage4.Controls.Add(Me.lblAuteur)
        Me.TabPage4.Controls.Add(Me.lblDescription)
        Me.TabPage4.Controls.Add(Me.lblSujet)
        Me.TabPage4.Location = New System.Drawing.Point(4, 31)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(528, 555)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Domaine"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnChargement
        '
        Me.btnChargement.BackColor = System.Drawing.Color.White
        Me.btnChargement.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChargement.Image = CType(resources.GetObject("btnChargement.Image"), System.Drawing.Image)
        Me.btnChargement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChargement.Location = New System.Drawing.Point(36, 418)
        Me.btnChargement.Name = "btnChargement"
        Me.btnChargement.Size = New System.Drawing.Size(179, 36)
        Me.btnChargement.TabIndex = 5
        Me.btnChargement.Text = "Charger un domaine"
        Me.btnChargement.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChargement.UseVisualStyleBackColor = False
        '
        'txtSujet
        '
        Me.txtSujet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSujet.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSujet.Location = New System.Drawing.Point(174, 101)
        Me.txtSujet.Name = "txtSujet"
        Me.txtSujet.Size = New System.Drawing.Size(335, 26)
        Me.txtSujet.TabIndex = 2
        '
        'txtAuteurs
        '
        Me.txtAuteurs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuteurs.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuteurs.Location = New System.Drawing.Point(173, 177)
        Me.txtAuteurs.Name = "txtAuteurs"
        Me.txtAuteurs.Size = New System.Drawing.Size(335, 26)
        Me.txtAuteurs.TabIndex = 4
        '
        'lblDomaine
        '
        Me.lblDomaine.AutoSize = True
        Me.lblDomaine.BackColor = System.Drawing.Color.White
        Me.lblDomaine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDomaine.Font = New System.Drawing.Font("Rockwell Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomaine.Location = New System.Drawing.Point(228, 24)
        Me.lblDomaine.Name = "lblDomaine"
        Me.lblDomaine.Size = New System.Drawing.Size(79, 24)
        Me.lblDomaine.TabIndex = 47
        Me.lblDomaine.Text = "Domaine"
        Me.lblDomaine.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNomFichier
        '
        Me.txtNomFichier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomFichier.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomFichier.Location = New System.Drawing.Point(174, 65)
        Me.txtNomFichier.Name = "txtNomFichier"
        Me.txtNomFichier.Size = New System.Drawing.Size(335, 26)
        Me.txtNomFichier.TabIndex = 1
        '
        'lblNomFichier
        '
        Me.lblNomFichier.AutoSize = True
        Me.lblNomFichier.BackColor = System.Drawing.Color.White
        Me.lblNomFichier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNomFichier.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomFichier.Location = New System.Drawing.Point(32, 68)
        Me.lblNomFichier.Name = "lblNomFichier"
        Me.lblNomFichier.Size = New System.Drawing.Size(109, 21)
        Me.lblNomFichier.TabIndex = 7
        Me.lblNomFichier.Text = "Nom du fichier"
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(174, 138)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(335, 26)
        Me.txtDescription.TabIndex = 3
        '
        'btnSauvegarde
        '
        Me.btnSauvegarde.BackColor = System.Drawing.Color.White
        Me.btnSauvegarde.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSauvegarde.Image = CType(resources.GetObject("btnSauvegarde.Image"), System.Drawing.Image)
        Me.btnSauvegarde.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSauvegarde.Location = New System.Drawing.Point(304, 418)
        Me.btnSauvegarde.Name = "btnSauvegarde"
        Me.btnSauvegarde.Size = New System.Drawing.Size(204, 36)
        Me.btnSauvegarde.TabIndex = 6
        Me.btnSauvegarde.Text = "Sauvegarder le domaine"
        Me.btnSauvegarde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSauvegarde.UseVisualStyleBackColor = False
        '
        'lstRegleDom
        '
        Me.lstRegleDom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstRegleDom.Enabled = False
        Me.lstRegleDom.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRegleDom.FormattingEnabled = True
        Me.lstRegleDom.ItemHeight = 19
        Me.lstRegleDom.Location = New System.Drawing.Point(96, 262)
        Me.lstRegleDom.Name = "lstRegleDom"
        Me.lstRegleDom.Size = New System.Drawing.Size(328, 135)
        Me.lstRegleDom.TabIndex = 4
        '
        'lblRegleDom
        '
        Me.lblRegleDom.AutoSize = True
        Me.lblRegleDom.BackColor = System.Drawing.Color.White
        Me.lblRegleDom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRegleDom.Font = New System.Drawing.Font("Rockwell Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegleDom.Location = New System.Drawing.Point(158, 228)
        Me.lblRegleDom.Name = "lblRegleDom"
        Me.lblRegleDom.Size = New System.Drawing.Size(226, 24)
        Me.lblRegleDom.TabIndex = 3
        Me.lblRegleDom.Text = "Liste des règles du domaine"
        '
        'lblAuteur
        '
        Me.lblAuteur.AutoSize = True
        Me.lblAuteur.BackColor = System.Drawing.Color.White
        Me.lblAuteur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAuteur.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuteur.Location = New System.Drawing.Point(32, 180)
        Me.lblAuteur.Name = "lblAuteur"
        Me.lblAuteur.Size = New System.Drawing.Size(60, 21)
        Me.lblAuteur.TabIndex = 2
        Me.lblAuteur.Text = "Auteurs"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.White
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescription.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(32, 141)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(85, 21)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Description"
        '
        'lblSujet
        '
        Me.lblSujet.AutoSize = True
        Me.lblSujet.BackColor = System.Drawing.Color.White
        Me.lblSujet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSujet.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSujet.Location = New System.Drawing.Point(32, 104)
        Me.lblSujet.Name = "lblSujet"
        Me.lblSujet.Size = New System.Drawing.Size(43, 21)
        Me.lblSujet.TabIndex = 0
        Me.lblSujet.Text = "Sujet"
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.Editor.My.Resources.Resources.arnold_conan_republican
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.pnlTerme)
        Me.TabPage1.Controls.Add(Me.lblTerme)
        Me.TabPage1.Controls.Add(Me.lstTerme)
        Me.TabPage1.Controls.Add(Me.btnPlusTerme)
        Me.TabPage1.Controls.Add(Me.btnMoinsTerme)
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(528, 555)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Termes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.Editor.My.Resources.Resources.arnold_conan_republican
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.lblFait)
        Me.TabPage2.Controls.Add(Me.btnMoinsFait)
        Me.TabPage2.Controls.Add(Me.btnPlusFait)
        Me.TabPage2.Controls.Add(Me.lstFait)
        Me.TabPage2.Controls.Add(Me.pnlFait)
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(528, 555)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Faits"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblFait
        '
        Me.lblFait.AutoSize = True
        Me.lblFait.BackColor = System.Drawing.Color.White
        Me.lblFait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFait.Font = New System.Drawing.Font("Rockwell Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFait.Location = New System.Drawing.Point(211, 13)
        Me.lblFait.Name = "lblFait"
        Me.lblFait.Size = New System.Drawing.Size(119, 24)
        Me.lblFait.TabIndex = 44
        Me.lblFait.Text = "Liste des faits"
        Me.lblFait.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnMoinsFait
        '
        Me.btnMoinsFait.BackColor = System.Drawing.Color.White
        Me.btnMoinsFait.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoinsFait.Image = CType(resources.GetObject("btnMoinsFait.Image"), System.Drawing.Image)
        Me.btnMoinsFait.Location = New System.Drawing.Point(291, 180)
        Me.btnMoinsFait.Name = "btnMoinsFait"
        Me.btnMoinsFait.Size = New System.Drawing.Size(47, 23)
        Me.btnMoinsFait.TabIndex = 43
        Me.btnMoinsFait.UseVisualStyleBackColor = False
        '
        'btnPlusFait
        '
        Me.btnPlusFait.BackColor = System.Drawing.Color.White
        Me.btnPlusFait.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlusFait.Image = CType(resources.GetObject("btnPlusFait.Image"), System.Drawing.Image)
        Me.btnPlusFait.Location = New System.Drawing.Point(207, 180)
        Me.btnPlusFait.Name = "btnPlusFait"
        Me.btnPlusFait.Size = New System.Drawing.Size(47, 23)
        Me.btnPlusFait.TabIndex = 42
        Me.btnPlusFait.UseVisualStyleBackColor = False
        '
        'lstFait
        '
        Me.lstFait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstFait.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFait.FormattingEnabled = True
        Me.lstFait.ItemHeight = 19
        Me.lstFait.Location = New System.Drawing.Point(128, 44)
        Me.lstFait.Name = "lstFait"
        Me.lstFait.Size = New System.Drawing.Size(284, 116)
        Me.lstFait.TabIndex = 41
        '
        'pnlFait
        '
        Me.pnlFait.BackColor = System.Drawing.Color.Transparent
        Me.pnlFait.Controls.Add(Me.lblQuestionFait)
        Me.pnlFait.Controls.Add(Me.txtQuestionFait)
        Me.pnlFait.Controls.Add(Me.btnAjoutFait)
        Me.pnlFait.Controls.Add(Me.lblCommFait)
        Me.pnlFait.Controls.Add(Me.lblNomFait)
        Me.pnlFait.Controls.Add(Me.txtCommFait)
        Me.pnlFait.Controls.Add(Me.txtNomFait)
        Me.pnlFait.Controls.Add(Me.btnTermeDch)
        Me.pnlFait.Controls.Add(Me.btnTermeCh)
        Me.pnlFait.Controls.Add(Me.lblTermeChoisi)
        Me.pnlFait.Controls.Add(Me.lblTermeDis)
        Me.pnlFait.Controls.Add(Me.lstTermeChoisi)
        Me.pnlFait.Controls.Add(Me.lstTermeDis)
        Me.pnlFait.Controls.Add(Me.lblAjoutFait)
        Me.pnlFait.Location = New System.Drawing.Point(18, 228)
        Me.pnlFait.Name = "pnlFait"
        Me.pnlFait.Size = New System.Drawing.Size(492, 316)
        Me.pnlFait.TabIndex = 38
        '
        'lblQuestionFait
        '
        Me.lblQuestionFait.AutoSize = True
        Me.lblQuestionFait.BackColor = System.Drawing.Color.White
        Me.lblQuestionFait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuestionFait.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionFait.Location = New System.Drawing.Point(12, 254)
        Me.lblQuestionFait.Name = "lblQuestionFait"
        Me.lblQuestionFait.Size = New System.Drawing.Size(67, 21)
        Me.lblQuestionFait.TabIndex = 46
        Me.lblQuestionFait.Text = "Question"
        Me.lblQuestionFait.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtQuestionFait
        '
        Me.txtQuestionFait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuestionFait.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestionFait.Location = New System.Drawing.Point(136, 251)
        Me.txtQuestionFait.Name = "txtQuestionFait"
        Me.txtQuestionFait.Size = New System.Drawing.Size(342, 26)
        Me.txtQuestionFait.TabIndex = 6
        '
        'btnAjoutFait
        '
        Me.btnAjoutFait.BackColor = System.Drawing.Color.White
        Me.btnAjoutFait.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjoutFait.Image = CType(resources.GetObject("btnAjoutFait.Image"), System.Drawing.Image)
        Me.btnAjoutFait.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjoutFait.Location = New System.Drawing.Point(190, 282)
        Me.btnAjoutFait.Name = "btnAjoutFait"
        Me.btnAjoutFait.Size = New System.Drawing.Size(148, 30)
        Me.btnAjoutFait.TabIndex = 7
        Me.btnAjoutFait.Text = "Ajouter le fait"
        Me.btnAjoutFait.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjoutFait.UseVisualStyleBackColor = False
        '
        'lblCommFait
        '
        Me.lblCommFait.AutoSize = True
        Me.lblCommFait.BackColor = System.Drawing.Color.White
        Me.lblCommFait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommFait.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommFait.Location = New System.Drawing.Point(12, 211)
        Me.lblCommFait.Name = "lblCommFait"
        Me.lblCommFait.Size = New System.Drawing.Size(97, 21)
        Me.lblCommFait.TabIndex = 43
        Me.lblCommFait.Text = "Commentaire"
        '
        'lblNomFait
        '
        Me.lblNomFait.AutoSize = True
        Me.lblNomFait.BackColor = System.Drawing.Color.White
        Me.lblNomFait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNomFait.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomFait.Location = New System.Drawing.Point(13, 169)
        Me.lblNomFait.Name = "lblNomFait"
        Me.lblNomFait.Size = New System.Drawing.Size(40, 21)
        Me.lblNomFait.TabIndex = 44
        Me.lblNomFait.Text = "Nom"
        '
        'txtCommFait
        '
        Me.txtCommFait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCommFait.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommFait.Location = New System.Drawing.Point(136, 208)
        Me.txtCommFait.Name = "txtCommFait"
        Me.txtCommFait.Size = New System.Drawing.Size(342, 26)
        Me.txtCommFait.TabIndex = 5
        '
        'txtNomFait
        '
        Me.txtNomFait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomFait.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomFait.Location = New System.Drawing.Point(136, 166)
        Me.txtNomFait.Name = "txtNomFait"
        Me.txtNomFait.Size = New System.Drawing.Size(342, 26)
        Me.txtNomFait.TabIndex = 4
        '
        'btnTermeDch
        '
        Me.btnTermeDch.BackColor = System.Drawing.Color.White
        Me.btnTermeDch.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTermeDch.Image = CType(resources.GetObject("btnTermeDch.Image"), System.Drawing.Image)
        Me.btnTermeDch.Location = New System.Drawing.Point(222, 113)
        Me.btnTermeDch.Name = "btnTermeDch"
        Me.btnTermeDch.Size = New System.Drawing.Size(47, 23)
        Me.btnTermeDch.TabIndex = 42
        Me.btnTermeDch.UseVisualStyleBackColor = False
        '
        'btnTermeCh
        '
        Me.btnTermeCh.BackColor = System.Drawing.Color.White
        Me.btnTermeCh.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTermeCh.Image = CType(resources.GetObject("btnTermeCh.Image"), System.Drawing.Image)
        Me.btnTermeCh.Location = New System.Drawing.Point(222, 90)
        Me.btnTermeCh.Name = "btnTermeCh"
        Me.btnTermeCh.Size = New System.Drawing.Size(47, 23)
        Me.btnTermeCh.TabIndex = 38
        Me.btnTermeCh.UseVisualStyleBackColor = False
        '
        'lblTermeChoisi
        '
        Me.lblTermeChoisi.AutoSize = True
        Me.lblTermeChoisi.BackColor = System.Drawing.Color.White
        Me.lblTermeChoisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTermeChoisi.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTermeChoisi.Location = New System.Drawing.Point(299, 42)
        Me.lblTermeChoisi.Name = "lblTermeChoisi"
        Me.lblTermeChoisi.Size = New System.Drawing.Size(95, 21)
        Me.lblTermeChoisi.TabIndex = 41
        Me.lblTermeChoisi.Text = "Terme choisi"
        '
        'lblTermeDis
        '
        Me.lblTermeDis.AutoSize = True
        Me.lblTermeDis.BackColor = System.Drawing.Color.White
        Me.lblTermeDis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTermeDis.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTermeDis.Location = New System.Drawing.Point(13, 42)
        Me.lblTermeDis.Name = "lblTermeDis"
        Me.lblTermeDis.Size = New System.Drawing.Size(194, 21)
        Me.lblTermeDis.TabIndex = 40
        Me.lblTermeDis.Text = "Liste des termes disponibles"
        '
        'lstTermeChoisi
        '
        Me.lstTermeChoisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTermeChoisi.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTermeChoisi.FormattingEnabled = True
        Me.lstTermeChoisi.ItemHeight = 19
        Me.lstTermeChoisi.Location = New System.Drawing.Point(302, 101)
        Me.lstTermeChoisi.Name = "lstTermeChoisi"
        Me.lstTermeChoisi.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstTermeChoisi.Size = New System.Drawing.Size(176, 21)
        Me.lstTermeChoisi.TabIndex = 39
        '
        'lstTermeDis
        '
        Me.lstTermeDis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTermeDis.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTermeDis.FormattingEnabled = True
        Me.lstTermeDis.ItemHeight = 19
        Me.lstTermeDis.Location = New System.Drawing.Point(16, 73)
        Me.lstTermeDis.Name = "lstTermeDis"
        Me.lstTermeDis.Size = New System.Drawing.Size(176, 78)
        Me.lstTermeDis.TabIndex = 38
        '
        'lblAjoutFait
        '
        Me.lblAjoutFait.BackColor = System.Drawing.Color.White
        Me.lblAjoutFait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAjoutFait.Font = New System.Drawing.Font("Rockwell Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAjoutFait.Location = New System.Drawing.Point(3, 16)
        Me.lblAjoutFait.Name = "lblAjoutFait"
        Me.lblAjoutFait.Size = New System.Drawing.Size(486, 22)
        Me.lblAjoutFait.TabIndex = 0
        Me.lblAjoutFait.Text = "Ajout d'un fait"
        Me.lblAjoutFait.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = Global.Editor.My.Resources.Resources.arnold_conan_republican
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage3.Controls.Add(Me.btnMoinsRegle)
        Me.TabPage3.Controls.Add(Me.btnPlusRegle)
        Me.TabPage3.Controls.Add(Me.lblRegle)
        Me.TabPage3.Controls.Add(Me.lstRegle)
        Me.TabPage3.Controls.Add(Me.pnlRegle)
        Me.TabPage3.Location = New System.Drawing.Point(4, 31)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(528, 555)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Règles"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnMoinsRegle
        '
        Me.btnMoinsRegle.BackColor = System.Drawing.Color.White
        Me.btnMoinsRegle.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoinsRegle.Image = CType(resources.GetObject("btnMoinsRegle.Image"), System.Drawing.Image)
        Me.btnMoinsRegle.Location = New System.Drawing.Point(291, 180)
        Me.btnMoinsRegle.Name = "btnMoinsRegle"
        Me.btnMoinsRegle.Size = New System.Drawing.Size(47, 23)
        Me.btnMoinsRegle.TabIndex = 48
        Me.btnMoinsRegle.UseVisualStyleBackColor = False
        '
        'btnPlusRegle
        '
        Me.btnPlusRegle.BackColor = System.Drawing.Color.White
        Me.btnPlusRegle.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlusRegle.Image = CType(resources.GetObject("btnPlusRegle.Image"), System.Drawing.Image)
        Me.btnPlusRegle.Location = New System.Drawing.Point(207, 180)
        Me.btnPlusRegle.Name = "btnPlusRegle"
        Me.btnPlusRegle.Size = New System.Drawing.Size(47, 23)
        Me.btnPlusRegle.TabIndex = 47
        Me.btnPlusRegle.UseVisualStyleBackColor = False
        '
        'lblRegle
        '
        Me.lblRegle.AutoSize = True
        Me.lblRegle.BackColor = System.Drawing.Color.White
        Me.lblRegle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRegle.Font = New System.Drawing.Font("Rockwell Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegle.Location = New System.Drawing.Point(199, 13)
        Me.lblRegle.Name = "lblRegle"
        Me.lblRegle.Size = New System.Drawing.Size(129, 24)
        Me.lblRegle.TabIndex = 46
        Me.lblRegle.Text = "Liste des règles"
        Me.lblRegle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lstRegle
        '
        Me.lstRegle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstRegle.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRegle.FormattingEnabled = True
        Me.lstRegle.ItemHeight = 19
        Me.lstRegle.Location = New System.Drawing.Point(128, 44)
        Me.lstRegle.Name = "lstRegle"
        Me.lstRegle.Size = New System.Drawing.Size(283, 116)
        Me.lstRegle.TabIndex = 45
        '
        'pnlRegle
        '
        Me.pnlRegle.BackColor = System.Drawing.Color.Transparent
        Me.pnlRegle.Controls.Add(Me.lstFaitChoisiPost)
        Me.pnlRegle.Controls.Add(Me.btnFaitPostDch)
        Me.pnlRegle.Controls.Add(Me.btnFaitPostCh)
        Me.pnlRegle.Controls.Add(Me.lblPostCond)
        Me.pnlRegle.Controls.Add(Me.btnAjoutRegle)
        Me.pnlRegle.Controls.Add(Me.lblNomRegle)
        Me.pnlRegle.Controls.Add(Me.txtNomRegle)
        Me.pnlRegle.Controls.Add(Me.btnFaitPreDch)
        Me.pnlRegle.Controls.Add(Me.btnFaitPreCh)
        Me.pnlRegle.Controls.Add(Me.lblFaitChoisi)
        Me.pnlRegle.Controls.Add(Me.lblFaitDis)
        Me.pnlRegle.Controls.Add(Me.lstFaitChoisiPre)
        Me.pnlRegle.Controls.Add(Me.lstFaitDis)
        Me.pnlRegle.Controls.Add(Me.lblAjoutRegle)
        Me.pnlRegle.Controls.Add(Me.chkNegatif)
        Me.pnlRegle.Location = New System.Drawing.Point(7, 209)
        Me.pnlRegle.Name = "pnlRegle"
        Me.pnlRegle.Size = New System.Drawing.Size(518, 328)
        Me.pnlRegle.TabIndex = 44
        '
        'lstFaitChoisiPost
        '
        Me.lstFaitChoisiPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstFaitChoisiPost.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFaitChoisiPost.FormattingEnabled = True
        Me.lstFaitChoisiPost.ItemHeight = 19
        Me.lstFaitChoisiPost.Location = New System.Drawing.Point(293, 206)
        Me.lstFaitChoisiPost.Name = "lstFaitChoisiPost"
        Me.lstFaitChoisiPost.Size = New System.Drawing.Size(209, 21)
        Me.lstFaitChoisiPost.TabIndex = 63
        '
        'btnFaitPostDch
        '
        Me.btnFaitPostDch.BackColor = System.Drawing.Color.White
        Me.btnFaitPostDch.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFaitPostDch.Image = CType(resources.GetObject("btnFaitPostDch.Image"), System.Drawing.Image)
        Me.btnFaitPostDch.Location = New System.Drawing.Point(227, 219)
        Me.btnFaitPostDch.Name = "btnFaitPostDch"
        Me.btnFaitPostDch.Size = New System.Drawing.Size(47, 23)
        Me.btnFaitPostDch.TabIndex = 62
        Me.btnFaitPostDch.UseVisualStyleBackColor = False
        '
        'btnFaitPostCh
        '
        Me.btnFaitPostCh.BackColor = System.Drawing.Color.White
        Me.btnFaitPostCh.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFaitPostCh.Image = CType(resources.GetObject("btnFaitPostCh.Image"), System.Drawing.Image)
        Me.btnFaitPostCh.Location = New System.Drawing.Point(227, 196)
        Me.btnFaitPostCh.Name = "btnFaitPostCh"
        Me.btnFaitPostCh.Size = New System.Drawing.Size(47, 23)
        Me.btnFaitPostCh.TabIndex = 61
        Me.btnFaitPostCh.UseVisualStyleBackColor = False
        '
        'lblPostCond
        '
        Me.lblPostCond.BackColor = System.Drawing.Color.White
        Me.lblPostCond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPostCond.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostCond.Location = New System.Drawing.Point(293, 179)
        Me.lblPostCond.Name = "lblPostCond"
        Me.lblPostCond.Size = New System.Drawing.Size(209, 25)
        Me.lblPostCond.TabIndex = 60
        Me.lblPostCond.Text = "Fait de la post-condition"
        '
        'btnAjoutRegle
        '
        Me.btnAjoutRegle.BackColor = System.Drawing.Color.White
        Me.btnAjoutRegle.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjoutRegle.Image = CType(resources.GetObject("btnAjoutRegle.Image"), System.Drawing.Image)
        Me.btnAjoutRegle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjoutRegle.Location = New System.Drawing.Point(190, 293)
        Me.btnAjoutRegle.Name = "btnAjoutRegle"
        Me.btnAjoutRegle.Size = New System.Drawing.Size(156, 30)
        Me.btnAjoutRegle.TabIndex = 59
        Me.btnAjoutRegle.Text = "Ajouter la règle"
        Me.btnAjoutRegle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjoutRegle.UseVisualStyleBackColor = False
        '
        'lblNomRegle
        '
        Me.lblNomRegle.AutoSize = True
        Me.lblNomRegle.BackColor = System.Drawing.Color.White
        Me.lblNomRegle.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomRegle.Location = New System.Drawing.Point(9, 262)
        Me.lblNomRegle.Name = "lblNomRegle"
        Me.lblNomRegle.Size = New System.Drawing.Size(38, 19)
        Me.lblNomRegle.TabIndex = 56
        Me.lblNomRegle.Text = "Nom"
        '
        'txtNomRegle
        '
        Me.txtNomRegle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomRegle.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomRegle.Location = New System.Drawing.Point(71, 258)
        Me.txtNomRegle.Name = "txtNomRegle"
        Me.txtNomRegle.Size = New System.Drawing.Size(431, 26)
        Me.txtNomRegle.TabIndex = 57
        '
        'btnFaitPreDch
        '
        Me.btnFaitPreDch.BackColor = System.Drawing.Color.White
        Me.btnFaitPreDch.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFaitPreDch.Image = CType(resources.GetObject("btnFaitPreDch.Image"), System.Drawing.Image)
        Me.btnFaitPreDch.Location = New System.Drawing.Point(227, 146)
        Me.btnFaitPreDch.Name = "btnFaitPreDch"
        Me.btnFaitPreDch.Size = New System.Drawing.Size(47, 23)
        Me.btnFaitPreDch.TabIndex = 54
        Me.btnFaitPreDch.UseVisualStyleBackColor = False
        '
        'btnFaitPreCh
        '
        Me.btnFaitPreCh.BackColor = System.Drawing.Color.White
        Me.btnFaitPreCh.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFaitPreCh.Image = CType(resources.GetObject("btnFaitPreCh.Image"), System.Drawing.Image)
        Me.btnFaitPreCh.Location = New System.Drawing.Point(227, 93)
        Me.btnFaitPreCh.Name = "btnFaitPreCh"
        Me.btnFaitPreCh.Size = New System.Drawing.Size(47, 23)
        Me.btnFaitPreCh.TabIndex = 49
        Me.btnFaitPreCh.UseVisualStyleBackColor = False
        '
        'lblFaitChoisi
        '
        Me.lblFaitChoisi.BackColor = System.Drawing.Color.White
        Me.lblFaitChoisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFaitChoisi.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaitChoisi.Location = New System.Drawing.Point(294, 39)
        Me.lblFaitChoisi.Name = "lblFaitChoisi"
        Me.lblFaitChoisi.Size = New System.Drawing.Size(208, 47)
        Me.lblFaitChoisi.TabIndex = 53
        Me.lblFaitChoisi.Text = "Liste des faits choisis pour la pré-condition"
        '
        'lblFaitDis
        '
        Me.lblFaitDis.AutoSize = True
        Me.lblFaitDis.BackColor = System.Drawing.Color.White
        Me.lblFaitDis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFaitDis.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaitDis.Location = New System.Drawing.Point(9, 39)
        Me.lblFaitDis.Name = "lblFaitDis"
        Me.lblFaitDis.Size = New System.Drawing.Size(180, 21)
        Me.lblFaitDis.TabIndex = 52
        Me.lblFaitDis.Text = "Liste des faits disponibles"
        '
        'lstFaitChoisiPre
        '
        Me.lstFaitChoisiPre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstFaitChoisiPre.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFaitChoisiPre.FormattingEnabled = True
        Me.lstFaitChoisiPre.ItemHeight = 19
        Me.lstFaitChoisiPre.Location = New System.Drawing.Point(293, 89)
        Me.lstFaitChoisiPre.Name = "lstFaitChoisiPre"
        Me.lstFaitChoisiPre.Size = New System.Drawing.Size(209, 78)
        Me.lstFaitChoisiPre.TabIndex = 51
        '
        'lstFaitDis
        '
        Me.lstFaitDis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstFaitDis.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFaitDis.FormattingEnabled = True
        Me.lstFaitDis.ItemHeight = 19
        Me.lstFaitDis.Location = New System.Drawing.Point(12, 93)
        Me.lstFaitDis.Name = "lstFaitDis"
        Me.lstFaitDis.Size = New System.Drawing.Size(190, 154)
        Me.lstFaitDis.TabIndex = 50
        '
        'lblAjoutRegle
        '
        Me.lblAjoutRegle.BackColor = System.Drawing.Color.White
        Me.lblAjoutRegle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAjoutRegle.Font = New System.Drawing.Font("Rockwell Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAjoutRegle.Location = New System.Drawing.Point(3, 11)
        Me.lblAjoutRegle.Name = "lblAjoutRegle"
        Me.lblAjoutRegle.Size = New System.Drawing.Size(499, 22)
        Me.lblAjoutRegle.TabIndex = 48
        Me.lblAjoutRegle.Text = "Ajout d'une règle"
        Me.lblAjoutRegle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chkNegatif
        '
        Me.chkNegatif.AutoSize = True
        Me.chkNegatif.BackColor = System.Drawing.Color.White
        Me.chkNegatif.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.chkNegatif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkNegatif.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNegatif.Location = New System.Drawing.Point(212, 119)
        Me.chkNegatif.Name = "chkNegatif"
        Me.chkNegatif.Size = New System.Drawing.Size(72, 23)
        Me.chkNegatif.TabIndex = 1
        Me.chkNegatif.Text = "Négatif"
        Me.chkNegatif.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "*.conan"
        Me.OpenFileDialog1.Filter = "Base de connaissance|*.conan|Tous|*.*"
        Me.OpenFileDialog1.Title = "Ouverture d'une base de connaissances"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(539, 592)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Éditeur de base de connaissances Conan the republican"
        Me.pnlTerme.ResumeLayout(False)
        Me.pnlTerme.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.pnlFait.ResumeLayout(False)
        Me.pnlFait.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.pnlRegle.ResumeLayout(False)
        Me.pnlRegle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lstTerme As System.Windows.Forms.ListBox
    Friend WithEvents lblTerme As System.Windows.Forms.Label
    Friend WithEvents btnPlusTerme As System.Windows.Forms.Button
    Friend WithEvents btnMoinsTerme As System.Windows.Forms.Button
    Friend WithEvents lblAjoutTerme As System.Windows.Forms.Label
    Friend WithEvents lblValeurTerme As System.Windows.Forms.Label
    Friend WithEvents txtValeurTerme As System.Windows.Forms.TextBox
    Friend WithEvents btnAjouterTerme As System.Windows.Forms.Button
    Friend WithEvents pnlTerme As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblFait As System.Windows.Forms.Label
    Friend WithEvents btnMoinsFait As System.Windows.Forms.Button
    Friend WithEvents btnPlusFait As System.Windows.Forms.Button
    Friend WithEvents lstFait As System.Windows.Forms.ListBox
    Friend WithEvents pnlFait As System.Windows.Forms.Panel
    Friend WithEvents btnAjoutFait As System.Windows.Forms.Button
    Friend WithEvents lblCommFait As System.Windows.Forms.Label
    Friend WithEvents lblNomFait As System.Windows.Forms.Label
    Friend WithEvents txtCommFait As System.Windows.Forms.TextBox
    Friend WithEvents txtNomFait As System.Windows.Forms.TextBox
    Friend WithEvents btnTermeDch As System.Windows.Forms.Button
    Friend WithEvents btnTermeCh As System.Windows.Forms.Button
    Friend WithEvents lblTermeChoisi As System.Windows.Forms.Label
    Friend WithEvents lblTermeDis As System.Windows.Forms.Label
    Friend WithEvents lstTermeChoisi As System.Windows.Forms.ListBox
    Friend WithEvents lstTermeDis As System.Windows.Forms.ListBox
    Friend WithEvents lblAjoutFait As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnMoinsRegle As System.Windows.Forms.Button
    Friend WithEvents btnPlusRegle As System.Windows.Forms.Button
    Friend WithEvents lblRegle As System.Windows.Forms.Label
    Friend WithEvents lstRegle As System.Windows.Forms.ListBox
    Friend WithEvents pnlRegle As System.Windows.Forms.Panel
    Friend WithEvents lstFaitChoisiPost As System.Windows.Forms.ListBox
    Friend WithEvents btnFaitPostDch As System.Windows.Forms.Button
    Friend WithEvents btnFaitPostCh As System.Windows.Forms.Button
    Friend WithEvents lblPostCond As System.Windows.Forms.Label
    Friend WithEvents btnAjoutRegle As System.Windows.Forms.Button
    Friend WithEvents lblNomRegle As System.Windows.Forms.Label
    Friend WithEvents txtNomRegle As System.Windows.Forms.TextBox
    Friend WithEvents btnFaitPreDch As System.Windows.Forms.Button
    Friend WithEvents btnFaitPreCh As System.Windows.Forms.Button
    Friend WithEvents lblFaitChoisi As System.Windows.Forms.Label
    Friend WithEvents lblFaitDis As System.Windows.Forms.Label
    Friend WithEvents lstFaitChoisiPre As System.Windows.Forms.ListBox
    Friend WithEvents lstFaitDis As System.Windows.Forms.ListBox
    Friend WithEvents lblAjoutRegle As System.Windows.Forms.Label
    Friend WithEvents chkNegatif As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblAuteur As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblSujet As System.Windows.Forms.Label
    Friend WithEvents btnSauvegarde As System.Windows.Forms.Button
    Friend WithEvents lstRegleDom As System.Windows.Forms.ListBox
    Friend WithEvents lblRegleDom As System.Windows.Forms.Label
    Friend WithEvents txtNomFichier As System.Windows.Forms.TextBox
    Friend WithEvents lblNomFichier As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDomaine As System.Windows.Forms.Label
    Friend WithEvents txtAuteurs As System.Windows.Forms.TextBox
    Friend WithEvents txtSujet As System.Windows.Forms.TextBox
    Friend WithEvents lblQuestionFait As System.Windows.Forms.Label
    Friend WithEvents txtQuestionFait As System.Windows.Forms.TextBox
    Friend WithEvents btnChargement As System.Windows.Forms.Button
End Class
