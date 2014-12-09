using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace any_rotation_bones_plugin
{
    public partial class plugin_form : Form
    {
        private PEPlugin.Pmx.IPXPmx pmx_;
        
        public plugin_form(PEPlugin.Pmx.IPXPmx pmx)
        {
            InitializeComponent();

            pmx_ = pmx;
        }

        private void edge_check_box_CheckedChanged(object sender, EventArgs e)
        {
            if ( edge_check_box.Checked == true ) {
                zero_parent_check_box.Enabled = true;
                edge_bone_name_box.Enabled = true;
            }
            else {
                zero_parent_check_box.Enabled = false;
                edge_bone_name_box.Enabled = false;
            }
        }

        private void target_bone_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( target_bone_box.SelectedIndex == 0 ) {
                last_bone_check_box.Enabled = false;
                last_bone_check_box.Enabled = false;
            }
            else {
                last_bone_check_box.Enabled = true;
                last_bone_check_box.Enabled = true;
            }
        }

        private void plugin_form_Shown(object sender, EventArgs e)
        {
            foreach ( var i in pmx_.Bone.Select( (value, index) => new { value, index } ) ) {
                target_bone_box.Items.Add( i.value.Name );
                if ( i.value.Name == "全ての親" ) {
                    target_bone_box.SelectedIndex = i.index;
                }
            }

            if ( target_bone_box.SelectedIndex == -1 && pmx_.Bone.Count > 0 ) {
                target_bone_box.SelectedIndex = 0;
            }

            foreach ( var i in target_bone_box.Items ) {
                selected_bone_pos_combo_box.Items.Add( i );
            }

            if ( selected_bone_pos_combo_box.SelectedIndex == -1 && pmx_.Bone.Count > 0 ) {
                selected_bone_pos_combo_box.SelectedIndex = 0;
            }

            edge_check_box_CheckedChanged( sender, e );
            target_bone_box_SelectedIndexChanged( sender, e );
            selected_bone_pos_radio_box_CheckedChanged( sender, e );
        }

        private void selected_bone_pos_radio_box_CheckedChanged(object sender, EventArgs e)
        {
            if ( selected_bone_pos_radio_box.Checked == true ) {
                selected_bone_pos_combo_box.Enabled = true;
            }
            else {
                selected_bone_pos_combo_box.Enabled = false;
            }
        }
    }
}
