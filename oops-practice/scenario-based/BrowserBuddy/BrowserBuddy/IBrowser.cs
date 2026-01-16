using System;
using System.Collections.Generic;
using System.Text;

namespace BrowserBuddy {
    internal interface IBrowser {
        void OpenNewTab();
        void CloseTab();
        void RestoreTab();
    }
}
