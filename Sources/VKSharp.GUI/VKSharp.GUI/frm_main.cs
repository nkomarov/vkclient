using System;
using System.IO;
using System.Windows.Forms;
using VKSharp;
using EpicMorg.Net;

namespace VKSharp.GUI {
    public partial class frm_main : Form {
        public frm_main() {
            InitializeComponent();
            CheckLoginState();
        }

        private void WhatIsChecked() {
            
            foreach ( int indexChecked in checkAudioList.CheckedIndices ) { 
                MessageBox.Show( "Index#: " + indexChecked.ToString() + ", is checked. Checked state is:" +
                                checkAudioList.GetItemCheckState( indexChecked ).ToString() + "." );
            }  
        }

        private void CheckLoginState() {
            if ( txtToken.Text == String.Empty ) {
                gbAudiolist.Enabled = false;
                gbSaveTo.Enabled = false;
            }
            else {
                gbAudiolist.Enabled = true;
                gbSaveTo.Enabled = true;
            } 
        }
        private void SaveToFolder() {
          
            if ( dlgSaveTo.ShowDialog() == DialogResult.OK ) {
                string folder = dlgSaveTo.SelectedPath;
                txtSavePath.Text = folder; 
            } 
        }

        private void btnSelectAll_Click( object sender, EventArgs e ) {
            try {
                for ( int i = 0; i < checkAudioList.Items.Count; i++ )
                    checkAudioList.SetItemChecked( i, true );
            }
            catch { MessageBox.Show("Error " + e);}
        }

        private void checkAudioList_SelectedIndexChanged( object sender, EventArgs e ) {
          //  WhatIsChecked(); //debug
        }

        private void btnSelectNone_Click( object sender, EventArgs e ) { 
            try {
                for ( int i = 0; i < checkAudioList.Items.Count; i++ )
                    checkAudioList.SetItemChecked( i, false );
            }
            catch { MessageBox.Show("Error " + e);}
        }

        private void btnLogin_Click( object sender, EventArgs e ) { 
            CheckLoginState();
            try {

                gbLogin.Enabled = false; //do it after succesfull login
            }
            catch { MessageBox.Show( "Error " + e ); }
        }

       
        private void btnBrowse_Click( object sender, EventArgs e ) {
            SaveToFolder();
        }

        private void btnDownStart_Click( object sender, EventArgs e ) {
            try {
                  if (txtSavePath.Text == String.Empty) { SaveToFolder(); }
                  else
                  {}
                } 
            catch { MessageBox.Show( "Error " + e ); }
        }

        
    }
}
