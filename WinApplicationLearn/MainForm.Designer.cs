namespace WinApplicationLearn
{
    partial class MainForm
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
            System.Windows.Forms.Label CalculatePresetLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PresetBox = new System.Windows.Forms.ComboBox();
            this.AttackTypeBox = new System.Windows.Forms.ComboBox();
            this.ArmorTypeBox = new System.Windows.Forms.ComboBox();
            this.totalDamageText = new System.Windows.Forms.TextBox();
            this.ArmorValueBox = new System.Windows.Forms.TextBox();
            this.AttackValueBox = new System.Windows.Forms.TextBox();
            CalculatePresetLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculatePresetLabel
            // 
            CalculatePresetLabel.AutoSize = true;
            CalculatePresetLabel.Location = new System.Drawing.Point(12, 9);
            CalculatePresetLabel.Name = "CalculatePresetLabel";
            CalculatePresetLabel.Size = new System.Drawing.Size(155, 20);
            CalculatePresetLabel.TabIndex = 0;
            CalculatePresetLabel.Text = "Пресет калькулятора";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 80);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "Тип Атаки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(169, 80);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 20);
            label2.TabIndex = 3;
            label2.Text = "Тип Брони";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 134);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 20);
            label3.TabIndex = 6;
            label3.Text = "Урон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(169, 134);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 20);
            label4.TabIndex = 7;
            label4.Text = "Броня";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(240, 187);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(116, 20);
            label5.TabIndex = 8;
            label5.Text = "Итоговый урон";
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(WinApplicationLearn.MainForm);
            // 
            // PresetBox
            // 
            this.PresetBox.FormattingEnabled = true;
            this.PresetBox.Location = new System.Drawing.Point(12, 32);
            this.PresetBox.Name = "PresetBox";
            this.PresetBox.Size = new System.Drawing.Size(151, 28);
            this.PresetBox.TabIndex = 1;
            this.PresetBox.SelectedIndexChanged += new System.EventHandler(this.PresetBox_SelectedIndexChanged);
            // 
            // AttackTypeBox
            // 
            this.AttackTypeBox.FormattingEnabled = true;
            this.AttackTypeBox.Location = new System.Drawing.Point(12, 103);
            this.AttackTypeBox.Name = "AttackTypeBox";
            this.AttackTypeBox.Size = new System.Drawing.Size(151, 28);
            this.AttackTypeBox.TabIndex = 4;
            this.AttackTypeBox.SelectedIndexChanged += new System.EventHandler(this.AttackTypeBox_SelectedIndexChanged);
            // 
            // ArmorTypeBox
            // 
            this.ArmorTypeBox.FormattingEnabled = true;
            this.ArmorTypeBox.Location = new System.Drawing.Point(169, 103);
            this.ArmorTypeBox.Name = "ArmorTypeBox";
            this.ArmorTypeBox.Size = new System.Drawing.Size(151, 28);
            this.ArmorTypeBox.TabIndex = 5;
            this.ArmorTypeBox.SelectedIndexChanged += new System.EventHandler(this.ArmorTypeBox_SelectedIndexChanged);
            // 
            // totalDamageText
            // 
            this.totalDamageText.Location = new System.Drawing.Point(240, 210);
            this.totalDamageText.Name = "totalDamageText";
            this.totalDamageText.ReadOnly = true;
            this.totalDamageText.Size = new System.Drawing.Size(125, 27);
            this.totalDamageText.TabIndex = 9;
            // 
            // ArmorValueBox
            // 
            this.ArmorValueBox.Location = new System.Drawing.Point(169, 157);
            this.ArmorValueBox.Name = "ArmorValueBox";
            this.ArmorValueBox.Size = new System.Drawing.Size(151, 27);
            this.ArmorValueBox.TabIndex = 10;
            this.ArmorValueBox.TextChanged += new System.EventHandler(this.ArmorValueBox_TextChanged);
            // 
            // AttackValueBox
            // 
            this.AttackValueBox.Location = new System.Drawing.Point(12, 157);
            this.AttackValueBox.Name = "AttackValueBox";
            this.AttackValueBox.Size = new System.Drawing.Size(151, 27);
            this.AttackValueBox.TabIndex = 11;
            this.AttackValueBox.TextChanged += new System.EventHandler(this.AttackValueBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 245);
            this.Controls.Add(this.AttackValueBox);
            this.Controls.Add(this.ArmorValueBox);
            this.Controls.Add(this.totalDamageText);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.ArmorTypeBox);
            this.Controls.Add(this.AttackTypeBox);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.PresetBox);
            this.Controls.Add(CalculatePresetLabel);
            this.Name = "MainForm";
            this.Text = "Damage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource mainFormBindingSource;
        private ComboBox PresetBox;
        private ComboBox AttackTypeBox;
        private ComboBox ArmorTypeBox;
        private TextBox totalDamageText;
        private TextBox ArmorValueBox;
        private TextBox AttackValueBox;
    }
}