using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirintus_ProjektZH
{
    public partial class GameForm : Form
    {
        Steve player = new Steve();
        List<BrickBlock> bricks = new List<BrickBlock>();

        int elteltido = new int();
        int lepesszam = new int();
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            player.Top = 0;
            player.Left = 0;
            Controls.Add(player);

            //tölts pályát
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader streamReader = new StreamReader(ofd.FileName);
                    byte sorokszama = 0;
                    while (!streamReader.EndOfStream)
                    {
                        string sor = streamReader.ReadLine();
                        for (int i = 0; i < sor.Length; i++)
                        {
                            if (sor[i] == 's')
                            {
                                StartBlock startBlock = new StartBlock();
                                startBlock.Top = sorokszama * 32;
                                startBlock.Left = i * 32;
                                Controls.Add(startBlock);
                            }
                            if (sor[i] == '#')
                            {
                                BrickBlock brickBlock = new BrickBlock();
                                brickBlock.Top = sorokszama * 32;
                                brickBlock.Left = i * 32;
                                Controls.Add(brickBlock);
                                bricks.Add(brickBlock);
                            }
                            if (sor[i] == '.')
                            {
                                GrassBlock grassBlock = new GrassBlock();
                                grassBlock.Top = sorokszama * 32;
                                grassBlock.Left = i * 32;
                                Controls.Add(grassBlock);
                            }
                            if (sor[i] == 'c')
                            {
                                FinishBlock finishBlock = new FinishBlock();
                                finishBlock.Top = sorokszama * 32;
                                finishBlock.Left = i * 32;
                                Controls.Add(finishBlock);
                            }
                        }
                        sorokszama++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                timer1.Enabled = false;
                if (MessageBox.Show("Kilépsz?", "Pause menü", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Close();
                }
                timer1.Enabled = true;
            }

            int xloc = player.Left;
            int yloc = player.Top;

            if (e.KeyCode == Keys.Down) { yloc += 32; };
            if (e.KeyCode == Keys.Up && yloc != 0) { yloc -= 32; };
            if (e.KeyCode == Keys.Right) { xloc += 32; };
            if (e.KeyCode == Keys.Left && xloc !=0) { xloc -= 32; };

            foreach (Control c in Controls)
            {
                if (c is BrickBlock)
                {
                    if (c.Top == yloc && c.Left == xloc)
                    {
                        return;
                    }
                }
            }
            player.Left = xloc;
            player.Top = yloc;
            lepesszam++;
            lepesszamLabel.Text = "Lépésszám: " + lepesszam.ToString();
            
            foreach (Control vege in Controls)
            {
                if (vege is FinishBlock)
                {
                    if (vege.Top == yloc && vege.Left == xloc)
                    {
                        MessageBox.Show("Pálya teljesítve!");
                        Close();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elteltido++;
            elteltIdoLabel.Text = "Eltelt idő: "+elteltido.ToString();
        }
    }
}
