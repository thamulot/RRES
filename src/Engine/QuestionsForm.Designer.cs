namespace Reagan.Engine
{
    partial class QuestionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            this.btn_why = new System.Windows.Forms.Button();
            this.btn_how = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_ok = new System.Windows.Forms.Button();
            this.zone_question = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_yes
            // 
            this.btn_yes.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yes.Location = new System.Drawing.Point(63, 194);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(81, 40);
            this.btn_yes.TabIndex = 0;
            this.btn_yes.Text = "Oui";
            this.toolTip1.SetToolTip(this.btn_yes, "Cliquer ici si la reponse est oui a la question.");
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // btn_no
            // 
            this.btn_no.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_no.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.Location = new System.Drawing.Point(179, 194);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(81, 40);
            this.btn_no.TabIndex = 1;
            this.btn_no.Text = "Non";
            this.toolTip1.SetToolTip(this.btn_no, "Cliquer ici si la reponse est non a la question.");
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // btn_why
            // 
            this.btn_why.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_why.Location = new System.Drawing.Point(285, 194);
            this.btn_why.Name = "btn_why";
            this.btn_why.Size = new System.Drawing.Size(81, 40);
            this.btn_why.TabIndex = 2;
            this.btn_why.Text = "Pourquoi";
            this.btn_why.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btn_why, "Pour savoir pourquoi le SE pose cette question.");
            this.btn_why.UseVisualStyleBackColor = true;
            this.btn_why.Click += new System.EventHandler(this.btn_why_Click);
            // 
            // btn_how
            // 
            this.btn_how.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_how.Location = new System.Drawing.Point(384, 194);
            this.btn_how.Name = "btn_how";
            this.btn_how.Size = new System.Drawing.Size(81, 40);
            this.btn_how.TabIndex = 3;
            this.btn_how.Text = "Comment";
            this.toolTip1.SetToolTip(this.btn_how, "Pour savoir comment le SE s\'est rendu a cette enonce.");
            this.btn_how.UseVisualStyleBackColor = true;
            this.btn_how.Click += new System.EventHandler(this.btn_how_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(216, 194);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(81, 40);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // zone_question
            // 
            this.zone_question.AutoSize = true;
            this.zone_question.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone_question.Location = new System.Drawing.Point(3, 6);
            this.zone_question.Name = "zone_question";
            this.zone_question.Size = new System.Drawing.Size(47, 19);
            this.zone_question.TabIndex = 6;
            this.zone_question.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.zone_question);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 166);
            this.panel1.TabIndex = 8;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(100, 194);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 40);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "OK";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // QuestionsForm
            // 
            this.AcceptButton = this.btn_close;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 246);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_how);
            this.Controls.Add(this.btn_why);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_yes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuestionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Button btn_why;
        private System.Windows.Forms.Button btn_how;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label zone_question;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
    }
}