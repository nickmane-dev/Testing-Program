using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_by.Timashov
{
    public partial class Result : Form
    {
        public Result(Dictionary<int,int> _rightAnswer, Dictionary<int, int> _saveAnswer, int _time)
        {
            InitializeComponent();
            rightAnswer = _rightAnswer;
            saveAnswer = _saveAnswer;
            time = _time;
            loadForm();            
        }

        int time = 0;
        Dictionary<int, int> rightAnswer = new Dictionary<int, int>();
        Dictionary<int, int> saveAnswer = new Dictionary<int, int>();

        int rate1 = 2;
        int rate2 = 3;
        int rate3 = 5;
        int rate4 = 7;
        int rate5 = 10;

        int score = 0;
        int rate = 0;

        public void loadForm ()
        {

            for (int i = 1; i < rightAnswer.Count + 1; i++)
            {
                try
                {
                    if (rightAnswer[i] == saveAnswer[i])
                    {
                        score++;
                    }
                } catch
                {

                }
            }



            switch (score)
            {
                case 0:
                    rate = 0;
                    break;
                case 1:
                    rate = 1;
                    break;
                case 2:
                    rate = 2;
                    break;
                case 3:
                    rate = 2;
                    break;
                case 4:
                    rate = 2;
                    break;
                case 5:
                    rate = 3;
                    break;
                case 6:
                    rate = 3;
                    break;
                case 7:
                    rate = 4;
                    break;
                case 8:
                    rate = 4;
                    break;
                case 9:
                    rate = 4;
                    break;
                case 10:
                    rate = 5;
                    break;
            }




            if (rate != 5)
            {
                if (rate == 0)
                {
                    rateTxt.Text = "Оценка " + rate;
                    advice.Text = "Очень плох, \nизучи материал.";
                    sym.Text = "🤦";
                }
                else if (rate == 1)
                {
                    rateTxt.Text = "Оценка " + rate;
                    advice.Text = "Плохой из тебя философ. \nРекомендую изучить материал лучше.";
                    sym.Text = "🙄";
                }
                else if (rate == 2)
                {
                    rateTxt.Text = "Оценка " + rate;
                    advice.Text = "Почти философ лол";
                    sym.Text = "😔";
                }
                else if (rate == 3)
                {
                    rateTxt.Text = "Оценка " + rate;
                    advice.Text = "Ты удоволетворительный философ)) \nно можно было, и лучше.";
                    sym.Text = "😌";
                }
                else if (rate == 4)
                {
                    rateTxt.Text = "Оценка " + rate;
                    advice.Text = "Нормальный философ ты \nхочешь стать выше? \nто поработай над ошибками.";
                    sym.Text = "😁";
                }

            }
            else
            {
                rateTxt.Text = "Оценка 5";
                advice.Text = "Тебя можно сравнить с любым \nвеликым философым.";
                sym.Text = "🔥";
            }

            scoreTxt.Text = "Вы получили " + score + " баллов из 10";
            timeTxt.Text = "Вы потратили " + time + " минут на тест";
        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
            this.Close();
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
