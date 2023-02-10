using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using ZYGD.Common;
using ZYGD.Events;

namespace ZYGD.ViewModels
{
  public  class HomeViewModel: BindableBase
    {

        #region 变量
        public IEventAggregator _eventAggregator;
        public DelegateCommand<string> btnMatrixCommand { get; private set; }
        /// <summary>
        /// 产品矩阵1参数
        /// </summary>
        private ProductMatrixParameter _PM1 = new ProductMatrixParameter();
        /// <summary>
        /// 产品矩阵2参数
        /// </summary>
        private ProductMatrixParameter _PM2 = new ProductMatrixParameter();
        /// <summary>
        /// 产品矩阵3参数
        /// </summary>
        private ProductMatrixParameter _PM3 = new ProductMatrixParameter();

        private ObservableCollection<ProductMatrix> pMatrix1;
        /// <summary>
        /// 矩阵1
        /// </summary>
        public ObservableCollection<ProductMatrix> PMatrix1
        {
            get { return pMatrix1; }
            set { pMatrix1 = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<ProductMatrix> pMatrix2;
        /// <summary>
        /// 矩阵2
        /// </summary>
        public ObservableCollection<ProductMatrix> PMatrix2
        {
            get { return pMatrix2; }
            set { pMatrix2 = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<ProductMatrix> pMatrix3;
        /// <summary>
        /// 矩阵3
        /// </summary>
        public ObservableCollection<ProductMatrix> PMatrix3
        {
            get { return pMatrix3; }
            set { pMatrix3 = value; RaisePropertyChanged(); }
        }
        #endregion

        public HomeViewModel(IEventAggregator ea)
        {
            _eventAggregator = ea;
            _eventAggregator.GetEvent<Event_PMatrix1Click>().Subscribe(_Event_PMClickFun);

            PMatrix1 = new ObservableCollection<ProductMatrix>();
            PMatrix2 = new ObservableCollection<ProductMatrix>();
            PMatrix3 = new ObservableCollection<ProductMatrix>();

            _PM1.Radui = 10;
            _PM1.XSpacing = 19;
            _PM1.YSpacing = 19;
            _PM1.XPoingNumber = 10;
            _PM1.YPoingNumber = 20;
            _PM1.XStartPoint = 0;
            _PM1.YStartPoint = 0;

            _PM2.Radui = 10;
            _PM2.XSpacing = 19;
            _PM2.YSpacing = 19;
            _PM2.XPoingNumber = 10;
            _PM2.YPoingNumber = 20;
            _PM2.XStartPoint = 0;
            _PM2.YStartPoint = 0;

            _PM3.Radui = 10;
            _PM3.XSpacing = 19;
            _PM3.YSpacing = 19;
            _PM3.XPoingNumber = 10;
            _PM3.YPoingNumber = 20;
            _PM3.XStartPoint = 0;
            _PM3.YStartPoint = 0;

            Task.Factory.StartNew( () =>
            {
                PMatrix1 = LoadProductMatrix(_PM1.XStartPoint, _PM1.YStartPoint, _PM1.XPoingNumber,
                                        _PM1.YPoingNumber, _PM1.XSpacing, _PM1.YSpacing, _PM1.Radui, PMatrix1, _PM1);


            });
            Task.Factory.StartNew(() =>
            {
                PMatrix2 = LoadProductMatrix(_PM2.XStartPoint, _PM2.YStartPoint, _PM2.XPoingNumber,
                                             _PM2.YPoingNumber, _PM2.XSpacing, _PM2.YSpacing, _PM2.Radui, PMatrix2, _PM2);
            });
            Task.Factory.StartNew(() =>
            {
                PMatrix3 = LoadProductMatrix(_PM3.XStartPoint, _PM3.YStartPoint, _PM3.XPoingNumber,
                                              _PM3.YPoingNumber, _PM3.XSpacing, _PM3.YSpacing, _PM3.Radui, PMatrix3, _PM3);
            });

        }



        #region 产品矩阵/加载/更新
      
        /// <summary>
        /// 界面点击更新
        /// </summary>
        /// <param name="number"></param>
        private void _Event_PMClickFun(object number)
        {
            Canvas canvas= (Canvas)number;
            if (canvas.Name == "Canvas1")
            {
                PMatrix1 = UpdataMatrixCommandFUN(number, PMatrix1);
            }
            else if (canvas.Name == "Canvas2")
            {
                PMatrix2 = UpdataMatrixCommandFUN(number, PMatrix2);
            }
            else if (canvas.Name == "Canvas3")
            {
                PMatrix3 = UpdataMatrixCommandFUN(number, PMatrix3);
            }


        }

        /// <summary>
        /// 加载矩阵
        /// </summary>
        /// <param name="x_start">X起始点</param>
        /// <param name="y_start">Y起始点</param>
        /// <param name="x_number">X点数</param>
        /// <param name="y_number">Y点数</param>
        /// <param name="x_spacing">X间距</param>
        /// <param name="y_spacing">Y间距</param>
        /// <param name="radui"></param>
        private ObservableCollection<ProductMatrix> LoadProductMatrix(int x_start,int y_start,int x_number,int y_number,int x_spacing,int y_spacing,int radui, ObservableCollection<ProductMatrix> PMatrix, ProductMatrixParameter pm)
        {
            int number = 0;

            for(int i = 0; i< y_number; i++)
            {
                for(int j = 0; j < x_number; j++)
                {
                    PMatrix.Add(new ProductMatrix() { XCorrdinate = x_start + radui, YCorrdinate = y_start + radui, Radius = radui, BackgroundColor = "#00A630", Number = number });
                    x_start = x_start + x_spacing;
                    number++;
                }
                x_start =pm.XStartPoint ;
                y_start = y_start + y_spacing;
            }
          

            return PMatrix;
        }
        /// <summary>
        /// 更新矩阵
        /// </summary>
        /// <param name="number">需要更新的产品编号</param>
        private ObservableCollection<ProductMatrix> UpdataMatrixCommandFUN(object number , ObservableCollection<ProductMatrix> PMatrix)
        {
            Canvas btn = number as Canvas;
            ProductMatrix pm = btn.DataContext as ProductMatrix;
            ProductMatrix pmtemp=new ProductMatrix();   
            pmtemp.Radius = pm.Radius;
            pmtemp.Number = pm.Number;  
            pmtemp.YCorrdinate=pm.YCorrdinate;
            pmtemp.XCorrdinate=pm.XCorrdinate;
            pmtemp.BackgroundColor = "#E53D30";
            PMatrix[Convert.ToInt32(pm.Number)]= pmtemp;
            return PMatrix;
           
        }
        #endregion
    }
}
