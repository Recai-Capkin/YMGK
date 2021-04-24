using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YMGKWebService.Data;
using YMGKWebService.Data.Models;

namespace YMGKWebService.Services
{
    public class FileService
    {
        public async Task<bool> InsertMedia(File file)
        {
            YMGKContext db = new YMGKContext();

            file.InsertDate = DateTime.Now;
            try
            {
                await db.AddAsync(file).ConfigureAwait(false);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void UpdateMedia(File file)
        {
            YMGKContext db = new YMGKContext();

            file.UpdateDate = DateTime.Now;

            db.Update(file);
            db.SaveChanges();
           
        }
        public void DeleteMedia(int fileId)
        {
            YMGKContext db = new YMGKContext();
            var file = db.Files.Where(x => x.Id == fileId).FirstOrDefault();
            db.Remove(file);
            db.SaveChanges();
        }
        
        public List<File> GetFilesAsync()
        {
            YMGKContext db = new YMGKContext();
            return db.Files.ToList();
        }

    }
}
