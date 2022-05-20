using ImmServiceContainers;
using MassTransit;
using MayEpCHADesktopApp.Core.Components;
using MayEpCHADesktopApp.Core.Model;
using MayEpCHADesktopApp.Core.Services.Communication.Consumer;
using MayEpCHADesktopApp.Core.Services.Interfaces;
using MayEpCHADesktopApp.Core.ViewModels.BaseViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace MayEpCHADesktopApp.Core.ViewModels.ComponentViewModels
{
    public class DetailMachineViewModel : ViewModels.BaseViewModels.BaseViewModel
    {

        #region var

  

        private  string content { get; set; }
        public  string Content { get => content; set { content = value; OnPropertyChanged(); } }
        private string tag { get; set; }
        public string Tag { get => tag; set { tag = value; OnPropertyChanged(); } }

        private bool animation1;
        public bool Animation1 { get => animation1; set { animation1 = value; OnPropertyChanged(); } }

        private bool animation2;
        public bool Animation2 { get => animation2; set { animation2 = value; OnPropertyChanged(); } }
        //so luong
        private string count1 { get; set; }
        public string Count1 { get => count1; set { count1 = value; OnPropertyChanged(); } }
        private string count2 { get; set; }
        public string Count2 { get => count2; set { count2 = value; OnPropertyChanged(); } }
        private string count3 { get; set; }
        public string Count3 { get => count3; set { count3 = value; OnPropertyChanged(); } }
        private string count4 { get; set; }
        public string Count4 { get => count4; set { count4 = value; OnPropertyChanged(); } }
        private string count5 { get; set; }
        public string Count5 { get => count5; set { count5 = value; OnPropertyChanged(); } }
        private string count6 { get; set; }
        public string Count6 { get => count6; set { count6 = value; OnPropertyChanged(); } }
        private string count7 { get; set; }
        public string Count7 { get => count7; set { count7 = value; OnPropertyChanged(); } }
        private string count8 { get; set; }
        public string Count8 { get => count8; set { count8 = value; OnPropertyChanged(); } }
        private string count9 { get; set; }
        public string Count9 { get => count9; set { count9 = value; OnPropertyChanged(); } }
        private string count10 { get; set; }
        public string Count10 { get => count10; set { count10 = value; OnPropertyChanged(); } }
        private string count11 { get; set; }
        public string Count11 { get => count11; set { count11 = value; OnPropertyChanged(); } }
        private string count12 { get; set; }
        public string Count12 { get => count12; set { count12 = value; OnPropertyChanged(); } }
        private string count13 { get; set; }
        public string Count13 { get => count13; set { count13 = value; OnPropertyChanged(); } }
        private string count14 { get; set; }
        public string Count14 { get => count14; set { count14 = value; OnPropertyChanged(); } }
        private string count15 { get; set; }
        public string Count15 { get => count15; set { count15 = value; OnPropertyChanged(); } }
        private string count16 { get; set; }
        public string Count16 { get => count16; set { count16 = value; OnPropertyChanged(); } }
        private string count17 { get; set; }
        public string Count17 { get => count17; set { count17 = value; OnPropertyChanged(); } }
        private string count18 { get; set; }
        public string Count18 { get => count18; set { count18 = value; OnPropertyChanged(); } }
        private string count19 { get; set; }
        public string Count19 { get => count19; set { count19 = value; OnPropertyChanged(); } }
        private string count20 { get; set; }
        public string Count20 { get => count20; set { count20 = value; OnPropertyChanged(); } }
        private string count21 { get; set; }
        public string Count21 { get => count21; set { count21 = value; OnPropertyChanged(); } }
        private string count22 { get; set; }
        public string Count22 { get => count22; set { count22 = value; OnPropertyChanged(); } }
        private string count23 { get; set; }
        public string Count23 { get => count23; set { count23 = value; OnPropertyChanged(); } }
        private string count24 { get; set; }
        public string Count24 { get => count24; set { count24 = value; OnPropertyChanged(); } }
        private string count25 { get; set; }
        public string Count25 { get => count25; set { count25 = value; OnPropertyChanged(); } }
        private string count26 { get; set; }
        public string Count26 { get => count26; set { count26 = value; OnPropertyChanged(); } }
        private string count27 { get; set; }
        public string Count27 { get => count27; set { count27 = value; OnPropertyChanged(); } }
        private string count28 { get; set; }
        public string Count28 { get => count28; set { count28 = value; OnPropertyChanged(); } }
        private string countL1 { get; set; }
        public string CountL1 { get => countL1; set { countL1 = value; OnPropertyChanged(); } }
        private string countL2 { get; set; }
        public string CountL2 { get => countL2; set { countL2 = value; OnPropertyChanged(); } }
        private string countL3 { get; set; }
        public string CountL3 { get => countL3; set { countL3 = value; OnPropertyChanged(); } }
        private string countL4 { get; set; }
        public string CountL4 { get => countL4; set { countL4 = value; OnPropertyChanged(); } }
        private string countL5 { get; set; }
        public string CountL5 { get => countL5; set { countL5 = value; OnPropertyChanged(); } }
        private string countL6 { get; set; }
        public string CountL6 { get => countL6; set { countL6 = value; OnPropertyChanged(); } }
        private string countL7 { get; set; }
        public string CountL7 { get => countL7; set { countL7 = value; OnPropertyChanged(); } }
        private string countL8 { get; set; }
        public string CountL8 { get => countL8; set { countL8 = value; OnPropertyChanged(); } }
        private string countL9 { get; set; }
        public string CountL9 { get => countL9; set { countL9 = value; OnPropertyChanged(); } }
        private string countL10{ get; set; }
        public string CountL10 { get => countL10; set { countL10 = value; OnPropertyChanged(); } }
        private string countL12 { get; set; }
        public string CountL12 { get => countL12; set { countL12 = value; OnPropertyChanged(); } }
        private string countL11 { get; set; }
        public string CountL11 { get => countL12; set { countL12 = value; OnPropertyChanged(); } }


        //
        private string moldId1 { get; set; }
        public string MoldId1 { get => moldId1; set { moldId1= value; OnPropertyChanged(); } }
        private string moldId2 { get; set; }
        public string MoldId2 { get => moldId2; set { moldId2 = value; OnPropertyChanged(); } }
        private string moldId3 { get; set; }
        public string MoldId3 { get => moldId3; set { moldId3 = value; OnPropertyChanged(); } }
        private string moldId4 { get; set; }
        public string MoldId4 { get => moldId4; set { moldId4 = value; OnPropertyChanged(); } }
        private string moldId5 { get; set; }
        public string MoldId5 { get => moldId5; set { moldId5 = value; OnPropertyChanged(); } }
        private string moldId6 { get; set; }
        public string MoldId6 { get => moldId6; set { moldId6 = value; OnPropertyChanged(); } }
        private string moldId7 { get; set; }
        public string MoldId7 { get => moldId7; set { moldId7 = value; OnPropertyChanged(); } }
        private string moldId { get; set; }
        private string moldId8 { get; set; }
        public string MoldId8 { get => moldId8; set { moldId8 = value; OnPropertyChanged(); } }
        private string moldId9 { get; set; }
        public string MoldId9 { get => moldId9; set { moldId9 = value; OnPropertyChanged(); } }
        private string moldId10 { get; set; }
        public string MoldId10 { get => moldId10; set { moldId10 = value; OnPropertyChanged(); } }
        private string moldId11 { get; set; }
        public string MoldId11 { get => moldId11; set { moldId11 = value; OnPropertyChanged(); } }
        private string moldId13 { get; set; }
        public string MoldId13 { get => moldId13; set { moldId13= value; OnPropertyChanged(); } }
        private string moldId12 { get; set; }
        public string MoldId12 { get => moldId12; set { moldId12 = value; OnPropertyChanged(); } }
        private string moldId14 { get; set; }
        public string MoldId14 { get => moldId14; set { moldId14 = value; OnPropertyChanged(); } }
        private string moldId15 { get; set; }
        public string MoldId15 { get => moldId15; set { moldId15 = value; OnPropertyChanged(); } }
        private string moldId16 { get; set; }
        public string MoldId16 { get => moldId16; set { moldId16 = value; OnPropertyChanged(); } }
        private string moldId17 { get; set; }
        public string MoldId17{ get => moldId17; set { moldId17 = value; OnPropertyChanged(); } }
        private string moldId18 { get; set; }
        public string MoldId18 { get => moldId18; set { moldId18 = value; OnPropertyChanged(); } }
        private string moldId19 { get; set; }
        public string MoldId19 { get => moldId19; set { moldId19 = value; OnPropertyChanged(); } }
        private string moldId20 { get; set; }
        public string MoldId20 { get => moldId20; set { moldId20 = value; OnPropertyChanged(); } }
        private string moldId21 { get; set; }
        public string MoldId21 { get => moldId21; set { moldId21 = value; OnPropertyChanged(); } }
        private string moldId22 { get; set; }
        public string MoldId22 { get => moldId22; set { moldId22 = value; OnPropertyChanged(); } }
        private string moldId23 { get; set; }
        public string MoldId23 { get => moldId23; set { moldId23 = value; OnPropertyChanged(); } }
        private string moldId24 { get; set; }
        public string MoldId24 { get => moldId24; set { moldId24 = value; OnPropertyChanged(); } }
        private string moldId25 { get; set; }
        public string MoldId25 { get => moldId25; set { moldId25 = value; OnPropertyChanged(); } }
        private string moldId26{ get; set; }
        public string MoldId26 { get => moldId26; set { moldId26 = value; OnPropertyChanged(); } }
        private string moldId27 { get; set; }
        public string MoldId27 { get => moldId27; set { moldId27 = value; OnPropertyChanged(); } }
        private string moldId28 { get; set; }
        public string MoldId28 { get => moldId28; set { moldId28 = value; OnPropertyChanged(); } }
        private string moldIdL1 { get; set; }
        public string MoldIdL1 { get => moldIdL1; set { moldIdL1 = value; OnPropertyChanged(); } }
        private string moldIdL2 { get; set; }
        public string MoldIdL2 { get => moldIdL2; set { moldIdL2 = value; OnPropertyChanged(); } }
        private string moldIdL3 { get; set; }
        public string MoldIdL3 { get => moldIdL3; set { moldIdL3 = value; OnPropertyChanged(); } }
        private string moldIdL4 { get; set; }
        public string MoldIdL4 { get => moldIdL4; set { moldIdL4 = value; OnPropertyChanged(); } }
        private string moldIdL5 { get; set; }
        public string MoldIdL5 { get => moldIdL5; set { moldIdL5 = value; OnPropertyChanged(); } }
        private string moldIdL6 { get; set; }
        public string MoldIdL6 { get => moldIdL6; set { moldIdL6 = value; OnPropertyChanged(); } }
        private string moldIdL7 { get; set; }
        public string MoldIdL7 { get => moldIdL7; set { moldIdL7 = value; OnPropertyChanged(); } }
        private string moldIdL8{ get; set; }
        public string MoldIdL8 { get => moldIdL8; set { moldIdL8 = value; OnPropertyChanged(); } }
        private string moldIdL9 { get; set; }
        public string MoldIdL9 { get => moldIdL9; set { moldIdL9 = value; OnPropertyChanged(); } }
        private string moldIdL10 { get; set; }
        public string MoldIdL10 { get => moldIdL10; set { moldIdL10 = value; OnPropertyChanged(); } }
        private string moldIdL11 { get; set; }
        public string MoldIdL11 { get => moldIdL11; set { moldIdL11 = value; OnPropertyChanged(); } }
        private string moldIdL12 { get; set; }
        public string MoldIdL12 { get => moldIdL12; set { moldIdL12 = value; OnPropertyChanged(); } }

        //
        private string productId1 { get; set; }
        public string ProductId1 { get => productId1; set { productId1 = value; OnPropertyChanged(); } }
        private string productId2 { get; set; }
        public string ProductId2 { get => productId2; set { productId2 = value; OnPropertyChanged(); } }
        private string productId3 { get; set; }
        public string ProductId3 { get => productId3; set { productId3 = value; OnPropertyChanged(); } }
        private string productId4 { get; set; }
        public string ProductId4 { get => productId4; set { productId4 = value; OnPropertyChanged(); } }
        private string productId5 { get; set; }
        public string ProductId5 { get => productId5; set { productId5 = value; OnPropertyChanged(); } }
        private string productId6 { get; set; }
        public string ProductId6 { get => productId6; set { productId6= value; OnPropertyChanged(); } }
        private string productId7 { get; set; }
        public string ProductId7 { get => productId7; set { productId7 = value; OnPropertyChanged(); } }
        private string productId8 { get; set; }
        public string ProductId8 { get => productId8; set { productId8 = value; OnPropertyChanged(); } }
        private string productId9 { get; set; }
        public string ProductId9 { get => productId9; set { productId9 = value; OnPropertyChanged(); } }
        private string productId10 { get; set; }
        public string ProductId10 { get => productId10; set { productId10 = value; OnPropertyChanged(); } }
        private string productId11 { get; set; }
        public string ProductId12 { get => productId12; set { productId12 = value; OnPropertyChanged(); } }
        private string productId12 { get; set; }
        public string ProductId13 { get => productId13; set { productId12 = value; OnPropertyChanged(); } }
        private string productId13 { get; set; }
        public string ProductId11 { get => productId11; set { productId11 = value; OnPropertyChanged(); } }
        private string productId14 { get; set; }
        public string ProductId14 { get => productId14; set { productId14 = value; OnPropertyChanged(); } }
        private string productId15 { get; set; }
        public string ProductId15 { get => productId15; set { productId15 = value; OnPropertyChanged(); } }
        private string productId16 { get; set; }
        public string ProductId16 { get => productId16; set { productId16 = value; OnPropertyChanged(); } }
        private string productId17 { get; set; }
        public string ProductId17 { get => productId17; set { productId17 = value; OnPropertyChanged(); } }
        private string productId18 { get; set; }
        public string ProductId18 { get => productId18; set { productId18 = value; OnPropertyChanged(); } }
        private string productId19 { get; set; }
        public string ProductId19 { get => productId19; set { productId19 = value; OnPropertyChanged(); } }
        private string productId20 { get; set; }
        public string ProductId20 { get => productId20; set { productId20 = value; OnPropertyChanged(); } }
        private string productId21 { get; set; }
        public string ProductId21 { get => productId21; set { productId21 = value; OnPropertyChanged(); } }
        private string productId22 { get; set; }
        public string ProductId22 { get => productId22; set { productId22 = value; OnPropertyChanged(); } }
        private string productId23 { get; set; }
        public string ProductId23{ get => productId23; set { productId23 = value; OnPropertyChanged(); } }
        private string productId24 { get; set; }
        public string ProductId24 { get => productId24; set { productId24 = value; OnPropertyChanged(); } }
        private string productId25 { get; set; }
        public string ProductId25 { get => productId25; set { productId25 = value; OnPropertyChanged(); } }
        private string productId26 { get; set; }
        public string ProductId26 { get => productId26; set { productId26 = value; OnPropertyChanged(); } }
        private string productId27 { get; set; }
        public string ProductId27 { get => productId27; set { productId27 = value; OnPropertyChanged(); } }
        private string productId28 { get; set; }
        public string ProductId28 { get => productId28; set { productId28 = value; OnPropertyChanged(); } }
        private string productIdL1 { get; set; }
        public string ProductIdL1 { get => productIdL1; set { productIdL1 = value; OnPropertyChanged(); } }
        private string productIdL2 { get; set; }
        public string ProductIdL2 { get => productIdL2; set { productIdL2 = value; OnPropertyChanged(); } }
        private string productIdL3 { get; set; }
        public string ProductIdL3 { get => productIdL3; set { productIdL3 = value; OnPropertyChanged(); } }
        private string productIdL4 { get; set; }
        public string ProductIdL4 { get => productIdL4; set { productIdL4 = value; OnPropertyChanged(); } }
        private string productIdL5 { get; set; }
        public string ProductIdL5 { get => productIdL5; set { productIdL5 = value; OnPropertyChanged(); } }
        private string productIdL6 { get; set; }
        public string ProductIdL6 { get => productIdL6; set { productIdL6 = value; OnPropertyChanged(); } }
        private string productIdL7 { get; set; }
        public string ProductIdL7 { get => productIdL7; set { productIdL7= value; OnPropertyChanged(); } }
        private string productIdL8 { get; set; }
        public string ProductIdL8 { get => productIdL8; set { productIdL8 = value; OnPropertyChanged(); } }
        private string productIdL9 { get; set; }
        public string ProductIdL9 { get => productIdL9; set { productIdL9= value; OnPropertyChanged(); } }
        private string productIdL10{ get; set; }
        public string ProductIdL10 { get => productIdL10; set { productIdL10 = value; OnPropertyChanged(); } }
        private string productIdL11 { get; set; }
        public string ProductIdL11 { get => productIdL11; set { productIdL11 = value; OnPropertyChanged(); } }
        private string productIdL12 { get; set; }
        public string ProductIdL12 { get => productIdL12; set { productIdL12 = value; OnPropertyChanged(); } }
        //
        private string cycle1 { get; set; }
        public string Cycle1 { get => cycle1; set { cycle11 = value; OnPropertyChanged(); } }
        private string cycle2 { get; set; }
        public string Cycle2 { get => cycle2; set { cycle2 = value; OnPropertyChanged(); } }
        private string cycle3 { get; set; }
        public string Cycle3 { get => cycle3; set { cycle3 = value; OnPropertyChanged(); } }
        private string cycle4 { get; set; }
        public string Cycle4 { get => cycle4; set { cycle4 = value; OnPropertyChanged(); } }
        private string cycle5 { get; set; }
        public string Cycle5 { get => cycle5; set { cycle5 = value; OnPropertyChanged(); } }
        private string cycle6{ get; set; }
        public string Cycle6 { get => cycle6; set { cycle6 = value; OnPropertyChanged(); } }
        private string cycle7 { get; set; }
        public string Cycle7 { get => cycle7; set { cycle7 = value; OnPropertyChanged(); } }
        private string cycle8 { get; set; }
        public string Cycle8 { get => cycle8; set { cycle8 = value; OnPropertyChanged(); } }
        private string cycle9 { get; set; }
        public string Cycle9 { get => cycle9; set { cycle9 = value; OnPropertyChanged(); } }
        private string cycle10 { get; set; }
        public string Cycle10 { get => cycle10; set { cycle10 = value; OnPropertyChanged(); } }
        private string cycle11 { get; set; }
        public string Cycle11 { get => cycle11; set { cycle11 = value; OnPropertyChanged(); } }
        private string cycle12 { get; set; }
        public string Cycle12 { get => cycle12; set { cycle12 = value; OnPropertyChanged(); } }

        private string cycle13 { get; set; }
        public string Cycle13 { get => cycle13; set { cycle13 = value; OnPropertyChanged(); } }
        private string cycle14 { get; set; }
        public string Cycle15 { get => cycle15; set { cycle15 = value; OnPropertyChanged(); } }
        private string cycle16 { get; set; }
        public string Cycle16 { get => cycle16; set { cycle16 = value; OnPropertyChanged(); } }
        private string cycle17 { get; set; }
        public string Cycle14 { get => cycle14; set { cycle14 = value; OnPropertyChanged(); } }
        private string cycle18 { get; set; }
        public string Cycle17 { get => cycle17; set { cycle17 = value; OnPropertyChanged(); } }
        private string cycle15 { get; set; }
        public string Cycle18 { get => cycle18; set { cycle18 = value; OnPropertyChanged(); } }
        private string cycle19 { get; set; }
        public string Cycle19 { get => cycle19; set { cycle19 = value; OnPropertyChanged(); } }
        private string cycle20 { get; set; }
        public string Cycle20 { get => cycle20; set { cycle20 = value; OnPropertyChanged(); } }
        private string cycle21 { get; set; }
        public string Cycle21 { get => cycle21; set { cycle21 = value; OnPropertyChanged(); } }
        private string cycle22 { get; set; }
        public string Cycle22 { get => cycle22; set { cycle22 = value; OnPropertyChanged(); } }
        private string cycle23 { get; set; }
        public string Cycle23 { get => cycle23; set { cycle23 = value; OnPropertyChanged(); } }
        private string cycle24 { get; set; }
        public string Cycle24 { get => cycle24; set { cycle24 = value; OnPropertyChanged(); } }
        private string cycle25 { get; set; }
        public string Cycle25 { get => cycle25; set { cycle25 = value; OnPropertyChanged(); } }
        private string cycle26 { get; set; }
        public string Cycle26 { get => cycle26; set { cycle26 = value; OnPropertyChanged(); } }
        private string cycle27 { get; set; }
        public string Cycle27 { get => cycle27; set { cycle27 = value; OnPropertyChanged(); } }
        private string cycle28 { get; set; }
        public string Cycle28 { get => cycle28; set { cycle28 = value; OnPropertyChanged(); } }
        private string cyclel1 { get; set; }
        public string CycleL1 { get => cyclel1; set { cyclel1 = value; OnPropertyChanged(); } }
        private string cyclel2 { get; set; }
        public string CycleL2 { get => cyclel2; set { cyclel2 = value; OnPropertyChanged(); } }
        private string cyclel3 { get; set; }
        public string CycleL3 { get => cyclel3; set { cyclel3 = value; OnPropertyChanged(); } }
        private string cyclel4{ get; set; }
        public string CycleL4 { get => cyclel4; set { cyclel4= value; OnPropertyChanged(); } }
        private string cyclel6 { get; set; }
        public string CycleL6 { get => cyclel6; set { cyclel6 = value; OnPropertyChanged(); } }
        private string cyclel5 { get; set; }
        public string CycleL5 { get => cyclel5; set { cyclel5 = value; OnPropertyChanged(); } }
        private string cyclel7 { get; set; }
        public string CycleL7 { get => cyclel7; set { cyclel7 = value; OnPropertyChanged(); } }
        private string cyclel8{ get; set; }
        public string CycleL8 { get => cyclel8; set { cyclel8 = value; OnPropertyChanged(); } }
        private string cyclel9 { get; set; }
        public string CycleL9 { get => cyclel9; set { cyclel9 = value; OnPropertyChanged(); } }
        private string cyclel10 { get; set; }
        public string CycleL10 { get => cyclel10; set { cyclel10 = value; OnPropertyChanged(); } }
        private string cyclel11 { get; set; }
        public string CycleL11 { get => cyclel11; set { cyclel11 = value; OnPropertyChanged(); } }
        private string cyclel12 { get; set; }
        
        public string CycleL12 { get => cyclel12; set { cyclel12 = value; OnPropertyChanged(); } }

        //
        private string cycleStandard1 { get; set; }
        public string CycleStandard1 { get => cycleStandard1; set { cycleStandard1 = value; OnPropertyChanged(); } }
        private string cycleStandard2 { get; set; }
        public string CycleStandard2 { get => cycleStandard2; set { cycleStandard2 = value; OnPropertyChanged(); } }
        private string cycleStandard3 { get; set; }
        public string CycleStandard3 { get => cycleStandard3; set { cycleStandard3 = value; OnPropertyChanged(); } }
        private string cycleStandard4 { get; set; }
        public string CycleStandard4 { get => cycleStandard4; set { cycleStandard4 = value; OnPropertyChanged(); } }
        private string cycleStandard5 { get; set; }
        public string CycleStandard5 { get => cycleStandard5; set { cycleStandard5 = value; OnPropertyChanged(); } }
        private string cycleStandard6 { get; set; }
        public string CycleStandard6 { get => cycleStandard6; set { cycleStandard6 = value; OnPropertyChanged(); } }
        private string cycleStandard7 { get; set; }
        public string CycleStandard7 { get => cycleStandard7; set { cycleStandard7 = value; OnPropertyChanged(); } }
        private string cycleStandard8 { get; set; }
        public string CycleStandard8 { get => cycleStandard8; set { cycleStandard8 = value; OnPropertyChanged(); } }
        private string cycleStandard9 { get; set; }
        public string CycleStandard9 { get => cycleStandard9; set { cycleStandard9 = value; OnPropertyChanged(); } }
        private string cycleStandard10 { get; set; }
        public string CycleStandard10 { get => cycleStandard10; set { cycleStandard10 = value; OnPropertyChanged(); } }
        private string cycleStandard11 { get; set; }
        public string CycleStandard11 { get => cycleStandard11; set { cycleStandard11 = value; OnPropertyChanged(); } }
        private string cycleStandard12 { get; set; }
        public string CycleStandard12 { get => cycleStandard12; set { cycleStandard12 = value; OnPropertyChanged(); } }
        private string cycleStandard13 { get; set; }
        public string CycleStandard13 { get => cycleStandard13; set { cycleStandard13 = value; OnPropertyChanged(); } }
        private string cycleStandard14 { get; set; }
        public string CycleStandard14 { get => cycleStandard14; set { cycleStandard14 = value; OnPropertyChanged(); } }
        private string cycleStandard15 { get; set; }
        public string CycleStandard15 { get => cycleStandard15; set { cycleStandard15 = value; OnPropertyChanged(); } }
        private string cycleStandard16 { get; set; }
        public string CycleStandard16 { get => cycleStandard16; set { cycleStandard16 = value; OnPropertyChanged(); } }
        private string cycleStandard17 { get; set; }
        public string CycleStandard17 { get => cycleStandard17; set { cycleStandard17 = value; OnPropertyChanged(); } }
        private string cycleStandard18 { get; set; }
        public string CycleStandard18 { get => cycleStandard18; set { cycleStandard18 = value; OnPropertyChanged(); } }
        private string cycleStandard19 { get; set; }
        public string CycleStandard19 { get => cycleStandard19; set { cycleStandard19 = value; OnPropertyChanged(); } }
        private string cycleStandard20 { get; set; }
        public string CycleStandard20 { get => cycleStandard20; set { cycleStandard20 = value; OnPropertyChanged(); } }
        private string cycleStandard21 { get; set; }
        public string CycleStandard21 { get => cycleStandard21; set { cycleStandard21 = value; OnPropertyChanged(); } }
        private string cycleStandard22 { get; set; }
        public string CycleStandard22 { get => cycleStandard22; set { cycleStandard22 = value; OnPropertyChanged(); } }
        private string cycleStandard23 { get; set; }
        public string CycleStandard23 { get => cycleStandard23; set { cycleStandard23 = value; OnPropertyChanged(); } }
        private string cycleStandard24 { get; set; }
        public string CycleStandard24 { get => cycleStandard24; set { cycleStandard24 = value; OnPropertyChanged(); } }
        private string cycleStandard25 { get; set; }
        public string CycleStandard25 { get => cycleStandard25; set { cycleStandard25 = value; OnPropertyChanged(); } }
        private string cycleStandard26 { get; set; }
        public string CycleStandard26 { get => cycleStandard26; set { cycleStandard26 = value; OnPropertyChanged(); } }
        private string cycleStandard27 { get; set; }
        public string CycleStandard27 { get => cycleStandard27; set { cycleStandard27 = value; OnPropertyChanged(); } }
        private string cycleStandard28 { get; set; }
        public string CycleStandard28 { get => cycleStandard28; set { cycleStandard28 = value; OnPropertyChanged(); } }
        private string cycleStandardL1 { get; set; }
        public string CycleStandardL1 { get => cycleStandardL1; set { cycleStandardL1 = value; OnPropertyChanged(); } }
        private string cycleStandardL2 { get; set; }
        public string CycleStandardL2 { get => cycleStandardL2; set { cycleStandardL2 = value; OnPropertyChanged(); } }
        private string cycleStandardL3 { get; set; }
        public string CycleStandardL3 { get => cycleStandardL3; set { cycleStandardL3 = value; OnPropertyChanged(); } }
        private string cycleStandardL4 { get; set; }
        public string CycleStandardL4 { get => cycleStandardL4; set { cycleStandardL4 = value; OnPropertyChanged(); } }
        private string cycleStandardL5 { get; set; }
        public string CycleStandardL5 { get => cycleStandardL5; set { cycleStandardL5 = value; OnPropertyChanged(); } }
        private string cycleStandardL6 { get; set; }
        public string CycleStandardL6 { get => cycleStandardL6; set { cycleStandardL6 = value; OnPropertyChanged(); } }
        private string cycleStandardL7 { get; set; }
        public string CycleStandardL8 { get => cycleStandardL8; set { cycleStandardL8 = value; OnPropertyChanged(); } }
        private string cycleStandardL8 { get; set; }
        public string CycleStandardL7 { get => cycleStandardL7; set { cycleStandardL7 = value; OnPropertyChanged(); } }
        private string cycleStandardL9 { get; set; }
        public string CycleStandardL9 { get => cycleStandardL9; set { cycleStandardL9 = value; OnPropertyChanged(); } }
        private string cycleStandardL10 { get; set; }
        public string CycleStandardL10 { get => cycleStandardL10; set { cycleStandardL10 = value; OnPropertyChanged(); } }
        private string cycleStandardL11 { get; set; }
        public string CycleStandardL11 { get => cycleStandardL11; set { cycleStandardL11 = value; OnPropertyChanged(); } }
        private string cycleStandardL12 { get; set; }
        public string CycleStandardL12 { get => cycleStandardL12; set { cycleStandardL12 = value; OnPropertyChanged(); } }
        //
        private string listEvent1 { get; set; }
        public string ListEvent1 { get => listEvent1; set { listEvent1 = value; OnPropertyChanged(); } }
        private string listEvent2 { get; set; }
        public string ListEvent3 { get => listEvent3; set { listEvent3 = value; OnPropertyChanged(); } }
        private string listEvent4 { get; set; }
        public string ListEvent4 { get => listEvent4; set { listEvent4= value; OnPropertyChanged(); } }
        private string listEvent5 { get; set; }
        public string ListEvent5 { get => listEvent5; set { listEvent5 = value; OnPropertyChanged(); } }
        private string listEvent3 { get; set; }
        public string ListEvent2 { get => listEvent2; set { listEvent2 = value; OnPropertyChanged(); } }
        private string listEvent6 { get; set; }
        public string ListEvent6 { get => listEvent5; set { listEvent6 = value; OnPropertyChanged(); } }

        private string listEvent7 { get; set; }
        public string ListEvent7 { get => listEvent7; set { listEvent7 = value; OnPropertyChanged(); } }
        private string listEvent8 { get; set; }
        public string ListEvent8 { get => listEvent8; set { listEvent8 = value; OnPropertyChanged(); } }
        private string listEvent9 { get; set; }
        public string ListEvent9 { get => listEvent9; set { listEvent9 = value; OnPropertyChanged(); } }
        private string listEvent10 { get; set; }
        public string ListEvent10 { get => listEvent10; set { listEvent10 = value; OnPropertyChanged(); } }
        private string listEvent11 { get; set; }
        public string ListEvent11 { get => listEvent11; set { listEvent11 = value; OnPropertyChanged(); } }
        private string listEvent12 { get; set; }
        public string ListEvent12 { get => listEvent12; set { listEvent12 = value; OnPropertyChanged(); } }
        private string listEvent13 { get; set; }
        public string ListEvent13{ get => listEvent13; set { listEvent13= value; OnPropertyChanged(); } }
        private string listEvent14 { get; set; }
        public string ListEvent14 { get => listEvent14; set { listEvent14 = value; OnPropertyChanged(); } }
        private string listEvent15 { get; set; }
        public string ListEvent15 { get => listEvent15; set { listEvent15 = value; OnPropertyChanged(); } }
        private string listEvent16 { get; set; }
        public string ListEvent16 { get => listEvent16; set { listEvent16 = value; OnPropertyChanged(); } }
        private string listEvent17 { get; set; }
        public string ListEvent17 { get => listEvent17; set { listEvent17 = value; OnPropertyChanged(); } }
        private string listEvent18 { get; set; }
        public string ListEvent18 { get => listEvent18; set { listEvent18 = value; OnPropertyChanged(); } }
        private string listEvent19 { get; set; }
        public string ListEvent19 { get => listEvent19; set { listEvent19 = value; OnPropertyChanged(); } }
        private string listEvent20 { get; set; }
        public string ListEvent20 { get => listEvent20; set { listEvent20 = value; OnPropertyChanged(); } }
        private string listEvent21 { get; set; }
        public string ListEvent21 { get => listEvent21; set { listEvent21 = value; OnPropertyChanged(); } }
        private string listEvent22 { get; set; }
        public string ListEvent22 { get => listEvent22; set { listEvent22 = value; OnPropertyChanged(); } }
        private string listEvent23 { get; set; }
        public string ListEvent23 { get => listEvent23; set { listEvent23 = value; OnPropertyChanged(); } }
        private string listEvent24 { get; set; }
        public string ListEvent24 { get => listEvent24; set { listEvent24 = value; OnPropertyChanged(); } }
        private string listEvent25 { get; set; }
        public string ListEvent25 { get => listEvent25; set { listEvent25 = value; OnPropertyChanged(); } }
        private string listEvent26 { get; set; }
        public string ListEvent26 { get => listEvent26; set { listEvent26 = value; OnPropertyChanged(); } }
        private string listEvent27 { get; set; }
        public string ListEvent27 { get => listEvent27; set { listEvent27 = value; OnPropertyChanged(); } }
        private string listEvent28 { get; set; }
        public string ListEvent28 { get => listEvent28; set { listEvent28 = value; OnPropertyChanged(); } }
        private string listEventL1 { get; set; }
        public string ListEventL1 { get => listEventL1; set { listEventL1 = value; OnPropertyChanged(); } }
        private string listEventL2 { get; set; }
        public string ListEventL2 { get => listEventL2; set { listEventL2 = value; OnPropertyChanged(); } }
        private string listEventL3 { get; set; }
        public string ListEventL3 { get => listEventL3; set { listEventL3 = value; OnPropertyChanged(); } }
        private string listEventL4 { get; set; }
        public string ListEventL4 { get => listEventL4; set { listEventL4 = value; OnPropertyChanged(); } }
        private string listEventL5 { get; set; }
        public string ListEventL5 { get => listEventL5; set { listEventL5 = value; OnPropertyChanged(); } }
        private string listEventL6 { get; set; }
        public string ListEventL6 { get => listEventL6; set { listEventL6 = value; OnPropertyChanged(); } }
        private string listEventL8 { get; set; }
        public string ListEventL8 { get => listEventL8; set { listEventL8 = value; OnPropertyChanged(); } }
        private string listEventL7 { get; set; }
        public string ListEventL7 { get => listEventL7; set { listEventL7 = value; OnPropertyChanged(); } }
        private string listEventL9{ get; set; }
        private string listEventL10 { get; set; }
        private string listEventL11 { get; set; }

        public string ListEventL9 { get => listEventL9; set { listEventL9 = value; OnPropertyChanged(); } }
        public string ListEventL10 { get => listEventL10; set { listEventL10= value; OnPropertyChanged(); } }
        public string ListEventL { get => listEventL11; set { listEventL11 = value; OnPropertyChanged(); } }
        private string listEventL12 { get; set; }
        public string ListEventL12 { get => listEventL12; set { listEventL12 = value; OnPropertyChanged(); } }
        //
      
        
        private string mode1;
        private string mode2;
        private string mode3;
        private string mode4;
        private string mode5;
        private string mode6;
        private string mode7;
        private string mode8;
        private string mode9;
        private string mode10;
        private string mode11;
        private string mode12;
        private string mode13;
        private string mode14;
        private string mode15;
        private string mode16;
        private string mode17;
        private string mode18;
        private string mode19;
        private string mode20;
        private string mode21;
        private string mode22;
        private string mode23;
        private string mode24;
        private string mode25;
        private string mode26;
        private string mode27;
        private string mode28;
        private string modeL1;
        private string modeL2;
        private string modeL3;
        private string modeL4;
        private string modeL5;
        private string modeL6;
        private string modeL7;
        private string modeL8;
        private string modeL9;
        private string modeL10;
        private string modeL11;
        private string modeL12;
        public string ModeL1 { get => modeL1; set { modeL1 = value; OnPropertyChanged(); } }
        public string ModeL2 { get => modeL2; set { modeL2 = value; OnPropertyChanged(); } }
        public string ModeL3 { get => modeL3; set { modeL3 = value; OnPropertyChanged(); } }
        public string ModeL4 { get => modeL4; set { modeL4 = value; OnPropertyChanged(); } }
        public string ModeL5 { get => modeL5; set { modeL5 = value; OnPropertyChanged(); } }
        public string ModeL6 { get => modeL6; set { modeL6 = value; OnPropertyChanged(); } }
        public string ModeL7 { get => modeL7; set { modeL7 = value; OnPropertyChanged(); } }
        public string ModeL8 { get => modeL8; set { modeL8 = value; OnPropertyChanged(); } }
        public string ModeL9 { get => modeL9; set { modeL9 = value; OnPropertyChanged(); } }
        public string ModeL10 { get => modeL10; set { modeL10 = value; OnPropertyChanged(); } }
        public string ModeL11 { get => modeL11; set { modeL11 = value; OnPropertyChanged(); } }
        public string ModeL12 { get => modeL12; set { modeL12 = value; OnPropertyChanged(); } }
        public string Mode1 { get => mode1; set { mode1 = value; OnPropertyChanged(); } }
        public string Mode2 { get => mode2; set { mode2 = value; OnPropertyChanged(); } }
        public string Mode3 { get => mode3; set { mode3 = value; OnPropertyChanged(); } }
        public string Mode4 { get => mode4; set { mode4 = value; OnPropertyChanged(); } }
        public string Mode5 { get => mode5; set { mode5 = value; OnPropertyChanged(); } }
        public string Mode6 { get => mode6; set { mode6 = value; OnPropertyChanged(); } }
        public string Mode7 { get => mode7; set { mode7 = value; OnPropertyChanged(); } }
        public string Mode8 { get => mode8; set { mode8 = value; OnPropertyChanged(); } }
        public string Mode9 { get => mode9; set { mode9 = value; OnPropertyChanged(); } }
        public string Mode10 { get => mode10; set { mode10 = value; OnPropertyChanged(); } }
        public string Mode11 { get => mode11; set { mode11 = value; OnPropertyChanged(); } }
        public string Mode12 { get => mode12; set { mode12 = value; OnPropertyChanged(); } }
        public string Mode13 { get => mode13; set { mode13 = value; OnPropertyChanged(); } }
        public string Mode14 { get => mode14; set { mode14 = value; OnPropertyChanged(); } }
        public string Mode15 { get => mode15; set { mode15 = value; OnPropertyChanged(); } }
        public string Mode16 { get => mode16; set { mode16 = value; OnPropertyChanged(); } }
        public string Mode17 { get => mode17; set { mode17 = value; OnPropertyChanged(); } }
        public string Mode18 { get => mode18; set { mode18 = value; OnPropertyChanged(); } }
        public string Mode19 { get => mode19; set { mode19 = value; OnPropertyChanged(); } }
        public string Mode20 { get => mode20; set { mode20 = value; OnPropertyChanged(); } }
        public string Mode21 { get => mode21; set { mode21 = value; OnPropertyChanged(); } }
        public string Mode22 { get => mode22; set { mode22 = value; OnPropertyChanged(); } }
        public string Mode23 { get => mode23; set { mode23 = value; OnPropertyChanged(); } }
        public string Mode24 { get => mode24; set { mode24 = value; OnPropertyChanged(); } }
        public string Mode25 { get => mode25; set { mode25 = value; OnPropertyChanged(); } }
        public string Mode26 { get => mode26; set { mode26 = value; OnPropertyChanged(); } }
        public string Mode27 { get => mode27; set { mode27 = value; OnPropertyChanged(); } }
        public string Mode28 { get => mode28; set { mode28 = value; OnPropertyChanged(); } }

        //
        private bool a1;
        public bool A1 { get => a1; set { a1 = value; OnPropertyChanged(); } }
        private bool a2;
        public bool A2 { get => a2; set { a2 = value; OnPropertyChanged(); } }
        private bool a3;
        public bool A4 { get => a4; set { a4 = value; OnPropertyChanged(); } }
        private bool a5;
        public bool A5 { get => a5; set { a5 = value; OnPropertyChanged(); } }
        private bool a6;
        public bool A6 { get => a6; set { a6 = value; OnPropertyChanged(); } }
        private bool a4;
        public bool A7 { get => a7; set { a7 = value; OnPropertyChanged(); } }
        private bool a7;
        public bool A8 { get => a8; set { a8 = value; OnPropertyChanged(); } }
        private bool a8;
        public bool A3 { get => a3; set { a3 = value; OnPropertyChanged(); } }
        private bool a9;
        public bool A9 { get => a9; set { a9 = value; OnPropertyChanged(); } }
        private bool a10;
        public bool A10 { get => a10; set { a10 = value; OnPropertyChanged(); } }
        private bool a11;
        public bool A11 { get => a11; set { a11 = value; OnPropertyChanged(); } }
        private bool a12;
        public bool A12 { get => a12; set { a12 = value; OnPropertyChanged(); } }
        private bool a13;
        public bool A13 { get => a13; set { a13 = value; OnPropertyChanged(); } }
        private bool a14;
        public bool A14 { get => a14; set { a14 = value; OnPropertyChanged(); } }
        private bool a15;
        public bool A15 { get => a15; set { a15 = value; OnPropertyChanged(); } }
        private bool a16;
        public bool A16 { get => a16; set { a16 = value; OnPropertyChanged(); } }
        private bool a17;
        public bool A17 { get => a17; set { a17 = value; OnPropertyChanged(); } }
        private bool a18;
        public bool A18 { get => a18; set { a18 = value; OnPropertyChanged(); } }
        private bool a19;
        public bool A19 { get => a19; set { a19 = value; OnPropertyChanged(); } }
        private bool a20;
        public bool A20 { get => a20; set { a20 = value; OnPropertyChanged(); } }
        private bool a21;
        public bool A22 { get => a22; set { a22 = value; OnPropertyChanged(); } }
        private bool a22;
        public bool A21 { get => a21; set { a21 = value; OnPropertyChanged(); } }
        private bool a23;
        public bool A23 { get => a23; set { a23 = value; OnPropertyChanged(); } }
        private bool a24;
        public bool A24 { get => a24; set { a24 = value; OnPropertyChanged(); } }
        private bool a25;
        public bool A25 { get => a25; set { a25 = value; OnPropertyChanged(); } }
        private bool a26;
        public bool A26 { get => a26; set { a26 = value; OnPropertyChanged(); } }
        private bool a27;
        public bool A27 { get => a27; set { a27 = value; OnPropertyChanged(); } }
        private bool a28;
        public bool A28 { get => a28; set { a28 = value; OnPropertyChanged(); } }
        private bool aL1;
        public bool AL1 { get => aL1; set { aL1 = value; OnPropertyChanged(); } }
        private bool aL2;
        public bool AL2 { get => aL2; set { aL2 = value; OnPropertyChanged(); } }
        private bool aL3;
        public bool AL3 { get => aL3; set { aL3 = value; OnPropertyChanged(); } }
        private bool aL4;
        public bool AL4 { get => aL4; set { aL4 = value; OnPropertyChanged(); } }
        private bool aL5;
        public bool AL5 { get => aL5; set { aL5 = value; OnPropertyChanged(); } }
        private bool aL6;
        public bool AL6 { get => aL6; set { aL6 = value; OnPropertyChanged(); } }
        private bool aL7;
        public bool AL7 { get => aL7; set { aL7 = value; OnPropertyChanged(); } }
        private bool aL8;
        public bool AL8{ get => aL8; set { aL8 = value; OnPropertyChanged(); } }
        private bool aL9;
        public bool AL9 { get => aL9; set { aL9 = value; OnPropertyChanged(); } }
        private bool aL10;
        public bool AL10 { get => aL10; set { aL10 = value; OnPropertyChanged(); } }

        private bool aL11;
        public bool AL11 { get => aL11; set { aL11 = value; OnPropertyChanged(); } }
        private bool aL12;
        public bool AL12 { get => aL12; set { aL12 = value; OnPropertyChanged(); } }
        //
        private bool b1;
        public bool B1 { get => b1; set { b1 = value; OnPropertyChanged(); } }
        private bool b2;
        public bool B2 { get => b2; set { b2 = value; OnPropertyChanged(); } }
        private bool b3;
        public bool B4 { get => b4; set { b4 = value; OnPropertyChanged(); } }
        private bool b5;
        public bool B5 { get => b5; set { b5 = value; OnPropertyChanged(); } }
        private bool b6;
        public bool B6 { get => b6; set { b6 = value; OnPropertyChanged(); } }
        private bool b4;
        public bool B7 { get => b7; set { b7 = value; OnPropertyChanged(); } }
        private bool b7;
        public bool B8 { get => b8; set { b8 = value; OnPropertyChanged(); } }
        private bool b8;
        public bool B3 { get => b3; set { b3 = value; OnPropertyChanged(); } }
        private bool b9;
        public bool B9 { get => b9; set { b9 = value; OnPropertyChanged(); } }
        private bool b10;
        public bool B10 { get => b10; set { b10 = value; OnPropertyChanged(); } }
        private bool b11;
        public bool B11 { get => b11; set { b11 = value; OnPropertyChanged(); } }
        private bool b12;
        public bool B12 { get => b12; set { b12 = value; OnPropertyChanged(); } }
        private bool b13;
        public bool B13 { get => b13; set { b13 = value; OnPropertyChanged(); } }
        private bool b14;
        public bool B14 { get => b14; set { b14 = value; OnPropertyChanged(); } }
        private bool b15;
        public bool B15 { get => b15; set { b15 = value; OnPropertyChanged(); } }
        private bool b16;
        public bool B16 { get => b16; set { b16 = value; OnPropertyChanged(); } }
        private bool b17;
        public bool B17 { get => b17; set { b17 = value; OnPropertyChanged(); } }
        private bool b18;
        public bool B18 { get => b18; set { b18 = value; OnPropertyChanged(); } }
        private bool b19;
        public bool B19 { get => b19; set { b19 = value; OnPropertyChanged(); } }
        private bool b20;
        public bool B20 { get => b20; set { b20 = value; OnPropertyChanged(); } }
        private bool b21;
        public bool B22 { get => b22; set { b22 = value; OnPropertyChanged(); } }
        private bool b22;
        public bool B21 { get => b21; set { b21 = value; OnPropertyChanged(); } }
        private bool b23;
        public bool B23 { get => b23; set { b23 = value; OnPropertyChanged(); } }
        private bool b24;
        public bool B24 { get => b24; set { b24 = value; OnPropertyChanged(); } }
        private bool b25;
        public bool B25 { get => b25; set { b25 = value; OnPropertyChanged(); } }
        private bool b26;
        public bool B26 { get => b26; set { b26 = value; OnPropertyChanged(); } }
        private bool b27;
        public bool B27 { get => b27; set { b27 = value; OnPropertyChanged(); } }
        private bool b28;
        public bool B28 { get => b28; set { b28 = value; OnPropertyChanged(); } }
        private bool bL1;
        public bool BL1 { get => bL1; set { bL1 = value; OnPropertyChanged(); } }
        private bool bL2;
        public bool BL2 { get => bL2; set { bL2 = value; OnPropertyChanged(); } }
        private bool bL3;
        public bool BL3 { get => bL3; set { bL3 = value; OnPropertyChanged(); } }
        private bool bL4;
        public bool BL4 { get => bL4; set { bL4 = value; OnPropertyChanged(); } }
        private bool bL5;
        public bool BL5 { get => bL5; set { bL5 = value; OnPropertyChanged(); } }
        private bool bL6;
        public bool BL6 { get => bL6; set { bL6 = value; OnPropertyChanged(); } }
        private bool bL7;
        public bool BL7 { get => bL7; set { bL7 = value; OnPropertyChanged(); } }
        private bool bL8;
        public bool BL8 { get => bL8; set { bL8 = value; OnPropertyChanged(); } }
        private bool bL9;
        public bool BL9 { get => bL9; set { bL9 = value; OnPropertyChanged(); } }
        private bool bL10;
        public bool BL10 { get => bL10; set { bL10 = value; OnPropertyChanged(); } }
        private bool bL11;
        public bool BL11 { get => bL11; set { bL11 = value; OnPropertyChanged(); } }
        private bool bL12;
        public bool BL12 { get => bL12; set { bL12 = value; OnPropertyChanged(); } }
        //
        private string content1;
        public string Content1 { get => content1; set { content1 = value; OnPropertyChanged(); } }
        private string content2;
        public string Content2 { get => content2; set { content2 = value; OnPropertyChanged(); } }
        private string content3;
        public string Content3 { get => content3; set { content3 = value; OnPropertyChanged(); } }
        private string content4;
        public string Content4 { get => content4; set { content4 = value; OnPropertyChanged(); } }
        private string content5;
        public string Content5 { get => content5; set { content5 = value; OnPropertyChanged(); } }
        private string content6;
        public string Content6 { get => content6; set { content6 = value; OnPropertyChanged(); } }
        private string content7;
        public string Content7 { get => content7; set { content7 = value; OnPropertyChanged(); } }
        private string content8;
        public string Content8 { get => content8; set { content8 = value; OnPropertyChanged(); } }
        private string content9;
        public string Content9 { get => content9; set { content9 = value; OnPropertyChanged(); } }
        private string content10;
        public string Content10 { get => content10; set { content10 = value; OnPropertyChanged(); } }
        private string content11;
        public string Content11 { get => content11; set { content11 = value; OnPropertyChanged(); } }
        private string content12;
        public string Content12 { get => content12; set { content12 = value; OnPropertyChanged(); } }
        private string content13;
        public string Content13 { get => content13; set { content13 = value; OnPropertyChanged(); } }
        private string content14;
        public string Content14 { get => content14; set { content14 = value; OnPropertyChanged(); } }
        private string content15;
        public string Content15 { get => content15; set { content15 = value; OnPropertyChanged(); } }
        private string content16;
        public string Content16 { get => content16; set { content16 = value; OnPropertyChanged(); } }
        private string content17;
        public string Content17 { get => content17; set { content17 = value; OnPropertyChanged(); } }
        private string content18;
        public string Content18 { get => content18; set { content18 = value; OnPropertyChanged(); } }
        private string content19;
        public string Content19 { get => content19; set { content19 = value; OnPropertyChanged(); } }
        private string content20;
        public string Content20 { get => content20; set { content20 = value; OnPropertyChanged(); } }
        private string content21;
        public string Content21 { get => content21; set { content21 = value; OnPropertyChanged(); } }
        private string content22;
        public string Content22 { get => content22; set { content22 = value; OnPropertyChanged(); } }
        private string content23;
        public string Content23 { get => content23; set { content23 = value; OnPropertyChanged(); } }
        private string content24;
        public string Content24 { get => content24; set { content24 = value; OnPropertyChanged(); } }
        private string content25;
        public string Content25 { get => content25; set { content25 = value; OnPropertyChanged(); } }
        private string content26;
        public string Content26 { get => content26; set { content26 = value; OnPropertyChanged(); } }
        private string content27;
        public string Content27 { get => content27; set { content27 = value; OnPropertyChanged(); } }
        private string content28;
        public string Content28 { get => content28; set { content28 = value; OnPropertyChanged(); } }
        private string contentL1;
        public string ContentL1 { get => contentL1; set { contentL1 = value; OnPropertyChanged(); } }
        private string contentL2;
        public string ContentL2 { get => contentL2; set { contentL2 = value; OnPropertyChanged(); } }
        private string contentL3;
        public string ContentL3 { get => contentL3; set { contentL3 = value; OnPropertyChanged(); } }
        private string contentL4;
        public string ContentL4 { get => contentL4; set { contentL4 = value; OnPropertyChanged(); } }
        private string contentL5;
        public string ContentL5 { get => contentL5; set { contentL5 = value; OnPropertyChanged(); } }
        private string contentL6;
        public string ContentL6 { get => contentL6; set { contentL6 = value; OnPropertyChanged(); } }
        private string contentL7;
        public string ContentL7 { get => contentL7; set { contentL7 = value; OnPropertyChanged(); } }
        private string contentL8;
        public string ContentL8 { get => contentL8; set { contentL8 = value; OnPropertyChanged(); } }
        private string contentL9;
        public string ContentL9 { get => contentL9; set { contentL9 = value; OnPropertyChanged(); } }
        private string contentL10;
        public string ContentL10 { get => contentL10; set { contentL10 = value; OnPropertyChanged(); } }
        private string contentL11;
        public string ContentL11 { get => contentL11; set { contentL11 = value; OnPropertyChanged(); } }
        private string contentL12;
        public string ContentL12 { get => contentL12; set { contentL12 = value; OnPropertyChanged(); } }
        //
        private string statusL1;
        public string StatusL1 { get => statusL1; set { statusL1 = value; OnPropertyChanged(); } }
        private string statusL2;
        public string StatusL2 { get => statusL2; set { statusL2 = value; OnPropertyChanged(); } }
        private string statusL3;
        public string StatusL3 { get => statusL3; set { statusL3 = value; OnPropertyChanged(); } }
        private string statusL4;
        public string StatusL4 { get => statusL4; set { statusL4 = value; OnPropertyChanged(); } }
        private string statusL5;
        public string StatusL5 { get => statusL5; set { statusL5 = value; OnPropertyChanged(); } }
        private string statusL6;
        public string StatusL6 { get => statusL6; set { statusL6 = value; OnPropertyChanged(); } }
        private string statusL7;
        public string StatusL7 { get => statusL7; set { statusL7 = value; OnPropertyChanged(); } }
        private string statusL8;
        public string StatusL8 { get => statusL8; set { statusL8 = value; OnPropertyChanged(); } }
        private string statusL9;
        public string StatusL9 { get => statusL9; set { statusL9 = value; OnPropertyChanged(); } }
        private string statusL10;
        public string StatusL10 { get => statusL10; set { statusL10 = value; OnPropertyChanged(); } }
        private string statusL11;
        public string StatusL11 { get => statusL11; set { statusL11 = value; OnPropertyChanged(); } }
        private string statusL12;
        public string StatusL12 { get => statusL12; set { statusL12 = value; OnPropertyChanged(); } }
        //
        private string status1;
        public string Status1 { get => status1; set { status1 = value; OnPropertyChanged(); } }
        private string status2;
        public string Status2 { get => status2; set { status2 = value; OnPropertyChanged(); } }
        private string status3;
        public string Status3 { get => status3; set { status3 = value; OnPropertyChanged(); } }
        private string status4;
        public string Status4 { get => status4; set { status4 = value; OnPropertyChanged(); } }
        private string status5;
        public string Status5 { get => status5; set { status5 = value; OnPropertyChanged(); } }
        private string status6;
        public string Status6 { get => status6; set { status6 = value; OnPropertyChanged(); } }
        private string status7;
        public string Status7 { get => status7; set { status7 = value; OnPropertyChanged(); } }
        private string status8;
        public string Status8 { get => status8; set { status8 = value; OnPropertyChanged(); } }
        private string status9;
        public string Status9 { get => status9; set { status9 = value; OnPropertyChanged(); } }
        private string status10;
        public string Status10 { get => status10; set { status10 = value; OnPropertyChanged(); } }
        private string status11;
        public string Status11 { get => status11; set { status11 = value; OnPropertyChanged(); } }
        private string status12;
        public string Status12 { get => status12; set { status12 = value; OnPropertyChanged(); } }
        private string status13;
        public string Status13 { get => status13; set { status13 = value; OnPropertyChanged(); } }
        private string status14;
        public string Status14 { get => status14; set { status14 = value; OnPropertyChanged(); } }
        private string status15;
        public string Status15 { get => status15; set { status15 = value; OnPropertyChanged(); } }
        private string status16;
        public string Status16 { get => status16; set { status16 = value; OnPropertyChanged(); } }
        private string status17;
        public string Status17 { get => status17; set { status17 = value; OnPropertyChanged(); } }
        private string status18;
        public string Status18 { get => status18; set { status18 = value; OnPropertyChanged(); } }
        private string status19;
        public string Status19 { get => status19; set { status19 = value; OnPropertyChanged(); } }
        private string status20;
        public string Status20 { get => status20; set { status20 = value; OnPropertyChanged(); } }
        private string status21;
        public string Status21 { get => status21; set { status21 = value; OnPropertyChanged(); } }
        private string status22;
        public string Status22 { get => status22; set { status22 = value; OnPropertyChanged(); } }
        private string status23;
        public string Status23 { get => status23; set { status23 = value; OnPropertyChanged(); } }
        private string status24;
        public string Status24 { get => status24; set { status24 = value; OnPropertyChanged(); } }
        private string status25;
        public string Status25 { get => status25; set { status25 = value; OnPropertyChanged(); } }
        private string status26;
        public string Status26 { get => status26; set { status26 = value; OnPropertyChanged(); } }
        private string status27;
        public string Status27 { get => status27; set { status27 = value; OnPropertyChanged(); } }
        private string status28;
        public string Status28 { get => status28; set { status28 = value; OnPropertyChanged(); } }
        /// <summary>
        ///
        /// </summary>
        #endregion var
        private ObservableCollection<Product> listProduct;
        public ObservableCollection<Product> ListProduct
        {
            get => listProduct; set
            {
                listProduct = value; OnPropertyChanged();
            }
        }
        private ObservableCollection<Mold> listMold;
        public ObservableCollection<Mold> ListMold { get => listMold; set { listMold = value; } }
        private ObservableCollection<Employee> listEmployee;
        public ObservableCollection<Employee> ListEmployee { get => listEmployee; set { listEmployee = value; OnPropertyChanged(); } }
        private ObservableCollection<Machine> listMachine;
        public ObservableCollection<Machine> ListMachine { get => listMachine; set { listMachine = value; OnPropertyChanged(); } }
        public delegate void ReceiveCycleMessage(CycleMessage Message);
        public static ReceiveCycleMessage Sender;


        public delegate void ReceiveMachineMessage(MachineMessage Message);
        public static ReceiveMachineMessage MachineMessage;
        private Product product;
        public Product Product { get => product; set { product = value; OnPropertyChanged();
                try {
                    foreach (var item in ListMold)
                    {
                        if (Product.MoldId == item.Id)
                        {
                            Mold = item;
                            break;
                        }
                    }
                    
                    Cycle = Mold.StandardInjectionCycle.ToString();
                }catch (Exception ex)
                {

                }

            
            } }
       
       
        private Mold mold;
        public Mold Mold { get => mold; set { mold = value; OnPropertyChanged(); } }
        private string cycle;
        public string Cycle { get => cycle; set { cycle = value; OnPropertyChanged(); } }
        private HttpClient httpClient;
        private HttpRequestMessage httpRequest;
        private IBusControl _bus;
        private IDatabaseServices _databaseServices;
        private IApiServices _apiServices;  
        public ICommand PauseCommand { get; set; }

        //IBusControl bus
        //IDatabaseServices databaseServices
        public DetailMachineViewModel() {
            //_bus = bus;
            //_databaseServices = databaseServices;
            Content = "Tạm dừng";
            Animation1 = true;
            Animation2 = false;
            Sender = new ReceiveCycleMessage(GetCycleMessage);
            MachineMessage = new ReceiveMachineMessage(GetMachineStatus);
            ListMold = new ObservableCollection<Mold>();
            ListMachine = new ObservableCollection<Machine>();
            ListEmployee = new ObservableCollection<Employee>();
            GetProductTotal("");
            GetMoldTotal("");

            #region int
            StatusL1 = "1";
            StatusL2 = "1";
            StatusL3 = "1";
            StatusL4 = "1";
            StatusL5 = "1";
            StatusL6 = "1";
            StatusL7 = "1";
            StatusL8 = "1";
            StatusL9 = "1";
            StatusL10 = "1";
            StatusL11 = "1";
            StatusL12 = "1";
            Status1 = "1";
            Status2 = "1";
            Status3 = "1";
            Status4 = "1";
            Status5 = "1";
            Status6 = "1";
            Status7 = "1";
            Status8 = "1";
            Status9 = "1";
            Status10 = "1";
            Status11 = "1";
            Status12 = "1";
            Status13 = "1";
            Status14 = "1";
            Status15 = "1";
            Status16 = "1";
            Status17 = "1";
            Status18 = "1";
            Status19 = "1";
            Status20 = "1";
            Status21 = "1";
            Status22 = "1";
            Status23 = "1";
            Status24 = "1";
            Status25 = "1";
            Status26 = "1";
            Status27 = "1";
            Status28 = "1";
            A1 = true;
                    B1 = false;
                    Content1 = "Tạm dừng";

                    A3 = true;
                    B3 = false;
                    Content2 = "Tạm dừng";

                    A3 = true;
                    B3 = false;
                    Content3 = "Tạm dừng";

                    A4 = true;
                    B4 = false;
                    Content4 = "Tạm dừng";

                    A5 = true;
                    B5 = false;
                    Content5 = "Tạm dừng";

                    A6 = true;
                    B6 = false;
                    Content6 = "Tạm dừng";

                    A7 = true;
                    B7 = false;
                    Content7 = "Tạm dừng";

                    A8 = true;
                    B8 = false;
                    Content8 = "Tạm dừng";

                    A9 = true;
                    B9 = false;
                    Content9 = "Tạm dừng";

                    A10 = true;
                    B10 = false;
                    Content10 = "Tạm dừng";

                    A11 = true;
                    B11 = false;
                    Content11 = "Tạm dừng";

                    A12 = true;
                    B12 = false;
                    Content12 = "Tạm dừng";
  
                    A13 = true;
                    B13 = false;
                    Content13 = "Tạm dừng";

                    A14 = true;
                    B14 = false;
                    Content14 = "Tạm dừng";

                    A15 = true;
                    B15 = false;
                    Content15 = "Tạm dừng";

                    A16 = true;
                    B16 = false;
                    Content16 = "Tạm dừng";

                    A17 = true;
                    B17 = false;
                    Content17 = "Tạm dừng";


                    A18 = true;
                    B18 = false;
                    Content18 = "Tạm dừng";

                    A19 = true;
                    B19 = false;
                    Content19 = "Tạm dừng";

                    A20 = true;
                    B20 = false;
                    Content20 = "Tạm dừng";

                    A21 = true;
                    B21 = false;
                    Content21 = "Tạm dừng";

                    A22 = true;
                    B22 = false;
                    Content22 = "Tạm dừng";

                    A23 = true;
                    B23 = false;
                    Content23 = "Tạm dừng";

                    A24 = true;
                    B24 = false;
                    Content24 = "Tạm dừng";

                    A25 = true;
                    B25 = false;
                    Content25 = "Tạm dừng";

                    A26 = true;
                    B26 = false;
                    Content26 = "Tạm dừng";



                    A27 = true;
                    B27 = false;
                    Content27 = "Tạm dừng";


                    A28 = true;
                    B28 = false;
                    Content28 = "Tạm dừng";

                    AL1 = true;
                    BL1 = false;
                    ContentL1 = "Tạm dừng";


                    AL2 = true;
                    BL2 = false;
                    ContentL2 = "Tạm dừng";

                    AL3 = true;
                    BL3 = false;
                    ContentL3 = "Tạm dừng";

                    AL4 = true;
                    BL4 = false;
                    ContentL4 = "Tạm dừng";

                    AL5 = true;
                    BL5 = false;
                    ContentL5 = "Tạm dừng";

                    AL6 = true;
                    BL6 = false;
                    ContentL6 = "Tạm dừng";

                    AL7 = true;
                    BL7 = false;
                    ContentL7 = "Tạm dừng";

                    AL8 = true;
                    BL8 = false;
                    ContentL8 = "Tạm dừng";

                    AL9 = true;
                    BL9 = false;
                    ContentL9 = "Tạm dừng";

                    AL10 = true;
                    BL10 = false;
                    ContentL10 = "Tạm dừng";

                    AL11 = true;
                    BL11 = false;
                    ContentL11 = "Tạm dừng";

                    AL12 = true;
                    BL12 = false;
                    ContentL12 = "Tạm dừng";


            #endregion int

            // _apiServices = apiServices;
            PauseCommand = new RelayObjectCommand<object>((p) => { return p == null ? false : true; }, async (p) => Pause(p));
          

        }
        public async  void Command(CommandMessage commandMessage)
        {
            var endpoint = await _bus.GetSendEndpoint(new Uri("http://127.0.0.1:8181/send-config"));
            await endpoint.Send<CommandMessage>(commandMessage);
        }
        public async  void ConfigCommand(ConfigurationMessage configMessage)
        {
            var endpoint = await _bus.GetSendEndpoint(new Uri("http://127.0.0.1:8181/send-config"));
            await endpoint.Send<ConfigurationMessage>(configMessage);
        }
        private void GetMachineStatus(MachineMessage Message)
        {

            switch (Message.MachineId)
            {
                case "M1":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status1 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status1 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status1 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status1 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status1 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status1 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status1 = "7";
                            break;

                    }

                    break;
                case "M2":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status2 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status2 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status2 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status2 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status2 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status2 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status2 = "7";
                            break;

                    }

                    break;
                case "M3":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status3 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status3 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status3 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status3 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status3 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status3 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status3 = "7";
                            break;

                    }

                    break;
                case "M4":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status4 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status4 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status4 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status4 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status4 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status4 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status4 = "7";
                            break;

                    }

                    break;
                case "M5":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status5 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status5 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status5 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status5 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status5 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status5 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status5 = "7";
                            break;

                    }

                    break;
                case "M6":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status6 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status6 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status6 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status6 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status6 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status6 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status6 = "7";
                            break;

                    }

                    break;
                case "M7":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status7 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status7 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status7 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status7 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status7 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status7 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status7 = "7";
                            break;

                    }

                    break;
                case "M8":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status8 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status8 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status8 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status8 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status8 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status8 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status8 = "7";
                            break;

                    }

                    break;
                case "M9":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status9 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status9 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status9 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status9 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status9 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status9 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status9 = "7";
                            break;

                    }

                    break;
                case "M10":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status10 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status10 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status10 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status10 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status10 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status10 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status10 = "7";
                            break;

                    }

                    break;
                case "M11":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status11 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status11 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status11 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status11 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status11 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status11 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status11 = "7";
                            break;

                    }

                    break;
                case "M12":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status12 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status12 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status12 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status12 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status12 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status12 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status12 = "7";
                            break;

                    }

                    break;
                case "M13":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status13 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status13 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status13 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status13 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status13 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status13 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status13 = "7";
                            break;

                    }

                    break;
                case "M14":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status14 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status14 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status14 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status14 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status14 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status14 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status14 = "7";
                            break;

                    }

                    break;
                case "M15":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status15 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status15 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status15 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status15 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status15 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status15 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status15 = "7";
                            break;

                    }
                    break;
                case "M16":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status16 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status16 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status16 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status16 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status16 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status16 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status16 = "7";
                            break;

                    }
                    break;
                case "M17":

                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status17 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status17 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status17 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status17 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status17 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status17 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status17 = "7";
                            break;

                    }
                    break;
                case "M18":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status18 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status18 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status18 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status18 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status18 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status18 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status18 = "7";
                            break;

                    }
                    break;
                case "M19":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status19 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status19 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status19 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status19 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status19 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status19 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status19 = "7";
                            break;

                    }
                    break;
                case "M20":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status20 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status20 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status20 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status20 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status20 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status20 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status20 = "7";
                            break;

                    }
                    break;
                case "M21":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status21 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status21 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status21 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status21 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status21 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status21 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status21 = "7";
                            break;

                    }
                    break;
                case "M22":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status22 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status22 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status22 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status22 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status22 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status22 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status22 = "7";
                            break;

                    }
                    break;
                case "M23":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status23 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status23 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status23 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status23 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status23 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status23 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status23 = "7";
                            break;

                    }
                    break;
                case "M24":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status24 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status24 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status24 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status24 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status24 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status24 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status24 = "7";
                            break;

                    }
                    break;
                case "M25":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status25 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status25 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status25 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status25 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status25 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status25 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status25 = "7";
                            break;

                    }
                    break;
                case "M26":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status26 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status26 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status26 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status26 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status26 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status26 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status26 = "7";
                            break;

                    }
                    break;
                case "M27":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status27 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status27 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status27 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status27 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status27 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status27 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status27 = "7";
                            break;

                    }
                    break;
                case "M28":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            Status28 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status28 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            Status28 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            Status28 = "4";
                            break;
                        case EMachineStatus.Idle:
                            Status28 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status28 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            Status28 = "7";
                            break;

                    }
                    break;
                case "L1":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            StatusL1 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            StatusL1 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            StatusL1 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            StatusL1 = "4";
                            break;
                        case EMachineStatus.Idle:
                            StatusL1 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            StatusL1 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            StatusL1 = "7";
                            break;

                    }
                    break;
                case "L2":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            StatusL2 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            StatusL2 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            StatusL2 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            StatusL2 = "4";
                            break;
                        case EMachineStatus.Idle:
                            StatusL2 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            StatusL2 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            StatusL2 = "7";
                            break;

                    }
                    break;
                case "L3":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            StatusL3 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            StatusL3 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            StatusL3 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            StatusL3 = "4";
                            break;
                        case EMachineStatus.Idle:
                            StatusL3 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            Status1 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            StatusL3 = "7";
                            break;

                    }
                    break;
                case "L4":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            StatusL4 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            StatusL4 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            StatusL4 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            StatusL4 = "4";
                            break;
                        case EMachineStatus.Idle:
                            StatusL4 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            StatusL4 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            StatusL4 = "7";
                            break;

                    }
                    break;
                case "L5":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            StatusL5 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            StatusL5 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            StatusL5 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            StatusL5 = "4";
                            break;
                        case EMachineStatus.Idle:
                            StatusL5 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            StatusL5 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            StatusL5 = "7";
                            break;

                    }
                    break;
                case "L6":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            StatusL6 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            StatusL6 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            StatusL6 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            StatusL6 = "4";
                            break;
                        case EMachineStatus.Idle:
                            StatusL6 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            StatusL6 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            StatusL6 = "7";
                            break;

                    }
                    break;
                case "L7":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            StatusL7 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            StatusL7 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            StatusL7 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            StatusL7 = "4";
                            break;
                        case EMachineStatus.Idle:
                            StatusL7 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            StatusL7 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            StatusL7 = "7";
                            break;

                    }
                    break;
                case "L8":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            StatusL8 = "1";
                            break;
                        //case EMachineStatus.PowerOn:
                        //    StatusL8 = "2";
                           
                        case EMachineStatus.Disconnect:
                            StatusL8 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            StatusL8 = "4";
                            break;
                        case EMachineStatus.Idle:
                            StatusL8 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            StatusL8 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            StatusL8 = "7";
                            break;

                    }
                    break;
                case "L9":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            StatusL9 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            Status1 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            StatusL9 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            StatusL9 = "4";
                            break;
                        case EMachineStatus.Idle:
                            StatusL9 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            StatusL9 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            StatusL9 = "7";
                            break;

                    }
                    break;
                case "L10":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            StatusL10 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            StatusL10 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            StatusL10 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            StatusL10 = "4";
                            break;
                        case EMachineStatus.Idle:
                            StatusL10 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            StatusL10 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            StatusL10 = "7";
                            break;

                    }
                    break;
                case "L11":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            StatusL11 = "1";
                            break;
                        case EMachineStatus.PowerOn:
                            StatusL11 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            StatusL11 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            StatusL11 = "4";
                            break;
                        case EMachineStatus.Idle:
                            StatusL11 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            StatusL11 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            StatusL11 = "7";
                            break;

                    }
                    break;
                case "L12":
                    switch (Message.MachineStatus)
                    {
                        case EMachineStatus.PowerOff:
                            StatusL12 = "1";
                            break;

                        case EMachineStatus.PowerOn:
                            StatusL12 = "2";
                            break;
                        case EMachineStatus.Disconnect:
                            StatusL12 = "3";
                            break;
                        case EMachineStatus.OnProduction:
                            StatusL12 = "4";
                            break;
                        case EMachineStatus.Idle:
                            StatusL12 = "5";
                            break;
                        case EMachineStatus.ErrorOnGoing:
                            StatusL12 = "6";
                            break;
                        case EMachineStatus.ErrorOutGoing:
                            StatusL12 = "7";
                            break;

                    }
                    break;
                default:
                    break;

            }

        }   
         private  void GetCycleMessage(CycleMessage Message)
        {
            
           
            switch (Message.MachineId)
            {
                case "M1":
                    Count1 = Message.CounterShot.ToString();
                    ProductId1 = Message.ProductId.ToString();
                    CycleStandard1 = Message.SetCycle.ToString();
                    Cycle1 = Message.CycleTime.ToString();  
                    MoldId1 = Message.MoldId.ToString();
                    if(Message.Mode == 1)
                    {
                        Mode1 = "Tự động";
                    }
                    else
                    {
                        Mode1 = "Bán Tự động";
                    }

                    break;
                case "M2":
                    Count2 = Message.CounterShot.ToString();
                    ProductId2 = Message.ProductId.ToString();
                    CycleStandard2 = Message.SetCycle.ToString();
                    Cycle2 = Message.CycleTime.ToString();
                    MoldId2 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode2 = "Tự động";
                    }
                    else
                    {
                        Mode2 = "Bán Tự động";
                    }
                    break;
                case "M3":
                    Count3 = Message.CounterShot.ToString();
                    ProductId3 = Message.ProductId.ToString();
                    ProductId3 = Message.ProductId.ToString();
                    CycleStandard3 = Message.SetCycle.ToString();
                    Cycle3 = Message.CycleTime.ToString();
                    MoldId3 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode3 = "Tự động";
                    }
                    else
                    {
                        Mode3 = "Bán Tự động";
                    }
                    break;
                case "M4":
                    Count4 = Message.CounterShot.ToString();
                    ProductId4 = Message.ProductId.ToString();
                    CycleStandard4 = Message.SetCycle.ToString();
                    Cycle4= Message.CycleTime.ToString();
                    MoldId4 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode4 = "Tự động";
                    }
                    else
                    {
                        Mode4 = "Bán Tự động";
                    }
                    break;
                case "M5":
                    Count5 = Message.CounterShot.ToString();
                    ProductId5 = Message.ProductId.ToString();
                    CycleStandard5 = Message.SetCycle.ToString();
                    Cycle5 = Message.CycleTime.ToString();
                    MoldId6 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode5 = "Tự động";
                    }
                    else
                    {
                        Mode5 = "Bán Tự động";
                    }
                    break;
                case "M6":
                    Count6= Message.CounterShot.ToString();
                    ProductId6 = Message.ProductId.ToString();
                    CycleStandard6 = Message.SetCycle.ToString();
                    Cycle6 = Message.CycleTime.ToString();
                    MoldId6 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode6 = "Tự động";
                    }
                    else
                    {
                        Mode6 = "Bán Tự động";
                    }
                    break;
                case "M7":
                    Count7 = Message.CounterShot.ToString();
                    ProductId7 = Message.ProductId.ToString();
                    CycleStandard7 = Message.SetCycle.ToString();
                    Cycle7 = Message.CycleTime.ToString();
                    MoldId7 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode7 = "Tự động";
                    }
                    else
                    {
                        Mode7 = "Bán Tự động";
                    }
                    break;
                case "M8":
                    Count8 = Message.CounterShot.ToString();
                    ProductId8 = Message.ProductId.ToString();
                    CycleStandard8 = Message.SetCycle.ToString();
                    Cycle8 = Message.CycleTime.ToString();
                    MoldId8 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode8 = "Tự động";
                    }
                    else
                    {
                        Mode8 = "Bán Tự động";
                    }
                    break;
                case "M9":
                    Count9 = Message.CounterShot.ToString();
                    ProductId9 = Message.ProductId.ToString();
                    CycleStandard9 = Message.SetCycle.ToString();
                    Cycle9 = Message.CycleTime.ToString();
                    MoldId9 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode9 = "Tự động";
                    }
                    else
                    {
                        Mode9 = "Bán Tự động";
                    }
                    break;
                case "M10":
                    Count10 = Message.CounterShot.ToString();
                    ProductId10 = Message.ProductId.ToString();
                    CycleStandard10 = Message.SetCycle.ToString();
                    Cycle10 = Message.CycleTime.ToString();
                    MoldId10 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode10 = "Tự động";
                    }
                    else
                    {
                        Mode10 = "Bán Tự động";
                    }
                    break;
                case "M11":
                    Count11 = Message.CounterShot.ToString();
                    ProductId11 = Message.ProductId.ToString();
                    CycleStandard11 = Message.SetCycle.ToString();
                    Cycle11 = Message.CycleTime.ToString();
                    MoldId11 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode11 = "Tự động";
                    }
                    else
                    {
                        Mode11 = "Bán Tự động";
                    }
                    break;
                case "M12":
                    Count12 = Message.CounterShot.ToString();
                    ProductId12 = Message.ProductId.ToString();
                    CycleStandard12 = Message.SetCycle.ToString();
                    Cycle12 = Message.CycleTime.ToString();
                    MoldId12 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode12 = "Tự động";
                    }
                    else
                    {
                        Mode12 = "Bán Tự động";
                    }
                    break;
                case "M13":
                    Count13 = Message.CounterShot.ToString();
                    ProductId13 = Message.ProductId.ToString();
                    CycleStandard13 = Message.SetCycle.ToString();
                    Cycle13 = Message.CycleTime.ToString();
                    MoldId13 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode13 = "Tự động";
                    }
                    else
                    {
                        Mode13 = "Bán Tự động";
                    }
                    break;
                case "M14":
                    Count14 = Message.CounterShot.ToString();
                    ProductId14 = Message.ProductId.ToString();
                    CycleStandard14 = Message.SetCycle.ToString();
                    Cycle14 = Message.CycleTime.ToString();
                    MoldId14 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode14 = "Tự động";
                    }
                    else
                    {
                        Mode14 = "Bán Tự động";
                    }
                    break;
                case "M15":
                    Count15 = Message.CounterShot.ToString();
                    ProductId15 = Message.ProductId.ToString();
                    CycleStandard15 = Message.SetCycle.ToString();
                    Cycle15 = Message.CycleTime.ToString();
                    MoldId15 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode15 = "Tự động";
                    }
                    else
                    {
                        Mode15 = "Bán Tự động";
                    }
                    break;
                case "M16":
                    Count16 = Message.CounterShot.ToString();
                    ProductId16 = Message.ProductId.ToString();
                    CycleStandard16 = Message.SetCycle.ToString();
                    Cycle16 = Message.CycleTime.ToString();
                    MoldId16 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode16 = "Tự động";
                    }
                    else
                    {
                        Mode16 = "Bán Tự động";
                    }
                    break;
                case "M17":
                    Count17 = Message.CounterShot.ToString();
                    ProductId17 = Message.ProductId.ToString();
                    CycleStandard17 = Message.SetCycle.ToString();
                    Cycle17 = Message.CycleTime.ToString();
                    MoldId17 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode17 = "Tự động";
                    }
                    else
                    {
                        Mode17 = "Bán Tự động";
                    }
                    break;
                case "M18":
                    Count18 = Message.CounterShot.ToString();
                    ProductId18 = Message.ProductId.ToString();
                    CycleStandard18 = Message.SetCycle.ToString();
                    Cycle18 = Message.CycleTime.ToString();
                    MoldId18 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode18 = "Tự động";
                    }
                    else
                    {
                        Mode18 = "Bán Tự động";
                    }
                    break;
                case "M19":
                    Count19 = Message.CounterShot.ToString();
                    ProductId19 = Message.ProductId.ToString();
                    CycleStandard19 = Message.SetCycle.ToString();
                    Cycle19 = Message.CycleTime.ToString();
                    MoldId19 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode19 = "Tự động";
                    }
                    else
                    {
                        Mode19 = "Bán Tự động";
                    }
                    break;
                case "M20":
                    Count20 = Message.CounterShot.ToString();
                    ProductId20 = Message.ProductId.ToString();
                    CycleStandard20 = Message.SetCycle.ToString();
                    Cycle20 = Message.CycleTime.ToString();
                    MoldId20 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode20 = "Tự động";
                    }
                    else
                    {
                        Mode20 = "Bán Tự động";
                    }
                    break;
                case "M21":
                    Count21= Message.CounterShot.ToString();
                    ProductId21 = Message.ProductId.ToString();
                    CycleStandard21 = Message.SetCycle.ToString();
                    Cycle21 = Message.CycleTime.ToString();
                    MoldId21 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode21 = "Tự động";
                    }
                    else
                    {
                        Mode21 = "Bán Tự động";
                    }
                    break;
                case "M22":
                    Count22 = Message.CounterShot.ToString();
                    ProductId22 = Message.ProductId.ToString();
                    CycleStandard22 = Message.SetCycle.ToString();
                    Cycle22 = Message.CycleTime.ToString();
                    MoldId22 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode22 = "Tự động";
                    }
                    else
                    {
                        Mode22 = "Bán Tự động";
                    }
                    break;
                case "M23":
                    Count23 = Message.CounterShot.ToString();
                    ProductId23 = Message.ProductId.ToString();
                    CycleStandard23 = Message.SetCycle.ToString();
                    Cycle23 = Message.CycleTime.ToString();
                    MoldId23 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode23 = "Tự động";
                    }
                    else
                    {
                        Mode23 = "Bán Tự động";
                    }
                    break;
                case "M24":
                    Count24 = Message.CounterShot.ToString();
                    ProductId24 = Message.ProductId.ToString();
                    CycleStandard24 = Message.SetCycle.ToString();
                    Cycle24= Message.CycleTime.ToString();
                    MoldId24 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode24 = "Tự động";
                    }
                    else
                    {
                        Mode24 = "Bán Tự động";
                    }
                    break;
                case "M25":
                    Count25 = Message.CounterShot.ToString();
                    ProductId25 = Message.ProductId.ToString();
                    CycleStandard25 = Message.SetCycle.ToString();
                    Cycle25 = Message.CycleTime.ToString();
                    MoldId25 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode25 = "Tự động";
                    }
                    else
                    {
                        Mode25 = "Bán Tự động";
                    }
                    break;
                case "M26":
                    Count26 = Message.CounterShot.ToString();
                    ProductId26 = Message.ProductId.ToString();
                    CycleStandard26 = Message.SetCycle.ToString();
                    Cycle26 = Message.CycleTime.ToString();
                    MoldId26= Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode26 = "Tự động";
                    }
                    else
                    {
                        Mode26 = "Bán Tự động";
                    }
                    break;
                case "M27":
                    Count27= Message.CounterShot.ToString();
                    ProductId27 = Message.ProductId.ToString();
                    CycleStandard27 = Message.SetCycle.ToString();
                    Cycle27 = Message.CycleTime.ToString();
                    MoldId27 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode27 = "Tự động";
                    }
                    else
                    {
                        Mode27 = "Bán Tự động";
                    }
                    break;
                case "M28":
                    Count28 = Message.CounterShot.ToString();
                    ProductId28 = Message.ProductId.ToString();
                    CycleStandard28 = Message.SetCycle.ToString();
                    Cycle28 = Message.CycleTime.ToString();
                    MoldId28 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        Mode28 = "Tự động";
                    }
                    else
                    {
                        Mode28 = "Bán Tự động";
                    }
                    break;
                case "L1":
                    CountL1 = Message.CounterShot.ToString();
                    ProductIdL1 = Message.ProductId.ToString();
                    CycleStandardL1 = Message.SetCycle.ToString();
                    CycleL1 = Message.CycleTime.ToString();
                    MoldIdL1 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        ModeL1 = "Tự động";
                    }
                    else
                    {
                        ModeL1 = "Bán Tự động";
                    }
                    break;
                case "L2":
                    CountL2 = Message.CounterShot.ToString();
                    ProductIdL2 = Message.ProductId.ToString();
                    CycleStandardL2 = Message.SetCycle.ToString();
                    CycleL2 = Message.CycleTime.ToString();
                    MoldIdL2 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        ModeL2 = "Tự động";
                    }
                    else
                    {
                        ModeL2 = "Bán Tự động";
                    }
                    break;
                case "L3":
                    CountL3 = Message.CounterShot.ToString();
                    ProductIdL3 = Message.ProductId.ToString();
                    CycleStandardL3 = Message.SetCycle.ToString();
                    CycleL3 = Message.CycleTime.ToString();
                    MoldIdL3 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        ModeL3 = "Tự động";
                    }
                    else
                    {
                        ModeL3 = "Bán Tự động";
                    }
                    break;
                case "L4":
                    CountL4 = Message.CounterShot.ToString();
                    ProductIdL4 = Message.ProductId.ToString();
                    CycleStandardL4 = Message.SetCycle.ToString();
                    CycleL4 = Message.CycleTime.ToString();
                    MoldIdL4 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        ModeL4 = "Tự động";
                    }
                    else
                    {
                        ModeL4 = "Bán Tự động";
                    }
                    break;
                case "L5":
                    CountL5 = Message.CounterShot.ToString();
                    ProductIdL5 = Message.ProductId.ToString();
                    CycleStandardL5 = Message.SetCycle.ToString();
                    CycleL5 = Message.CycleTime.ToString();
                    MoldIdL5 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        ModeL5 = "Tự động";
                    }
                    else
                    {
                        ModeL5 = "Bán Tự động";
                    }
                    break;
                case "L6":
                    CountL6= Message.CounterShot.ToString();
                    ProductIdL6 = Message.ProductId.ToString();
                    CycleStandardL6 = Message.SetCycle.ToString();
                    CycleL6 = Message.CycleTime.ToString();
                    MoldId6 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        ModeL6 = "Tự động";
                    }
                    else
                    {
                        ModeL6 = "Bán Tự động";
                    }
                    break;
                case "L7":
                    CountL7 = Message.CounterShot.ToString();
                    ProductIdL7 = Message.ProductId.ToString();
                    CycleStandardL7 = Message.SetCycle.ToString();
                    CycleL7 = Message.CycleTime.ToString();
                    MoldIdL7 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        ModeL7 = "Tự động";
                    }
                    else
                    {
                        ModeL7 = "Bán Tự động";
                    }
                    break;
                case "L8":
                    CountL8 = Message.CounterShot.ToString();
                    ProductIdL8 = Message.ProductId.ToString();
                    CycleStandardL8 = Message.SetCycle.ToString();
                    CycleL8 = Message.CycleTime.ToString();
                    MoldIdL9 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        ModeL8 = "Tự động";
                    }
                    else
                    {
                        ModeL8 = "Bán Tự động";
                    }
                    break;
                case "L9":
                    CountL9 = Message.CounterShot.ToString();
                    ProductIdL9 = Message.ProductId.ToString();
                    CycleStandardL9 = Message.SetCycle.ToString();
                    CycleL9 = Message.CycleTime.ToString();
                    MoldIdL9 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        ModeL9 = "Tự động";
                    }
                    else
                    {
                        ModeL9 = "Bán Tự động";
                    }
                    break;
                case "L10":
                    CountL10 = Message.CounterShot.ToString();
                    ProductIdL10 = Message.ProductId.ToString();
                    CycleStandard10 = Message.SetCycle.ToString();
                    CycleL10 = Message.CycleTime.ToString();
                    MoldIdL10 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        ModeL10 = "Tự động";
                    }
                    else
                    {
                        ModeL10 = "Bán Tự động";
                    }
                    break;
                case "L11":
                    CountL11 = Message.CounterShot.ToString();
                    ProductIdL11 = Message.ProductId.ToString();
                    CycleStandard11 = Message.SetCycle.ToString();
                    CycleL11 = Message.CycleTime.ToString();
                    MoldIdL11 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        ModeL11 = "Tự động";
                    }
                    else
                    {
                        ModeL11 = "Bán Tự động";
                    }
                    break;
                case "L12":
                    Count12 = Message.CounterShot.ToString();
                    ProductIdL12 = Message.ProductId.ToString();
                    cycleStandard12 = Message.SetCycle.ToString();
                    cycle12 = Message.CycleTime.ToString();
                    MoldId12 = Message.MoldId.ToString();
                    if (Message.Mode == 1)
                    {
                        ModeL12 = "Tự động";
                    }
                    else
                    {
                        ModeL12 = "Bán Tự động";
                    }
                    break;
                default:
                    break;


            }
        }

        private void Pause(object p)
        {

            string Namemachine ="";
            if (p != null)
            {
                Namemachine = (p as UserControl).Tag.ToString();
            }
            else
            {
                Namemachine = "M24";
            }
            try
            {
              
                if( Content == "Tạm dừng")
                {
                   MessageBoxResult result = CustomMessageBox.Show("Bạn có chắc dừng lại thay khuôn không ??", "Cảnh báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                    if (result == MessageBoxResult.OK)
                    {
                        Content = "Tiếp tục";

                        Command(new CommandMessage
                        {
                            MachineId = Namemachine,
                            Timestamp = DateTime.UtcNow,
                            Command = ECommand.ChangeMold,

                        });
                        switch (Namemachine)
                        {
                            case "M1":
                                A1 = false;
                                B1 = true;
                                Content1 = "Tiếp tục";
                                break;
                            case "M2":
                                A2 = false;
                                B2 = true;
                                Content2 = "Tiếp tục";
                                break;
                            case "M3":
                                A3 = false;
                                B3 = true;
                                Content3 = "Tiếp tục";
                                break;
                            case "M4":
                                A4 = false;
                                B4= true;
                                Content4 = "Tiếp tục";
                                break;
                            case "M5":
                                A5 = false;
                                B5 = true;
                                Content5 = "Tiếp tục";
                                break;
                            case "M6":
                                A6 = false;
                                B6 = true;
                                Content6 = "Tiếp tục";
                                break;
                            case "M7":
                                A7 = false;
                                B7 = true;
                                Content7 = "Tiếp tục";
                                break;
                            case "M8":
                                A8 = false;
                                B8 = true;
                                Content8 = "Tiếp tục";
                                break;
                            case "M9":
                                A9 = true;
                                B9 = false;
                                Content9 = "Tiếp tục";
                                break;
                            case "M10":
                                A10 = false;
                                B10 = true;
                                Content10 = "Tiếp tục";
                                break;
                            case "M11":
                                A11 = false;
                                B11 = true;
                                Content11 = "Tiếp tục";

                                break;
                            case "M12":
                                A12 = false;
                                B12 = true;
                                Content12 = "Tiếp tục";
                                break;
                            case "M13":
                                A13 = false;
                                B13 = true;
                                Content13 = "Tiếp tục";
                                break;
                            case "M14":
                                A14 = false;
                                B14 = true;
                                Content14 = "Tiếp tục";
                                break;
                            case "M15":
                                A15 = false;
                                B15 = true;
                                Content15 = "Tiếp tục";
                                break;
                            case "M16":
                                A16 = false;
                                B16 = true;
                                Content16 = "Tiếp tục";
                                break;
                            case "M17":
                                A17 = false;
                                B17= true;
                                Content17 = "Tiếp tục";

                                break;
                            case "M18":
                                A18 = false;
                                B18 = true;
                                Content18 = "Tiếp tục";
                                break;
                            case "M19":
                                A19 = false;
                                B19 = true;
                                Content19 = "Tiếp tục";
                                break;
                            case "M20":
                                A20 = false;
                                B20= true;
                                Content20 = "Tiếp tục";
                                break;
                            case "M21":
                                A21 = false;
                                B21 = true;
                                Content21 = "Tiếp tục";
                                break;
                            case "M22":
                                A22 = false;
                                B22 = true;
                                Content22 = "Tiếp tục";
                                break;
                            case "M23":
                                A23 = false;
                                B23 = true;
                                Content23 = "Tiếp tục";
                                break;
                            case "M24":
                                A24 = false;
                                B24 = true;
                                Content24 = "Tiếp tục";
                                break;
                            case "M25":
                                A25 = false;
                                B25= true;
                                Content25 = "Tiếp tục";
                                break;
                            case "M26":
                                A26 = false;
                                B26= true;
                                Content26 = "Tiếp tục";


                                break;
                            case "M27":
                                A27 = false;
                                B27= true;
                                Content27 = "Tiếp tục";

                                break;
                            case "M28":
                                A28 = false;
                                B28 = true;
                                Content28 = "Tiếp tục";
                                break;
                            case "L1":
                                AL1 = false;
                                BL1 = true;
                                ContentL1 = "Tiếp tục";

                                break;
                            case "L2":
                                AL2 = false;
                                BL2 = true;
                                ContentL2 = "Tiếp tục";
                                break;
                            case "L3":
                                AL3 = false;
                                BL3 = true;
                                ContentL3 = "Tiếp tục";
                                break;
                            case "L4":
                                AL4 = false;
                                BL4 = true;
                                ContentL4 = "Tiếp tục";
                                break;
                            case "L5":
                                AL5 = false;
                                BL5 = true;
                                ContentL5 = "Tiếp tục";
                                break;
                            case "L6":
                                AL6 = false;
                                BL6 = true;

                                ContentL6 = "Tiếp tục";
                                break;
                            case "L7":
                                AL7 = false;
                                BL7 = true;
                                ContentL7 = "Tiếp tục";
                                break;
                            case "L8":
                                AL8 = false;
                                BL8 = true;
                                ContentL8 = "Tiếp tục";
                                break;
                            case "L9":
                                AL9 = false;
                                BL9 = true;
                                ContentL9 = "Tiếp tục";
                                break;
                            case "L10":

                                AL10 = false;
                                BL10 = true;
                                ContentL10 = "Tiếp tục";
                                break;
                            case "L11":
                                AL11 = false;
                                BL11 = true;
                                ContentL11 = "Tiếp tục";
                                break;
                            case "L12":
                                AL12 = false;
                                BL12 = true;
                                ContentL12 = "Tiếp tục";
                                break;
                            default:
                                break;


                        }

                    }

                }
                else if (Content == "Tiếp tục")
                {
                    MessageBoxResult result = CustomMessageBox.Show("Bạn muốn máy hoạt động với thông số đã nhập??", "Cảnh báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                    if (result == MessageBoxResult.OK)
                    {

                        //ShiftReport shiftReport = new ShiftReport();
                        //shiftReport.MachineId = Namemachine;
                        //shiftReport.Date = DateTime.Now;
                        //if(DateTime.Now.Hour >7 && DateTime.Now.Minute < 19)
                        //{
                        //    shiftReport.TotalQuantity = (19 * 3600 - DateTime.Now.Hour * 60*60-DateTime.Now.Minute*60)/ Convert.ToInt32( Cycle );
                        //}

                        //shiftReport.ProductId = Product.Id;
                        //shiftReport.ShiftNumber = EShift.Night;
                        //_apiServices.PostShiftReportSingle("", shiftReport);
                        ConfigCommand(new ConfigurationMessage
                        {
                            MachineId = Namemachine,
                            Timestamp = DateTime.UtcNow,
                            MoldId = Mold.Id,
                            CycleTime = Convert.ToInt32(Cycle),
                            ProductId = Product.Id

                        }); ;
                        Command(new CommandMessage
                        {
                            MachineId = Namemachine,
                            Timestamp = DateTime.UtcNow,
                            Command = ECommand.ChangeMoldDone,

                        });

                        Content = "Tạm dừng";
                        switch (Namemachine)
                        {
                            case "M1":
                                A1 = true;
                                B1 = false;
                                Content1 = "Tạm dừng";
                                break;
                            case "M2":
                                A3 = true;
                                B3 = false;
                                Content2 = "Tạm dừng";
                                break;
                            case "M3":
                                A3 = true;
                                B3 = false;
                                Content3 = "Tạm dừng";
                                break;
                            case "M4":
                                A4 = true;
                                B4 = false;
                                Content4 = "Tạm dừng";
                                break;
                            case "M5":
                                A5 = true;
                                B5 = false;
                                Content5 = "Tạm dừng";
                                break;
                            case "M6":
                                A6 = true;
                                B6 = false;
                                Content6 = "Tạm dừng";
                                break;
                            case "M7":
                                A7 = true;
                                B7 = false;
                                Content7 = "Tạm dừng";
                                break;
                            case "M8":
                                A8 = true;
                                B8 = false;
                                Content8 = "Tạm dừng";
                                break;
                            case "M9":
                                A9 = true;
                                B9 = false;
                                Content9 = "Tạm dừng";
                                break;
                            case "M10":
                                A10 = true;
                                B10 = false;
                                Content10 = "Tạm dừng";
                                break;
                            case "M11":
                                A11 = true;
                                B11 = false;
                                Content11 = "Tạm dừng";

                                break;
                            case "M12":
                                A12 = true;
                                B12 = false;
                                Content12 = "Tạm dừng";
                                break;
                            case "M13":
                                A13 = true;
                                B13 = false;
                                Content13 = "Tạm dừng";
                                break;
                            case "M14":
                                A14 = true;
                                B14 = false;
                                Content14 = "Tạm dừng";
                                break;
                            case "M15":
                                A15 = true;
                                B15 = false;
                                Content15 = "Tạm dừng";
                                break;
                            case "M16":
                                A16 = true;
                                B16 = false;
                                Content16 = "Tạm dừng";
                                break;
                            case "M17":
                                A17 = true;
                                B17 = false;
                                Content17 = "Tạm dừng";

                                break;
                            case "M18":
                                A18 = true;
                                B18 = false;
                                Content18 = "Tạm dừng";
                                break;
                            case "M19":
                                A19 = true;
                                B19 = false;
                                Content19 = "Tạm dừng";
                                break;
                            case "M20":
                                A20 = true;
                                B20 = false;
                                Content20 = "Tạm dừng";
                                break;
                            case "M21":
                                A21 = true;
                                B21 = false;
                                Content21 = "Tạm dừng";
                                break;
                            case "M22":
                                A22 = true;
                                B22 = false;
                                Content22 = "Tạm dừng";
                                break;
                            case "M23":
                                A23 = true;
                                B23 = false;
                                Content23 = "Tạm dừng";
                                break;
                            case "M24":
                                A24 = true;
                                B24 = false;
                                Content24 = "Tạm dừng";
                                break;
                            case "M25":
                                A25 = true;
                                B25 = false;
                                Content25 = "Tạm dừng";
                                break;
                            case "M26":
                                A26 = true;
                                B26 = false;
                                Content26 = "Tạm dừng";


                                break;
                            case "M27":
                                A27 = true;
                                B27 = false;
                                Content27 = "Tạm dừng";

                                break;
                            case "M28":
                                A28 = true;
                                B28 = false;
                                Content28 = "Tạm dừng";
                                break;
                            case "L1":
                                AL1 = true;
                                BL1 = false;
                                ContentL1 = "Tạm dừng";

                                break;
                            case "L2":
                                AL2 = true;
                                BL2 = false;
                                ContentL2 = "Tạm dừng";
                                break;
                            case "L3":
                                AL3 = true;
                                BL3 = false;
                                ContentL3 = "Tạm dừng";
                                break;
                            case "L4":
                                AL4 = true;
                                BL4 = false;
                                ContentL4 = "Tạm dừng";
                                break;
                            case "L5":
                                AL5 = true;
                                BL5 = false;
                                ContentL5 = "Tạm dừng";
                                break;
                            case "L6":

                                AL6 = true;
                                BL6 = false;
                                ContentL6 = "Tạm dừng";
                                break;
                            case "L7":
                                AL7 = true;
                                BL7 = false;
                                ContentL7 = "Tạm dừng";
                                break;
                            case "L8":
                                AL8 = true;
                                BL8 = false;
                                ContentL8 = "Tạm dừng";
                                break;
                            case "L9":
                                AL9 = true;
                                BL9 = false;
                                ContentL9 = "Tạm dừng";
                                break;
                            case "L10":
                                AL10 = true;
                                BL10 = false;
                                ContentL10 = "Tạm dừng";
                                break;
                            case "L11":
                                AL11 = true;
                                BL11 = false;
                                ContentL11 = "Tạm dừng";
                                break;
                            case "L12":
                                AL12 = true;
                                BL12 = false;
                                ContentL12 = "Tạm dừng";
                                break;
                            default:
                                break;


                        }

                    }
                }
            }
            catch
            {

            }
            //public async Task Consume(ConsumeContext<CycleMessage> context)
            //{
            //    var message = context.Message;

            //    //   Console.WriteLine("Timestamp: {0}\r\nCycleTime: {1}\r\nOpenTime: {2}\r\nMode: {3}\r\nCounterShot: {4}\r\nMoldId: {5}\r\nSetCycle: {6}\r\n", message.Timestamp, message.CycleTime, message.OpenTime, message.Mode, message.CounterShot, message.MoldId, message.SetCycle);
            //}
            //DialogResult result = cs.ShowDialog();




        }
        ///api
        public async Task<ObservableCollection<Product>> GetProductTotal(string auth)
        {
            try
            {
                using (httpClient = new HttpClient())
                {
                    using (httpRequest = new HttpRequestMessage())
                    {
                        string Url = "http://192.168.1.80:8082/api/products";
                        httpRequest.Method = System.Net.Http.HttpMethod.Get;
                        httpRequest.RequestUri = new Uri(Url);
                        HttpResponseMessage httpResponse = await httpClient.SendAsync(httpRequest);
                        var ob = await httpResponse.Content.ReadAsStringAsync();
                        ListProduct = JsonConvert.DeserializeObject<ObservableCollection<Product>>(ob);

                    }

                }

            }
            catch
            {
           //  CustomMessageBox.Show("Lỗi trong quá trình lấy dữ liệu từ Sever!", "Cảnh bảo", System.Windows.MessageBoxButton.OKCancel, System.Windows.MessageBoxImage.Warning);
        }

            return ListProduct;

        }
        public async Task<ObservableCollection<Mold>> GetMoldTotal(string auth)
        {
            try
            {
                using (httpClient = new HttpClient())
                {
                    using (httpRequest = new HttpRequestMessage())
                    {
                        string Url = "http://192.168.1.80:8082/api/molds";
                        httpRequest.Method = System.Net.Http.HttpMethod.Get;
                        httpRequest.RequestUri = new Uri(Url);
                        HttpResponseMessage httpResponse = await httpClient.SendAsync(httpRequest);
                        var ob = await httpResponse.Content.ReadAsStringAsync();
                        ListMold = JsonConvert.DeserializeObject<ObservableCollection<Mold>>(ob);

                    }

                }
            }
            catch
            {
              //  CustomMessageBox.Show("Lỗi trong quá trình lấy dữ liệu từ Sever!", "Cảnh bảo", System.Windows.MessageBoxButton.OKCancel, System.Windows.MessageBoxImage.Warning);
            }

            return ListMold;
        }

    }
}
