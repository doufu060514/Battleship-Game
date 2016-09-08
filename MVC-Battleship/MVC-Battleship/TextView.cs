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
    public partial class TextView : Form
    {
        BSContoller bsController;
        int viewDefinder = 0;
        string[] rowList = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};
        string[] columnList = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

        public TextView(BSContoller bs)
        {
            InitializeComponent();
            bsController = bs;
            btnSaveGame.Enabled = false;
            for (int i = 0; i < 10; i++) {
                cmbRow.Items.Insert(i, rowList[i]);
                cmbColumn.Items.Insert(i, columnList[i]);
            }
            cmbRow.SelectedIndex = 0;
            cmbColumn.SelectedIndex = 0;

        }

        //Close the project while the form closed
        private void TextView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Create new game
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.newGame(viewDefinder);
        }

        public void newGame(int viewDifinder) {
            if (viewDefinder == 0) {
                bsController.newGameBoardSet(0);
            }
            textBox.Text += "New Game Started\r\n";
            displayReset();
            btnNewGame.Enabled = false;
        }

        //Change the label texts and button available after the game reset
        public void displayReset()
        {
            textBox.Text += "Please select the front position of the submarine(Length is 2)\r\n";
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

        //Put the battleship position
        private void btnPut_Click(object sender, EventArgs e)
        {
            Boolean finished = false;
            finished = bsController.putBattleText(cmbRow.SelectedIndex, cmbColumn.SelectedIndex, textBox, lblPlayerSubmarineState, lblPlayerDestoryState, lblPlayerCruiserState);
            if (finished)
            {
                btnPut.Enabled = false;
                aIBoardSet(viewDefinder);
                btnStartGame.Enabled = true;
            }
        }

        //Add put battleship help message in the textbox
        public void putMessage(int row, int column,int period) {
            textBox.Text += "Boat put at position " + rowList[row] + "-" + columnList[column] + " \r\n";
            switch (period) {
                case 0: {
                        textBox.Text += "Please select the end position of the submarine(Length is 2)\r\n";
                    }
                    break;
                case 1:
                    {
                        textBox.Text += "Please select the start position of the destroyer(Length is 3)\r\n";
                    }
                    break;
                case 2:
                    {
                        textBox.Text += "Please select the end position of the destory(Length is 3)\r\n";
                    }
                    break;
                case 3:
                    {
                        textBox.Text += "Please select the start position of the cruiser(Length is 4)\r\n";
                    }
                    break;
                case 4:
                    {
                        textBox.Text += "Please select the end position of the cruiser(Length is 4)\r\n";
                    }
                    break;
                case 5:
                    {
                        textBox.Text += "Please click Start Game Button to start the game.\r\n";
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
            if (viewDefinder == 0)
            {
                bsController.setAIBoard(viewDefinder);
            }
        }

        //Start the game after all the boats have been placed
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            startGame(viewDefinder);
        }

        public void startGame(int vDefinder)
        {
            btnHit.Enabled = true;
            btnStartGame.Enabled = false;
            lblPlayerSubmarineState.Text = "Survival";
            lblPlayerCruiserState.Text = "Survival";
            lblPlayerDestoryState.Text = "Survival";
            lblAISubmarineState.Text = "Survival";
            lblAIDestoryState.Text = "Survival";
            lblAICruiserState.Text = "Survival";
            btnSaveGame.Enabled = true;
            
            if (vDefinder == 0)
            {
                bsController.startGame(viewDefinder);
                MessageBox.Show("Game Start!\n Destory all the enemy's battles", "Start");
            }
        }

        //Add message in the text box
        public void textBoxAddMessage(string str) {
            textBox.Text += str;
        }

        //Hit a position selected
        private void btnHit_Click(object sender, EventArgs e)
        {
            int gameSituation = bsController.hitFunctionByTextView(cmbRow.SelectedIndex, cmbColumn.SelectedIndex);
            removeLineinTextView(4);
            removeLineinTextView(4);
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

        //Set the board information to "Sank" after all the positions of the boat has been hit
        public void refreshBoardSurvialState(int[] boardSurvivalState) {
            for (int i = 0; i < 6; i++) {
                if (boardSurvivalState[i] == 0) {
                    switch (i) {
                        case 0: lblPlayerSubmarineState.Text = "Sank";
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

        //Scroll the textbox to the last line       
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            this.textBox.Select(this.textBox.TextLength, 0);
            textBox.ScrollToCaret();
        }

        //Save the current game
        private void btnSaveGame_Click(object sender, EventArgs e)
        {
            bsController.saveGame();
        }

        //Reset the buttons after load game
        public void loadGameSuccessBtnReset() {
            btnNewGame.Enabled = false;
            btnSaveGame.Enabled = true;
            btnPut.Enabled = false;
            btnStartGame.Enabled = false;
            btnHit.Enabled = true;
        }

        //reset the borad information label
        public void resetBoardInformationLabel()
        {
            lblPlayerSubmarineState.Text = "Survival";
            lblPlayerCruiserState.Text = "Survival";
            lblPlayerDestoryState.Text = "Survival";
            lblAISubmarineState.Text = "Survival";
            lblAIDestoryState.Text = "Survival";
            lblAICruiserState.Text = "Survival";
        }

        //Load game from saving file
        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            btnNewGame.Enabled = false;
            Boolean fileExist = bsController.loadGamebyText();
            if (fileExist) {
                loadGameSuccessBtnReset();
            }
        }

        //Reset the game to a new game
        private void btnResetGame_Click(object sender, EventArgs e)
        {
            btnNewGame.Enabled = false;
            textBoxAddMessage("Reset the game successful\r\n");
            displayReset();
            bsController.resetGameByTextView();
        }

        //Remove last line in the textbox
        public void removeLastLineInTextView() {
            string str = "\n";
            string[] lines = textBox.Text.Split(Convert.ToChar(str));
            textBox.Text = "";
            for (int i = 0; i < lines.Length - 2; i++) {
                textBox.Text += lines[i] + "\n";
            }
        }

        //Remove a speific line in the textbox
        public void removeLineinTextView(int place) {
            string str = "\n";
            string[] lines = textBox.Text.Split(Convert.ToChar(str));
            //textBox.Text = "";
            string nText = "";
            for (int i = 0; i < lines.Length - 1; i++)
            {
                if (i != lines.Length - place) {
                    nText += lines[i] + "\n";
                }
            }
            textBox.Text = nText;
        }

        //Action when the selection of the cmbRow or cmbColumn changed
        private void cmbRow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRow.SelectedIndex+cmbColumn.SelectedIndex != 0 && btnPut.Enabled == false && btnNewGame.Enabled == false) {
                bsController.setAIBoardSelection(cmbRow.SelectedIndex, cmbColumn.SelectedIndex);
            }
        }

        //Play music
        private void btnMusicStart_Click(object sender, EventArgs e)
        {
            musicStart(viewDefinder);
        }

        public void musicStart(int viewDefinder)
        {
            btnMusicStart.Enabled = false;
            if (viewDefinder == 0)
            {
                bsController.playMusic(viewDefinder);
            }
        }
       
    }
}
