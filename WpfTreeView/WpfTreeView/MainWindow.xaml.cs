using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace WpfTreeView
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();


            //this.DataContext = new Class1();
            //var d = new DirectoryStructureViewModel();
            //var item1 = d.Items[0];

            //d.Items[0].ExpandCommand.Execute(null);
            this.DataContext = new DirectoryStructureViewModel();
        }

        #endregion
    }
}
