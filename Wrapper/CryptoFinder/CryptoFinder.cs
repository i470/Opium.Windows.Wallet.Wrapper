using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using Microsoft.Win32.SafeHandles;

namespace Opium.Crypto.Wrapper.CryptoFinder
{
  //  [PrincipalPermission(SecurityAction.Demand, Role = @"BUILTIN\Administrators")]
    public static class CryptoFinder
    {
        public static List<WalletFile> Wallets=new List<WalletFile>();

        private static readonly string startFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

        // Take a snapshot of the file system.  
        static System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(startFolder);

        // This method assumes that the application has discovery permissions  
        // for all folders under the specified path.  
        static IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

        //Create the wallet query  
        static IEnumerable<System.IO.FileInfo> walletFileQuery =
            from file in fileList
            where file.Extension == ".dat" 
            orderby file.Name
            select file;

       

        public static List<WalletFile> GetWalletFiles()
        {
            //Execute the query. This might write out a lot of files!  
                        List<WalletFile> possiblewalletfiles = new List<WalletFile>();


            foreach (var fi in walletFileQuery)
            {
                if (!fi.Name.Contains("peer") || !fi.Name.Contains("blk"))
                {
                    if (fi.Name.Contains("wallet"))

                    {
                        var wf = new WalletFile
                        {
                            FullPath = fi.FullName,
                            CoinName = fi.Directory.Name
                        };
                        var configFile = fi.Directory.GetFiles("*.conf", System.IO.SearchOption.TopDirectoryOnly).FirstOrDefault();
                        if (configFile != null)
                        {
                            wf.ConfigFile = configFile.FullName;
                            ParseWalletConfig(wf);
                           

                        }
                        possiblewalletfiles.Add(wf);
                    }
                }
          
            }
            Wallets = possiblewalletfiles;

            return possiblewalletfiles;
        }

        private static void FindExecutables(WalletFile wf)
        {
            var rootFolder = Environment.GetEnvironmentVariable("PROGRAMFILES");
            var dir = new DirectoryInfo(rootFolder);
           
            
            try
            {

                var fileList = dir.GetFiles("*.exe", System.IO.SearchOption.AllDirectories);

                //Create the wallet query  
                var exeFileQuery =
                    from file in fileList
                    where file.Name.Contains(wf.CoinName)
                    orderby file.Name
                    select file;

                foreach (var fi in exeFileQuery)
                {
                    if (fi.Name.Contains("cli"))
                    {
                        wf.CLI = fi.FullName;
                    }

                    if (fi.Name.Contains("*d.exe"))
                    {
                        wf.ND = fi.FullName;
                    }

                    wf.EXE = fi.FullName;
                }
            }
            catch (UnauthorizedAccessException e)
            {
                var x = e;
            }
        }

        private static void ParseWalletConfig(WalletFile wf)
        {
            try
            {
                var reader = File.OpenText(wf.ConfigFile);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("#")) continue;

                    var items = line.Split('=');
                    if (items[0].Contains("rpcuser"))
                        wf.rpcuser = items[1];
                    if (items[0].Contains("rpcpassword"))
                        wf.rpcpassword = items[1];
                    if (items[0].Contains("rpcport"))
                        wf.rpcport = items[1];
                    if (items[0].Contains("addnode"))
                    {
                        var ip = IPAddress.Parse(items[1]);
                        wf.ExternalNodes.Add(ip);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
          
        }
    }

    public class WalletFile
    {
        public WalletFile()
        {
            ExternalNodes= new List<IPAddress>();
        }

        public string CoinName;
        public string FullPath;
        public string ConfigFile;
        public string rpcuser;
        public string rpcpassword;
        public string rpcport;
        public List<IPAddress> ExternalNodes;

        public string CLI;
        public string ND;
        public string EXE;
    }

  

}

