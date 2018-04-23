using System;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Registrator;

namespace MyXtraGrid {
	public class MyGridControl : GridControl {
		protected override BaseView CreateDefaultView() {
			return CreateView("MyGridView");
		}
		protected override void RegisterAvailableViewsCore(InfoCollection collection) {
			base.RegisterAvailableViewsCore(collection);
			collection.Add(new MyGridViewInfoRegistrator());
		}
	}
}
