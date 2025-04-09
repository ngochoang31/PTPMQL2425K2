
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Models;

namespace MvcMovie.Controllers{
    public class ScoreSubjectController:Controller{
        public IActionResult Index(){
            return View();
        }
        [HttpPost]
        public IActionResult Index(ScoreSubject sc){
            if(sc.pointC <=0 ||sc.pointB <=0 || sc.pointA <=0){
                @ViewBag.ScoreResult = "Bạn đã trượt môn này!";
            }else if(sc.pointC >10 ||sc.pointB >10 || sc.pointA >10){
                @ViewBag.ScoreResult = "Số điểm vượt quá quy định, vui lòng nhập lại!";
            }else{
                double result = 0.1*sc.pointC + sc.pointB * 0.3 + sc.pointA*0.6;
                string strOutput="Điểm môn học là: " + result;
                @ViewBag.ScoreResult = strOutput;
            }

          
            return View();
        }
    }
}
