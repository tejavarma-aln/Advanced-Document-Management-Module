using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentLinker
{
    public class Dlinker
    {

        public String LaunchDialog(int multiselect)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                OpenFileDialog of = new OpenFileDialog
                {
                    Title = "Select files to link",
                    Multiselect = (multiselect == 1)
                };
                if (of.ShowDialog() == true)
                {
                    foreach (String f in of.FileNames)
                    {
                        sb.Append(f);
                        sb.Append("|");
                    }
                    return sb.ToString();
                }
            }catch(Exception ex)
            {
                return "Error|" + ex.Message;
            }

            return "OPFAILED|";
        }

    }
}
