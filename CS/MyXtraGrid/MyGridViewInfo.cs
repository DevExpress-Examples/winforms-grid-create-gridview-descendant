using System;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace MyXtraGrid {
	public class MyGridViewInfo : GridViewInfo {
		public MyGridViewInfo(DevExpress.XtraGrid.Views.Grid.GridView gridView) : base(gridView) {}

		public override int CalcRowHeight(Graphics graphics, int rowHandle, int rowVisibleIndex, int min, int level, bool useCache, GridColumnsInfo columns) {
			return base.CalcRowHeight(graphics, rowHandle, rowVisibleIndex, MinRowHeight, level, useCache, columns);            
    }

        public override int MinRowHeight {
            get {
                return base.MinRowHeight - 2;
            }
        }
	}
}
