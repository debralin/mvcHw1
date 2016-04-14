using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day1Homework.Models.ViewModels
{
    public class ListViewModel
    {
        //透過DisplayName屬性標籤呈現List資料表頭名稱, 
        //WAY 1: [DisplayName("種類")] 但要加入using System.ComponentModel
        [DisplayName("種類")]
        public string Category { get; set; }

        //否則表頭會秀 SET 屬性的名, EX: Category

        [DisplayName("金額")]
        public double Money { get; set; }

        //WAY2 :  [Display(Name = "日期")]但要加入using System.ComponentModel.DataAnnotations;
        [Display(Name = "日期")]
        public DateTime Date { get; set; }

        [Display(Name = "備註")]
        public string Description { get; set; }
    }
}