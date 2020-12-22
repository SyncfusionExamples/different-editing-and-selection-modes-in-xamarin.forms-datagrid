using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyXamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //dataGrid.AllowEditing = true;
            //dataGrid.SelectionMode = Syncfusion.SfDataGrid.XForms.SelectionMode.Single;
            //dataGrid.EditTapAction = Syncfusion.SfDataGrid.XForms.TapAction.OnTap;
            //dataGrid.NavigationMode = Syncfusion.SfDataGrid.XForms.NavigationMode.Cell;
            //dataGrid.EditorSelectionBehavior = Syncfusion.SfDataGrid.XForms.EditorSelectionBehavior.SelectAll;
            //dataGrid.ImeOptions = Syncfusion.SfDataGrid.XForms.GridImeOptions.NoExtractUi;
            //dataGrid.SelectionUnit = Syncfusion.SfDataGrid.XForms.SelectionUnit.Cell;

            //dataGrid.SelectionChanged += DataGrid_SelectionChanged;
        }

        private void DataGrid_SelectionChanged(object sender, Syncfusion.SfDataGrid.XForms.GridSelectionChangedEventArgs e)
        {
            var selectionChanged = e.AddedItems[0];
        }
    }
}
