using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller

  {
        [Route("/")]
        public ActionResult Hello()
        {
          LetterVariable myLetterVariable = new LetterVariable();
          myLetterVariable.SetRecipient("Eric");
          myLetterVariable.SetSender("John");
          return View(myLetterVariable);
        }
        [Route("/journal")]
        public ActionResult Journal()
        {
          return View();
        }
        [Route("/vacation_form")]
        public ActionResult VacationForm()
        {
          return View();
        }
        [Route("/vacation")]
        public ActionResult Vacation()
        {
          LetterVariable myLetterVariable = new LetterVariable();
          myLetterVariable.SetLocation(Request.Query["location"]);
          myLetterVariable.SetItems(Request.Query["items"]);
          return View("VacationList", myLetterVariable);
        }
        
        [Route("/form")]
        public ActionResult Form()
        {
          return View();
        }
        [Route("/greeting_card")]
        public ActionResult GreetingCard()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetRecipient(Request.Query["recipient"]);
            myLetterVariable.SetSender(Request.Query["sender"]);
            return View("Hello", myLetterVariable);
        }
    }
  }
