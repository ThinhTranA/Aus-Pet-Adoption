using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Xamarin.Forms;

namespace AusPetAdoption.Utils
{
    public static class MediaPlugin
    {
        public static List<string> filesPath = new List<string>();

        public static async Task<Image> AddPhoto()
        {
            MediaFile file = null;

            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await Application.Current.MainPage.DisplayAlert("No Camera", "You need to fix the problem of camera availability", "OK");
                return null;
            }

            var imageSource = await Application.Current.MainPage.DisplayActionSheet("Image Source", "Cancel", null, new string[] { "Camera", "Photo Gallery" });
            var photoName = Guid.NewGuid().ToString() + ".jpg";

            switch (imageSource)
            {
                case "Camera":
                    file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                    {
                        Directory = "Photos",
                        Name = photoName,
                        PhotoSize = PhotoSize.Small
                    });

                    break;

                case "Photo Gallery":
                    file = await CrossMedia.Current.PickPhotoAsync();

                    break;

                default:
                    break;
            }

            if (file == null)
                return null;


            var newImage = new Image()
            {
                Source = ImageSource.FromFile(file.Path),
                //VerticalOptions = LayoutOptions.FillAndExpand,
                //HorizontalOptions = LayoutOptions.FillAndExpand,
                //Aspect = Aspect.AspectFill,
                //Scale = 0
            };

            filesPath.Add(file.Path);


            // await newImage.ScaleTo(1, 250, Easing.SpringOut);

            return newImage;

        }

        public static async Task<string> TakePhoto()
        {
            MediaFile file = null;

            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await Application.Current.MainPage.DisplayAlert("No Camera", "You need to fix the problem of camera availability", "OK");
                return null;
            }

            var imageSource = await Application.Current.MainPage.DisplayActionSheet("Image Source", "Cancel", null, new string[] { "Camera", "Photo Gallery" });
            var photoName = Guid.NewGuid().ToString() + ".jpg";

            switch (imageSource)
            {
                case "Camera":
                    file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                    {
                        Directory = "Sample",
                        Name = photoName,
                        PhotoSize = PhotoSize.Small
                    });

                    break;

                case "Photo Gallery":
                    file = await CrossMedia.Current.PickPhotoAsync();

                    break;

                default:
                    break;
            }

            if (file == null)
                return null;


            filesPath.Add(file.Path);


            return file.Path;

        }

        public static async Task InitialiseMediaPermissions()
        {
            var cameraStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Camera);
            var storageStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Storage);

            if (cameraStatus != PermissionStatus.Granted || storageStatus != PermissionStatus.Granted)
            {
                var results = await CrossPermissions.Current.RequestPermissionsAsync(new[] { Permission.Camera, Permission.Storage });
                cameraStatus = results[Permission.Camera];
                storageStatus = results[Permission.Storage];
            }
        }
    }
}
