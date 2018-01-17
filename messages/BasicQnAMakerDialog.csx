

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;
using System.Linq;
using System.Net;

// For more information about this template visit http://aka.ms/azurebots-csharp-qnamaker


    [Serializable]
   public class BasicQnAMakerDialog : QnAMakerDialog
{   
    
  /*  public static string MessageText ="<div style='padding:20px'><p> i didnt get you</p><h4>Here are some things i can help you with</h4>\n\n<a href='https://www.w3schools.com/html/'>Visit our HTML tutorial</a>  \n\n<a href='https://www.w3schools.com/html/'>Visit our HTML tutorial</a>  \n\n<a href='https://www.w3schools.com/html/'>Visit our HTML tutorial</a> \n\n <a href='https://www.w3schools.com/html/'>Visit our HTML tutorial</a>\n\n  <a href='https://share.ey.net/sites/app/Pages/index.html#/details/187' target=_blank>Visit our HTML tutorial</a></div>";
   */
   public static string MessageBot ="I could not understand your query, Please visit the [FAQ](https://us.internal.eyqa.net/sites/badges/Pages/index.html#/help) page for more details";
    
    // Go to https://qnamaker.ai and feed data, train & publish your QnA Knowledgebase.
    public BasicQnAMakerDialog() : base(new QnAMakerService(new QnAMakerAttribute(Utils.GetAppSetting("QnASubscriptionKey"), Utils.GetAppSetting("QnAKnowledgebaseId"),MessageBot)))
    {
        
    }
}
    
    
 
         