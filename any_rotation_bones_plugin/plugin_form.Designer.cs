namespace any_rotation_bones_plugin
{
    partial class plugin_form
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
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bones_num_box = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.target_bone_box = new System.Windows.Forms.ComboBox();
            this.edge_check_box = new System.Windows.Forms.CheckBox();
            this.zero_parent_check_box = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.any_rotation_name_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.parent_bone_name_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.node_name_box = new System.Windows.Forms.TextBox();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.last_bone_check_box = new System.Windows.Forms.CheckBox();
            this.begin_rotation_check_box = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edge_bone_name_box = new System.Windows.Forms.TextBox();
            this.target_pos_radio_box = new System.Windows.Forms.RadioButton();
            this.selected_bone_pos_radio_box = new System.Windows.Forms.RadioButton();
            this.selected_bone_pos_combo_box = new System.Windows.Forms.ComboBox();
            this.origin_pos_radio_box = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.bones_num_box)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "段数";
            // 
            // bones_num_box
            // 
            this.bones_num_box.Location = new System.Drawing.Point(66, 18);
            this.bones_num_box.Maximum = new decimal(new int[] {
            65532,
            0,
            0,
            0});
            this.bones_num_box.Name = "bones_num_box";
            this.bones_num_box.Size = new System.Drawing.Size(175, 19);
            this.bones_num_box.TabIndex = 1;
            this.bones_num_box.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "ターゲット";
            // 
            // target_bone_box
            // 
            this.target_bone_box.FormattingEnabled = true;
            this.target_bone_box.Location = new System.Drawing.Point(66, 43);
            this.target_bone_box.Name = "target_bone_box";
            this.target_bone_box.Size = new System.Drawing.Size(175, 20);
            this.target_bone_box.TabIndex = 3;
            // 
            // edge_check_box
            // 
            this.edge_check_box.AutoSize = true;
            this.edge_check_box.Location = new System.Drawing.Point(15, 180);
            this.edge_check_box.Name = "edge_check_box";
            this.edge_check_box.Size = new System.Drawing.Size(137, 16);
            this.edge_check_box.TabIndex = 8;
            this.edge_check_box.Text = "エッジ調整ボーンの生成";
            this.edge_check_box.UseVisualStyleBackColor = true;
            this.edge_check_box.CheckedChanged += new System.EventHandler(this.edge_check_box_CheckedChanged);
            // 
            // zero_parent_check_box
            // 
            this.zero_parent_check_box.AutoSize = true;
            this.zero_parent_check_box.Checked = true;
            this.zero_parent_check_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zero_parent_check_box.Location = new System.Drawing.Point(32, 202);
            this.zero_parent_check_box.Name = "zero_parent_check_box";
            this.zero_parent_check_box.Size = new System.Drawing.Size(120, 16);
            this.zero_parent_check_box.TabIndex = 9;
            this.zero_parent_check_box.Text = "0番ボーンを親にする";
            this.zero_parent_check_box.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "任意中心回転ボーン名";
            // 
            // any_rotation_name_box
            // 
            this.any_rotation_name_box.Location = new System.Drawing.Point(15, 297);
            this.any_rotation_name_box.Name = "any_rotation_name_box";
            this.any_rotation_name_box.Size = new System.Drawing.Size(229, 19);
            this.any_rotation_name_box.TabIndex = 13;
            this.any_rotation_name_box.Text = "任意中心回転";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "親ボーン名";
            // 
            // parent_bone_name_box
            // 
            this.parent_bone_name_box.Location = new System.Drawing.Point(15, 334);
            this.parent_bone_name_box.Name = "parent_bone_name_box";
            this.parent_bone_name_box.Size = new System.Drawing.Size(229, 19);
            this.parent_bone_name_box.TabIndex = 15;
            this.parent_bone_name_box.Text = "親";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "表示枠名";
            // 
            // node_name_box
            // 
            this.node_name_box.Location = new System.Drawing.Point(15, 415);
            this.node_name_box.Name = "node_name_box";
            this.node_name_box.Size = new System.Drawing.Size(229, 19);
            this.node_name_box.TabIndex = 19;
            this.node_name_box.Text = "任意中心回転";
            // 
            // ok_button
            // 
            this.ok_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_button.Location = new System.Drawing.Point(89, 456);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 20;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(171, 456);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 21;
            this.cancel_button.Text = "キャンセル";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // last_bone_check_box
            // 
            this.last_bone_check_box.AutoSize = true;
            this.last_bone_check_box.Location = new System.Drawing.Point(15, 224);
            this.last_bone_check_box.Name = "last_bone_check_box";
            this.last_bone_check_box.Size = new System.Drawing.Size(179, 16);
            this.last_bone_check_box.TabIndex = 10;
            this.last_bone_check_box.Text = "ターゲットを最後の親ボーンにする";
            this.last_bone_check_box.UseVisualStyleBackColor = true;
            // 
            // begin_rotation_check_box
            // 
            this.begin_rotation_check_box.AutoSize = true;
            this.begin_rotation_check_box.Location = new System.Drawing.Point(15, 246);
            this.begin_rotation_check_box.Name = "begin_rotation_check_box";
            this.begin_rotation_check_box.Size = new System.Drawing.Size(167, 16);
            this.begin_rotation_check_box.TabIndex = 11;
            this.begin_rotation_check_box.Text = "任意中心回転ボーンから開始";
            this.begin_rotation_check_box.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "エッジ調整ボーン名";
            // 
            // edge_bone_name_box
            // 
            this.edge_bone_name_box.Location = new System.Drawing.Point(15, 371);
            this.edge_bone_name_box.Name = "edge_bone_name_box";
            this.edge_bone_name_box.Size = new System.Drawing.Size(229, 19);
            this.edge_bone_name_box.TabIndex = 17;
            this.edge_bone_name_box.Text = "エッジ調整";
            // 
            // target_pos_radio_box
            // 
            this.target_pos_radio_box.AutoSize = true;
            this.target_pos_radio_box.Checked = true;
            this.target_pos_radio_box.Location = new System.Drawing.Point(15, 103);
            this.target_pos_radio_box.Name = "target_pos_radio_box";
            this.target_pos_radio_box.Size = new System.Drawing.Size(152, 16);
            this.target_pos_radio_box.TabIndex = 5;
            this.target_pos_radio_box.TabStop = true;
            this.target_pos_radio_box.Text = "ターゲットと同じ位置に生成";
            this.target_pos_radio_box.UseVisualStyleBackColor = true;
            // 
            // selected_bone_pos_radio_box
            // 
            this.selected_bone_pos_radio_box.AutoSize = true;
            this.selected_bone_pos_radio_box.Location = new System.Drawing.Point(15, 125);
            this.selected_bone_pos_radio_box.Name = "selected_bone_pos_radio_box";
            this.selected_bone_pos_radio_box.Size = new System.Drawing.Size(161, 16);
            this.selected_bone_pos_radio_box.TabIndex = 6;
            this.selected_bone_pos_radio_box.Text = "指定したボーンの位置に生成";
            this.selected_bone_pos_radio_box.UseVisualStyleBackColor = true;
            this.selected_bone_pos_radio_box.CheckedChanged += new System.EventHandler(this.selected_bone_pos_radio_box_CheckedChanged);
            // 
            // selected_bone_pos_combo_box
            // 
            this.selected_bone_pos_combo_box.FormattingEnabled = true;
            this.selected_bone_pos_combo_box.Location = new System.Drawing.Point(28, 147);
            this.selected_bone_pos_combo_box.Name = "selected_bone_pos_combo_box";
            this.selected_bone_pos_combo_box.Size = new System.Drawing.Size(173, 20);
            this.selected_bone_pos_combo_box.TabIndex = 7;
            // 
            // origin_pos_radio_box
            // 
            this.origin_pos_radio_box.AutoSize = true;
            this.origin_pos_radio_box.Location = new System.Drawing.Point(14, 81);
            this.origin_pos_radio_box.Name = "origin_pos_radio_box";
            this.origin_pos_radio_box.Size = new System.Drawing.Size(80, 16);
            this.origin_pos_radio_box.TabIndex = 4;
            this.origin_pos_radio_box.TabStop = true;
            this.origin_pos_radio_box.Text = "原点に生成";
            this.origin_pos_radio_box.UseVisualStyleBackColor = true;
            // 
            // plugin_form
            // 
            this.AcceptButton = this.ok_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(258, 500);
            this.ControlBox = false;
            this.Controls.Add(this.origin_pos_radio_box);
            this.Controls.Add(this.selected_bone_pos_combo_box);
            this.Controls.Add(this.selected_bone_pos_radio_box);
            this.Controls.Add(this.target_pos_radio_box);
            this.Controls.Add(this.edge_bone_name_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.begin_rotation_check_box);
            this.Controls.Add(this.last_bone_check_box);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.node_name_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.parent_bone_name_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.any_rotation_name_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zero_parent_check_box);
            this.Controls.Add(this.edge_check_box);
            this.Controls.Add(this.target_bone_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bones_num_box);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "plugin_form";
            this.Text = "任意中心回転ボーン生成";
            this.Shown += new System.EventHandler(this.plugin_form_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bones_num_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        public System.Windows.Forms.NumericUpDown bones_num_box;
        public System.Windows.Forms.ComboBox target_bone_box;
        public System.Windows.Forms.CheckBox edge_check_box;
        public System.Windows.Forms.CheckBox zero_parent_check_box;
        public System.Windows.Forms.TextBox any_rotation_name_box;
        public System.Windows.Forms.TextBox parent_bone_name_box;
        public System.Windows.Forms.TextBox node_name_box;
        public System.Windows.Forms.CheckBox last_bone_check_box;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.CheckBox begin_rotation_check_box;
        public System.Windows.Forms.TextBox edge_bone_name_box;
        public System.Windows.Forms.RadioButton origin_pos_radio_box;
        public System.Windows.Forms.RadioButton target_pos_radio_box;
        public System.Windows.Forms.RadioButton selected_bone_pos_radio_box;
        public System.Windows.Forms.ComboBox selected_bone_pos_combo_box;
    }
}