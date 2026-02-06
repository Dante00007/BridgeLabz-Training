using System;
using System.Collections.Generic;
using System.Text;

namespace library_management {
    internal interface ILibrary {
        void AddBook();
        void SearchByTitle();
        void Delete();
        void Update();
        
        void LendBook();
        void ReturnBook();
    }
}
