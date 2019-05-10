using Amazon;
using Amazon.Translate;
using Amazon.Translate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmazonTranslator.Models;

namespace AmazonTranslator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddComment()
        {
            var model = new TranslateCommentViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult TranslateComment(TranslateCommentViewModel comment)
        {
            var translate = new AmazonTranslateClient("AKIAZXJXTSK2EDSZC7PL", "nmumsa2yN3ZOLqeXAdnIi6ALPCpq20u+NyytJk+J", RegionEndpoint.USEast1);
            var request = new TranslateTextRequest() { Text = comment.CommentText, SourceLanguageCode = "en", TargetLanguageCode = comment.TargetLanguage };
            var model = new TranslatedCommentViewModel()
            {
                CommentText = comment.CommentText,
                SubmitterName = comment.SubmitterName,
                TargetLangauge = comment.TargetLanguage,
                TranslateResponse = translate.TranslateText(request) // Make the actual call to Amazon Translate
            };
            return View(model);
        }
    }
}