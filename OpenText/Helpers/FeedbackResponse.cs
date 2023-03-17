using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace OpenText.Helpers
{
    internal class FeedbackResponse
    {

        public static void ShowFeedbackMessage(ToolStripLabel feedbackLabel, System.Windows.Forms.Timer feedbackTimer, string message)
        {
            feedbackTimer = new System.Windows.Forms.Timer();
            feedbackTimer.Interval = 3000;
            feedbackTimer.Tick += (sender, e) => feedbackTimer_Tick(feedbackLabel, feedbackTimer, e);

            feedbackLabel.Text = message;
            feedbackLabel.Visible = true;
            feedbackLabel.Tag = feedbackTimer;
            feedbackTimer.Start();
        }

        public static void feedbackTimer_Tick(ToolStripLabel feedbackLabel, System.Windows.Forms.Timer feedbackTimer, EventArgs e)
        {
            feedbackLabel.Text = "";
            feedbackLabel.Visible = false;
            feedbackTimer.Stop();
        }

    }
}
