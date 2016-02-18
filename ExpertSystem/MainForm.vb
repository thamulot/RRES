
Public Class MainForm

    Private Function LoadDomain() As Reagan.Data.Domain
        Dim domaine As Reagan.Data.Domain = Nothing

        If (Me.OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.Cancel) Then
            domaine = Reagan.Data.BinaryManager.ReadFile(Me.OpenFileDialog1.FileName)

            Dim message As String = "Est-ce bien """ + domaine.Subject + """ par " + domaine.Authors + " ?"
            'couenne.Talk(message)
            Dim value As DialogResult = MessageBox.Show(message, "- Question -", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If (value = Windows.Forms.DialogResult.No) Then
                domaine = LoadDomain()
            ElseIf (value = Windows.Forms.DialogResult.Cancel) Then
                domaine = Nothing
            End If

        End If

        Return domaine
    End Function

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim splash As SplashScreen = New SplashScreen
        splash.Show()

        'couenne.Talk("Bonjour, je m'appelle Calculon.")
        'couenne.Talk("Bienvenue dans le système expert Ronald \Map=""Rigueune""=""Reagan""\ !")
        'couenne.Talk("Veuillez choisir une base de connaissance :")

        Dim domaine As Reagan.Data.Domain = LoadDomain()
        If (Not (domaine Is Nothing)) Then
            'couenne.Animate("Read")
            'couenne.Animate("ReadContinued")
            'couenne.Animate("ReadReturn")

            ' Chargement du moteur d'inférence
            Dim successeur As Reagan.Engine.Successeurs = New Reagan.Engine.Successeurs(domaine.Facts, domaine.Rules)
            Do
                ' Demande du problème
                Dim probleme As Probleme = New Probleme()
                Dim seulprobleme As Reagan.Data.Fact = probleme.ChargerListe(domaine.getEachPostConditions())

                If (seulprobleme Is Nothing) Then
                    'couenne.Talk("À propos de quoi désirez-vous m'intérroger ?")
                    probleme.ShowDialog()
                    seulprobleme = probleme.getProbleme
                End If

                Dim faitInitial As Reagan.Data.Fact = New Reagan.Data.Fact()
                faitInitial.Name = seulprobleme.Name
                Dim termeInitial As Reagan.Data.Term = New Reagan.Data.Term()
                termeInitial.Value = "?X"
                termeInitial.TermType = "Variable"
                faitInitial.Comments = seulprobleme.Comments
                faitInitial.Term = termeInitial

                Dim noeudInitial As Reagan.Engine.Noeud = New Reagan.Engine.Noeud(Nothing, faitInitial, False, "Racine")
                Dim resultat As Boolean = Reagan.Engine.AEtoile.rechercheDansGraphe(noeudInitial, Nothing, successeur)

                Dim reponse As String = "Pas de réponse."
                Dim gosh2 As Reagan.Data.Fact = CType(noeudInitial.data, Reagan.Data.Fact)

                If resultat Then
                    reponse = gosh2.Term.Value + " : " + successeur.getCommentaireUnification()
                End If

                successeur.afficherResultat(reponse)

                If resultat Then
                    '                    couenne.Animate("Congratulate")

                    'couenne.Talk(reponse)
                Else
                    'couenne.Animate("Sad")
                    'couenne.Talk("Je n'ai pas trouvé de réponse à votre problème...")
                End If

            Loop Until (MessageBox.Show("Désirez-vous poser une autre question au système ?", "- Question -", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No)

            ' En cas de question
            'couenne.Animate("Announce")
            'couenne.Animate("Confused")
            'couenne.Animate("GetAttention")
            'couenne.Animate("StartListening")

            ''Après saisie de question
            'couenne.Animate("Write")

            '' En cas de question pas bonne
            'couenne.Animate("DontRecognize")

            '' En cas de succès
            'couenne.Animate("Pleased")
            'couenne.Animate("Congratulate")

            '' En cas de NON succès
            'couenne.Animate("Decline")
            'couenne.Animate("Sad")
            'couenne.Animate("Uncertain")
        End If

        Application.Exit()
    End Sub
End Class
