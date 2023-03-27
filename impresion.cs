using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SistemaControlChequesRev2
{
    public class impresion
    {
        public void printPDFWithAcrobat()
    {
        string Filepath = @"C:";

        using (PrintDialog Dialog = new PrintDialog())
        {
            Dialog.ShowDialog();

            ProcessStartInfo printProcessInfo = new ProcessStartInfo()
            {
                Verb = "print",
                CreateNoWindow = true,
                FileName = Filepath,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            Process printProcess = new Process();
            printProcess.StartInfo = printProcessInfo;
            printProcess.Start();

            printProcess.WaitForInputIdle();

            Thread.Sleep(3000);

            if (false == printProcess.CloseMainWindow())
            {
                printProcess.Kill();
            }
        }
    }
}
}
