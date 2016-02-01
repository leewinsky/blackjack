using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

//
// TODO: Add csv/xml file for graphing big winner hands
// TODO: Add ability to increase bet after certain wins, not just # of losses
// TODO: Add fade down bet option, not just reset bet always
// TODO: Add Stop After Win% = Target gains
// TODO: Add double-down, and split hand
// TODO: Add side bets - analyze Lucky Ladies and Spanish 21
// TODO: Add simple form of card counting - increase bet when cc+
//			K-O technique: 10,A=-1, 2-7=+1, 8,9=0


namespace BlackJackApp
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class frmMain : System.Windows.Forms.Form
    {

        private System.Windows.Forms.TextBox txtDecks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtStayAt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIncreaseBet;
        private System.Windows.Forms.TextBox txtDecreaseBet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPlayers;
        private System.Windows.Forms.TextBox txtRoundsPlayed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSeatingPos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStartingBet;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkChangeBet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIncreaseBy;
        private System.Windows.Forms.RadioButton radAmount;
        private System.Windows.Forms.RadioButton radFactor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkDealerTen;
        private System.Windows.Forms.Button btnOdds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk456;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPercentGains;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox chkQuitWhenAhead;

        //GLOBALS
        //
        float lifeTimeCash = 0;
        private System.Windows.Forms.Label lblOddsGames;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox chkDoubleDown;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtMaxBet;
        int lifeTimeNumPlays = 0;
        private Button btnResetLifetime;
        private TextBox txtPlayCount;
        private Label label24;
        private LinkLabel lnkSpecial;
        int cardCountValue = 0;

        public frmMain()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.txtDecks = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaxBet = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.chkDoubleDown = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.chkQuitWhenAhead = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPercentGains = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.chk456 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDealerTen = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.radFactor = new System.Windows.Forms.RadioButton();
            this.radAmount = new System.Windows.Forms.RadioButton();
            this.txtIncreaseBy = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chkChangeBet = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStartingBet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDecreaseBet = new System.Windows.Forms.TextBox();
            this.txtIncreaseBet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStayAt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSeatingPos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPlayers = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRoundsPlayed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOdds = new System.Windows.Forms.Button();
            this.lblOddsGames = new System.Windows.Forms.Label();
            this.btnResetLifetime = new System.Windows.Forms.Button();
            this.txtPlayCount = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.lnkSpecial = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDecks
            // 
            this.txtDecks.Location = new System.Drawing.Point(120, 24);
            this.txtDecks.Name = "txtDecks";
            this.txtDecks.Size = new System.Drawing.Size(72, 20);
            this.txtDecks.TabIndex = 0;
            this.txtDecks.Text = "8";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkSpecial);
            this.groupBox1.Controls.Add(this.txtMaxBet);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.chkDoubleDown);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.chkQuitWhenAhead);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtPercentGains);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.chkSpecial);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.chk456);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkDealerTen);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.radFactor);
            this.groupBox1.Controls.Add(this.radAmount);
            this.groupBox1.Controls.Add(this.txtIncreaseBy);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.chkChangeBet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtStartingBet);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtDecreaseBet);
            this.groupBox1.Controls.Add(this.txtIncreaseBet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtStayAt);
            this.groupBox1.Location = new System.Drawing.Point(312, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 344);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Strategy";
            // 
            // txtMaxBet
            // 
            this.txtMaxBet.Location = new System.Drawing.Point(120, 48);
            this.txtMaxBet.Name = "txtMaxBet";
            this.txtMaxBet.Size = new System.Drawing.Size(80, 20);
            this.txtMaxBet.TabIndex = 33;
            this.txtMaxBet.Text = "2500";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(24, 48);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 16);
            this.label23.TabIndex = 32;
            this.label23.Text = "Max Bet:";
            // 
            // chkDoubleDown
            // 
            this.chkDoubleDown.Location = new System.Drawing.Point(136, 216);
            this.chkDoubleDown.Name = "chkDoubleDown";
            this.chkDoubleDown.Size = new System.Drawing.Size(136, 16);
            this.chkDoubleDown.TabIndex = 31;
            this.chkDoubleDown.Text = "(dlr 4-5-6, plr 10-11)";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(40, 216);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 16);
            this.label22.TabIndex = 30;
            this.label22.Text = "Double-Down:";
            // 
            // chkQuitWhenAhead
            // 
            this.chkQuitWhenAhead.Location = new System.Drawing.Point(120, 296);
            this.chkQuitWhenAhead.Name = "chkQuitWhenAhead";
            this.chkQuitWhenAhead.Size = new System.Drawing.Size(16, 16);
            this.chkQuitWhenAhead.TabIndex = 29;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(24, 296);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 16);
            this.label21.TabIndex = 28;
            this.label21.Text = "Quit When Ahead:";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(168, 320);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 16);
            this.label20.TabIndex = 27;
            this.label20.Text = "% gains.";
            // 
            // txtPercentGains
            // 
            this.txtPercentGains.Location = new System.Drawing.Point(136, 320);
            this.txtPercentGains.Name = "txtPercentGains";
            this.txtPercentGains.Size = new System.Drawing.Size(24, 20);
            this.txtPercentGains.TabIndex = 26;
            this.txtPercentGains.Text = "30";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(40, 320);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 16);
            this.label19.TabIndex = 25;
            this.label19.Text = "Stop After:";
            // 
            // chkSpecial
            // 
            this.chkSpecial.Location = new System.Drawing.Point(120, 96);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(16, 16);
            this.chkSpecial.TabIndex = 24;
            this.chkSpecial.CheckedChanged += new System.EventHandler(this.chkSpecial_CheckedChanged);
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(24, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 16);
            this.label18.TabIndex = 23;
            this.label18.Text = "MattLee Special:";
            // 
            // chk456
            // 
            this.chk456.Location = new System.Drawing.Point(120, 272);
            this.chk456.Name = "chk456";
            this.chk456.Size = new System.Drawing.Size(16, 16);
            this.chk456.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Aggresive 4-5-6:";
            // 
            // chkDealerTen
            // 
            this.chkDealerTen.Location = new System.Drawing.Point(120, 248);
            this.chkDealerTen.Name = "chkDealerTen";
            this.chkDealerTen.Size = new System.Drawing.Size(16, 16);
            this.chkDealerTen.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(24, 248);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 16);
            this.label17.TabIndex = 19;
            this.label17.Text = "Showing 10:";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(232, 192);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 18;
            this.label16.Text = "factor";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(168, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 16);
            this.label15.TabIndex = 17;
            this.label15.Text = "amount";
            // 
            // radFactor
            // 
            this.radFactor.Checked = true;
            this.radFactor.Location = new System.Drawing.Point(280, 192);
            this.radFactor.Name = "radFactor";
            this.radFactor.Size = new System.Drawing.Size(16, 16);
            this.radFactor.TabIndex = 16;
            this.radFactor.TabStop = true;
            this.radFactor.Text = "radioButton2";
            // 
            // radAmount
            // 
            this.radAmount.Location = new System.Drawing.Point(216, 192);
            this.radAmount.Name = "radAmount";
            this.radAmount.Size = new System.Drawing.Size(16, 16);
            this.radAmount.TabIndex = 15;
            this.radAmount.Text = "radioButton1";
            // 
            // txtIncreaseBy
            // 
            this.txtIncreaseBy.Location = new System.Drawing.Point(136, 192);
            this.txtIncreaseBy.Name = "txtIncreaseBy";
            this.txtIncreaseBy.Size = new System.Drawing.Size(24, 20);
            this.txtIncreaseBy.TabIndex = 14;
            this.txtIncreaseBy.Text = "1.5";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(40, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Increase by:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(168, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "straight win(s).";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(168, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "straight loss(es).";
            // 
            // chkChangeBet
            // 
            this.chkChangeBet.Checked = true;
            this.chkChangeBet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChangeBet.Location = new System.Drawing.Point(120, 120);
            this.chkChangeBet.Name = "chkChangeBet";
            this.chkChangeBet.Size = new System.Drawing.Size(16, 16);
            this.chkChangeBet.TabIndex = 10;
            this.chkChangeBet.CheckedChanged += new System.EventHandler(this.chkChangeBet_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(24, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Change Betting:";
            // 
            // txtStartingBet
            // 
            this.txtStartingBet.Location = new System.Drawing.Point(120, 24);
            this.txtStartingBet.Name = "txtStartingBet";
            this.txtStartingBet.Size = new System.Drawing.Size(80, 20);
            this.txtStartingBet.TabIndex = 8;
            this.txtStartingBet.Text = "5";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(24, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Starting Bet:";
            // 
            // txtDecreaseBet
            // 
            this.txtDecreaseBet.Location = new System.Drawing.Point(136, 168);
            this.txtDecreaseBet.Name = "txtDecreaseBet";
            this.txtDecreaseBet.Size = new System.Drawing.Size(24, 20);
            this.txtDecreaseBet.TabIndex = 5;
            this.txtDecreaseBet.Text = "1";
            // 
            // txtIncreaseBet
            // 
            this.txtIncreaseBet.Location = new System.Drawing.Point(136, 144);
            this.txtIncreaseBet.Name = "txtIncreaseBet";
            this.txtIncreaseBet.Size = new System.Drawing.Size(24, 20);
            this.txtIncreaseBet.TabIndex = 4;
            this.txtIncreaseBet.Text = "3";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(40, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Decrease After:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(40, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Increase After:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stay At:";
            // 
            // txtStayAt
            // 
            this.txtStayAt.Location = new System.Drawing.Point(120, 72);
            this.txtStayAt.Name = "txtStayAt";
            this.txtStayAt.Size = new System.Drawing.Size(80, 20);
            this.txtStayAt.TabIndex = 0;
            this.txtStayAt.Text = "14";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSeatingPos);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPlayers);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtRoundsPlayed);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDecks);
            this.groupBox2.Location = new System.Drawing.Point(16, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Setup";
            // 
            // txtSeatingPos
            // 
            this.txtSeatingPos.Location = new System.Drawing.Point(120, 96);
            this.txtSeatingPos.Name = "txtSeatingPos";
            this.txtSeatingPos.Size = new System.Drawing.Size(72, 20);
            this.txtSeatingPos.TabIndex = 9;
            this.txtSeatingPos.Text = "2";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(16, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Seating Pos:";
            // 
            // txtPlayers
            // 
            this.txtPlayers.Location = new System.Drawing.Point(120, 72);
            this.txtPlayers.Name = "txtPlayers";
            this.txtPlayers.Size = new System.Drawing.Size(72, 20);
            this.txtPlayers.TabIndex = 7;
            this.txtPlayers.Text = "5";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Players:";
            // 
            // txtRoundsPlayed
            // 
            this.txtRoundsPlayed.Location = new System.Drawing.Point(120, 48);
            this.txtRoundsPlayed.Name = "txtRoundsPlayed";
            this.txtRoundsPlayed.Size = new System.Drawing.Size(72, 20);
            this.txtRoundsPlayed.TabIndex = 5;
            this.txtRoundsPlayed.Text = "7";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Rounds Played:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Decks:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResults);
            this.groupBox3.Location = new System.Drawing.Point(16, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(608, 64);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // lblResults
            // 
            this.lblResults.Location = new System.Drawing.Point(32, 24);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(552, 32);
            this.lblResults.TabIndex = 0;
            this.lblResults.Text = "Set up the Game and click Play!";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Starting Cash:";
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(120, 8);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(88, 20);
            this.txtCash.TabIndex = 5;
            this.txtCash.Text = "300";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(208, 432);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(160, 24);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Let\'s Play!";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnOdds
            // 
            this.btnOdds.Location = new System.Drawing.Point(16, 432);
            this.btnOdds.Name = "btnOdds";
            this.btnOdds.Size = new System.Drawing.Size(56, 24);
            this.btnOdds.TabIndex = 0;
            this.btnOdds.Text = "Odds";
            this.btnOdds.Click += new System.EventHandler(this.btnOdds_Click);
            // 
            // lblOddsGames
            // 
            this.lblOddsGames.Location = new System.Drawing.Point(80, 440);
            this.lblOddsGames.Name = "lblOddsGames";
            this.lblOddsGames.Size = new System.Drawing.Size(128, 16);
            this.lblOddsGames.TabIndex = 7;
            this.lblOddsGames.Text = "# of decks";
            // 
            // btnResetLifetime
            // 
            this.btnResetLifetime.Location = new System.Drawing.Point(528, 433);
            this.btnResetLifetime.Name = "btnResetLifetime";
            this.btnResetLifetime.Size = new System.Drawing.Size(96, 23);
            this.btnResetLifetime.TabIndex = 8;
            this.btnResetLifetime.Text = "Reset Lifetime $";
            this.btnResetLifetime.UseVisualStyleBackColor = true;
            this.btnResetLifetime.Click += new System.EventHandler(this.btnResetLifetime_Click);
            // 
            // txtPlayCount
            // 
            this.txtPlayCount.Location = new System.Drawing.Point(394, 432);
            this.txtPlayCount.Name = "txtPlayCount";
            this.txtPlayCount.Size = new System.Drawing.Size(30, 20);
            this.txtPlayCount.TabIndex = 9;
            this.txtPlayCount.Text = "1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(429, 435);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 13);
            this.label24.TabIndex = 10;
            this.label24.Text = "play count";
            // 
            // lnkSpecial
            // 
            this.lnkSpecial.AutoSize = true;
            this.lnkSpecial.Location = new System.Drawing.Point(145, 96);
            this.lnkSpecial.Name = "lnkSpecial";
            this.lnkSpecial.Size = new System.Drawing.Size(36, 13);
            this.lnkSpecial.TabIndex = 34;
            this.lnkSpecial.TabStop = true;
            this.lnkSpecial.Text = "what?";
            this.lnkSpecial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSpecial_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(640, 470);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtPlayCount);
            this.Controls.Add(this.btnResetLifetime);
            this.Controls.Add(this.lblOddsGames);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOdds);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "BlackJackApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new frmMain());
        }

        private void btnPlay_Click(object sender, System.EventArgs e)
        {
            string path = Path.Combine(System.Environment.CurrentDirectory, "data.csv");
            System.IO.StreamWriter csvWriter = System.IO.File.CreateText(path);

            float cash = System.Convert.ToInt32(txtCash.Text, 10);
            BJResults results = new BJResults();
            results.minCash = results.maxCash = cash;
            int totalGames = 0;
            int iTotalCount = 1;
            float totalCash = 0;
            Int32.TryParse(txtPlayCount.Text, out iTotalCount);
            for (int playCount = 0; playCount < iTotalCount; playCount++)
            {
                // prepare strategy
                int games = 0;
                cash = System.Convert.ToInt32(txtCash.Text, 10);
                float startingCash = cash;
                int maxGames = System.Convert.ToInt32(txtRoundsPlayed.Text, 10);
                int decks = System.Convert.ToInt32(txtDecks.Text, 10);
                bool quitWhenAhead = chkQuitWhenAhead.Checked;
                double percentGains = System.Convert.ToDouble(txtPercentGains.Text);
                percentGains = (percentGains + 100) / 100;

                // prepare the shoe
                int totalCards = decks * 52;
                Card[] Cards = new Card[totalCards];
                for (int i = 0; i < totalCards; i++)
                    Cards[i] = new Card();

                csvWriter.WriteLine("----New Play----");
                csvWriter.WriteLine("Cash, Bet");

                lifeTimeCash -= cash;
                totalCash -= cash;

                // playCount is your number of days played based on your strategy / exit
                for (games = 0; games < maxGames; games++)
                {
                    Shuffle(ref Cards, decks);//create the cards
                    PlayBigDeck(ref Cards, ref cash, startingCash, ref results, csvWriter);

                    if (cash <= 0)
                        break;
                    if (quitWhenAhead)
                    {
                        if (cash >= startingCash * percentGains)
                            break;
                    }
                }
                csvWriter.WriteLine("{0}, {1}, {2}", cash, 0, lifeTimeCash);
                csvWriter.Flush();

                lifeTimeCash += cash;
                totalCash += cash;
                lifeTimeNumPlays++;

                DisplayResults(cash, games, results);
            }
            DisplayResults(totalCash, totalGames, results);
            csvWriter.Close();
        }

        private void Shuffle(ref Card[] Cards, int Decks)
        {
            cardCountValue = 0;
            int index = 0;
            for (int i = 0; i < Decks; i++)
            {
                NewDeck freshie = new NewDeck();

                for (int j = 0; j < 52; j++)
                {
                    Random rand = new Random();

                    //Find an undealt card and assign it to the BlackJack deck
                    int pos = rand.Next(0, 51);
                    while (freshie.Cards[pos].Dealt)
                    {
                        pos = rand.Next(0, 51);
                        if (j == 51)
                            pos = 51;
                    }
                    Cards[index].Value = freshie.Cards[pos].Value;
                    Cards[index].Suit = freshie.Cards[pos].Suit;
                    Cards[index].Dealt = false;
                    freshie.Cards[pos].Dealt = true;

                    index++;
                }
            }
        }

        private void PlayHand(ref float Cash, ref float bet, float originalBet, bool trend,
                    ref bool stayBet, ref BJResults Results, Card[] Cards, ref int index,
                    int mySeat, int maxPlayers, bool doubled)
        {
            CardHand dealerHand = new CardHand(15);
            CardHand myHand = new CardHand(15);

            Betting(Cash, ref bet, originalBet, trend,
                ref stayBet, Results.movement, Cards, index);

            InitialDeal(ref Cards, ref index, ref myHand, ref dealerHand,
                mySeat, maxPlayers);

            if (ThereIsABlackJack(myHand, dealerHand, ref Cash, bet,
                ref Results, ref trend))
            {
                return;
            }

            //double-down?
            if (chkDoubleDown.Checked)
            {
                if ((dealerHand.Showing == 4 || dealerHand.Showing == 5 ||
                    dealerHand.Showing == 6) && (myHand.Total == 10 ||
                    myHand.Total == 11))
                {
                    if (Cash > bet * 2)
                    {
                        bet = bet * 2;
                        doubled = true;
                    }
                }
            }

            HitStayBust(ref Cards, ref index, ref myHand, ref dealerHand,
                maxPlayers, mySeat, doubled);

            WrapUp(myHand, dealerHand, ref Cash, bet, ref Results);

            if (doubled)
            {
                bet /= 2;
                doubled = false;
            }
        }

        private void PlayBigDeck(ref Card[] Cards, ref float Cash, float startingCash,
            ref BJResults Results, StreamWriter csvWriter)
        {
            float bet = System.Convert.ToInt32(txtStartingBet.Text, 10);
            float originalBet = bet;
            float originalCash = Cash;
            int maxPlayers = System.Convert.ToInt32(txtPlayers.Text, 10);
            int mySeat = System.Convert.ToInt32(txtSeatingPos.Text, 10);
            bool quitWhenAhead = chkQuitWhenAhead.Checked;
            double percentGains = System.Convert.ToDouble(txtPercentGains.Text);
            percentGains = (percentGains + 100) / 100;
            int index = 0;//card index
            bool trend = true;//MattLee Special (21) trend
            bool stayBet = false;//for pushes
            bool doubled = false;//keep track if we doubled-down

            int iMinShoeSize = 52 * 2;
            while (index < Cards.Length - iMinShoeSize && Cash > 0)//leave 2 decks unplayed
            {
                if (quitWhenAhead)
                {
                    if (Cash >= startingCash * percentGains)
                        break;
                }
                //csvWriter.WriteLine("{0}, {1}", Cash, bet);
                csvWriter.WriteLine("{0}, {1}, {2}", Cash, bet, lifeTimeCash);

                PlayHand(ref Cash, ref bet, originalBet, trend, ref stayBet, ref Results, Cards, ref index, mySeat, maxPlayers, doubled);
            }
        }

        private void DisplayResults(float Cash, int GamesPlayed, BJResults Results)
        {
            string result;
            result = String.Format("Cash Results: {0}  ", Cash.ToString("00000.00"));
            result += String.Format("Max Cash: {0}  ", Results.maxCash.ToString("00000.00"));
            result += String.Format("Min Cash: {0}  ", Results.minCash.ToString("00000.00"));
            result += String.Format("Hands Played: {0}  ", Results.HandsPlayed.ToString());
            result += String.Format("Win Pct: {0}  ", Results.WinPct.ToString("P"));
            result += String.Format("\nLifeTime Cash: {0}  ", lifeTimeCash);
            result += String.Format("LifeTime Spins: {0}  ", lifeTimeNumPlays);

            lblResults.Text = result;

            if (Cash > 2500 && Cash < 10000)
            {
                lblResults.ForeColor = Color.Red;
                Update();
                System.Threading.Thread.Sleep(250);
            }
            else if (Cash > 9999)
            {
                lblResults.ForeColor = Color.Orange;
                Update();
                System.Threading.Thread.Sleep(250);
            }
            else
            {
                lblResults.ForeColor = Color.Black;
                Update();
            }
        }

        private void btnOdds_Click(object sender, System.EventArgs e)
        {
            BJResults Results = new BJResults();

            float startingCash = 99999f;
            float bet = 10f;
            int index = 0;
            bool trend = true;
            bool stayBet = false;
            
            
            // prepare the shoe
            int numDecks = 5;
            int totalCards = numDecks * 52;
            Card[] deck = new Card[totalCards];
            for (int i = 0; i < totalCards; i++)
                deck[i] = new Card();

            float totalCash = startingCash;
            for (int i = 0; i < 2000; i++)//many many times
            {
                index = 0;
                float cash = startingCash;
                totalCash -= cash;

                Shuffle(ref deck, numDecks);

                while (index < (numDecks * 52) - 60) //leave a few cards
                {
                    PlayHand(ref cash, ref bet, 10, trend, ref stayBet, ref Results, deck, ref index, 1, 2, false);
                }

                totalCash += cash;
            }

            lblOddsGames.Text = "2000 decks played";

            DisplayOdds(Results, totalCash - startingCash);
        }

        private void Betting(float Cash, ref float Bet, float originalBet,
            bool trend, ref bool stayBet, int movement, Card[] Cards, int deckIndex)
        {
            bool changeBet = System.Convert.ToBoolean(chkChangeBet.Checked);

            if (!changeBet)
                return;

            int increaseA = System.Convert.ToInt32(txtIncreaseBet.Text);
            int decreaseA = System.Convert.ToInt32(txtDecreaseBet.Text);
            double increaseBy = System.Convert.ToDouble(txtIncreaseBy.Text);
            bool factor = radFactor.Checked;
            bool amount = radAmount.Checked;
            bool special = chkSpecial.Checked;
            int maxBet = System.Convert.ToInt32(txtMaxBet.Text);

            if (special)
            {
                if (stayBet == true)
                    Bet = Bet;
                else if (trend == false)
                {
                    if (factor)
                        Bet = Bet * (float)increaseBy;
                    else//amount
                        Bet += (float)increaseBy;
                }
                else if (trend == true)
                    Bet = originalBet;
            }
            else
            {
                if (stayBet == true)
                    Bet = Bet;
                else if (movement <= (-increaseA))
                {
                    if (factor)
                        Bet = Bet * (float)increaseBy;
                    else//amount
                        Bet += (float)increaseBy;
                }
                else if (movement >= decreaseA)
                    Bet = originalBet;
            }

            stayBet = false;

            //Card-Counting betting
            //			int decksLeft = (Cards.Length - deckIndex) / 52;
            //			int trueCount = cardCountValue / decksLeft;
            //			if ( trueCount > 5 )
            //				Bet = originalBet*4;
            //			else if ( trueCount > 3 )
            //				Bet = originalBet*3;
            //			else if ( trueCount > 1 )
            //				Bet = originalBet*2;
            //			else
            //				Bet = originalBet;

            if (Bet > maxBet)
                Bet = maxBet;

            if (Bet > Cash)
                Bet = Cash;//toss it all in!
        }

        private void InitialDeal(ref Card[] Cards, ref int index,
            ref CardHand myHand, ref CardHand dealerHand,
            int mySeat, int maxPlayers)
        {
            for (int i = 0; i < 2; i++)//two cards each
            {
                for (int dealto = 0; dealto < maxPlayers + 1; dealto++)
                {
                    //count cards
                    CountCard(Cards[index].Value);

                    //Deal
                    if (dealto == mySeat)
                    {
                        myHand.Cards[i].Value = Cards[index].Value;
                        myHand.Cards[i].Suit = Cards[index].Suit;
                    }
                    else if (dealto == maxPlayers)//the Dealer
                    {
                        dealerHand.Cards[i].Value = Cards[index].Value;
                        dealerHand.Cards[i].Suit = Cards[index].Suit;
                    }
                    //else {deal this card to some random person}
                    Cards[index].Dealt = true;
                    index++;
                }
            }
        }

        private bool ThereIsABlackJack(CardHand myHand, CardHand dealerHand,
            ref float Cash, float Bet, ref BJResults Results, ref bool trend)
        {
            //Did dealer get 21?
            if (dealerHand.Total == 21)
            {
                Cash -= Bet;
                Results.dealerTwentyones++;
                trend = false;
                if (Cash < Results.minCash)
                    Results.minCash = Cash;
                if (Results.movement > 0)
                    Results.movement = 0;
                else
                    Results.movement--;
                return true;
            }
            //Did we get 21?
            if (myHand.Total == 21)
            {
                Cash += Bet * 1.5f;
                Results.myTwentyones++;
                trend = true;
                if (Cash > Results.maxCash)
                    Results.maxCash = Cash;
                if (Results.movement < 0)
                    Results.movement = 0;
                else
                    Results.movement++;
                return true;
            }

            return false;
        }

        private void HitStayBust(ref Card[] Cards, ref int index,
            ref CardHand myHand, ref CardHand dealerHand, int maxPlayers,
            int mySeat, bool doubled)
        {
            int stayAt = System.Convert.ToInt32(txtStayAt.Text, 10);
            bool dealerTen = System.Convert.ToBoolean(chkDealerTen.Checked);
            bool agg456 = System.Convert.ToBoolean(chk456.Checked);

            for (int dealto = 0; dealto < maxPlayers + 1; dealto++)
            {
                if (dealto == mySeat)
                {
                    if (dealerTen && dealerHand.Showing == 10)
                    {
                        stayAt = 16;
                    }
                    else if (agg456 && (dealerHand.Showing == 4 ||
                        dealerHand.Showing == 5 ||
                        dealerHand.Showing == 6))
                    {
                        stayAt = 12;
                    }
                    else
                    {
                        stayAt = stayAt;//normal
                    }

                    //take some cards (or not)
                    while (myHand.Total < stayAt)
                    {
                        myHand.AddCard(Cards[index]);
                        Cards[index].Dealt = true;
                        CountCard(Cards[index].Value);
                        index++;
                        if (doubled)
                            break;//double-down only gets one card
                    }
                }
                else if (dealto == maxPlayers)//the Dealer
                {
                    while (dealerHand.Total < 17)
                    {
                        dealerHand.AddCard(Cards[index]);
                        Cards[index].Dealt = true;
                        CountCard(Cards[index].Value);
                        index++;
                    }
                }
                else
                {
                    Random rand = new Random();
                    int burn = rand.Next(0, 3);
                    for (int b = 0; b < burn; b++)
                    {
                        Cards[index].Dealt = true;
                        CountCard(Cards[index].Value);
                        index++;
                    }
                }

            }
        }

        private void WrapUp(CardHand myHand, CardHand dealerHand,
            ref float Cash, float Bet, ref BJResults Results)
        {
            //If player or dealer hit 21 on deal, we already took care of things.
            //Did we win?
            if ((myHand.Total > dealerHand.Total && myHand.Total < 22) ||
                (dealerHand.Total > 21 && myHand.Total < 22))
            {
                Cash += Bet;
                Results.wins++;
                if (Results.movement < 0)
                    Results.movement = 0;
                else
                    Results.movement++;
            }
            else if ((myHand.Total > 21) ||
                (myHand.Total < dealerHand.Total))
            {
                Cash -= Bet;
                Results.losses++;
                if (Results.movement > 0)
                    Results.movement = 0;
                else
                    Results.movement--;
            }
            else
            {
                Results.pushes++;
                //stayBet = true;
            }

            if (Cash > Results.maxCash)
                Results.maxCash = Cash;
            if (Cash < Results.minCash)
                Results.minCash = Cash;

        }

        private void DisplayOdds(BJResults Results, float cash)
        {
            string result;
            result = String.Format("Cash out: {0}  ", cash);
            result += String.Format("Win Pct: {0}  ", Results.WinPct);
            result += String.Format("Pushes: {0}  ", Results.pushes);
            result += String.Format("\nmyBJ: {0}   dealerBJ: {1}",
                Results.myTwentyones, Results.dealerTwentyones);

            lblResults.Text = result;
        }

        private void chkChangeBet_CheckedChanged(object sender, System.EventArgs e)
        {
            bool val = chkChangeBet.Checked;

            txtDecreaseBet.Enabled = val;
            txtIncreaseBet.Enabled = val;
            txtIncreaseBy.Enabled = val;

            radAmount.Enabled = val;
            radFactor.Enabled = val;
        }

        private void chkSpecial_CheckedChanged(object sender, System.EventArgs e)
        {
            bool val = chkSpecial.Checked;

            chkChangeBet.Enabled = !val;

            if (val)
            {
                chkChangeBet.Checked = true;
                txtIncreaseBet.Text = "3";
                txtIncreaseBy.Text = "1.5";
                txtDecreaseBet.Text = "1";
                radFactor.Checked = true;
                radAmount.Checked = false;
                chkQuitWhenAhead.Checked = false;
                chk456.Checked = true;
                chkDealerTen.Checked = true;
                this.Update();
            }

            txtDecreaseBet.Enabled = !val;
            txtIncreaseBet.Enabled = !val;
            txtIncreaseBy.Enabled = !val;

            radAmount.Enabled = !val;
            radFactor.Enabled = !val;

            chkQuitWhenAhead.Enabled = !val;
            txtPercentGains.Enabled = !val;
        }

        void CountCard(int val)
        {
            //K-O method
            if (val > 9)
                cardCountValue -= 1;//10s and Aces
            else if (val < 7)//2-6
                cardCountValue += 1;
            //else
            //ignore 7,8,9
        }

        private void btnResetLifetime_Click(object sender, EventArgs e)
        {
            lifeTimeCash = 0;
            lifeTimeNumPlays = 0;
        }

        private void lnkSpecial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string msg = "The 'Special' ignores Change Bet settings and sets 3 for IncreaseAfter \n ";
            msg += "(wins) and 1 for DecreaseAfter (wins) and 1.5 for IncreaseBy (factor), \n";
            msg += "and also bets odds of 21.";
            MessageBox.Show(msg);
        }

    }//class
}//namespace
