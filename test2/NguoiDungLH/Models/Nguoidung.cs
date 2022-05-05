namespace NguoiDungLH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nguoidung")]
    public partial class Nguoidung
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string hoten { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(12)]
        public string dienthoai { get; set; }

        [StringLength(50)]
        public string noidung { get; set; }
    }
}
