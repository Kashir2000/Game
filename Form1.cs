using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Game__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random RN = new Random(); //新增亂數物件
        List<int> Number = new List<int>(); //新增表單物件
        Button FirstClick = null; //紀錄第一次按鍵的值 (遊戲中產生按鈕第一次的選項按鈕)
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer(); //創建音樂物件
        public static int Rank; //難度等級
        public static int ClickCount;  //紀錄按第幾次(2次歸0)
        public static int WinRecord; //紀錄按對組數
        public static int TotalStep; //總步數

        private void GameStart_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            wplayer.URL = @"TVアニメ「進撃の巨人」The Final SeasonノンクレジットOP【神聖かまってちゃん「僕の戦争」】.mp3";
            wplayer.controls.play();
            wplayer.settings.setMode("loop",true); //重複播放 
            
            
            WinRecord = 0;   //重置全域變數,防止中途遊戲中又重新開始導致新局出錯
            ClickCount = 0;
            WinRecord = 0;
            TotalStep = 0;
            FirstClick = null;
            Number.Clear();


            //難度選擇
            if (Easy.Checked)
            {
                Rank = 4;
                NewGame(Rank);
            }
            else if (Normal.Checked)
            {
                Rank = 6;
                NewGame(Rank);
            }
            else if (Hard.Checked)
            {
                Rank = 8;
                NewGame(Rank);
            }
            else
            {
                Rank = 10;
                NewGame(Rank);
            }

        }
        private void NewGame(int Rank)
        {
            int i, j;
            for (i = 0; i < (Rank * Rank) / 2; i++)
            {
                Number.Add(i);
                Number.Add(i);  //置入數字組
            }
            for (i = 0; i < Rank; i++)
            {
                for (j = 0; j < Rank; j++)
                {
                    int Lucky;
                    Lucky = RN.Next(0, Number.Count); //置入隨機到的數字進表單
                    Button button = new Button()
                    {                                             //創建按鈕格式
                        Text = Convert.ToString(Number[Lucky]),  //將隨機到的數字轉換字串
                        Size = new Size(60, 60),  //控制按鍵大小
                        Location = new Point(5 + (90 * i), 5 + (66 * j)),  //置放位置
                    };
                    button.FlatAppearance.BorderColor = Color.Blue; //改變邊框顏色        
                    button.ForeColor = Color.Gray;  //按鍵字體轉換灰色
                    button.BackColor = Color.Gray;  //背景反灰
                    button.Click += new EventHandler(button_Click); //按鈕共用事件
                    Number.RemoveAt(Lucky);  //置入完成後,將隨機到的數字值的數字組移除
                    this.splitContainer1.Panel2.Controls.Add(button);  //按鈕加入視窗
                }
            }

        }
        private void button_Click(object sender, EventArgs e)
        {
            Button ClickOn = (Button)sender;
            ClickCount++; //按下按鈕次數+1
            TotalStep++;  //紀錄次數
            if (ClickCount == 1)  //第一次翻牌
            {
                ClickOn.BackColor = Color.BlueViolet; //改變按下按鈕背景色
                ClickOn.ForeColor = Color.White;  //顯示字體(改色)
                ClickOn.Enabled = false; //已選時,不可取消
                FirstClick = ClickOn; //記住按鍵
            }
            else if (ClickCount == 2) //第二次翻牌
            {
                ClickCount = 0;  //紀錄次數歸0
                if (ClickOn.Text == FirstClick.Text)
                {
                    ClickOn.BackColor = Color.BlueViolet;  //同上變化按鈕背景與字體顏色
                    ClickOn.ForeColor = Color.White;
                    ClickOn.Enabled = false;
                    WinRecord += 2;  //答對後,紀錄組數(1組為2個)
                    FirstClick = null;
                    if (WinRecord == Rank * Rank)
                    {
                        MessageBox.Show("總步數為" + TotalStep + "次", "過關", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        wplayer.controls.stop(); //過關後停止播放
                        Process.Start("https://www.youtube.com/watch?v=072tU1tamd0");
                    }
                }
                else  //如果翻到不一樣的
                {
                    ClickOn.BackColor = Color.BlueViolet;  //同上變化按鈕背景與字體顏色
                    ClickOn.ForeColor = Color.White;
                    ClickOn.Enabled = false;
                    Thread.Sleep(600);  //暫停並顯示
                    ClickOn.BackColor = Color.Gray;  //恢復初始狀態並解除鎖定按鈕
                    ClickOn.ForeColor = Color.Gray;
                    ClickOn.Enabled = true;
                    FirstClick.BackColor = Color.Gray; //第一次選的也恢復初始狀態並解鎖按鈕
                    FirstClick.ForeColor = Color.Gray;
                    FirstClick.Enabled = true;
                    FirstClick = null;   //重設暫存按鈕
                }
            }

        }
    }
}

