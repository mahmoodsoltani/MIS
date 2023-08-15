using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cs_Component {
	public class RPFFixedSectionTrackerControl : Cs_Component.RPFSectionTrackerControl {
		private System.ComponentModel.IContainer components = null;

		public RPFFixedSectionTrackerControl() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

		}
		public RPFFixedSectionTrackerControl( RPFFixedSection rpf_object): base( rpf_object){
			InitializeComponent();
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
		}
		#endregion
	}
}

