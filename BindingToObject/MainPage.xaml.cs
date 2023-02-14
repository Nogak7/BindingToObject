namespace BindingToObject;
using BindingToObject.Models;

public partial class MainPage : ContentPage
{
	public Phone Phones { get; set; } = new Phone("0506665835", "Iphone", "iphone.png");

    public MainPage()
	{
		
		InitializeComponent();
	}

	
}

