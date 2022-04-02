namespace cookieClicker
{
    public partial class Form1 : Form
    {
        public Random rd = new Random();
        PictureBox pig;
        public long money = 0;
        public int amount = 0;
        public int GetPerClick = 1;
        public int cps = 0;
        public long UpgradeCost = 4;
        public long ChurchCost = 50;
        public int ChurchNumber = 0;
        public long FactoryCost = 500;
        public int FactoryNumber = 0;
        public long ShopCost = 2000;
        public int ShopNumber = 0;
        public double sance = 0.000002;
        public double churchCost = 44;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetText("money", coin);
            SetText("ChurchNumber", churchNumber);
            SetText("BuyChurch", buyChurch);
            SetText("FactoryNumber", factoryNumber);
            SetText("BuyFactory", buyFactory);
            SetText("ShopNumber", shopNumber);
            SetText("BuyShop", buyShop);
            SetText("BuyAll", BuyAll);
            SetText("BuyOne", BuyOne);
            SetText("FactoryBuyAll", FactoryUpgradeAll);
            SetText("ChurchBuyAll", ChurchUpgradeAll);
            SetText("ShopBuyAll", ShopUpgradeAll);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            addMoney();
        }

        public void addMoney()
        {
            money += GetPerClick;
            SetText("money", coin);
            SetText("BuyAll", BuyAll);
            SetText("ChurchBuyAll", ChurchUpgradeAll);
            SetText("FactoryBuyAll", FactoryUpgradeAll);
            SetText("ShopBuyAll", ShopUpgradeAll);

        }

        public void random()
        {
            int x = (int)(100 / sance);
            if(cps > 0)
            {
                x = (int)(100 / (sance * cps));
            }
            if(rd.Next(1, x + 1) == 1)
            {
                spawnPig();
            }
        }
        public void spawnPig()
        {
            pig = new PictureBox();
            pig.BackColor = Color.Transparent;
            pig.BackgroundImage = Properties.Resources.pig;
            pig.BackgroundImageLayout = ImageLayout.Stretch;
            pig.Width = 100;
            pig.Height = 100;
            pig.Click += moneyClick;
           
            pig.Location = new Point(rd.Next(1,this.Width - pig.Width),rd.Next(1,this.Height + pig.Height));

            this.Controls.Add(pig);
        }
        private void moneyClick(object sender, EventArgs e)
        {
            PictureBox pig2 = sender as PictureBox;
            pig2.Dispose();
            money += 250 * (cps * 10 + money);
            SetText("money", coin);
        }

        public string setNumber(long number)
        {
            float x = number;

            if(x >= 1000000 && x < 1000000000)
            {
                return Math.Round((x / 1000000),2).ToString() + "mil";
            }
            if (x >= 1000000000)
            {
                return Math.Round((x / 1000000000), 2).ToString() + "mld";
            }

            return number.ToString();
        }
        public long[] getUpgrade(long number)
        {
            amount = 0;
            //0 = cena upgradu,  1 = celkovy soucet
            long[] All = new long[] { number, number };

            while (money >= All[1])
            {
                amount++;
                All[0] = All[0] + All[0] / 2;
                All[1] += All[0];
                if(All[1] > money)
                {
                    All[1] -= All[0];
                    return All;
                }
 
            }
            return All;

        }
        public string SetText(string text, Label label)
        {
            
            if (text == "money")
            {
                return label.Text = setNumber(money) + " GigaCoinù";
            }
            else if (text == "ChurchNumber")
            {
                return label.Text = ChurchNumber.ToString();
            }
            else if (text == "FactoryNumber")
            {
                return label.Text = FactoryNumber.ToString();
            }
            else if (text == "ShopNumber")
            {
                return label.Text = ShopNumber.ToString();
            }

            return label.Text = "error";
        }
        public string SetText(string text, Button button)
        {
            if (text == "BuyChurch")
            {
                return button.Text = setNumber(ChurchCost);
            }
            else if (text == "BuyFactory")
            {
                return button.Text = setNumber(FactoryCost);
            }
            else if (text == "BuyShop")
            {
                return button.Text = setNumber(ShopCost);
            }
            else if (text == "BuyOne")
            {
                return button.Text = setNumber(UpgradeCost);
            }
            else if (text == "BuyAll")
            {
                long[] x = getUpgrade(UpgradeCost);
                return button.Text = setNumber(x[1]);
            }
            else if (text == "ChurchBuyAll")
            {
                long[] x = getUpgrade(ChurchCost);
                return button.Text = setNumber(x[1]);
            }
            else if (text == "FactoryBuyAll")
            {
                long[] x = getUpgrade(FactoryCost);
                return button.Text = setNumber(x[1]);
            }
            else if (text == "ShopBuyAll")
            {
                long[] x = getUpgrade(ShopCost);
                return button.Text = setNumber(x[1]);
            }
            return button.Text = "error";
        }


        public void GetMoney()
        {
            cps = (5 * ChurchNumber) + (25 * FactoryNumber) + (100 * ShopNumber);
            money += cps;
        }
        private void buyChurch_Click(object sender, EventArgs e)
        {
            if(money >= ChurchCost)
            {
                ChurchNumber++;
                money -= ChurchCost;
                ChurchCost = ChurchCost + ChurchCost / 2;
                SetText("ChurchNumber", churchNumber);
                SetText("BuyChurch", buyChurch);
                SetText("ChurchBuyAll", ChurchUpgradeAll);
                SetText("money", coin);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetMoney();
            SetText("BuyAll", BuyAll);
            SetText("money", coin);
            SetText("ChurchBuyAll", ChurchUpgradeAll);
            SetText("FactoryBuyAll", FactoryUpgradeAll);
            SetText("ShopBuyAll", ShopUpgradeAll);


            random();


        }

        private void buyFactory_Click(object sender, EventArgs e)
        {
            if(money >= FactoryCost)
            {
                FactoryNumber++;
                money -= FactoryCost;
                FactoryCost = FactoryCost + FactoryCost / 2;
                SetText("FactoryNumber", factoryNumber);
                SetText("BuyFactory", buyFactory);
                SetText("FactoryBuyAll", FactoryUpgradeAll);
                SetText("money", coin);
            }
        }

        private void BuyShop_Click(object sender, EventArgs e)
        {
            if(money >= ShopCost)
            {
                ShopNumber++;
                money -= ShopCost;
                ShopCost = ShopCost + ShopCost / 2;
                SetText("ShopNumber", shopNumber);
                SetText("BuyShop", buyShop);
                SetText("money", coin);
            }
        }

        private void BuyOne_Click(object sender, EventArgs e)
        {
            if(money >= UpgradeCost)
            {
                GetPerClick += 1;
                money -= UpgradeCost;
                UpgradeCost = UpgradeCost + UpgradeCost / 2;
                SetText("money", coin);
                SetText("BuyOne", BuyOne);
                SetText("BuyAll", BuyAll);

            }
        }

        private void BuyAll_Click(object sender, EventArgs e)
        {
            long[] x = getUpgrade(UpgradeCost);

            if(money >= x[1])
            {

                GetPerClick += amount;
                money -= x[1];
                UpgradeCost = x[0];
                SetText("money", coin);
                SetText("BuyAll", BuyAll);
                SetText("BuyOne", BuyOne);

            }
            
        }

        private void ChurchUpgradeAll_Click(object sender, EventArgs e)
        {
            long[] x = getUpgrade(ChurchCost);

            if (money >= x[1])
            {

                ChurchNumber += amount;
                money -= x[1];
                ChurchCost = x[0];
                SetText("money", coin);
                SetText("ChurchNumber", churchNumber);
                SetText("BuyChurch", buyChurch);
                SetText("ChurchBuyAll", ChurchUpgradeAll);


            }
        }

        private void FactoryUpgradeAll_Click(object sender, EventArgs e)
        {
            long[] x = getUpgrade(FactoryCost);

            if (money >= x[1])
            {

                FactoryNumber += amount;
                money -= x[1];
                FactoryCost = x[0];
                SetText("money", coin);
                SetText("FactoryNumber", factoryNumber);
                SetText("BuyFactory", buyFactory);
                SetText("FactoryBuyAll", FactoryUpgradeAll);


            }
        }

        private void ShopUpgradeAll_Click(object sender, EventArgs e)
        {
            long[] x = getUpgrade(ShopCost);

            if (money >= x[1])
            {

                ShopNumber += amount;
                money -= x[1];
                ShopCost = x[0];
                SetText("money", coin);
                SetText("ShopNumber", shopNumber);
                SetText("BuyShop", buyShop);
                SetText("ShopBuyAll", ShopUpgradeAll);


            }
        }
    }
}