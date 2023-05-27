using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace Gradient
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private int indx = 0;
        Button[] btns = new Button[500];
        List<Button> btns2 = new List<Button>();    

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Gradient";
            this.Size = new Size(500, 440);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            int posX = 0;
            int posY = 0;
            
            for (int i = 0; i < 500; i++)
            {

                if (posX >= this.Width - 20)
                {
                    posX = 0;
                    posY += 20;

                }
                  
                Button btn = new Button();
                btn.Name = indx.ToString();
                btn.Size = new Size(20, 20);
                btn.BackColor = Color.White;
                btn.Location = new Point(posX, posY);
                //btn.MouseHover += (s, e) => btn.BackColor = Color.FromArgb(255, 255, 160, 122);
                btn.MouseHover += Btn_MouseHover;
                btn.MouseLeave += Btn_MouseLeave;

                posX += 20;
                btns[i] = (btn);
                btns2.Add(btn);

                // add my btn to my form !!!!!
                this.Controls.Add(btn);
                indx++;
            }


        }

        private void Btn_MouseHover(object sender, EventArgs e)

        {

            (sender as Button).BackColor = Color.FromArgb(255, 250, 17, 0);
            for (int i = 0; i<500; i++)
            {
                if (btns[i] == sender as Button)
                {
                    btns[i + 1].BackColor = Color.FromArgb(255, 252, 69, 56);
                    btns[i + 24].BackColor = Color.FromArgb(255, 252, 69, 56);
                    btns[i + 23].BackColor = Color.FromArgb(255, 252, 69, 56);
                    btns[i + 25].BackColor = Color.FromArgb(255, 252, 69, 56);
                    if (i > 0)
                    {
                        btns[i - 1].BackColor = Color.FromArgb(255, 252, 69, 56);
                    }
                    if (i > 22)
                    { 
                    btns[i - 23].BackColor = Color.FromArgb(255, 252, 69, 56);
                    }
                    if (i > 23)
                    {
                        btns[i - 24].BackColor = Color.FromArgb(255, 252, 69, 56);
                    }
                    if (i > 24)
                    {
                        btns[i - 25].BackColor = Color.FromArgb(255, 252, 69, 56);
                    }
                    btns[i + 2].BackColor = Color.FromArgb(255, 247, 97, 87);
                    btns[i - 2].BackColor = Color.FromArgb(255, 247, 97, 87);
                    btns[i + 22].BackColor = Color.FromArgb(255, 247, 97, 87);
                    btns[i + 26].BackColor = Color.FromArgb(255, 247, 97, 87);
                    btns[i - 22].BackColor = Color.FromArgb(255, 247, 97, 87);
                    btns[i - 26].BackColor = Color.FromArgb(255, 247, 97, 87);



                }
            }

        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
           // (sender as Button).BackColor = Color.White;
            for (int i = 0; i < 500; i++)
            {
                btns[i].BackColor = Color.White;
            }
            
            

            #endregion
        }

    }
}

