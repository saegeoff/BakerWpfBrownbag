using BakerWpfBrownbag.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BakerWpfBrownbag.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        protected string m_Name;
        protected string m_Description;
        protected double m_CompressiveStrength28;
        protected double m_InitialCompressiveStrength;
        protected double m_CoeffThermalExpansion;
        protected double m_DensityDeadLoad;

        protected DelegateCommand m_OkCommand;
        protected DelegateCommand m_ApplyCommand;
        protected DelegateCommand m_CancelCommand;

        public MainWindowViewModel()
        {
            m_OkCommand = new DelegateCommand(OnOkCommand);
            m_ApplyCommand = new DelegateCommand(OnApplyCommand);
            m_CancelCommand = new DelegateCommand(OnCancelCommand);

            ResetFields();
        }

        public string Name
        {
            get { return m_Name; }
            set
            {
                m_Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Description
        {
            get { return m_Description; }
            set
            {
                m_Description = value;
                OnPropertyChanged("Description");
            }
        }

        public double CompressiveStrength28
        {
            get { return m_CompressiveStrength28; }
            set
            {
                m_CompressiveStrength28 = value;
                OnPropertyChanged("CompressiveStrength28");
            }
        }

        public double InitialCompressiveStrength
        {
            get { return m_InitialCompressiveStrength; }
            set
            {
                m_InitialCompressiveStrength = value;
                OnPropertyChanged("InitialCompressiveStrength");
            }
        }

        public double CoeffThermalExpansion
        {
            get { return m_CoeffThermalExpansion; }
            set
            {
                m_CoeffThermalExpansion = value;
                OnPropertyChanged("CoeffThermalExpansion");
            }
        }

        public double DensityDeadLoad
        {
            get { return m_DensityDeadLoad; }
            set
            {
                m_DensityDeadLoad = value;
                OnPropertyChanged("DensityDeadLoad");
            }
        }

        public ICommand OkCommand
        {
            get { return m_OkCommand; }
        }

        public ICommand ApplyCommand
        {
            get { return m_ApplyCommand; }
        }

        public ICommand CancelCommand
        {
            get { return m_CancelCommand; }
        }

        protected void OnOkCommand()
        {

        }

        protected void OnApplyCommand()
        {

        }

        protected void OnCancelCommand()
        {
            ResetFields();
        }

        protected void ResetFields()
        {
            this.Name = "WPF Brownbag";
            this.Description = string.Empty;

            this.CompressiveStrength28 = 0.0;
            this.InitialCompressiveStrength = 0.0;
            this.CoeffThermalExpansion = 0.0;
            this.DensityDeadLoad = 0.0;
        }
    }
}
