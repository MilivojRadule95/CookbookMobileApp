using CookbookXF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace CookbookXF.ViewModels
{
    internal class StepsViewModel : BaseViewModel
    {
        public StepsViewModel()
        {
            
        }

        private string _text;
        private ImageSource _image;

        public void LoadStep(Step step)
        {
            Text = step.Text;
            Image = ImageSource.FromResource($"{Constants.ResourcePrefix}{step.Image}");
        }

        public string Text
        {
            get { return _text; }
            set 
            {
                _text = value; 
                OnPropertyChanged(nameof(Text));
            }
            
        }

        public ImageSource Image
        {
            get { return _image; }
            set 
            {
                _image = value;
                OnPropertyChanged(nameof(Image));
            }
        }
    }
}
