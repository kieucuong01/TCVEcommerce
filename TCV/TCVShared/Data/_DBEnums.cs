using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TCVShared.Helpers;

namespace TCVShared.Data
{
    public enum EntityStatus
    {
        [Display(Name = "Không rõ"), StatusCss("default")]
        None,
        [Display(Name = "Hoạt động"), StatusCss("success")]
        Enabled,
        [Display(Name = "Tạm ngưng"), StatusCss("warning")]
        Disabled,
        [Display(Name = "Hết hạn"), StatusCss("danger")]
        Expiried,
        [Display(Name = "Thử nghiệm"), StatusCss("info")]
        Testing,
    }

    public enum UserMode
    {
        None,
        Locked,
        Unlocked,
        Unlocking,
    }
    public enum UserAction
    {
        None,
        Register,
        ChangePass,
        ChangeEmail,
        VerifyEmail,
        ChangePhone,
        VerifyPhone,
        RequestOTP,
        ExternalAddLogin,
        ExternalRemoveLogin,
        ExternalSetPassword,
        UpdateProfile,
        UpdateAllInfo,
        LockAccount,
        UnlockAccount,
        UnlockAccountDone,
        ForgotPassword,
        ResetPassByEmail,
        ResetPassByPhone,
    }
    public enum TaxoType
    {
        PostCat,
        PostTag,
        ItemCat,
        ItemTag,
    }
    public enum PostFormat
    {
        [Display(Name = "Thông thường")]
        Standard,

        [Display(Name = "Thư viện hình")]
        Gallery,

        [Display(Name = "Bài Video")]
        Video,

        [Display(Name = "Bài Review")]
        Review,

        [Display(Name = "Link ngoài")]
        ExtLink,
    }

    public enum PostStatus
    {
        [Display(Name = "Tin đã khóa")]
        Suspended = -1,

        [Display(Name = "Chờ đăng tin")]
        Pending,

        [Display(Name = "Tin thường")]
        Normal,

        [Display(Name = "Đặc biệt")]
        Special,
    }
}
