using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_Battleship
{
    public partial class FilterView : Form
    {
        BSContoller bsController;
        int[,] player = new int[10, 10];
        int[,] ai = new int[10, 10];


        public FilterView(BSContoller bs)
        {
            InitializeComponent();
            bsController = bs;
            bsController.setDatagridView(dgv);
            dgv[0, 0].Selected = true;
            dgv.CurrentCell.Selected = false;
            cmbBoardSelection.Items.Insert(0, "Player Game Board");
            cmbBoardSelection.Items.Insert(1, "Computer Game Board");
            cmbBoardSelection.SelectedIndex = 0;
        }

        //Set the data grid view
        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                dgv.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgv.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgv.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        //Refresh the data grid view
        public void refreshView(int[,] playerBoard, int[,] aiBoard)
        {
            player = playerBoard;
            ai = aiBoard;
            
            if (cmbBoardSelection.SelectedIndex == 0)
            {
                lblTitle.Text = "Player Game Board";
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        dgv[j, i].Value = "";
                        dgv[j, i].Style.BackColor = Color.Blue;
                        if (player[i, j] == 2 || player[i, j] == 3 || player[i, j] == 4)
                        {
                            dgv[j, i].Value = "B";
                        }
                        else if (player[i, j] == 5 || player[i, j] == 6 || player[i, j] == 7)
                        {
                            dgv[j, i].Value = "B";
                            dgv[j, i].Style.BackColor = Color.Red;
                        }
                        else if (player[i, j] == 1)
                        {
                            dgv[j, i].Style.BackColor = Color.Red;
                        }
                    }
                }
            }
            else {
                lblTitle.Text = "Computer Game Board";
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        dgv[j, i].Value = "";
                        dgv[j, i].Style.BackColor = Color.Blue;
                        if (ai[i, j] == 8 || ai[i, j] == 9 || ai[i, j] == 10)
                        {
                            dgv[j, i].Value = "B";
                        }
                        else if (ai[i, j] == 11 || ai[i, j] == 12 || ai[i, j] == 13)
                        {
                            dgv[j, i].Value = "B";
                            dgv[j, i].Style.BackColor = Color.Red;
                        }
                        else if (ai[i, j] == 1)
                        {
                            dgv[j, i].Style.BackColor = Color.Red;
                        }
                    }
                }
            }
            
        }

        //Refresh the board when user selection change
        private void cmbBoardSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshView(player,ai);
        }
    }
}
