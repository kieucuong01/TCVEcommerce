using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace TCVShared.Data
{

    public class VoteInfo
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int VoteCount { get; set; }
        public int Percentage { get; set; }
    }

    public class UserVote
    {
        public int UserId { get; set; }
        public int VoteId { get; set; }
    }

    public class PostReview
    {
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }
        [StringLength(1024)]
        [Display(Name = "Giới thiệu")]
        [DataType(DataType.MultilineText)]
        public string Intro { get; set; }
        public List<VoteInfo> VotesList { get; set; }
        public List<UserVote> UserVotes { get; set; }
        [NotMapped]
        private string votesListText;
        [NotMapped]
        public string VotesListText
        {
            get
            {
                if (VotesList.Count() > 0)
                {
                    if (votesListText != null)
                        return votesListText;
                    votesListText = String.Join(",", VotesList.Select(x => x.Text.ToString()));
                }
                return votesListText;
            }
            set
            {
                votesListText = value;
            }
        }
        public void OnUpdateValues()
        {
            VotesListText = votesListText;
        }
        public int TotalVote
        {
            get { return UserVotes.Count; }
        }

        public PostReview()
        {
            VotesList = new List<VoteInfo>();
            UserVotes = new List<UserVote>();
        }

        public void AddVote(string text)
        {
            VoteInfo newVote = null;
            string[] Votes = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            VotesList = new List<VoteInfo>();
            foreach (var vote in Votes)
            {
                if (VotesList.Count == 0)
                {
                    newVote = new VoteInfo() { Id = 1, Text = vote };
                }
                else
                {
                    newVote = new VoteInfo() { Id = int.Parse(VotesList.Max(x => x.Id).ToString()) + 1, Text = vote };
                }
                VotesList.Add(newVote);
            }
        }
        public bool UserVote(int userId, int voteId)
        {
            VoteInfo voteInfo = VotesList.FirstOrDefault(x => x.Id == voteId);
            if (voteInfo == null)
                return false;

            var userVote = UserVotes.FirstOrDefault(x => x.UserId == userId);
            if (userVote != null)
                return false;

            UserVotes.Add(new UserVote { UserId = userId, VoteId = voteId });

            voteInfo.VoteCount += 1;
            return true;
        }
        public void CalculatePercertage(List<VoteInfo> voteinfo)
        {
            foreach (var vote in voteinfo)
            {
                vote.Percentage = vote.VoteCount * 100 / TotalVote;
            }
        }

        public bool HasUserVoted(int userId)
        {
            var userVote = UserVotes.FirstOrDefault(x => x.UserId == userId);
            return userVote != null;
        }
    }

    public class BlogPostTaxo
    {
        public int Id { get; set; }

        public int TaxoId { get; set; }

        public int PostId { get; set; }

        [ForeignKey("TaxoId")]
        public virtual Taxonomy Taxonomy { get; set; }

        [ForeignKey("PostId")]
        public virtual BlogPost BlogPost { get; set; }
    }

    public class BlogPost
    {
        public int Id { get; set; }

        [Display(Name = "Hình ảnh")]
        public int? AlbumId { get; set; }

        [Display(Name = "Bình luận")]
        public int? ThreadId { get; set; }

        [StringLength(128)]
        [Display(Name = "Người tạo")]
        public string CreateUser { get; set; }

        [StringLength(128)]
        [Display(Name = "Người sửa")]
        public string UpdateUser { get; set; }

        [Display(Name = "Ngày tạo")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime? CreateTime { get; set; }

        [Display(Name = "Sửa cuối")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime? LastUpdate { get; set; }

        [Display(Name = "Giờ đăng")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime? PublishTime { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }

        [StringLength(512)]
        [Display(Name = "Hình đại diện")]
        public string Image { get; set; }

        [StringLength(1024)]
        [Display(Name = "Link ngoài")]
        public string ExtLink { get; set; }

        [StringLength(1024)]
        [Display(Name = "Giới thiệu")]
        [DataType(DataType.MultilineText)]
        public string Preview { get; set; }

        [Display(Name = "Nội dung")]
        public string Content { get; set; }

        [Display(Name = "Định dạng")]
        public PostFormat Format { get; set; }

        [Display(Name = "Trạng thái")]
        public PostStatus Status { get; set; }

        [NotMapped]
        public PostStatus LastStatus { get; set; }

        [ForeignKey("ThreadId")]
        public virtual UserThread Thread { get; set; }

        [Display(Name = "Phân loại")]
        public virtual ICollection<BlogPostTaxo> Taxonomies { get; set; }

        [NotMapped]
        [Display(Name = "Phân loại")]
        public int[] PostCats { get; set; }

        [NotMapped]
        [Display(Name = "Thẻ gắn")]
        public string PostTags { get; set; }

        [ForeignKey("AlbumId")]
        public virtual MediaAlbum MediaAlbum { get; set; }

        [NotMapped]
        [Display(Name = "Bình luận")]
        public virtual ICollection<UserMessage> Messages
        {
            get
            {
                if (ThreadId == null)
                    return new List<UserMessage>();

                return Thread.Children.Where(x => x.ParentId == null).ToList();
            }
        }
        [NotMapped]
        [Display(Name = "Tổng số bình luận")]
        public virtual int TotalMessages
        {
            get
            {
                return Thread == null ? 0 : Thread.MsgCount;
            }
        }

        [NotMapped]
        private PostReview postReview;

        [NotMapped]
        [Display(Name = "Biểu quyết")]
        public virtual PostReview PostReview
        {
            get

            {
                if (postReview == null)
                    if (Format == PostFormat.Review)
                        postReview = Content == null ? new PostReview() : JsonConvert.DeserializeObject<PostReview>(Content);

                return postReview;
            }
            set
            {
                if (Format == PostFormat.Review)
                {
                    postReview = value;
                    OnUpdateValues();
                }
            }
        }
        public void OnUpdateValues()
        {
            Content = postReview == null ? null : JsonConvert.SerializeObject(postReview);
        }
    }
}
