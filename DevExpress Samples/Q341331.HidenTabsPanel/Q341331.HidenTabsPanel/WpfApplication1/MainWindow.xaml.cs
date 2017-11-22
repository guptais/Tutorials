using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Docking.Base;
using DevExpress.Xpf.Bars;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            GridControl.AllowInfiniteGridSize = true;
            BarManager.CheckBarItemNames = false;
            InitializeComponent();
        }

        private void showCurrentTab()
        {
            if (!(mainTab.SelectedTabIndex == 1))
            {
                mainTab.SelectedTabIndex = 1;
            }
        }

        private void showHistoryTab()
        {
            if (!(mainTab.SelectedTabIndex == 0)) // if the tab is not already selected
            {
                mainTab.SelectedTabIndex = 0;
            }
        }


        #region Tool Bar Events

        private void itemMoveBack_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            
        }

        private void itemMove_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {

           
        }

        private void itemSubmit_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            
        }

        private void itemCurrent_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            showCurrentTab();
        }

        private void itemHistory_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            showHistoryTab();
        }

        private void itemClockReadingHistory_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {

           

        }

        private void itemClockReadingCurrent_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
           
        }

        private void itemUserClocks_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            
        }

        private void itemChangeEquipment_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
           

        }

        private void itemChangeClock_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
           

        }

        private void itemDataTransfer_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
          
        }

        private void itemImportEquipHistory_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            
        }

        private void itemFeedBack_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            
        }

        private void itemModificationLog_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            
        }

        private void itemChngPastClockReading_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
           
        }

        private void itemReSubmitData_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            
        }

        private void itemPastEquipmentHours_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            
        }

        private void itemClose_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Close();
        }

        private void itemAddNotes_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
           

        }

        private void itemRecover_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
           

        }

        private void itemHelp_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            DevExpress.Xpf.Core.DXMessageBox.Show("Feature not implemented.", "Not Implemented");
        }

        private void itemEquipmentList_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            
        }
        #endregion

        #region Print Reports

        private void itemPrintMarkedTasks_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
           

        }
       

        private void itemPrePostDiveChecklist_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
           
        }

        private void itemTaskDone_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
           
        }

        private void itemMissed_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
           
        }

        private void itemWeeklyTasks_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {

          
        }
        

        private void itemBiweeklyTasks_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
           
          
        }
       

        private void itemMaintPlanByCateg_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {

            

        }
     

        private void itemMaintPlanByFreq_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {

           

        }
       
      
        private void itemRemobilsation_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
           


        }
       

        private void itemPrintEquipmentHistory_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
           
        }
        

        #endregion
    }
}
