
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Models;
namespace MvcMovie.Controllers;
    public class BillController:Controller{
        public IActionResult Index(){
            return View();
        }
        [HttpPost]
        public IActionResult Index (Bill bi){
            if(bi.donGia>0 || bi.soLuong >0){
                double tong = bi.donGia*bi.soLuong;
                @ViewBag.tongtien ="Sản phẩm " + bi.tenSp +", tổng số tiền bạn phải trả là: " + tong +" VND";
                
            }else{
                @ViewBag.tongtien = "Vui lòng nhập lại!";
            
            }
            return View();
        }
    }
