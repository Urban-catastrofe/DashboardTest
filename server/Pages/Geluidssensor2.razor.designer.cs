using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using DashboardTest.Models.JmullinkProject4;
using Microsoft.EntityFrameworkCore;

namespace DashboardTest.Pages
{
    public partial class Geluidssensor2Component : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

   

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected JmullinkProject4Service JmullinkProject4 { get; set; }
        protected RadzenDataGrid<DashboardTest.Models.JmullinkProject4.MicJori> datagrid1;

        IEnumerable<DashboardTest.Models.JmullinkProject4.MicJori> _getMicJorisResult;
        protected IEnumerable<DashboardTest.Models.JmullinkProject4.MicJori> getMicJorisResult
        {
            get
            {
                return _getMicJorisResult;
            }
            set
            {
                if (!object.Equals(_getMicJorisResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getMicJorisResult", NewValue = value, OldValue = _getMicJorisResult };
                    _getMicJorisResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<DashboardTest.Models.JmullinkProject4.MicKay> _getMicKaysResult;
        protected IEnumerable<DashboardTest.Models.JmullinkProject4.MicKay> getMicKaysResult
        {
            get
            {
                return _getMicKaysResult;
            }
            set
            {
                if (!object.Equals(_getMicKaysResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getMicKaysResult", NewValue = value, OldValue = _getMicKaysResult };
                    _getMicKaysResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            var jmullinkProject4GetMicJorisResult = await JmullinkProject4.GetMicJoris();
            getMicJorisResult = jmullinkProject4GetMicJorisResult;

            var jmullinkProject4GetMicKaysResult = await JmullinkProject4.GetMicKays();
            getMicKaysResult = jmullinkProject4GetMicKaysResult;

            var jmullinkProject4GetMicJorisResult0 = await JmullinkProject4.GetMicJoris();
            getMicJorisResult = jmullinkProject4GetMicJorisResult0;
        }
    }
}
