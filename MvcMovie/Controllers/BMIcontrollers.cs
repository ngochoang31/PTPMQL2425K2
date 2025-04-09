using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class BMIController:Controller{
        public IActionResult Index(){
            return View();
        }
        [HttpPost]
        public IActionResult Index(BMI bmi){
            double bmiResult = (bmi.Weight/(bmi.Height * bmi.Height));
            string strOutput = "Chỉ số BMI của bạn là: "+bmiResult;
            if(bmi.Weight <=0 || bmi.Height <=0){
                ViewBag.BMIResult="Vui lòng nhập lại!";
            }else{
                if(bmiResult <18.5){
                    @ViewBag.BMIResult=strOutput +" Gầy";
                }
                else if(bmiResult <24.9){
                    @ViewBag.BMIResult=strOutput + " Bình thường";
                }            
                else if(bmiResult <29.9){
                    @ViewBag.BMIResult=strOutput + " Thừa cân";
                }
                else{
                    @ViewBag.BMIResult=strOutput + " Béo phì";
                }
            }
            return View();
            
        }
    }
}
                        