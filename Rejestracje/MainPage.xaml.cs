using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Rejestracje
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private RegisterDataBase _registerDataBase;

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            _registerDataBase = new RegisterDataBase();

            textBoxRegisterNumber.KeyUp += ToUpper;
            buttonCheck.Tapped += OnButtonCheckClicked;
        }

        private void ToUpper(object sender, KeyRoutedEventArgs e)
        {
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }



        private async void OnButtonCheckClicked(object sender, TappedRoutedEventArgs tappedRoutedEventArgs)
        {
            provinceTextBlock.Text = String.Empty;
            stateTextBlock.Text = String.Empty;
            try
            {
                string registerNumber = FindRegisterNumber(textBoxRegisterNumber.Text);

                RegisterData registerDataFound = _registerDataBase.GetRegisterDataByRegisterNumber(registerNumber);

                if (registerDataFound == null)
                {
                    throw new Exception("Nie znaleziono podanej rejestracji");
                }

                provinceTextBlock.Text = "Województwo : " + registerDataFound.Province;
                stateTextBlock.Text = "Powiat : " + registerDataFound.State;
            }
            catch (Exception ex)
            {
                MessageDialog msgbox = new MessageDialog("Błąd : " + ex.Message);

                await msgbox.ShowAsync();
            }
        }

        private string FindRegisterNumber(string text)
        {
            try
            {
                return text.Substring(0, 3);
            }
            catch (Exception)
            {
                throw new Exception("Należy wpisać conajmniej 3 znaki!");
            }
        }


        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }
    }
}