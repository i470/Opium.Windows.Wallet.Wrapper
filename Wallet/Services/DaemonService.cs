using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Opium.Wallet.Services
{
    public static class DaemonService
    {
    //    private static Process dSever;
    //    private static Process cliClient;

    //    public JObject GetDaemonRawRuntimeInfo()
    //    {
            
    //    }


    //    public String getZPrivateKey(String address)
    //    {
            
    //    }
    //    throws WalletCallException, IOException, InterruptedException {
    //        String response = this.executeCommandAndGetSingleStringResponse(
    //            "z_exportkey", wrapStringParameter(address));

    //        return response.trim();
    //    }

    //public static void StartDaemon()
    //    {
    //        var startInfo = new ProcessStartInfo
    //        {
    //            FileName = getDServer(),
    //            Arguments = "",
    //            RedirectStandardOutput = true,
    //            RedirectStandardError = true,
    //            UseShellExecute = false,
    //            CreateNoWindow = true
    //        };

    //        var dServer = new Process
    //        {
    //            StartInfo = startInfo,
    //            EnableRaisingEvents = true
    //        };
    //        try
    //        {
    //            dServer.Start();
    //            dServer.StandardInput.WriteLine("d server started");
    //            dServer.StandardInput.Flush();
    //            dServer.StandardInput.Close();
    //            dServer.WaitForExit();
    //        }
    //        catch (Exception e)
    //        {
    //            throw;
    //        }
    //    }
    //    public static void StopDaemon()
    //    {
            
    //    }


        /// <summary>
        /// returns name of *d process (zcashd, bitcoind, etc)
        /// </summary>
        /// <returns></returns>
        private static string getDServer()
        {
            var dServer = "";
            if (string.IsNullOrEmpty(dServer)) throw new ArgumentNullException();

            var sb = new StringBuilder();
            sb.Append(dServer);
            sb.Append(@".exe");
            return sb.ToString();
        }

        /// <summary>
        /// returns name of cli process (zcash-cli, bitcoin-cli, etc)
        /// </summary>
        /// <returns></returns>
        private static string GetCli()
        {

            var cli = "";
            if (string.IsNullOrEmpty(cli)) throw new ArgumentNullException();

            var sb = new StringBuilder();
            sb.Append(cli);
            sb.Append(@".exe");
            return sb.ToString();
        }


        private static string WrapStringParameter(String param)
        {
          //  param = "\"" + param.replace("\"", "\\\"") + "\"";
            return param;
    }

    }
}
