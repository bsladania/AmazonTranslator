using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmazonTranslator.Models
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
                TargetLanguages.Add(new SelectListItem() { Text = "Select Language", Value = string.Empty });
                TargetLanguages.Add(new SelectListItem() { Text = "Chinese - Simplified (zh)", Value = "zh" });
                TargetLanguages.Add(new SelectListItem() { Text = "French (fr)", Value = "fr" });
                TargetLanguages.Add(new SelectListItem() { Text = "German (de)", Value = "de" });
            }
        
    }
}