using System.IO;
using ExifLibrary;
namespace exify.Exif
{
    public class ExifRead
    {
        public ExifRead(Stream str)
        {
               ImageFile imgfile = ImageFile.FromStream(str);
               FNumber = imgfile.Properties.Get<ExifURational>(ExifTag.FNumber).ToFloat();
               FocalLength = imgfile.Properties.Get<ExifProperty>(ExifTag.FocalLength);
               Iso = imgfile.Properties.Get<ExifProperty>(ExifTag.ISOSpeedRatings);
               MeteringMode = imgfile.Properties.Get<ExifProperty>(ExifTag.MeteringMode);
               LensModel = imgfile.Properties.Get<ExifProperty>(ExifTag.LensModel);
               Model = imgfile.Properties.Get<ExifProperty>(ExifTag.Model);
               ShutterSpeed = imgfile.Properties.Get<ExifProperty>(ExifTag.ShutterSpeedValue);
               ExposureMode = imgfile.Properties.Get<ExifProperty>(ExifTag.ExposureMode);
               ExposureProgram = imgfile.Properties.Get<ExifProperty>(ExifTag.ExposureProgram);
               ExposureTime = imgfile.Properties.Get<ExifProperty>(ExifTag.ExposureTime);
               Make = imgfile.Properties.Get<ExifProperty>(ExifTag.Make);
        }
        public float? FNumber 
        {
            get;
            private set;
        }
        public object FocalLength
        {
            get;
            private set;
        }
        public object Iso 
        {
            get;
            private set;
        }
        public object MeteringMode 
        {
            get;
            private set;
        }
        public object LensModel 
        {
            get;
            private set;
        }
        public object Model 
        {
            get;
            private set;
        }
        public object ShutterSpeed 
        {
            get;
            private set;
        }
        public object ExposureMode 
        {
            get;
            private set;
        }
        public object ExposureProgram 
        {
            get;
            private set;
        }
        public object ExposureTime 
        {
            get;
            private set;
        }
        public object Make 
        {
            get;
            private set;
        }
    }
}