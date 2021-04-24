using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YMGKWebService.Data.Models;
using YMGKWebService.Services;

namespace YMGKWebService.Controllers
{   
    [Route("services")]
    [EnableCors("AllowAll")]
    public class ServiceController : Controller
    {

        [Route("GetMedias")]
        public List<File> GetMedias()
        {
            return new FileService().GetFilesAsync();
        }

        [Route("InsertMedia")]
        public Task<bool> InsertMedia([FromBody] File file)
        {
            //Servis'e dosya gönderilip true false yanıt dönmektedir
            return new FileService().InsertMedia(file);
        }

        [Route("UpdateMedia")]
        public void UpdateMedia([FromBody] File file)
        {
            new FileService().UpdateMedia(file);
        }

        [Route("DeleteMedia")]
        public void DeleteMedia(int FileId)
        {
            new FileService().DeleteMedia(FileId);
        }
    }
}
