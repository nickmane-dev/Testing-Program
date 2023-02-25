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
    public partial class Test : Form
    {
        bool helps = false;
        public Test(bool _help, int _limit)
        {
            InitializeComponent();            
            tm = new TestManager();
            reloadNewPage();

            if (_help)
            {
                helps = true;
                help.Cursor = Cursors.Hand;
                noAccessToHelp.Active = false;
            }

            if (_limit < 100)
            {
                timeLabel.Visible = true;
                limit = _limit;

            }

            timeLabel.Text = "До конца теста осталось " + (_limit - tm.spentTime) + "мин";
        }

        int limit = 10000000;
       
        TestManager tm;
        
        public void selectedVariant (Button btn, byte variant)
        {
            tm.saveAnswer[tm.page] = variant;
            tm.addDemoSelectedVariant(tm.page, variant);

            reloadButton();
        }

        public void reloadButton ()
        {
            for (byte i = 1; i <= 4; i++)
            {
                getButtonVarById(i).BackColor = Color.FromArgb(164, 216, 247);
                getButtonVarById(i).ForeColor = Color.Black;

                if (tm.demoSelectedVariant[tm.page, i])
                {
                    getButtonVarById(i).BackColor = Color.SteelBlue;
                    getButtonVarById(i).ForeColor = Color.White;
                }
            }
        }

        public void reloadNewPage ()
        {
            reloadButton();
            pageLabel.Text = tm.page + " / " + tm.maxPage;

            for (byte i = 1; i <= tm.maxPage; i++)
            {
                getPanelByPage(i).Visible = false;
                getPanelByPage(i).Location = new System.Drawing.Point(500, 0);
                if (tm.page == i)
                {
                    getPanelByPage(i).Visible = true;
                    getPanelByPage(i).BringToFront();
                    getPanelByPage(i).Location = new System.Drawing.Point(5, 25);
                    getPanelByPage(i).Size = new System.Drawing.Size(784, 308);
                }

            }
        }

        public void closeTest ()
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
            this.Close();
        }
        public void aboutProgram ()
        {
            About about = new About();
            about.Show();
        }
        private void var1_Click(object sender, EventArgs e)
        {
            selectedVariant(var1, 1);
        }
        private void var2_Click(object sender, EventArgs e)
        {
            selectedVariant(var2, 2);
        }
        private void var3_Click(object sender, EventArgs e)
        {
            selectedVariant(var3, 3);
        }
        private void var4_Click(object sender, EventArgs e)
        {
            selectedVariant(var4, 4);
        }
        private void back_Click(object sender, EventArgs e)
        {
            if (tm.page == 1)
            {
                MessageBox.Show("Это и так самый первый вопрос.", "Назад пути нет!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tm.page -= 1;
            reloadNewPage();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (tm.page == tm.maxPage)
            {
                if (MessageBox.Show("Ты дошёл до конца! Ты закончил тест?", "Конец", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Result result = new Result(tm.rightAnswer, tm.saveAnswer, tm.spentTime); result.Show(); this.Hide(); this.Close();
                }
                return;
            }
            tm.page += 1;
            reloadNewPage();
        }
        private void назадВМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeTest();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutProgram();
        }

        private Button getButtonVarById(byte variant)
        {
            switch (variant)
            {
                case 1:
                    return var1;
                case 2:
                    return var2;
                case 3:
                    return var3;
                case 4:
                    return var4;

                default:
                    return null;
            }
        }
        private Panel getPanelByPage(byte page)
        {
            switch (page)
            {
                case 1:
                    return qn1;
                case 2:
                    return qn2;
                case 3:
                    return qn3;
                case 4:
                    return qn4;
                case 5:
                    return qn5;
                case 6:
                    return qn6;
                case 7:
                    return qn7;
                case 8:
                    return qn8;
                case 9:
                    return qn9;
                case 10:
                    return qn10;
                default:
                    MessageBox.Show("return null", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return null;
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void secundomer_Tick(object sender, EventArgs e)
        {
            tm.spentTime++;
            timeLabel.Text = "До конца теста осталось " + (limit - tm.spentTime) + " мин";
            if (tm.spentTime == limit)
            {
                MessageBox.Show("Время вышло!", "Конец", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Result result = new Result(tm.rightAnswer, tm.saveAnswer, tm.spentTime); result.Show(); this.Hide(); this.Close();
            }
        }

        private void help_Click(object sender, EventArgs e)
        {
            if (!helps)
            {
                return;
            }
            MessageBox.Show("В этом вопросе правильный вариант - " + tm.rightAnswer[tm.page], "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
