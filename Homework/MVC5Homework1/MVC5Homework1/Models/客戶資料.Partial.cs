namespace MVC5Homework1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(客戶資料MetaData))]
    public partial class 客戶資料
    {
        //public int 聯絡人數量
        //{
        //    get
        //    {
        //        //return this.OrderLine.Count;
        //        //因為不是直接從Entity時做出來的東東，所以沒有導覽屬性可以用，須改寫如下:
        //        using (var db = new 客戶資料Entities())
        //        {
        //            int item = db.客戶資料.Find(this.Id)

        //            return item;
        //        }
        //    }
        //}

        //public int 銀行帳戶數量
        //{
        //    get
        //    {
        //        //return this.OrderLine.Count;
        //        //因為不是直接從Entity時做出來的東東，所以沒有導覽屬性可以用，須改寫如下:
        //        using (var db = new 客戶資料Entities())
        //        {
        //            return db.客戶資料.Find(Id).客戶銀行資訊.Count;
        //        }
        //    }
        //}
    }
    
    public partial class 客戶資料MetaData
    {
        [Required]
        public int Id { get; set; }
        
        [StringLength(50, ErrorMessage="客戶名稱不得大於 50 個字元")]
        [Required]
        public string 客戶名稱 { get; set; }
        
        [StringLength(8, ErrorMessage="統一編號須為 8 個字元")]
        [Required]
        public string 統一編號 { get; set; }
        
        [StringLength(10, ErrorMessage="電話長度錯誤")]
        [Required]
        public string 電話 { get; set; }
        
        [StringLength(50, ErrorMessage="傳真號碼長度錯誤")]
        public string 傳真 { get; set; }
        
        [StringLength(100, ErrorMessage="地址長度不得大於 100 個字元")]
        public string 地址 { get; set; }
        
        [EmailAddress(ErrorMessage ="非電子信箱格式")]
        [StringLength(250, ErrorMessage="欄位長度不得大於 250 個字元")]
        public string Email { get; set; }
    
        public virtual ICollection<客戶銀行資訊> 客戶銀行資訊 { get; set; }
        public virtual ICollection<客戶聯絡人> 客戶聯絡人 { get; set; }
    }
}
