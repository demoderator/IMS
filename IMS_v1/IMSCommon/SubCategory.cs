using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSCommon
{
    public class SubCategory
    {
        #region fields
        private int _subCategoryID;
        private string _name;
        private int _categoryID;

        
        #endregion

        public SubCategory() {  }

        #region properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int SubCategoryID
        {
            get { return _subCategoryID; }
           // set { _subCategoryID = value; }
        }


        public int CategoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }  
        #endregion
    }
}
