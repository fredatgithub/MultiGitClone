using System;
using System.IO;

namespace MultiGitClone
{
  class Program
  {
    static void Main()
    {
      Action<string> display = Console.WriteLine;
      display("Multi GIT Clone");
      var urlGitClone = "https://github.com/francoistonic/programmez";
      var urlGitCloneEndString = ".git";
      var gitCloneStartNumber = 232;
      var gitCloneEndNumber = 242;
      display($"Starting to clone from {gitCloneStartNumber}");
      for (int i = gitCloneStartNumber; i <= gitCloneEndNumber; i++)
      {
        if (File.Exists(ExtractUrl(urlGitClone + i)))
        {
          // start a git update

        }
        else
        {
          // create a git clone url

        }
      }

      display("Press any key to exit:");
      Console.ReadKey();
    }

    public static string ExtractUrl(string url)
    {
      var tmpList = url.Split('/');
      return tmpList[tmpList.Length];
    }
  }
}
