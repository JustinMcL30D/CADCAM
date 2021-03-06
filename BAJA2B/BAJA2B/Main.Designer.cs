﻿namespace BAJA2B
{
    partial class Main
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
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_wheelbase = new System.Windows.Forms.TrackBar();
            this.tb_frame_width = new System.Windows.Forms.TrackBar();
            this.tb_frame_height = new System.Windows.Forms.TrackBar();
            this.tb_ground_clearance = new System.Windows.Forms.TrackBar();
            this.tb_steering_ratio = new System.Windows.Forms.TrackBar();
            this.box_mass = new System.Windows.Forms.TextBox();
            this.units = new System.Windows.Forms.DomainUpDown();
            this.box_wheelbase = new System.Windows.Forms.TextBox();
            this.box_frame_width = new System.Windows.Forms.TextBox();
            this.box_frame_height = new System.Windows.Forms.TextBox();
            this.box_ground_clearance = new System.Windows.Forms.TextBox();
            this.box_steering_ratio = new System.Windows.Forms.TextBox();
            this.cb_ANSYS_script = new System.Windows.Forms.CheckBox();
            this.tb_damping_ratio = new System.Windows.Forms.TrackBar();
            this.tn_rear_omegan = new System.Windows.Forms.TrackBar();
            this.tb_front_omegan = new System.Windows.Forms.TrackBar();
            this.box_damping_ratio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_wheelbase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_frame_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_frame_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ground_clearance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_steering_ratio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_damping_ratio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tn_rear_omegan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_front_omegan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(287, 393);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(125, 42);
            this.btn_generate.TabIndex = 0;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(418, 393);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(125, 42);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wheelbase (mm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frame Width (mm)";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Frame Height (mm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ground Clearance (mm)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Steering Ratio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mass of Driver";
            // 
            // tb_wheelbase
            // 
            this.tb_wheelbase.BackColor = System.Drawing.SystemColors.Control;
            this.tb_wheelbase.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_wheelbase.LargeChange = 100;
            this.tb_wheelbase.Location = new System.Drawing.Point(12, 39);
            this.tb_wheelbase.Maximum = 2500;
            this.tb_wheelbase.Minimum = 1624;
            this.tb_wheelbase.Name = "tb_wheelbase";
            this.tb_wheelbase.Size = new System.Drawing.Size(200, 45);
            this.tb_wheelbase.SmallChange = 20;
            this.tb_wheelbase.TabIndex = 8;
            this.tb_wheelbase.Value = 1624;
            this.tb_wheelbase.Scroll += new System.EventHandler(this.tb_wheelbase_Scroll);
            // 
            // tb_frame_width
            // 
            this.tb_frame_width.Location = new System.Drawing.Point(12, 103);
            this.tb_frame_width.Maximum = 1221;
            this.tb_frame_width.Minimum = 914;
            this.tb_frame_width.Name = "tb_frame_width";
            this.tb_frame_width.Size = new System.Drawing.Size(200, 45);
            this.tb_frame_width.TabIndex = 9;
            this.tb_frame_width.Value = 914;
            this.tb_frame_width.Scroll += new System.EventHandler(this.tb_frame_width_Scroll);
            // 
            // tb_frame_height
            // 
            this.tb_frame_height.Location = new System.Drawing.Point(12, 167);
            this.tb_frame_height.Maximum = 1501;
            this.tb_frame_height.Minimum = 1219;
            this.tb_frame_height.Name = "tb_frame_height";
            this.tb_frame_height.Size = new System.Drawing.Size(200, 45);
            this.tb_frame_height.TabIndex = 10;
            this.tb_frame_height.Value = 1219;
            this.tb_frame_height.Scroll += new System.EventHandler(this.tb_frame_height_Scroll);
            // 
            // tb_ground_clearance
            // 
            this.tb_ground_clearance.Location = new System.Drawing.Point(12, 243);
            this.tb_ground_clearance.Maximum = 350;
            this.tb_ground_clearance.Minimum = 152;
            this.tb_ground_clearance.Name = "tb_ground_clearance";
            this.tb_ground_clearance.Size = new System.Drawing.Size(200, 45);
            this.tb_ground_clearance.TabIndex = 11;
            this.tb_ground_clearance.Value = 252;
            this.tb_ground_clearance.Scroll += new System.EventHandler(this.tb_ground_clearance_Scroll);
            // 
            // tb_steering_ratio
            // 
            this.tb_steering_ratio.Location = new System.Drawing.Point(13, 309);
            this.tb_steering_ratio.Maximum = 5;
            this.tb_steering_ratio.Minimum = 1;
            this.tb_steering_ratio.Name = "tb_steering_ratio";
            this.tb_steering_ratio.Size = new System.Drawing.Size(200, 45);
            this.tb_steering_ratio.TabIndex = 12;
            this.tb_steering_ratio.Value = 4;
            this.tb_steering_ratio.Scroll += new System.EventHandler(this.tb_steering_ratio_Scroll);
            // 
            // box_mass
            // 
            this.box_mass.Location = new System.Drawing.Point(27, 381);
            this.box_mass.Name = "box_mass";
            this.box_mass.Size = new System.Drawing.Size(44, 20);
            this.box_mass.TabIndex = 13;
            this.box_mass.Text = "250";
            // 
            // units
            // 
            this.units.Items.Add("lbs");
            this.units.Items.Add("kg");
            this.units.Location = new System.Drawing.Point(92, 381);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(120, 20);
            this.units.TabIndex = 14;
            this.units.Text = "lbs";
            // 
            // box_wheelbase
            // 
            this.box_wheelbase.Location = new System.Drawing.Point(218, 39);
            this.box_wheelbase.Name = "box_wheelbase";
            this.box_wheelbase.Size = new System.Drawing.Size(44, 20);
            this.box_wheelbase.TabIndex = 16;
            this.box_wheelbase.Tag = "";
            this.box_wheelbase.Text = "1624";
            this.box_wheelbase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_wheelbase_KeyPress);
            this.box_wheelbase.Leave += new System.EventHandler(this.box_wheelbase_Leave);
            // 
            // box_frame_width
            // 
            this.box_frame_width.Location = new System.Drawing.Point(218, 103);
            this.box_frame_width.Name = "box_frame_width";
            this.box_frame_width.Size = new System.Drawing.Size(44, 20);
            this.box_frame_width.TabIndex = 17;
            this.box_frame_width.Text = "914";
            this.box_frame_width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_frame_width_KeyPress);
            this.box_frame_width.Leave += new System.EventHandler(this.box_frame_width_Leave);
            // 
            // box_frame_height
            // 
            this.box_frame_height.Location = new System.Drawing.Point(218, 167);
            this.box_frame_height.Name = "box_frame_height";
            this.box_frame_height.Size = new System.Drawing.Size(44, 20);
            this.box_frame_height.TabIndex = 18;
            this.box_frame_height.Text = "1219";
            this.box_frame_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_frame_height_KeyPress);
            this.box_frame_height.Leave += new System.EventHandler(this.box_frame_height_Leave);
            // 
            // box_ground_clearance
            // 
            this.box_ground_clearance.Location = new System.Drawing.Point(218, 243);
            this.box_ground_clearance.Name = "box_ground_clearance";
            this.box_ground_clearance.Size = new System.Drawing.Size(44, 20);
            this.box_ground_clearance.TabIndex = 19;
            this.box_ground_clearance.Text = "252";
            this.box_ground_clearance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_ground_clearance_KeyPress);
            this.box_ground_clearance.Leave += new System.EventHandler(this.box_ground_clearance_Leave);
            // 
            // box_steering_ratio
            // 
            this.box_steering_ratio.Location = new System.Drawing.Point(218, 309);
            this.box_steering_ratio.Name = "box_steering_ratio";
            this.box_steering_ratio.Size = new System.Drawing.Size(44, 20);
            this.box_steering_ratio.TabIndex = 20;
            this.box_steering_ratio.Text = "4";
            this.box_steering_ratio.Leave += new System.EventHandler(this.box_steering_ratio_Leave);
            // 
            // cb_ANSYS_script
            // 
            this.cb_ANSYS_script.AutoSize = true;
            this.cb_ANSYS_script.Location = new System.Drawing.Point(27, 418);
            this.cb_ANSYS_script.Name = "cb_ANSYS_script";
            this.cb_ANSYS_script.Size = new System.Drawing.Size(245, 17);
            this.cb_ANSYS_script.TabIndex = 21;
            this.cb_ANSYS_script.Text = "Generate 3D ANSYS Mechanical APDL Script";
            this.cb_ANSYS_script.UseVisualStyleBackColor = true;
            this.cb_ANSYS_script.CheckedChanged += new System.EventHandler(this.cb_ANSYS_script_CheckedChanged);
            // 
            // tb_damping_ratio
            // 
            this.tb_damping_ratio.Location = new System.Drawing.Point(287, 309);
            this.tb_damping_ratio.Maximum = 1000;
            this.tb_damping_ratio.Name = "tb_damping_ratio";
            this.tb_damping_ratio.Size = new System.Drawing.Size(200, 45);
            this.tb_damping_ratio.TabIndex = 22;
            this.tb_damping_ratio.Value = 707;
            this.tb_damping_ratio.Scroll += new System.EventHandler(this.tb_damping_ratio_Scroll);
            // 
            // tn_rear_omegan
            // 
            this.tn_rear_omegan.Location = new System.Drawing.Point(287, 243);
            this.tn_rear_omegan.Maximum = 30;
            this.tn_rear_omegan.Minimum = 5;
            this.tn_rear_omegan.Name = "tn_rear_omegan";
            this.tn_rear_omegan.Size = new System.Drawing.Size(200, 45);
            this.tn_rear_omegan.TabIndex = 1;
            this.tn_rear_omegan.Value = 17;
            // 
            // tb_front_omegan
            // 
            this.tb_front_omegan.Location = new System.Drawing.Point(287, 167);
            this.tb_front_omegan.Maximum = 30;
            this.tb_front_omegan.Minimum = 5;
            this.tb_front_omegan.Name = "tb_front_omegan";
            this.tb_front_omegan.Size = new System.Drawing.Size(200, 45);
            this.tb_front_omegan.TabIndex = 24;
            this.tb_front_omegan.Value = 15;
            // 
            // box_damping_ratio
            // 
            this.box_damping_ratio.Location = new System.Drawing.Point(494, 309);
            this.box_damping_ratio.Name = "box_damping_ratio";
            this.box_damping_ratio.Size = new System.Drawing.Size(44, 20);
            this.box_damping_ratio.TabIndex = 25;
            this.box_damping_ratio.Text = "0.707";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Damping Ratio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Desired Rear Natural Frequency (Hz)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(494, 243);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "1.7";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(494, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 20);
            this.textBox2.TabIndex = 29;
            this.textBox2.Text = "1.5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Desired Front Natural Frequency (Hz)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 447);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.box_damping_ratio);
            this.Controls.Add(this.tb_front_omegan);
            this.Controls.Add(this.tn_rear_omegan);
            this.Controls.Add(this.tb_damping_ratio);
            this.Controls.Add(this.cb_ANSYS_script);
            this.Controls.Add(this.box_steering_ratio);
            this.Controls.Add(this.box_ground_clearance);
            this.Controls.Add(this.box_frame_height);
            this.Controls.Add(this.box_frame_width);
            this.Controls.Add(this.box_wheelbase);
            this.Controls.Add(this.units);
            this.Controls.Add(this.box_mass);
            this.Controls.Add(this.tb_steering_ratio);
            this.Controls.Add(this.tb_ground_clearance);
            this.Controls.Add(this.tb_frame_height);
            this.Controls.Add(this.tb_frame_width);
            this.Controls.Add(this.tb_wheelbase);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_generate);
            this.Name = "Main";
            this.Text = "Fluent Design - CADCAM 2017";
            ((System.ComponentModel.ISupportInitialize)(this.tb_wheelbase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_frame_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_frame_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ground_clearance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_steering_ratio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_damping_ratio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tn_rear_omegan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_front_omegan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar tb_wheelbase;
        private System.Windows.Forms.TrackBar tb_frame_width;
        private System.Windows.Forms.TrackBar tb_frame_height;
        private System.Windows.Forms.TrackBar tb_ground_clearance;
        private System.Windows.Forms.TrackBar tb_steering_ratio;
        private System.Windows.Forms.TextBox box_mass;
        private System.Windows.Forms.DomainUpDown units;
        private System.Windows.Forms.TextBox box_wheelbase;
        private System.Windows.Forms.TextBox box_frame_width;
        private System.Windows.Forms.TextBox box_frame_height;
        private System.Windows.Forms.TextBox box_ground_clearance;
        private System.Windows.Forms.TextBox box_steering_ratio;
        private System.Windows.Forms.CheckBox cb_ANSYS_script;
        private System.Windows.Forms.TrackBar tb_damping_ratio;
        private System.Windows.Forms.TrackBar tn_rear_omegan;
        private System.Windows.Forms.TrackBar tb_front_omegan;
        private System.Windows.Forms.TextBox box_damping_ratio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
    }
}

