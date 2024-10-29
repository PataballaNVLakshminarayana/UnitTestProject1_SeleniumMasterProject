using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;

namespace UnitTestProject1_SeleniumMasterProject
{
    public class SelectElement
    {
        internal object SelectedOption;

        public SelectElement(ReadOnlyCollection<IWebElement> elements)
        {
            Elements = elements;
        }

        public SelectElement(IWebElement selectbytextelement)
        {
        }

        public ReadOnlyCollection<IWebElement> Elements { get; }
        public bool IsMultiple { get; internal set; }

        internal void SelectByText(string v)
        {
            throw new NotImplementedException();
        }
    }
}