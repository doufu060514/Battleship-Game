namespace MVC_Battleship
{
    partial class GraphicView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvAI = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.dgvPlayer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMusicStart = new System.Windows.Forms.Button();
            this.pnlAI.SuspendLayout();
            this.pnlPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).BeginInit();
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
            this.pnlAI.Location = new System.Drawing.Point(444, 64);
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
            this.pnlPlayer.Location = new System.Drawing.Point(10, 64);
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
            this.btnStartGame.Location = new System.Drawing.Point(246, 583);
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
            this.btnResetGame.Location = new System.Drawing.Point(367, 9);
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
            this.btnLoadGame.Location = new System.Drawing.Point(246, 9);
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
            this.btnNewGame.Location = new System.Drawing.Point(10, 9);
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
            this.btnSaveGame.Location = new System.Drawing.Point(128, 9);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(94, 32);
            this.btnSaveGame.TabIndex = 17;
            this.btnSaveGame.Text = "Save Game";
            this.btnSaveGame.UseVisualStyleBackColor = true;
            this.btnSaveGame.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPut
            // 
            this.btnPut.Enabled = false;
            this.btnPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPut.Location = new System.Drawing.Point(10, 583);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(94, 32);
            this.btnPut.TabIndex = 16;
            this.btnPut.Text = "Put";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // dgvAI
            // 
            this.dgvAI.AllowUserToAddRows = false;
            this.dgvAI.AllowUserToDeleteRows = false;
            this.dgvAI.AllowUserToResizeColumns = false;
            this.dgvAI.AllowUserToResizeRows = false;
            this.dgvAI.CausesValidation = false;
            this.dgvAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAI.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAI.Location = new System.Drawing.Point(444, 199);
            this.dgvAI.MultiSelect = false;
            this.dgvAI.Name = "dgvAI";
            this.dgvAI.ReadOnly = true;
            this.dgvAI.RowHeadersWidth = 30;
            this.dgvAI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvAI.Size = new System.Drawing.Size(330, 321);
            this.dgvAI.TabIndex = 15;
            this.dgvAI.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvPlayer_RowPostPaint);
            this.dgvAI.SelectionChanged += new System.EventHandler(this.dgvAI_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "A";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "B";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "C";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "D";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "E";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "F";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "G";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "H";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "I";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "J";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(7, 543);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 14;
            // 
            // btnHit
            // 
            this.btnHit.Enabled = false;
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(680, 583);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(94, 32);
            this.btnHit.TabIndex = 13;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // dgvPlayer
            // 
            this.dgvPlayer.AllowUserToAddRows = false;
            this.dgvPlayer.AllowUserToDeleteRows = false;
            this.dgvPlayer.AllowUserToResizeColumns = false;
            this.dgvPlayer.AllowUserToResizeRows = false;
            this.dgvPlayer.CausesValidation = false;
            this.dgvPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlayer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlayer.Location = new System.Drawing.Point(10, 199);
            this.dgvPlayer.MultiSelect = false;
            this.dgvPlayer.Name = "dgvPlayer";
            this.dgvPlayer.ReadOnly = true;
            this.dgvPlayer.RowHeadersWidth = 30;
            this.dgvPlayer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvPlayer.Size = new System.Drawing.Size(330, 321);
            this.dgvPlayer.TabIndex = 12;
            this.dgvPlayer.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvPlayer_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "A";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "B";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "C";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "D";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "E";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "F";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "G";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "H";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "I";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "J";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // btnMusicStart
            // 
            this.btnMusicStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicStart.Location = new System.Drawing.Point(680, 9);
            this.btnMusicStart.Name = "btnMusicStart";
            this.btnMusicStart.Size = new System.Drawing.Size(94, 32);
            this.btnMusicStart.TabIndex = 24;
            this.btnMusicStart.Text = "Play Music";
            this.btnMusicStart.UseVisualStyleBackColor = true;
            this.btnMusicStart.Click += new System.EventHandler(this.btnMusicStart_Click);
            // 
            // GraphicView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 626);
            this.Controls.Add(this.btnMusicStart);
            this.Controls.Add(this.pnlAI);
            this.Controls.Add(this.pnlPlayer);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnSaveGame);
            this.Controls.Add(this.btnPut);
            this.Controls.Add(this.dgvAI);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.dgvPlayer);
            this.Name = "GraphicView";
            this.Text = "GraphicView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GraphicView_FormClosed);
            this.pnlAI.ResumeLayout(false);
            this.pnlAI.PerformLayout();
            this.pnlPlayer.ResumeLayout(false);
            this.pnlPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.DataGridView dgvPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btnMusicStart;
    }
}