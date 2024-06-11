using OpticsSetsMy.Models;
using Pomocne;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace OpticsSetsMy.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private RelayCommand _soczewkaLewaCommand;

        public RelayCommand SoczewkaLewaCommand
        {
            get => _soczewkaLewaCommand;
            set
            {
                if (_soczewkaLewaCommand != value)
                {
                    _soczewkaLewaCommand = value;
                    OnPropertyChanged();
                }
            }
        }
        private KompletOpticsViewModel _selectedKompletOptics;
        public ObservableCollection<KompletOpticsViewModel> ListaKompletowOC { get; set; }
        public ObservableCollection<Soczewka> ListaSoczewekOC { get; set; }
        public ObservableCollection<Oprawka> ListaOprawekOC { get; set; }
        private Soczewka _selectedSoczewkaLewa;
        private Soczewka _selectedSoczewkaPrawa;
        private Oprawka _selectedOprawka;
        public Soczewka SelectedSoczewkaLewa
        {
            get => _selectedSoczewkaLewa;
            set
            {
                if (_selectedSoczewkaLewa != value)
                {
                    var contains = ListaSoczewekOC.Contains(value);
                    _selectedSoczewkaLewa = value;
                    OnPropertyChanged();
                }
            }
        }
        public Soczewka SelectedSoczewkaPrawa
        {
            get => _selectedSoczewkaPrawa;
            set
            {
                if (_selectedSoczewkaPrawa != value)
                {
                    _selectedSoczewkaPrawa = value;
                    OnPropertyChanged();
                }
            }
        }
        public Oprawka SelectedOprawa
        {
            get => _selectedOprawka;
            set
            {
                if (_selectedOprawka != value)
                {
                    _selectedOprawka = value;
                    OnPropertyChanged();
                }
            }
        }


        public KompletOpticsViewModel SelectedKompletOptics
        {
            get => _selectedKompletOptics;
            set
            {
                if (_selectedKompletOptics != value)
                {
                    _selectedKompletOptics = value;
                    SelectedOprawa = _selectedKompletOptics.Oprawa.Oprawa;
                    SelectedSoczewkaLewa = _selectedKompletOptics.SoczewkaLewa.Soczewka;
                    SelectedSoczewkaPrawa = _selectedKompletOptics.SoczewkaPrawa.Soczewka;
                    OnPropertyChanged();
                }
            }
        }

        public MainWindowViewModel()
        {
            SoczewkaLewaCommand = new RelayCommand(SoczewkaLewaCommandExecute, CanSoczewkaExecute);
            ListaSoczewekOC = new ObservableCollection<Soczewka>
            {
                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },                new Soczewka { Name = "SL1" },
                new Soczewka { Name = "SL2" },
                // Add more items as needed
            };
            ListaOprawekOC = new ObservableCollection<Oprawka>
            {
                new Oprawka { Name = "O1" },
                new Oprawka { Name = "O2" },
                // Add more items as needed
            };
            ListaKompletowOC = new ObservableCollection<KompletOpticsViewModel>
            {
                new KompletOpticsViewModel(new KompletOptics
                {
                    Name = "K1",
                    SoczewkaLewa = ListaSoczewekOC[0],
                    SoczewkaPrawa = ListaSoczewekOC[1],
                    Oprawa = ListaOprawekOC[0]
                }),
                new KompletOpticsViewModel(new KompletOptics
                {
                    Name = "K2",
                    SoczewkaLewa = ListaSoczewekOC[1],
                    SoczewkaPrawa = ListaSoczewekOC[0],
                    Oprawa = ListaOprawekOC[1]
                }),
                new KompletOpticsViewModel(new KompletOptics
                {
                    Name = "K3",
                    SoczewkaLewa = ListaSoczewekOC[22],
                    SoczewkaPrawa = ListaSoczewekOC[15],
                    Oprawa = ListaOprawekOC[1]
                }),
            };
        }
        private void SoczewkaLewaCommandExecute()
        {
            return;
            SelectedSoczewkaLewa = ListaSoczewekOC[33];
        }
        private bool CanSoczewkaExecute()
        {
            // Replace the condition with your own logic
            return true;
        }
    }
}
