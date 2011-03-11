﻿using UpdateControls;

namespace CAP
{
    public class PresentationNavigationModel
    {
        private int _currentPageIndex = 0;

        #region Independent properties
        // Generated by Update Controls --------------------------------
        private Independent _indCurrentPageIndex = new Independent();

        public int CurrentPageIndex
        {
            get { _indCurrentPageIndex.OnGet(); return _currentPageIndex; }
            set { _indCurrentPageIndex.OnSet(); _currentPageIndex = value; }
        }
        // End generated code --------------------------------
        #endregion
    }
}