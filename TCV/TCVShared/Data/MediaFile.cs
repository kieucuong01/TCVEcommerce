using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TCVShared.Helpers;

namespace TCVShared.Data
{
    public class MediaFile
    {
        public static string MediaLink = "/Media/";

        static MediaFile()
        {
            MediaLink = Common.GetAppSetting("MediaLink");
        }

        public int Id { get; set; }

        public int AlbumId { get; set; }

        [StringLength(128)]
        [Display(Name = "Tên file")]
        public string FileName { get; set; }

        [StringLength(512)]
        [Display(Name = "Đường dẫn")]
        public string FullPath { get; set; }

        [Display(Name = "Dung lượng")]
        public int FileSize { get; set; }

        [Display(Name = "Ngày tạo")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm}")]
        public DateTime? CreateTime { get; set; }

        [ForeignKey("AlbumId")]
        public virtual MediaAlbum MediaAlbum { get; set; }

        [NotMapped]
        public string FileLink
        {
            get
            {
                if (string.IsNullOrEmpty(FullPath))
                    return "/Assets/img/album.png";

                return string.Format("{0}/{1}", MediaLink, FullPath);
            }
        }
    }
}
