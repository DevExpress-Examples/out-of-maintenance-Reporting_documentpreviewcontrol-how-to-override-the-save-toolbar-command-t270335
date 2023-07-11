using DevExpress.Xpf.Printing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpf.Printing.PreviewControl;
using DevExpress.XtraPrinting;

namespace MinimalisticReportPreviewDemo {
    public class MyDocumentPreviewControl : DocumentPreviewControl {
        public override void Save() {
            if(System.Windows.MessageBox.Show("Do you want to save the document?", "Save...", System.Windows.MessageBoxButton.YesNoCancel) == System.Windows.MessageBoxResult.Yes)
                base.Save();
            
        }
    }
}
