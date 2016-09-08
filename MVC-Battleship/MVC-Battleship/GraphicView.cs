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
    public partial class GraphicView : Form
    {
        BSContoller bsController;
        int viewDefinder = 1;
        int first = 0;

        public GraphicView(BSContoller bs)
        {
            InitializeComponent();
            bsController = bs;
            //Format the oringinal board
            bsController.setDatagridView(dgvPlayer);
            bsController.setDatagridView(dgvAI);
            btnSaveGame.Enabled = false;
        }

        //Use number to sequence the row in datagridview
        private void dgvPlayer_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                dgvPlayer.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgvPlayer.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgvPlayer.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        //New Game Button -- New Game
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.newGame(viewDefinder);
        }

        public void newGame(int viewDefinder) {
            bsController.setDatagridView(dgvPlayer);
            bsController.setDatagridView(dgvAI);
            if (viewDefinder == 1) {
                bsController.newGameBoardSet(1);
            }
            displayReset();
            btnNewGame.Enabled = false;
        }

        //Put Button function -- Put start and end position for each battle
        private void btnPut_Click(object sender, EventArgs e)
        {
            Boolean finished = false;
            finished = bsController.putBattle(dgvPlayer, lblMessage, lblPlayerSubmarineState, lblPlayerDestoryState, lblPlayerCruiserState);
            if (finished)
            {
                btnPut.Enabled = false;
                aIBoardSet(viewDefinder);
                btnStartGame.Enabled = true;
            }
        }

        //Put battleship display setting
        public void putBattleGraphic(int row, int column, int period, string str) {
            if (str == "S" || str == "B") {
                dgvPlayer[column, row].Selected = true;
            }
            
            dgvPlayer[column, row].Value = str;
            switch (period)
            {
                case 0:
                    {
                        lblMessage.Text = "Please select the end position of the submarine(Length is 2)\r\n";
                    }
                    break;
                case 1:
                    {
                        lblMessage.Text = "Please select the start position of the destroyer(Length is 3)\r\n";
                    }
                    break;
                case 2:
                    {
                        lblMessage.Text = "Please select the end position of the destory(Length is 3)\r\n";
                    }
                    break;
                case 3:
                    {
                        lblMessage.Text = "Please select the start position of the cruiser(Length is 4)\r\n";
                    }
                    break;
                case 4:
                    {
                        lblMessage.Text = "Please select the end position of the cruiser(Length is 4)\r\n";
                    }
                    break;
                case 5:
                    {
                        lblMessage.Text = "Please click Start Game Button to start the game.\r\n";
                        btnPut.Enabled = false;
                        btnStartGame.Enabled = true;
                    }
                    break;
                default:
                    {
                    }
                    break;
            }
        }

        //Auto set the AI battle position
        public void aIBoardSet(int viewDefinder)
        {
            lblPlayerCruiserState.Text = "Ready";
            lblPlayerDestoryState.Text = "Ready";
            lblPlayerSubmarineState.Text = "Ready";
            lblAICruiserState.Text = "Ready";
            lblAIDestoryState.Text = "Ready";
            lblAISubmarineState.Text = "Ready";
            if (viewDefinder == 1) {
                bsController.setAIBoard(viewDefinder);
            }
            
        }

        //Hit Button function -- Hit the position selected
        private void btnHit_Click(object sender, EventArgs e)
        {
            int gameSituation = bsController.hitFunction(dgvPlayer, dgvAI, lblPlayerSubmarineState, lblPlayerDestoryState, lblPlayerCruiserState, lblAISubmarineState, lblAIDestoryState, lblAICruiserState);
            if (gameSituation == 1)
            {
                MessageBox.Show("Congratuation you win the game!", "Success");
                btnHit.Enabled = false;
            }
            else if (gameSituation == 2)
            {
                MessageBox.Show("Sorry you lose the game", "Fail");
                btnHit.Enabled = false;
            }
        }

        //Display the cell AI hit position
        public void hitAIBoard(int row, int column,string str) {
            dgvAI[column, row].Selected = true;
            dgvAI[column, row].Style.BackColor = Color.Red;
            dgvAI[column, row].Value = str;
            dgvAI[column, row].Selected = false;
        }

        //Show the position AI hit to red
        public void hitPlayerBoard(int row, int column)
        {
            dgvPlayer[column, row].Style.BackColor = Color.Red;
        }

        //Start Game Button -- start the game after all the battles have been set positions
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            startGame(viewDefinder);
        }


        //Set the board information label after start the game
        public void startGame(int vDefinder) {
            btnHit.Enabled = true;
            btnStartGame.Enabled = false;
            lblMessage.Text = "";
            lblPlayerSubmarineState.Text = "Survival";
            lblPlayerCruiserState.Text = "Survival";
            lblPlayerDestoryState.Text = "Survival";
            lblAISubmarineState.Text = "Survival";
            lblAIDestoryState.Text = "Survival";
            lblAICruiserState.Text = "Survival";
            btnSaveGame.Enabled = true;
            
            dgvPlayer.ClearSelection();
            if (vDefinder == 1) {
                bsController.startGame(viewDefinder);
                MessageBox.Show("Game Start!\n Destory all the enemy's battles", "Start");
            }
        }

        //Save Button function -- Save the game
        private void btnSave_Click(object sender, EventArgs e)
        {
            bsController.saveGame();
        }

        //Load Button function -- Load the game
        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            btnNewGame.Enabled = false;
            Boolean fileExist = bsController.loadGame(dgvPlayer, dgvAI, lblPlayerSubmarineState, lblPlayerDestoryState, lblPlayerCruiserState, lblAISubmarineState, lblAIDestoryState, lblAICruiserState);
            if (fileExist)
            {
                lblMessage.Text = "";
                btnSaveGame.Enabled = true;
                btnPut.Enabled = false;
                btnStartGame.Enabled = false;
                btnHit.Enabled = true;
            }
        }

        //Reset the game after success load game
        public void loadGameSuccessGameBoardReset(int[,] boardPlayer, int[,] boardAI) {
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
            dgvPlayer.ClearSelection();
            dgvAI.ClearSelection();
        }

        //Reset the buttons after load game
        public void loadGameSuccessBtnReset()
        {
            btnNewGame.Enabled = false;
            lblMessage.Text = "";
            btnSaveGame.Enabled = true;
            btnPut.Enabled = false;
            btnStartGame.Enabled = false;
            btnHit.Enabled = true;
        }

        //Reset Game Button -- Reset the game
        private void btnResetGame_Click(object sender, EventArgs e)
        {
            btnNewGame.Enabled = false;
            bsController.resetGame(dgvPlayer, dgvAI);
            displayReset();

        }

        //Clear the board after reset the game
        public void resetPlayerAndAIBoard() {
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
        }

        //Change the label texts and button available after the game reset
        public void displayReset()
        {
            lblMessage.Text = "Please select the front position of the submarine(Length is 2)";
            btnPut.Enabled = true;
            btnStartGame.Enabled = false;
            btnHit.Enabled = false;
            btnSaveGame.Enabled = false;
            lblPlayerCruiserState.Text = "Waiting";
            lblPlayerDestoryState.Text = "Waiting";
            lblPlayerSubmarineState.Text = "Waiting";
            lblAICruiserState.Text = "Waiting";
            lblAIDestoryState.Text = "Waiting";
            lblAISubmarineState.Text = "Waiting";
        }

        //Reset the board information to "Survival"
        public void resetBoardInformationLabel() {
            lblPlayerSubmarineState.Text = "Survival";
            lblPlayerCruiserState.Text = "Survival";
            lblPlayerDestoryState.Text = "Survival";
            lblAISubmarineState.Text = "Survival";
            lblAIDestoryState.Text = "Survival";
            lblAICruiserState.Text = "Survival";
        }

        //When the AI data grid view selection changed
        private void dgvAI_SelectionChanged(object sender, EventArgs e)
        {
            if (!btnPut.Enabled && (dgvAI.CurrentCell.ColumnIndex + dgvAI.CurrentCell.RowIndex != 0)) {
                bsController.playerSelectionChanged(dgvAI.CurrentCell.ColumnIndex,dgvAI.CurrentCell.RowIndex);
            }
        }

        public void aiGameBoardSelectionChange(int rowP, int columnP)
        {
            if (first == 0)
            {
                dgvAI[rowP, columnP].Selected = true;
                dgvAI[rowP, columnP].Selected = true;
            }
            else {
                dgvAI[rowP, columnP].Selected = true;
                dgvAI[rowP, columnP].Selected = true;
                bsController.removeLineinTextBox();
            }
            first++;
        }


        //Set the board information to "Sank" after all the positions of the boat has been hit
        public void refreshBoardSurvialState(int[] boardSurvivalState)
        {
            for (int i = 0; i < 6; i++)
            {
                if (boardSurvivalState[i] == 0)
                {
                    switch (i)
                    {
                        case 0:
                            lblPlayerSubmarineState.Text = "Sank";
                            break;
                        case 1:
                            lblPlayerCruiserState.Text = "Sank";
                            break;
                        case 2:
                            lblPlayerDestoryState.Text = "Sank";
                            break;
                        case 3:
                            lblAISubmarineState.Text = "Sank";
                            break;
                        case 4:
                            lblAIDestoryState.Text = "Sank";
                            break;
                        case 5:
                            lblAICruiserState.Text = "Sank";
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        //Close the project while the form close
        private void GraphicView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Start play the music
        private void btnMusicStart_Click(object sender, EventArgs e)
        {
            musicStart(viewDefinder);
        }

        public void musicStart(int viewDefinder) {
            btnMusicStart.Enabled = false;
            if (viewDefinder == 1)
            {
                bsController.playMusic(viewDefinder);
            }
        }
    }
}
