using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace MVC_Battleship
{
    public class BSContoller
    {
        TextView textView;
        GraphicView graphicView;
        FilterView filterView;

        Board board = new Board();

        int rowPoisiton; //Store the current row position
        int columnPosition; //Store the current column position
        int putBoardPeriod = 0; //Define period of putting battles
        int startRowPosition = 0; //Start row position of each battle
        int startColoumnPosition = 0; //Start column position of each battle
        string[] rowList = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        string[] columnList = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        Thread newThread;
        System.Media.SoundPlayer sp;

        public void showViews(){
            textView = new TextView(this);
            graphicView = new GraphicView(this);
            filterView = new FilterView(this);
            textView.Show();
            graphicView.Show();
            filterView.Show();
            newThread = new Thread(musicSet);
            sp = new SoundPlayer();
        }
        //Format the oringinal board
        public void setDatagridView(System.Windows.Forms.DataGridView dgv)
        {
            for (int i = 0; i < 10; i++)
            {
                dgv.Rows.Add();
            }
            for (int i = 0; i < 10; i++)
            {
                dgv.Columns[i].Width = 30;
                dgv.Rows[i].Height = 30;
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    dgv[i, j].Style.BackColor = Color.Blue;
                    dgv[i, j].Value = "";
                }
            }
        }

        //Set the new game boards for player and AI
        public void newGameBoardSet(int viewDefinder)
        {
            int[,] boardPlayer = new int[10, 10];
            int[,] boardAI = new int[10, 10];
            board.setBoardPlayer(boardPlayer);
            board.setBoardAI(boardAI);
            putBoardPeriod = 0;
            if (viewDefinder == 0)
            {
                graphicView.newGame(0);
            }
            else if (viewDefinder == 1) {
                textView.newGame(1);
            }
        }

        //Check the start position and available end position of each battle
        public Boolean putBattle(System.Windows.Forms.DataGridView dgvPlayer, System.Windows.Forms.Label label, System.Windows.Forms.Label pLabel1, System.Windows.Forms.Label pLabel2, System.Windows.Forms.Label pLabel3)
        {
            int[,] boardPlayer;
            Boolean finished = false;
            //Define the period of putting battles
            switch (putBoardPeriod)
            {
                case 0:
                    {
                        //Set the start position of submarine
                        dgvPlayer.CurrentCell.Value = "S";
                        rowPoisiton = dgvPlayer.CurrentCell.RowIndex;
                        columnPosition = dgvPlayer.CurrentCell.ColumnIndex;
                        boardPlayer = board.getBoardPlayer();
                        boardPlayer[rowPoisiton, columnPosition] = 2;
                        board.setBoardPlayer(boardPlayer);
                        textView.putMessage(columnPosition, rowPoisiton,putBoardPeriod);

                        //Check Up
                        if (rowPoisiton > 0 && boardPlayer[rowPoisiton - 1, columnPosition] == 0)
                        {
                            boardPlayer[rowPoisiton - 1, columnPosition] = 15;
                            dgvPlayer[columnPosition, rowPoisiton - 1].Value = "E";
                        }

                        //Check Down
                        if (rowPoisiton < 9 && boardPlayer[rowPoisiton + 1, columnPosition] == 0)
                        {
                            boardPlayer[rowPoisiton + 1, columnPosition] = 15;
                            dgvPlayer[columnPosition, rowPoisiton + 1].Value = "E";
                        }

                        //Check Left
                        if (columnPosition > 0 && boardPlayer[rowPoisiton, columnPosition - 1] == 0)
                        {
                            boardPlayer[rowPoisiton, columnPosition - 1] = 15;
                            dgvPlayer[columnPosition - 1, rowPoisiton].Value = "E";
                        }

                        //Check Right
                        if (columnPosition < 9 && boardPlayer[rowPoisiton, columnPosition + 1] == 0)
                        {
                            boardPlayer[rowPoisiton, columnPosition + 1] = 15;
                            dgvPlayer[columnPosition + 1, rowPoisiton].Value = "E";
                        }

                        label.Text = "Please select the end position of the submarine(Length is 2)";
                        putBoardPeriod++;
                        //dgvPlayer.ClearSelection();
                    }
                    break;
                case 1:
                    {//Set the end position of submarine
                        rowPoisiton = dgvPlayer.CurrentCell.RowIndex;
                        columnPosition = dgvPlayer.CurrentCell.ColumnIndex;
                        boardPlayer = board.getBoardPlayer();
                        if (boardPlayer[rowPoisiton, columnPosition] == 15)
                        {
                            boardPlayer[rowPoisiton, columnPosition] = 2;
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    if (boardPlayer[i, j] == 15)
                                    {
                                        dgvPlayer[j, i].Value = "";
                                        boardPlayer[i, j] = 0;
                                    }
                                    else if (boardPlayer[i, j] == 2)
                                    {
                                        dgvPlayer[j, i].Value = "B";
                                    }
                                }
                            }
                            label.Text = "Please select the start position of the destroyer(Length is 3)";
                            pLabel1.Text = "Ready";
                            textView.putMessage(columnPosition, rowPoisiton, putBoardPeriod);
                            putBoardPeriod++;
                            
                        }
                        else {
                            label.Text = "You can't put the end position here, please select one cell which has \"E\"";
                            textView.textBoxAddMessage("You can't put the end position here, please select one cell which has \"E\"\r\n");
                        }
                    }
                    break;
                case 2:
                    {//Set the start position of destoryer
                        rowPoisiton = dgvPlayer.CurrentCell.RowIndex;
                        columnPosition = dgvPlayer.CurrentCell.ColumnIndex;
                        boardPlayer = board.getBoardPlayer();
                        if (boardPlayer[rowPoisiton, columnPosition] == 0)
                        {
                            dgvPlayer.CurrentCell.Value = "S";
                            boardPlayer[rowPoisiton, columnPosition] = 3;
                            startRowPosition = rowPoisiton;
                            startColoumnPosition = columnPosition;
                            textView.putMessage(columnPosition, rowPoisiton, putBoardPeriod);
                            //MessageBox.Show(startRowPosition.ToString() + " " + startColoumnPosition.ToString());

                            //Check Up
                            if (rowPoisiton > 1 && boardPlayer[rowPoisiton - 1, columnPosition] == 0 && boardPlayer[rowPoisiton - 2, columnPosition] == 0)
                            {
                                boardPlayer[rowPoisiton - 2, columnPosition] = 15;
                                dgvPlayer[columnPosition, rowPoisiton - 2].Value = "E";
                            }

                            //Check Down
                            if (rowPoisiton < 8 && boardPlayer[rowPoisiton + 1, columnPosition] == 0 && boardPlayer[rowPoisiton + 2, columnPosition] == 0)
                            {
                                boardPlayer[rowPoisiton + 2, columnPosition] = 15;
                                dgvPlayer[columnPosition, rowPoisiton + 2].Value = "E";
                            }

                            //Check Left
                            if (columnPosition > 1 && boardPlayer[rowPoisiton, columnPosition - 1] == 0 && boardPlayer[rowPoisiton, columnPosition - 2] == 0)
                            {
                                boardPlayer[rowPoisiton, columnPosition - 2] = 15;
                                dgvPlayer[columnPosition - 2, rowPoisiton].Value = "E";
                            }

                            //Check Right
                            if (columnPosition < 8 && boardPlayer[rowPoisiton, columnPosition + 1] == 0 && boardPlayer[rowPoisiton, columnPosition + 2] == 0)
                            {
                                boardPlayer[rowPoisiton, columnPosition + 2] = 15;
                                dgvPlayer[columnPosition + 2, rowPoisiton].Value = "E";
                            }

                            label.Text = "Please select the end position of the destory(Length is 3)";
                            putBoardPeriod++;
                        }
                        else {
                            label.Text = "You can't put the battle here because there already has a battle in this position";
                            textView.textBoxAddMessage("You can't put the battle here because there already has a battle in this position\r\n");
                        }
                    }
                    break;
                case 3:
                    {//Set the end position of destoryer
                        rowPoisiton = dgvPlayer.CurrentCell.RowIndex;
                        columnPosition = dgvPlayer.CurrentCell.ColumnIndex;
                        boardPlayer = board.getBoardPlayer();
                        //MessageBox.Show(startRowPosition.ToString() + " " + startColoumnPosition.ToString());
                        int rowDif = rowPoisiton - startRowPosition;
                        int columnDif = columnPosition - startColoumnPosition;
                        //MessageBox.Show(rowDif.ToString() + " " + columnDif.ToString());

                        if (boardPlayer[rowPoisiton, columnPosition] == 15)
                        {
                            boardPlayer[rowPoisiton, columnPosition] = 3;
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    if (boardPlayer[i, j] == 15)
                                    {
                                        dgvPlayer[j, i].Value = "";
                                        boardPlayer[i, j] = 0;
                                    }
                                    else if (boardPlayer[i, j] == 3)
                                    {
                                        dgvPlayer[j, i].Value = "B";
                                    }
                                }
                            }

                            //Put the body of the Battle
                            if (rowDif > 0 && columnDif == 0)
                            {
                                boardPlayer[rowPoisiton - 1, columnPosition] = 3;
                                dgvPlayer[columnPosition, rowPoisiton - 1].Value = "B";
                            }
                            else if (rowDif < 0 && columnDif == 0)
                            {
                                boardPlayer[rowPoisiton + 1, columnPosition] = 3;
                                dgvPlayer[columnPosition, rowPoisiton + 1].Value = "B";
                            }
                            else if (rowDif == 0 && columnDif > 0)
                            {
                                boardPlayer[rowPoisiton, columnPosition - 1] = 3;
                                dgvPlayer[columnPosition - 1, rowPoisiton].Value = "B";
                            }
                            else if (rowDif == 0 && columnDif < 0)
                            {
                                boardPlayer[rowPoisiton, columnPosition + 1] = 3;
                                dgvPlayer[columnPosition + 1, rowPoisiton].Value = "B";
                            }
                            label.Text = "Please select the start position of the cruiser(Length is 4)";
                            pLabel2.Text = "Ready";
                            textView.putMessage(columnPosition, rowPoisiton, putBoardPeriod);
                            putBoardPeriod++;
                            
                        }
                        else {
                            label.Text = "You can't put the end position here, please select one cell which has \"E\"";
                            textView.textBoxAddMessage("You can't put the end position here, please select one cell which has \"E\"\r\n");
                        }
                    }
                    break;
                case 4:
                    {//Set the start position of cruiser
                        rowPoisiton = dgvPlayer.CurrentCell.RowIndex;
                        columnPosition = dgvPlayer.CurrentCell.ColumnIndex;
                        boardPlayer = board.getBoardPlayer();
                        if (boardPlayer[rowPoisiton, columnPosition] == 0)
                        {
                            dgvPlayer.CurrentCell.Value = "S";
                            boardPlayer[rowPoisiton, columnPosition] = 4;
                            startRowPosition = rowPoisiton;
                            startColoumnPosition = columnPosition;
                            textView.putMessage(columnPosition, rowPoisiton, putBoardPeriod);
                            //MessageBox.Show(startRowPosition.ToString() + " " + startColoumnPosition.ToString());

                            //Check Up
                            if (rowPoisiton > 2 && boardPlayer[rowPoisiton - 1, columnPosition] == 0 && boardPlayer[rowPoisiton - 2, columnPosition] == 0
                                && boardPlayer[rowPoisiton - 3, columnPosition] == 0)
                            {
                                boardPlayer[rowPoisiton - 3, columnPosition] = 15;
                                dgvPlayer[columnPosition, rowPoisiton - 3].Value = "E";
                            }

                            //Check Down
                            if (rowPoisiton < 7 && boardPlayer[rowPoisiton + 1, columnPosition] == 0 && boardPlayer[rowPoisiton + 2, columnPosition] == 0
                                && boardPlayer[rowPoisiton + 3, columnPosition] == 0)
                            {
                                boardPlayer[rowPoisiton + 3, columnPosition] = 15;
                                dgvPlayer[columnPosition, rowPoisiton + 3].Value = "E";
                            }

                            //Check Left
                            if (columnPosition > 2 && boardPlayer[rowPoisiton, columnPosition - 1] == 0 && boardPlayer[rowPoisiton, columnPosition - 2] == 0
                                && boardPlayer[rowPoisiton, columnPosition - 3] == 0)
                            {
                                boardPlayer[rowPoisiton, columnPosition - 3] = 15;
                                dgvPlayer[columnPosition - 3, rowPoisiton].Value = "E";
                            }

                            //Check Right
                            if (columnPosition < 7 && boardPlayer[rowPoisiton, columnPosition + 1] == 0 && boardPlayer[rowPoisiton, columnPosition + 2] == 0
                                && boardPlayer[rowPoisiton, columnPosition + 3] == 0)
                            {
                                boardPlayer[rowPoisiton, columnPosition + 3] = 15;
                                dgvPlayer[columnPosition + 3, rowPoisiton].Value = "E";
                            }

                            label.Text = "Please select the end position of the cruiser(Length is 4)";
                            putBoardPeriod++;
                        }
                        else {
                            label.Text = "You can't put the battle here because there already has a battle in this position";
                            textView.textBoxAddMessage("You can't put the battle here because there already has a battle in this position\r\n");

                        }

                    }
                    break;
                case 5:
                    {//Set the end position of cruiser
                        rowPoisiton = dgvPlayer.CurrentCell.RowIndex;
                        columnPosition = dgvPlayer.CurrentCell.ColumnIndex;
                        boardPlayer = board.getBoardPlayer();
                        //MessageBox.Show(startRowPosition.ToString() + " " + startColoumnPosition.ToString());
                        int rowDif = rowPoisiton - startRowPosition;
                        int columnDif = columnPosition - startColoumnPosition;
                        //MessageBox.Show(rowDif.ToString() + " " + columnDif.ToString());

                        if (boardPlayer[rowPoisiton, columnPosition] == 15)
                        {
                            boardPlayer[rowPoisiton, columnPosition] = 4;
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    if (boardPlayer[i, j] == 15)
                                    {
                                        dgvPlayer[j, i].Value = "";
                                        boardPlayer[i, j] = 0;
                                    }
                                    else if (boardPlayer[i, j] == 4)
                                    {
                                        dgvPlayer[j, i].Value = "B";
                                    }
                                }
                            }

                            //Put the body of the Battle
                            if (rowDif > 0 && columnDif == 0)
                            {
                                boardPlayer[rowPoisiton - 1, columnPosition] = 4;
                                dgvPlayer[columnPosition, rowPoisiton - 1].Value = "B";
                                boardPlayer[rowPoisiton - 2, columnPosition] = 4;
                                dgvPlayer[columnPosition, rowPoisiton - 2].Value = "B";
                            }
                            else if (rowDif < 0 && columnDif == 0)
                            {
                                boardPlayer[rowPoisiton + 1, columnPosition] = 4;
                                dgvPlayer[columnPosition, rowPoisiton + 1].Value = "B";
                                boardPlayer[rowPoisiton + 2, columnPosition] = 4;
                                dgvPlayer[columnPosition, rowPoisiton + 2].Value = "B";
                            }
                            else if (rowDif == 0 && columnDif > 0)
                            {
                                boardPlayer[rowPoisiton, columnPosition - 1] = 4;
                                dgvPlayer[columnPosition - 1, rowPoisiton].Value = "B";
                                boardPlayer[rowPoisiton, columnPosition - 2] = 4;
                                dgvPlayer[columnPosition - 2, rowPoisiton].Value = "B";
                            }
                            else if (rowDif == 0 && columnDif < 0)
                            {
                                boardPlayer[rowPoisiton, columnPosition + 1] = 4;
                                dgvPlayer[columnPosition + 1, rowPoisiton].Value = "B";
                                boardPlayer[rowPoisiton, columnPosition + 2] = 4;
                                dgvPlayer[columnPosition + 2, rowPoisiton].Value = "B";
                            }
                            label.Text = "Please click Start Game Button to start the game.";
                            pLabel3.Text = "Ready";
                            finished = true;
                            textView.putMessage(columnPosition, rowPoisiton, putBoardPeriod);
                        }
                        else {
                            label.Text = "You can't put the end position here, please select one cell which has \"E\"";
                            textView.textBoxAddMessage("You can't put the end position here, please select one cell which has \"E\"\r\n");
                        }
                    }
                    break;
                default:
                    {

                    }
                    break;
            }
            refreshFilterView();
            return finished;
        }


        //Check the start position and available end position of each battle, put battleship by using TextView
        public Boolean putBattleText(int column,int row, System.Windows.Forms.TextBox txtBox, System.Windows.Forms.Label pLabel1, System.Windows.Forms.Label pLabel2, System.Windows.Forms.Label pLabel3)
        {
            int[,] boardPlayer;
            Boolean finished = false;
            //Define the period of putting battles
            switch (putBoardPeriod)
            {
                case 0:
                    {
                        //Set the start position of submarine
                        graphicView.putBattleGraphic(row, column, putBoardPeriod,"S");
                        rowPoisiton = row;
                        columnPosition = column;
                        boardPlayer = board.getBoardPlayer();
                        boardPlayer[rowPoisiton, columnPosition] = 2;
                        board.setBoardPlayer(boardPlayer);
                        textView.putMessage(columnPosition, rowPoisiton, putBoardPeriod);

                        //Check Up
                        if (rowPoisiton > 0 && boardPlayer[rowPoisiton - 1, columnPosition] == 0)
                        {
                            boardPlayer[rowPoisiton - 1, columnPosition] = 15;
                            
                            graphicView.putBattleGraphic(row-1, column, putBoardPeriod, "E");
                        }

                        //Check Down
                        if (rowPoisiton < 9 && boardPlayer[rowPoisiton + 1, columnPosition] == 0)
                        {
                            boardPlayer[rowPoisiton + 1, columnPosition] = 15;
                            
                            graphicView.putBattleGraphic(row+1, column, putBoardPeriod, "E");
                        }

                        //Check Left
                        if (columnPosition > 0 && boardPlayer[rowPoisiton, columnPosition - 1] == 0)
                        {
                            boardPlayer[rowPoisiton, columnPosition - 1] = 15;
                            graphicView.putBattleGraphic(row, column-1, putBoardPeriod, "E");
                        }

                        //Check Right
                        if (columnPosition < 9 && boardPlayer[rowPoisiton, columnPosition + 1] == 0)
                        {
                            boardPlayer[rowPoisiton, columnPosition + 1] = 15;
                            graphicView.putBattleGraphic(row, column+1, putBoardPeriod, "E");
                        }
                        
                        putBoardPeriod++;
                    }
                    break;

                
                case 1:
                    {//Set the end position of submarine
                        rowPoisiton = row;
                        columnPosition = column;
                        boardPlayer = board.getBoardPlayer();
                        if (boardPlayer[rowPoisiton, columnPosition] == 15)
                        {
                            boardPlayer[rowPoisiton, columnPosition] = 2;
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    if (boardPlayer[i, j] == 15)
                                    {
                                        graphicView.putBattleGraphic(i, j, putBoardPeriod, "");
                                        boardPlayer[i, j] = 0;
                                    }
                                    else if (boardPlayer[i, j] == 2)
                                    {
                                        
                                        graphicView.putBattleGraphic(i, j, putBoardPeriod, "B");
                                    }
                                }
                            }
                            pLabel1.Text = "Ready";
                            textView.putMessage(columnPosition, rowPoisiton, putBoardPeriod);
                            putBoardPeriod++;
                            
                        }
                        else {
                            txtBox.Text += "You can't put the end position here, please select one cell which has \"E\" \r\n";
                        }
                    }
                    break;
                case 2:
                    {//Set the start position of destoryer
                        rowPoisiton = row;
                        columnPosition = column;
                        boardPlayer = board.getBoardPlayer();
                        if (boardPlayer[rowPoisiton, columnPosition] == 0)
                        {
                            graphicView.putBattleGraphic(row, column, putBoardPeriod, "S");
                            boardPlayer[rowPoisiton, columnPosition] = 3;
                            startRowPosition = rowPoisiton;
                            startColoumnPosition = columnPosition;
                            textView.putMessage(columnPosition, rowPoisiton, putBoardPeriod);

                            //Check Up
                            if (rowPoisiton > 1 && boardPlayer[rowPoisiton - 1, columnPosition] == 0 && boardPlayer[rowPoisiton - 2, columnPosition] == 0)
                            {
                                boardPlayer[rowPoisiton - 2, columnPosition] = 15;
                                graphicView.putBattleGraphic(row-2, column, putBoardPeriod, "E");
                            }

                            //Check Down
                            if (rowPoisiton < 8 && boardPlayer[rowPoisiton + 1, columnPosition] == 0 && boardPlayer[rowPoisiton + 2, columnPosition] == 0)
                            {
                                boardPlayer[rowPoisiton + 2, columnPosition] = 15;
                                graphicView.putBattleGraphic(row+2, column, putBoardPeriod, "E");
                            }

                            //Check Left
                            if (columnPosition > 1 && boardPlayer[rowPoisiton, columnPosition - 1] == 0 && boardPlayer[rowPoisiton, columnPosition - 2] == 0)
                            {
                                boardPlayer[rowPoisiton, columnPosition - 2] = 15;
                                graphicView.putBattleGraphic(row, column -2, putBoardPeriod, "E");
                            }

                            //Check Right
                            if (columnPosition < 8 && boardPlayer[rowPoisiton, columnPosition + 1] == 0 && boardPlayer[rowPoisiton, columnPosition + 2] == 0)
                            {
                                boardPlayer[rowPoisiton, columnPosition + 2] = 15;
                                graphicView.putBattleGraphic(row, column + 2, putBoardPeriod, "E");
                            }
                            
                            putBoardPeriod++;
                        }
                        else {
                            txtBox.Text += "You can't put the battle here because there already has a battle in this position\r\n";
                        }
                    }
                    break;
                case 3:
                    {//Set the end position of destoryer
                        rowPoisiton = row;
                        columnPosition = column;
                        boardPlayer = board.getBoardPlayer();
                        int rowDif = rowPoisiton - startRowPosition;
                        int columnDif = columnPosition - startColoumnPosition;

                        if (boardPlayer[rowPoisiton, columnPosition] == 15)
                        {
                            boardPlayer[rowPoisiton, columnPosition] = 3;
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    if (boardPlayer[i, j] == 15)
                                    {
                                        graphicView.putBattleGraphic(i, j, putBoardPeriod, "");
                                        boardPlayer[i, j] = 0;
                                    }
                                    else if (boardPlayer[i, j] == 3)
                                    {
                                        graphicView.putBattleGraphic(i, j, putBoardPeriod, "B");
                                    }
                                }
                            }

                            //Put the body of the Battle
                            if (rowDif > 0 && columnDif == 0)
                            {
                                boardPlayer[rowPoisiton - 1, columnPosition] = 3;
                                graphicView.putBattleGraphic(row-1, column, putBoardPeriod, "B");
                            }
                            else if (rowDif < 0 && columnDif == 0)
                            {
                                boardPlayer[rowPoisiton + 1, columnPosition] = 3;
                                graphicView.putBattleGraphic(row+1, column, putBoardPeriod, "B");
                            }
                            else if (rowDif == 0 && columnDif > 0)
                            {
                                boardPlayer[rowPoisiton, columnPosition - 1] = 3;
                                graphicView.putBattleGraphic(row, column -1, putBoardPeriod, "B");
                            }
                            else if (rowDif == 0 && columnDif < 0)
                            {
                                boardPlayer[rowPoisiton, columnPosition + 1] = 3;
                                graphicView.putBattleGraphic(row, column + 1, putBoardPeriod, "B");
                            }
                            pLabel2.Text = "Ready";
                            textView.putMessage(columnPosition, rowPoisiton, putBoardPeriod);
                            putBoardPeriod++;
                            
                        }
                        else {
                            txtBox.Text += "You can't put the end position here, please select one cell which has \"E\"\r\n";
                        }
                    }
                    break;
                case 4:
                    {//Set the start position of cruiser
                        rowPoisiton = row;
                        columnPosition = column;
                        boardPlayer = board.getBoardPlayer();
                        if (boardPlayer[rowPoisiton, columnPosition] == 0)
                        {
                            graphicView.putBattleGraphic(row, column, putBoardPeriod, "S");
                            boardPlayer[rowPoisiton, columnPosition] = 4;
                            startRowPosition = rowPoisiton;
                            startColoumnPosition = columnPosition;
                            textView.putMessage(columnPosition, rowPoisiton, putBoardPeriod);

                            //Check Up
                            if (rowPoisiton > 2 && boardPlayer[rowPoisiton - 1, columnPosition] == 0 && boardPlayer[rowPoisiton - 2, columnPosition] == 0
                                && boardPlayer[rowPoisiton - 3, columnPosition] == 0)
                            {
                                boardPlayer[rowPoisiton - 3, columnPosition] = 15;
                                graphicView.putBattleGraphic(row-3, column, putBoardPeriod, "E");
                            }

                            //Check Down
                            if (rowPoisiton < 7 && boardPlayer[rowPoisiton + 1, columnPosition] == 0 && boardPlayer[rowPoisiton + 2, columnPosition] == 0
                                && boardPlayer[rowPoisiton + 3, columnPosition] == 0)
                            {
                                boardPlayer[rowPoisiton + 3, columnPosition] = 15;
                                graphicView.putBattleGraphic(row+3, column, putBoardPeriod, "E");
                            }

                            //Check Left
                            if (columnPosition > 2 && boardPlayer[rowPoisiton, columnPosition - 1] == 0 && boardPlayer[rowPoisiton, columnPosition - 2] == 0
                                && boardPlayer[rowPoisiton, columnPosition - 3] == 0)
                            {
                                boardPlayer[rowPoisiton, columnPosition - 3] = 15;
                                graphicView.putBattleGraphic(row, column - 3, putBoardPeriod, "E");
                            }

                            //Check Right
                            if (columnPosition < 7 && boardPlayer[rowPoisiton, columnPosition + 1] == 0 && boardPlayer[rowPoisiton, columnPosition + 2] == 0
                                && boardPlayer[rowPoisiton, columnPosition + 3] == 0)
                            {
                                boardPlayer[rowPoisiton, columnPosition + 3] = 15;
                                graphicView.putBattleGraphic(row, column +3, putBoardPeriod, "E");
                            }
                            
                            putBoardPeriod++;
                        }
                        else {
                            txtBox.Text += "You can't put the battle here because there already has a battle in this position\r\n";
                        }

                    }
                    break;
                case 5:
                    {//Set the end position of cruiser
                        rowPoisiton = row;
                        columnPosition = column;
                        boardPlayer = board.getBoardPlayer();
                        int rowDif = rowPoisiton - startRowPosition;
                        int columnDif = columnPosition - startColoumnPosition;

                        if (boardPlayer[rowPoisiton, columnPosition] == 15)
                        {
                            boardPlayer[rowPoisiton, columnPosition] = 4;
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    if (boardPlayer[i, j] == 15)
                                    {
                                        graphicView.putBattleGraphic(i, j, putBoardPeriod, "");
                                        boardPlayer[i, j] = 0;
                                    }
                                    else if (boardPlayer[i, j] == 4)
                                    {
                                        graphicView.putBattleGraphic(i, j, putBoardPeriod, "B");
                                    }
                                }
                            }

                            //Put the body of the Battle
                            if (rowDif > 0 && columnDif == 0)
                            {
                                boardPlayer[rowPoisiton - 1, columnPosition] = 4;
                                graphicView.putBattleGraphic(row-1, column, putBoardPeriod, "B");
                                boardPlayer[rowPoisiton - 2, columnPosition] = 4;
                                graphicView.putBattleGraphic(row - 2, column, putBoardPeriod, "B");
                            }
                            else if (rowDif < 0 && columnDif == 0)
                            {
                                boardPlayer[rowPoisiton + 1, columnPosition] = 4;
                                graphicView.putBattleGraphic(row + 1, column, putBoardPeriod, "B");
                                boardPlayer[rowPoisiton + 2, columnPosition] = 4;
                                graphicView.putBattleGraphic(row +2, column, putBoardPeriod, "B");
                            }
                            else if (rowDif == 0 && columnDif > 0)
                            {
                                boardPlayer[rowPoisiton, columnPosition - 1] = 4;
                                graphicView.putBattleGraphic(row, column-1, putBoardPeriod, "B");
                                boardPlayer[rowPoisiton, columnPosition - 2] = 4;
                                graphicView.putBattleGraphic(row, column - 2, putBoardPeriod, "B");
                            }
                            else if (rowDif == 0 && columnDif < 0)
                            {
                                boardPlayer[rowPoisiton, columnPosition + 1] = 4;
                                graphicView.putBattleGraphic(row, column+1, putBoardPeriod, "B");
                                boardPlayer[rowPoisiton, columnPosition + 2] = 4;
                                graphicView.putBattleGraphic(row, column+2, putBoardPeriod, "B");
                            }
                            pLabel3.Text = "Ready";
                            textView.putMessage(columnPosition, rowPoisiton, putBoardPeriod);
                            finished = true;
                            
                        }
                        else {
                            txtBox.Text += "You can't put the end position here, please select one cell which has \"E\"\r\n";
                        }
                    }
                    break;
                    
                default:
                    {

                    }
                    break;
            }
            refreshFilterView();
            return finished;
        }

        //Set the AI battles positions
        public void setAIBoard(int viewDefinder)
        {
            //Set AI Random Battle Position
            Random random = new Random();
            int row = random.Next(0, 9);
            int[,] boardAI;
            boardAI = board.getBoardAI();

            //Set the AI submarine position
            boardAI[row, 3] = 8;
            boardAI[row + 1, 3] = 8;

            //Set the AI destoryer position
            row = random.Next(0, 8);
            boardAI[row, 5] = 9;
            boardAI[row + 1, 5] = 9;
            boardAI[row + 2, 5] = 9;

            //set the AI cruisher position
            row = random.Next(0, 7);
            boardAI[row, 7] = 10;
            boardAI[row + 1, 7] = 10;
            boardAI[row + 2, 7] = 10;
            boardAI[row + 3, 7] = 10;
            if (viewDefinder == 0)
            {
                graphicView.aIBoardSet(viewDefinder);
            }
            else {
                textView.aIBoardSet(viewDefinder);
            }
        }

        //Hit functions, define the hit available and decide the situation after each hit made
        public int hitFunction(System.Windows.Forms.DataGridView dgvPlayer, System.Windows.Forms.DataGridView dgvAI,
                                                                             System.Windows.Forms.Label lblPlayerSubmarine,
                                                                             System.Windows.Forms.Label lblPlayerDestoryer,
                                                                             System.Windows.Forms.Label lblPlayerCruisher,
                                                                             System.Windows.Forms.Label lblAISubmarine,
                                                                             System.Windows.Forms.Label lblAIDestoryer,
                                                                             System.Windows.Forms.Label lblAICruisher)
        {
            int gameSituation = 0;
            /*
            0: Game Continue
            1: Player Win
            2: AI Win
            **/

            int[,] boardPlayer;
            int[,] boardAI;
            boardPlayer = board.getBoardPlayer();
            boardAI = board.getBoardAI();

            Boolean validHit = false;
            rowPoisiton = dgvAI.CurrentCell.RowIndex;
            columnPosition = dgvAI.CurrentCell.ColumnIndex;
            int positionValue = boardAI[rowPoisiton, columnPosition];

            //Decide whether the position has been hit before
            if (positionValue == 0 || positionValue == 8 || positionValue == 9 || positionValue == 10)
            {
                validHit = true;
                //Decide the hit on free sea or battles
                switch (positionValue)
                {
                    case 0:
                        {
                            boardAI[rowPoisiton, columnPosition] = 1;
                            dgvAI[columnPosition, rowPoisiton].Style.BackColor = Color.Red;
                        }
                        break;
                    case 8:
                        {
                            boardAI[rowPoisiton, columnPosition] = 11;
                            dgvAI[columnPosition, rowPoisiton].Style.BackColor = Color.Red;
                            dgvAI[columnPosition, rowPoisiton].Value = "B";
                            checkBattleState(8, lblAISubmarine, boardAI);
                        }
                        break;
                    case 9:
                        {
                            boardAI[rowPoisiton, columnPosition] = 12;
                            dgvAI[columnPosition, rowPoisiton].Style.BackColor = Color.Red;
                            dgvAI[columnPosition, rowPoisiton].Value = "B";
                            checkBattleState(9, lblAIDestoryer, boardAI);
                        }
                        break;
                    case 10:
                        {
                            boardAI[rowPoisiton, columnPosition] = 13;
                            dgvAI[columnPosition, rowPoisiton].Style.BackColor = Color.Red;
                            dgvAI[columnPosition, rowPoisiton].Value = "B";
                            checkBattleState(10, lblAICruisher, boardAI);
                        }
                        break;
                }
                string columnName = columnList[rowPoisiton];
                string rowName = rowList[columnPosition];
                textView.textBoxAddMessage("Position select at " + rowName + "-" + columnName + ", Fire! \r\n");
                dgvAI.ClearSelection();
                textView.removeLastLineInTextView();
                refreshBoatInformationLabel();
            }
            else {
                MessageBox.Show("This position has already been hit", "Warning");
                textView.textBoxAddMessage("Warning - This position has already been hit\r\n");
            }

            //AI action after valid player hit
            if (validHit)
            {
                //Check whether the game is finished
                gameSituation = checkGameWin();
                //If the game is continued, then AI random hit
                if (gameSituation == 0)
                {
                    validHit = false;
                    int hitPositionValue = 0;
                    int rowHitPosition = 0;
                    int columnHitPosition = 0;
                    //Hit the available position
                    while (!validHit)
                    {
                        Random random = new Random();
                        rowHitPosition = random.Next(0, 10);
                        columnHitPosition = random.Next(0, 10);
                        hitPositionValue = boardPlayer[rowHitPosition, columnHitPosition];

                        if (hitPositionValue == 0 || hitPositionValue == 2 || hitPositionValue == 3 || hitPositionValue == 4)
                        {
                            validHit = true;
                        }
                    }

                    //Decide the hit on free sea or battles
                    switch (hitPositionValue)
                    {
                        case 0:
                            {
                                boardPlayer[rowHitPosition, columnHitPosition] = 1;
                                dgvPlayer[columnHitPosition, rowHitPosition].Style.BackColor = Color.Red;
                            }
                            break;
                        case 2:
                            {
                                boardPlayer[rowHitPosition, columnHitPosition] = 5;
                                dgvPlayer[columnHitPosition, rowHitPosition].Style.BackColor = Color.Red;
                                checkBattleState(2, lblPlayerSubmarine, boardPlayer);
                            }
                            break;
                        case 3:
                            {
                                boardPlayer[rowHitPosition, columnHitPosition] = 6;
                                dgvPlayer[columnHitPosition, rowHitPosition].Style.BackColor = Color.Red;
                                checkBattleState(3, lblPlayerDestoryer, boardPlayer);
                            }
                            break;
                        case 4:
                            {
                                boardPlayer[rowHitPosition, columnHitPosition] = 7;
                                dgvPlayer[columnHitPosition, rowHitPosition].Style.BackColor = Color.Red;
                                checkBattleState(4, lblPlayerCruisher, boardPlayer);
                            }
                            break;
                    }
                    string columnName = columnList[rowHitPosition];
                    string rowName = rowList[columnHitPosition];
                    textView.textBoxAddMessage("Computer shoot at position " + rowName + "-" + columnName + "\r\n");
                    refreshBoatInformationLabel();
                }

                //Check whether the game is finished
                gameSituation = checkGameWin();
            }
            filterView.refreshView(board.getBoardPlayer(), board.getBoardAI());
            return gameSituation;
        }

        //Refresh Boat information labels after hit
        public void refreshBoatInformationLabel() {
            int[,] boardPlayer;
            int[,] boardAI;
            boardPlayer = board.getBoardPlayer();
            boardAI = board.getBoardAI();
            int[] boardSurvialStates = { 0, 0, 0, 0, 0, 0 };
            int[] count = { 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (boardPlayer[i, j] == 2)
                    {
                        count[0] = 1;
                    }
                    else if (boardPlayer[i, j] == 3) {
                        count[1] = 1;
                    }
                    else if (boardPlayer[i, j] == 4)
                    {
                        count[2] = 1;
                    }
                    if (boardAI[i, j] == 8)
                    {
                        count[3] = 1;
                    }
                    else if (boardAI[i, j] == 9)
                    {
                        count[4] = 1;
                    }
                    else if (boardAI[i, j] == 10)
                    {
                        count[5] = 1;
                    }
                }
            }

            for (int i = 0; i < 6; i++) {
                if (count[i] == 1) {
                    boardSurvialStates[i] = 1;
                }
            }

            textView.refreshBoardSurvialState(boardSurvialStates);
            graphicView.refreshBoardSurvialState(boardSurvialStates);
        }

        //Hit functions, define the hit available and decide the situation after each hit made, processing hit function by text view
        public int hitFunctionByTextView(int column, int row)
        {
            int gameSituation = 0;
            /*
            0: Game Continue
            1: Player Win
            2: AI Win
            **/

            int[,] boardPlayer;
            int[,] boardAI;
            boardPlayer = board.getBoardPlayer();
            boardAI = board.getBoardAI();

            Boolean validHit = false;
            rowPoisiton = row;
            columnPosition = column;
            int positionValue = boardAI[rowPoisiton, columnPosition];

            //Decide whether the position has been hit before
            if (positionValue == 0 || positionValue == 8 || positionValue == 9 || positionValue == 10)
            {
                validHit = true;
                //Decide the hit on free sea or battles
                switch (positionValue)
                {
                    case 0:
                        {
                            boardAI[rowPoisiton, columnPosition] = 1;
                            //dgvAI[columnPosition, rowPoisiton].Style.BackColor = Color.Red;
                            graphicView.hitAIBoard(rowPoisiton, columnPosition, "");
                        }
                        break;
                        
                    case 8:
                        {
                            boardAI[rowPoisiton, columnPosition] = 11;
                            graphicView.hitAIBoard(rowPoisiton, columnPosition, "B");
                        }
                        break;
                    case 9:
                        {
                            boardAI[rowPoisiton, columnPosition] = 12;
                            graphicView.hitAIBoard(rowPoisiton, columnPosition, "B");
                        }
                        break;
                    case 10:
                        {
                            boardAI[rowPoisiton, columnPosition] = 13;
                            graphicView.hitAIBoard(rowPoisiton, columnPosition, "B");
                        }
                        break;
                        
                }
                string columnName = columnList[rowPoisiton];
                string rowName = rowList[columnPosition];
                textView.textBoxAddMessage("Position select at " + rowName + "-" + columnName + ", Fire! \r\n");
                refreshBoatInformationLabel();
            }
            else {
                MessageBox.Show("This position has already been hit", "Warning");
                textView.textBoxAddMessage("Warning - This position has already been hit\r\n");
            }

            
            //AI action after valid player hit
            if (validHit)
            {
                //Check whether the game is finished
                gameSituation = checkGameWin();
                //If the game is continued, then AI random hit
                if (gameSituation == 0)
                {
                    validHit = false;
                    int hitPositionValue = 0;
                    int rowHitPosition = 0;
                    int columnHitPosition = 0;
                    //Hit the available position
                    while (!validHit)
                    {
                        Random random = new Random();
                        rowHitPosition = random.Next(0, 10);
                        columnHitPosition = random.Next(0, 10);
                        hitPositionValue = boardPlayer[rowHitPosition, columnHitPosition];

                        if (hitPositionValue == 0 || hitPositionValue == 2 || hitPositionValue == 3 || hitPositionValue == 4)
                        {
                            validHit = true;
                        }
                    }

                    //Decide the hit on free sea or battles
                    switch (hitPositionValue)
                    {
                        case 0:
                            {
                                boardPlayer[rowHitPosition, columnHitPosition] = 1;
                                graphicView.hitPlayerBoard(rowHitPosition, columnHitPosition);
                            }
                            break;
                        case 2:
                            {
                                boardPlayer[rowHitPosition, columnHitPosition] = 5;
                                graphicView.hitPlayerBoard(rowHitPosition, columnHitPosition);
                            }
                            break;
                        case 3:
                            {
                                boardPlayer[rowHitPosition, columnHitPosition] = 6;
                                graphicView.hitPlayerBoard(rowHitPosition, columnHitPosition);
                            }
                            break;
                        case 4:
                            {
                                boardPlayer[rowHitPosition, columnHitPosition] = 7;
                                graphicView.hitPlayerBoard(rowHitPosition, columnHitPosition);
                            }
                            break;
                    }
                    string columnName = columnList[rowHitPosition];
                    string rowName = rowList[columnHitPosition];
                    textView.textBoxAddMessage("Computer shoot at position " + rowName + "-" + columnName + "\r\n");
                    refreshBoatInformationLabel();
                }

                //Check whether the game is finished
                gameSituation = checkGameWin();
            }
            
            filterView.refreshView(board.getBoardPlayer(), board.getBoardAI());
            return gameSituation;
        }

        //Check the battle whether is sank
        public void checkBattleState(int battleIndex, System.Windows.Forms.Label label, int[,] boardSelected)
        {

            Boolean battleSank = true;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (boardSelected[i, j] == battleIndex)
                    {
                        battleSank = false;
                    }
                }
            }
            if (battleSank)
            {
                label.Text = "Sank";
            }
            else {
                label.Text = "Survival";
            }
        }

        //Check whether player or AI win the game
        public int checkGameWin()
        {
            Boolean playerWin = true;
            Boolean aiWin = true;
            int situation = 0;

            int[,] boardPlayer;
            int[,] boardAI;
            boardPlayer = board.getBoardPlayer();
            boardAI = board.getBoardAI();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (boardPlayer[i, j] == 2 || boardPlayer[i, j] == 3 || boardPlayer[i, j] == 4)
                    {
                        aiWin = false;
                    }
                    if (boardAI[i, j] == 8 || boardAI[i, j] == 9 || boardAI[i, j] == 10)
                    {
                        playerWin = false;
                    }
                }
            }

            if (aiWin)
            {
                situation = 2;
            }
            else if (playerWin)
            {
                situation = 1;
            }
            return situation;
        }

        //Load Game
        public Boolean loadGame(System.Windows.Forms.DataGridView dgvPlayer, System.Windows.Forms.DataGridView dgvAI,
                                                                             System.Windows.Forms.Label lblPlayerSubmarine,
                                                                             System.Windows.Forms.Label lblPlayerDestoryer,
                                                                             System.Windows.Forms.Label lblPlayerCruisher,
                                                                             System.Windows.Forms.Label lblAISubmarine,
                                                                             System.Windows.Forms.Label lblAIDestoryer,
                                                                             System.Windows.Forms.Label lblAICruisher)
        {
            Boolean fileExist = board.loadGame();
            if (fileExist)
            {
                int[,] boardPlayer;
                int[,] boardAI;
                boardPlayer = board.getBoardPlayer();
                boardAI = board.getBoardAI();

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        dgvPlayer[j, i].Value = "";
                        dgvPlayer[j, i].Style.BackColor = Color.Blue;
                        if (boardPlayer[i, j] == 2 || boardPlayer[i, j] == 3 || boardPlayer[i, j] == 4)
                        {
                            dgvPlayer[j, i].Value = "B";
                        }
                        else if (boardPlayer[i, j] == 5 || boardPlayer[i, j] == 6 || boardPlayer[i, j] == 7)
                        {
                            dgvPlayer[j, i].Value = "B";
                            dgvPlayer[j, i].Style.BackColor = Color.Red;
                        }
                        else if (boardPlayer[i, j] == 1)
                        {
                            dgvPlayer[j, i].Style.BackColor = Color.Red;
                        }

                        dgvAI[j, i].Value = "";
                        dgvAI[j, i].Style.BackColor = Color.Blue;
                        if (boardAI[i, j] == 1)
                        {
                            dgvAI[j, i].Style.BackColor = Color.Red;
                        }
                        else if (boardAI[i, j] == 11 || boardAI[i, j] == 12 || boardAI[i, j] == 13)
                        {
                            dgvAI[j, i].Value = "B";
                            dgvAI[j, i].Style.BackColor = Color.Red;
                        }

                    }
                }
                putBoardPeriod = 0;
                checkBattleState(8, lblAISubmarine, boardAI);
                checkBattleState(9, lblAIDestoryer, boardAI);
                checkBattleState(10, lblAICruisher, boardAI);
                checkBattleState(2, lblPlayerSubmarine, boardPlayer);
                checkBattleState(3, lblPlayerDestoryer, boardPlayer);
                checkBattleState(4, lblPlayerCruisher, boardPlayer);
                dgvPlayer.ClearSelection();
                dgvAI.ClearSelection();
                MessageBox.Show("Load Game Successfully", "Success");
                refreshBoatInformationLabel();
                textView.textBoxAddMessage("Load Game Successfully\r\n");
                textView.resetBoardInformationLabel();
                textView.loadGameSuccessBtnReset();
            }
            else {
                textView.textBoxAddMessage("Can't find a save file\r\n");
            }
            filterView.refreshView(board.getBoardPlayer(), board.getBoardAI());
            return fileExist;
        }

        //Load game by text view
        public Boolean loadGamebyText() {
            Boolean fileExist = board.loadGame();
            
            if (fileExist)
            {
                int[,] boardPlayer;
                int[,] boardAI;
                boardPlayer = board.getBoardPlayer();
                boardAI = board.getBoardAI();
                putBoardPeriod = 0;
                MessageBox.Show("Load Game Successfully", "Success");
                
                textView.textBoxAddMessage("Load Game Successfully\r\n");
                graphicView.loadGameSuccessGameBoardReset(boardPlayer, boardAI);
                graphicView.loadGameSuccessBtnReset();
                graphicView.resetBoardInformationLabel();
                textView.resetBoardInformationLabel();
                refreshBoatInformationLabel();

            }
            else {
                textView.textBoxAddMessage("Can't find a save file\r\n");
            }
            filterView.refreshView(board.getBoardPlayer(), board.getBoardAI());
            return fileExist;
        }

        public void startGame(int vDefinder) {
            if (vDefinder == 0)
            {
                graphicView.startGame(vDefinder);
            }
            else {
                textView.startGame(vDefinder);
            }
        }
        
        //Reset game board and datagridview
        public void resetGame(System.Windows.Forms.DataGridView dgvPlayer, System.Windows.Forms.DataGridView dgvAI)
        {

            textView.textBoxAddMessage("Reset the game successful\r\n");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    dgvPlayer[j, i].Value = "";
                    dgvPlayer[j, i].Style.BackColor = Color.Blue;
                    dgvAI[j, i].Value = "";
                    dgvAI[j, i].Style.BackColor = Color.Blue;
                }
            }
            putBoardPeriod = 0;
            board.resetBoards();
            textView.displayReset();
            filterView.refreshView(board.getBoardPlayer(), board.getBoardAI());
        }

        public void resetGameByTextView() {
            putBoardPeriod = 0;
            board.resetBoards();
            graphicView.resetPlayerAndAIBoard();
            graphicView.displayReset();
            filterView.refreshView(board.getBoardPlayer(), board.getBoardAI());
        }

        //Save the game
        public void saveGame()
        {
            board.saveGame();
            textView.textBoxAddMessage("Save Game Successfully\r\n");
        }

        //Refresh the FilterView
        public void refreshFilterView() {
            int[,] boardPlayer;
            int[,] boardAI;
            boardPlayer = board.getBoardPlayer();
            boardAI = board.getBoardAI();
            filterView.refreshView(boardPlayer, boardAI);
        }

        //Display move record in the textbox in TextView
        public void playerSelectionChanged(int rowP, int columnP) {
            string columnName = columnList[columnP];
            string rowName = rowList[rowP];
            textView.textBoxAddMessage("Shoot position move to " + rowName + "-" + columnName + "\r\n");
        }

        //Move the selected cell in AI game bord while the cell player selected changed
        public void aiGameBoardSelectionChange(int rowP, int columnP) {
            graphicView.aiGameBoardSelectionChange(rowP, columnP);
        }

        public void setAIBoardSelection(int row, int column) {
            graphicView.aiGameBoardSelectionChange(row, column);
        }

        //Remove lines in the textbox
        public void removeLineinTextBox() {
            textView.removeLineinTextView(3);
        }

        //Start the new thread to play music
        public void playMusic(int vDefinder) {
            if (vDefinder == 0)
            {
                graphicView.musicStart(vDefinder);
            }
            else {
                textView.musicStart(vDefinder);
            }
            newThread.Start();
            textView.textBoxAddMessage("Music starts playing --- Melody of the Night, Ch5\r\n");
        }

        public void musicSet() {
            sp.SoundLocation = System.Environment.CurrentDirectory + "\\Night5.wav";
            sp.PlayLooping();
        }
    }
}
