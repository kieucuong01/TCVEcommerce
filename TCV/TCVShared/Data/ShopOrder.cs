using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TCVShared.Data
{
    public class ShopAddress
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        [Display(Name = "Điện thoại")]
        public string Phone { get; set; }

        [StringLength(256)]
        [Display(Name = "Địa chỉ")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [StringLength(64)]
        [Display(Name = "Thành phố")]
        public string City { get; set; }

        [StringLength(64)]
        [Display(Name = "Tiểu bang")]
        public string State { get; set; }

        [StringLength(64)]
        [Display(Name = "Quốc gia")]
        public string Country { get; set; }

        [StringLength(32)]
        [Display(Name = "Mã zip")]
        public string ZipCode { get; set; }

        [ForeignKey("UserId")]
        public virtual AppUser AppUser { get; set; }
    }

    [Table("ShopOrderItems")]
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ItemId { get; set; }

        [Display(Name = "Số lượng")]
        public int Quantity { get; set; }

        [Display(Name = "Thuộc tính")]
        public string ItemAttrib { get; set; }

        [ForeignKey("OrderId")]
        public virtual ShopOrder ShopOrder { get; set; }

        [ForeignKey("ItemId")]
        public virtual ShopItem ShopItem { get; set; }
    }

    public class ShopOrder
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        [Display(Name = "Thanh toán")]
        public int? BillingId { get; set; }

        [Display(Name = "Giao hàng")]
        public int? ShippingId { get; set; }

        [Display(Name = "Chỉnh giá")]
        public double AdjustPrice { get; set; }

        [Display(Name = "Phí giao hàng")]
        public double ShippingFee { get; set; }

        [Display(Name = "Tổng cộng")]
        public double GrandTotalPrice { get; set; }

        [Display(Name = "Thanh toán")]
        public string PaymentInfo { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime? CreateTime { get; set; }

        [Display(Name = "Ngày giao")]
        public DateTime? DeliveryTime { get; set; }

        [StringLength(256)]
        [Display(Name = "Ghi chú")]
        [DataType(DataType.MultilineText)]
        public string Note { get; set; }

        [Display(Name = "Trạng thái Đơn hàng")]
        public OrderStatus OrderStatus { get; set; }

        [Display(Name = "Trạng thái Thanh toán")]
        public PaymentStatus PaymentStatus { get; set; }

        [ForeignKey("UserId")]
        public virtual AppUser AppUser { get; set; }

        [ForeignKey("BillingId")]
        public virtual ShopAddress Billing { get; set; }

        [ForeignKey("ShippingId")]
        public virtual ShopAddress Shipping { get; set; }

        [Display(Name = "Sản phẩm")]
        public virtual ICollection<OrderItem> Items { get; set; }
    }
}
