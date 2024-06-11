using OpticsSetsMy.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OpticsSetsMy.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class SoczewkaViewModel : BaseViewModel
    {
        private  Soczewka _soczewka;
        public Soczewka Soczewka
        {
            get => _soczewka;
            set
            {
                if (_soczewka != value)
                {
                    _soczewka = value;
                    OnPropertyChanged();
                }
            }
        }

        public SoczewkaViewModel(Soczewka soczewka)
        {
            _soczewka = soczewka;
        }

        public string Name
        {
            get => _soczewka.Name;
            set
            {
                if (_soczewka.Name != value)
                {
                    _soczewka.Name = value;
                    OnPropertyChanged();
                }
            }
        }
    }

    public class OprawkaViewModel : BaseViewModel
    {
        private Oprawka _oprawka;
        public Oprawka Oprawa
        {
            get => _oprawka;
            set
            {
                if (_oprawka != value)
                {
                    _oprawka = value;
                    OnPropertyChanged();
                }
            }
        }

        public OprawkaViewModel(Oprawka oprawka)
        {
            _oprawka = oprawka;
        }

        public string Name
        {
            get => _oprawka.Name;
            set
            {
                if (_oprawka.Name != value)
                {
                    _oprawka.Name = value;
                    OnPropertyChanged();
                }
            }
        }
    }

    public class KompletOpticsViewModel : BaseViewModel
    {
        private readonly KompletOptics _kompletOptics;

        public KompletOpticsViewModel(KompletOptics kompletOptics)
        {
            _kompletOptics = kompletOptics;
            SoczewkaLewa = new SoczewkaViewModel(_kompletOptics.SoczewkaLewa);
            SoczewkaPrawa = new SoczewkaViewModel(_kompletOptics.SoczewkaPrawa);
            Oprawa = new OprawkaViewModel(_kompletOptics.Oprawa);
        }

        public string Name
        {
            get => _kompletOptics.Name;
            set
            {
                if (_kompletOptics.Name != value)
                {
                    _kompletOptics.Name = value;
                    OnPropertyChanged();
                }
            }
        }

        public SoczewkaViewModel SoczewkaLewa { get; }
        public SoczewkaViewModel SoczewkaPrawa { get; }
        public OprawkaViewModel Oprawa { get; }
    }
}
