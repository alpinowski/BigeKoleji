using System;
using System.IO;
using System.Web;


namespace BilgeKoleji.COMMON.Tools
{
    public class ImageUploader
    {
        public static string UploadSingleImage(string serverPath, HttpPostedFileBase file)
        {
            if (file !=null)
            {
                serverPath = serverPath.Replace("~", string.Empty);
                string[] fileArray = file.FileName.Split('.');
                string extension = fileArray[fileArray.Length - 1].ToLower();
                string fileName = Guid.NewGuid() + "." + extension;

                if (extension == "jpg" || extension == "png" || extension == "gif" || extension == "jpeg") //Dosya uzantı kontrolü yapıyoruz.
                {
                    if (File.Exists(HttpContext.Current.Server.MapPath(serverPath + fileName))) //Aynı isimde bir dosya var mı kontrolü yapıyoruz.
                    {
                        return "Dosya mevcut!";
                    }
                    else
                    {
                        //Gelen isimde bir dosya yoksa sunucu tarafına dosyayı kaydediyoruz.
                        var filePath = HttpContext.Current.Server.MapPath(serverPath + fileName);
                        file.SaveAs(filePath);
                        return serverPath + fileName;
                    }
                }
                else
                {
                    return "Dosya tipi yanlış!";
                }
            }
            else
            {
                return "noimage.jpg";
            }
        }
    }
}   
    

       

	

