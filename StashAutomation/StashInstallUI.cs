using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Automation;
using System.Threading;

namespace StashAutomation
{
    public class StashInstallUI
    {
        public const int waitTime = 20;

        private AutomationElement _Main;

        public AutomationElement Main
        {
            get
            {
                Thread.Sleep(1000);
                _Main = AutomationBuild.FindElementByClassName(AutomationElement.RootElement, "MsiDialogCloseClass", ControlType.Window)[0];
                for (int i = 0; i < waitTime; i++)
                {
                    if (_Main == null)
                    {
                        Thread.Sleep(1000);
                        _Main = AutomationBuild.FindElementByClassName(AutomationElement.RootElement, "MsiDialogCloseClass", ControlType.Window)[0];
                    }
                    else
                    {
                        break;
                    }
                }

                return _Main;
            }
            set { _Main = value; }
        }

        private AutomationElement _MainSetup;

        public AutomationElement MainSetup
        {
            get
            {
                Thread.Sleep(1000);
                _MainSetup = AutomationBuild.FindElementByClassName(AutomationElement.RootElement, "wxWindowClassNR", ControlType.Window)[0];
                for (int i = 0; i < waitTime; i++)
                {
                    if (_Main == null)
                    {
                        Thread.Sleep(1000);
                        _MainSetup = AutomationBuild.FindElementByClassName(AutomationElement.RootElement, "wxWindowClassNR", ControlType.Window)[0];
                    }
                    else
                    {
                        break;
                    }
                }

                return _MainSetup;
            }
            set { _MainSetup = value; }
        }

        private AutomationElement nextButton;

        public AutomationElement NextButton
        {
            get
            {
                nextButton = null;
                for (int i = 0; i < waitTime; i++)
                {

                    if (nextButton == null)
                    {
                        Thread.Sleep(1000);
                        nextButton = AutomationBuild.FindWindowByName(this.Main, "Next", ControlType.Button);
                    }
                    else
                    {
                        break;
                    }
                }

                return nextButton;
            }
            set { nextButton = value; }
        }

        private AutomationElement acceptChb;

        public AutomationElement AcceptChb
        {
            get
            {
                for (int i = 0; i < waitTime; i++)
                {
                    if (acceptChb == null)
                    {
                        Thread.Sleep(1000);
                        acceptChb = AutomationBuild.FindWindowByName(this.Main, "I accept the terms in the License Agreement", ControlType.CheckBox);
                    }
                    else
                    {
                        break;
                    }
                }

                return acceptChb;
            }
            set
            {
                acceptChb = value;
            }
        }

        private AutomationElement installButton;

        public AutomationElement InstallButton
        {
            get
            {
                for (int i = 0; i < waitTime; i++)
                {
                    if (installButton == null)
                    {
                        Thread.Sleep(1000);
                        installButton = AutomationBuild.FindWindowByName(this.Main, "Install", ControlType.Button);
                    }
                    else
                    {
                        break;
                    }
                }

                return installButton;
            }
            set
            {
                installButton = value;
            }
        }

        private AutomationElement finishButton;

        public AutomationElement FinishButton
        {
            get
            {
                for (int i = 0; i < waitTime; i++)
                {
                    if (finishButton == null)
                    {
                        Thread.Sleep(1000);
                        finishButton = AutomationBuild.FindWindowByName(this.Main, "Finish", ControlType.Button);
                    }
                    else
                    {
                        break;
                    }
                }

                return finishButton;
            }
            set
            {
                finishButton = value;
            }
        }
    }
}
