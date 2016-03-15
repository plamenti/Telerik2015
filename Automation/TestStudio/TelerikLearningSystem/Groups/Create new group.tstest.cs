using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace TelerikLearningSystem
{

    public class Create_new_group : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        //[CodedStep(@"Verify 'TextContent' 'Contains' 'Групи за присъствено участие в курсове' on 'ГрупиЗаH1Tag'")]
        //public void Create_new_group_CodedStep()
        //{
            //// Verify 'TextContent' 'Contains' 'Групи за присъствено участие в курсове' on 'ГрупиЗаH1Tag'
            //Pages.ГрупиЗаПрисъственоУчастие.ГрупиЗаH1Tag.AssertContent().TextContent(ArtOfTest.Common.StringCompareType.Contains, "Групи за присъствено участие в курсове");
            
        //}
    
        //[CodedStep(@"Wait for 'TextContent' 'Contains' 'Групи за присъствено участие в курсове' on 'ГрупиЗаH1Tag'")]
        //public void Create_new_group_CodedStep1()
        //{
            //// Wait for 'TextContent' 'Contains' 'Групи за присъствено участие в курсове' on 'ГрупиЗаH1Tag'
            //Pages.ГрупиЗаПрисъственоУчастие.ГрупиЗаH1Tag.BaseElement.Wait.ForCondition((a_0, a_1) => ArtOfTest.Common.CompareUtils.StringCompare(a_0.TextContent, "Групи за присъствено участие в курсове", ArtOfTest.Common.StringCompareType.Contains), false, null, 30000);
            
        //}
    
        [CodedStep(@"Click 'UpdateLink'")]
        public void Create_new_group_CodedStep()
        {
            // Click 'UpdateLink'
            System.Threading.Thread.Sleep(2000);
            Pages.ГрупиЗаПрисъственоУчастие.UpdateLink.Click(false);
            
        }
    
        [CodedStep(@"Click '100000ListItem'")]
        public void Create_new_group_CodedStep1()
        {
            // Click '100000ListItem'
            System.Threading.Thread.Sleep(1000);
            Pages.ГрупиЗаПрисъственоУчастие._100000ListItem.Click(false);
            
        }
    
        [CodedStep(@"Click 'SelectSpan'")]
        public void Create_new_group_CodedStep2()
        {
            // Click 'SelectSpan0'
            System.Threading.Thread.Sleep(1000);
            Pages.ГрупиЗаПрисъственоУчастие.SelectSpan0.Click(false);
            
        }
    
        [CodedStep(@"Click 'СъздаванеНаLink'")]
        public void Create_new_group_CodedStep3()
        {
            // Click 'СъздаванеНаLink'
            System.Threading.Thread.Sleep(1000);
            Pages.ГрупиЗаПрисъственоУчастие.СъздаванеНаLink.Click(false);
            
        }
    
        [CodedStep(@"Enter text 'Трета група' in 'NameText'")]
        public void Create_new_group_CodedStep4()
        {
            // Enter text 'Трета група' in 'NameText'
            System.Threading.Thread.Sleep(1000);
            Actions.SetText(Pages.ГрупиЗаПрисъственоУчастие.NameText, "Трета група");
            
        }
    
        [CodedStep(@"Click 'SelectSpan'")]
        public void Create_new_group_CodedStep5()
        {
            // Click 'SelectSpan'
            System.Threading.Thread.Sleep(1000);
            Pages.ГрупиЗаПрисъственоУчастие.SelectSpan.Click(false);
            
        }
    
        [CodedStep(@"Click 'CPartIIListItem'")]
        public void Create_new_group_CodedStep6()
        {
            // Click 'CPartIIListItem'
            System.Threading.Thread.Sleep(1000);
            Pages.ГрупиЗаПрисъственоУчастие.CPartIIListItem.Click(false);
            
        }
    
        [CodedStep(@"Click 'Span'")]
        public void Create_new_group_CodedStep7()
        {
            // Click 'Span'
            System.Threading.Thread.Sleep(1000);
            Pages.ГрупиЗаПрисъственоУчастие.Span.Click(false);
            
        }
    
        [CodedStep(@"Click 'ВторникListItem'")]
        public void Create_new_group_CodedStep8()
        {
            // Click 'ВторникListItem'
            System.Threading.Thread.Sleep(1000);
            Pages.ГрупиЗаПрисъственоУчастие.ВторникListItem.Click(false);
            
        }
    
        [CodedStep(@"Click 'SelectSpan'")]
        public void Create_new_group_CodedStep9()
        {
            // Click 'SelectSpan1'
            System.Threading.Thread.Sleep(1000);
            Pages.ГрупиЗаПрисъственоУчастие.SelectSpan1.Click(false);
            
        }
    
        [CodedStep(@"Click '14DecemberLink'")]
        public void Create_new_group_CodedStep10()
        {
            // Click '14DecemberLink'
            System.Threading.Thread.Sleep(1000);
            Pages.ГрупиЗаПрисъственоУчастие._14DecemberLink.Click(false);
            
        }
    
        [CodedStep(@"Step up on 'WeekLectureNumberNumber' with step'1'")]
        public void Create_new_group_CodedStep11()
        {
            // Step up on 'WeekLectureNumberNumber' with step'1'
            if (!Double.IsNaN(Pages.ГрупиЗаПрисъственоУчастие.WeekLectureNumberNumber.ValueAsNumber))
            {
                    Pages.ГрупиЗаПрисъственоУчастие.WeekLectureNumberNumber.StepUp(1);
            } else
            {
                    Pages.ГрупиЗаПрисъственоУчастие.WeekLectureNumberNumber.SetValue("value", Pages.ГрупиЗаПрисъственоУчастие.WeekLectureNumberNumber.Min);
            }
            
        }
    }
}
