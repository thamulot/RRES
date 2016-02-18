
Imports Reagan

Public Class MainForm
    Public domaine As Reagan.Data.Domain
    Public termeModif As Reagan.Data.Term
    Public faitModif As Reagan.Data.Fact
    Public regleModif As Reagan.Data.Rule

    Public blnTermeModif As Boolean
    Public blnFaitModif As Boolean
    Public blnRegleModif As Boolean

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.domaine = New Reagan.Data.Domain()

        termeModif = New Reagan.Data.Term()
        faitModif = New Reagan.Data.Fact()
        regleModif = New Reagan.Data.Rule()

        blnFaitModif = False
        blnRegleModif = False
        blnTermeModif = False

        pnlTerme.Visible = False
        pnlFait.Visible = False
        pnlRegle.Visible = False
    End Sub

    Private Sub enleverListe(ByRef liste As ListBox, ByRef liste2 As ListBox, ByVal genre As String)
        Dim i As Integer

        liste2.Items.Remove(liste.SelectedItem)

        For i = liste.SelectedIndices.Count - 1 To 0 Step -1
            liste.Items.RemoveAt(liste.SelectedIndices(i))
        Next

    End Sub

    Private Sub remplirListeDis(ByVal listeRemp As ListBox, ByRef listeARemplir As ListBox)
        Dim i As Integer

        For i = 0 To listeRemp.Items.Count - 1
            listeARemplir.Items.Add(listeRemp.Items.Item(i))
        Next
    End Sub

    Private Sub btnMoinsTerme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoinsTerme.Click
        enleverListe(lstTerme, lstTermeDis, "Terme")
    End Sub

    Private Sub btnMoinsFait_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoinsFait.Click
        enleverListe(lstFait, lstFaitDis, "Fait")
    End Sub

    Private Sub btnMoinsRegle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoinsRegle.Click
        enleverListe(lstRegle, lstRegleDom, "Regle")
    End Sub


    Private Sub btnPlusTerme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlusTerme.Click
        blnTermeModif = False
        pnlTerme.Visible = True
        lblAjoutTerme.Text = "Ajout d'un terme"
        btnAjouterTerme.Text = "Ajouter le terme"
        txtValeurTerme.Text = ""
        txtValeurTerme.Focus()
    End Sub


    Private Sub btnPlusFait_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlusFait.Click
        pnlFait.Visible = True

        blnFaitModif = False
        lblAjoutFait.Text = "Ajout d'un fait"
        btnAjoutFait.Text = "Ajouter le fait"

        txtNomFait.Text = ""
        txtCommFait.Text = ""
        txtQuestionFait.Text = ""
        lstTermeDis.Items.Clear()
        lstTermeChoisi.Items.Clear()
        remplirListeDis(lstTerme, lstTermeDis)
    End Sub

    Private Sub btnPlusRegle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlusRegle.Click
        pnlRegle.Visible = True

        blnRegleModif = False
        lblAjoutRegle.Text = "Ajout d'une règle"
        btnAjoutRegle.Text = "Ajouter la règle"

        lstFaitDis.Items.Clear()
        lstFaitChoisiPre.Items.Clear()
        lstFaitChoisiPost.Items.Clear()
        txtNomRegle.Text = ""
        remplirListeDis(lstFait, lstFaitDis)
    End Sub

    Private Sub btnAjouterTerme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouterTerme.Click
        If txtValeurTerme.Text.Length < 1 Then
            'uenne.Talk("Vous devez saisir une valeur pour le terme.")
            Return
        End If


        Dim i As Integer

        If blnTermeModif Then
            'Modification d'un terme
            termeModif.Value = txtValeurTerme.Text

            'Rafraichir les listes pc vb est trop cave avec sa propre méthode...
            For i = 0 To lstTerme.Items.Count - 1
                lstTerme.Items.Item(i) = lstTerme.Items.Item(i)
            Next

            For i = 0 To lstTermeDis.Items.Count - 1
                lstTermeDis.Items.Item(i) = lstTermeDis.Items.Item(i)
            Next

            For i = 0 To lstTermeChoisi.Items.Count - 1
                lstTermeChoisi.Items.Item(i) = lstTermeChoisi.Items.Item(i)
            Next

        Else
            'Ajouter le terme
            Dim terme As Reagan.Data.Term = New Reagan.Data.Term

            terme.Value = txtValeurTerme.Text
            terme.TermType = "constante"

            lstTerme.Items.Add(terme)
            lstTermeDis.Items.Add(terme)
        End If

        pnlTerme.Visible = False
    End Sub

    Private Sub btnAjoutFait_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjoutFait.Click
        Dim i As Integer

        If lstTermeChoisi.Items.Count = 0 Then

            '            couenne.Talk("Vous devez choisir un terme pour que votre fait soit valide.")
        ElseIf txtNomFait.Text.Length < 1 Then
            '            couenne.Talk("Vous devez saisir un nom pour le fait.")
        ElseIf txtCommFait.Text.Length < 1 Then
            '            couenne.Talk("Vous devez saisir un commentaire pour le fait.")
        ElseIf txtQuestionFait.Text.Length < 1 Then
            '            couenne.Talk("Vous devez saisir une question pour le fait.")
        ElseIf blnFaitModif Then
            'Modification du fait

            faitModif.Name = txtNomFait.Text
            faitModif.Question = txtQuestionFait.Text
            faitModif.Comments = txtCommFait.Text
            faitModif.Term = lstTermeChoisi.Items.Item(0)

            'Rafraichir les listes pc vb est trop cave avec sa propre méthode...
            For i = 0 To lstFait.Items.Count - 1
                lstFait.Items.Item(i) = lstFait.Items.Item(i)
            Next

            For i = 0 To lstFaitDis.Items.Count - 1
                lstFaitDis.Items.Item(i) = lstFaitDis.Items.Item(i)
            Next

            For i = 0 To lstFaitChoisiPre.Items.Count - 1
                lstFaitChoisiPre.Items.Item(i) = lstFaitChoisiPre.Items.Item(i)
            Next

            For i = 0 To lstFaitChoisiPost.Items.Count - 1
                lstFaitChoisiPost.Items.Item(i) = lstFaitChoisiPost.Items.Item(i)
            Next

            pnlFait.Visible = False
        Else

            'Ajouter le fait
            Dim fait As Reagan.Data.Fact = New Reagan.Data.Fact

            fait.Comments = txtCommFait.Text
            fait.Question = txtQuestionFait.Text
            fait.Name = txtNomFait.Text
            fait.Term = lstTermeChoisi.Items.Item(0)

            lstFait.Items.Add(fait)
            lstFaitDis.Items.Add(fait)
            pnlFait.Visible = False
        End If

    End Sub

    Private Sub btnAjoutRegle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjoutRegle.Click
        Dim i As Integer

        If lstFaitChoisiPre.Items.Count = 0 Then
            '            couenne.Talk("Vous devez choisir au moins un fait en pré-condition pour que votre règle soit valide.")

        ElseIf lstFaitChoisiPost.Items.Count = 0 Then

            '           couenne.Talk("Vous devez choisir un fait en post-condition pour que votre règle soit valide.")
        ElseIf txtNomRegle.Text.Length < 1 Then
            '            couenne.Talk("Vous devez spécifier le nom de la règle.")
        ElseIf blnRegleModif Then
            Dim faitWrap As Reagan.Data.FactWrapper

            'Modification d'une règle
            regleModif.Name = txtNomRegle.Text
            regleModif.PostCondition = lstFaitChoisiPost.Items.Item(0)

            regleModif.PreConditions.Clear()
            For Each faitWrap In lstFaitChoisiPre.Items
                regleModif.PreConditions.Add(faitWrap)
            Next

            'Rafraichir les listes pc vb est trop cave avec sa propre méthode (bug de micormou)...
            For i = 0 To lstRegle.Items.Count - 1
                lstRegle.Items.Item(i) = lstRegle.Items.Item(i)
            Next

            For i = 0 To lstRegleDom.Items.Count - 1
                lstRegleDom.Items.Item(i) = lstRegleDom.Items.Item(i)
            Next

            pnlRegle.Visible = False
        Else

            'Ajouter la règle
            Dim regle As Reagan.Data.Rule = New Reagan.Data.Rule
            Dim fait As Reagan.Data.Fact = New Reagan.Data.Fact

            regle.PostCondition = lstFaitChoisiPost.Items.Item(0)

            'Ajouter les préconditions

            For i = 0 To lstFaitChoisiPre.Items.Count - 1
                regle.PreConditions.Add(lstFaitChoisiPre.Items(i))
            Next

            regle.Name = txtNomRegle.Text
            lstRegle.Items.Add(regle)
            lstRegleDom.Items.Add(regle)

            pnlRegle.Visible = False
        End If
    End Sub

    Private Sub btnTermeCh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTermeCh.Click
        Dim i As Integer

        If lstTermeDis.SelectedItems.Count > 0 Then

            If lstTermeChoisi.Items.Count > 0 Then
                'On remet dans les termes le terme qui etait dans la liste choisi
                lstTermeDis.Items.Add(lstTermeChoisi.Items.Item(0))
                lstTermeChoisi.Items.Clear()
            End If

            lstTermeChoisi.Items.Add(lstTermeDis.SelectedItem)

            For i = lstTermeDis.SelectedIndices.Count - 1 To 0 Step -1
                lstTermeDis.Items.RemoveAt(lstTermeDis.SelectedIndices(i))
            Next
        End If

    End Sub

    Private Sub btnTermeDch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTermeDch.Click

        If lstTermeChoisi.SelectedItems.Count > 0 Then
            lstTermeDis.Items.Add(lstTermeChoisi.Items.Item(0))
            lstTermeChoisi.Items.Clear()
        End If

    End Sub



    Private Sub btnFaitPreCh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFaitPreCh.Click
        'Plus touchy, y faut transformer le fait en faitwrapper!

        Dim i As Integer
        Dim fait As Reagan.Data.Fact
        Dim faitWrap As Reagan.Data.FactWrapper = New Reagan.Data.FactWrapper

        For Each fait In lstFaitDis.SelectedItems
            faitWrap.Fact = fait

            If chkNegatif.Checked Then
                faitWrap.Negation = True
            Else
                faitWrap.Negation = False
            End If

            lstFaitChoisiPre.Items.Add(faitWrap)
        Next

        For i = lstFaitDis.SelectedIndices.Count - 1 To 0 Step -1
            lstFaitDis.Items.RemoveAt(lstFaitDis.SelectedIndices(i))
        Next

    End Sub

    Private Sub btnFaitPreDch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFaitPreDch.Click

        'Défaire le faitWrapper
        Dim i As Integer
        Dim fait As Reagan.Data.Fact = New Reagan.Data.Fact
        Dim faitWrap As Reagan.Data.FactWrapper

        For Each faitWrap In lstFaitChoisiPre.SelectedItems
            fait = faitWrap.Fact
            lstFaitDis.Items.Add(fait)
        Next

        For i = lstFaitChoisiPre.SelectedIndices.Count - 1 To 0 Step -1
            lstFaitChoisiPre.Items.RemoveAt(lstFaitChoisiPre.SelectedIndices(i))
        Next

    End Sub

    Private Sub btnFaitPostCh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFaitPostCh.Click

        Dim fait As Reagan.Data.Fact
        Dim i As Integer

        If lstFaitDis.SelectedItems.Count > 1 Then
            'IL FAUT EN CHOISIR UN SEUL
        Else
            For Each fait In lstFaitDis.SelectedItems
                lstFaitChoisiPost.Items.Add(fait)
            Next

            For i = lstFaitDis.SelectedIndices.Count - 1 To 0 Step -1
                lstFaitDis.Items.RemoveAt(lstFaitDis.SelectedIndices(i))
            Next

        End If

    End Sub

    Private Sub btnFaitPostDch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFaitPostDch.Click

        Dim i As Integer
        Dim fait As Reagan.Data.Fact

        For Each fait In lstFaitChoisiPost.SelectedItems
            lstFaitDis.Items.Add(fait)
        Next

        For i = lstFaitChoisiPost.SelectedIndices.Count - 1 To 0 Step -1
            lstFaitChoisiPost.Items.RemoveAt(lstFaitChoisiPost.SelectedIndices(i))
        Next
    End Sub

    Private Sub btnSauvegarde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSauvegarde.Click

        If (txtNomFichier.Text.Length < 1) Then
            '            couenne.Talk("Vous devez spécifier le nom du fichier !")

        ElseIf (txtSujet.Text.Length < 1) Then

            '           couenne.Talk("Vous devez spécifier le sujet du domaine.")

        ElseIf (txtDescription.Text.Length < 1) Then
            '            couenne.Talk("Vous devez spécifier une desription sommaire du domaine.")
        ElseIf (txtAuteurs.Text.Length < 1) Then
            '            couenne.Talk("Vous devez spécifier le ou les auteurs du domaine.")
        Else
            With Me.domaine

                Dim terme As Reagan.Data.Term
                Dim fait As Reagan.Data.Fact
                Dim regle As Reagan.Data.Rule

                .Authors = txtAuteurs.Text
                .Description = txtDescription.Text
                .Subject = txtSujet.Text

                .Rules.Clear()
                For Each regle In lstRegle.Items
                    .Rules.Add(regle)
                Next

                .Facts.Clear()
                For Each fait In lstFait.Items
                    .Facts.Add(fait)
                Next

                .Terms.Clear()
                For Each terme In lstTerme.Items
                    .Terms.Add(terme)
                Next
            End With


            Reagan.Data.BinaryManager.WriteFile(txtNomFichier.Text + ".conan", Me.domaine)
            'couenne.Talk("La sauvegarde s'est effectuée avec succès !")
        End If
    End Sub

    Private Sub btnChargement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChargement.Click

        If (Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            'Vidage des controles en cours
            lstFait.Items.Clear()
            lstFaitChoisiPost.Items.Clear()
            lstFaitChoisiPre.Items.Clear()
            lstFaitDis.Items.Clear()
            lstRegle.Items.Clear()
            lstRegleDom.Items.Clear()
            lstTerme.Items.Clear()
            lstTermeChoisi.Items.Clear()
            lstTermeDis.Items.Clear()

            txtCommFait.Text = ""
            txtNomFait.Text = ""
            txtNomRegle.Text = ""
            txtQuestionFait.Text = ""
            txtValeurTerme.Text = ""

            pnlFait.Visible = False
            pnlRegle.Visible = False
            pnlTerme.Visible = False

            Me.domaine = Reagan.Data.BinaryManager.ReadFile(Me.OpenFileDialog1.FileName)

            ' Charge les termes
            Dim terme As Reagan.Data.Term
            For Each terme In Me.domaine.Terms
                Me.lstTerme.Items.Add(terme)
                Me.lstTermeDis.Items.Add(terme)
            Next

            ' Charge les faits
            Dim fait As Reagan.Data.Fact
            For Each fait In Me.domaine.Facts
                Me.lstFait.Items.Add(fait)
                Me.lstFaitDis.Items.Add(fait)
            Next

            ' Charge les règles
            Dim regle As Reagan.Data.Rule
            For Each regle In Me.domaine.Rules
                Me.lstRegle.Items.Add(regle)
                Me.lstRegleDom.Items.Add(regle)
            Next

            ' Charge les infos du domaine
            Me.txtNomFichier.Text = Me.OpenFileDialog1.FileName.Substring(
                Me.OpenFileDialog1.FileName.LastIndexOf("\") + 1,
                Me.OpenFileDialog1.FileName.Length - (Me.OpenFileDialog1.FileName.LastIndexOf("\") + 7))
            Me.txtAuteurs.Text = Me.domaine.Authors
            Me.txtSujet.Text = Me.domaine.Subject
            Me.txtDescription.Text = Me.domaine.Description

            'couenne.Talk("Chargement du domaine terminé.")
        End If
    End Sub

    Private Sub lstTerme_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTerme.DoubleClick
        If (lstTerme.SelectedItem Is Nothing) Then
            Return
        End If

        termeModif = lstTerme.SelectedItem

        blnTermeModif = True
        pnlTerme.Visible = True
        lblAjoutTerme.Text = "Modification d'un terme"
        btnAjouterTerme.Text = "Modifier le terme"
        txtValeurTerme.Text = termeModif.Value

        txtValeurTerme.Focus()

    End Sub

    Private Sub lstFait_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFait.DoubleClick
        If (lstFait.SelectedItem Is Nothing) Then
            Return
        End If

        faitModif = lstFait.SelectedItem

        blnFaitModif = True
        pnlFait.Visible = True
        lblAjoutFait.Text = "Modification d'un fait"
        btnAjoutFait.Text = "Modifier le fait"
        lstTermeChoisi.Items.Clear()
        lstTermeChoisi.Items.Add(faitModif.Term)
        lstTermeDis.Items.Clear()
        remplirListeDis(lstTerme, lstTermeDis)
        lstTermeDis.Items.Remove(faitModif.Term)
        txtCommFait.Text = faitModif.Comments
        txtQuestionFait.Text = faitModif.Question
        txtNomFait.Text = faitModif.Name

    End Sub

    Private Sub lstRegle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstRegle.DoubleClick
        If (lstRegle.SelectedItem Is Nothing) Then
            Return
        End If

        Dim i As Integer

        regleModif = lstRegle.SelectedItem

        blnRegleModif = True
        pnlRegle.Visible = True
        lblAjoutRegle.Text = "Modification d'une règle"
        btnAjoutRegle.Text = "Modifier la règle"
        lstFaitChoisiPost.Items.Clear()
        lstFaitChoisiPost.Items.Add(regleModif.PostCondition)
        lstFaitChoisiPre.Items.Clear()
        lstFaitDis.Items.Clear()
        remplirListeDis(lstFait, lstFaitDis)
        lstFaitDis.Items.Remove(regleModif.PostCondition)

        'Mettre les faitsWrappers dans la liste des fait préconditions
        For i = 0 To regleModif.PreConditions.Count - 1
            lstFaitChoisiPre.Items.Add(regleModif.PreConditions(i))
            lstFaitDis.Items.Remove(regleModif.PreConditions(i).Fact)
        Next

        txtNomRegle.Text = regleModif.Name

    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
    End Sub
End Class