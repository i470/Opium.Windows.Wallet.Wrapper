using System.ComponentModel.Composition;
using System.Diagnostics;
using System.IO;
using System.Windows;
using Opium.Crypto.Wrapper.CryptoFinder;
using Prism.Mvvm;

namespace Opium.Wallet
{
    [Export]
    public class ShellViewModel: BindableBase
    {
        public ShellViewModel()
        {
            //var wallets = CryptoFinder.GetWalletFiles();

            //var proc = new Process
            //{
            //    StartInfo = new ProcessStartInfo
            //    {
            //        FileName = @"C:\Users\Inga Bemman\Downloads\BitcoinPrivateDesktopWallet_1.0.4_windows\btcpd.exe",
            //        UseShellExecute = false,
            //        RedirectStandardOutput = true,
            //        CreateNoWindow = true,
            //       }
            //};

            //proc.EnableRaisingEvents = true;
            //proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //proc.OutputDataReceived += new DataReceivedEventHandler(OnDataReceived);
            //proc.ErrorDataReceived += new DataReceivedEventHandler(OnDataReceived);
            //proc.Start();

            //proc.BeginOutputReadLine();
            //proc.BeginErrorReadLine();

            // Send a directory command and an exit command to the shell
           // proc.StandardInput.WriteLine("getinfo");
           // proc.StandardInput.WriteLine("exit");

           // proc.WaitForExit();
            //  StreamWriter inputStream = proc.StandardInput;
            //send command to cmd prompt and wait for command to execute with thread sleep
            //   inputStream.WriteLine("getinfo");
            //    inputStream.Flush();
        }

        private void OnDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                MessageBox.Show(e.Data);
            }
        }
    }
}
