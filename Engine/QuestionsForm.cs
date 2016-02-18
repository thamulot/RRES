using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reagan.Engine
{
    public partial class QuestionsForm : Form
    {
        public static Reagan.Agent.MSAgent couenne;

        String choix;

        public QuestionsForm()
        {
            InitializeComponent();
        }

        public String getChoix(){return choix;}

        public void setQuestion(string q, bool isQuestion, bool talk) 
        {
            btn_close.Visible = false;
            couenne.StopIt();

            if (!isQuestion)
            {
                btn_how.Visible = false;
                btn_why.Visible = false;
                btn_yes.Visible = false;
                btn_no.Visible = false;
                btn_ok.Visible = true;
            }
            else
            {
                btn_how.Visible = true;
                btn_why.Visible = true;
                btn_yes.Visible = true;
                btn_no.Visible = true;
                btn_ok.Visible = false;
            }

            zone_question.Text = q;

            if(talk)
                couenne.Talk(q);
        }

        public void setTraceResulat(string q)
        {
            couenne.StopIt();

            btn_how.Visible = true;
            btn_why.Visible = true;
            btn_yes.Visible = false;
            btn_no.Visible = false;
            btn_ok.Visible = false;
            btn_close.Visible = true;

            zone_question.Text = q;
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            choix= "yes";
            Close();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            choix = "no";
            Close();
        }

        private void btn_why_Click(object sender, EventArgs e)
        {
            choix = "why";
            Close();
        }

        private void btn_how_Click(object sender, EventArgs e)
        {
            choix = "how";
            Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            choix = "close";
            couenne.StopIt();
            Close();
        }
    }
}