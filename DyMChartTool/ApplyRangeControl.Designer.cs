﻿
namespace DyMChartTool
{
    partial class ApplyRangeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.entireChartRadoButton = new System.Windows.Forms.RadioButton();
            this.timeRangeRadioButton = new System.Windows.Forms.RadioButton();
            this.timeRangeStartNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeRangeEndNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTrackCheckBox = new System.Windows.Forms.CheckBox();
            this.rightTrackCheckBox = new System.Windows.Forms.CheckBox();
            this.leftTrackCheckBox = new System.Windows.Forms.CheckBox();
            this.holdNoteCheckBox = new System.Windows.Forms.CheckBox();
            this.chainNoteCheckBox = new System.Windows.Forms.CheckBox();
            this.normalNoteCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeRangeStartNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRangeEndNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 99);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.timeRangeEndNumericUpDown);
            this.groupBox1.Controls.Add(this.timeRangeStartNumericUpDown);
            this.groupBox1.Controls.Add(this.timeRangeRadioButton);
            this.groupBox1.Controls.Add(this.entireChartRadoButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.leftTrackCheckBox);
            this.groupBox2.Controls.Add(this.rightTrackCheckBox);
            this.groupBox2.Controls.Add(this.mainTrackCheckBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(255, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tracks";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.holdNoteCheckBox);
            this.groupBox3.Controls.Add(this.normalNoteCheckBox);
            this.groupBox3.Controls.Add(this.chainNoteCheckBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(506, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 93);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notes";
            // 
            // entireChartRadoButton
            // 
            this.entireChartRadoButton.AutoSize = true;
            this.entireChartRadoButton.Checked = true;
            this.entireChartRadoButton.Location = new System.Drawing.Point(6, 19);
            this.entireChartRadoButton.Name = "entireChartRadoButton";
            this.entireChartRadoButton.Size = new System.Drawing.Size(79, 17);
            this.entireChartRadoButton.TabIndex = 0;
            this.entireChartRadoButton.TabStop = true;
            this.entireChartRadoButton.Text = "Entire chart";
            this.entireChartRadoButton.UseVisualStyleBackColor = true;
            // 
            // timeRangeRadioButton
            // 
            this.timeRangeRadioButton.AutoSize = true;
            this.timeRangeRadioButton.Location = new System.Drawing.Point(6, 42);
            this.timeRangeRadioButton.Name = "timeRangeRadioButton";
            this.timeRangeRadioButton.Size = new System.Drawing.Size(78, 17);
            this.timeRangeRadioButton.TabIndex = 1;
            this.timeRangeRadioButton.TabStop = true;
            this.timeRangeRadioButton.Text = "Time range";
            this.timeRangeRadioButton.UseVisualStyleBackColor = true;
            // 
            // timeRangeStartNumericUpDown
            // 
            this.timeRangeStartNumericUpDown.DecimalPlaces = 5;
            this.timeRangeStartNumericUpDown.Enabled = false;
            this.timeRangeStartNumericUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.timeRangeStartNumericUpDown.Location = new System.Drawing.Point(6, 65);
            this.timeRangeStartNumericUpDown.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.timeRangeStartNumericUpDown.Name = "timeRangeStartNumericUpDown";
            this.timeRangeStartNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.timeRangeStartNumericUpDown.TabIndex = 3;
            // 
            // timeRangeEndNumericUpDown
            // 
            this.timeRangeEndNumericUpDown.DecimalPlaces = 5;
            this.timeRangeEndNumericUpDown.Enabled = false;
            this.timeRangeEndNumericUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.timeRangeEndNumericUpDown.Location = new System.Drawing.Point(99, 65);
            this.timeRangeEndNumericUpDown.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.timeRangeEndNumericUpDown.Name = "timeRangeEndNumericUpDown";
            this.timeRangeEndNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.timeRangeEndNumericUpDown.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "~";
            // 
            // mainTrackCheckBox
            // 
            this.mainTrackCheckBox.AutoSize = true;
            this.mainTrackCheckBox.Checked = true;
            this.mainTrackCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mainTrackCheckBox.Location = new System.Drawing.Point(6, 20);
            this.mainTrackCheckBox.Name = "mainTrackCheckBox";
            this.mainTrackCheckBox.Size = new System.Drawing.Size(49, 17);
            this.mainTrackCheckBox.TabIndex = 0;
            this.mainTrackCheckBox.Text = "Main";
            this.mainTrackCheckBox.UseVisualStyleBackColor = true;
            // 
            // rightTrackCheckBox
            // 
            this.rightTrackCheckBox.AutoSize = true;
            this.rightTrackCheckBox.Checked = true;
            this.rightTrackCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rightTrackCheckBox.Location = new System.Drawing.Point(6, 66);
            this.rightTrackCheckBox.Name = "rightTrackCheckBox";
            this.rightTrackCheckBox.Size = new System.Drawing.Size(51, 17);
            this.rightTrackCheckBox.TabIndex = 1;
            this.rightTrackCheckBox.Text = "Right";
            this.rightTrackCheckBox.UseVisualStyleBackColor = true;
            // 
            // leftTrackCheckBox
            // 
            this.leftTrackCheckBox.AutoSize = true;
            this.leftTrackCheckBox.Checked = true;
            this.leftTrackCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.leftTrackCheckBox.Location = new System.Drawing.Point(6, 43);
            this.leftTrackCheckBox.Name = "leftTrackCheckBox";
            this.leftTrackCheckBox.Size = new System.Drawing.Size(44, 17);
            this.leftTrackCheckBox.TabIndex = 2;
            this.leftTrackCheckBox.Text = "Left";
            this.leftTrackCheckBox.UseVisualStyleBackColor = true;
            // 
            // holdNoteCheckBox
            // 
            this.holdNoteCheckBox.AutoSize = true;
            this.holdNoteCheckBox.Checked = true;
            this.holdNoteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.holdNoteCheckBox.Location = new System.Drawing.Point(6, 43);
            this.holdNoteCheckBox.Name = "holdNoteCheckBox";
            this.holdNoteCheckBox.Size = new System.Drawing.Size(48, 17);
            this.holdNoteCheckBox.TabIndex = 5;
            this.holdNoteCheckBox.Text = "Hold";
            this.holdNoteCheckBox.UseVisualStyleBackColor = true;
            // 
            // chainNoteCheckBox
            // 
            this.chainNoteCheckBox.AutoSize = true;
            this.chainNoteCheckBox.Checked = true;
            this.chainNoteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chainNoteCheckBox.Location = new System.Drawing.Point(6, 66);
            this.chainNoteCheckBox.Name = "chainNoteCheckBox";
            this.chainNoteCheckBox.Size = new System.Drawing.Size(53, 17);
            this.chainNoteCheckBox.TabIndex = 4;
            this.chainNoteCheckBox.Text = "Chain";
            this.chainNoteCheckBox.UseVisualStyleBackColor = true;
            // 
            // normalNoteCheckBox
            // 
            this.normalNoteCheckBox.AutoSize = true;
            this.normalNoteCheckBox.Checked = true;
            this.normalNoteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normalNoteCheckBox.Location = new System.Drawing.Point(6, 20);
            this.normalNoteCheckBox.Name = "normalNoteCheckBox";
            this.normalNoteCheckBox.Size = new System.Drawing.Size(59, 17);
            this.normalNoteCheckBox.TabIndex = 3;
            this.normalNoteCheckBox.Text = "Normal";
            this.normalNoteCheckBox.UseVisualStyleBackColor = true;
            // 
            // ApplyRangeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ApplyRangeControl";
            this.Size = new System.Drawing.Size(756, 99);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeRangeStartNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRangeEndNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton timeRangeRadioButton;
        private System.Windows.Forms.RadioButton entireChartRadoButton;
        private System.Windows.Forms.CheckBox leftTrackCheckBox;
        private System.Windows.Forms.CheckBox rightTrackCheckBox;
        private System.Windows.Forms.CheckBox mainTrackCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown timeRangeEndNumericUpDown;
        private System.Windows.Forms.NumericUpDown timeRangeStartNumericUpDown;
        private System.Windows.Forms.CheckBox holdNoteCheckBox;
        private System.Windows.Forms.CheckBox normalNoteCheckBox;
        private System.Windows.Forms.CheckBox chainNoteCheckBox;
    }
}