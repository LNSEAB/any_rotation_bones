using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace any_rotation_bones_plugin
{
    public class main_class :
        PEPlugin.PEPluginClass
    {
        private const string caption_ = "任意中心回転ボーン生成";

        public main_class() :
            base()
        {
            this.m_option = new PEPlugin.PEPluginOption( false, true, caption_ );
        }

        private void set_append_translation(PEPlugin.Pmx.IPXBone target, PEPlugin.Pmx.IPXBone parent, float ratio)
        {
            target.IsAppendTranslation = true;
            target.AppendParent = parent;
            target.AppendRatio = ratio;
        }

        private PEPlugin.Pmx.IPXBone make_translatable_bone(string name, PEPlugin.SDX.V3 pos)
        {
            PEPlugin.Pmx.IPXBone bone = PEPlugin.PEStaticBuilder.Pmx.Bone();

            bone.Name = name;
            bone.Position = pos.Clone();
            bone.IsRotation = true;
            bone.IsTranslation = true;
            bone.IsIK = false;
            bone.Controllable = true;
            bone.Visible = true;

            return bone;
        }

        private PEPlugin.Pmx.IPXNodeItem make_bone_node_item(PEPlugin.Pmx.IPXBone bone)
        {
            PEPlugin.Pmx.IPXNodeItem item = PEPlugin.PEStaticBuilder.Pmx.BoneNodeItem();

            item.BoneItem.Bone = bone;

            return item;
        }

        private PEPlugin.SDX.V3 get_position(PEPlugin.Pmx.IPXPmx pmx, plugin_form form)
        { 
            if ( form.target_pos_radio_box.Checked ) {
                return pmx.Bone[form.target_bone_box.SelectedIndex].Position;
            }
            if ( form.selected_bone_pos_radio_box.Checked ) {
                return pmx.Bone[form.selected_bone_pos_combo_box.SelectedIndex].Position;
            }

            return new PEPlugin.SDX.V3( 0, 0, 0 );
        }

        private PEPlugin.Pmx.IPXBone make_rotation_bone(
            PEPlugin.Pmx.IPXPmx pmx, PEPlugin.Pmx.IPXNode node, PEPlugin.Pmx.IPXBone target_bone, PEPlugin.SDX.V3 pos,
            plugin_form form, int index
        ) {
            var bone = make_translatable_bone( form.any_rotation_name_box.Text + index.ToString(), pos );
            pmx.Bone.Insert( form.target_bone_box.SelectedIndex, bone );

            PEPlugin.Pmx.IPXBone parent = null;

            if ( index == 1 && form.begin_rotation_check_box.Checked ) {
                parent = target_bone.Parent;
            }
            else {
                parent = make_parent_bone( pmx, node, target_bone, pos, form, index - 1 );
            }

            bone.Parent = parent;
            node.Items.Add( make_bone_node_item( bone ) );

            return bone;
        }

        private PEPlugin.Pmx.IPXBone make_parent_bone(
            PEPlugin.Pmx.IPXPmx pmx, PEPlugin.Pmx.IPXNode node, PEPlugin.Pmx.IPXBone target_bone, PEPlugin.SDX.V3 pos,
            plugin_form form, int index
        ) {
            var bone = make_translatable_bone( form.parent_bone_name_box.Text + index.ToString(), pos );
            pmx.Bone.Insert( form.target_bone_box.SelectedIndex, bone );

            PEPlugin.Pmx.IPXBone parent = null;

            if ( index == 0 ) {
                parent = target_bone.Parent;
            }
            else {
                parent = make_rotation_bone( pmx, node, target_bone, pos, form, index );
                set_append_translation( bone, parent, -1.0f );
            }

            bone.Parent = parent;
            node.Items.Add( make_bone_node_item( bone ) );

            return bone;
        }

        private void make(PEPlugin.Pmx.IPXPmx pmx, PEPlugin.Pmx.IPXNode node, plugin_form form)
        {
            string parent_name = form.parent_bone_name_box.Text;
            string rotation_name = form.any_rotation_name_box.Text;
            int n = (int)form.bones_num_box.Value;
            int index = form.target_bone_box.SelectedIndex;
            PEPlugin.SDX.V3 pos = get_position( pmx, form );

            if ( form.last_bone_check_box.Checked ) {
                var bone = pmx.Bone[form.target_bone_box.SelectedIndex];
                var parent = make_rotation_bone( pmx, node, bone, pos, form, n );

                bone.Parent = parent;
                set_append_translation( bone, parent, -1.0f );
            }
            else {
                var bone = pmx.Bone[form.target_bone_box.SelectedIndex];
                var parent = make_parent_bone( pmx, node, bone, pos, form, n );

                bone.Parent = parent;
            }
        }

        private void make_edge_bone(PEPlugin.Pmx.IPXPmx pmx, PEPlugin.Pmx.IPXNode node, plugin_form form)
        {
            var bone = make_translatable_bone( form.edge_bone_name_box.Text, new PEPlugin.SDX.V3( 0, 0, 0 ) );

            bone.Parent = form.zero_parent_check_box.Checked ? pmx.Bone[0] : null;

            pmx.Bone.Insert( 1, bone );
            node.Items.Insert( 0, make_bone_node_item( bone ) );
        }

        public override void Run(PEPlugin.IPERunArgs args)
        {
            base.Run( args );

            PEPlugin.Pmx.IPXPmx pmx = args.Host.Connector.Pmx.GetCurrentState();
            plugin_form form = new plugin_form( pmx );

            try {
                if ( form.ShowDialog() == DialogResult.Cancel ) {
                    return;
                }
            
                PEPlugin.Pmx.IPXNode node = PEPlugin.PEStaticBuilder.Pmx.Node();

                make( pmx, node, form );

                if ( form.edge_check_box.Checked ) {
                    make_edge_bone( pmx, node, form );
                }
            
                pmx.Node.Insert( 2, node );

                args.Host.Connector.Pmx.Update( pmx );
                args.Host.Connector.Form.UpdateList( PEPlugin.Pmd.UpdateObject.All );
                args.Host.Connector.View.PmxView.UpdateModel();
            }
            catch ( System.Exception e ) {
                MessageBox.Show( e.Message, caption_, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            finally {
                form.Dispose();
            }
        }
    }
}
