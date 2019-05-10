using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Amazon.Translate.Model;

namespace AmazonTranslator.Models
{
    public class ViewModel
    {
        public class TranslateCommentViewModel
        {
            public string SubmitterName { get; set; }
            public string CommentText { get; set; }
            public string TargetLanguage { get; set; }
            public List<SelectListItem> TargetLanguages { get; set; }
            public TranslateCommentViewModel()
            {
                // Set up the target language select
                TargetLanguages = new List<SelectListItem>();
                TargetLanguages.Add(new SelectListItem() { Text = "Select...", Value = string.Empty });
                TargetLanguages.Add(new SelectListItem() { Text = "Chinese - Simplified (zh)", Value = "zh" });
                TargetLanguages.Add(new SelectListItem() { Text = "French (fr)", Value = "fr" });
                TargetLanguages.Add(new SelectListItem() { Text = "German (de)", Value = "de" });
            }
        }

        public class TranslatedCommentViewModel
        {
            public string SubmitterName { get; set; }
            public string CommentText { get; set; }
            public string TargetLangauge { get; set; }
            public TranslateTextResponse TranslateResponse { get; set; }
        }

    }
}