namespace cookieClicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buyChurch = new System.Windows.Forms.Button();
            this.churchNumber = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.factoryNumber = new System.Windows.Forms.Label();
            this.buyFactory = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.shopNumber = new System.Windows.Forms.Label();
            this.buyShop = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BuyAll = new System.Windows.Forms.Button();
            this.BuyOne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChurchUpgradeAll = new System.Windows.Forms.Button();
            this.FactoryUpgradeAll = new System.Windows.Forms.Button();
            this.ShopUpgradeAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::cookieClicker.Properties.Resources.cookie;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(390, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // coin
            // 
            this.coin.AutoSize = true;
            this.coin.BackColor = System.Drawing.Color.Transparent;
            this.coin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.coin.Location = new System.Drawing.Point(444, 120);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(0, 32);
            this.coin.TabIndex = 1;
            this.coin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::cookieClicker.Properties.Resources.church;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(739, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 80);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // buyChurch
            // 
            this.buyChurch.AutoSize = true;
            this.buyChurch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buyChurch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buyChurch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buyChurch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buyChurch.Location = new System.Drawing.Point(842, 211);
            this.buyChurch.Margin = new System.Windows.Forms.Padding(0);
            this.buyChurch.Name = "buyChurch";
            this.buyChurch.Size = new System.Drawing.Size(94, 36);
            this.buyChurch.TabIndex = 3;
            this.buyChurch.UseVisualStyleBackColor = false;
            this.buyChurch.Click += new System.EventHandler(this.buyChurch_Click);
            // 
            // churchNumber
            // 
            this.churchNumber.AutoSize = true;
            this.churchNumber.BackColor = System.Drawing.Color.Transparent;
            this.churchNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.churchNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.churchNumber.Location = new System.Drawing.Point(707, 217);
            this.churchNumber.Name = "churchNumber";
            this.churchNumber.Size = new System.Drawing.Size(0, 30);
            this.churchNumber.TabIndex = 5;
            this.churchNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // factoryNumber
            // 
            this.factoryNumber.AutoSize = true;
            this.factoryNumber.BackColor = System.Drawing.Color.Transparent;
            this.factoryNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.factoryNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.factoryNumber.Location = new System.Drawing.Point(707, 320);
            this.factoryNumber.Name = "factoryNumber";
            this.factoryNumber.Size = new System.Drawing.Size(0, 30);
            this.factoryNumber.TabIndex = 8;
            this.factoryNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buyFactory
            // 
            this.buyFactory.AutoSize = true;
            this.buyFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buyFactory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buyFactory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buyFactory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buyFactory.Location = new System.Drawing.Point(842, 319);
            this.buyFactory.Margin = new System.Windows.Forms.Padding(0);
            this.buyFactory.Name = "buyFactory";
            this.buyFactory.Size = new System.Drawing.Size(94, 36);
            this.buyFactory.TabIndex = 7;
            this.buyFactory.UseVisualStyleBackColor = false;
            this.buyFactory.Click += new System.EventHandler(this.buyFactory_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::cookieClicker.Properties.Resources.factory;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(739, 290);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 80);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // shopNumber
            // 
            this.shopNumber.AutoSize = true;
            this.shopNumber.BackColor = System.Drawing.Color.Transparent;
            this.shopNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shopNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.shopNumber.Location = new System.Drawing.Point(707, 428);
            this.shopNumber.Name = "shopNumber";
            this.shopNumber.Size = new System.Drawing.Size(0, 30);
            this.shopNumber.TabIndex = 11;
            this.shopNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buyShop
            // 
            this.buyShop.AutoSize = true;
            this.buyShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buyShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buyShop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buyShop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buyShop.Location = new System.Drawing.Point(842, 422);
            this.buyShop.Margin = new System.Windows.Forms.Padding(0);
            this.buyShop.Name = "buyShop";
            this.buyShop.Size = new System.Drawing.Size(94, 36);
            this.buyShop.TabIndex = 10;
            this.buyShop.UseVisualStyleBackColor = false;
            this.buyShop.Click += new System.EventHandler(this.BuyShop_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::cookieClicker.Properties.Resources.shop;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(739, 398);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(88, 80);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // BuyAll
            // 
            this.BuyAll.AutoSize = true;
            this.BuyAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BuyAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuyAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BuyAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BuyAll.Location = new System.Drawing.Point(945, 530);
            this.BuyAll.Margin = new System.Windows.Forms.Padding(0);
            this.BuyAll.Name = "BuyAll";
            this.BuyAll.Size = new System.Drawing.Size(94, 36);
            this.BuyAll.TabIndex = 12;
            this.BuyAll.UseVisualStyleBackColor = false;
            this.BuyAll.Click += new System.EventHandler(this.BuyAll_Click);
            // 
            // BuyOne
            // 
            this.BuyOne.AutoSize = true;
            this.BuyOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BuyOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuyOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BuyOne.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BuyOne.Location = new System.Drawing.Point(842, 530);
            this.BuyOne.Margin = new System.Windows.Forms.Padding(0);
            this.BuyOne.Name = "BuyOne";
            this.BuyOne.Size = new System.Drawing.Size(94, 36);
            this.BuyOne.TabIndex = 13;
            this.BuyOne.UseVisualStyleBackColor = false;
            this.BuyOne.Click += new System.EventHandler(this.BuyOne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(866, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "1x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(970, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "All";
            // 
            // ChurchUpgradeAll
            // 
            this.ChurchUpgradeAll.AutoSize = true;
            this.ChurchUpgradeAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ChurchUpgradeAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChurchUpgradeAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChurchUpgradeAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChurchUpgradeAll.Location = new System.Drawing.Point(945, 211);
            this.ChurchUpgradeAll.Margin = new System.Windows.Forms.Padding(0);
            this.ChurchUpgradeAll.Name = "ChurchUpgradeAll";
            this.ChurchUpgradeAll.Size = new System.Drawing.Size(94, 36);
            this.ChurchUpgradeAll.TabIndex = 16;
            this.ChurchUpgradeAll.UseVisualStyleBackColor = false;
            this.ChurchUpgradeAll.Click += new System.EventHandler(this.ChurchUpgradeAll_Click);
            // 
            // FactoryUpgradeAll
            // 
            this.FactoryUpgradeAll.AutoSize = true;
            this.FactoryUpgradeAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FactoryUpgradeAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FactoryUpgradeAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FactoryUpgradeAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FactoryUpgradeAll.Location = new System.Drawing.Point(945, 319);
            this.FactoryUpgradeAll.Margin = new System.Windows.Forms.Padding(0);
            this.FactoryUpgradeAll.Name = "FactoryUpgradeAll";
            this.FactoryUpgradeAll.Size = new System.Drawing.Size(94, 36);
            this.FactoryUpgradeAll.TabIndex = 17;
            this.FactoryUpgradeAll.UseVisualStyleBackColor = false;
            this.FactoryUpgradeAll.Click += new System.EventHandler(this.FactoryUpgradeAll_Click);
            // 
            // ShopUpgradeAll
            // 
            this.ShopUpgradeAll.AutoSize = true;
            this.ShopUpgradeAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ShopUpgradeAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShopUpgradeAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShopUpgradeAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShopUpgradeAll.Location = new System.Drawing.Point(945, 422);
            this.ShopUpgradeAll.Margin = new System.Windows.Forms.Padding(0);
            this.ShopUpgradeAll.Name = "ShopUpgradeAll";
            this.ShopUpgradeAll.Size = new System.Drawing.Size(94, 36);
            this.ShopUpgradeAll.TabIndex = 18;
            this.ShopUpgradeAll.UseVisualStyleBackColor = false;
            this.ShopUpgradeAll.Click += new System.EventHandler(this.ShopUpgradeAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(866, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "1x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(866, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "1x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(866, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "1x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(735, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 30);
            this.label6.TabIndex = 22;
            this.label6.Text = "Upgrade";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(970, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "All";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(970, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 32);
            this.label8.TabIndex = 24;
            this.label8.Text = "All";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(970, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 32);
            this.label9.TabIndex = 25;
            this.label9.Text = "All";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::cookieClicker.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 586);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShopUpgradeAll);
            this.Controls.Add(this.FactoryUpgradeAll);
            this.Controls.Add(this.ChurchUpgradeAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuyOne);
            this.Controls.Add(this.BuyAll);
            this.Controls.Add(this.shopNumber);
            this.Controls.Add(this.buyShop);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.factoryNumber);
            this.Controls.Add(this.buyFactory);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.churchNumber);
            this.Controls.Add(this.buyChurch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label coin;
        private PictureBox pictureBox2;
        private Button buyChurch;
        private Label churchNumber;
        private System.Windows.Forms.Timer timer1;
        private Label factoryNumber;
        private Button buyFactory;
        private PictureBox pictureBox3;
        private Label shopNumber;
        private Button buyShop;
        private PictureBox pictureBox4;
        private Button BuyAll;
        private Button BuyOne;
        private Label label1;
        private Label label2;
        private Button ChurchUpgradeAll;
        private Button FactoryUpgradeAll;
        private Button ShopUpgradeAll;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}