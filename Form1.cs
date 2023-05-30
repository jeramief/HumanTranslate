using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanTranslate
{

    public partial class Form1 : Form
    {

        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {

            InitializeComponent();

            AskQuestion(questionNumber);

            totalQuestions = 8;
        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {

                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


                MessageBox.Show("Quiz Ended" + Environment.NewLine +
                                "You have answered " + score + " questions correcly" + Environment.NewLine +
                                "Your total percentage is " + percentage + " %" + Environment.NewLine +
                                "Click Ok to play again"

                    );

                score = 0;
                questionNumber = 0;

                AskQuestion(questionNumber);
            }

            questionNumber++;

            AskQuestion(questionNumber);
        }


        private void AskQuestion(int qnum)
        {

            switch (qnum)
            {

                case 1:

                    lblQuestion.Text = "In English, what does " + "月曜日" + " mean?";

                    button1.Text = "today";
                    button2.Text = "Sunday";
                    button3.Text = "purple";
                    button4.Text = "Monday";

                    correctAnswer = 4;

                    break;
                case 2:

                    lblQuestion.Text = "In English, what does " + "高い" + " mean?";

                    button1.Text = "like";
                    button2.Text = "expensive";
                    button3.Text = "brother";
                    button4.Text = "cheap";

                    correctAnswer = 2;

                    break;

                case 3:

                    lblQuestion.Text = "In Japanese, how do you say " + "friend" + "?";

                    button1.Text = "友達";
                    button2.Text = "野菜";
                    button3.Text = "彼女";
                    button4.Text = "話せ";

                    correctAnswer = 1;

                    break;

                case 4:

                    lblQuestion.Text = "In English, how do you say " + "京都" + "?";

                    button1.Text = "Tokyo";
                    button2.Text = "Kyoto";
                    button3.Text = "Oosaka";
                    button4.Text = "Naomi";

                    correctAnswer = 2;

                    break;

                case 5:

                    lblQuestion.Text = "In Japanese, what is " + "毎朝" + "?";

                    button1.Text = "まいあさ";
                    button2.Text = "おちゃ";
                    button3.Text = "ごはん";
                    button4.Text = "おくさん";

                    correctAnswer = 1;

                    break;

                case 6:

                    lblQuestion.Text = "In Japanese, how do you say " + "grandchild" + "?";

                    button1.Text = "窓";
                    button2.Text = "買い";
                    button3.Text = "孫";
                    button4.Text = "元気";

                    correctAnswer = 3;

                    break;

                case 7:

                    lblQuestion.Text = "In Japanese, how do you say " + "Goodnight" + "?";

                    button1.Text = "おやすみなさい。";
                    button2.Text = "こにちは";
                    button3.Text = "おはようございます";
                    button4.Text = "こんばんは";

                    correctAnswer = 1;

                    break;

                case 8:

                    lblQuestion.Text = "In English, what does " + "百円" + "mean?";

                    button1.Text = "dirty";
                    button2.Text = "pull";
                    button3.Text = "a hundred yen";
                    button4.Text = "five dollars";

                    correctAnswer = 3;

                    break;
            }

        }

    }
}
