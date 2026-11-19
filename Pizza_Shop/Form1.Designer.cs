namespace Pizza_Shop
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
            cmboxType = new ComboBox();
            lblType = new Label();
            lblSize = new Label();
            rbtnSmall = new RadioButton();
            rbtnMiddle = new RadioButton();
            rbtnFamily = new RadioButton();
            lblAdd = new Label();
            chboxCheese = new CheckBox();
            chboxBacon = new CheckBox();
            chboxMushrooms = new CheckBox();
            chboxOlives = new CheckBox();
            lblQuantity = new Label();
            txtBoxQuantity = new TextBox();
            btnAddToBill = new Button();
            btnFinishBill = new Button();
            listBox1 = new ListBox();
            lblBill = new Label();
            lblSummary = new Label();
            SuspendLayout();
            // 
            // cmboxType
            // 
            cmboxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxType.FormattingEnabled = true;
            cmboxType.Location = new Point(340, 80);
            cmboxType.Name = "cmboxType";
            cmboxType.Size = new Size(188, 28);
            cmboxType.TabIndex = 0;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(190, 83);
            lblType.Name = "lblType";
            lblType.Size = new Size(133, 20);
            lblType.TabIndex = 1;
            lblType.Text = "Избери вид пица:";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(153, 129);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(121, 20);
            lblSize.TabIndex = 2;
            lblSize.Text = "Избери размер:";
            // 
            // rbtnSmall
            // 
            rbtnSmall.AutoSize = true;
            rbtnSmall.Location = new Point(281, 127);
            rbtnSmall.Name = "rbtnSmall";
            rbtnSmall.Size = new Size(74, 24);
            rbtnSmall.TabIndex = 3;
            rbtnSmall.TabStop = true;
            rbtnSmall.Text = "Малка";
            rbtnSmall.UseVisualStyleBackColor = true;
            // 
            // rbtnMiddle
            // 
            rbtnMiddle.AutoSize = true;
            rbtnMiddle.Location = new Point(281, 157);
            rbtnMiddle.Name = "rbtnMiddle";
            rbtnMiddle.Size = new Size(81, 24);
            rbtnMiddle.TabIndex = 4;
            rbtnMiddle.TabStop = true;
            rbtnMiddle.Text = "Средна";
            rbtnMiddle.UseVisualStyleBackColor = true;
            // 
            // rbtnFamily
            // 
            rbtnFamily.AutoSize = true;
            rbtnFamily.Location = new Point(281, 187);
            rbtnFamily.Name = "rbtnFamily";
            rbtnFamily.Size = new Size(92, 24);
            rbtnFamily.TabIndex = 5;
            rbtnFamily.TabStop = true;
            rbtnFamily.Text = "Семейна";
            rbtnFamily.UseVisualStyleBackColor = true;
            // 
            // lblAdd
            // 
            lblAdd.AutoSize = true;
            lblAdd.Location = new Point(437, 127);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(126, 20);
            lblAdd.TabIndex = 6;
            lblAdd.Text = "Избери добавка:";
            // 
            // chboxCheese
            // 
            chboxCheese.AutoSize = true;
            chboxCheese.Location = new Point(571, 127);
            chboxCheese.Name = "chboxCheese";
            chboxCheese.Size = new Size(145, 24);
            chboxCheese.TabIndex = 7;
            chboxCheese.Text = "Двоен кашкавал";
            chboxCheese.UseVisualStyleBackColor = true;
            // 
            // chboxBacon
            // 
            chboxBacon.AutoSize = true;
            chboxBacon.Location = new Point(571, 157);
            chboxBacon.Name = "chboxBacon";
            chboxBacon.Size = new Size(73, 24);
            chboxBacon.TabIndex = 8;
            chboxBacon.Text = "Бекон";
            chboxBacon.UseVisualStyleBackColor = true;
            // 
            // chboxMushrooms
            // 
            chboxMushrooms.AutoSize = true;
            chboxMushrooms.Location = new Point(571, 187);
            chboxMushrooms.Name = "chboxMushrooms";
            chboxMushrooms.Size = new Size(65, 24);
            chboxMushrooms.TabIndex = 9;
            chboxMushrooms.Text = "Гъби";
            chboxMushrooms.UseVisualStyleBackColor = true;
            // 
            // chboxOlives
            // 
            chboxOlives.AutoSize = true;
            chboxOlives.Location = new Point(571, 217);
            chboxOlives.Name = "chboxOlives";
            chboxOlives.Size = new Size(94, 24);
            chboxOlives.TabIndex = 10;
            chboxOlives.Text = "Маслини";
            chboxOlives.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(76, 263);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(226, 20);
            lblQuantity.TabIndex = 11;
            lblQuantity.Text = "Въведи брой пици от този вид:";
            // 
            // txtBoxQuantity
            // 
            txtBoxQuantity.Location = new Point(308, 263);
            txtBoxQuantity.Name = "txtBoxQuantity";
            txtBoxQuantity.Size = new Size(125, 27);
            txtBoxQuantity.TabIndex = 12;
            // 
            // btnAddToBill
            // 
            btnAddToBill.Location = new Point(675, 338);
            btnAddToBill.Name = "btnAddToBill";
            btnAddToBill.Size = new Size(183, 29);
            btnAddToBill.TabIndex = 13;
            btnAddToBill.Text = "Добави към сметката";
            btnAddToBill.UseVisualStyleBackColor = true;
            btnAddToBill.Click += btnAddToBill_Click;
            // 
            // btnFinishBill
            // 
            btnFinishBill.Location = new Point(675, 373);
            btnFinishBill.Name = "btnFinishBill";
            btnFinishBill.Size = new Size(183, 29);
            btnFinishBill.TabIndex = 14;
            btnFinishBill.Text = "Приключи сметка";
            btnFinishBill.UseVisualStyleBackColor = true;
            btnFinishBill.Click += btnFinishBill_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(76, 339);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(593, 284);
            listBox1.TabIndex = 15;
            // 
            // lblBill
            // 
            lblBill.AutoSize = true;
            lblBill.Location = new Point(76, 316);
            lblBill.Name = "lblBill";
            lblBill.Size = new Size(58, 20);
            lblBill.TabIndex = 16;
            lblBill.Text = "Сметка";
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Location = new Point(675, 417);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(93, 20);
            lblSummary.TabIndex = 17;
            lblSummary.Text = "Обобщение";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 655);
            Controls.Add(lblSummary);
            Controls.Add(lblBill);
            Controls.Add(listBox1);
            Controls.Add(btnFinishBill);
            Controls.Add(btnAddToBill);
            Controls.Add(txtBoxQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(chboxOlives);
            Controls.Add(chboxMushrooms);
            Controls.Add(chboxBacon);
            Controls.Add(chboxCheese);
            Controls.Add(lblAdd);
            Controls.Add(rbtnFamily);
            Controls.Add(rbtnMiddle);
            Controls.Add(rbtnSmall);
            Controls.Add(lblSize);
            Controls.Add(lblType);
            Controls.Add(cmboxType);
            Name = "Form1";
            Text = "Pizza Shop - Teodora Dobreva F118082";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmboxType;
        private Label lblType;
        private Label lblSize;
        private RadioButton rbtnSmall;
        private RadioButton rbtnMiddle;
        private RadioButton rbtnFamily;
        private Label lblAdd;
        private CheckBox chboxCheese;
        private CheckBox chboxBacon;
        private CheckBox chboxMushrooms;
        private CheckBox chboxOlives;
        private Label lblQuantity;
        private TextBox txtBoxQuantity;
        private Button btnAddToBill;
        private Button btnFinishBill;
        private ListBox listBox1;
        private Label lblBill;
        private Label lblSummary;
    }
}
