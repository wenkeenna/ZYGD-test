using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using ZYGD.Common;

namespace ZYGD.ViewModels
{
  public  class HomeViewModel: BindableBase
    {

        public HomeViewModel()
        {
            PMatrix = new ObservableCollection<ProductMatrix>();

            LoadProductMatrix();
        }

        private ObservableCollection<ProductMatrix> pMatrix;
        public ObservableCollection<ProductMatrix> PMatrix
        {
            get { return pMatrix; }
            set { pMatrix = value; RaisePropertyChanged(); }
        }

        private int radui = 10;
        private int xstartpoint = 1;
        private int ystartpoint = 1;
        private int xpoingNumber = 10;
        private int ypoingNumber = 10;
        private int xspacing = 19;
        private int yspacing = 19;   

        private void LoadProductMatrix()
        {
            for(int i = 0; i< ypoingNumber; i++)
            {
                for(int j = 0; j < xpoingNumber; j++)
                {
                    PMatrix.Add(new ProductMatrix() { XCorrdinate = xstartpoint+ radui, YCorrdinate = ystartpoint+radui, Radius = radui, BackgroundColor = "#AEEA00" });
                    xstartpoint = xstartpoint + xspacing;
                }
                xstartpoint = 2;
                ystartpoint = ystartpoint + yspacing;
            }
            ystartpoint = 2;
            //PMatrix.Add(new ProductMatrix() { XCorrdinate= xstartpoint, YCorrdinate=20,Radius= radui, BackgroundColor= "#AEEA00" });
            //PMatrix.Add(new ProductMatrix() { XCorrdinate = 20, YCorrdinate = 20, Radius = radui, BackgroundColor = "#AEEA00" });
            //PMatrix.Add(new ProductMatrix() { XCorrdinate = 30, YCorrdinate = 20, Radius = radui, BackgroundColor = "#AEEA00" });

        }
    }
}
