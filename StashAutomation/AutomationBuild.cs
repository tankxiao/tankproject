using System.Windows.Automation;
using System.Windows.Automation.Provider;
using System.Windows.Automation.Text;
//using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace StashAutomation
{
    public class AutomationBuild
    {
        public static AutomationElement FindWindowByName(AutomationElement rootElement, string name, ControlType type)
        {
            PropertyCondition nameCondition = new PropertyCondition(AutomationElement.NameProperty, name);

            PropertyCondition typeCondition = new PropertyCondition(AutomationElement.ControlTypeProperty, type);

            AndCondition andCondition = new AndCondition(nameCondition, typeCondition);

            return rootElement.FindFirst(TreeScope.Element | TreeScope.Descendants, andCondition);
        }

        public static AutomationElement FindElementById(AutomationElement parentElement, string automationID, ControlType type)
        {
            PropertyCondition typeCondition = new PropertyCondition(AutomationElement.ControlTypeProperty, type);

            PropertyCondition IDCondition = new PropertyCondition(AutomationElement.AutomationIdProperty, automationID);

            AndCondition andCondition = new AndCondition(typeCondition, IDCondition);

            return parentElement.FindFirst(TreeScope.Element | TreeScope.Descendants, andCondition);

        }

        public static AutomationElementCollection FindElementByClassName(AutomationElement parentElement, string className, ControlType type)
        {
            PropertyCondition typeCondition = new PropertyCondition(AutomationElement.ControlTypeProperty, type);

            PropertyCondition IDCondition = new PropertyCondition(AutomationElement.ClassNameProperty, className);

            AndCondition andCondition = new AndCondition(typeCondition, IDCondition);

            return parentElement.FindAll(TreeScope.Element | TreeScope.Descendants, andCondition);

        }

        public static void SetValue(AutomationElement element, string newValue)
        {
            ValuePattern valuePattern = element.GetCurrentPattern(ValuePattern.Pattern) as ValuePattern;

            valuePattern.SetValue(newValue);
        }

        public static void ClickButton(AutomationElement element)
        {
            InvokePattern invokePattern = element.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;

            invokePattern.Invoke();
        }

        public static string GetText(AutomationElement element)
        {
            string content = string.Empty;

            TextPattern txtPattern = element.GetCurrentPattern(TextPattern.Pattern) as TextPattern;

            if (txtPattern != null)
            {
                content = txtPattern.DocumentRange.GetText(-1);
            }

            return content;
        }

        public static void Select(AutomationElement element)
        {
            SelectionItemPattern selectionItemPattern = element.GetCurrentPattern(SelectionItemPattern.Pattern) as SelectionItemPattern;

            selectionItemPattern.Select();
        }

        public static void Check(AutomationElement element)
        {
           // element.SetFocus();
            //SendKeys.SendWait(" ");

            TogglePattern togglePattern = element.GetCurrentPattern(TogglePattern.Pattern) as TogglePattern;

           togglePattern.Toggle();
        }
    }
}
