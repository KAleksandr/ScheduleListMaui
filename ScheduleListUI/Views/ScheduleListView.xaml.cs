using Microsoft.Maui.Controls;
using ScheduleListUI.ViewModels;

namespace ScheduleListUI.Views;

public partial class ScheduleListView : ContentPage
{
    private bool _isPanelTranslated; 
	public ScheduleListView()
	{
		InitializeComponent();
        this.BindingContext = new ScheduleListModels();
        panelLeft.TranslateTo(-80, 0, 150);
    }
    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        var viewModel = (ScheduleListModels)BindingContext;
        viewModel.BindDataToScheduleList();
    }
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if(_isPanelTranslated)
        {
            panelLeft.TranslateTo(-80, 0, 150);
        }
        else
        {
            panelLeft.TranslateTo(0, 0, 150);
        }
        _isPanelTranslated = !_isPanelTranslated;
    }
}