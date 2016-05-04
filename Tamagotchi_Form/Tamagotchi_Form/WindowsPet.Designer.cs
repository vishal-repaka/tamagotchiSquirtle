namespace WindowsFormsApplication1
{
    partial class WindowsPet
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsPet));
            this.MoodL = new System.Windows.Forms.Label();
            this.MoodT = new System.Windows.Forms.TextBox();
            this.FullnessL = new System.Windows.Forms.Label();
            this.HungerT = new System.Windows.Forms.TextBox();
            this.ThirstT = new System.Windows.Forms.TextBox();
            this.ThirstL = new System.Windows.Forms.Label();
            this.BoredomT = new System.Windows.Forms.TextBox();
            this.BoredomL = new System.Windows.Forms.Label();
            this.SleepT = new System.Windows.Forms.TextBox();
            this.SleepL = new System.Windows.Forms.Label();
            this.EnergyT = new System.Windows.Forms.TextBox();
            this.EnergyL = new System.Windows.Forms.Label();
            this.SleepCount = new System.Windows.Forms.Timer(this.components);
            this.SleepC = new System.Windows.Forms.Label();
            this.StatCheck = new System.Windows.Forms.Timer(this.components);
            this.Eating = new System.Windows.Forms.Timer(this.components);
            this.Exercising = new System.Windows.Forms.Timer(this.components);
            this.FitChanger = new System.Windows.Forms.Timer(this.components);
            this.MoodCheck = new System.Windows.Forms.Timer(this.components);
            this.BoredomCheck = new System.Windows.Forms.Timer(this.components);
            this.TirednessChanger = new System.Windows.Forms.Timer(this.components);
            this.Textchanger = new System.Windows.Forms.Timer(this.components);
            this.Drinking = new System.Windows.Forms.Timer(this.components);
            this.Petting = new System.Windows.Forms.Timer(this.components);
            this.IdleCount = new System.Windows.Forms.Timer(this.components);
            this.Ignoring = new System.Windows.Forms.Timer(this.components);
            this.Sleep1 = new System.Windows.Forms.Button();
            this.Pet = new System.Windows.Forms.PictureBox();
            this.Ignore = new System.Windows.Forms.Button();
            this.Exercise = new System.Windows.Forms.Button();
            this.Pat = new System.Windows.Forms.Button();
            this.Drink = new System.Windows.Forms.Button();
            this.Feed = new System.Windows.Forms.Button();
            this.PetSleep = new System.Windows.Forms.PictureBox();
            this.PetLonely = new System.Windows.Forms.PictureBox();
            this.PetEat = new System.Windows.Forms.PictureBox();
            this.PetExercise = new System.Windows.Forms.PictureBox();
            this.FeelingGood = new System.Windows.Forms.PictureBox();
            this.PetDrinking = new System.Windows.Forms.PictureBox();
            this.PetPat = new System.Windows.Forms.PictureBox();
            this.PetSad = new System.Windows.Forms.PictureBox();
            this.PetIdle = new System.Windows.Forms.PictureBox();
            this.PetIdle2 = new System.Windows.Forms.PictureBox();
            this.PetIgnored = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.StatTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetLonely)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetEat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetExercise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeelingGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetDrinking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetPat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetSad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetIdle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetIdle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetIgnored)).BeginInit();
            this.SuspendLayout();
            // 
            // MoodL
            // 
            this.MoodL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoodL.Location = new System.Drawing.Point(36, 99);
            this.MoodL.Name = "MoodL";
            this.MoodL.Size = new System.Drawing.Size(57, 29);
            this.MoodL.TabIndex = 7;
            this.MoodL.Text = "Mood";
            // 
            // MoodT
            // 
            this.MoodT.Location = new System.Drawing.Point(12, 121);
            this.MoodT.Name = "MoodT";
            this.MoodT.Size = new System.Drawing.Size(100, 20);
            this.MoodT.TabIndex = 8;
            this.MoodT.Text = "100";
            // 
            // FullnessL
            // 
            this.FullnessL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullnessL.Location = new System.Drawing.Point(27, 229);
            this.FullnessL.Name = "FullnessL";
            this.FullnessL.Size = new System.Drawing.Size(76, 29);
            this.FullnessL.TabIndex = 9;
            this.FullnessL.Text = "Fullness";
            // 
            // HungerT
            // 
            this.HungerT.Location = new System.Drawing.Point(12, 251);
            this.HungerT.Name = "HungerT";
            this.HungerT.Size = new System.Drawing.Size(100, 20);
            this.HungerT.TabIndex = 10;
            this.HungerT.Text = "100";
            // 
            // ThirstT
            // 
            this.ThirstT.Location = new System.Drawing.Point(12, 392);
            this.ThirstT.Name = "ThirstT";
            this.ThirstT.Size = new System.Drawing.Size(100, 20);
            this.ThirstT.TabIndex = 12;
            this.ThirstT.Text = "100";
            // 
            // ThirstL
            // 
            this.ThirstL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirstL.Location = new System.Drawing.Point(36, 370);
            this.ThirstL.Name = "ThirstL";
            this.ThirstL.Size = new System.Drawing.Size(57, 29);
            this.ThirstL.TabIndex = 11;
            this.ThirstL.Text = "Thirst";
            // 
            // BoredomT
            // 
            this.BoredomT.Location = new System.Drawing.Point(522, 251);
            this.BoredomT.Name = "BoredomT";
            this.BoredomT.Size = new System.Drawing.Size(100, 20);
            this.BoredomT.TabIndex = 16;
            this.BoredomT.Text = "100";
            // 
            // BoredomL
            // 
            this.BoredomL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoredomL.Location = new System.Drawing.Point(537, 229);
            this.BoredomL.Name = "BoredomL";
            this.BoredomL.Size = new System.Drawing.Size(76, 29);
            this.BoredomL.TabIndex = 15;
            this.BoredomL.Text = "Boredom";
            // 
            // SleepT
            // 
            this.SleepT.Location = new System.Drawing.Point(522, 121);
            this.SleepT.Name = "SleepT";
            this.SleepT.Size = new System.Drawing.Size(100, 20);
            this.SleepT.TabIndex = 14;
            this.SleepT.Text = "100";
            // 
            // SleepL
            // 
            this.SleepL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SleepL.Location = new System.Drawing.Point(532, 99);
            this.SleepL.Name = "SleepL";
            this.SleepL.Size = new System.Drawing.Size(81, 29);
            this.SleepL.TabIndex = 13;
            this.SleepL.Text = "Tiredness";
            // 
            // EnergyT
            // 
            this.EnergyT.Location = new System.Drawing.Point(522, 392);
            this.EnergyT.Name = "EnergyT";
            this.EnergyT.Size = new System.Drawing.Size(100, 20);
            this.EnergyT.TabIndex = 18;
            this.EnergyT.Text = "10";
            // 
            // EnergyL
            // 
            this.EnergyL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnergyL.Location = new System.Drawing.Point(537, 370);
            this.EnergyL.Name = "EnergyL";
            this.EnergyL.Size = new System.Drawing.Size(76, 29);
            this.EnergyL.TabIndex = 17;
            this.EnergyL.Text = "Energy";
            // 
            // SleepCount
            // 
            this.SleepCount.Interval = 600;
            this.SleepCount.Tick += new System.EventHandler(this.SleepCount_Tick);
            // 
            // SleepC
            // 
            this.SleepC.AutoSize = true;
            this.SleepC.Location = new System.Drawing.Point(224, 99);
            this.SleepC.Name = "SleepC";
            this.SleepC.Size = new System.Drawing.Size(25, 13);
            this.SleepC.TabIndex = 20;
            this.SleepC.Text = "666";
            this.SleepC.Visible = false;
            // 
            // StatCheck
            // 
            this.StatCheck.Enabled = true;
            this.StatCheck.Interval = 1;
            this.StatCheck.Tick += new System.EventHandler(this.StatCheck_Tick);
            // 
            // Eating
            // 
            this.Eating.Interval = 1000;
            this.Eating.Tick += new System.EventHandler(this.Eating_Tick);
            // 
            // Exercising
            // 
            this.Exercising.Interval = 1000;
            this.Exercising.Tick += new System.EventHandler(this.Exercising_Tick);
            // 
            // FitChanger
            // 
            this.FitChanger.Enabled = true;
            this.FitChanger.Interval = 100000;
            this.FitChanger.Tick += new System.EventHandler(this.FitChanger_Tick);
            // 
            // MoodCheck
            // 
            this.MoodCheck.Enabled = true;
            this.MoodCheck.Interval = 1;
            this.MoodCheck.Tick += new System.EventHandler(this.MoodCheck_Tick);
            // 
            // BoredomCheck
            // 
            this.BoredomCheck.Enabled = true;
            this.BoredomCheck.Interval = 1;
            this.BoredomCheck.Tick += new System.EventHandler(this.BoredomCheck_Tick);
            // 
            // TirednessChanger
            // 
            this.TirednessChanger.Enabled = true;
            this.TirednessChanger.Interval = 10000;
            this.TirednessChanger.Tick += new System.EventHandler(this.TirednessChanger_Tick);
            // 
            // Textchanger
            // 
            this.Textchanger.Enabled = true;
            this.Textchanger.Interval = 1;
            this.Textchanger.Tick += new System.EventHandler(this.Textchanger_Tick);
            // 
            // Drinking
            // 
            this.Drinking.Interval = 1000;
            this.Drinking.Tick += new System.EventHandler(this.Drinking_Tick);
            // 
            // Petting
            // 
            this.Petting.Interval = 1000;
            this.Petting.Tick += new System.EventHandler(this.Petting_Tick);
            // 
            // IdleCount
            // 
            this.IdleCount.Enabled = true;
            this.IdleCount.Interval = 1000;
            this.IdleCount.Tick += new System.EventHandler(this.IdleCount_Tick);
            // 
            // Ignoring
            // 
            this.Ignoring.Interval = 1000;
            this.Ignoring.Tick += new System.EventHandler(this.Ignoring_Tick);
            // 
            // Sleep1
            // 
            this.Sleep1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sleep1.BackgroundImage")));
            this.Sleep1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sleep1.Location = new System.Drawing.Point(486, 449);
            this.Sleep1.Name = "Sleep1";
            this.Sleep1.Size = new System.Drawing.Size(127, 63);
            this.Sleep1.TabIndex = 24;
            this.Sleep1.UseVisualStyleBackColor = true;
            this.Sleep1.Click += new System.EventHandler(this.Sleep1_Click);
            // 
            // Pet
            // 
            this.Pet.BackColor = System.Drawing.Color.Transparent;
            this.Pet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pet.Image = global::WindowsFormsApplication1.Properties.Resources.output_18BHHa;
            this.Pet.Location = new System.Drawing.Point(127, 80);
            this.Pet.Name = "Pet";
            this.Pet.Size = new System.Drawing.Size(376, 363);
            this.Pet.TabIndex = 6;
            this.Pet.TabStop = false;
            // 
            // Ignore
            // 
            this.Ignore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ignore.BackgroundImage")));
            this.Ignore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ignore.Location = new System.Drawing.Point(252, 449);
            this.Ignore.Name = "Ignore";
            this.Ignore.Size = new System.Drawing.Size(127, 63);
            this.Ignore.TabIndex = 5;
            this.Ignore.UseVisualStyleBackColor = true;
            this.Ignore.Click += new System.EventHandler(this.Ignore_Click);
            // 
            // Exercise
            // 
            this.Exercise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exercise.BackgroundImage")));
            this.Exercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exercise.Location = new System.Drawing.Point(13, 449);
            this.Exercise.Name = "Exercise";
            this.Exercise.Size = new System.Drawing.Size(127, 63);
            this.Exercise.TabIndex = 3;
            this.Exercise.UseVisualStyleBackColor = true;
            this.Exercise.Click += new System.EventHandler(this.Exercise_Click);
            // 
            // Pat
            // 
            this.Pat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Pat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pat.BackgroundImage")));
            this.Pat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pat.Location = new System.Drawing.Point(497, 13);
            this.Pat.Name = "Pat";
            this.Pat.Size = new System.Drawing.Size(127, 63);
            this.Pat.TabIndex = 2;
            this.Pat.UseVisualStyleBackColor = true;
            this.Pat.Click += new System.EventHandler(this.Pat_Click);
            // 
            // Drink
            // 
            this.Drink.Image = ((System.Drawing.Image)(resources.GetObject("Drink.Image")));
            this.Drink.Location = new System.Drawing.Point(252, 13);
            this.Drink.Name = "Drink";
            this.Drink.Size = new System.Drawing.Size(127, 63);
            this.Drink.TabIndex = 1;
            this.Drink.UseVisualStyleBackColor = true;
            this.Drink.Click += new System.EventHandler(this.Drink_Click);
            // 
            // Feed
            // 
            this.Feed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Feed.BackgroundImage")));
            this.Feed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Feed.Image = ((System.Drawing.Image)(resources.GetObject("Feed.Image")));
            this.Feed.Location = new System.Drawing.Point(13, 13);
            this.Feed.Name = "Feed";
            this.Feed.Size = new System.Drawing.Size(127, 63);
            this.Feed.TabIndex = 0;
            this.Feed.UseVisualStyleBackColor = true;
            this.Feed.Click += new System.EventHandler(this.Feed_Click);
            // 
            // PetSleep
            // 
            this.PetSleep.BackColor = System.Drawing.Color.Transparent;
            this.PetSleep.Image = ((System.Drawing.Image)(resources.GetObject("PetSleep.Image")));
            this.PetSleep.Location = new System.Drawing.Point(144, 380);
            this.PetSleep.Name = "PetSleep";
            this.PetSleep.Size = new System.Drawing.Size(54, 50);
            this.PetSleep.TabIndex = 19;
            this.PetSleep.TabStop = false;
            this.PetSleep.Visible = false;
            // 
            // PetLonely
            // 
            this.PetLonely.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PetLonely.Image = global::WindowsFormsApplication1.Properties.Resources.Lonely;
            this.PetLonely.Location = new System.Drawing.Point(127, 82);
            this.PetLonely.Name = "PetLonely";
            this.PetLonely.Size = new System.Drawing.Size(376, 361);
            this.PetLonely.TabIndex = 21;
            this.PetLonely.TabStop = false;
            this.PetLonely.Visible = false;
            // 
            // PetEat
            // 
            this.PetEat.BackColor = System.Drawing.Color.Transparent;
            this.PetEat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PetEat.Image = global::WindowsFormsApplication1.Properties.Resources.Feed;
            this.PetEat.Location = new System.Drawing.Point(127, 81);
            this.PetEat.Name = "PetEat";
            this.PetEat.Size = new System.Drawing.Size(376, 361);
            this.PetEat.TabIndex = 22;
            this.PetEat.TabStop = false;
            this.PetEat.Visible = false;
            // 
            // PetExercise
            // 
            this.PetExercise.BackColor = System.Drawing.Color.White;
            this.PetExercise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PetExercise.Image = global::WindowsFormsApplication1.Properties.Resources.Exercise2;
            this.PetExercise.Location = new System.Drawing.Point(127, 83);
            this.PetExercise.Name = "PetExercise";
            this.PetExercise.Size = new System.Drawing.Size(376, 360);
            this.PetExercise.TabIndex = 23;
            this.PetExercise.TabStop = false;
            this.PetExercise.Visible = false;
            // 
            // FeelingGood
            // 
            this.FeelingGood.BackColor = System.Drawing.Color.White;
            this.FeelingGood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FeelingGood.Image = global::WindowsFormsApplication1.Properties.Resources.FeelingGood;
            this.FeelingGood.Location = new System.Drawing.Point(127, 82);
            this.FeelingGood.Name = "FeelingGood";
            this.FeelingGood.Size = new System.Drawing.Size(376, 360);
            this.FeelingGood.TabIndex = 25;
            this.FeelingGood.TabStop = false;
            this.FeelingGood.Visible = false;
            // 
            // PetDrinking
            // 
            this.PetDrinking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PetDrinking.Image = global::WindowsFormsApplication1.Properties.Resources.Drinking2;
            this.PetDrinking.Location = new System.Drawing.Point(127, 82);
            this.PetDrinking.Name = "PetDrinking";
            this.PetDrinking.Size = new System.Drawing.Size(376, 361);
            this.PetDrinking.TabIndex = 26;
            this.PetDrinking.TabStop = false;
            this.PetDrinking.Visible = false;
            // 
            // PetPat
            // 
            this.PetPat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PetPat.Image = global::WindowsFormsApplication1.Properties.Resources.Pat;
            this.PetPat.Location = new System.Drawing.Point(127, 82);
            this.PetPat.Name = "PetPat";
            this.PetPat.Size = new System.Drawing.Size(376, 361);
            this.PetPat.TabIndex = 27;
            this.PetPat.TabStop = false;
            this.PetPat.Visible = false;
            // 
            // PetSad
            // 
            this.PetSad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PetSad.Image = global::WindowsFormsApplication1.Properties.Resources.Sad;
            this.PetSad.Location = new System.Drawing.Point(127, 82);
            this.PetSad.Name = "PetSad";
            this.PetSad.Size = new System.Drawing.Size(376, 361);
            this.PetSad.TabIndex = 28;
            this.PetSad.TabStop = false;
            this.PetSad.Visible = false;
            // 
            // PetIdle
            // 
            this.PetIdle.Image = global::WindowsFormsApplication1.Properties.Resources.tumblr_mic9nppWSk1rxsftpo1_500;
            this.PetIdle.Location = new System.Drawing.Point(127, 82);
            this.PetIdle.Name = "PetIdle";
            this.PetIdle.Size = new System.Drawing.Size(376, 361);
            this.PetIdle.TabIndex = 29;
            this.PetIdle.TabStop = false;
            this.PetIdle.Visible = false;
            // 
            // PetIdle2
            // 
            this.PetIdle2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PetIdle2.Image = global::WindowsFormsApplication1.Properties.Resources.Silly;
            this.PetIdle2.Location = new System.Drawing.Point(127, 80);
            this.PetIdle2.Name = "PetIdle2";
            this.PetIdle2.Size = new System.Drawing.Size(376, 362);
            this.PetIdle2.TabIndex = 30;
            this.PetIdle2.TabStop = false;
            this.PetIdle2.Visible = false;
            // 
            // PetIgnored
            // 
            this.PetIgnored.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PetIgnored.Image = global::WindowsFormsApplication1.Properties.Resources.tumblr_mrlku6v1JS1rqf5j4o1_500;
            this.PetIgnored.Location = new System.Drawing.Point(127, 80);
            this.PetIgnored.Name = "PetIgnored";
            this.PetIgnored.Size = new System.Drawing.Size(376, 363);
            this.PetIgnored.TabIndex = 31;
            this.PetIgnored.TabStop = false;
            this.PetIgnored.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Created By Alex Tran";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 528);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(367, 23);
            this.Save.TabIndex = 33;
            this.Save.Text = "Save Game";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // StatTimer
            // 
            this.StatTimer.Enabled = true;
            this.StatTimer.Interval = 10000;
            this.StatTimer.Tick += new System.EventHandler(this.StatTimer_Tick_1);
            // 
            // WindowsPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(636, 560);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sleep1);
            this.Controls.Add(this.EnergyT);
            this.Controls.Add(this.EnergyL);
            this.Controls.Add(this.BoredomT);
            this.Controls.Add(this.BoredomL);
            this.Controls.Add(this.SleepT);
            this.Controls.Add(this.SleepL);
            this.Controls.Add(this.ThirstT);
            this.Controls.Add(this.ThirstL);
            this.Controls.Add(this.HungerT);
            this.Controls.Add(this.FullnessL);
            this.Controls.Add(this.MoodT);
            this.Controls.Add(this.MoodL);
            this.Controls.Add(this.Pet);
            this.Controls.Add(this.Ignore);
            this.Controls.Add(this.Exercise);
            this.Controls.Add(this.Pat);
            this.Controls.Add(this.Drink);
            this.Controls.Add(this.Feed);
            this.Controls.Add(this.PetSleep);
            this.Controls.Add(this.SleepC);
            this.Controls.Add(this.PetLonely);
            this.Controls.Add(this.PetEat);
            this.Controls.Add(this.PetExercise);
            this.Controls.Add(this.FeelingGood);
            this.Controls.Add(this.PetDrinking);
            this.Controls.Add(this.PetPat);
            this.Controls.Add(this.PetSad);
            this.Controls.Add(this.PetIdle);
            this.Controls.Add(this.PetIdle2);
            this.Controls.Add(this.PetIgnored);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowsPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokePet";
            ((System.ComponentModel.ISupportInitialize)(this.Pet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetLonely)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetEat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetExercise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeelingGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetDrinking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetPat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetSad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetIdle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetIdle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetIgnored)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Feed;
        private System.Windows.Forms.Button Drink;
        private System.Windows.Forms.Button Exercise;
        private System.Windows.Forms.Button Ignore;
        private System.Windows.Forms.Button Pat;
        private System.Windows.Forms.PictureBox Pet;
        private System.Windows.Forms.Label MoodL;
        private System.Windows.Forms.TextBox MoodT;
        private System.Windows.Forms.Label FullnessL;
        private System.Windows.Forms.TextBox HungerT;
        private System.Windows.Forms.TextBox ThirstT;
        private System.Windows.Forms.Label ThirstL;
        private System.Windows.Forms.TextBox BoredomT;
        private System.Windows.Forms.Label BoredomL;
        private System.Windows.Forms.TextBox SleepT;
        private System.Windows.Forms.Label SleepL;
        private System.Windows.Forms.TextBox EnergyT;
        private System.Windows.Forms.Label EnergyL;
        private System.Windows.Forms.PictureBox PetSleep;
        private System.Windows.Forms.Timer SleepCount;
        private System.Windows.Forms.Label SleepC;
        private System.Windows.Forms.Timer StatCheck;
        private System.Windows.Forms.PictureBox PetLonely;
        private System.Windows.Forms.PictureBox PetEat;
        private System.Windows.Forms.Timer Eating;
        private System.Windows.Forms.PictureBox PetExercise;
        private System.Windows.Forms.Button Sleep1;
        private System.Windows.Forms.Timer Exercising;
        private System.Windows.Forms.PictureBox FeelingGood;
        private System.Windows.Forms.Timer FitChanger;
        private System.Windows.Forms.Timer MoodCheck;
        private System.Windows.Forms.Timer BoredomCheck;
        private System.Windows.Forms.Timer TirednessChanger;
        private System.Windows.Forms.Timer Textchanger;
        private System.Windows.Forms.PictureBox PetDrinking;
        private System.Windows.Forms.Timer Drinking;
        private System.Windows.Forms.PictureBox PetPat;
        private System.Windows.Forms.Timer Petting;
        private System.Windows.Forms.PictureBox PetSad;
        private System.Windows.Forms.Timer IdleCount;
        private System.Windows.Forms.PictureBox PetIdle;
        private System.Windows.Forms.PictureBox PetIdle2;
        private System.Windows.Forms.Timer Ignoring;
        private System.Windows.Forms.PictureBox PetIgnored;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Timer StatTimer;
    }
}

