namespace MVC_Battleship
{
    partial class TextView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAI = new System.Windows.Forms.Panel();
            this.lblAICruiserState = new System.Windows.Forms.Label();
            this.lblAIDestoryState = new System.Windows.Forms.Label();
            this.lblAISubmarineState = new System.Windows.Forms.Label();
            this.lblAICruiser = new System.Windows.Forms.Label();
            this.lblAIDestoryer = new System.Windows.Forms.Label();
            this.lblAISubmarine = new System.Windows.Forms.Label();
            this.lblAI = new System.Windows.Forms.Label();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.lblPlayerCruiserState = new System.Windows.Forms.Label();
            this.lblPlayerDestoryState = new System.Windows.Forms.Label();
            this.lblPlayerSubmarineState = new System.Windows.Forms.Label();
            this.lblPlayerCruiser = new System.Windows.Forms.Label();
            this.lblPlayerDestoryer = new System.Windows.Forms.Label();
            this.lblPlayerSubmarine = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnSaveGame = new System.Windows.Forms.Button();
            this.btnPut = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRow = new System.Windows.Forms.ComboBox();
            this.cmbColumn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMusicStart = new System.Windows.Forms.Button();
            this.pnlAI.SuspendLayout();
            this.pnlPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAI
            // 
            this.pnlAI.Controls.Add(this.lblAICruiserState);
            this.pnlAI.Controls.Add(this.lblAIDestoryState);
            this.pnlAI.Controls.Add(this.lblAISubmarineState);
            this.pnlAI.Controls.Add(this.lblAICruiser);
            this.pnlAI.Controls.Add(this.lblAIDestoryer);
            this.pnlAI.Controls.Add(this.lblAISubmarine);
            this.pnlAI.Controls.Add(this.lblAI);
            this.pnlAI.Location = new System.Drawing.Point(450, 65);
            this.pnlAI.Name = "pnlAI";
            this.pnlAI.Size = new System.Drawing.Size(330, 116);
            this.pnlAI.TabIndex = 23;
            // 
            // lblAICruiserState
            // 
            this.lblAICruiserState.AutoSize = true;
            this.lblAICruiserState.Location = new System.Drawing.Point(76, 91);
            this.lblAICruiserState.Name = "lblAICruiserState";
            this.lblAICruiserState.Size = new System.Drawing.Size(43, 13);
            this.lblAICruiserState.TabIndex = 6;
            this.lblAICruiserState.Text = "Waiting";
            // 
            // lblAIDestoryState
            // 
            this.lblAIDestoryState.AutoSize = true;
            this.lblAIDestoryState.Location = new System.Drawing.Point(76, 66);
            this.lblAIDestoryState.Name = "lblAIDestoryState";
            this.lblAIDestoryState.Size = new System.Drawing.Size(43, 13);
            this.lblAIDestoryState.TabIndex = 5;
            this.lblAIDestoryState.Text = "Waiting";
            // 
            // lblAISubmarineState
            // 
            this.lblAISubmarineState.AutoSize = true;
            this.lblAISubmarineState.Location = new System.Drawing.Point(76, 38);
            this.lblAISubmarineState.Name = "lblAISubmarineState";
            this.lblAISubmarineState.Size = new System.Drawing.Size(43, 13);
            this.lblAISubmarineState.TabIndex = 4;
            this.lblAISubmarineState.Text = "Waiting";
            // 
            // lblAICruiser
            // 
            this.lblAICruiser.AutoSize = true;
            this.lblAICruiser.Location = new System.Drawing.Point(3, 91);
            this.lblAICruiser.Name = "lblAICruiser";
            this.lblAICruiser.Size = new System.Drawing.Size(48, 13);
            this.lblAICruiser.TabIndex = 3;
            this.lblAICruiser.Text = "Cruiser : ";
            // 
            // lblAIDestoryer
            // 
            this.lblAIDestoryer.AutoSize = true;
            this.lblAIDestoryer.Location = new System.Drawing.Point(3, 66);
            this.lblAIDestoryer.Name = "lblAIDestoryer";
            this.lblAIDestoryer.Size = new System.Drawing.Size(61, 13);
            this.lblAIDestoryer.TabIndex = 2;
            this.lblAIDestoryer.Text = "Destroyer : ";
            // 
            // lblAISubmarine
            // 
            this.lblAISubmarine.AutoSize = true;
            this.lblAISubmarine.Location = new System.Drawing.Point(3, 38);
            this.lblAISubmarine.Name = "lblAISubmarine";
            this.lblAISubmarine.Size = new System.Drawing.Size(66, 13);
            this.lblAISubmarine.TabIndex = 1;
            this.lblAISubmarine.Text = "Submarine : ";
            // 
            // lblAI
            // 
            this.lblAI.AutoSize = true;
            this.lblAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAI.Location = new System.Drawing.Point(3, 9);
            this.lblAI.Name = "lblAI";
            this.lblAI.Size = new System.Drawing.Size(74, 16);
            this.lblAI.TabIndex = 0;
            this.lblAI.Text = "Computer";
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.Controls.Add(this.lblPlayerCruiserState);
            this.pnlPlayer.Controls.Add(this.lblPlayerDestoryState);
            this.pnlPlayer.Controls.Add(this.lblPlayerSubmarineState);
            this.pnlPlayer.Controls.Add(this.lblPlayerCruiser);
            this.pnlPlayer.Controls.Add(this.lblPlayerDestoryer);
            this.pnlPlayer.Controls.Add(this.lblPlayerSubmarine);
            this.pnlPlayer.Controls.Add(this.lblPlayer);
            this.pnlPlayer.Location = new System.Drawing.Point(16, 65);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(330, 116);
            this.pnlPlayer.TabIndex = 22;
            // 
            // lblPlayerCruiserState
            // 
            this.lblPlayerCruiserState.AutoSize = true;
            this.lblPlayerCruiserState.Location = new System.Drawing.Point(76, 91);
            this.lblPlayerCruiserState.Name = "lblPlayerCruiserState";
            this.lblPlayerCruiserState.Size = new System.Drawing.Size(43, 13);
            this.lblPlayerCruiserState.TabIndex = 6;
            this.lblPlayerCruiserState.Text = "Waiting";
            // 
            // lblPlayerDestoryState
            // 
            this.lblPlayerDestoryState.AutoSize = true;
            this.lblPlayerDestoryState.Location = new System.Drawing.Point(76, 66);
            this.lblPlayerDestoryState.Name = "lblPlayerDestoryState";
            this.lblPlayerDestoryState.Size = new System.Drawing.Size(43, 13);
            this.lblPlayerDestoryState.TabIndex = 5;
            this.lblPlayerDestoryState.Text = "Waiting";
            // 
            // lblPlayerSubmarineState
            // 
            this.lblPlayerSubmarineState.AutoSize = true;
            this.lblPlayerSubmarineState.Location = new System.Drawing.Point(76, 38);
            this.lblPlayerSubmarineState.Name = "lblPlayerSubmarineState";
            this.lblPlayerSubmarineState.Size = new System.Drawing.Size(43, 13);
            this.lblPlayerSubmarineState.TabIndex = 4;
            this.lblPlayerSubmarineState.Text = "Waiting";
            // 
            // lblPlayerCruiser
            // 
            this.lblPlayerCruiser.AutoSize = true;
            this.lblPlayerCruiser.Location = new System.Drawing.Point(3, 91);
            this.lblPlayerCruiser.Name = "lblPlayerCruiser";
            this.lblPlayerCruiser.Size = new System.Drawing.Size(48, 13);
            this.lblPlayerCruiser.TabIndex = 3;
            this.lblPlayerCruiser.Text = "Cruiser : ";
            // 
            // lblPlayerDestoryer
            // 
            this.lblPlayerDestoryer.AutoSize = true;
            this.lblPlayerDestoryer.Location = new System.Drawing.Point(3, 66);
            this.lblPlayerDestoryer.Name = "lblPlayerDestoryer";
            this.lblPlayerDestoryer.Size = new System.Drawing.Size(61, 13);
            this.lblPlayerDestoryer.TabIndex = 2;
            this.lblPlayerDestoryer.Text = "Destroyer : ";
            // 
            // lblPlayerSubmarine
            // 
            this.lblPlayerSubmarine.AutoSize = true;
            this.lblPlayerSubmarine.Location = new System.Drawing.Point(3, 38);
            this.lblPlayerSubmarine.Name = "lblPlayerSubmarine";
            this.lblPlayerSubmarine.Size = new System.Drawing.Size(66, 13);
            this.lblPlayerSubmarine.TabIndex = 1;
            this.lblPlayerSubmarine.Text = "Submarine : ";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(3, 9);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(53, 16);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Player";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Enabled = false;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(554, 584);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(94, 32);
            this.btnStartGame.TabIndex = 21;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnResetGame
            // 
            this.btnResetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGame.Location = new System.Drawing.Point(373, 10);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(94, 32);
            this.btnResetGame.TabIndex = 20;
            this.btnResetGame.Text = "Reset Game";
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadGame.Location = new System.Drawing.Point(252, 10);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(94, 32);
            this.btnLoadGame.TabIndex = 19;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(16, 10);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(94, 32);
            this.btnNewGame.TabIndex = 18;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGame.Location = new System.Drawing.Point(134, 10);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(94, 32);
            this.btnSaveGame.TabIndex = 17;
            this.btnSaveGame.Text = "Save Game";
            this.btnSaveGame.UseVisualStyleBackColor = true;
            this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // btnPut
            // 
            this.btnPut.Enabled = false;
            this.btnPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPut.Location = new System.Drawing.Point(420, 584);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(94, 32);
            this.btnPut.TabIndex = 16;
            this.btnPut.Text = "Put";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(13, 544);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 14;
            // 
            // btnHit
            // 
            this.btnHit.Enabled = false;
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(686, 584);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(94, 32);
            this.btnHit.TabIndex = 13;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(16, 187);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(764, 333);
            this.textBox.TabIndex = 24;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Row";
            // 
            // cmbRow
            // 
            this.cmbRow.FormattingEnabled = true;
            this.cmbRow.Location = new System.Drawing.Point(54, 592);
            this.cmbRow.Name = "cmbRow";
            this.cmbRow.Size = new System.Drawing.Size(95, 21);
            this.cmbRow.TabIndex = 26;
            this.cmbRow.SelectedIndexChanged += new System.EventHandler(this.cmbRow_SelectedIndexChanged);
            // 
            // cmbColumn
            // 
            this.cmbColumn.FormattingEnabled = true;
            this.cmbColumn.Location = new System.Drawing.Point(231, 592);
            this.cmbColumn.Name = "cmbColumn";
            this.cmbColumn.Size = new System.Drawing.Size(95, 21);
            this.cmbColumn.TabIndex = 28;
            this.cmbColumn.SelectedIndexChanged += new System.EventHandler(this.cmbRow_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Column";
            // 
            // btnMusicStart
            // 
            this.btnMusicStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicStart.Location = new System.Drawing.Point(686, 10);
            this.btnMusicStart.Name = "btnMusicStart";
            this.btnMusicStart.Size = new System.Drawing.Size(94, 32);
            this.btnMusicStart.TabIndex = 29;
            this.btnMusicStart.Text = "Play Music";
            this.btnMusicStart.UseVisualStyleBackColor = true;
            this.btnMusicStart.Click += new System.EventHandler(this.btnMusicStart_Click);
            // 
            // TextView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 626);
            this.Controls.Add(this.btnMusicStart);
            this.Controls.Add(this.cmbColumn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pnlAI);
            this.Controls.Add(this.pnlPlayer);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnSaveGame);
            this.Controls.Add(this.btnPut);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnHit);
            this.Name = "TextView";
            this.Text = "TextView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TextView_FormClosed);
            this.pnlAI.ResumeLayout(false);
            this.pnlAI.PerformLayout();
            this.pnlPlayer.ResumeLayout(false);
            this.pnlPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAI;
        private System.Windows.Forms.Label lblAICruiserState;
        private System.Windows.Forms.Label lblAIDestoryState;
        private System.Windows.Forms.Label lblAISubmarineState;
        private System.Windows.Forms.Label lblAICruiser;
        private System.Windows.Forms.Label lblAIDestoryer;
        private System.Windows.Forms.Label lblAISubmarine;
        private System.Windows.Forms.Label lblAI;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Label lblPlayerCruiserState;
        private System.Windows.Forms.Label lblPlayerDestoryState;
        private System.Windows.Forms.Label lblPlayerSubmarineState;
        private System.Windows.Forms.Label lblPlayerCruiser;
        private System.Windows.Forms.Label lblPlayerDestoryer;
        private System.Windows.Forms.Label lblPlayerSubmarine;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnSaveGame;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRow;
        private System.Windows.Forms.ComboBox cmbColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMusicStart;
    }
}