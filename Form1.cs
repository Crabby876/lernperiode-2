namespace Schere__Stein_Papier

{
    using System;
    using System.Threading.Tasks;
    public partial class Form1 : Form
    {
        string NutzerEntscheidung;
        string SchereSteinPapier;
        public Form1()
        {
            InitializeComponent();
        }

        private bool MehrPunkte = false;
        private int runde = 0;
        private int winBot = 0;
        private int winPlayer = 0;
        private void MenuAnsicht()
        {
            RESET.Visible = false;
            BMenu.Visible = false;
            B1pt.Visible = true;
            B3pt.Visible = true;
            BStone.Visible = false;
            BScissour.Visible = false;
            BPaper.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            labelVS.Visible = false;
            label3.Text = "";
            label4.Text = "";
            NutzerEntscheidung = "";
            SchereSteinPapier = "";
        }

        private void SpielAnsicht()
        {
            RESET.Visible = false;
            BMenu.Visible = true;
            B1pt.Visible = false;
            B3pt.Visible = false;
            BStone.Visible = true;
            BScissour.Visible = true;
            BPaper.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            labelVS.Visible = false;
            label3.Text = "";
            label4.Text = "";
            NutzerEntscheidung = "";
            SchereSteinPapier = "";
        }
        private void AuswahlGegner()
        {
            Random rzahl = new Random();
            int Entscheidung = rzahl.Next(1, 4);

            switch (Entscheidung)
            {
                case 1:
                    SchereSteinPapier = "Schere";
                    label1.Text = "✂️";
                    break;
                case 2:
                    SchereSteinPapier = "Stein";
                    label1.Text = "🗿";
                    break;
                case 3:
                    SchereSteinPapier = "Papier";
                    label1.Text = "📃";
                    break;
            }
        }

        private void BScissour_Click(object sender, EventArgs e)
        {
            NutzerEntscheidung = "Schere";
            label2.Text = "✂️";
            AuswahlGegner();
            BStone.Visible = false;
            BScissour.Visible = false;
            BPaper.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            labelVS.Visible = true;

            if (MehrPunkte)
            {
                switch (SchereSteinPapier)
                {
                    case "Schere":
                        label3.Text = "  DRAW";
                        label3.ForeColor = Color.Blue;
                        label4.Text = "  DRAW";
                        label4.ForeColor = Color.Blue;

                        break;
                    case "Stein":
                        label3.Text = "WINNER";
                        label3.ForeColor = Color.Green;
                        label4.Text = "  LOSER";
                        label4.ForeColor = Color.Red;
                        winBot = winBot + 1;
                        break;
                    case "Papier":
                        label3.Text = "  LOSER";
                        label3.ForeColor = Color.Red;
                        label4.Text = "WINNER";
                        label4.ForeColor = Color.Green;
                        winPlayer = winPlayer + 1;
                        break;
                }
                Task.Delay(2000).Wait();
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = true;
                Task.Delay(2000).Wait();
                if (winBot + winPlayer == 3)
                {
                    label3.Visible = false;
                    label4.Visible = false;
                    label1.Text = "PL.1";
                    label2.Text = "PL.2";
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                    Task.Delay(2000).Wait();
                    if (winBot < winPlayer)
                    {
                        label3.Text = "WINNER";
                        label4.Text = "  LOSER";
                    }
                    else if (winBot > winPlayer)
                    {
                        label3.Text = "  LOSER";
                        label4.Text = "WINNER";
                    }

                    label1.Visible = false;
                    label2.Visible = false;
                    labelVS.Visible = false;
                    Task.Delay(2000).Wait();
                    label3.Visible = true;
                    label4.Visible = true;
                }
                else
                {
                    SpielAnsicht();
                }
            }
            else
            {
                switch (SchereSteinPapier)
                {
                    case "Schere":
                        label3.Text = "  DRAW";
                        label3.ForeColor = Color.Blue;
                        label4.Text = "  DRAW";
                        label4.ForeColor = Color.Blue;
                        break;
                    case "Stein":
                        label3.Text = "WINNER";
                        label3.ForeColor = Color.Green;
                        label4.Text = "  LOSER";
                        label4.ForeColor = Color.Red;
                        break;
                    case "Papier":
                        label3.Text = "  LOSER";
                        label3.ForeColor = Color.Red;
                        label4.Text = "WINNER";
                        label4.ForeColor = Color.Green;
                        break;
                }
                Task.Delay(2000).Wait();
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = true;
            }

        }

        private void BPaper_Click(object sender, EventArgs e)
        {
            NutzerEntscheidung = "Papier";
            label2.Text = "📃";
            AuswahlGegner();
            BStone.Visible = false;
            BScissour.Visible = false;
            BPaper.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            labelVS.Visible = true;

            if (MehrPunkte)
            {
                switch (SchereSteinPapier)
                {
                    case "Schere":
                        label3.Text = "WINNER";
                        label3.ForeColor = Color.Green;
                        label4.Text = "  LOSER";
                        label4.ForeColor = Color.Red;
                        winBot++;
                        break;
                    case "Stein":
                        label3.Text = "  LOSER";
                        label3.ForeColor = Color.Red;
                        label4.Text = "WINNER";
                        label4.ForeColor = Color.Green;
                        winPlayer++;
                        break;
                    case "Papier":
                        label3.Text = "  DRAW";
                        label3.ForeColor = Color.Blue;
                        label4.Text = "  DRAW";
                        label4.ForeColor = Color.Blue;
                        break;
                }
                Task.Delay(2000).Wait();
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = true;
                Task.Delay(2000).Wait();
                if (winBot + winPlayer == 3)
                {
                    label3.Visible = false;
                    label4.Visible = false;
                    label1.Text = "PL.1";
                    label2.Text = "PL.2";
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    Task.Delay(2000).Wait();
                    if (winBot < winPlayer)
                    {
                        label3.Text = "WINNER";
                        label4.Text = "  LOSER";
                    }
                    else if (winBot > winPlayer)
                    {
                        label3.Text = "  LOSER";
                        label4.Text = "WINNER";
                    }

                    label1.Visible = false;
                    label2.Visible = false;
                    labelVS.Visible = false;
                    Task.Delay(2000).Wait();
                    label3.Visible = true;
                    label4.Visible = true;
                }
                else
                {
                    SpielAnsicht();
                }
            }
            else
            {
                switch (SchereSteinPapier)
                {
                    case "Schere":
                        label3.Text = "WINNER";
                        label3.ForeColor = Color.Green;
                        label4.Text = "  LOSER";
                        label4.ForeColor = Color.Red;
                        break;
                    case "Stein":
                        label3.Text = "  LOSER";
                        label3.ForeColor = Color.Red;
                        label4.Text = "WINNER";
                        label4.ForeColor = Color.Green;
                        break;
                    case "Papier":
                        label3.Text = "  DRAW";
                        label3.ForeColor = Color.Blue;
                        label4.Text = "  DRAW";
                        label4.ForeColor = Color.Blue;
                        break;
                }
                Task.Delay(2000).Wait();
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = true;
            }


        }

        private void BStone_Click(object sender, EventArgs e)
        {
            NutzerEntscheidung = "Stein";
            label2.Text = "🗿";
            AuswahlGegner();
            BStone.Visible = false;
            BScissour.Visible = false;
            BPaper.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            labelVS.Visible = true;

            if (MehrPunkte)
            {

                switch (SchereSteinPapier)
                {
                    case "Schere":
                        label4.Text = "WINNER";
                        label4.ForeColor = Color.Green;
                        label3.Text = "  LOSER";
                        label3.ForeColor = Color.Red;
                        winPlayer++;
                        break;
                    case "Stein":
                        label3.Text = "  DRAW";
                        label3.ForeColor = Color.Blue;
                        label4.Text = "  DRAW";
                        label4.ForeColor = Color.Blue;
                        break;
                    case "Papier":
                        label3.Text = "WINNER";
                        label3.ForeColor = Color.Green;
                        label4.Text = "  LOSER";
                        label4.ForeColor = Color.Red;
                        winBot++;
                        break;
                }
                Task.Delay(2000).Wait();
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = true;
                Task.Delay(2000).Wait();
                if (winBot + winPlayer == 3)
                {
                    label3.Visible = false;
                    label4.Visible = false;
                    label1.Text = "PL.1";
                    label2.Text = "PL.2";
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    Task.Delay(2000).Wait();
                    if (winBot < winPlayer)
                    {
                        label3.Text = "WINNER";
                        label4.Text = "  LOSER";
                    }
                    else if (winBot > winPlayer)
                    {
                        label3.Text = "  LOSER";
                        label4.Text = "WINNER";
                    }

                    label1.Visible = false;
                    label2.Visible = false;
                    labelVS.Visible = false;
                    Task.Delay(2000).Wait();
                    label3.Visible = true;
                    label4.Visible = true;

                }
                else
                {
                    SpielAnsicht();
                }
            }
            else
            {

                switch (SchereSteinPapier)
                {
                    case "Schere":
                        label4.Text = "WINNER";
                        label4.ForeColor = Color.Green;
                        label3.Text = "  LOSER";
                        label3.ForeColor = Color.Red;
                        break;
                    case "Stein":
                        label3.Text = "  DRAW";
                        label3.ForeColor = Color.Blue;
                        label4.Text = "  DRAW";
                        label4.ForeColor = Color.Blue;
                        break;
                    case "Papier":
                        label3.Text = "WINNER";
                        label3.ForeColor = Color.Green;
                        label4.Text = "  LOSER";
                        label4.ForeColor = Color.Red;
                        break;
                }
                Task.Delay(2000).Wait();
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = true;
            }

        }

        private void RESET_Click(object sender, EventArgs e)
        {
            SpielAnsicht();
        }

        private void B3pt_Click(object sender, EventArgs e)
        {
            SpielAnsicht();
            MehrPunkte = true;

        }

        private void B1pt_Click(object sender, EventArgs e)
        {
            SpielAnsicht();
            MehrPunkte = false;
            RESET.Visible = true;

        }

        private void BMenu_Click(object sender, EventArgs e)
        {
            MenuAnsicht();
        }
    }
}