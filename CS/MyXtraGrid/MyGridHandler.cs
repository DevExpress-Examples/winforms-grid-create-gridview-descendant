using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace MyXtraGrid {
	public class MyGridHandler : DevExpress.XtraGrid.Views.Grid.Handler.GridHandler {
		public MyGridHandler(GridView gridView) : base(gridView) {}

		protected override void OnKeyDown(KeyEventArgs e) {
			base.OnKeyDown(e);
			if(e.KeyData == Keys.Delete && View.State == GridState.Normal)
				View.DeleteRow(View.FocusedRowHandle);
		}
	}
}
