using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        int correctQuestion;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);

            totalQuestions = 6;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObjesct = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObjesct.Tag);

            if(buttonTag==correctQuestion)
            {
                score++;
            }
            if(questionNumber==totalQuestions)
            {
                percentage=(int)Math.Round((double)(score*100)/totalQuestions);
                MessageBox.Show(
                    "Testul a luat sfarsit!" + Environment.NewLine +
                    "Ai raspuns la " + score + " intrebari corecte." + Environment.NewLine +
                    "Procentajul total este de " + percentage + "%" + Environment.NewLine +
                    "Apasa ok pentru a relua testul"
                    );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);



        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.man_with_question_01;

                    lblQuestion.Text = "Care este capitala Romaniei?";

                    button1.Text = "Cluj";
                    button2.Text = "Bucuresti";
                    button3.Text = "Londra";
                    button4.Text = "Chisinau";

                    correctQuestion = 2;


                    break;


                case 2:
                    pictureBox1.Image = Properties.Resources.piramide;

                    lblQuestion.Text = "In ce tara se regaseste peisajul din imagine?";

                    button1.Text = "Egipt";
                    button2.Text = "SUA";
                    button3.Text = "Italia";
                    button4.Text = "China";

                    correctQuestion = 1;


                    break;




                case 3:
                    pictureBox1.Image = Properties.Resources.man_with_question_01;

                    lblQuestion.Text = "La ce mare are iesire Romania?";

                    button1.Text = "Marea Alba";
                    button2.Text = "Marea Rosie";
                    button3.Text = "Marea Neagra";
                    button4.Text = "Marea Aral";

                    correctQuestion = 3;


                    break;



                case 4:
                    pictureBox1.Image = Properties.Resources.castel;

                    lblQuestion.Text = "Ce castel se afla in imagine?";

                    button1.Text = "Castelul Bran";
                    button2.Text = "Castelul Peles";
                    button3.Text = "Castelul Sturdza";
                    button4.Text = "Castelul Corvinilor";

                    correctQuestion = 4;


                    break;


                case 5:
                    pictureBox1.Image = Properties.Resources.man_with_question_01;

                    lblQuestion.Text = "In ce tara se afla orasul MANCHESTER? ";

                    button1.Text = "Anglia";
                    button2.Text = "Rusia";
                    button3.Text = "Cehia";
                    button4.Text = "Ucraina";

                    correctQuestion = 1;


                    break;




                case 6:
                    pictureBox1.Image = Properties.Resources.tesla;

                    lblQuestion.Text = "Ce masina se afla in imagine? ";

                    button1.Text = "BMW";
                    button2.Text = "Tesla";
                    button3.Text = "Audi";
                    button4.Text = "FIAT";

                    correctQuestion = 2;


                    break;
            }



        }
    }
}
