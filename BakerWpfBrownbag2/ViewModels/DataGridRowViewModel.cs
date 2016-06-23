using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerWpfBrownbag.ViewModels
{
    class DataGridRowViewModel : ViewModelBase
    {
        protected string m_FirstColumn = string.Empty;
        protected string m_SecondColumn = string.Empty;
        protected double m_ThirdColumn = 0.0;

        public string FirstColumn
        {
            get { return m_FirstColumn; }
            set
            {
                m_FirstColumn = value;
                OnPropertyChanged("FirstColumn");
            }
        }

        public string SecondColumn
        {
            get { return m_SecondColumn; }
            set
            {
                m_SecondColumn = value;
                OnPropertyChanged("SecondColumn");
            }
        }

        public double ThirdColumn
        {
            get { return m_ThirdColumn; }
            set
            {
                m_ThirdColumn = value;
                OnPropertyChanged("ThirdColumn");
            }
        }

        public bool NewRow { get; set; }

        public void Copy(DataGridRowViewModel vm)
        {
            this.FirstColumn = vm.FirstColumn;
            this.SecondColumn = vm.SecondColumn;
            this.ThirdColumn = vm.ThirdColumn;
        }
    }
}
