using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverAppen.ViewModels
{
    public class PhotoViewModel : BaseViewModel
    {
        public Command TakePhotoBtn { get; }
        public Command ChoosePhotoBtn { get; }

        public PhotoViewModel() 
        {
            TakePhotoBtn = new Command(TakeAndUploadPhoto);
            ChoosePhotoBtn = new Command(ChoosePhotoAndUpload);
        }

        private async void TakeAndUploadPhoto(object obj)
        {
            var photo = await MediaPicker.CapturePhotoAsync();

            if (photo != null)
            {
                var fileToUpload = await photo.OpenReadAsync();

                var firebaseStorage = await new FirebaseStorage("cleverboi-ffba2.appspot.com")
                    .Child($"{Guid.NewGuid()}.jpg")
                    .PutAsync(fileToUpload);

                await Application.Current.MainPage.DisplayAlert("Success!", "Image successfully uploaded to storage!", "Ok");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error!", "There was an error taking the photo!", "ok");
            }
        }

        private async void ChoosePhotoAndUpload(object obj)
        {
            var photo = await MediaPicker.PickPhotoAsync();

            if (photo != null)
            {
                var fileToUpload = await photo.OpenReadAsync();

                var firebaseStorage = await new FirebaseStorage("cleverboi-ffba2.appspot.com")
                    .Child($"{Guid.NewGuid()}.jpg")
                    .PutAsync(fileToUpload);

                await Application.Current.MainPage.DisplayAlert("Success!", "Image successfully uploaded to storage!", "Ok");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error!", "There was an error taking the photo!", "ok");
            }
        }
    }
}
