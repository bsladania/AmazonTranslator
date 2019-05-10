
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Amazon.Translate.Model;

namespace AmazonTranslator.Models
{
    public class TranslatedCommentViewModel
    {
        public string SubmitterName { get; set; }
        public string CommentText { get; set; }
        public string TargetLangauge { get; set; }
        public TranslateTextResponse TranslateResponse { get; set; }
    }
}