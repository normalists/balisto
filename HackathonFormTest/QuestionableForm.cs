﻿using HackathonClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackathonFormTest
{
    public partial class QuestionableForm : Form
    {
        private MainForm parent;

        public QuestionableForm()
        {
            InitializeComponent();
        }

        public void SetUpForm()
        {
            parent = Program.GetMainForm();
        }


        internal void InformQuestioned(QuestionedPriceFeedItem feedItem)
        {
            questionedListBox.Items.Add(feedItem);
        }

        private void QuestionableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.ToggleQuestionableDisplay();
            e.Cancel = true;
        }

        internal QuestionedPriceFeedItem GetNextIssue(int quickTerminalId)
        {
            //bool found = false;
            int index = 0;
            while (questionedListBox.Items.Count > index)
            {
                QuestionedPriceFeedItem item = (QuestionedPriceFeedItem)questionedListBox.Items[index];
                if (!item.ReadBy(quickTerminalId) && item.GetWorkerCount() < 2)
                {
                    item.Checkout(quickTerminalId);
                    return (QuestionedPriceFeedItem)questionedListBox.Items[index];
                }

                index++;
            }

            return null;
        }

        internal void CancelWork(QuestionedPriceFeedItem currentIssue, int quickTerminalId)
        {
            ((QuestionedPriceFeedItem)questionedListBox.Items[questionedListBox.Items.IndexOf(currentIssue)]).CancelWork(quickTerminalId);
        }



        internal void InformDealtWith(QuestionedPriceFeedItem questionedFeedItem)
        {
            questionedListBox.Items.Remove(questionedFeedItem);
        }


    }
}
